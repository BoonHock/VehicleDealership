using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Datasets;
using VehicleDealership.Classes;

namespace VehicleDealership.View
{
	public partial class Form_edit_users : Form
	{
		private readonly User Obj_user;
		private void Setup_form()
		{
			Class_style.Grd_style.Common_style(grd_permission);
			Class_listview.Setup_listview(listview_usergroup, Permission_ds.Select_usergroup());
		}
		public Form_edit_users(int int_user)
		{
			InitializeComponent();
			Setup_form();

			Obj_user = new User(int_user);

			txt_username.Text = Obj_user.Username;
			txt_name.Text = Obj_user.Name;
			txt_ic_no.Text = Obj_user.IcNo;
			dtp_join.Value = Obj_user.JoinDate;

			if (Obj_user.LeaveDate != null)
			{
				dtp_leave.Value = (DateTime)Obj_user.LeaveDate;
				dtp_leave.Enabled = true;
				ch_empty_leave_date.Checked = false;
			}
			else
			{
				dtp_leave.Enabled = false;
				ch_empty_leave_date.Checked = true;
			}
			if (Obj_user.Photo != null)
			{
				picbox_photo.Image = Image.FromStream(new MemoryStream(Obj_user.Photo));
			}
			if (Obj_user.UserGroup != null )
			{
				foreach (ListViewItem lv_item in listview_usergroup.Items)
				{
					if (lv_item.Text == Obj_user.UserGroup)
					{
						listview_usergroup.SelectedItems.Clear();
						lv_item.Selected = true;
						break;
					}
				}
			}
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(User_permission.EDIT_USER))
			{
				MessageBox.Show("You do not have permission to edit users!", "PERMISSION DENIED",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			Update_user_details();
			Update_user_permissions();

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Update_user_details()
		{
			string str_username = txt_username.Text.Trim();
			string str_name = txt_name.Text.Trim();
			string str_ic_no = txt_ic_no.Text.Trim();
			DateTime date_join = dtp_join.Value;
			DateTime? date_leave = (ch_empty_leave_date.Checked) ? (DateTime?)null : dtp_leave.Value;
			byte[] byte_image = null;
			string str_usergroup = "";

			if (str_username.Length == 0 || str_name.Length == 0)
			{
				MessageBox.Show("Username and Name is required.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!User.Is_username_valid(str_username))
			{
				MessageBox.Show("Username is invalid. Only aphanumeric characters allowed for username. Please retry",
					"Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!User.Is_username_available(str_username, Obj_user.UserID))
			{
				MessageBox.Show("Username is taken.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (date_leave != null && date_leave < date_join)
			{
				MessageBox.Show("Leave date cannot be before Join Date.", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (listview_usergroup.SelectedItems.Count == 0)
			{
				MessageBox.Show("Usergroup is required. Please go to 'Permission' tab to select usergroup.", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (picbox_photo.Image != null)
			{
				Image img = picbox_photo.Image;
				using (MemoryStream ms = new MemoryStream())
				{
					img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					byte_image = ms.ToArray();
				}
			}
			str_usergroup = listview_usergroup.SelectedItems[0].Text;

			User_ds.Update_user(Obj_user.UserID, str_username, str_name, str_ic_no, date_join, date_leave, byte_image, str_usergroup);

			if (Obj_user.UserID == Program.System_user.UserID)
				Program.System_user = new User(Obj_user.UserID); // refresh current user details
		}
		private void Update_user_permissions()
		{
			//foreach (ListViewItem lv_item in listview_permissions.Items)
			//{
			//	if (Obj_user.Has_permission(lv_item.Text) && !lv_item.Checked)
			//	{
			//		// remove permission
			//		User_permission_DS.DELETE_user_permission(Obj_user.UserID, lv_item.Text);
			//	}
			//	else if (!Obj_user.Has_permission(lv_item.Text) && lv_item.Checked)
			//	{
			//		// add permission
			//		User_permission_DS.INSERT_user_permission(Obj_user.UserID, lv_item.Text);
			//	}
			//}
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Ch_empty_leave_date_CheckedChanged(object sender, EventArgs e)
		{
			dtp_leave.Enabled = !ch_empty_leave_date.Checked;
		}
		private void Btn_change_photo_Click(object sender, EventArgs e)
		{
			if (filedlg_img.ShowDialog() != DialogResult.OK) return;

			picbox_photo.ImageLocation = filedlg_img.FileName;

		}
		private void Btn_remove_photo_Click(object sender, EventArgs e)
		{
			picbox_photo.Image = null;
		}
		private void Form_edit_users_Shown(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(User_permission.EDIT_USER))
			{
				MessageBox.Show("You do not have permission to edit users!", "PERMISSION DENIED",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}
		private void Listview_usergroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listview_usergroup.Items.Count == 0 || listview_usergroup.SelectedIndices[0] < 0)
			{
				return;
			}

			grd_permission.DataSource = null;
			grd_permission.DataSource = Permission_ds.Select_permission_by_usergroup(listview_usergroup.SelectedItems[0].Text);
			grd_permission.Columns["permission"].Width = 160;
			grd_permission.Columns["permission_desc"].Width = 200;
		}
	}
}
