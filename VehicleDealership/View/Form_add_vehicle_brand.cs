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
	public partial class Form_add_vehicle_brand : Form
	{
		private int _int_brand_id = 0;
		public int BrandID
		{
			get
			{
				return _int_brand_id;
			}
		}
		public Form_add_vehicle_brand(int int_brand_id = 0)
		{
			InitializeComponent();

			_int_brand_id = int_brand_id;

			DataTable dttable_group = new DataTable();
			dttable_group.Columns.Add("group_name", typeof(string));

			grd_group.DataSource = null;
			grd_group.DataSource = dttable_group;


		}

		private void Form_add_vehicle_brand_Load(object sender, EventArgs e)
		{
			DataTable dttable_group = new DataTable();
			dttable_group.Columns.Add("group_name", typeof(string));

			grd_group.DataSource = null;
			grd_group.DataSource = dttable_group;

			if (_int_brand_id == 0) return;

			Vehicle_brand_ds.sp_select_vehicle_brand_n_groupDataTable dttable = Vehicle_brand_ds.Select_vehicle_brand_n_group(_int_brand_id);

			if (dttable.Rows.Count == 0) return;

			txt_brand_name.Text = dttable.Rows[0]["vehicle_brand_name"].ToString();
		}
	}
}
