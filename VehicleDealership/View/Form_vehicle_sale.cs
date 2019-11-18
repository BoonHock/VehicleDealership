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

			// LOAD VEHICLE DETAILS
			using (Vehicle_ds.sp_select_vehicleDataTable dttable =
				Vehicle_ds.Select_vehicle(VehicleID))
			{
				if (!dttable.Any())
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
			// LOAD VEHICLE SALE DETAILS
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

					txt_insurance_company.Text = dttable[0].insurance_org_name;
					num_insurance_company_id.Value = dttable[0].insurance;
					txt_insurance_reg_no.Text = dttable[0].insurance_org_reg_no;
					txt_insurance_cover_note_no.Text = dttable[0].insurance_cover_note_no;
					txt_insurance_endorsement_no.Text = dttable[0].insurance_endorsement_no;
					txt_insurance_policy_no.Text = dttable[0].insurance_policy_no;
					dtp_insurance_date.Value = dttable[0].insurance_date;
					cmb_insurance_category.SelectedValue = dttable[0].insurance_category;
					cmb_insurance_type.SelectedValue = dttable[0].insurance_type;
					num_insurance_sum_insured.Value = dttable[0].insurance_sum_insured;
					num_insurance_premium.Value = dttable[0].insurance_premium;
					num_insurance_stamp_duty.Value = dttable[0].insurance_stamp_duty;
					num_insurance_loading_percent.Value = dttable[0].insurance_loading_percent;
					//num_insurance_loading_amount.Value = // TODO
					num_insurance_ncb_percent.Value = dttable[0].insurance_ncb_percent;
					//num_insurance_ncb_amount.Value = // TODO
					num_insurance_windscreen.Value = dttable[0].insurance_windscreen;
					num_insurance_windscreen_sum_insured.Value = dttable[0].insurance_windscreen_sum_insured;
					//num_insurance_premium_to_pay .Value = // TODO
					txt_guarantor_name.Text = dttable[0].guarantor_name;
					num_guarantor_id.Value = dttable[0].guarantor_person;
					txt_remark.Text = dttable[0].remark;
				}
			}
			// CHARGES ADD / LESS
			using (Vehicle_sale_charges_ds.sp_select_vehicle_sale_chargesDataTable dttable =
				Vehicle_sale_charges_ds.Select_vehicle_sale_charges(VehicleID))
			{
				DataTable dttable_grd;

				// CHARGES TO CUSTOMER (ADD)
				var query = (from row in dttable
							 where row.is_add
							 select row);
				if (query.Any())
					dttable_grd = query.CopyToDataTable();
				else
					dttable_grd = dttable.Clone(); // no row, just clone table structure

				dttable_grd.Columns["description"].DefaultValue = "Add";
				dttable_grd.Columns["amount"].DefaultValue = 0;
				dttable_grd.Columns.Remove("is_add");
				dttable_grd.Columns["modified_by"].DefaultValue = Program.System_user.Name;
				grd_charges_add.DataSource = dttable_grd;

				// CHARGES TO CUSTOMER (LESS)
				query = (from row in dttable
						 where !row.is_add
						 select row);
				if (query.Any())
					dttable_grd = query.CopyToDataTable();
				else
					dttable_grd = dttable.Clone(); // no row, just clone table structure

				dttable_grd.Columns["description"].DefaultValue = "Less";
				dttable_grd.Columns["amount"].DefaultValue = 0;
				dttable_grd.Columns.Remove("is_add");
				dttable_grd.Columns["modified_by"].DefaultValue = Program.System_user.Name;
				grd_charges_less.DataSource = dttable_grd;

				Class_datagridview.Hide_columns(grd_charges_add, new string[] { "vehicle_sale_charges" });
				Class_datagridview.Hide_columns(grd_charges_less, new string[] { "vehicle_sale_charges" });

				Class_datagridview.Set_column_to_money_column(grd_charges_add, "amount");
				Class_datagridview.Set_column_to_money_column(grd_charges_less, "amount");
			}
			// PAYMENT RECEIVED FROM CUSTOMER
			Setup_grd_payment(grd_payment_received, Class_payment_function.PaymentFunction.VSALE_PAYMENT_RECEIVED);
			// EXPENSES
			Setup_grd_payment(grd_expenses, Class_payment_function.PaymentFunction.VSALE_EXPENSES);
			// MISC PAID
			Setup_grd_payment(grd_misc_payment_paid, Class_payment_function.PaymentFunction.VSALE_MISC_PAID);
			// MISC RECEIVED
			Setup_grd_payment(grd_misc_payment_received, Class_payment_function.PaymentFunction.VSALE_MISC_RECEIVED);

			using (Insurance_driver_ds.sp_select_insurance_driverDataTable dttable = Insurance_driver_ds.Select_insurance_driver(VehicleID))
			{
				dttable.modified_byColumn.DefaultValue = Program.System_user.Name;
				grd_insurance_driver.DataSource = dttable;
			}
			using (Insurance_misc_charges_ds.sp_select_insurance_misc_chargesDataTable dttable = Insurance_misc_charges_ds.Select_insurance_misc_charges(VehicleID))
			{
				dttable.modified_byColumn.DefaultValue = Program.System_user.Name;
				grd_insurance_misc.DataSource = dttable;
				Class_datagridview.Set_column_to_money_column(grd_insurance_misc, "amount");
				grd_insurance_misc.Columns["insurance_misc_charges"].Visible = false;
			}
			Setup_grd_trade_in();

			((DataTable)grd_charges_add.DataSource).RowChanged += (sender2, e2) => Grd_charges_calculate_total(grd_charges_add);
			((DataTable)grd_charges_less.DataSource).RowChanged += (sender2, e2) => Grd_charges_calculate_total(grd_charges_less);
		}
		private void Grd_charges_calculate_total(DataGridView grd)
		{
			DataTable dttable = (DataTable)grd.DataSource;
			ToolStripLabel lbl = grd == grd_charges_add ? lbl_charges_add_total : lbl_charges_less_total;
			NumericUpDown num_finance = grd == grd_charges_add ? num_total_additional_charges : num_total_less_charges;

			lbl.Text = "0.00";
			if (dttable.Rows.Count == 0) return;

			decimal total_amount = (from row in dttable.AsEnumerable()
									select row.Field<decimal>("amount")).ToList().Sum();

			lbl.Text = total_amount.ToString("#,##0.00");
			num_finance.Value = total_amount;
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
			((DataGridView)sender).CancelEdit();
			e.Cancel = true;
		}
		private void Setup_grd_payment(DataGridView grd, Classes.Class_payment_function.PaymentFunction payment_function, int int_preselect = 0)
		{
			using (Vehicle_sale_payment_ds.sp_select_vehicle_sale_paymentDataTable dttable = Vehicle_sale_payment_ds.Select_vehicle_sale_payment(VehicleID, payment_function))
			{
				grd.DataSource = null;
				grd.DataSource = dttable;
				Class_datagridview.Set_column_to_money_column(grd, "amount");

				grd.AutoResizeColumns();

				if (int_preselect != 0)
					Class_datagridview.Select_row_by_value(grd, "payment", int_preselect);
			}
		}
		public void Setup_grd_trade_in(int int_vehicle = 0)
		{
			using (Vehicle_ds.sp_select_vehicle_trade_inDataTable dttable = Vehicle_ds.Select_vehicle_trade_in(VehicleID))
			{
				grd_trade_in.DataSource = null;
				grd_trade_in.DataSource = dttable;
				Class_datagridview.Hide_columns(grd_trade_in, new string[] { "vehicle" });
				grd_trade_in.AutoResizeColumns();
			}
			Class_datagridview.Select_row_by_value(grd_trade_in, "vehicle", int_vehicle);
		}
		private void Calculate_insurance_ValueChanged(object sender, EventArgs e)
		{
			num_insurance_loading_amount.Value =
				(num_insurance_premium.Value - num_insurance_stamp_duty.Value) * num_insurance_loading_percent.Value / 100;
			num_insurance_ncb_amount.Value =
				(num_insurance_premium.Value - num_insurance_stamp_duty.Value) * num_insurance_ncb_percent.Value / 100;
		}
		private void Btn_payment_received_add_Click(object sender, EventArgs e)
		{
			using (Form_edit_payment dlg_payment = new Form_edit_payment())
			{
				if (dlg_payment.ShowDialog() != DialogResult.OK) return;

				Vehicle_sale_payment_ds.sp_select_vehicle_sale_paymentDataTable dttable =
					(Vehicle_sale_payment_ds.sp_select_vehicle_sale_paymentDataTable)grd_payment_received.DataSource;

				//dttable.Addsp_select_vehicle_sale_paymentRow(dlg_payment.PaymentNo,
				//	dlg_payment.PaymentDescription, dlg_payment.PayToId, dlg_payment.PayToName,
				//	dlg_payment.PayToType, dlg_payment.PaymentAmount, dlg_payment.PaymentDate,
				//	dlg_payment.IsPaid, dlg_payment.PaymentMethodType,
				//	dlg_payment.PaymentMethodDescription, dlg_payment.PaymentMethod,
				//	dlg_payment.ChequeNo, dlg_payment.CreditCardNo, dlg_payment.CreditCardTypeId,
				//	dlg_payment.CreditCardTypeName, dlg_payment.PaymentMethodFinance,
				//	dlg_payment.PaymentMethodFinanceName, dlg_payment.PaymentMethodDate,
				//	dlg_payment.PaymentRemark, Program.System_user.Name);
			}
		}
		private void Btn_payment_received_edit_Click(object sender, EventArgs e)
		{

		}
		private void Btn_payment_received_delete_Click(object sender, EventArgs e)
		{

		}
		private void Btn_expenses_add_Click(object sender, EventArgs e)
		{

		}
		private void Btn_expenses_edit_Click(object sender, EventArgs e)
		{

		}
		private void Btn_expenses_delete_Click(object sender, EventArgs e)
		{

		}
	}
}
