using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using VehicleDealership.Classes;

namespace VehicleDealership.View
{
	public partial class Form_main_menu : Form
	{
		string str_project_path = Application.StartupPath;
		public Form_main_menu()
		{
			InitializeComponent();
		}

		private void Form_main_menu_Load(object sender, EventArgs e)
		{
			log_in_menustrip.Visible = true;
			main_menu_strip.Visible = false;
			ssl_username.Text = "";
			ssl_usergroup.Text = "";

			//simulateUserToolStripMenuItem.Click += (sender2, e2) => Open_form(new Form_simulate_user());
			usersToolStripMenuItem.Click += (sender2, e2) => Open_form(typeof(Form_datagridview), false, "USER");
			userGroupsToolStripMenuItem.Click += (sender2, e2) => Open_form(typeof(Form_usergroup));
			changePasswordToolStripMenuItem.Click += (sender2, e2) => (new Form_change_pw()).ShowDialog();
			brandGroupModelToolStripMenuItem.Click += (sender2, e2) => Open_form(typeof(Form_vehicle_template));
			transmissionToolStripMenuItem.Click += (sender2, e2) => Open_form(typeof(Form_datagridview), false, "TRANSMISSION");
			fuelTypeToolStripMenuItem.Click += (sender2, e2) => Open_form(typeof(Form_datagridview), false, "FUEL_TYPE");
			colorToolStripMenuItem.Click += (sender2, e2) => Open_form(typeof(Form_datagridview), false, "COLOR");
			salespersonToolStripMenuItem.Click += (sender2, e2) => Open_form(typeof(Form_datagridview), false, "SALESPERSON");

			salesOrderToolStripMenuItem.Click += (sender2, e2) => Open_form(typeof(Form_sales_order));
		}
		private void Form_main_menu_Shown(object sender, EventArgs e)
		{
			logInToolStripMenuItem.PerformClick();
		}
		public void Setup_menustrip()
		{
			usersToolStripMenuItem.Enabled = (
				Program.System_user.Has_permission(User_permission.ADD_USER) ||
				Program.System_user.Has_permission(User_permission.EDIT_USER));

			userGroupsToolStripMenuItem.Enabled = (
				Program.System_user.Has_permission(User_permission.ADD_USERGROUP) ||
				Program.System_user.Has_permission(User_permission.EDIT_USERGROUP));

			brandGroupModelToolStripMenuItem.Enabled = (
				Program.System_user.Has_permission(User_permission.ADD_EDIT_VEHICLE_BRAND_GROUP_MODEL) ||
				Program.System_user.Has_permission(User_permission.DELETE_VEHICLE_BRAND_GROUP_MODEL));
			transmissionToolStripMenuItem.Enabled = (
				Program.System_user.Has_permission(User_permission.ADD_EDIT_TRANSMISSION) ||
				Program.System_user.Has_permission(User_permission.DELETE_TRANSMISSION));
			fuelTypeToolStripMenuItem.Enabled = (
				Program.System_user.Has_permission(User_permission.ADD_EDIT_FUEL_TYPE) ||
				Program.System_user.Has_permission(User_permission.DELETE_FUEL_TYPE));
			colorToolStripMenuItem.Enabled = (
				Program.System_user.Has_permission(User_permission.ADD_EDIT_COLOR) ||
				Program.System_user.Has_permission(User_permission.DELETE_COLOR));

		}
		private void Open_form(Type f_type, bool is_maximised = false, string form_tag = "")
		{
			foreach (Form f in this.MdiChildren)
			{
				if (f.GetType() == f_type && ((f.Tag == null && form_tag == "") ||
					(f.Tag != null && f.Tag.ToString() == form_tag)))
				{
					f.Activate();
					return;
				}
			}

			Form form_to_open = (Form)Activator.CreateInstance(f_type);
			form_to_open.MdiParent = this;
			if (is_maximised) form_to_open.WindowState = FormWindowState.Maximized;
			form_to_open.Tag = form_tag;
			form_to_open.Show();
		}
		private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.MdiChildren.Count() != 0 && MessageBox.Show("Are you sure? Any changes will not be saved.", "Log out",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.OK) return;

			foreach (Form frm in this.MdiChildren)
			{
				frm.Close();
			}
			this.main_menu_strip.Visible = false;
			this.log_in_menustrip.Visible = true;
			ssl_username.Text = "";
			ssl_usergroup.Text = "";
			Program.System_user = null;

			logInToolStripMenuItem.PerformClick();
		}
		private void LogInToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_log_in form_login = new Form_log_in();
			if (form_login.ShowDialog() != DialogResult.OK) return;

			Program.System_user = new User(form_login.Username);

			if (Program.System_user.UserID == 1)
			{
				// temporary for development
				// if user log in as admin, assign all permissions. just in case any permission not assigned
				Datasets.Permission_ds.Assign_all_permission_to_administrator();

				// developer is only availabe to user id 1
				Program.System_user.IsDeveloper = form_login.IsDeveloper;
			}
			Setup_menustrip();
			ssl_username.Text = Program.System_user.Username;
			ssl_usergroup.Text = Program.System_user.UserGroup;

			log_in_menustrip.Visible = false;
			main_menu_strip.Visible = true;
		}
	}
}
