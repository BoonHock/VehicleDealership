using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Classes;
using VehicleDealership.Datasets;

namespace VehicleDealership.View
{
	public partial class Form_simulate_user : Form
	{
		public Form_simulate_user()
		{
			InitializeComponent();
		}
		private void Form_simulate_user_Load(object sender, EventArgs e)
		{
			Setup_grd();
		}
		private void Txt_search_TextChanged(object sender, EventArgs e)
		{

		}
		private void Setup_grd()
		{
			//string str_search = Txt_search.Text.Trim();

			//Grd_users.DataSource = null;
			//Grd_users.DataSource = Class_datatable.Remove_columns(Users_DS.
			//	SELECT_user_by_search(str_search), new string[] { "Password", "Photo" });
		}
	}
}
