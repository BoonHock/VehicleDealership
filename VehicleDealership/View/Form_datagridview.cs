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
	public partial class Form_datagridview : Form
	{
		public Form_datagridview()
		{
			InitializeComponent();
		}
		private void Form_datagridview_Load(object sender, EventArgs e)
		{
			Class_style.Grd_style.Common_style(grd_main);
		}
		private void Form_datagridview_Shown(object sender, EventArgs e)
		{
			if (this.Tag.ToString() == "USER")
				Setup_form_users();
		}
		#region USERS
		public void Setup_form_users()
		{
			DataTable dttable_active = new DataTable();
			dttable_active.Columns.Add("display", typeof(string));
			dttable_active.Columns.Add("value", typeof(int));

			dttable_active.Rows.Add("All", -1);
			dttable_active.Rows.Add("Active", 1);
			dttable_active.Rows.Add("Inactive", 0);

			cmb_is_active.ComboBox.DisplayMember = "display";
			cmb_is_active.ComboBox.ValueMember = "value";
			cmb_is_active.ComboBox.DataSource = dttable_active;
			cmb_is_active.ComboBox.SelectedValue = 1; // select first item as default

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

			grd_main.ContextMenuStrip = cms_user;
			Setup_grd_users();

			txt_search.TextChanged += Setup_grd_users;
			cmb_is_active.ComboBox.SelectedIndexChanged += Setup_grd_users;
			grd_main.MouseDown += Class_datagridview.MouseDown_select_cell;
			btn_add.Click += Add_user;
			addToolStripMenuItem.Click += Add_user;
			btn_edit.Click += Edit_user;
			editToolStripMenuItem.Click += Edit_user;
			btn_deactivate.Click += Btn_activate_deactivate_Click;
			btn_activate.Click += Btn_activate_deactivate_Click;
		}
		private void Setup_grd_users(object sender = null, EventArgs e = null)
		{
			// setup grd_main
			grd_main.RowEnter -= Grd_users_RowEnter;
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

			Class_datagridview.Setup_and_preselect(grd_main, dttable, "user");

			grd_main.AutoResizeColumns();

			Class_datagridview.Hide_columns(grd_main, new string[] { "user" });

			Setup_buttons_enable();
			grd_main.RowEnter += Grd_users_RowEnter;
		}
		private void Edit_user(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0)
			{
				MessageBox.Show("Select a user to edit.");
				return;
			}
			int int_user = (int)grd_main.Rows[grd_main.SelectedCells[0].RowIndex].Cells["user"].Value;
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
			if (grd_main.SelectedCells.Count == 0)
			{
				MessageBox.Show("Select a user to edit.");
				return;
			}

			int int_user = (int)grd_main.Rows[grd_main.SelectedCells[0].RowIndex].Cells["user"].Value;
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
			if (grd_main.Rows.Count == 0 || grd_main.SelectedCells.Count == 0) return;

			int int_user = (int)grd_main.Rows[grd_main.SelectedCells[0].RowIndex].Cells["user"].Value;

			bool is_admin = (int_user == 1);

			btn_edit.Enabled = !is_admin;
			btn_deactivate.Enabled = !is_admin;
			btn_activate.Enabled = !is_admin;
			editToolStripMenuItem.Enabled = !is_admin;
		}

		#endregion

	}
}
