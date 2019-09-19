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
	public partial class Form_datagridview_select : Form
	{
		readonly string _form_type = "";
		readonly string _preselect_value = "";

		public Form_datagridview_select(string form_type, string preselect_value = "", bool select_multiple = false)
		{
			InitializeComponent();

			_form_type = form_type;
			_preselect_value = preselect_value;

			// by default, hide these
			lbl_type.Visible = false;
			cmb_type.Visible = false;

			grd_main.MultiSelect = select_multiple;
			Class_style.Grd_style.Common_style(grd_main);
		}
		private void Form_datagridview_select_Shown(object sender, EventArgs e)
		{
			switch (_form_type)
			{
				case "VEHICLE_MODEL":
					Setup_vehicle_model_form(_preselect_value);
					break;
				case "LOCATION":
					Setup_location_form(_preselect_value);
					break;
				case "PERSON_ORGANISATION":
					lbl_type.Visible = true;
					cmb_type.Visible = true;
					Setup_person_organisation_form();
					break;
			}
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0)
			{
				MessageBox.Show("No item selected.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.DialogResult = DialogResult.None;
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

		public int Get_selected_value_as_int(string str_value_col)
		{
			if (grd_main.SelectedCells.Count > 0)
				return int.Parse(grd_main.SelectedCells[0].OwningRow.Cells[str_value_col].Value.ToString());

			return 0;
		}
		public string Get_selected_value_as_string(string str_value_col)
		{
			if (grd_main.SelectedCells.Count > 0)
				return grd_main.SelectedCells[0].OwningRow.Cells[str_value_col].Value.ToString();

			return "";
		}
		#region VEHICLE_MODEL
		private void Setup_vehicle_model_form(string preselect_value)
		{
			Class_datagridview.Setup_and_preselect(grd_main, Vehicle_model_ds.Select_vehicle_model(-1, -1, -1, -1),
				"vehicle_model", new string[] { "vehicle_model_name", "year_make", "engine_capacity",
					"no_of_door","seat_capacity", "fuel_type_name", "transmission_name",
					"vehicle_group_name", "vehicle_brand_name"}, preselect_value);

			grd_main.AutoResizeColumns();

			txt_search.TextChanged += (sender2, e2) => Apply_filter_vehicle_model();
		}
		private void Apply_filter_vehicle_model()
		{
			if (grd_main.DataSource == null) return;

			string str_search = txt_search.Text.Trim();

			((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[vehicle_model_name] LIKE '%" + str_search +
				"%' OR CONVERT([year_make], System.String) LIKE '%" + str_search +
				"%' OR [fuel_type_name] LIKE '%" + str_search +
				"%' OR [transmission_name] LIKE '%" + str_search +
				"%' OR [vehicle_group_name] LIKE '%" + str_search +
				"%' OR [vehicle_brand_name] LIKE '%" + str_search + "%'";
		}
		#endregion
		#region LOCATION
		private void Setup_location_form(string preselect_value)
		{
			Class_datagridview.Setup_and_preselect(grd_main, Location_ds.Select_location(), "location", new string[] { "location_name" }, preselect_value);

			grd_main.AutoResizeColumns();

			txt_search.TextChanged += (sender2, e2) => Apply_filter_location();
		}
		private void Apply_filter_location()
		{
			if (grd_main.DataSource == null) return;

			string str_search = txt_search.Text.Trim();

			((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[location_name] LIKE '%" + str_search + "%'";
		}
		#endregion
		#region PERSON_ORGANISATION
		private void Setup_person_organisation_form()
		{
			if (cmb_type.Items.Count > 0) cmb_type.SelectedIndex = 0;

			Setup_grd_person_organisation();

			txt_search.TextChanged += (sender2, e2) => Apply_filter_person_organisation();
			cmb_type.SelectedIndexChanged += Cmb_type_SelectedIndexChanged;
		}
		private void Setup_grd_person_organisation()
		{
			if (cmb_type.SelectedItem == null) return;

			grd_main.DataSource = null;

			if (cmb_type.SelectedItem.ToString().ToUpper() == "PERSON")
				grd_main.DataSource = Person_ds.Select_person_simplified();
			else
				grd_main.DataSource = Organisation_branch_ds.Select_organisation_simplified();

			Class_datagridview.Hide_columns(grd_main, "person", "organisation_branch", "organisation");

			grd_main.AutoResizeColumns();

			Apply_filter_person_organisation();
		}
		private void Cmb_type_SelectedIndexChanged(object sender, EventArgs e)
		{
			Setup_grd_person_organisation();
		}
		private void Apply_filter_person_organisation()
		{
			if (grd_main.DataSource == null) return;

			string str_search = txt_search.Text.Trim();

			if (cmb_type.SelectedItem.ToString().ToUpper() == "PERSON")
			{
				((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[name] LIKE '%" + str_search +
					"%' OR [ic_no] LIKE '%" + str_search + "%'";
			}
			else
			{
				((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[name] LIKE '%" + str_search +
					"%' OR [branch_name] LIKE '%" + str_search +
					"%' OR [registration_no] LIKE '%" + str_search + "%'";
			}
		}
		#endregion

	}
}
