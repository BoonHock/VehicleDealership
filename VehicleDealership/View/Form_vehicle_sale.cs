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
using VehicleDealership.Classes;

namespace VehicleDealership.View
{
	public partial class Form_vehicle_sale : Form
	{
		public int VehicleID { get; private set; }
		public Form_vehicle_sale(int int_vehicle = 0)
		{
			InitializeComponent();

			VehicleID = int_vehicle;
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{

		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{

		}
		private void Form_vehicle_sale_Shown(object sender, EventArgs e)
		{
			cmb_vehicle_colour.DisplayMember = "colour_name";
			cmb_vehicle_colour.ValueMember = "colour";
			cmb_vehicle_colour.DataSource = Colour_ds.Select_colour();


		}
	}
}
