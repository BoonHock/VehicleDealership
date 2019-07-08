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
		private bool _already_init_tab_permission = false;

		public Form_edit_users(int int_user)
		{
			InitializeComponent();

			Obj_user = new User(int_user);

			grd_usergroup.Enabled = (int_user != 1);
			linklbl_change_password.Visible = (int_user == Program.System_user.UserID);
		}
		private void Form_edit_users_Shown(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(User_permission.EDIT_USER))
			{
				MessageBox.Show("You do not have permission to edit users!", "PERMISSION DENIED",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}

			Class_style.Grd_style.Common_style(grd_permission);
			Class_style.Grd_style.Common_style(grd_usergroup);

			grd_usergroup.DataSource = Permission_ds.Select_usergroup();
			grd_usergroup.ClearSelection();
			grd_usergroup.CurrentCell = null;

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
			if (Obj_user.UserImage != null)
			{
				picbox_image.Image = Image.FromStream(new MemoryStream(Obj_user.UserImage));
			}
			if (Obj_user.UserGroup != null)
			{
				foreach (DataGridViewRow grd_row in grd_usergroup.Rows)
				{
					if (grd_row.Cells["usergroup"].Value.ToString() == Obj_user.UserGroup)
					{
						grd_usergroup.ClearSelection();
						grd_row.Cells["usergroup"].Selected = true;
						grd_usergroup.CurrentCell = grd_row.Cells["usergroup"];
						break;
					}
				}
			}
			grd_usergroup.RowEnter += Grd_usergroup_RowEnter;
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
			if (Update_user_details())
			{

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
		private bool Update_user_details()
		{
			string str_username = txt_username.Text.Trim();
			string str_name = txt_name.Text.Trim();
			string str_ic_no = txt_ic_no.Text.Trim();
			DateTime date_join = dtp_join.Value;
			DateTime? date_leave = (ch_empty_leave_date.Checked) ? (DateTime?)null : dtp_leave.Value;
			byte[] byte_image = null;

			if (str_username.Length == 0 || str_name.Length == 0)
			{
				MessageBox.Show("Username and Name is required.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (!User.Is_username_valid(str_username))
			{
				MessageBox.Show("Username is invalid. Only aphanumeric characters allowed for username. Please retry",
					"Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (!User.Is_username_available(str_username, Obj_user.UserID))
			{
				MessageBox.Show("Username is taken.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (date_leave != null && date_leave < date_join)
			{
				MessageBox.Show("Leave date cannot be before Join Date.", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (grd_usergroup.SelectedRows.Count == 0)
			{
				MessageBox.Show("Usergroup is required. Please go to 'Permission' tab to select usergroup.", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (picbox_image.Image != null)
			{
				Image img = picbox_image.Image;
				using (MemoryStream ms = new MemoryStream())
				{
					img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					byte_image = ms.ToArray();
				}
			}
			string str_usergroup = grd_usergroup.SelectedRows[0].Cells["usergroup"].Value.ToString();

			User_ds.Update_user(Obj_user.UserID, str_username, str_name, str_ic_no, date_join, date_leave, byte_image, str_usergroup);

			if (Obj_user.UserID == Program.System_user.UserID)
				Program.System_user = new User(Obj_user.UserID); // refresh current user details

			return true;
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
		private void Btn_change_image_Click(object sender, EventArgs e)
		{
			if (filedlg_img.ShowDialog() != DialogResult.OK) return;

			Image img = Image.FromFile(filedlg_img.FileName);

			picbox_image.Image = Resized_image(img, 400);
		}
		/// <summary>
		/// this should be plaed in miscellaneous class or something
		/// </summary>
		/// <param name="img"></param>
		/// <param name="box_size"></param>
		/// <param name="resize_only_if_bigger"></param>
		/// <returns></returns>
		private Image Resized_image(Image img, float box_size, bool resize_only_if_bigger = true)
		{
			if (resize_only_if_bigger && img.Height < box_size && img.Width < box_size) return img;

			float scaleHeight = (float)box_size / (float)img.Height;
			float scaleWidth = (float)box_size / (float)img.Width;

			float scale = Math.Min(scaleHeight, scaleWidth);

			return new Bitmap(img, (int)(img.Width * scale), (int)(img.Height * scale));

		}
		private void Btn_remove_image_Click(object sender, EventArgs e)
		{
			picbox_image.Image = null;
		}
		private void Grd_usergroup_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			Setup_grd_permission();
		}
		private void Setup_grd_permission()
		{
			if (grd_usergroup.SelectedCells.Count == 0) return;

			string str_usergroup = grd_usergroup.SelectedRows[0].Cells["usergroup"].Value.ToString();

			grd_permission.DataSource = null;
			grd_permission.DataSource = Permission_ds.Select_permission_by_usergroup(str_usergroup);
			grd_permission.Columns["permission"].Width = 160;
			grd_permission.Columns["permission_desc"].Width = 200;
		}
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedTab == tab_permission && !_already_init_tab_permission)
			{
				_already_init_tab_permission = true;

				grd_usergroup.AutoResizeColumns();
				grd_permission.AutoResizeColumns();

				Setup_grd_permission();
			}
		}
		private void Linklabel_change_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{

		}
	}
}
