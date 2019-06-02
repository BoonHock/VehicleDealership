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

namespace VehicleDealership.View
{
	public partial class Form_edit_users : Form
	{
		int int_edit_user = 0;
		private void Setup_form()
		{
			Classes.Class_listview.Setup_listview(listview_permissions, Permission_DS.SELECT_permissions());
		}
		public Form_edit_users()
		{
			InitializeComponent();
			Setup_form();
		}
		public Form_edit_users(int int_user_id)
		{
			InitializeComponent();
			Setup_form();

			int_edit_user = int_user_id;

			Classes.User Obj_user = new Classes.User(int_user_id);

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
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(Classes.User_permission.EDIT_USERS))
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
		private void Update_user_details ()
		{
			string str_username = txt_username.Text.Trim();
			string str_name = txt_name.Text.Trim();
			string str_ic_no = txt_ic_no.Text.Trim();
			DateTime date_join = dtp_join.Value;
			DateTime? date_leave = dtp_leave.Value;
			byte[] byte_image = null;

			if (str_username.Length == 0 || str_name.Length == 0 || str_ic_no.Length == 0)
			{
				MessageBox.Show("Username, Name and IC no./Passport no. is required.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Classes.User.Is_username_valid(str_username))
			{
				MessageBox.Show("Username is invalid. Only aphanumeric characters allowed for username. Please retry",
					"Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (Classes.User.Is_username_taken(str_username, int_edit_user))
			{
				MessageBox.Show("Username is taken.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (date_leave < date_join)
			{
				MessageBox.Show("Leave date cannot be before Join Date.", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (ch_empty_leave_date.Checked)
			{
				date_leave = null;
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

			Users_DS.UPDATE_user(int_edit_user, str_username, str_name, str_ic_no, date_join, date_leave, byte_image);

			if (int_edit_user == Program.System_user.UserID)
			{
				Program.System_user = new Classes.User(int_edit_user); // refresh current user details
			}
		}
		private void Update_user_permissions()
		{
			// @TODO: UPDATE USER PERMISSION
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
			if (!Program.System_user.Has_permission(Classes.User_permission.EDIT_USERS))
			{
				MessageBox.Show("You do not have permission to edit users!", "PERMISSION DENIED", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}
		}
	}
}
