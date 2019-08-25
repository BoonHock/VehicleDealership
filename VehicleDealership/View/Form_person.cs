using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Datasets;
using VehicleDealership.Classes;

namespace VehicleDealership.View
{
	public partial class Form_person : Form
	{
		private readonly int PersonID = 0;
		public Form_person(int int_person = 0)
		{
			InitializeComponent();

			PersonID = int_person;
		}
		private void Btn_change_image_Click(object sender, EventArgs e)
		{
			if (filedlg_img.ShowDialog() != DialogResult.OK) return;

			picbox_image.Image = Class_misc.Resized_image(Image.FromFile(filedlg_img.FileName), 400);
		}
		private void Btn_remove_image_Click(object sender, EventArgs e)
		{
			picbox_image.Image = null;
		}
		private void Form_person_Shown(object sender, EventArgs e)
		{
			grd_contact.DataSource = Person_contact_info_DS.Select_Person_Contact_Info(PersonID);
			grd_contact.AutoResizeColumns();

			Class_combobox.Setup_combobox(cmb_type, Person_org_type_ds.Select_person_org_type(), "person_org_type", "person_org_description");
			Class_combobox.Setup_combobox(cmb_race, Race_ds.Select_race(), "race", "race_description");
			Class_combobox.Setup_combobox(cmb_country, Combobox_options_ds.Select_country(), "display", "value");

			DataTable dttable_gender = new DataTable();
			dttable_gender.Columns.Add("display");
			dttable_gender.Columns.Add("value");
			dttable_gender.Rows.Add("MALE", true);
			dttable_gender.Rows.Add("FEMALE", false);

			Class_combobox.Setup_combobox(cmb_gender, dttable_gender, "display", "value");

			if (PersonID != 0) return; // if zero means adding new person instead of editing

			Person_ds.sp_select_personDataTable dttable_person = Person_ds.Select_person(PersonID);
			if (dttable_person.Rows.Count == 0) return;

			DataRow dt_row = dttable_person.Rows[0];

			txt_name.Text = dt_row["name"].ToString();
			txt_ic_no.Text = dt_row["ic_no"].ToString();

			if (dttable_person.Rows[0]["image"] != DBNull.Value)
				picbox_image.Image = Image.FromStream(new MemoryStream((byte)dt_row["image"]));

			cmb_type.SelectedValue = dt_row["person_org_type"].ToString();
			txt_driving_license.Text = dt_row["driving_license"].ToString();
			cmb_gender.SelectedValue = dt_row["gender"];
			cmb_race.SelectedValue = dt_row["race"];
			txt_address.Text = dt_row["address"].ToString();
			txt_city.Text = dt_row["city"].ToString();
			txt_state.Text = dt_row["state"].ToString();
			txt_postcode.Text = dt_row["postcode"].ToString();
			cmb_country.SelectedValue = dt_row["country"];
			txt_occupation.Text= dt_row["occupation"].ToString();
			txt_company.Text = dt_row["company"].ToString();
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			string str_name = txt_name.Text.Trim();

			if (str_name == "")
			{
				MessageBox.Show("Name is required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}



			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
