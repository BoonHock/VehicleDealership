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
	public partial class Form_usergroup : Form
	{
		public Form_usergroup()
		{
			InitializeComponent();

			btn_add.Click += Add_usergroup;
			addToolStripMenuItem.Click += Add_usergroup;

			btn_edit.Click += Edit_usergroup;
			editToolStripMenuItem.Click += Edit_usergroup;

			btn_remove.Click += Remove_usergroup;
			removeToolStripMenuItem.Click += Remove_usergroup;
			grd_usergroup.MouseDown += Class_datagridview.MouseDown_select_cell;
		}

		private void Form_usergroup_Shown(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission("ADD_USERGROUP") && !Program.System_user.Has_permission("EDIT_USERGROUP"))
			{
				MessageBox.Show("PERMISSION DENIED", "PERMISSION DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			addToolStripMenuItem.Enabled = false;
			btn_add.Enabled = false;
			editToolStripMenuItem.Enabled = false;
			btn_edit.Enabled = false;
			btn_remove.Enabled = false;
			removeToolStripMenuItem.Enabled = false;

			if (Program.System_user.Has_permission("ADD_USERGROUP"))
			{
				addToolStripMenuItem.Enabled = true;
				btn_add.Enabled = true;
			}
			if (Program.System_user.Has_permission("EDIT_USERGROUP"))
			{
				editToolStripMenuItem.Enabled = true;
				btn_edit.Enabled = true;
				btn_remove.Enabled = true;
				removeToolStripMenuItem.Enabled = true;
			}

			Class_style.Grd_style.Common_style(grd_usergroup);
			Class_style.Grd_style.Common_style(grd_permission);

			Setup_grd_usergroup();

			grd_usergroup.RowEnter += Grd_usergroup_RowEnter;

		}
		private void Setup_grd_usergroup(string select_usergroup = "")
		{
			grd_usergroup.DataSource = Permission_ds.Select_usergroup();

			if (grd_usergroup.Rows.Count == 0) return;

			grd_usergroup.ClearSelection();

			if (select_usergroup == "")
			{
				grd_usergroup.Rows[0].Selected = true;
				grd_usergroup.CurrentCell = grd_usergroup[0, 0];
			}
			else
			{
				select_usergroup = select_usergroup.ToUpper();
				foreach (DataGridViewRow grd_row in grd_usergroup.Rows)
				{
					if (grd_row.Cells["usergroup"].Value.ToString().ToUpper() == select_usergroup)
					{
						grd_row.Selected = true;
						grd_usergroup.CurrentCell = grd_row.Cells["usergroup"];
						break;
					}
				}
			}

			grd_usergroup.AutoResizeColumns();
			Setup_grd_permission();
		}
		private void Grd_usergroup_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			Setup_grd_permission();
		}
		private void Setup_grd_permission()
		{
			if (grd_usergroup.SelectedCells.Count == 0) return;

			string str_usergroup = grd_usergroup.SelectedRows[0].Cells["usergroup"].Value.ToString();

			bool is_administrator = str_usergroup == "ADMINISTRATOR";

			editToolStripMenuItem.Enabled = !is_administrator;
			btn_edit.Enabled = !is_administrator;
			removeToolStripMenuItem.Enabled = !is_administrator;
			btn_remove.Enabled = !is_administrator;

			grd_permission.DataSource = null;
			grd_permission.DataSource = Permission_ds.Select_permission_by_usergroup(str_usergroup);
			grd_permission.Columns["permission"].Width = 160;
			grd_permission.Columns["permission_desc"].Width = 200;
		}
		private void Edit_usergroup(object sender, EventArgs e)
		{
			if (grd_usergroup.SelectedCells.Count == 0)
			{
				MessageBox.Show("Select a usergroup to edit.");
				return;
			}

			DataGridViewRow grd_row = grd_usergroup.Rows[grd_usergroup.SelectedCells[0].RowIndex];
			string str_usergroup = grd_row.Cells["usergroup"].Value.ToString();

			// ADMINISTRATOR usergroup CANNOT be edited and removed
			if (str_usergroup.ToUpper() == "ADMINISTRATOR")
			{
				MessageBox.Show("ADMINISTRATOR usergroup cannot be edited or deleted.", "",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Form_edit_usergroup form_edit = new Form_edit_usergroup(str_usergroup,
				grd_row.Cells["usergroup_desc"].Value.ToString());

			if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_usergroup(form_edit.Usergroup);
		}
		private void Add_usergroup(object sender, EventArgs e)
		{
			Form_edit_usergroup form_edit = new Form_edit_usergroup();

			if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_usergroup(form_edit.Usergroup);
		}
		private void Remove_usergroup(object sender, EventArgs e)
		{
			DataGridViewRow grd_row = grd_usergroup.Rows[grd_usergroup.SelectedCells[0].RowIndex];
			string str_usergroup = grd_row.Cells["usergroup"].Value.ToString();

			// ADMINISTRATOR usergroup CANNOT be edited and removed
			if (str_usergroup.ToUpper() == "ADMINISTRATOR")
			{
				MessageBox.Show("ADMINISTRATOR usergroup cannot be edited or deleted.", "",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (MessageBox.Show("Are you sure? This action cannot be undone", "Confirm",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;

			Permission_ds.Delete_usergroup(str_usergroup);

			Setup_grd_usergroup();
		}
	}
}
