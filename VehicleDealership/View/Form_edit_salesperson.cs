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
	public partial class Form_edit_salesperson : Form
	{
		public int SalespersonID { get; private set; } = 0;

		readonly bool _is_person = false;
		readonly int _person_orgbranch_id;

		/// <summary>
		/// this constructor is for EDITING existing salesperson
		/// </summary>
		/// <param name="int_salesperson"></param>
		public Form_edit_salesperson(int int_salesperson)
		{
			InitializeComponent();

			SalespersonID = int_salesperson;

			Salesperson_ds.sp_select_salespersonDataTable dttable_salesperson = Salesperson_ds.Select_salesperson(SalespersonID);

			if (dttable_salesperson.Rows.Count > 0)
			{
				if (dttable_salesperson.Rows[0]["person"] == DBNull.Value)
				{
					_is_person = false;
					_person_orgbranch_id = dttable_salesperson[0].organisation_branch;
				}
				else
				{
					_is_person = true;
					_person_orgbranch_id = dttable_salesperson[0].person;
				}

				dtp_join.Value = dttable_salesperson[0].date_join;
				if (dttable_salesperson.Rows[0]["date_leave"] != DBNull.Value)
				{
					dtp_leave.Checked = true;
					dtp_leave.Value = dttable_salesperson[0].date_leave;
				}
				txt_location.Text = dttable_salesperson[0].location;
				txt_remark.Text = dttable_salesperson[0].remark;
			}
		}
		/// <summary>
		/// this constructor is for ADDING new salesperson
		/// </summary>
		/// <param name="int_person_orgbranch">person ID or organisation ID</param>
		/// <param name="is_person">true if is person, false if is organisation</param>
		public Form_edit_salesperson(int int_person_orgbranch, bool is_person)
		{
			InitializeComponent();

			_is_person = is_person;
			_person_orgbranch_id = int_person_orgbranch;
		}
		private void Form_edit_salesperson_Shown(object sender, EventArgs e)
		{
			Class_style.Grd_style.Common_style(grd_contact);

			if (!Program.System_user.Has_permission(Class_enum.User_permission.VIEW_SALESPERSON) &&
				!Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_SALESPERSON))
			{
				MessageBox.Show("You do not have sufficient permission to perform this action!",
					"ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			if (_is_person)
			{
				Setup_form_person();
			}
			else
			{
				Setup_form_org();
			}

			if (!Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_SALESPERSON))
			{
				// no permission to add/edit salesperson
				btn_ok.Visible = false;
				dtp_join.Enabled = false;
				dtp_leave.Enabled = false;
				txt_location.ReadOnly = true;
				txt_remark.ReadOnly = true;
			}

			grd_contact.AutoResizeColumns();
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_SALESPERSON))
			{
				// NO PERMISSION
				this.DialogResult = DialogResult.Cancel;
				this.Close();
				return;
			}

			if (dtp_leave.Checked && dtp_leave.Value < dtp_join.Value)
			{
				MessageBox.Show("Date leave must be after date join.", "Invalid",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (SalespersonID == 0)
			{
				// insert
				SalespersonID = Salesperson_ds.Insert_salesperson(_person_orgbranch_id, _is_person, txt_location.Text.Trim(),
					dtp_join.Value, dtp_leave.Checked ? dtp_leave.Value : (DateTime?)null, txt_remark.Text.Trim());
			}
			else
			{
				// update
				Salesperson_ds.Update_salesperson(SalespersonID, txt_location.Text.Trim(), dtp_join.Value,
					dtp_leave.Checked ? dtp_leave.Value : (DateTime?)null, txt_remark.Text.Trim());
			}

			// at this point, should not be zero anymore
			if (SalespersonID == 0)
			{
				MessageBox.Show("An error has occurred.", "ERROR",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
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
		private void Setup_form_person()
		{
			lbl_ic_reg.Text = "IC no.:";
			split_cont_person_org.Panel2Collapsed = true;

			Person_ds.sp_select_personDataTable dttable_person = Person_ds.Select_person(_person_orgbranch_id);

			if (dttable_person.Rows.Count > 0)
			{
				txt_name.Text = dttable_person[0].name;
				txt_ic_reg.Text = dttable_person[0].ic_no;
				txt_type.Text = dttable_person[0].person_type_description;
				txt_driving_license.Text = dttable_person[0].driving_license;
				txt_gender.Text = dttable_person[0].gender ? "MALE" : "FEMALE";
				txt_race.Text = dttable_person[0].race_description;
				txt_address.Text = dttable_person[0].address;
				txt_city.Text = dttable_person[0].city;
				txt_state.Text = dttable_person[0].state;
				txt_postcode.Text = dttable_person[0].postcode;
				txt_country.Text = dttable_person[0].country_name;
				link_lbl_url.Text = dttable_person[0].url;
			}

			grd_contact.DataSource = null;
			grd_contact.DataSource = Person_contact_ds.Select_person_contact(_person_orgbranch_id);
		}
		private void Setup_form_org()
		{
			lbl_ic_reg.Text = "Registration no.:";
			split_cont_person_org.Panel1Collapsed = true;

			Organisation_branch_ds.sp_select_organisation_branch_with_org_detailsDataTable dttable_branch = 
				Organisation_branch_ds.Select_organisation_branch_with_org_details(_person_orgbranch_id);

			if (dttable_branch.Rows.Count > 0)
			{
				txt_name.Text = dttable_branch[0].branch_name;
				txt_ic_reg.Text = dttable_branch[0].registration_no;
				txt_type.Text = dttable_branch[0].organisation_type_description;
				txt_address.Text = dttable_branch[0].address;
				txt_city.Text = dttable_branch[0].city;
				txt_state.Text = dttable_branch[0].state;
				txt_postcode.Text = dttable_branch[0].postcode;
				txt_country.Text = dttable_branch[0].country_name;
				link_lbl_url.Text = dttable_branch[0].url;
				txt_branch.Text = dttable_branch[0].branch_name;

				grd_contact.DataSource = null;
				grd_contact.DataSource = Organisation_contact_ds.Select_organisation_contact(dttable_branch[0].organisation);
			}
		}
		private void Link_lbl_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class_misc.Go_url(link_lbl_url.Text);
		}
		private void Grd_salestarget_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			e.Row.Cells["target_description"].Value = "New target";
			e.Row.Cells["target1"].Value = 0;
			e.Row.Cells["target2"].Value = 0;
			e.Row.Cells["target3"].Value = 0;
			e.Row.Cells["target4"].Value = 0;
			e.Row.Cells["target5"].Value = 0;
			e.Row.Cells["target6"].Value = 0;
			e.Row.Cells["target7"].Value = 0;
			e.Row.Cells["target8"].Value = 0;
			e.Row.Cells["target9"].Value = 0;
			e.Row.Cells["target10"].Value = 0;
			e.Row.Cells["target11"].Value = 0;
			e.Row.Cells["target12"].Value = 0;
		}
	}
}
