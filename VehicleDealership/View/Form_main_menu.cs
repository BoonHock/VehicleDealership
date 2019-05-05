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
using VehicleDealership.Classes;

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
			//grd_test.DataSource = Model.Users_DS.SELECT_user("", "");
			//Object.assignHandler((sender) => evHandler(sender, someData));
			salesOrderToolStripMenuItem.Click += (sender2, e2) => Open_form(new Form_sales_order());

		}
		private void Open_form(Form form_to_open, bool is_maximised = false, string form_tag = "")
		{
			if (Open_active_form(form_to_open)) return;

			form_to_open.MdiParent = this;
			if (is_maximised) form_to_open.WindowState = FormWindowState.Maximized;
			form_to_open.Tag = form_tag;
			form_to_open.Show();
		}
		private bool Open_active_form(Form form_to_check)
		{
			foreach (Form f in Application.OpenForms)
			{
				if (f.GetType() == form_to_check.GetType())
				{
					f.Activate();
					return true;
				}
			}
			return false;
		}
	}
}
