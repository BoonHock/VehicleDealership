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

				if (int_id != 0)
					Class_datagridview.Select_row_by_value(grd_main, "organisation", int_id.ToString());
			}
			grd_main.AutoResizeColumns();
		}

		private void Add_person()
		{
			if ((new Form_person()).ShowDialog() == DialogResult.OK)
				Setup_grd_main();
		}
		private void Add_organisation()
		{

		}
		private void Edit_person()
		{
			if (grd_main.SelectedCells.Count == 0) return;

			if ((new Form_person((int)grd_main.SelectedCells[0].OwningRow.Cells["person"].Value)).ShowDialog() == DialogResult.OK)
				Setup_grd_main();
		}
		private void Edit_organisation()
		{

		}
		private void Btn_add_Click(object sender, EventArgs e)
		{
			if (cmb_type.ComboBox.SelectedValue.ToString() == "PERSON")
				Add_person();
			else
				Add_organisation();
		}

		private void Btn_edit_Click(object sender, EventArgs e)
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
			string str_search = txt_search.Text.Trim();

			if (cmb_type.ComboBox.SelectedValue.ToString() == "PERSON")
				((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[name] LIKE '%" +
					str_search + "%' OR [ic_no] LIKE '%" + str_search + "%'";
		}
	}
}
