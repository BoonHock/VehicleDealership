using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VehicleDealership.Datasets;

namespace VehicleDealership.View
{
	public partial class Form_edit_vehicle_brand_group : Form
	{
		private int _int_main_id = 0;
		private bool _is_brand = false;
		public int MainID
		{
			get
			{
				return _int_main_id;
			}
		}
		public int ComboboxValue
		{
			get
			{
				return int.Parse(cmb1.SelectedValue.ToString());
			}
		}
		/// <summary>
		/// this form is used to edit vehicle brand or vehicle group
		/// </summary>
		/// <param name="is_brand">set true if editing vehicle brand, else false</param>
		/// <param name="main_id">if editing vehicle brand, pass vehicle brand id, else pass vehicle group id</param>
		/// <param name="cmb_value">combox value to preselect. will be overridden if editing instead of adding</param>
		public Form_edit_vehicle_brand_group(bool is_brand, int main_id = 0, int cmb_value = 0)
		{
			InitializeComponent();

			Classes.Class_style.Grd_style.Common_style(grd_main);

			_int_main_id = main_id;

			_is_brand = is_brand;

			if (_is_brand)
				Setup_form_brand(cmb_value);
			else
				Setup_form_group();
		}
		private void Form_edit_vehicle_brand_group_Shown(object sender, EventArgs e)
		{

		}
		private void Setup_form_brand(int cmb_value)
		{
			label2.Text = "Brand name:";
			label1.Text = "Country:";
			label3.Text = "Vehicle groups:";

			cmb1.DisplayMember = "display";
			cmb1.ValueMember = "value";
			cmb1.DataSource = Combobox_options_ds.Select_country();
			cmb1.SelectedValue = cmb_value;

			Vehicle_group_ds.sp_select_vehicle_group_for_editDataTable dttable_group = Vehicle_group_ds.Select_vehicle_group_for_edit(_int_main_id);

			grd_main.DataSource = null;
			grd_main.DataSource = dttable_group;
			grd_main.Columns["vehicle_group"].Visible = false;

			if (_int_main_id == 0) return;

			Vehicle_group_ds.sp_select_vehicle_brand_n_groupDataTable dttable = Vehicle_group_ds.Select_vehicle_brand_n_group(_int_main_id);

			if (dttable.Rows.Count == 0) return;

			txt_name.Text = dttable.Rows[0]["vehicle_brand_name"].ToString();
			cmb1.SelectedValue = dttable.Rows[0]["country"];
		}
		private void Setup_form_group()
		{
			label2.Text = "Group name:";
			label1.Text = "Brand:";
			label3.Text = "Vehicle models:";

			cmb1.DataSource = null;
			cmb1.DisplayMember = "vehicle_brand_name";
			cmb1.ValueMember = "vehicle_brand";
			cmb1.DataSource = Vehicle_brand_ds.Select_vehicle_brand();

			Vehicle_group_ds.sp_select_vehicle_group_n_modelDataTable dttable = Vehicle_group_ds.Select_vehicle_group_n_model(_int_main_id);
			if (dttable.Rows.Count == 0) return;

			txt_name.Text = dttable.Rows[0]["vehicle_group_name"].ToString();
			cmb1.SelectedValue = dttable.Rows[0]["vehicle_brand"];

			grd_main.DataSource = null;
			grd_main.DataSource = dttable;
			Classes.Class_datagridview.Hide_columns(grd_main, new string[] { "vehicle_group", "vehicle_group_name", "vehicle_brand", "vehicle_model" });
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (_is_brand)
			{
				if (!Save_form_brand()) return;
			}
			else
			{
				// TODO: save form group and models
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private bool Save_form_brand()
		{
			// reset all grd_group rows back color
			foreach (DataGridViewRow grd_row in grd_main.Rows)
			{
				if (!grd_row.IsNewRow) grd_row.DefaultCellStyle.BackColor = Color.Empty;
			}

			string str_brand_name = txt_name.Text.Trim();
			int int_country = int.Parse(cmb1.SelectedValue.ToString());

			if (str_brand_name == "")
			{
				MessageBox.Show("Brand name is required!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (!Vehicle_brand_ds.Is_vehicle_brand_name_available(str_brand_name, _int_main_id))
			{
				MessageBox.Show("Brand name already exists! Please input new brand name.",
					"Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (cmb1.SelectedIndex < 0)
			{
				MessageBox.Show("Please select a country.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			DataTable dttable_vehicle_group = ((DataTable)grd_main.DataSource).Copy();

			if (dttable_vehicle_group.Rows.Count == 0)
			{
				MessageBox.Show("At least one vehicle group is required.", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			int distinct_group_name_count = (from DataRow row in dttable_vehicle_group.Rows
											 select row["vehicle_group_name"].ToString().ToUpper()).Distinct().ToList().Count;

			if (distinct_group_name_count != dttable_vehicle_group.Rows.Count)
			{
				MessageBox.Show("Duplicate vehicle group found. Please check and retry.",
					"Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (_int_main_id == 0)
				_int_main_id = Vehicle_brand_ds.Insert_vehicle_brand(str_brand_name, int_country);
			else
				Vehicle_brand_ds.Update_vehicle_brand(_int_main_id, str_brand_name, int_country);

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

			Vehicle_group_ds.Update_insert_vehicle_group(_int_main_id);
			return true;
		}
	}
}
