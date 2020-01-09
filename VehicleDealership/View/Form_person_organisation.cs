using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Classes;
using VehicleDealership.Datasets;

namespace VehicleDealership.View
{
	public partial class Form_person_organisation : Form
	{
		readonly string _select_for;
		public string SelectedType
		{
			get
			{
				return cmb_type.ComboBox.SelectedItem.ToString().ToUpper();
			}
		}
		public int SelectedID
		{
			get
			{
				int int_result = 0;

				if (cmb_type.ComboBox.SelectedItem.ToString().ToUpper() == "PERSON")
				{
					if (grd_main.SelectedCells.Count > 0)
						int_result = int.Parse(grd_main.SelectedCells[0].OwningRow.Cells["person"].Value.ToString());
				}
				else
				{
					if (grd_main.SelectedCells.Count > 0)
						int_result = int.Parse(grd_main.SelectedCells[0].OwningRow.Cells["organisation"].Value.ToString());
				}

				return int_result;
			}
		}
		public int SelectedBranchID
		{
			get
			{
				int int_result = 0;

				if (cmb_type.ComboBox.SelectedItem.ToString().ToUpper() == "ORGANISATION" && grd_main.SelectedCells.Count > 0)
				{
					int_result = int.Parse(grd_main.SelectedCells[0].OwningRow.Cells["organisation_branch"].Value.ToString());
				}

				return int_result;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="select_for">
		/// SALESPERSON/FINANCE/INSURANCE/LOAN. 
		/// passstring if just person and organisation
		/// </param>
		public Form_person_organisation(string select_for = "")
		{
			InitializeComponent();

			_select_for = select_for;

			grd_main.MouseDown += Class_datagridview.MouseDown_select_cell;
		}
		private void Form_person_organisation_Shown(object sender, EventArgs e)
		{
			Class_style.Grd_style.Common_style(grd_main);

			cmb_type.ComboBox.SelectedIndex = 0;

			Setup_grd_main();
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
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0)
			{
				MessageBox.Show("No item selected.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		private void Setup_grd_main(int int_id = 0)
		{
			grd_main.DataSource = null;

			switch (_select_for)
			{
				case "":
					if (cmb_type.ComboBox.SelectedItem.ToString() == "PERSON")
					{
						grd_main.DataSource = Person_ds.Select_person(-1);
						Class_datagridview.Hide_columns(grd_main,
							new string[] { "person", "image", "person_type", "gender", "race", "country" });
					}
					else
					{
						grd_main.DataSource = Organisation_branch_ds.Select_organisation_branch_with_org_details(-1);
						Class_datagridview.Hide_columns(grd_main,
							new string[] { "organisation", "organisation_type", "country" });
					}
					break;
				case "SALESPERSON":
					if (cmb_type.ComboBox.SelectedItem.ToString() == "PERSON")
						grd_main.DataSource = Person_ds.Select_person_not_salesperson();
					else
						grd_main.DataSource = Organisation_branch_ds.Select_organisation_not_salesperson();
					break;
				case "FINANCE":
					cmb_type.ComboBox.SelectedValue = "ORGANISATION";
					cmb_type.Enabled = false; // ONLY organisation allowed for finance
					grd_main.DataSource = Organisation_branch_ds.Select_organisation_not_finance();
					break;
				case "INSURANCE":
					cmb_type.ComboBox.SelectedValue = "ORGANISATION";
					cmb_type.Enabled = false; // ONLY organisation allowed for insurance
					grd_main.DataSource = Organisation_branch_ds.Select_organisation_not_insurance();
					break;
				case "LOAN":
					cmb_type.ComboBox.SelectedValue = "ORGANISATION";
					cmb_type.Enabled = false; // ONLY organisation allowed for loan
					grd_main.DataSource = Organisation_branch_ds.Select_organisation_not_loan();
					break;
			}

			if (cmb_type.ComboBox.SelectedItem.ToString() == "PERSON")
			{
				Class_datagridview.Hide_columns(grd_main, new string[] { "person" });

				if (int_id != 0)
					Class_datagridview.Select_row_by_value(grd_main, "person", int_id);

				btn_add.Enabled = Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_PERSON);
				addToolStripMenuItem.Enabled = Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_PERSON);
				btn_edit.Enabled = Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_PERSON) ||
					Program.System_user.Has_permission(Class_enum.User_permission.VIEW_PERSON);
			}
			else
			{
				Class_datagridview.Hide_columns(grd_main, new string[] { "organisation_branch", "organisation" });

				if (int_id != 0)
					Class_datagridview.Select_row_by_value(grd_main, "organisation", int_id);

				btn_add.Enabled = Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_ORGANISATION);
				addToolStripMenuItem.Enabled = Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_ORGANISATION);
				btn_edit.Enabled = Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_ORGANISATION) ||
					Program.System_user.Has_permission(Class_enum.User_permission.VIEW_ORGANISATION);
			}

