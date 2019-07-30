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
		public Form_edit_vehicle_model(int? int_model = 0, int? int_group = null)
		{
			InitializeComponent();

			if (int_model != null) _int_model_id = (int)int_model;

			cmb_brand.DisplayMember = "display";
			cmb_brand.ValueMember = "value";
			cmb_brand.DataSource = Combobox_options_ds.Option_vehicle_brand();
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
		}

		private void Cmb_group_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
