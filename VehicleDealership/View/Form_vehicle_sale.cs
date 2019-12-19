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
	public partial class Form_vehicle_sale : Form
	{
		public int VehicleID { get; private set; }
		List<int> list_trade_in_vehicle_id = new List<int>();

		public Form_vehicle_sale(int int_vehicle)
		{
			InitializeComponent();

			VehicleID = int_vehicle;

			grd_payment_received.CellDoubleClick += (sender, e) => Grd_payment_CellDoubleClick(e, grd_payment_received, btn_payment_received_edit);
			grd_expenses.CellDoubleClick += (sender, e) => Grd_payment_CellDoubleClick(e, grd_expenses, btn_expenses_edit);
			grd_misc_payment_received.CellDoubleClick += (sender, e) => Grd_payment_CellDoubleClick(e, grd_misc_payment_received, btn_misc_payment_received_edit);
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			string str_error = "";
			if (num_salesperson_id.Value == 0)
				str_error += "\n- Salesperson not selected.";
			if (num_customer_id.Value == 0)
				str_error += "\n- Customer not selected.";

			if (str_error.Length != 0)
			{
				MessageBox.Show("Input incomplete." + str_error,
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int? customer_person = null;
			int? customer_org = null;
			int? loan = num_loan_company_id.Value == 0 ? (int?)null : (int)num_loan_company_id.Value;
			int? insurance = num_insurance_company_id.Value == 0 ? (int?)null : (int)num_insurance_company_id.Value;
			int? insurance_category = cmb_insurance_category.SelectedIndex < 0 ? (int?)null : (int)cmb_insurance_category.SelectedValue;
			int? guarantor = num_guarantor_id.Value == 0 ? (int?)null : (int)num_guarantor_id.Value;
			int? insurance_comprehensive = cmb_ins_comprehensive.SelectedIndex < 0 ? (int?)null : (int)cmb_ins_comprehensive.SelectedValue;

			if (txt_customer_type.Text == "PERSON")
				customer_person = (int)num_customer_id.Value;
			else
				customer_org = (int)num_customer_id.Value;

			byte? road_tax_month = null;
			if (dtp_new_road_tax.Checked)
				road_tax_month = rad_road_tax_month6.Checked ? (byte?)6 : (byte?)12;

			// UPDATE / INSERT VEHICLE SALE
			using (Vehicle_sale_ds.sp_select_vehicle_saleDataTable dttable = Vehicle_sale_ds.Select_vehicle_sale(VehicleID))
			{
				if (dttable.Any())
				{
					// editing
					Vehicle_sale_ds.Update_vehicle_sale(VehicleID, customer_person, customer_org, dtp_sale_date.Value,
						num_net_selling_price.Value, num_road_tax_amount.Value, road_tax_month, loan,
						num_loan_amount.Value, (int)(num_loan_year.Value * 12 + num_loan_month.Value),
						num_loan_interest.Value, num_loan_installment.Value, txt_loan_finance_ref_no.Text.Trim(),
						dtp_loan_approved_date.Value, txt_loan_ownership_claim.Text.Trim(), guarantor, insurance,
						txt_insurance_cover_note_no.Text.Trim(), txt_insurance_endorsement_no.Text.Trim(),
						txt_insurance_policy_no.Text.Trim(), dtp_insurance_date.Value, insurance_category,
						cmb_insurance_type.SelectedItem.ToString() == "COMPREHENSIVE", num_insurance_basic.Value,
						num_insurance_sum_insured.Value, insurance_comprehensive, num_additional_comprehensive.Value,
						num_insurance_adjustment.Value, num_insurance_loading_age_percent.Value,
						num_insurance_loading_percent.Value, num_insurance_ncd_amount.Value,
						num_insurance_stamp_duty.Value, num_insurance_windscreen_sum_insured.Value,
						num_insurance_windscreen.Value, num_insurance_total_payable.Value,
						(int)num_salesperson_id.Value, txt_remark.Text.Trim());
				}
				else
				{
					// inserting
					Vehicle_sale_ds.Insert_vehicle_sale(VehicleID, Document_prefix_ds.Select_document_prefix("VEHICLE_SALE"),
						customer_person, customer_org, dtp_sale_date.Value,
						num_net_selling_price.Value, num_road_tax_amount.Value, road_tax_month, loan,
						num_loan_amount.Value, (int)(num_loan_year.Value * 12 + num_loan_month.Value),
						num_loan_interest.Value, num_loan_installment.Value, txt_loan_finance_ref_no.Text.Trim(),
						dtp_loan_approved_date.Value, txt_loan_ownership_claim.Text.Trim(), guarantor, insurance,
						txt_insurance_cover_note_no.Text.Trim(), txt_insurance_endorsement_no.Text.Trim(),
						txt_insurance_policy_no.Text.Trim(), dtp_insurance_date.Value, insurance_category,
						cmb_insurance_type.SelectedItem.ToString() == "COMPREHENSIVE", num_insurance_basic.Value,
						num_insurance_sum_insured.Value, insurance_comprehensive, num_additional_comprehensive.Value,
						num_insurance_adjustment.Value, num_insurance_loading_age_percent.Value,
						num_insurance_loading_percent.Value, num_insurance_ncd_amount.Value,
						num_insurance_stamp_duty.Value, num_insurance_windscreen_sum_insured.Value,
						num_insurance_windscreen.Value, num_insurance_total_payable.Value,
						(int)num_salesperson_id.Value, txt_remark.Text.Trim());
				}
			}

			// UPDATE ROAD TAX & MILEAGE
			if (dtp_new_road_tax.Checked)
				Vehicle_ds.Update_road_tax_mileage(VehicleID, dtp_new_road_tax.Value,
					num_road_tax_amount.Value, (int)num_mileage.Value);
			else
				Vehicle_ds.Update_road_tax_mileage(VehicleID, null, null, (int)num_mileage.Value);

			// VEHICLE SALE CHARGES
			{
				Class_bulkcopy bk = new Class_bulkcopy(((DataTable)grd_charges.DataSource).Copy())
				{
					INT1 = "vehicle_sale_charges",
					NVARCHAR1 = "description",
					DECIMAL18_4 = "amount"
				};
				if (!bk.Write_to_db() || !Vehicle_sale_charges_ds.Update_insert_vehicle_sale_charges(VehicleID))
				{
					MessageBox.Show("Failed to update vehicle sale charges.", "ERROR",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			// VEHICLE EXPENSES
			Update_expenses();
			Update_veh_sale_payment_customer();
			Update_veh_sale_payment_receive_misc();

			// INSURANCE MISC CHARGES
			{
				Class_bulkcopy bk = new Class_bulkcopy(((DataTable)grd_insurance_misc.DataSource).Copy())
				{
					INT1 = "insurance_misc_charges",
					NVARCHAR1 = "description",
					DECIMAL18_4 = "amount"
				};
				if (!bk.Write_to_db() || !Insurance_misc_charges_ds.Update_insert_insurance_misc_charges(VehicleID))
				{
					MessageBox.Show("Failed to update insurance miscellaneous charges.", "ERROR",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			// INSURANCE DRIVER
			{
				Class_bulkcopy bk = new Class_bulkcopy(((DataTable)grd_insurance_driver.DataSource).Copy())
				{
					NVARCHAR1 = "driver",
					NVARCHAR2 = "ic_no"
				};
				if (!bk.Write_to_db() || !Insurance_driver_ds.Update_insert_insurance_driver(VehicleID))
				{
					MessageBox.Show("Failed to update insurance driver.", "ERROR",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			// TRADE IN
			if (!Vehicle_ds.Update_trade_in(string.Join(",", list_trade_in_vehicle_id), VehicleID))
			{
				MessageBox.Show("Failed to update trade in.", "ERROR",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return; // TODO: temporary. remove this.

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Update_expenses()
		{
			using (Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable dttable =
				(Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable)grd_expenses.DataSource)
			{
				List<int> list_payment_id = new List<int>();
				List<int> list_charge_to_customer = new List<int>();

				dttable.AcceptChanges();

				string str_doc_prefix = Document_prefix_ds.Select_document_prefix("VEHICLE_EXPENSES");

				foreach (Vehicle_expenses_ds.sp_select_vehicle_expensesRow dt_row in dttable)
				{
					int int_payment_id = Class_payment.Update_insert_payment(str_doc_prefix, dt_row.payment,
						dt_row.payment_description, dt_row.pay_to_id, dt_row.pay_to_type, dt_row.amount,
						dt_row.payment_date, dt_row.is_paid, dt_row.payment_method_type,
						(dt_row["payment_method_id"] == DBNull.Value) ? 0 : dt_row.payment_method_id,
						(dt_row["cheque_no"] == DBNull.Value) ? "" : dt_row.cheque_no,
						(dt_row["credit_card_no"] == DBNull.Value) ? "" : dt_row.credit_card_no,
						(dt_row["credit_card_type_id"] == DBNull.Value) ? 0 : dt_row.credit_card_type_id,
						(dt_row["finance_id"] == DBNull.Value) ? 0 : dt_row.finance_id,
						(dt_row["payment_method_date"] == DBNull.Value) ? DateTime.Today : dt_row.payment_method_date,
						dt_row.remark);

					if (int_payment_id == 0) continue;

					list_payment_id.Add(int_payment_id);
					if (dt_row.charge_to_customer) list_charge_to_customer.Add(int_payment_id);
				}

				if (!Vehicle_expenses_ds.Update_vehicle_expenses(VehicleID, string.Join(",", list_payment_id),
					string.Join(",", list_charge_to_customer)))
				{
					MessageBox.Show("Vehicle expenses update failed.", "ERROR",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void Update_veh_sale_payment_customer()
		{
			using (Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable dttable =
				(Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable)grd_payment_received.DataSource)
			{
				List<int> list_payment_id = new List<int>();
				List<int> list_charge_to_customer = new List<int>();

				dttable.AcceptChanges();

				string str_doc_prefix = Document_prefix_ds.Select_document_prefix("VEHICLE_PAYMENT_RECEIVED");

				foreach (Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerRow dt_row in dttable)
				{
					int int_payment_id = Class_payment.Update_insert_payment(str_doc_prefix, dt_row.payment,
						dt_row.payment_description, dt_row.pay_to_id, dt_row.pay_to_type, dt_row.amount,
						dt_row.payment_date, dt_row.is_paid, dt_row.payment_method_type,
						(dt_row["payment_method_id"] == DBNull.Value) ? 0 : dt_row.payment_method_id,
						(dt_row["cheque_no"] == DBNull.Value) ? "" : dt_row.cheque_no,
						(dt_row["credit_card_no"] == DBNull.Value) ? "" : dt_row.credit_card_no,
						(dt_row["credit_card_type_id"] == DBNull.Value) ? 0 : dt_row.credit_card_type_id,
						(dt_row["finance_id"] == DBNull.Value) ? 0 : dt_row.finance_id,
						(dt_row["payment_method_date"] == DBNull.Value) ? DateTime.Today : dt_row.payment_method_date,
						dt_row.remark);

					if (int_payment_id == 0) continue;

					list_payment_id.Add(int_payment_id);
				}

				if (!Veh_sale_payment_customer_ds.Update_veh_sale_payment_customer(VehicleID, string.Join(",", list_payment_id)))
				{
					MessageBox.Show("Vehicle payment received from customer update failed.", "ERROR",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void Update_veh_sale_payment_receive_misc()
		{
			using (Veh_sale_payment_receive_misc_ds.sp_select_veh_sale_payment_receive_miscDataTable dttable =
				(Veh_sale_payment_receive_misc_ds.sp_select_veh_sale_payment_receive_miscDataTable)grd_misc_payment_received.DataSource)
			{
				List<int> list_payment_id = new List<int>();
				List<int> list_charge_to_customer = new List<int>();

				dttable.AcceptChanges();

				string str_doc_prefix = Document_prefix_ds.Select_document_prefix("VEHICLE_SALE_MISC_RECEIVED");

				foreach (Veh_sale_payment_receive_misc_ds.sp_select_veh_sale_payment_receive_miscRow dt_row in dttable)
				{
					int int_payment_id = Class_payment.Update_insert_payment(str_doc_prefix, dt_row.payment,
						dt_row.payment_description, dt_row.pay_to_id, dt_row.pay_to_type, dt_row.amount,
						dt_row.payment_date, dt_row.is_paid, dt_row.payment_method_type,
						(dt_row["payment_method_id"] == DBNull.Value) ? 0 : dt_row.payment_method_id,
						(dt_row["cheque_no"] == DBNull.Value) ? "" : dt_row.cheque_no,
						(dt_row["credit_card_no"] == DBNull.Value) ? "" : dt_row.credit_card_no,
						(dt_row["credit_card_type_id"] == DBNull.Value) ? 0 : dt_row.credit_card_type_id,
						(dt_row["finance_id"] == DBNull.Value) ? 0 : dt_row.finance_id,
						(dt_row["payment_method_date"] == DBNull.Value) ? DateTime.Today : dt_row.payment_method_date,
						dt_row.remark);

					if (int_payment_id == 0) continue;

					list_payment_id.Add(int_payment_id);
				}

				if (!Veh_sale_payment_receive_misc_ds.Update_veh_sale_payment_receive_misc(VehicleID, string.Join(",", list_payment_id)))
				{
					MessageBox.Show("Vehicle miscellaneous payment received update failed.", "ERROR",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Form_vehicle_sale_Shown(object sender, EventArgs e)
		{
			cmb_insurance_category.DisplayMember = "description";
			cmb_insurance_category.ValueMember = "insurance_category";
			cmb_insurance_category.DataSource = Insurance_category_ds.Select_insurance_category();

			cmb_ins_comprehensive.DisplayMember = "title";
			cmb_ins_comprehensive.ValueMember = "insurance_comprehensive";
			cmb_ins_comprehensive.DataSource = Insurance_comprehensive_ds.Select_insurance_comprehensive();

			cmb_insurance_type.SelectedIndex = 0; // default

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
				txt_engine_cc.Text = dttable[0].engine_cc.ToString("#,##0");
				txt_year_make.Text = dttable[0].year_make.ToString();
				txt_vehicle_colour.Text = dttable[0].colour_name;
				num_mileage.Value = dttable[0].mileage;

				dtp_road_tax_expiry.Value = dttable[0].road_tax_expiry_date;
				dtp_registered.Value = dttable[0].registration_date;

				num_net_purchase.Value = dttable[0].purchase_price - dttable[0].overtrade;
				dtp_new_road_tax.Value = dttable[0].road_tax_expiry_date;
			}
			// LOAD VEHICLE SALE DETAILS
			using (Vehicle_sale_ds.sp_select_vehicle_saleDataTable dttable =
				Vehicle_sale_ds.Select_vehicle_sale(VehicleID))
			{
				if (dttable.Rows.Count > 0)
				{
					num_salesperson_id.Value = dttable[0].salesperson_id;
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

					if (dttable[0]["road_tax_month"] == DBNull.Value)
					{
						dtp_new_road_tax.Checked = false;
					}
					else
					{
						dtp_new_road_tax.Checked = true;
						rad_road_tax_month6.Checked = dttable[0].road_tax_month == 6;
						rad_road_tax_month12.Checked = dttable[0].road_tax_month == 12;
						num_road_tax_amount.Value = dttable[0].road_tax_amount;
					}

					num_selling_price.Value = dttable[0].sale_price;

					if (dttable[0]["loan"] != DBNull.Value)
					{
						num_loan_company_id.Value = dttable[0].loan;
						txt_loan_company.Text = dttable[0].loan_org_name;
						txt_loan_branch.Text = dttable[0].loan_org_branch_name;
						txt_loan_reg_no.Text = dttable[0].loan_org_reg_no;
					}
					num_loan_amount.Value = dttable[0].loan_amount;
					num_loan_year.Value = Math.Floor((decimal)dttable[0].loan_month / 12);
					num_loan_month.Value = (decimal)dttable[0].loan_month % 12;
					num_loan_interest.Value = dttable[0].loan_interest_percentage;
					num_loan_installment.Value = dttable[0].loan_monthly_installment;
					txt_loan_finance_ref_no.Text = dttable[0].loan_ref_no;
					dtp_loan_approved_date.Value = dttable[0].loan_approval_date;
					txt_loan_ownership_claim.Text = dttable[0].loan_ownership_claim_no;

					if (dttable[0]["insurance"] != DBNull.Value)
					{
						num_insurance_company_id.Value = dttable[0].insurance;
						txt_insurance_company.Text = dttable[0].insurance_org_name;
						txt_insurance_branch.Text = dttable[0].insurance_org_branch_name;
						txt_insurance_reg_no.Text = dttable[0].insurance_org_reg_no;
					}
					txt_insurance_policy_no.Text = dttable[0].insurance_policy_no;
					txt_insurance_cover_note_no.Text = dttable[0].insurance_cover_note_no;
					txt_insurance_endorsement_no.Text = dttable[0].insurance_endorsement_no;
					dtp_insurance_date.Value = dttable[0].insurance_date;

					if (dttable[0]["insurance_category"] != DBNull.Value)
						cmb_insurance_category.SelectedValue = dttable[0].insurance_category;

					cmb_insurance_type.SelectedItem = dttable[0].insurance_type ? "COMPREHENSIVE" : "THIRD PARTY";

					if (dttable[0]["insurance_comprehensive"] != DBNull.Value)
						cmb_ins_comprehensive.SelectedValue = dttable[0].insurance_comprehensive;

					num_insurance_sum_insured.Value = dttable[0].insurance_sum_insured;
					num_insurance_basic.Value = dttable[0].insurance_basic_premium;
					num_insurance_stamp_duty.Value = dttable[0].insurance_stamp_duty;
					num_insurance_loading_percent.Value = dttable[0].insurance_loading_percent;
					num_insurance_loading_amount.Value = (num_insurance_basic.Value - num_insurance_stamp_duty.Value) *
						num_insurance_loading_percent.Value;
					num_insurance_ncd_percent.Value = dttable[0].insurance_ncd_percent;
					num_insurance_ncd_amount.Value = (num_insurance_basic.Value - num_insurance_stamp_duty.Value) *
						num_insurance_ncd_percent.Value;
					num_insurance_windscreen.Value = dttable[0].insurance_windscreen;
					num_insurance_windscreen_sum_insured.Value = dttable[0].insurance_windscreen_sum_insured;
					num_insurance_total_payable.Value = dttable[0].insurance_total_payable;

					if (dttable[0]["guarantor_person"] != DBNull.Value)
					{
						num_guarantor_id.Value = dttable[0].guarantor_person;
						txt_guarantor_name.Text = dttable[0].guarantor_name;
					}
					txt_remark.Text = dttable[0].remark;
				}
			}
			// CHARGES
			using (Vehicle_sale_charges_ds.sp_select_vehicle_sale_chargesDataTable dttable =
				Vehicle_sale_charges_ds.Select_vehicle_sale_charges(VehicleID))
			{
				dttable.modified_byColumn.ReadOnly = true;
				dttable.descriptionColumn.DefaultValue = "CHARGES";
				dttable.amountColumn.DefaultValue = 0;
				dttable.modified_byColumn.DefaultValue = Program.System_user.Name;
				grd_charges.DataSource = dttable;
				grd_charges.Columns["modified_by"].DefaultCellStyle.BackColor = Color.LightGray;

				Class_datagridview.Hide_columns(grd_charges, new string[] { "vehicle_sale_charges" });
				Class_datagridview.Set_column_to_money_column(grd_charges, "amount");
				Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_charges, "description");
			}
			// EXPENSES
			using (Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable dttable =
				Vehicle_expenses_ds.Select_vehicle_expenses(VehicleID))
			{
				grd_expenses.DataSource = null;
				grd_expenses.DataSource = dttable;

				Class_datagridview.Set_column_to_money_column(grd_expenses, "amount");

				grd_expenses.AutoResizeColumns();

				// column charge_to_customer will be checkbox. allow user to tick/untick. other columns cannot edit
				foreach (DataGridViewColumn grd_col in grd_expenses.Columns)
				{
					if (grd_col.Name == "charge_to_customer")
					{
						grd_col.ReadOnly = false;
						grd_col.DefaultCellStyle.BackColor = Color.Yellow;
					}
					else
					{
						grd_col.ReadOnly = true;
						grd_col.DefaultCellStyle.BackColor = Color.LightGray;
					}
				}
			}
			// PAYMENT RECEIVED FROM CUSTOMER
			using (Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable dttable =
				Veh_sale_payment_customer_ds.Select_veh_sale_payment_customer(VehicleID))
			{
				grd_payment_received.DataSource = null;
				grd_payment_received.DataSource = dttable;

				Class_datagridview.Set_column_to_money_column(grd_payment_received, "amount");

				grd_payment_received.AutoResizeColumns();
			}
			// MISC RECEIVED
			using (Veh_sale_payment_receive_misc_ds.sp_select_veh_sale_payment_receive_miscDataTable dttable =
				Veh_sale_payment_receive_misc_ds.Select_veh_sale_payment_receive_misc(VehicleID))
			{
				grd_misc_payment_received.DataSource = null;
				grd_misc_payment_received.DataSource = dttable;

				Class_datagridview.Set_column_to_money_column(grd_misc_payment_received, "amount");

				grd_misc_payment_received.AutoResizeColumns();
			}
			// INSURANCE DRIVER
			using (Insurance_driver_ds.sp_select_insurance_driverDataTable dttable =
				Insurance_driver_ds.Select_insurance_driver(VehicleID))
			{
				dttable.modified_byColumn.ReadOnly = true;
				dttable.modified_byColumn.DefaultValue = Program.System_user.Name;
				grd_insurance_driver.DataSource = dttable;
				Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_insurance_driver, "driver");
				Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_insurance_driver, "ic_no");
			}
			// INSURANCE MISC CHARGES
			using (Insurance_misc_charges_ds.sp_select_insurance_misc_chargesDataTable dttable =
				Insurance_misc_charges_ds.Select_insurance_misc_charges(VehicleID))
			{
				dttable.modified_byColumn.ReadOnly = true;
				dttable.modified_byColumn.DefaultValue = Program.System_user.Name;
				grd_insurance_misc.DataSource = dttable;
				Class_datagridview.Set_column_to_money_column(grd_insurance_misc, "amount");
				grd_insurance_misc.Columns["insurance_misc_charges"].Visible = false;
				Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_insurance_misc, "description");
			}

			Setup_grd_trade_in(0, true);

			((DataTable)grd_charges.DataSource).RowChanged += (sender2, e2) => Grd_charges_calculate_total();
			((DataTable)grd_insurance_misc.DataSource).RowChanged += (sender2, e2) => Calculate_insurance_total_payable();

			Calculate_vehicle_payment();

			btn_trade_in_add.Visible = Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_ADD_EDIT);
			btn_trade_in_edit.Visible = Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_ADD_EDIT);
			btn_trade_in_delete.Visible = Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_ADD_EDIT);

			// hide unnecessary columns
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_payment_received,
				"payment_no", "payment_description", "pay_to", "amount",
				"payment_date", "is_paid", "payment_method_type", "cheque_no", "credit_card_no",
				"payment_method", "finance", "remark", "modified_by");
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_expenses,
				"charge_to_customer", "payment_no", "payment_description", "pay_to", "amount",
				"payment_date", "is_paid", "payment_method_type", "cheque_no", "credit_card_no",
				"payment_method", "finance", "remark", "modified_by");
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_misc_payment_received,
				"payment_no", "payment_description", "pay_to", "amount",
				"payment_date", "is_paid", "payment_method_type", "cheque_no", "credit_card_no",
				"payment_method", "finance", "remark", "modified_by");
		}
		private void Grd_charges_calculate_total()
		{
			DataTable dttable = (DataTable)grd_charges.DataSource;

			decimal add_charges = 0, less_charges = 0;

			var query = from row in dttable.AsEnumerable() where (decimal)row["amount"] > 0 select (decimal)row["amount"];
			if (query.Any()) add_charges = query.Sum();

			query = from row in dttable.AsEnumerable() where (decimal)row["amount"] < 0 select (decimal)row["amount"];
			if (query.Any()) less_charges = -query.Sum();

			lbl_charges_add.Text = add_charges.ToString("#,##0.00");
			lbl_charges_less.Text = less_charges.ToString("#,##0.00");

			num_total_additional_charges.Value = add_charges;
			num_total_less_charges.Value = less_charges;
		}
		private void Num_finance_ValueChanged(object sender, EventArgs e)
		{
			num_net_selling_price.Value = num_selling_price.Value + num_expenses_charged.Value +
				num_total_additional_charges.Value - num_total_less_charges.Value + num_road_tax_amount.Value;

			num_to_receive.Value = num_net_selling_price.Value - num_total_trade_in.Value;
			num_balance_to_receive.Value = num_to_receive.Value - num_received_payment.Value;

			num_net_selling_price1.Value = num_net_selling_price.Value;
			num_gross_profit.Value = num_net_selling_price1.Value + num_total_misc_received.Value -
				num_net_purchase.Value - num_total_expenses.Value;
		}
		private void Grd_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			((DataGridView)sender).CancelEdit();
			e.Cancel = true;
		}
		//private void Setup_grd_payment(DataGridView grd,
		//	Class_enum.Payment_function payment_function, int int_preselect = 0)
		//{
		//	using (Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable = Vehicle_payment_ds.Select_vehicle_payment(VehicleID, payment_function))
		//	{
		//		grd.DataSource = null;
		//		grd.DataSource = dttable;

		//		Class_datagridview.Set_column_to_money_column(grd, "amount");

		//		grd.AutoResizeColumns();

		//		if (int_preselect != 0)
		//			Class_datagridview.Select_row_by_value(grd, "payment", int_preselect);
		//	}
		//}
		public void Setup_grd_trade_in(int int_vehicle = 0, bool is_init = false)
		{
			/*
			 * if is initialising, then select trade in for this vehicle sale's vehicle ID. 
			 * else, select only what is in @list_trade_in_vehicle_id
			 */
			using (Vehicle_ds.sp_select_vehicle_trade_inDataTable dttable =
				Vehicle_ds.Select_vehicle_trade_in(is_init ? VehicleID : 0, string.Join(",", list_trade_in_vehicle_id)))
			{
				grd_trade_in.DataSource = null;
				grd_trade_in.DataSource = dttable;
				Class_datagridview.Hide_columns(grd_trade_in, new string[] { "vehicle" });
				grd_trade_in.AutoResizeColumns();

				// set @list_trade_in_vehicle_id to be same with what is selected
				if (dttable.Rows.Count > 0)
					list_trade_in_vehicle_id = (from row in dttable select row.vehicle).ToList();
			}
			Class_datagridview.Select_row_by_value(grd_trade_in, "vehicle", int_vehicle);
			Calculate_trade_in();
		}

		private void Calculate_vehicle_payment()
		{
			// PAYMENT RECEIVED
			{
				Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable dttable_payment_received =
					(Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable)grd_payment_received.DataSource;
				decimal dcml_payment_received = 0;

				if (dttable_payment_received.Rows.Count != 0)
					dcml_payment_received = (from row in dttable_payment_received select row.amount).Sum();

				lbl_payment_received_total.Text = dcml_payment_received.ToString("#,##0.00");
				num_received_payment.Value = dcml_payment_received;
			}
			// EXPENSES
			{
				Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable dttable_expenses =
					(Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable)grd_expenses.DataSource;
				decimal dcml_expenses = 0;
				decimal dcml_charged = 0;

				if (dttable_expenses.Rows.Count != 0)
					dcml_expenses = (from row in dttable_expenses select row.amount).Sum();

				var query_charged = (from row in dttable_expenses where row.charge_to_customer select row.amount);
				if (query_charged.Count() > 0) dcml_charged = query_charged.Sum();

				lbl_expenses_total.Text = dcml_expenses.ToString("#,##0.00");
				lbl_expenses_charged.Text = dcml_charged.ToString("#,##0.00");
				num_total_expenses.Value = dcml_expenses;
				num_expenses_charged.Value = dcml_charged;
			}
			// MISC RECEIVED
			{
				Veh_sale_payment_receive_misc_ds.sp_select_veh_sale_payment_receive_miscDataTable dttable_misc_received =
					(Veh_sale_payment_receive_misc_ds.sp_select_veh_sale_payment_receive_miscDataTable)grd_misc_payment_received.DataSource;
				decimal dcml_misc_received = 0;
				if (dttable_misc_received.Rows.Count != 0)
					dcml_misc_received = (from row in dttable_misc_received select row.amount).Sum();
				lbl_misc_payment_received_total.Text = dcml_misc_received.ToString("#,##0.00");
				num_total_misc_received.Value = dcml_misc_received;
			}

		}

		private void Btn_loan_company_Click(object sender, EventArgs e)
		{
			using (Form_datagridview_select dlg_select = new Form_datagridview_select(Loan_ds.Select_loan(-1),
				new string[] { "name", "branch_name", "registration_no", "address", "city", "state", "postcode",
	 "country_name", "url", "remark" }, "loan", num_loan_company_id.Value.ToString()))
			{
				if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
				{
					txt_loan_company.Text = dlg_select.Get_selected_value_as_string("name");
					txt_loan_branch.Text = dlg_select.Get_selected_value_as_string("branch_name");
					txt_loan_reg_no.Text = dlg_select.Get_selected_value_as_string("registration_no");
					num_loan_company_id.Value = dlg_select.Get_selected_value_as_int("loan");
				}
			}
		}
		private void Btn_insurance_company_Click(object sender, EventArgs e)
		{
			using (Form_datagridview_select dlg_select = new Form_datagridview_select(Insurance_ds.Select_insurance(-1),
				new string[] { "name", "branch_name", "registration_no", "address", "city", "state", "postcode",
	 "country_name", "url", "remark" }, "insurance", num_loan_company_id.Value.ToString()))
			{
				if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
				{
					txt_insurance_company.Text = dlg_select.Get_selected_value_as_string("name");
					txt_insurance_branch.Text = dlg_select.Get_selected_value_as_string("branch_name");
					txt_insurance_reg_no.Text = dlg_select.Get_selected_value_as_string("registration_no");
					num_insurance_company_id.Value = dlg_select.Get_selected_value_as_int("insurance");
				}
			}
		}

		private void Grd_expenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (grd_expenses.Columns[e.ColumnIndex].Name.ToUpper() == "CHARGE_TO_CUSTOMER")
			{
				grd_expenses.CommitEdit(DataGridViewDataErrorContexts.Commit);
				Calculate_vehicle_payment();
			}
		}
		private void Grd_payment_CellDoubleClick(DataGridViewCellEventArgs e, DataGridView grd, ToolStripButton btn_edit)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && grd.Columns[e.ColumnIndex].Name.ToUpper() != "CHARGE_TO_CUSTOMER")
				btn_edit.PerformClick();
		}
		private void Btn_trade_in_add_Click(object sender, EventArgs e)
		{
			using (Form_edit_vehicle dlg = new Form_edit_vehicle(0, false))
			{
				if (dlg.ShowDialog() != DialogResult.OK) return;

				list_trade_in_vehicle_id.Add(dlg.VehicleID);
				Setup_grd_trade_in(dlg.VehicleID);
			}
		}
		private void Btn_trade_in_edit_Click(object sender, EventArgs e)
		{
			if (grd_trade_in.SelectedCells.Count == 0) return;

			int int_vehicle_id = (int)grd_trade_in.SelectedCells[0].OwningRow.Cells["vehicle"].Value;

			using (Form_edit_vehicle dlg = new Form_edit_vehicle(int_vehicle_id, false))
			{
				if (dlg.ShowDialog() == DialogResult.OK) Setup_grd_trade_in(int_vehicle_id);
			}
		}
		private void Btn_trade_in_delete_Click(object sender, EventArgs e)
		{
			if (grd_trade_in.SelectedCells.Count == 0) return;
			if (MessageBox.Show("Are you sure? NOTE: Vehicle will only be removed as trade in for this vehicle sale. Vehicle record will still exist.",
				"Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
				return;

			int int_vehicle_id = (int)grd_trade_in.SelectedCells[0].OwningRow.Cells["vehicle"].Value;

			Vehicle_ds.sp_select_vehicle_trade_inDataTable dttable =
				(Vehicle_ds.sp_select_vehicle_trade_inDataTable)grd_trade_in.DataSource;

			for (int i = 0, j = dttable.Rows.Count; i < j; i++)
			{
				if (dttable[i].vehicle == int_vehicle_id) dttable.Rows.RemoveAt(i);
			}

			Calculate_trade_in();

			list_trade_in_vehicle_id = list_trade_in_vehicle_id.Distinct().ToList();
			list_trade_in_vehicle_id.Remove(int_vehicle_id);
		}
		private void Calculate_trade_in()
		{
			Vehicle_ds.sp_select_vehicle_trade_inDataTable dttable =
				(Vehicle_ds.sp_select_vehicle_trade_inDataTable)grd_trade_in.DataSource;

			decimal trade_in_total = 0;

			if (dttable.Rows.Count > 0)
				trade_in_total = (from row in dttable select row.purchase_price).Sum();

			lbl_trade_in_total.Text = trade_in_total.ToString("#,##0.00");
			num_total_trade_in.Value = trade_in_total;
		}
		private void Btn_guarantor_Click(object sender, EventArgs e)
		{
			using (Form_datagridview_select dlg_select = new Form_datagridview_select(Person_ds.Select_person_simplified(),
				new string[] { "name", "ic_no", "url" }, "person", ((int)num_guarantor_id.Value).ToString()))
			{
				if (dlg_select.ShowDialog() == DialogResult.OK)
				{
					txt_guarantor_name.Text = dlg_select.Get_selected_value_as_string("name");
					num_guarantor_id.Value = dlg_select.Get_selected_value_as_int("person");
				}
			}
		}

		private void Dtp_new_road_tax_ValueChanged(object sender, EventArgs e)
		{
			if (dtp_new_road_tax.Checked)
			{
				num_road_tax_amount.Enabled = true;
			}
			else
			{
				num_road_tax_amount.Enabled = false;
				num_road_tax_amount.Value = 0;
			}
		}
		private void Btn_salesperson_Click(object sender, EventArgs e)
		{
			using (Salesperson_ds.sp_select_salespersonDataTable dttable = Salesperson_ds.Select_salesperson(-1))
			{
				using (Form_datagridview_select dlg = new Form_datagridview_select(dttable,
					new string[] { "name", "branch_name", "registration_no" }, "salesperson", num_salesperson_id.Value.ToString()))
				{
					if (dlg.ShowDialog(this) == DialogResult.OK)
					{
						num_salesperson_id.Value = dlg.Get_selected_value_as_int("salesperson");
						txt_salesperson.Text = dlg.Get_selected_value_as_string("name");
					}
				}
			}
		}
		private void Btn_customer_Click(object sender, EventArgs e)
		{
			using (Form_person_organisation dlg = new Form_person_organisation())
			{
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					txt_customer_type.Text = dlg.SelectedType;

					if (txt_customer_type.Text == "PERSON")
					{
						num_customer_id.Value = dlg.Get_selected_value_as_int("person");
						txt_customer_reg_no.Text = dlg.Get_selected_value_as_string("ic_no");
					}
					else
					{
						num_customer_id.Value = dlg.Get_selected_value_as_int("organisation_branch");
						txt_customer_reg_no.Text = dlg.Get_selected_value_as_string("registration_no");
					}

					txt_customer_name.Text = dlg.Get_selected_value_as_string("name");
				}
			}
		}
		private void Btn_clear_loan_org_Click(object sender, EventArgs e)
		{
			txt_loan_company.Text = "";
			txt_loan_branch.Text = "";
			txt_loan_reg_no.Text = "";
			num_loan_company_id.Value = 0;
		}
		private void Btn_clear_insurance_org_Click(object sender, EventArgs e)
		{
			num_insurance_company_id.Value = 0;
			txt_insurance_company.Text = "";
			txt_insurance_branch.Text = "";
			txt_insurance_reg_no.Text = "";
		}
		private void Btn_expenses_add_Click(object sender, EventArgs e)
		{
			using (Form_edit_payment dlg_payment = new Form_edit_payment())
			{
				if (dlg_payment.ShowDialog() != DialogResult.OK) return;

				Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable dttable =
					(Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable)grd_expenses.DataSource;

				dttable.Addsp_select_vehicle_expensesRow(true, dlg_payment.PaymentNo,
					dlg_payment.PaymentDescription, dlg_payment.PayToId, dlg_payment.PayToName,
					dlg_payment.PayToType, dlg_payment.PaymentAmount, dlg_payment.PaymentDate,
					dlg_payment.IsPaid, dlg_payment.PaymentMethodType,
					dlg_payment.PaymentMethodDescription, dlg_payment.PaymentMethod,
					dlg_payment.ChequeNo, dlg_payment.CreditCardNo, dlg_payment.CreditCardTypeId,
					dlg_payment.CreditCardTypeName, dlg_payment.PaymentMethodFinance,
					dlg_payment.PaymentMethodFinanceName, dlg_payment.PaymentMethodDate,
					dlg_payment.PaymentRemark, Program.System_user.Name);

				Calculate_vehicle_payment();
			}
		}
		private void Btn_payment_received_add_Click(object sender, EventArgs e)
		{
			using (Form_edit_payment dlg_payment = new Form_edit_payment((int)num_customer_id.Value,
				txt_customer_name.Text, txt_customer_type.Text, false))
			{
				if (dlg_payment.ShowDialog() != DialogResult.OK) return;

				Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable dttable =
					(Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable)grd_payment_received.DataSource;

				dttable.Addsp_select_veh_sale_payment_customerRow(dlg_payment.PaymentNo,
					dlg_payment.PaymentDescription, dlg_payment.PayToId, dlg_payment.PayToName,
					dlg_payment.PayToType, dlg_payment.PaymentAmount, dlg_payment.PaymentDate,
					dlg_payment.IsPaid, dlg_payment.PaymentMethodType,
					dlg_payment.PaymentMethodDescription, dlg_payment.PaymentMethod,
					dlg_payment.ChequeNo, dlg_payment.CreditCardNo, dlg_payment.CreditCardTypeId,
					dlg_payment.CreditCardTypeName, dlg_payment.PaymentMethodFinance,
					dlg_payment.PaymentMethodFinanceName, dlg_payment.PaymentMethodDate,
					dlg_payment.PaymentRemark, Program.System_user.Name);
			}
		}
		private void Btn_misc_payment_received_add_Click(object sender, EventArgs e)
		{
			using (Form_edit_payment dlg_payment = new Form_edit_payment(0, "", "", false))
			{
				if (dlg_payment.ShowDialog() != DialogResult.OK) return;

				Veh_sale_payment_receive_misc_ds.sp_select_veh_sale_payment_receive_miscDataTable dttable =
					(Veh_sale_payment_receive_misc_ds.sp_select_veh_sale_payment_receive_miscDataTable)grd_misc_payment_received.DataSource;

				dttable.Addsp_select_veh_sale_payment_receive_miscRow(dlg_payment.PaymentNo,
					dlg_payment.PaymentDescription, dlg_payment.PayToId, dlg_payment.PayToName,
					dlg_payment.PayToType, dlg_payment.PaymentAmount, dlg_payment.PaymentDate,
					dlg_payment.IsPaid, dlg_payment.PaymentMethodType,
					dlg_payment.PaymentMethodDescription, dlg_payment.PaymentMethod,
					dlg_payment.ChequeNo, dlg_payment.CreditCardNo, dlg_payment.CreditCardTypeId,
					dlg_payment.CreditCardTypeName, dlg_payment.PaymentMethodFinance,
					dlg_payment.PaymentMethodFinanceName, dlg_payment.PaymentMethodDate,
					dlg_payment.PaymentRemark, Program.System_user.Name);
			}
		}
		private void Btn_expenses_edit_Click(object sender, EventArgs e)
		{
			if (grd_expenses.SelectedCells.Count == 0) return;

			Vehicle_expenses_ds.sp_select_vehicle_expensesRow dt_row =
				(from row in (Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable)grd_expenses.DataSource
				 where row.payment == (int)grd_expenses.SelectedCells[0].OwningRow.Cells["payment"].Value
				 select row).ToList()[0];
			using (Form_edit_payment dlg_payment = new Form_edit_payment(dt_row.payment, dt_row.payment_no,
				dt_row.payment_description, dt_row.is_paid, dt_row.pay_to_id, dt_row.pay_to,
				dt_row.pay_to_type, dt_row.payment_date, dt_row.amount, dt_row.payment_method_type,
				(dt_row["payment_method_id"] == DBNull.Value) ? 0 : dt_row.payment_method_id,
				(dt_row["credit_card_no"] == DBNull.Value) ? "" : dt_row.credit_card_no,
				(dt_row["cheque_no"] == DBNull.Value) ? "" : dt_row.cheque_no,
				(dt_row["credit_card_type_id"] == DBNull.Value) ? 0 : dt_row.credit_card_type_id,
				(dt_row["finance_id"] == DBNull.Value) ? 0 : dt_row.finance_id,
				(dt_row["finance"] == DBNull.Value) ? "" : dt_row.finance,
				(dt_row["payment_method_date"] == DBNull.Value) ? DateTime.Today : dt_row.payment_method_date,
				dt_row.remark))
			{
				if (dlg_payment.ShowDialog() != DialogResult.OK) return;

				dt_row.payment_description = dlg_payment.PaymentDescription;
				dt_row.pay_to_id = dlg_payment.PayToId;
				dt_row.pay_to = dlg_payment.PayToName;
				dt_row.pay_to_type = dlg_payment.PayToType;
				dt_row.amount = dlg_payment.PaymentAmount;
				dt_row.payment_date = dlg_payment.PaymentDate;
				dt_row.is_paid = dlg_payment.IsPaid;
				dt_row.payment_method_type = dlg_payment.PaymentMethodType;
				dt_row.payment_method = dlg_payment.PaymentMethodDescription;
				dt_row.payment_method_id = dlg_payment.PaymentMethod;

				dt_row.cheque_no = dlg_payment.ChequeNo;
				dt_row.credit_card_no = dlg_payment.CreditCardNo;
				dt_row.credit_card_type_id = dlg_payment.CreditCardTypeId;
				dt_row.credit_card_type = dlg_payment.CreditCardTypeName;
				dt_row.finance_id = dlg_payment.PaymentMethodFinance;
				dt_row.finance = dlg_payment.PaymentMethodFinanceName;

				dt_row.payment_method_date = dlg_payment.PaymentMethodDate;
				dt_row.remark = dlg_payment.PaymentRemark;
				dt_row.modified_by = Program.System_user.Name;
			}
			Calculate_vehicle_payment();
		}
		private void Btn_payment_received_edit_Click(object sender, EventArgs e)
		{
			if (grd_payment_received.SelectedCells.Count == 0) return;

			Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerRow dt_row =
				(from row in (Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable)grd_payment_received.DataSource
				 where row.payment == (int)grd_payment_received.SelectedCells[0].OwningRow.Cells["payment"].Value
				 select row).ToList()[0];
			using (Form_edit_payment dlg_payment = new Form_edit_payment(dt_row.payment, dt_row.payment_no,
				dt_row.payment_description, dt_row.is_paid, dt_row.pay_to_id, dt_row.pay_to,
				dt_row.pay_to_type, dt_row.payment_date, dt_row.amount, dt_row.payment_method_type,
				(dt_row["payment_method_id"] == DBNull.Value) ? 0 : dt_row.payment_method_id,
				(dt_row["credit_card_no"] == DBNull.Value) ? "" : dt_row.credit_card_no,
				(dt_row["cheque_no"] == DBNull.Value) ? "" : dt_row.cheque_no,
				(dt_row["credit_card_type_id"] == DBNull.Value) ? 0 : dt_row.credit_card_type_id,
				(dt_row["finance_id"] == DBNull.Value) ? 0 : dt_row.finance_id,
				(dt_row["finance"] == DBNull.Value) ? "" : dt_row.finance,
				(dt_row["payment_method_date"] == DBNull.Value) ? DateTime.Today : dt_row.payment_method_date,
				dt_row.remark))
			{
				if (dlg_payment.ShowDialog() != DialogResult.OK) return;

				dt_row.payment_description = dlg_payment.PaymentDescription;
				dt_row.pay_to_id = dlg_payment.PayToId;
				dt_row.pay_to = dlg_payment.PayToName;
				dt_row.pay_to_type = dlg_payment.PayToType;
				dt_row.amount = dlg_payment.PaymentAmount;
				dt_row.payment_date = dlg_payment.PaymentDate;
				dt_row.is_paid = dlg_payment.IsPaid;
				dt_row.payment_method_type = dlg_payment.PaymentMethodType;
				dt_row.payment_method = dlg_payment.PaymentMethodDescription;
				dt_row.payment_method_id = dlg_payment.PaymentMethod;

				dt_row.cheque_no = dlg_payment.ChequeNo;
				dt_row.credit_card_no = dlg_payment.CreditCardNo;
				dt_row.credit_card_type_id = dlg_payment.CreditCardTypeId;
				dt_row.credit_card_type = dlg_payment.CreditCardTypeName;
				dt_row.finance_id = dlg_payment.PaymentMethodFinance;
				dt_row.finance = dlg_payment.PaymentMethodFinanceName;

				dt_row.payment_method_date = dlg_payment.PaymentMethodDate;
				dt_row.remark = dlg_payment.PaymentRemark;
				dt_row.modified_by = Program.System_user.Name;
			}
			Calculate_vehicle_payment();
		}
		private void Btn_misc_payment_received_edit_Click(object sender, EventArgs e)
		{
			if (grd_misc_payment_received.SelectedCells.Count == 0) return;

			Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerRow dt_row =
				(from row in (Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable)grd_misc_payment_received.DataSource
				 where row.payment == (int)grd_misc_payment_received.SelectedCells[0].OwningRow.Cells["payment"].Value
				 select row).ToList()[0];
			using (Form_edit_payment dlg_payment = new Form_edit_payment(dt_row.payment, dt_row.payment_no,
				dt_row.payment_description, dt_row.is_paid, dt_row.pay_to_id, dt_row.pay_to,
				dt_row.pay_to_type, dt_row.payment_date, dt_row.amount, dt_row.payment_method_type,
				(dt_row["payment_method_id"] == DBNull.Value) ? 0 : dt_row.payment_method_id,
				(dt_row["credit_card_no"] == DBNull.Value) ? "" : dt_row.credit_card_no,
				(dt_row["cheque_no"] == DBNull.Value) ? "" : dt_row.cheque_no,
				(dt_row["credit_card_type_id"] == DBNull.Value) ? 0 : dt_row.credit_card_type_id,
				(dt_row["finance_id"] == DBNull.Value) ? 0 : dt_row.finance_id,
				(dt_row["finance"] == DBNull.Value) ? "" : dt_row.finance,
				(dt_row["payment_method_date"] == DBNull.Value) ? DateTime.Today : dt_row.payment_method_date,
				dt_row.remark))
			{
				if (dlg_payment.ShowDialog() != DialogResult.OK) return;

				dt_row.payment_description = dlg_payment.PaymentDescription;
				dt_row.pay_to_id = dlg_payment.PayToId;
				dt_row.pay_to = dlg_payment.PayToName;
				dt_row.pay_to_type = dlg_payment.PayToType;
				dt_row.amount = dlg_payment.PaymentAmount;
				dt_row.payment_date = dlg_payment.PaymentDate;
				dt_row.is_paid = dlg_payment.IsPaid;
				dt_row.payment_method_type = dlg_payment.PaymentMethodType;
				dt_row.payment_method = dlg_payment.PaymentMethodDescription;
				dt_row.payment_method_id = dlg_payment.PaymentMethod;

				dt_row.cheque_no = dlg_payment.ChequeNo;
				dt_row.credit_card_no = dlg_payment.CreditCardNo;
				dt_row.credit_card_type_id = dlg_payment.CreditCardTypeId;
				dt_row.credit_card_type = dlg_payment.CreditCardTypeName;
				dt_row.finance_id = dlg_payment.PaymentMethodFinance;
				dt_row.finance = dlg_payment.PaymentMethodFinanceName;

				dt_row.payment_method_date = dlg_payment.PaymentMethodDate;
				dt_row.remark = dlg_payment.PaymentRemark;
				dt_row.modified_by = Program.System_user.Name;
			}
			Calculate_vehicle_payment();
		}

		private void Btn_expenses_delete_Click(object sender, EventArgs e)
		{
			if (grd_expenses.SelectedCells.Count == 0) return;

			if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning) != DialogResult.Yes) return;

			List<int> list_payment_id = new List<int>();

			Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable dttable =
				(Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable)grd_expenses.DataSource;

			foreach (DataGridViewCell grd_cell in grd_expenses.SelectedCells)
			{
				list_payment_id.Add((int)grd_cell.OwningRow.Cells["payment"].Value);
			}
			for (int i = dttable.Rows.Count - 1; i >= 0; i--)
			{
				if (list_payment_id.Contains(dttable[i].payment)) dttable.Rows.RemoveAt(i);
			}
			Calculate_vehicle_payment();
		}
		private void Btn_payment_received_delete_Click(object sender, EventArgs e)
		{
			if (grd_payment_received.SelectedCells.Count == 0) return;

			if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning) != DialogResult.Yes) return;

			List<int> list_payment_id = new List<int>();

			Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable dttable =
				(Veh_sale_payment_customer_ds.sp_select_veh_sale_payment_customerDataTable)grd_payment_received.DataSource;

			foreach (DataGridViewCell grd_cell in grd_payment_received.SelectedCells)
			{
				list_payment_id.Add((int)grd_cell.OwningRow.Cells["payment"].Value);
			}
			for (int i = dttable.Rows.Count - 1; i >= 0; i--)
			{
				if (list_payment_id.Contains(dttable[i].payment)) dttable.Rows.RemoveAt(i);
			}
			Calculate_vehicle_payment();
		}
		private void Btn_misc_payment_received_delete_Click(object sender, EventArgs e)
		{
			if (grd_misc_payment_received.SelectedCells.Count == 0) return;

			if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning) != DialogResult.Yes) return;

			List<int> list_payment_id = new List<int>();
			Veh_sale_payment_receive_misc_ds.sp_select_veh_sale_payment_receive_miscDataTable dttable =
				(Veh_sale_payment_receive_misc_ds.sp_select_veh_sale_payment_receive_miscDataTable)grd_misc_payment_received.DataSource;

			foreach (DataGridViewCell grd_cell in grd_misc_payment_received.SelectedCells)
			{
				list_payment_id.Add((int)grd_cell.OwningRow.Cells["payment"].Value);
			}
			for (int i = dttable.Rows.Count - 1; i >= 0; i--)
			{
				if (list_payment_id.Contains(dttable[i].payment)) dttable.Rows.RemoveAt(i);
			}
			Calculate_vehicle_payment();
		}

		private void Cmb_insurance_type_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_insurance_type.SelectedItem == null) return;

			bool is_comprehensive = cmb_insurance_type.SelectedItem.ToString() == "COMPREHENSIVE";

			num_insurance_basic.Enabled = !is_comprehensive;
			cmb_ins_comprehensive.Enabled = is_comprehensive;

			if (is_comprehensive) Calculate_insurance_comprehensive_basic_premium();
		}

		private void Cmb_ins_comprehensive_SelectedIndexChanged(object sender, EventArgs e)
		{
			Calculate_insurance_comprehensive_basic_premium();
		}
		private void Calculate_insurance_comprehensive_basic_premium()
		{
			if (cmb_ins_comprehensive.SelectedIndex < 0) return;
			Insurance_comprehensive_rate_ds.sp_select_insurance_comprehensive_rateDataTable dttable =
				Insurance_comprehensive_rate_ds.Select_insurance_comprehensive_rate(
					(int)cmb_ins_comprehensive.SelectedValue, int.Parse(txt_engine_cc.Text));

			if (dttable.Any()) num_insurance_basic.Value = dttable[0].value;
		}
		private void Calculate_insurance_subtotal(object sender, EventArgs e)
		{
			num_insurance_subtotal.Value = num_insurance_basic.Value + (num_insurance_sum_insured.Value / 1000) *
				num_additional_comprehensive.Value + num_insurance_adjustment.Value;
		}
		private void Num_insurance_after_subtotal_ValueChanged(object sender, EventArgs e)
		{
			Calculate_insurance_total_payable();
		}
		private void Num_insurance_loading_age_percent_ValueChanged(object sender, EventArgs e)
		{
			num_insurance_loading_age_amount.Value = num_insurance_subtotal.Value *
				num_insurance_loading_age_percent.Value / 100;
		}
		private void Num_insurance_loading_percent_ValueChanged(object sender, EventArgs e)
		{
			num_insurance_loading_amount.Value = (num_insurance_subtotal.Value +
				num_insurance_loading_age_amount.Value) * num_insurance_loading_percent.Value / 100;
		}
		private void Num_insurance_ncd_percent_ValueChanged(object sender, EventArgs e)
		{
			num_insurance_ncd_amount.Value = (num_insurance_subtotal.Value +
				num_insurance_loading_age_amount.Value +
				num_insurance_loading_amount.Value) * num_insurance_ncd_percent.Value / 100;
		}
		private void Calculate_insurance_total_payable()
		{
			decimal total_payable = num_insurance_subtotal.Value + num_insurance_loading_age_amount.Value +
				num_insurance_loading_amount.Value + num_insurance_ncd_amount.Value +
				num_insurance_stamp_duty.Value + num_insurance_windscreen.Value;

			Insurance_misc_charges_ds.sp_select_insurance_misc_chargesDataTable dttable =
				(Insurance_misc_charges_ds.sp_select_insurance_misc_chargesDataTable)grd_insurance_misc.DataSource;

			dttable.AcceptChanges();

			if (dttable.Any()) total_payable += (from row in dttable select row.amount).Sum();

			num_insurance_total_payable.Value = total_payable;
		}
	}
}
