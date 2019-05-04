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

namespace VehicleDealership.View
{
	public partial class Form_main_menu : Form
	{
		public Form_main_menu()
		{
			InitializeComponent();
		}

		private void Form_main_menu_Load(object sender, EventArgs e)
		{
			grd_test.DataSource = Model.Users_DS.SELECT_user("", "");
		}
		private bool Log_in()
		{
			Form form_login = new Form_log_in();
			if (form_login.DialogResult == DialogResult.OK)
			{
				
			}
			return false;
		}
	}
}
