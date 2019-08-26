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
using System.Data.SqlClient;

namespace VehicleDealership.View
{
	public partial class Form_person : Form
	{
		public int PersonID { get; private set; }
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
			grd_contact.Columns["person_contact_info"].Visible = Program.System_user.IsDeveloper; // hide if not in developer mode

			Class_combobox.Setup_combobox(cmb_type, Person_type_ds.Select_person_type(), "person_type_description", "person_type");
			Class_combobox.Setup_combobox(cmb_race, Race_ds.Select_race(), "race_description", "race");
			Class_combobox.Setup_combobox(cmb_country, Combobox_options_ds.Select_country(), "display", "value");
			cmb_country.SelectedValue = 133; // set default to malaysia

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

			cmb_type.SelectedValue = dt_row["person_type"].ToString();
			txt_driving_license.Text = dt_row["driving_license"].ToString();
			cmb_gender.SelectedValue = dt_row["gender"];
			cmb_race.SelectedValue = dt_row["race"];
			txt_address.Text = dt_row["address"].ToString();
			txt_city.Text = dt_row["city"].ToString();
			txt_state.Text = dt_row["state"].ToString();
			txt_postcode.Text = dt_row["postcode"].ToString();
			cmb_country.SelectedValue = dt_row["country"];
			txt_occupation.Text = dt_row["occupation"].ToString();
			txt_company.Text = dt_row["company"].ToString();
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{

			if (txt_name.Text.Trim() == "" || txt_ic_no.Text.Trim() == "")
			{
				MessageBox.Show("Name and IC no. are required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Class_datagridview.Apply_all_changes(grd_contact);

			Person_contact_info_DS.sp_select_person_contact_infoDataTable dttable_contact = (Person_contact_info_DS.sp_select_person_contact_infoDataTable)grd_contact.DataSource;

			var query_contact = from row in dttable_contact
								group row by row.contact into grp
								where grp.Count() > 1
								select grp.Key;

			if (query_contact.Count() > 0)
			{
				MessageBox.Show("Duplicate contact detected. Please check and retry.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			byte[] byte_image = null;
			if (picbox_image.Image != null)
			{
				Image img = picbox_image.Image;
				using (MemoryStream ms = new MemoryStream())
				{
					img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
					byte_image = ms.ToArray();
				}
			}
			PersonID = Person_ds.Insert_person(txt_name.Text.Trim(), txt_ic_no.Text.Trim(), byte_image,
				(int)cmb_type.SelectedValue, txt_driving_license.Text.Trim(), (bool)cmb_gender.SelectedValue,
				(int)cmb_race.SelectedValue, txt_address.Text.Trim(), txt_city.Text.Trim(), txt_state.Text.Trim(),
				txt_postcode.Text.Trim(), (int)cmb_country.SelectedValue, txt_occupation.Text.Trim(),
				txt_company.Text.Trim());

			if (PersonID == 0)
			{
				MessageBox.Show("An error has occurred. Person cannot be added.",
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DataColumn dt_col1 = new DataColumn("modified_by", typeof(int));
			dt_col1.DefaultValue = Program.System_user.UserID;
			dttable_contact.Columns.Add(dt_col1);

			Bulkcopy_table_ds.Delete_by_user();

			using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VehicleDealershipConnectionString))
			{
				conn.Open();

				using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
				{
					bulkCopy.DestinationTableName = "[misc].[bulkcopy_table]";

					try
					{
						bulkCopy.ColumnMappings.Add("person_contact_info", "int1");
						bulkCopy.ColumnMappings.Add("contact", "nvarchar1");
						bulkCopy.ColumnMappings.Add("remark", "nvarchar2");
						bulkCopy.ColumnMappings.Add("modified_by", "created_by");
						bulkCopy.WriteToServer(dttable_contact);
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error has occurred. Vehicle groups cannot be updated. \n\n Message: " +
							ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				conn.Close();
			}

			Person_contact_info_DS.Update_insert_person_contact_info(PersonID);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void Grd_contact_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			e.Row.Cells["remark"].Value = "";
		}

		private void Grd_contact_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			MessageBox.Show("Contact is required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			e.Cancel = true;
		}
	}
}
