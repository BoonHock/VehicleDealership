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
	public partial class Form_select_person_org : Form
	{
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
		public Form_select_person_org(bool is_org_only = false)
		{
			InitializeComponent();

			// TODO:
			// not sure if this form is really needed.
			// dilemma: should we make everything down to org branch level
			// or some is to org level while some is to org branch level?
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
		private void Cmb_type_SelectedIndexChanged(object sender, EventArgs e)
		{
			Setup_grd_person_organisation();
		}
		private void Txt_search_TextChanged(object sender, EventArgs e)
		{
			Apply_filter_grd();
		}
		private void Apply_filter_grd()
		{
			string str_search = txt_search.Text.Trim();

			if (grd_main.DataSource == null) return;

			if (cmb_type.SelectedItem.ToString().ToUpper() == "PERSON")
			{
				((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[name] LIKE '%" +
					str_search + "%' OR [ic_no] LIKE '%" + str_search + "%'";
			}
			else
			{
				((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[name] LIKE '%" +
					str_search + "%' OR [branch_name] LIKE '%" + str_search +
					"%' OR [registration_no] LIKE '%" + str_search + "%'";
			}
		}
		private void Form_select_person_org_Shown(object sender, EventArgs e)
		{
			if (cmb_type.SelectedItem == null) return;

			// TODO
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

			Apply_filter_grd();
		}
	}
}
