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
		public string SelectedType { get; private set; }
		public int SelectedID { get; private set; } = 0;
		public Form_person_organisation()
		{
			InitializeComponent();

			bool has_add_edit_permission = Program.System_user.Has_add_edit_person_org_permission;

			btn_add.Enabled = has_add_edit_permission;
			btn_edit.Enabled = has_add_edit_permission;
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

			if (cmb_type.ComboBox.SelectedValue.ToString() == "PERSON")
			{
				grd_main.DataSource = Person_ds.Select_person_not_salesperson();
				grd_main.Columns["person"].Visible = false;

				if (int_id != 0)
				{
					// TODO: PRESELECT AFTER ADDING
				}
			}
			else
			{
				grd_main.DataSource = Organisation_ds.Select_organisation_not_salesperson();
				grd_main.Columns["organisation"].Visible = false;
			}
			grd_main.AutoResizeColumns();
		}

		private void Btn_add_person_Click(object sender, EventArgs e)
		{
			Form_person form_p = new Form_person();

			if (form_p.ShowDialog() == DialogResult.OK)
			{
				Setup_grd_main();
			}
		}
		private void Btn_edit_person_Click(object sender, EventArgs e)
		{

		}
	}
}
