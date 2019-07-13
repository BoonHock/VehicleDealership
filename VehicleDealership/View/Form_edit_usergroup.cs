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
	public partial class Form_edit_usergroup : Form
	{
		private string _usergroup = "";
		public string Usergroup { get { return _usergroup; } }
		public Form_edit_usergroup()
		{
			InitializeComponent();
			Init_form();
		}
		public Form_edit_usergroup(string str_usergroup, string str_usergroup_desc)
		{
			InitializeComponent();
			Init_form();

			_usergroup = str_usergroup;

			txt_name.Text = str_usergroup;
			txt_description.Text = str_usergroup_desc;
		}
		private void Init_form()
		{
			Class_listview.Setup_listview(listview_permission, Permission_ds.Select_all_permission());
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			string str_new_usergroup = txt_name.Text.Trim();
			string str_usergroup_description = txt_description.Text.Trim();

			if (str_new_usergroup.Length == 0)
			{
				MessageBox.Show("Usergroup name is required.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Permission_ds.Usergroup_available(str_new_usergroup, _usergroup))
			{
				MessageBox.Show("Usergroup name already in use.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (_usergroup == "")
			{
				// Adding new usergroup
				if (!Program.System_user.Has_permission(User_permission.ADD_USERGROUP))
				{
					MessageBox.Show("You do not have permission to add usergroup!", "PERMISSION DENIED",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
					return;
				}
				Permission_ds.Insert_usergroup(str_new_usergroup, str_usergroup_description);
			}
			else
			{
				// editing existing usergroup
				if (!Program.System_user.Has_permission(User_permission.EDIT_USERGROUP))
				{
					MessageBox.Show("You do not have permission to edit usergroup!", "PERMISSION DENIED",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
					return;
				}
				string str_perm_combine = Class_listview.Get_checked_results_as_string(listview_permission, "permission");
				Permission_ds.Update_usergroup(str_new_usergroup, str_usergroup_description, _usergroup);
			}

			string str_permission_combine = Class_listview.Get_checked_results_as_string(listview_permission, "permission");

			if (str_permission_combine == "")
			{
				MessageBox.Show("Select one or more permission.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Permission_ds.Update_usergroup_permission(str_new_usergroup, str_permission_combine);

			_usergroup = str_new_usergroup;

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Form_edit_usergroup_Shown(object sender, EventArgs e)
		{
			if (_usergroup == "")
			{
				if (!Program.System_user.Has_permission("ADD_USERGROUP"))
				{
					MessageBox.Show("PERMISSION DENIED", "PERMISSION DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
					return;
				}
			}
			else
			{
				if (!Program.System_user.Has_permission("EDIT_USERGROUP"))
				{
					MessageBox.Show("PERMISSION DENIED", "PERMISSION DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
					return;
				}
				Select_listview_permission();
			}
		}
		private void Select_listview_permission()
		{
			List<string> list_permission = new List<string>();

			foreach (DataRow dt_row in Permission_ds.Select_permission_by_usergroup(_usergroup).Rows)
			{
				list_permission.Add(dt_row["permission"].ToString());
			}
			foreach (ListViewItem lv_item in listview_permission.Items)
			{
				lv_item.Checked = list_permission.Contains(lv_item.Text);
			}
		}
	}
}
