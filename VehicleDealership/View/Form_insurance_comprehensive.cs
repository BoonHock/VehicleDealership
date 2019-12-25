using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Datasets;
using VehicleDealership.Classes;

namespace VehicleDealership.View
{
	public partial class Form_insurance_comprehensive : Form
	{
		public Form_insurance_comprehensive()
		{
			InitializeComponent();
		}
		private void Form_insurance_comprehensive_Shown(object sender, EventArgs e)
		{
			bool can_add_edit = Program.System_user.
				Has_permission(Class_enum.User_permission.INSURANCE_COMPREHENSIVE_ADD_EDIT);
			bool can_view = Program.System_user.
				Has_permission(Class_enum.User_permission.INSURANCE_COMPREHENSIVE_VIEW);

			if (!(can_add_edit || can_view))
			{
				MessageBox.Show("ACCESS DENIED", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}

			btn_add.Enabled = can_add_edit;
			btn_edit.Enabled = can_add_edit;

			Setup_listbox_ins();

			Class_style.Grd_style.Common_style(grd_ins);
		}
		private void Setup_listbox_ins(int preselect = 0)
		{
			listbox_ins.DisplayMember = "title";
			listbox_ins.ValueMember = "insurance_comprehensive";
			listbox_ins.DataSource = Insurance_comprehensive_ds.Select_insurance_comprehensive();

			if (preselect != 0)
				listbox_ins.SelectedValue = preselect;
		}
		private void Btn_add_Click(object sender, EventArgs e)
		{
			using (Form_edit_insurance_comprehensive form_edit =
				new Form_edit_insurance_comprehensive())
			{
				if (form_edit.ShowDialog() == DialogResult.OK)
					Setup_listbox_ins(form_edit.InsuranceComprehensive);
			}
		}

		private void Btn_edit_Click(object sender, EventArgs e)
		{
			if (listbox_ins.SelectedIndex < 0) return;

			using (Form_edit_insurance_comprehensive form_edit =
				new Form_edit_insurance_comprehensive((int)listbox_ins.SelectedValue))
			{
				if (form_edit.ShowDialog() == DialogResult.OK)
					Setup_listbox_ins(form_edit.InsuranceComprehensive);
			}
		}

		private void Listbox_ins_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listbox_ins.SelectedIndex >= 0)
			{
				grd_ins.DataSource = null;
				grd_ins.DataSource = Insurance_comprehensive_rate_ds.
					Select_insurance_comprehensive_rate((int)listbox_ins.SelectedValue, -1);

				Class_datagridview.Set_column_to_money_column(grd_ins, new string[] { "value" });
				grd_ins.AutoResizeColumns();

				if (!Program.System_user.IsDeveloper)
				{
					Class_datagridview.Hide_unnecessary_columns(grd_ins,
						new string[] { "cc_min", "cc_max", "value", "modified_by" });
				}
			}
		}
	}
}
