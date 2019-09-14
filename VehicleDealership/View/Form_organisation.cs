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

			if (!Program.System_user.Has_permission(User_permission.ADD_EDIT_ORGANISATION))
			{
				// no permission to add/edit
				txt_name.ReadOnly = true;
				txt_registration_no.ReadOnly = true;
				txt_url.ReadOnly = true;
				grd_branch.ReadOnly = true;
				grd_contact.ReadOnly = true;

				cmb_country.Enabled = false;
				cmb_type.Enabled = false;
				btn_ok.Visible = false;
			}
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(User_permission.ADD_EDIT_ORGANISATION))
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
				return;
			}

			if (txt_name.Text.Trim() == "" || txt_registration_no.Text.Trim() == "")
			{
				MessageBox.Show("Name and registration no. are required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Organisation_contact_ds.sp_select_organisation_contactDataTable dttable_contact = (Organisation_contact_ds.sp_select_organisation_contactDataTable)grd_contact.DataSource;
			dttable_contact.AcceptChanges();
			Organisation_branch_ds.sp_select_organisation_branchDataTable dttable_branch = (Organisation_branch_ds.sp_select_organisation_branchDataTable)grd_branch.DataSource;
			dttable_branch.AcceptChanges();

			if (dttable_branch.Rows.Count == 0)
			{
				MessageBox.Show("At least ONE branch is required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// must use row["remark"] instead of row.remark because row.remarks is string type and cannot be dbnull. row["remark"] is object type and can be dbnull
			if ((from row in dttable_contact
				 where row.contact.Trim() == "" && (row["remark"] != DBNull.Value && row.remark.Trim() != "")
				 select row.contact).Count() > 0)
			{
				MessageBox.Show("Contact cannot be empty. Please check and retry.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if ((from row in dttable_branch
				 where row.branch_name.Trim() == ""
				 select row.branch_name).Count() > 0)
			{
				MessageBox.Show("Branch name cannot be empty. Please check and retry.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if ((from row in dttable_contact
				 group row by row.contact.Trim() into grp
				 where grp.Count() > 1
				 select grp.Key).Count() > 0)
			{
				MessageBox.Show("Duplicate contact detected. Please check and retry.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if ((from row in dttable_branch
				 group row by row.branch_name.Trim() into grp
				 where grp.Count() > 1
				 select grp.Key).Count() > 0)
			{
				MessageBox.Show("Duplicate branch name is not allowed. Please check and retry.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (OrganisationID == 0)
			{
				// insert
				OrganisationID = Organisation_ds.Insert_organisation(txt_name.Text.Trim(),
					txt_registration_no.Text.Trim(), (int)cmb_type.SelectedValue,
					(short)cmb_country.SelectedValue, txt_url.Text.Trim());
			}
			else
			{
				// update
				Organisation_ds.Update_organisation(OrganisationID, txt_name.Text.Trim(),
					txt_registration_no.Text.Trim(), (int)cmb_type.SelectedValue,
					(short)cmb_country.SelectedValue, txt_url.Text.Trim());
			}
			if (OrganisationID == 0)
			{
				MessageBox.Show("An error has occurred.", "ERROR",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VehicleDealershipConnectionString))
			{
				conn.Open();

				using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
				{
					bulkCopy.DestinationTableName = "[misc].[bulkcopy_table]";

					// upload contact information
					Bulkcopy_table_ds.Delete_by_user();
					try
					{
						DataColumn dt_col1 = new DataColumn("modified_by", typeof(int));
						dt_col1.DefaultValue = Program.System_user.UserID;
						dttable_contact.Columns.Add(dt_col1);

						bulkCopy.ColumnMappings.Add("contact", "nvarchar1");
						bulkCopy.ColumnMappings.Add("remark", "nvarchar2");
						bulkCopy.ColumnMappings.Add("modified_by", "created_by");
						bulkCopy.WriteToServer(dttable_contact);

						Organisation_contact_ds.Update_insert_organisation_contact(OrganisationID);
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error has occurred. Contact cannot be updated. \n\n Message: " +
							ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

					// upload branch information
					Bulkcopy_table_ds.Delete_by_user();
					try
					{
						DataColumn dt_col1 = new DataColumn("modified_by", typeof(int));
						dt_col1.DefaultValue = Program.System_user.UserID;
						dttable_branch.Columns.Add(dt_col1);

						bulkCopy.ColumnMappings.Add("branch_name", "nvarchar1");
						bulkCopy.ColumnMappings.Add("address", "nvarchar2");
						bulkCopy.ColumnMappings.Add("city", "nvarchar3");
						bulkCopy.ColumnMappings.Add("state", "nvarchar4");
						bulkCopy.ColumnMappings.Add("postcode", "nvarchar5");
						bulkCopy.ColumnMappings.Add("organisation_branch", "int1");
						bulkCopy.ColumnMappings.Add("country", "int2");
						bulkCopy.ColumnMappings.Add("modified_by", "created_by");
						bulkCopy.WriteToServer(dttable_contact);

						Organisation_branch_ds.Update_insert_organisation_branch(OrganisationID);
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error has occurred. Branch cannot be updated. \n\n Message: " +
							ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				conn.Close();
			}

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
			if (!Program.System_user.Has_permission(User_permission.VIEW_ORGANISATION) &&
				!Program.System_user.Has_permission(User_permission.ADD_EDIT_ORGANISATION))
			{
				MessageBox.Show("You do not have sufficient permission to perform this action!",
					"ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			// ##################### GRD_CONTACT #####################
			grd_contact.DataSource = Organisation_contact_ds.Select_organisation_contact(OrganisationID);
			grd_contact.AutoResizeColumns();
			// database column nvarchar length is 100
			Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_contact, "contact", "remark");
			// allow dbnull because empty string will enter dbnull to datagridviewcolumn
			((DataTable)grd_contact.DataSource).Columns["remark"].AllowDBNull = true;
			// ##################### END GRD_CONTACT #####################

			Country_ds.sp_select_countryDataTable dttable_country = Country_ds.Select_country();

			// ##################### GRD_BRANCH #####################
			Organisation_branch_ds.sp_select_organisation_branchDataTable dttable_branch = Organisation_branch_ds.Select_organisation_branch(OrganisationID);

			dttable_branch.Columns["address"].AllowDBNull = true;
			dttable_branch.Columns["city"].AllowDBNull = true;
			dttable_branch.Columns["state"].AllowDBNull = true;
			dttable_branch.Columns["postcode"].AllowDBNull = true;
			dttable_branch.Columns.Remove("modified_by");// no need show this

			grd_branch.DataSource = dttable_branch;
			grd_branch.Columns["organisation_branch"].Visible = false;
			grd_branch.AutoResizeColumns();
			grd_branch.AutoResizeRows();

			Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_branch, "branch_name", "address", "city", "state", "postcode");
			Class_datagridview.Replace_column_with_combobox_column(grd_branch, "country", dttable_country.Copy(), "country_name", "country");
			grd_branch.Columns["address"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			// ##################### END GRD_BRANCH #####################

			Class_combobox.Setup_combobox(cmb_type, Organisation_type_ds.Select_organisation_type(),
				"organisation_type_description", "organisation_type");
			cmb_type.SelectedValue = 1; // set default value to CORPORATE
			Class_combobox.Setup_combobox(cmb_country, dttable_country.Copy(), "country_name", "country");
			cmb_country.SelectedValue = 133; // set default to malaysia

			if (OrganisationID == 0) return; // zero means adding new org

			Organisation_ds.sp_select_organisationDataTable dttable_org = Organisation_ds.Select_organisation(OrganisationID);
			if (dttable_org.Rows.Count == 0) return;

			txt_name.Text = dttable_org[0].name;
			txt_registration_no.Text = dttable_org[0].registration_no;
			cmb_country.SelectedValue = dttable_org[0].country;
			cmb_type.SelectedValue = dttable_org[0].organisation_type;
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
			Class_datagridview.Remove_row_of_selected_cells((DataGridView)sender);
		}

		private void Grd_branch_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			e.Row.Cells["branch_name"].Value = "";
			e.Row.Cells["address"].Value = "";
			e.Row.Cells["city"].Value = "";
			e.Row.Cells["state"].Value = "";
			e.Row.Cells["postcode"].Value = "";
			e.Row.Cells["country"].Value = cmb_country.SelectedValue;
		}
		private void Grd_branch_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			MessageBox.Show("Branch name is required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			e.Cancel = true;
		}
	}
}
