using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VehicleDealership.View
{
	public partial class Form_register_user : Form
	{
		public string Username { get; private set; }

		public Form_register_user()
		{
			InitializeComponent();
		}
		private void Form_register_user_Load(object sender, EventArgs e)
		{
			dtp_join_date.MaxDate = DateTime.Today;
		}
		private void Btn_register_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;

			Regex r = new Regex("^[a-zA-Z0-9]*$");
			Username = txt_username.Text.Trim();
			string str_password = txt_pw1.Text;
			string str_name = txt_fullname.Text.Trim();
			string str_ic_no = txt_ic_no.Text.Trim();

			if (Username.Length == 0 || str_password.Length == 0 || str_name.Length == 0 || str_ic_no.Length == 0)
			{
				MessageBox.Show("All fields are required.", "Missing input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!r.IsMatch(txt_username.Text))
			{
				MessageBox.Show("Only aphanumeric characters allowed for username. Please retry",
					"Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (Datasets.Users_DS.SELECT_user_by_username(Username).Rows.Count > 0)
			{
				MessageBox.Show("Username already in use.", "Username taken",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (str_ic_no.Length != 12)
			{
				MessageBox.Show("IC number is not in valid format. Please retry.", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Datasets.Users_DS.INSERT_user(Username, str_name, Form_log_in.ComputeHash(str_password, null), str_ic_no, dtp_join_date.Value);

			this.Close();
		}

		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
