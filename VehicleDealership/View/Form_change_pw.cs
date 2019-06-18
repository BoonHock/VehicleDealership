using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDealership.View
{
	public partial class Form_change_pw : Form
	{
		public Form_change_pw(int int_user)
		{
			InitializeComponent();

			txt_old_pw.Enabled = (Program.System_user.UserID == 1); // admin doesn't need to 
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{

		}

		private void Btn_cancel_Click(object sender, EventArgs e)
		{

		}
	}
}
