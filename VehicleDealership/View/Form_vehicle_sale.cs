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

			btn_payment_received_add.Click += (sender, e) => Add_payment(grd_payment_received, false);
			btn_expenses_add.Click += (sender, e) => Add_payment(grd_expenses, true);
			btn_misc_payment_received_add.Click += (sender, e) => Add_payment(grd_misc_payment_received, false);

			btn_payment_received_edit.Click += (sender, e) => Edit_payment(grd_payment_received);
			btn_expenses_edit.Click += (sender, e) => Edit_payment(grd_expenses);
			btn_misc_payment_received_edit.Click += (sender, e) => Edit_payment(grd_misc_payment_received);

			btn_payment_received_delete.Click += (sender, e) => Delete_payment(grd_payment_received);
			btn_expenses_delete.Click += (sender, e) => Delete_payment(grd_expenses);
			btn_misc_payment_received_delete.Click += (sender, e) => Delete_payment(grd_misc_payment_received);

			grd_payment_received.CellDoubleClick += (sender, e) => Grd_payment_CellDoubleClick(e, grd_payment_received, btn_payment_received_edit);
			grd_expenses.CellDoubleClick += (sender, e) => Grd_payment_CellDoubleClick(e, grd_expenses, btn_expenses_edit);
			grd_misc_payment_received.CellDoubleClick += (sender, e) => Grd_payment_CellDoubleClick(e, grd_misc_payment_received, btn_misc_payment_received_edit);
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			// remove vehicle trade in

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
					num_total_expenses.Value = dttable[0].vehicle_cost;

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
					num_insurance_loading_amount.Value = (num_insurance_premium.Value - num_insurance_stamp_duty.Value) *
						num_insurance_loading_percent.Value;
					num_insurance_ncb_percent.Value = dttable[0].insurance_ncb_percent;
					num_insurance_ncb_amount.Value = (num_insurance_premium.Value - num_insurance_stamp_duty.Value) *
						num_insurance_ncb_percent.Value;
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
				dttable.modified_byColumn.ReadOnly = true;

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
			Setup_grd_payment(grd_payment_received, Class_enum.Payment_function.VEHICLE_SALE_PAYMENT_RECEIVED);
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_payment_received,
				"payment_no", "payment_description", "pay_to", "amount",
				"payment_date", "is_paid", "payment_method_type", "cheque_no", "credit_card_no",
				"payment_method", "finance", "remark", "modified_by");
			// EXPENSES
			Setup_grd_payment(grd_expenses, Class_enum.Payment_function.VEHICLE_EXPENSES);
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_expenses,
				"charge_to_customer", "payment_no", "payment_description", "pay_to", "amount",
				"payment_date", "is_paid", "payment_method_type", "cheque_no", "credit_card_no",
				"payment_method", "finance", "remark", "modified_by");
			// column charge_to_customer will be checkbox. allow user to tick/untick. other columns cannot edit
			foreach (DataGridViewColumn grd_col in grd_expenses.Columns)
			{
				grd_col.ReadOnly = true;
				if (grd_col.Name == "charge_to_customer")
				{
					grd_col.ReadOnly = false;
					grd_col.DefaultCellStyle.BackColor = Color.Yellow;
				}
			}
			// MISC RECEIVED
			Setup_grd_payment(grd_misc_payment_received, Class_enum.Payment_function.VEHICLE_MISC_RECEIVED);
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_misc_payment_received,
				"payment_no", "payment_description", "pay_to", "amount",
				"payment_date", "is_paid", "payment_method_type", "cheque_no", "credit_card_no",
				"payment_method", "finance", "remark", "modified_by");
			// INSURANCE DRIVER
			using (Insurance_driver_ds.sp_select_insurance_driverDataTable dttable = Insurance_driver_ds.Select_insurance_driver(VehicleID))
			{
				dttable.modified_byColumn.ReadOnly = true;
				dttable.modified_byColumn.DefaultValue = Program.System_user.Name;
				grd_insurance_driver.DataSource = dttable;
			}
			// INSURANCE MISC CHARGES
			using (Insurance_misc_charges_ds.sp_select_insurance_misc_chargesDataTable dttable = Insurance_misc_charges_ds.Select_insurance_misc_charges(VehicleID))
			{
				dttable.modified_byColumn.ReadOnly = true;
				dttable.modified_byColumn.DefaultValue = Program.System_user.Name;
				grd_insurance_misc.DataSource = dttable;
				Class_datagridview.Set_column_to_money_column(grd_insurance_misc, "amount");
				grd_insurance_misc.Columns["insurance_misc_charges"].Visible = false;
			}
			Setup_grd_trade_in();

			((DataTable)grd_charges_add.DataSource).RowChanged += (sender2, e2) => Grd_charges_calculate_total(grd_charges_add);
			((DataTable)grd_charges_less.DataSource).RowChanged += (sender2, e2) => Grd_charges_calculate_total(grd_charges_less);

			Calculate_vehicle_payment();
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
		private void Setup_grd_payment(DataGridView grd,
			Class_enum.Payment_function payment_function, int int_preselect = 0)
		{
			using (Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable = Vehicle_payment_ds.Select_vehicle_payment(VehicleID, payment_function))
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
			Calculate_trade_in();
		}
		private void Calculate_insurance_ValueChanged(object sender, EventArgs e)
		{
			num_insurance_loading_amount.Value =
				(num_insurance_premium.Value - num_insurance_stamp_duty.Value) * num_insurance_loading_percent.Value / 100;
			num_insurance_ncb_amount.Value =
				(num_insurance_premium.Value - num_insurance_stamp_duty.Value) * num_insurance_ncb_percent.Value / 100;
		}
		private void Calculate_vehicle_payment()
		{
			// PAYMENT RECEIVED
			{
				Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable_payment_received =
					(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_payment_received.DataSource;
				decimal dcml_payment_received = 0;

				if (dttable_payment_received.Rows.Count != 0)
					dcml_payment_received = (from row in dttable_payment_received select row.amount).Sum();

				lbl_payment_received_total.Text = dcml_payment_received.ToString("#,##0.00");
				num_received_payment.Value = dcml_payment_received;
			}
			// EXPENSES
			{
				Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable_expenses =
					(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_expenses.DataSource;
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
				Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable_misc_received =
					(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_misc_payment_received.DataSource;
				decimal dcml_misc_received = 0;
				if (dttable_misc_received.Rows.Count != 0)
					dcml_misc_received = (from row in dttable_misc_received select row.amount).Sum();
				lbl_misc_payment_received_total.Text = dcml_misc_received.ToString("#,##0.00");
				num_total_misc_received.Value = dcml_misc_received;
			}

		}
		private void Add_payment(DataGridView grd, bool charge_to_customer)
		{
			using (Form_edit_payment dlg_payment = new Form_edit_payment())
			{
				if (dlg_payment.ShowDialog() != DialogResult.OK) return;

				Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable =
					(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd.DataSource;

				dttable.Addsp_select_vehicle_paymentRow(charge_to_customer, dlg_payment.PaymentNo,
					dlg_payment.PaymentDescription, dlg_payment.PayToId, dlg_payment.PayToName,
					dlg_payment.PayToType, dlg_payment.PaymentAmount, dlg_payment.PaymentDate,
					dlg_payment.IsPaid, dlg_payment.PaymentMethodType,
					dlg_payment.PaymentMethodDescription, dlg_payment.PaymentMethod,
					dlg_payment.ChequeNo, dlg_payment.CreditCardNo, dlg_payment.CreditCardTypeId,
					dlg_payment.CreditCardTypeName, dlg_payment.PaymentMethodFinance,
					dlg_payment.PaymentMethodFinanceName, dlg_payment.PaymentMethodDate,
					dlg_payment.PaymentRemark, Program.System_user.Name);
			}

			Calculate_vehicle_payment();
		}
		private void Edit_payment(DataGridView grd)
		{
			if (grd.SelectedCells.Count == 0) return;

			Vehicle_payment_ds.sp_select_vehicle_paymentRow dt_row =
				(from row in (Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd.DataSource
				 where row.payment == (int)grd.SelectedCells[0].OwningRow.Cells["payment"].Value
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
		private void Delete_payment(DataGridView grd)
		{
			if (grd.SelectedCells.Count == 0) return;

			if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning) != DialogResult.Yes) return;

			List<int> list_payment_id = new List<int>();

			Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable =
				(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd.DataSource;

			foreach (DataGridViewCell grd_cell in grd.SelectedCells)
			{
				list_payment_id.Add((int)grd_cell.OwningRow.Cells["payment"].Value);
			}
			for (int i = dttable.Rows.Count - 1; i >= 0; i--)
			{
				if (list_payment_id.Contains(dttable[i].payment)) dttable.Rows.RemoveAt(i);
			}
			Calculate_vehicle_payment();
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
			using (Form_edit_vehicle dlg = new Form_edit_vehicle())
			{
				if (dlg.ShowDialog() == DialogResult.OK) Setup_grd_trade_in(dlg.VehicleID);
			}
		}
		private void Btn_trade_in_edit_Click(object sender, EventArgs e)
		{
			if (grd_trade_in.SelectedCells.Count == 0) return;

			int int_vehicle_id = (int)grd_trade_in.SelectedCells[0].OwningRow.Cells["vehicle"].Value;

			using (Form_edit_vehicle dlg = new Form_edit_vehicle(int_vehicle_id))
			{
				if (dlg.ShowDialog() == DialogResult.OK) Setup_grd_trade_in(int_vehicle_id);
			}
		}
		private void Btn_trade_in_delete_Click(object sender, EventArgs e)
		{
			if (grd_trade_in.SelectedCells.Count == 0) return;
			if (MessageBox.Show("Are you sure? NOTE: Vehicle will only be removed as trade in for this vehicle sale. Vehicle record will still exist.",
				"Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				int vehicle_id = (int)grd_trade_in.SelectedCells[0].OwningRow.Cells["vehicle"].Value;

				Vehicle_ds.sp_select_vehicle_trade_inDataTable dttable =
					(Vehicle_ds.sp_select_vehicle_trade_inDataTable)grd_trade_in.DataSource;

				for (int i = 0, j = dttable.Rows.Count; i < j; i++)
				{
					if (dttable[i].vehicle == vehicle_id) dttable.Rows.RemoveAt(i);
				}
			}
			Calculate_trade_in();
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
	}
}
