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
		public Form_vehicle_sale(int int_vehicle)
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

			using (Vehicle_ds.sp_select_vehicleDataTable dttable = 
				Vehicle_ds.Select_vehicle(VehicleID))
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

				dtp_road_tax_expiry.Value = dttable[0].road_tax_expiry_date;
				dtp_registered.Value = dttable[0].registration_date;

			}
			using (Vehicle_sale_ds.sp_select_vehicle_saleDataTable dttable = 
				Vehicle_sale_ds.Select_vehicle_sale(VehicleID))
			{
				if (dttable.Rows.Count > 0)
				{
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
			using (Vehicle_sale_charges_ds.sp_select_vehicle_sale_chargesDataTable dttable =
				Vehicle_sale_charges_ds.Select_vehicle_sale_charges(VehicleID))
			{
				DataTable dttable_grd;

				var query = (from row in dttable
							 where row.is_add
							 select row);
				if (query.Count() > 0)
					dttable_grd = query.CopyToDataTable();
				else
					dttable_grd = dttable.Clone();

				dttable_grd.Columns["description"].DefaultValue = "Add";
				dttable_grd.Columns["amount"].DefaultValue = 0;
				dttable_grd.Columns.Remove("is_add");
				dttable_grd.Columns["modified_by"].DefaultValue = Program.System_user.Name;
				grd_charges_add.DataSource = dttable_grd;

				query = (from row in dttable
						 where !row.is_add
						 select row);
				if (query.Count() > 0)
					dttable_grd = query.CopyToDataTable();
				else
					dttable_grd = dttable.Clone();

				dttable_grd.Columns["description"].DefaultValue = "Less";
				dttable_grd.Columns["amount"].DefaultValue = 0;
				dttable_grd.Columns.Remove("is_add");
				dttable_grd.Columns["modified_by"].DefaultValue = Program.System_user.Name;
				grd_charges_less.DataSource = dttable_grd;

				Class_datagridview.Hide_columns(grd_charges_add, new string[] { "vehicle_sale_charges" });
				Class_datagridview.Hide_columns(grd_charges_less, new string[] { "vehicle_sale_charges" });

				grd_charges_add.Columns["amount"].DefaultCellStyle.Format = "N2";
				grd_charges_less.Columns["amount"].DefaultCellStyle.Format = "N2";
			}
			// TODO: GRD PAYMENT AND GRD EXPENSES
		}

		private void Num_finance_ValueChanged(object sender, EventArgs e)
		{
			num_net_selling_price.Value = num_selling_price.Value + num_total_expenses.Value +
				num_total_additional_charges.Value - num_total_less_charges.Value + num_road_tax_amount.Value;

			num_to_receive.Value = num_net_selling_price.Value - num_total_trade_in.Value;
			num_balance_to_receive.Value = num_to_receive.Value - num_received_payment.Value;

			num_net_selling_price1.Value = num_net_selling_price.Value;
			num_gross_profit.Value = num_net_selling_price1.Value + num_total_misc_received.Value -
				num_total_misc_paid.Value - num_vehicle_cost.Value;
		}

		private void Grd_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{

		}
	}
}
