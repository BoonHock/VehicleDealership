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
	public partial class Form_edit_finance : Form
	{
		readonly int _org_id = 0;
		public Form_edit_finance(int int_org_id)
		{
			InitializeComponent();

			_org_id = int_org_id;

			Finance_ds.sp_select_financeDataTable dttable_finance = Finance_ds.Select_finance(int_org_id);

			if (dttable_finance.Rows.Count > 0)
			{
				txt_remark.Text = dttable_finance[0].remark;
			}
		}
		private void Form_edit_finance_Shown(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission(User_permission.VIEW_FINANCE) &&
				!Program.System_user.Has_permission(User_permission.ADD_EDIT_FINANCE))
			{
				MessageBox.Show("You do not have sufficient permission to perform this action!",
					"ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			Setup_form();

			if (!Program.System_user.Has_permission(User_permission.ADD_EDIT_FINANCE))
			{
				// no permission to add/edit finance
				btn_ok.Visible = false;
				txt_remark.ReadOnly = true;
			}
		}
		private void Setup_form()
		{
			Organisation_ds.sp_select_organisationDataTable dttable_org = Organisation_ds.Select_organisation(_org_id);

			if (dttable_org.Rows.Count == 0)
			{
				MessageBox.Show("Invalid organisation ID!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.DialogResult = DialogResult.Cancel;
				this.Close();
				return;
			}

			txt_name.Text = dttable_org[0].name;
			txt_ic_reg.Text = dttable_org[0].registration_no;
			txt_type.Text = dttable_org[0].organisation_type_description;
			txt_address.Text = dttable_org[0].address;
			txt_city.Text = dttable_org[0].city;
			txt_state.Text = dttable_org[0].state;
			txt_postcode.Text = dttable_org[0].postcode;
			txt_country.Text = dttable_org[0].country_name;
			link_lbl_url.Text = dttable_org[0].url;

			grd_contact.DataSource = null;
			grd_contact.DataSource = Organisation_contact_ds.Select_organisation_contact(_org_id);
		}
		private void Link_lbl_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class_misc.Go_url(link_lbl_url.Text);
		}

		private void Btn_view_edit_Click(object sender, EventArgs e)
		{
			if ((new Form_organisation(_org_id)).ShowDialog() == DialogResult.OK) Setup_form();
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.None;

			if (!Program.System_user.Has_permission(User_permission.ADD_EDIT_FINANCE))
			{
				// NO PERMISSION
				this.DialogResult = DialogResult.Cancel;
				this.Close();
				return;
			}

			Finance_ds.Update_insert_finance(_org_id, txt_remark.Text.Trim());

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
