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
			simulateUserToolStripMenuItem.Click += (sender2, e2) => Open_form(new Form_simulate_user());
			usersToolStripMenuItem.Click += (sender2, e2) => Open_form(new Form_users());
			userGroupsToolStripMenuItem.Click += (sender2, e2) => Open_form(new Form_usergroup());
			changePasswordToolStripMenuItem.Click += (sender2, e2) => (new Form_change_pw()).ShowDialog();

			salesOrderToolStripMenuItem.Click += (sender2, e2) => Open_form(new Form_sales_order());
		}
		public void Setup_menustrip()
		{
			usersToolStripMenuItem.Enabled = (Program.System_user.Has_permission(User_permission.ADD_USER) ||
				Program.System_user.Has_permission(User_permission.EDIT_USER));

			userGroupsToolStripMenuItem.Enabled = (Program.System_user.Has_permission(User_permission.ADD_USERGROUP) ||
				Program.System_user.Has_permission(User_permission.EDIT_USERGROUP));
		}
		private void Open_form(Form form_to_open, bool is_maximised = false, string form_tag = "")
		{
			if (Open_active_form(form_to_open)) return;

			form_to_open.MdiParent = this;
			if (is_maximised) form_to_open.WindowState = FormWindowState.Maximized;
			form_to_open.Tag = form_tag;
			form_to_open.Show();
		}
		private bool Open_active_form(Form form_to_check)
		{
			foreach (Form f in Application.OpenForms)
			{
				if (f.GetType() == form_to_check.GetType())
				{
					f.Activate();
					return true;
				}
			}
			return false;
		}
	}
}
