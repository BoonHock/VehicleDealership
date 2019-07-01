using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Datasets;
using VehicleDealership.Classes;

namespace VehicleDealership.View
{
	public partial class Form_users : Form
	{
		public Form_users()
		{
			InitializeComponent();

			DataTable dttable_active = new DataTable();
			dttable_active.Columns.Add("display", typeof(string));
			dttable_active.Columns.Add("value", typeof(int));

			dttable_active.Rows.Add("All", -1);
			dttable_active.Rows.Add("Active", 1);
			dttable_active.Rows.Add("Inactive", 0);

			cmb_is_active.ComboBox.DisplayMember = "display";
			cmb_is_active.ComboBox.ValueMember = "value";
			cmb_is_active.ComboBox.DataSource = dttable_active;

			cmb_is_active.ComboBox.SelectedValue = 1;

			txt_search.TextChanged += Setup_grd_users;
			cmb_is_active.ComboBox.SelectedIndexChanged += Setup_grd_users;
			grd_users.MouseDown += Class_datagridview.MouseDown_select_cell;
		}
		private void Form_users_Load(object sender, EventArgs e)
		{
			btn_add.Visible = false;
			addToolStripMenuItem.Visible = false;
			btn_edit.Visible = false;
			editToolStripMenuItem.Visible = false;
			btn_activate.Visible = false;
			btn_deactivate.Visible = false;

			if (Program.System_user.Has_permission(User_permission.EDIT_USER))
			{
				btn_edit.Visible = true;
				editToolStripMenuItem.Visible = true;
				btn_activate.Visible = true;
				btn_deactivate.Visible = true;
			}
			if (Program.System_user.Has_permission(User_permission.ADD_USER))
			{
				btn_add.Visible = true;
				addToolStripMenuItem.Visible = true;
			}

			Setup_grd_users();

			Class_style.Grd_style.Common_style(grd_users);
		}
		private void Setup_grd_users(object sender = null, EventArgs e = null)
		{
			grd_users.RowEnter -= Grd_users_RowEnter;
			string str_search = txt_search.Text.Trim();

			DataTable dttable = new User_ds.sp_search_userDataTable();

			switch ((int)cmb_is_active.ComboBox.SelectedValue)
			{
				case 0:
					dttable = User_ds.Search_user(str_search, false);
					break;
				case 1:
					dttable = User_ds.Search_user(str_search, true);
					break;
				default:
					dttable = User_ds.Search_user(str_search, null);
					break;
			}

			Class_datagridview.Setup_and_preselect(grd_users, dttable, "user");

			grd_users.AutoResizeColumns();

			Class_datagridview.Hide_columns(grd_users, new string[] { "user" });

			Setup_buttons_enable();
			grd_users.RowEnter += Grd_users_RowEnter;
		}
		private void Edit_user(object sender, EventArgs e)
		{
			if (grd_users.SelectedCells.Count == 0)
			{
				MessageBox.Show("Select a user to edit.");
				return;
			}
			int int_user = (int)grd_users.Rows[grd_users.SelectedCells[0].RowIndex].Cells["user"].Value;
			if (int_user == 1)
			{
				MessageBox.Show("ADMIN cannot be activated or deactivated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Form_edit_users form_edit = new Form_edit_users(int_user);

			if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_users();
		}
		private void Add_user(object sender, EventArgs e)
		{
			string str_username = View.Form_register_user.Register_user();

			if (str_username == null) return;

			Setup_grd_users();
			MessageBox.Show("New user added");
		}
		private void Btn_activate_deactivate_Click(object sender, EventArgs e)
		{
			if (grd_users.SelectedCells.Count == 0)
			{
				MessageBox.Show("Select a user to edit.");
				return;
			}

			int int_user = (int)grd_users.Rows[grd_users.SelectedCells[0].RowIndex].Cells["user"].Value;
			bool is_activate = ((ToolStripButton)sender == btn_activate) ? true : false;

			if (int_user == 1)
			{
				MessageBox.Show("ADMIN cannot be activated or deactivated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			User_ds.Update_user_active(int_user, is_activate);
			Setup_grd_users();
		}
		private void Grd_users_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			Setup_buttons_enable();
		}
		private void Setup_buttons_enable()
		{
			if (grd_users.Rows.Count == 0) return;

			int int_user = (int)grd_users.Rows[grd_users.SelectedCells[0].RowIndex].Cells["user"].Value;

			bool is_admin = (int_user == 1);

			btn_edit.Enabled = !is_admin;
			btn_deactivate.Enabled = !is_admin;
			btn_activate.Enabled = !is_admin;
			editToolStripMenuItem.Enabled = !is_admin;
		}
	}
}
