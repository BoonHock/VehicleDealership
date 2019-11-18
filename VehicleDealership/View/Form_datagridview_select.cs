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

		readonly string _value_col_name = "";
		readonly string[] _cols_to_display = { };
		private string SearchString { get { return txt_search.Text.Trim(); } }
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
		public Form_datagridview_select(DataTable dttable, string[] col_to_display = null, string value_col_name = "", string preselect_value = "", bool select_multiple = false)
		{
			InitializeComponent();

			// by default, hide these
			lbl_type.Visible = false;
			cmb_type.Visible = false;

			grd_main.MultiSelect = select_multiple;
			Class_style.Grd_style.Common_style(grd_main);

			grd_main.DataSource = dttable;
			_cols_to_display = col_to_display;
			_value_col_name = value_col_name;
			_preselect_value = preselect_value;
		}
		private void Form_datagridview_select_Shown(object sender, EventArgs e)
		{
			Class_datagridview.Setup_search_textbox(txt_search.TextBox, grd_main);

			switch (_form_type)
			{
				case "PERSON_ORGANISATION":
					lbl_type.Visible = true;
					cmb_type.Visible = true;
					Setup_person_organisation_form();
					break;
			}

			grd_main.AutoResizeColumns();

			if (_cols_to_display.Count() > 0)
				Class_datagridview.Hide_unnecessary_columns(grd_main, _cols_to_display);

			if (_value_col_name != "")
				Class_datagridview.Select_row_by_value(grd_main, _value_col_name, _preselect_value);
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
		private void Grd_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// only when user clicks on cell which is not header, perform click
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0) btn_ok.PerformClick();
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

			if (cmb_type.SelectedItem.ToString().ToUpper() == "PERSON")
			{
				((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[name] LIKE '%" + SearchString +
					"%' OR [ic_no] LIKE '%" + SearchString + "%'";
			}
			else
			{
				((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[name] LIKE '%" + SearchString +
					"%' OR [branch_name] LIKE '%" + SearchString +
					"%' OR [registration_no] LIKE '%" + SearchString + "%'";
			}
		}
		#endregion
	}
}
