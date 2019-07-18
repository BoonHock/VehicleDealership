using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Datasets;

namespace VehicleDealership.View
{
	public partial class Form_add_vehicle_brand : Form
	{
		private int _int_brand_id = 0;
		public int BrandID
		{
			get
			{
				return _int_brand_id;
			}
		}
		public int Country
		{
			get
			{
				return int.Parse(cmb_country.SelectedValue.ToString());
			}
		}
		public Form_add_vehicle_brand(int int_brand_id = 0, int int_country = 0)
		{
			InitializeComponent();

			_int_brand_id = int_brand_id;

			cmb_country.DataSource = Combobox_options_ds.Select_country();
			cmb_country.DisplayMember = "display";
			cmb_country.ValueMember = "value";
			if (cmb_country.Items.Count > 0)
			{
				if (int_country != 0)
					cmb_country.SelectedValue = int_country;
				else
					cmb_country.SelectedIndex = 0;
			}

			Classes.Class_style.Grd_style.Common_style(grd_group);
		}

		private void Form_add_vehicle_brand_Load(object sender, EventArgs e)
		{
			Vehicle_group_ds.sp_select_vehicle_group_for_editDataTable dttable_group = Vehicle_group_ds.Select_vehicle_group_for_edit(_int_brand_id);

			grd_group.DataSource = null;
			grd_group.DataSource = dttable_group;
			grd_group.Columns["vehicle_group"].Visible = false;

			if (_int_brand_id == 0) return;

			Vehicle_group_ds.sp_select_vehicle_brand_n_groupDataTable dttable = Vehicle_group_ds.Select_vehicle_brand_n_group(_int_brand_id);

			if (dttable.Rows.Count == 0) return;

			txt_brand_name.Text = dttable.Rows[0]["vehicle_brand_name"].ToString();
			cmb_country.SelectedValue = dttable.Rows[0]["country"];

		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			// reset all grd_group rows back color
			foreach (DataGridViewRow grd_row in grd_group.Rows)
			{
				if (!grd_row.IsNewRow) grd_row.DefaultCellStyle.BackColor = Color.Empty;
			}

			string str_brand_name = txt_brand_name.Text.Trim();
			int int_country = int.Parse(cmb_country.SelectedValue.ToString());

			if (str_brand_name == "")
			{
				MessageBox.Show("Brand name is required!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Vehicle_brand_ds.Is_vehicle_brand_name_available(str_brand_name, _int_brand_id))
			{
				MessageBox.Show("Brand name already existed! Please input new brand name.",
					"Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (cmb_country.SelectedIndex < 0)
			{
				MessageBox.Show("Please select a country.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DataTable dttable_vehicle_group = (DataTable)grd_group.DataSource;

			if (dttable_vehicle_group.Rows.Count == 0)
			{
				MessageBox.Show("At least one vehicle group is required.", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int distinct_group_name_count = (from DataRow row in dttable_vehicle_group.Rows
											 select row["vehicle_group_name"].ToString().ToUpper()).Distinct().ToList().Count;

			if (distinct_group_name_count != dttable_vehicle_group.Rows.Count)
			{
				MessageBox.Show("Duplicate vehicle group found. Please check and retry.",
					"Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (_int_brand_id == 0)
				_int_brand_id = Vehicle_brand_ds.Insert_vehicle_brand(str_brand_name, int_country);
			else
				Vehicle_brand_ds.Update_vehicle_brand(_int_brand_id, str_brand_name, int_country);

			DataColumn dt_col1 = new DataColumn("Created_by", typeof(int));
			dt_col1.DefaultValue = Program.System_user.UserID;

			dttable_vehicle_group.Columns.Add(dt_col1);

			Bulkcopy_table_ds.Delete_by_user();

			using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VehicleDealershipConnectionString))
			{
				conn.Open();

				using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
				{
					bulkCopy.DestinationTableName = "[misc].[bulkcopy_table]";

					try
					{
						bulkCopy.ColumnMappings.Add("vehicle_group", "vehicle_group");
						bulkCopy.ColumnMappings.Add("vehicle_group_name", "vehicle_group_name");
						bulkCopy.ColumnMappings.Add("created_by", "created_by");
						bulkCopy.WriteToServer(dttable_vehicle_group);
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error has occurred. Vehicle groups cannot be updated. \n\n Message: " +
							ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

					}
				}
				conn.Close();
			}

			Vehicle_group_ds.Update_insert_vehicle_group(_int_brand_id);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
