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
using System.Data.SqlClient;

namespace VehicleDealership.View
{
	public partial class Form_organisation : Form
	{
		public int OrganisationID { get; private set; }
		public Form_organisation(int int_org = 0)
		{
			InitializeComponent();

			OrganisationID = int_org;
			grd_contact.MouseDown += Class_datagridview.MouseDown_select_cell;
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (txt_name.Text.Trim() == "" || txt_registration_no.Text.Trim() == "")
			{
				MessageBox.Show("Name and registration no. are required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Organisation_contact_ds.sp_select_organisation_contactDataTable dttable_contact = (Organisation_contact_ds.sp_select_organisation_contactDataTable)grd_contact.DataSource;
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

			if (OrganisationID == 0)
			{
				// insert
				OrganisationID = Organisation_ds.Insert_organisation(txt_name.Text.Trim(),
					txt_registration_no.Text.Trim(), (int)cmb_type.SelectedValue, txt_branch.Text.Trim(),
					txt_address.Text.Trim(), txt_city.Text.Trim(), txt_state.Text.Trim(),
					txt_postcode.Text.Trim(), (short)cmb_country.SelectedValue, txt_url.Text.Trim());
			}
			else
			{
				// update
				Organisation_ds.Update_organisation(OrganisationID, txt_name.Text.Trim(),
					txt_registration_no.Text.Trim(), (int)cmb_type.SelectedValue, txt_branch.Text.Trim(),
					txt_address.Text.Trim(), txt_city.Text.Trim(), txt_state.Text.Trim(),
					txt_postcode.Text.Trim(), (short)cmb_country.SelectedValue, txt_url.Text.Trim());
			}
			if (OrganisationID == 0)
			{
				MessageBox.Show("An error has occurred.", "ERROR",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			// upload contact information
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

			Organisation_contact_ds.Update_insert_organisation_contact(OrganisationID);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Form_organisation_Shown(object sender, EventArgs e)
		{
			grd_contact.DataSource = Organisation_contact_ds.Select_organisation_contact(OrganisationID);
			grd_contact.AutoResizeColumns();
			// database column nvarchar length is 100
			Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_contact, "contact");
			Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_contact, "remark");
			// allow dbnull because user is 
			((DataTable)grd_contact.DataSource).Columns["remark"].AllowDBNull = true;

			Class_combobox.Setup_combobox(cmb_type, Organisation_type_ds.Select_organisation_type(),
				"organisation_type_description", "organisation_type");
			cmb_type.SelectedValue = 1; // set default value to CORPORATE
			Class_combobox.Setup_combobox(cmb_country, Country_ds.Select_country(), "country_name", "country");
			cmb_country.SelectedValue = 133; // set default to malaysia

			if (OrganisationID == 0) return; // zero means adding new org

			Organisation_ds.sp_select_organisationDataTable dttable_org = Organisation_ds.Select_organisation(OrganisationID);
			if (dttable_org.Rows.Count == 0) return;

			txt_name.Text = dttable_org[0].name;
			txt_registration_no.Text = dttable_org[0].registration_no;
			txt_address.Text = dttable_org[0].address;
			txt_city.Text = dttable_org[0].city;
			txt_state.Text = dttable_org[0].state;
			txt_postcode.Text = dttable_org[0].postcode;
			cmb_country.SelectedValue = dttable_org[0].country;
			cmb_type.SelectedValue = dttable_org[0].organisation_type;
			txt_branch.Text = dttable_org[0].branch;
			txt_url.Text = dttable_org[0].url;
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
