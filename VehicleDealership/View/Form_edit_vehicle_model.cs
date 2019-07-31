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
	public partial class Form_edit_vehicle_model : Form
	{
		private int _int_model_id = 0;
		public int Model_id
		{
			get
			{
				return _int_model_id;
			}
		}
		public Form_edit_vehicle_model(int int_group = 0)
		{
			InitializeComponent();

			cmb_brand.DisplayMember = "display";
			cmb_brand.ValueMember = "value";
			cmb_brand.DataSource = Combobox_options_ds.Option_vehicle_brand();

			cmb_fuel_type.DisplayMember = "display";
			cmb_fuel_type.ValueMember = "value";
			cmb_fuel_type.DataSource = Combobox_options_ds.Select_fuel_type();

			cmb_transmission.DisplayMember = "display";
			cmb_transmission.ValueMember = "value";
			cmb_transmission.DataSource = Combobox_options_ds.Select_transmission();

			Vehicle_brand_ds.vehicle_brandDataTable dttable_brand = Vehicle_brand_ds.Select_veh_brand_by_veh_group(int_group);

			if (dttable_brand.Rows.Count > 0)
				cmb_brand.SelectedValue = dttable_brand.Rows[0]["vehicle_brand"];

			cmb_group.SelectedValue = int_group;

			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Initilise_grd_img);
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			string str_model_name = txt_model_name.Text;


			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void Cmb_brand_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_brand.SelectedIndex < 0) return;

			Vehicle_group_ds.sp_select_vehicle_brand_n_groupDataTable dttable =
				Vehicle_group_ds.Select_vehicle_brand_n_group(int.Parse(cmb_brand.SelectedValue.ToString()));

			txt_country.Text = dttable.Rows[0]["country_name"].ToString();

			DataTable dttable_group = new DataTable();
			dttable_group.Columns.Add("value");
			dttable_group.Columns.Add("display");

			foreach (var i in dttable.Select(i => new { i.vehicle_group, i.vehicle_group_name }).OrderBy(i => i.vehicle_group_name))
			{
				dttable_group.Rows.Add(i.vehicle_group, i.vehicle_group_name);
			}

			cmb_group.DataSource = null;
			cmb_group.DisplayMember = "display";
			cmb_group.ValueMember = "value";
			cmb_group.DataSource = dttable_group;

			if (cmb_group.Items.Count > 0) cmb_group.SelectedIndex = 0;
		}

		private void Initilise_grd_img(object sender, EventArgs e)
		{
			// set up grd_image when image tab is selected for the first time after form loads
			grd_img.DataSource = null;
			grd_img.DataSource = vehicle_model_image_ds.Select_vehicle_model_image(_int_model_id);

			// detach event handler after initilising images.
			this.tabControl1.SelectedIndexChanged -= new System.EventHandler(this.Initilise_grd_img);
		}
	}
}
