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
using System.IO;

namespace VehicleDealership.View
{
	public partial class Form_edit_vehicle_model : Form
	{
		const int GRD_IMAGE_ROW_HEIGHT = 50;

		private string _str_ori_edit_model_name = "";
		private vehicle_model_image_ds.sp_select_vehicle_model_imageDataTable dttable_img = new vehicle_model_image_ds.sp_select_vehicle_model_imageDataTable();

		public int Model_id { private set; get; } = 0;

		public Form_edit_vehicle_model(int int_group = 0, int int_model = 0)
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

			if (int_group != 0)
			{
				Vehicle_brand_ds.vehicle_brandDataTable dttable_brand = Vehicle_brand_ds.Select_veh_brand_by_veh_group(int_group);

				if (dttable_brand.Rows.Count > 0)
					cmb_brand.SelectedValue = dttable_brand.Rows[0]["vehicle_brand"];

				cmb_group.SelectedValue = int_group;
			}
			if (int_model != 0)
			{
				Model_id = int_model;
				Vehicle_model_ds.sp_select_vehicle_modelDataTable dttable = Vehicle_model_ds.
					Select_vehicle_model(-1, -1, -1, int_model);

				if (dttable.Rows.Count > 0)
				{
					_str_ori_edit_model_name = dttable.Rows[0]["vehicle_model_name"].ToString();
					txt_model_name.Text = dttable.Rows[0]["vehicle_model_name"].ToString();
					cmb_brand.SelectedValue = dttable.Rows[0]["vehicle_brand"].ToString();
					txt_country.Text = dttable.Rows[0]["country_name"].ToString();
					cmb_group.SelectedValue = dttable.Rows[0]["vehicle_group"].ToString();
					num_engine.Value = int.Parse(dttable.Rows[0]["engine_capacity"].ToString());
					num_no_of_door.Value = int.Parse(dttable.Rows[0]["no_of_door"].ToString());
					num_seat_capacity.Value = int.Parse(dttable.Rows[0]["seat_capacity"].ToString());
					cmb_fuel_type.SelectedValue = int.Parse(dttable.Rows[0]["fuel_type"].ToString());
					cmb_transmission.SelectedValue = int.Parse(dttable.Rows[0]["transmission"].ToString());
					txt_remarks.Text = dttable.Rows[0]["Remarks"].ToString();
				}
			}

			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.Initilise_grd_img);
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			string str_model_name = txt_model_name.Text.Trim();
			int int_group = int.Parse(cmb_group.SelectedValue.ToString());
			int int_engine_cc = (int)num_engine.Value;
			int int_door = (int)num_no_of_door.Value;
			int int_seat = (int)num_seat_capacity.Value;
			int int_fuel = int.Parse(cmb_fuel_type.SelectedValue.ToString());
			int int_transmission = int.Parse(cmb_transmission.SelectedValue.ToString());
			string str_remarks = txt_remarks.Text.Trim();

			if (str_model_name == "")
			{
				MessageBox.Show("Model name is required.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// if user is editing and doesn't change model name, no need to check if username taken.
			if (_str_ori_edit_model_name != str_model_name)
			{
				if (!Vehicle_model_ds.Is_vehicle_model_name_available(str_model_name, int_group))
				{
					MessageBox.Show("Save failed. There is already a vehicle model named \"" + str_model_name + "\" in this vehicle group.", "Duplicate blonde harir", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			if (Model_id == 0)
			{
				// insert
				Model_id = Vehicle_model_ds.Insert_vehicle_model(str_model_name, int_group,
					int_engine_cc, int_door, int_seat, int_fuel, int_transmission, str_remarks);

				// if _int_model_id is still 0 means insert got error. insert will return last inserted id which definitely isn't 0
				if (Model_id == 0) return;
			}
			else
			{
				// edit
				if (!Vehicle_model_ds.Update_vehicle_model(str_model_name, int_group, int_engine_cc, int_door, int_seat, int_fuel, int_transmission, str_remarks, Model_id)) return;
			}

			// TODO: save images/ update image description

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
			dttable_img = vehicle_model_image_ds.Select_vehicle_model_image(Model_id);

			grd_img.DataSource = null;
			grd_img.DataSource = dttable_img;

			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_img, new string[] { "image" });

			((DataGridViewImageColumn)grd_img.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;

			foreach (DataGridViewRow grd_row in grd_img.Rows)
			{
				grd_row.Height = GRD_IMAGE_ROW_HEIGHT;
			}

			// detach event handler after initilising images.
			this.tabControl1.SelectedIndexChanged -= new System.EventHandler(this.Initilise_grd_img);
		}

		private void Btn_add_img_Click(object sender, EventArgs e)
		{
			if (filedlg_img.ShowDialog() != DialogResult.OK) return;

			Cursor = Cursors.WaitCursor;

			int int_new_id = 0;

			if (dttable_img.Rows.Count > 0)
			{
				int_new_id = (from row in dttable_img
							  select row.vehicle_model_image).ToList().Min();
			}

			foreach (string str_filename in filedlg_img.FileNames)
			{
				int_new_id -= 1;

				dttable_img.Rows.Add(int_new_id,
					Class_misc.Image_to_byte_array(Class_misc.Resized_image(Image.FromFile(str_filename), 800)),
					"", Program.System_user.Name, DateTime.Now);

				grd_img.Rows[grd_img.Rows.Count - 1].Height = GRD_IMAGE_ROW_HEIGHT;
			}

			Cursor = Cursors.Default;
		}

		private void Grd_img_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (grd_img.SelectedCells.Count == 0) return;

			picbox.Image = Class_misc.Byte_array_to_image((byte[])grd_img.SelectedCells[0].OwningRow.Cells["image"].Value);

			txt_img_description.Text = grd_img.SelectedCells[0].OwningRow.Cells["image_description"].Value.ToString();
			txt_img_created_by.Text = grd_img.SelectedCells[0].OwningRow.Cells["created_by"].Value.ToString();
			txt_img_created_on.Text = grd_img.SelectedCells[0].OwningRow.Cells["created_on"].Value.ToString();

			// txt and btn was initialised to disabled so that only when image is loaded, there will something for user to edit
			txt_img_description.ReadOnly = false;
			btn_update_img_desc.Enabled = true;
		}

		private void Btn_update_img_desc_Click(object sender, EventArgs e)
		{
			int int_image_id = int.Parse(grd_img.SelectedCells[0].OwningRow.Cells["vehicle_model_image"].Value.ToString());

			foreach (DataRow dt_row in dttable_img.Rows)
			{
				if ((int)dt_row["vehicle_model_image"] == int_image_id)
				{
					dt_row["image_description"] = txt_img_description.Text;
					break;
				}
			}
		}
	}
}
