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
	public partial class Form_sales_order : Form
	{
		public Form_sales_order()
		{
			InitializeComponent();
		}

		private void Form_sales_order_Load(object sender, EventArgs e)
		{
			rad_all.CheckedChanged += Rad_so_status_CheckedChanged;
			rad_active.CheckedChanged += Rad_so_status_CheckedChanged;
			rad_inactive.CheckedChanged += Rad_so_status_CheckedChanged;
		}

		private void Rad_so_status_CheckedChanged(object sender, EventArgs e)
		{
			Setup_grd_sales_order();
		}
		private void Setup_grd_sales_order()
		{
			string str_search = Txt_search.Text.Trim();

		}
		private void Ts_insert_Click(object sender, EventArgs e)
		{

		}
		private void Ts_edit_Click(object sender, EventArgs e)
		{

		}
		private void Ts_delete_Click(object sender, EventArgs e)
		{

		}
	}
}
