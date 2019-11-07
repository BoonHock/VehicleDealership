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
	public partial class Form_vehicle_sale : Form
	{
		public int VehicleID { get; private set; }
		public Form_vehicle_sale(int int_vehicle = 0)
		{
			InitializeComponent();

			VehicleID = int_vehicle;
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Form_vehicle_sale_Shown(object sender, EventArgs e)
		{
			cmb_vehicle_colour.DisplayMember = "colour_name";
			cmb_vehicle_colour.ValueMember = "colour";
			cmb_vehicle_colour.DataSource = Colour_ds.Select_colour();

			using (Vehicle_ds.sp_select_vehicleDataTable dttable = Vehicle_ds.Select_vehicle(VehicleID))
			{
				if (dttable.Rows.Count == 0)
				{
					// whether user adding/editing, vehicle must exist in record!
					MessageBox.Show("Vehicle not found!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					this.Close();
					return;
				}

				txt_reg_no.Text = dttable[0].registration_no;
				txt_chassis.Text = dttable[0].chassis_no;
				txt_vehicle_model.Text = dttable[0].vehicle_model_name;
				txt_vehicle_group.Text = dttable[0].vehicle_group_name;
				txt_vehicle_brand.Text = dttable[0].vehicle_brand_name;
				txt_jpj.Text = dttable[0].jpj_serial_no;
				txt_engine_no.Text = dttable[0].engine_no;
				num_engine_cc.Value = (decimal)dttable[0].engine_cc;
				txt_year_make.Text = dttable[0].year_make.ToString();
				cmb_vehicle_colour.SelectedValue = dttable[0].colour;
				num_mileage.Value = dttable[0].mileage;
				// TODO: road tax expiry dtp
				dtp_registered.Value = dttable[0].registration_date;

			}
			using (Vehicle_sale_ds.sp_select_vehicle_saleDataTable dttable = Vehicle_sale_ds.Select_vehicle_sale(VehicleID))
			{
				if (dttable.Rows.Count == 0) return;

				txt_salesperson.Text = dttable[0].salesperson;
				txt_customer_type.Text = dttable[0].customer_type;
				if (dttable[0].customer_type == "PERSON")
				{
					txt_customer_name.Text = dttable[0].customer_person_name;
					num_customer_id.Value = dttable[0].customer_person;
					txt_customer_reg_no.Text = dttable[0].customer_person_ic;
				}
				else
				{
					txt_customer_name.Text = dttable[0].customer_org_name + " " + dttable[0].customer_organisation_branch;
					num_customer_id.Value = dttable[0].customer_organisation_branch;
					txt_customer_reg_no.Text = dttable[0].customer_org_reg_no;
				}
				dtp_sale_date.Value = dttable[0].sale_date;

				rad_road_tax_month6.Checked = dttable[0].road_tax_month == 6;
				rad_road_tax_month12.Checked = dttable[0].road_tax_month == 12;
				num_road_tax_amount.Value = dttable[0].road_tax_amount;
				num_selling_price.Value = dttable[0].sale_price;
				num_vehicle_cost.Value = dttable[0].vehicle_cost;

				txt_loan_company.Text = dttable[0].loan_org_name;
				num_loan_company_id.Value = dttable[0].loan;
				txt_loan_reg_no.Text = dttable[0].loan_org_reg_no;
				num_loan_amount.Value = dttable[0].loan_amount;
				num_loan_year.Value = Math.Floor((decimal)dttable[0].loan_month_term / 12);
				num_loan_month.Value = (decimal)dttable[0].loan_month_term % 12;
				num_loan_interest.Value = dttable[0].loan_interest_percentage;
				num_loan_installment.Value = dttable[0].loan_monthly_installment;
				txt_loan_finance_ref_no.Text = dttable[0].loan_ref_no;
				dtp_loan_approved_date.Value = dttable[0].loan_approval_date;
				txt_loan_ownership_claim.Text = dttable[0].loan_ownership_claim_no;

				
			}
		}

	}
}
