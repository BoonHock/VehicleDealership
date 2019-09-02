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

namespace VehicleDealership.View
{
	public partial class Form_change_pw : Form
	{
		public Form_change_pw()
		{
			InitializeComponent();
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (txt_new_pw.Text.Length == 0)
			{
				MessageBox.Show("New password cannot be empty.", "Input invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Form_log_in.VerifyHash(txt_old_pw.Text, Program.System_user.Password))
			{
				MessageBox.Show("Old password entered is invalid.", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			User_ds.Update_user_password(Form_log_in.ComputeHash(txt_new_pw.Text,null));

			MessageBox.Show("Password successfully changed.");

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Ch_display_text_CheckedChanged(object sender, EventArgs e)
		{
			txt_old_pw.UseSystemPasswordChar = !Ch_display_text.Checked;
			txt_new_pw.UseSystemPasswordChar = !Ch_display_text.Checked;
		}
	}
}
