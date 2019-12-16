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

			grd_contact.MouseDown += Class_datagridview.MouseDown_select_cell;

			if (!Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_PERSON))
			{
				// no permission to add/edit

				txt_name.ReadOnly = true;
				txt_ic_no.ReadOnly = true;
				txt_driving_license.ReadOnly = true;
				txt_address.ReadOnly = true;
				txt_city.ReadOnly = true;
				txt_state.ReadOnly = true;
				txt_postcode.ReadOnly = true;
				txt_occupation.ReadOnly = true;
				txt_company.ReadOnly = true;
				txt_url.ReadOnly = true;
				grd_contact.ReadOnly = true;

				cmb_type.Enabled = false;
				cmb_gender.Enabled = false;
				cmb_race.Enabled = false;
				cmb_country.Enabled = false;
				btn_change_image.Enabled = false;
				btn_remove_image.Enabled = false;

				btn_ok.Visible = false;
			}
		}
		private void Btn_change_image_Click(object sender, EventArgs e)
		{
			if (filedlg_img.ShowDialog() != DialogResult.OK) return;

			picbox_image.Image = Class_image.Resize_image(Image.FromFile(filedlg_img.FileName), 400);
		}
		private void Btn_remove_image_Click(object sender, EventArgs e)
		{
			picbox_image.Image = null;
		}
		private void Form_person_Shown(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(Class_enum.User_permission.VIEW_PERSON) && !Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_PERSON))
			{
				MessageBox.Show("You do not have sufficient permission to perform this action!",
					"ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			grd_contact.DataSource = Person_contact_ds.Select_person_contact(PersonID);
			grd_contact.AutoResizeColumns();
			// database column nvarchar length is 100
			Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_contact, "contact", "remark");
			// allow dbnull because user is 
			((DataTable)grd_contact.DataSource).Columns["remark"].AllowDBNull = true;

			Class_combobox.Setup_combobox(cmb_type, Person_type_ds.Select_person_type(), "person_type_description", "person_type");
			cmb_type.SelectedValue = 1; // set default to INDIVIDUAL
			Class_combobox.Setup_combobox(cmb_race, Race_ds.Select_race(), "race_description", "race");
			Class_combobox.Setup_combobox(cmb_country, Country_ds.Select_country(), "country_name", "country");
			cmb_country.SelectedValue = 133; // set default to malaysia

			DataTable dttable_gender = new DataTable();
			dttable_gender.Columns.Add("display");
			dttable_gender.Columns.Add("value");
			dttable_gender.Rows.Add("MALE", "MALE");
			dttable_gender.Rows.Add("FEMALE", "FEMALE");

			Class_combobox.Setup_combobox(cmb_gender, dttable_gender, "display", "value");

			if (PersonID == 0) return; // if zero means adding new person instead of editing

			using (Person_ds.sp_select_personDataTable dttable_person = Person_ds.Select_person(PersonID))
			{
				if (dttable_person.Rows.Count == 0) return;

				txt_name.Text = dttable_person[0].name;
				txt_ic_no.Text = dttable_person[0].ic_no;

				if (dttable_person.Rows[0]["image"] != DBNull.Value)
					picbox_image.Image = Image.FromStream(new MemoryStream(dttable_person[0].image));

				cmb_type.SelectedValue = dttable_person[0].person_type;
				txt_driving_license.Text = dttable_person[0].driving_license;
				cmb_gender.SelectedValue = (dttable_person[0].gender) ? "MALE" : "FEMALE";
				cmb_race.SelectedValue = dttable_person[0].race;
				txt_address.Text = dttable_person[0].address;
				txt_city.Text = dttable_person[0].city;
				txt_state.Text = dttable_person[0].state;
				txt_postcode.Text = dttable_person[0].postcode;
				cmb_country.SelectedValue = dttable_person[0].country;
				txt_occupation.Text = dttable_person[0].occupation;
				txt_company.Text = dttable_person[0].company;
				txt_url.Text = dttable_person[0].url;
			}
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_PERSON))
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
				return;
			}

			if (txt_name.Text.Trim() == "" || txt_ic_no.Text.Trim() == "")
			{
				MessageBox.Show("Name and IC no. are required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Person_contact_ds.sp_select_person_contactDataTable dttable_contact = (Person_contact_ds.sp_select_person_contactDataTable)grd_contact.DataSource;
			dttable_contact.AcceptChanges();

			// must use row["remark"] instead of row.remark because row.remarks is string type and cannot be dbnull. row["remark"] is object type and can be dbnull
			var query_check_empty = from row in dttable_contact
									where row.contact.Trim() == "" && (row["remark"] != DBNull.Value && row.remark.Trim() != "")
									select row;

			if (query_check_empty.Count() > 0)
			{
				MessageBox.Show("Contact cannot be empty. Please check and retry.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

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

			// set byte image to null if no image. null value will set db column to null
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

			if (PersonID == 0)
			{
				// insert
				PersonID = Person_ds.Insert_person(txt_name.Text.Trim(), txt_ic_no.Text.Trim(),
					byte_image, (int)cmb_type.SelectedValue, txt_driving_license.Text.Trim(),
					(cmb_gender.SelectedValue.ToString() == "MALE"), (int)cmb_race.SelectedValue,
					txt_address.Text.Trim(), txt_city.Text.Trim(), txt_state.Text.Trim(),
					txt_postcode.Text.Trim(), (short)cmb_country.SelectedValue, txt_occupation.Text.Trim(),
					txt_company.Text.Trim(), txt_url.Text.Trim());
			}
			else
			{
				// update
				Person_ds.Update_person(PersonID, txt_name.Text.Trim(), txt_ic_no.Text.Trim(),
					byte_image, (int)cmb_type.SelectedValue, txt_driving_license.Text.Trim(),
					(cmb_gender.SelectedValue.ToString() == "MALE"), (int)cmb_race.SelectedValue,
					txt_address.Text.Trim(), txt_city.Text.Trim(), txt_state.Text.Trim(),
					txt_postcode.Text.Trim(), (short)cmb_country.SelectedValue, txt_occupation.Text.Trim(),
					txt_company.Text.Trim(), txt_url.Text.Trim());
			}
			// at this point, personID must be positive integer. 
			if (PersonID == 0)
			{
				MessageBox.Show("An error has occurred.", "ERROR",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// upload contact information
			DataColumn dt_col1 = new DataColumn("modified_by", typeof(int))
			{
				DefaultValue = Program.System_user.UserID
			};
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

			Person_contact_ds.Update_insert_person_contact(PersonID);

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

		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Class_datagridview.Remove_row_of_selected_cells(grd_contact);
		}
	}
}
