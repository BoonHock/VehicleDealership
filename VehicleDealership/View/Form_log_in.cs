using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace VehicleDealership.View
{
	public partial class Form_log_in : Form
	{
		public Form_log_in()
		{
			InitializeComponent();
		}
		private void Btn_log_in_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			if (Log_in())
			{
				// logged in
				Cursor.Current = Cursors.Default;
				this.DialogResult = DialogResult.OK;
				this.Close();
				return;
			}
			Cursor.Current = Cursors.Default;
			lbl_invalid_login.Visible = true;
		}
		private bool Log_in()
		{
			string str_username = txt_username.Text;
			string str_password = txt_password.Text;

			return (Model.Users_DS.SELECT_user(str_username, str_password).Rows.Count > 0);
		}

	}
}
