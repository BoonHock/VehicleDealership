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
			// hide all toolstrip. will show them accordingly depending on what the user is using this form for
			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is ToolStrip) ctrl.Visible = false;
			}

			Class_style.Grd_style.Common_style(grd_main);
		}
		private void Form_datagridview_Shown(object sender, EventArgs e)
		{
			bool permission_denied = false;

			switch (this.Tag.ToString().ToUpper())
			{
				case "USER":
					if (!Program.System_user.Has_permission(User_permission.ADD_USER) &&
						!Program.System_user.Has_permission(User_permission.EDIT_USER))
						permission_denied = true;
					else
						Setup_form_users();
					break;
				case "VEHICLE_MODEL":
					if (!Program.System_user.Has_permission(User_permission.ADD_VEHICLE_MODEL) &&
						!Program.System_user.Has_permission(User_permission.EDIT_VEHICLE_MODEL) &&
						!Program.System_user.Has_permission(User_permission.DELETE_VEHICLE_MODEL))
						permission_denied = true;
					else
						Setup_form_vehicle_model();
					break;
			}

			if (permission_denied)
			{
				MessageBox.Show("PERMISSION DENIED", "PERMISSION DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}
		}
		#region USERS
		private void Setup_form_users()
		{
			ts_user.Visible = true;

			DataTable dttable_active = new DataTable();
			dttable_active.Columns.Add("display", typeof(string));
			dttable_active.Columns.Add("value", typeof(int));

			dttable_active.Rows.Add("All", -1);
			dttable_active.Rows.Add("Active", 1);
			dttable_active.Rows.Add("Inactive", 0);

			cmb_is_active_user.ComboBox.DisplayMember = "display";
			cmb_is_active_user.ComboBox.ValueMember = "value";
			cmb_is_active_user.ComboBox.DataSource = dttable_active;
			cmb_is_active_user.ComboBox.SelectedValue = 1; // select active user as default

			if (Program.System_user.Has_permission(User_permission.EDIT_USER))
			{
				btn_edit_user.Enabled = true;
				editToolStripMenuItem.Enabled = true;
				btn_activate_user.Enabled = true;
				btn_deactivate_user.Enabled = true;
			}
			if (Program.System_user.Has_permission(User_permission.ADD_USER))
			{
				btn_add_user.Enabled = true;
				addToolStripMenuItem.Enabled = true;
			}

			Setup_grd_users();

			txt_search_user.TextChanged += Setup_grd_users;
			cmb_is_active_user.ComboBox.SelectedIndexChanged += Setup_grd_users;
			grd_main.MouseDown += Class_datagridview.MouseDown_select_cell;
			btn_add_user.Click += Add_user;
			addToolStripMenuItem.Click += Add_user;
			btn_edit_user.Click += Edit_user;
			editToolStripMenuItem.Click += Edit_user;
			btn_deactivate_user.Click += Btn_activate_deactivate_user_Click;
			btn_activate_user.Click += Btn_activate_deactivate_user_Click;
		}
		private void Setup_grd_users(object sender = null, EventArgs e = null)
		{

		}
		private void Edit_user(object sender, EventArgs e)
		{

		}
		private void Add_user(object sender, EventArgs e)
		{

		}
		private void Btn_activate_deactivate_user_Click(object sender, EventArgs e)
		{

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

			btn_edit_user.Enabled = !is_admin;
			btn_deactivate_user.Enabled = !is_admin;
			btn_activate_user.Enabled = !is_admin;
			editToolStripMenuItem.Enabled = !is_admin;
		}
		#endregion
		#region VEHICLE_MODEL
		private void Setup_form_vehicle_model()
		{
			ts_vehicle_model.Visible = true;

			if (Program.System_user.Has_permission(User_permission.ADD_VEHICLE_MODEL))
			{
				btn_add_vehicle_model.Enabled = true;
				addToolStripMenuItem.Enabled = true;
			}
			if (Program.System_user.Has_permission(User_permission.EDIT_VEHICLE_MODEL))
			{
				btn_edit_vehicle_model.Enabled = true;
				editToolStripMenuItem.Enabled = true;
			}
			if (Program.System_user.Has_permission(User_permission.DELETE_VEHICLE_MODEL))
			{
				btn_delete_vehicle_model.Enabled = true;
			}

			Setup_grd_vehicle_model();
		}
		private void Setup_grd_vehicle_model(object sender = null, EventArgs e = null)
		{

		}

		#endregion
	}
}
