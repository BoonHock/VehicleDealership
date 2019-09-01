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
		public string SelectedType { get; private set; }
		public int SelectedID { get; private set; } = 0;
		public Form_person_organisation(string select_for)
		{
			InitializeComponent();

			bool has_add_edit_permission = Program.System_user.Has_add_edit_person_org_permission;

			btn_add.Enabled = has_add_edit_permission;
			btn_edit.Enabled = has_add_edit_permission;

			DataTable dttable = new DataTable();
			dttable.Columns.Add("display", typeof(string));
			dttable.Columns.Add("value", typeof(string));
			dttable.Rows.Add("PERSON", "PERSON");
			dttable.Rows.Add("ORGANISATION", "ORGANISATION");

			cmb_type.ComboBox.DisplayMember = "display";
			cmb_type.ComboBox.ValueMember = "value";
			cmb_type.ComboBox.DataSource = dttable;

			_select_for = select_for;

			grd_main.MouseDown += Class_datagridview.MouseDown_select_cell;
		}
		private void Form_person_organisation_Shown(object sender, EventArgs e)
		{
			Class_style.Grd_style.Common_style(grd_main);
			Class_style.Grd_style.Common_style(grd_main);

			Setup_grd_main();
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (cmb_type.ComboBox.SelectedValue.ToString().ToUpper() == "PERSON")
			{
				if (grd_main.SelectedCells.Count == 0)
				{
					MessageBox.Show("No person selected.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (grd_main.SelectedCells.Count > 0)
					SelectedID = int.Parse(grd_main.SelectedCells[0].OwningRow.Cells["person"].Value.ToString());
			}
			else
			{
				if (grd_main.SelectedCells.Count == 0)
				{
					MessageBox.Show("No organisation selected.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (grd_main.SelectedCells.Count > 0)
					SelectedID = int.Parse(grd_main.SelectedCells[0].OwningRow.Cells["organisation"].Value.ToString());
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

			if (_select_for == "SALESPERSON")
			{
				if (cmb_type.ComboBox.SelectedValue.ToString() == "PERSON")
					grd_main.DataSource = Person_ds.Select_person_not_salesperson();
				else
					grd_main.DataSource = Organisation_ds.Select_organisation_not_salesperson();
			}

			if (cmb_type.ComboBox.SelectedValue.ToString() == "PERSON")
			{
				Class_datagridview.Hide_columns(grd_main, new string[] { "person" });

				if (int_id != 0)
					Class_datagridview.Select_row_by_value(grd_main, "person", int_id.ToString());
			}
			else
			{
				Class_datagridview.Hide_columns(grd_main, new string[] { "organisation" });

				grd_main.Columns.Remove("url");

				DataGridViewLinkColumn col_link = new DataGridViewLinkColumn();
				col_link.DataPropertyName = "url";
				col_link.Name = "url";
				grd_main.Columns.Add(col_link);

				if (int_id != 0)
					Class_datagridview.Select_row_by_value(grd_main, "organisation", int_id.ToString());
			}
			grd_main.AutoResizeColumns();
			Apply_search_filter_to_grd_main();
		}

		private void Add_person()
		{
			Form_person formPerson = new Form_person();

			if (formPerson.ShowDialog() == DialogResult.OK)
				Setup_grd_main(formPerson.PersonID);
		}
		private void Add_organisation()
		{
			Form_organisation formOrg = new Form_organisation();

			if (formOrg.ShowDialog() == DialogResult.OK)
				Setup_grd_main(formOrg.OrganisationID);
		}
		private void Edit_person()
		{
			if (grd_main.SelectedCells.Count == 0) return;

			int int_person = (int)grd_main.SelectedCells[0].OwningRow.Cells["person"].Value;
			if ((new Form_person(int_person)).ShowDialog() == DialogResult.OK)
				Setup_grd_main(int_person);
		}
		private void Edit_organisation()
		{
			if (grd_main.SelectedCells.Count == 0) return;

			int int_org = (int)grd_main.SelectedCells[0].OwningRow.Cells["organisation"].Value;
			if ((new Form_organisation(int_org)).ShowDialog() == DialogResult.OK)
				Setup_grd_main(int_org);
		}
		private void Add_Click(object sender, EventArgs e)
		{
			if (cmb_type.ComboBox.SelectedValue.ToString() == "PERSON")
				Add_person();
			else
				Add_organisation();
		}
		private void Edit_Click(object sender, EventArgs e)
		{
			if (cmb_type.ComboBox.SelectedValue.ToString() == "PERSON")
				Edit_person();
			else
				Edit_organisation();
		}
		private void Cmb_type_SelectedIndexChanged(object sender, EventArgs e)
		{
			Setup_grd_main();
		}

		private void Txt_search_TextChanged(object sender, EventArgs e)
		{
			Apply_search_filter_to_grd_main();
		}
		private void Apply_search_filter_to_grd_main()
		{
			if (grd_main.DataSource == null) return;

			string str_search = txt_search.Text.Trim();

			if (cmb_type.ComboBox.SelectedValue.ToString() == "PERSON")
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
	}
}