			Class_datagridview.Convert_column_to_link_column(grd_main, "url", "url");

			grd_main.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
			grd_main.AutoResizeColumns();
			grd_main.AutoResizeRows();
			Apply_search_filter_to_grd_main();
		}
		private void Add_person()
		{
			using (Form_person formPerson = new Form_person())
			{
				if (formPerson.ShowDialog() == DialogResult.OK) Setup_grd_main(formPerson.PersonID);
			}
		}
		private void Add_organisation()
		{
			using (Form_organisation formOrg = new Form_organisation())
			{
				if (formOrg.ShowDialog() == DialogResult.OK) Setup_grd_main(formOrg.OrganisationID);
			}
		}
		private void Edit_person()
		{
			if (grd_main.SelectedCells.Count == 0) return;
			int int_person = (int)grd_main.SelectedCells[0].OwningRow.Cells["person"].Value;

			using (Form_person dlg = new Form_person(int_person))
			{
				if (dlg.ShowDialog() == DialogResult.OK) Setup_grd_main(int_person);
			}
		}
		private void Edit_organisation()
		{
			if (grd_main.SelectedCells.Count == 0) return;

			int int_org = (int)grd_main.SelectedCells[0].OwningRow.Cells["organisation"].Value;

			using (Form_organisation dlg = new Form_organisation(int_org))
			{
				if (dlg.ShowDialog() == DialogResult.OK) Setup_grd_main(int_org);
			}
		}
		private void Add_Click(object sender, EventArgs e)
		{
			if (cmb_type.ComboBox.SelectedItem.ToString() == "PERSON")
				Add_person();
			else
				Add_organisation();
		}
		private void Edit_Click(object sender, EventArgs e)
		{
			if (cmb_type.ComboBox.SelectedItem.ToString() == "PERSON")
				Edit_person();
			else
				Edit_organisation();
		}
		private void Txt_search_TextChanged(object sender, EventArgs e)
		{
			Apply_search_filter_to_grd_main();
		}
		private void Apply_search_filter_to_grd_main()
		{
			if (grd_main.DataSource == null) return;

			string str_search = txt_search.Text.Trim();

			if (cmb_type.ComboBox.SelectedItem.ToString() == "PERSON")
			{
				((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[name] LIKE '%" +
					str_search + "%' OR [ic_no] LIKE '%" + str_search + "%'";
			}
			else
			{
				((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[name] LIKE '%" +
					str_search + "%' OR [registration_no] LIKE '%" + str_search + "%'";
			}
		}
		private void Grd_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (grd_main.Columns[e.ColumnIndex].Name.ToUpper() == "URL")
			{
				Cursor = Cursors.WaitCursor;
				Class_misc.Go_url(grd_main[e.ColumnIndex, e.RowIndex].Value.ToString());
				Cursor = Cursors.Default;
			}
		}
		private void Grd_main_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_ok.PerformClick();
		}

		private void Cmb_type_SelectedIndexChanged(object sender, EventArgs e)
		{
			Setup_grd_main();
		}
	}
}
