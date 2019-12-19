using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Classes;
using VehicleDealership.Datasets;

namespace VehicleDealership.View
{
	public partial class Form_edit_insurance_comprehensive : Form
	{
		public int InsuranceComprehensive { get; private set; } = 0;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ins_comprehensive">ID of insurance comprehensive to edit. 0 to create new</param>
		public Form_edit_insurance_comprehensive(int ins_comprehensive = 0)
		{
			InitializeComponent();

			InsuranceComprehensive = ins_comprehensive;
		}

		private void Form_edit_insurance_comprehensive_Shown(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_COMPREHENSIVE_ADD_EDIT))
			{
				MessageBox.Show("ACCESS DENIED", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}

			if (InsuranceComprehensive != 0)
			{
				using (Insurance_comprehensive_ds.sp_select_insurance_comprehensiveDataTable dttable =
					Insurance_comprehensive_ds.Select_insurance_comprehensive(InsuranceComprehensive))
				{
					if (dttable.Any()) txt_title.Text = dttable[0].title;
				}
			}
			using (Insurance_comprehensive_rate_ds.sp_select_insurance_comprehensive_rateDataTable dttable =
				Insurance_comprehensive_rate_ds.Select_insurance_comprehensive_rate(InsuranceComprehensive, -1))
			{
				// not showing column but column needs value
				dttable.modified_byColumn.DefaultValue = Program.System_user.Name;
				// columns must have value!
				dttable.cc_minColumn.AllowDBNull = false;
				dttable.cc_maxColumn.AllowDBNull = false;
				dttable.valueColumn.AllowDBNull = false;

				grd_ins.DataSource = dttable;
				Class_datagridview.Hide_unnecessary_columns(grd_ins,
					new string[] { "cc_min", "cc_max", "value" });

				Class_datagridview.Set_column_to_money_column(grd_ins, "value");
				grd_ins.Columns["modified_by"].ReadOnly = true;
				grd_ins.Columns["modified_by"].DefaultCellStyle.BackColor = Color.LightGray;
			}
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_COMPREHENSIVE_ADD_EDIT))
			{
				MessageBox.Show("ACCESS DENIED", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}

			string str_title = txt_title.Text.Trim();

			if (str_title.Length == 0)
			{
				MessageBox.Show("Title is required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Insurance_comprehensive_ds.Check_ins_com_title_available(str_title, InsuranceComprehensive))
			{
				MessageBox.Show("Title is already in use. Please enter a new title.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Insurance_comprehensive_rate_ds.sp_select_insurance_comprehensive_rateDataTable dttable_ins =
				(Insurance_comprehensive_rate_ds.sp_select_insurance_comprehensive_rateDataTable)grd_ins.DataSource;

			if (dttable_ins.Rows.Count == 0)
			{
				MessageBox.Show("At least one rate is required.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if ((from row in dttable_ins where row.cc_max < 0 || row.cc_min < 0 select row).Count() > 0)
			{
				MessageBox.Show("Negative CC value is not allowed. Please check and retry.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (InsuranceComprehensive == 0)
			{
				// add
				InsuranceComprehensive = Insurance_comprehensive_ds.Insert_insurance_comprehensive(str_title);

				if (InsuranceComprehensive == 0)
				{
					MessageBox.Show("FAILED TO ADD NEW INSURANCE COMPREHENSIVE.",
						"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				Class_bulkcopy bk = new Class_bulkcopy(dttable_ins)
				{
					INT1 = "cc_min",
					INT2 = "cc_max",
					DECIMAL18_4 = "value"
				};
				bk.Write_to_db();
			}
			else
			{
				// edit
				if (!Insurance_comprehensive_ds.Update_insurance_comprehensive(InsuranceComprehensive, str_title))
				{
					MessageBox.Show("FAILED TO UPDATE INSURANCE COMPREHENSIVE.",
						"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			if (!Insurance_comprehensive_rate_ds.Update_insert_ins_com_rate(InsuranceComprehensive))
			{
				MessageBox.Show("FAILED TO UPDATE INSURANCE COMPREHENSIVE RATES.",
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void Grd_ins_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			e.Cancel = true;
		}
	}
}
