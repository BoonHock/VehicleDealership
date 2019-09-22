using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Classes;
using VehicleDealership.Datasets;

namespace VehicleDealership.View
{
	public partial class Form_edit_vehicle : Form
	{
		public int VehicleID { get; private set; }

		string _str_reg_no;
		string _str_chassis_no;

		public Form_edit_vehicle(int int_vehicle = 0)
		{
			InitializeComponent();

			VehicleID = int_vehicle;
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			string str_reg_no = txt_reg_no.Text.Trim();
			string str_chassis = txt_chassis.Text.Trim();
			string str_engine_no = txt_engine_no.Text.Trim();

			if (str_reg_no == "" || str_chassis == "" || str_engine_no == "" || str_chassis == "" ||
				num_vehicle_model_id.Value == 0 || num_seller_id.Value == 0 || num_checked_by_id.Value == 0)
			{
				MessageBox.Show("All highlighted fields are required. Please input and retry.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void Form_edit_vehicle_Shown(object sender, EventArgs e)
		{
			cmb_vehicle_colour.DisplayMember = "colour_name";
			cmb_vehicle_colour.ValueMember = "colour";
			cmb_vehicle_colour.DataSource = Colour_ds.Select_colour();

			cmb_acquire_method.SelectedItem = "PURCHASE"; // DEFAULT

			if (VehicleID == 0) return;

			// select vehicle and populate controls
		}
		private void Txt_reg_no_Enter(object sender, EventArgs e)
		{
			_str_reg_no = txt_reg_no.Text;
		}
		private void Txt_chassis_Enter(object sender, EventArgs e)
		{
			_str_chassis_no = txt_chassis.Text;
		}
		private void Txt_reg_no_Leave(object sender, EventArgs e)
		{
			Txt_reg_chassis_leave(txt_reg_no, ref _str_reg_no);
		}
		private void Txt_chassis_Leave(object sender, EventArgs e)
		{
			Txt_reg_chassis_leave(txt_chassis, ref _str_chassis_no);
		}
		private void Txt_reg_chassis_leave(TextBox txtbox, ref string str_param)
		{
			if (str_param == txtbox.Text) return; // user didn't make any changes. do nothing

			btn_vehicle_model.Enabled = true; // default is enabled	

			txtbox.Text = txtbox.Text.Trim(); // trim input

			if (txtbox.Text == "") return;

			str_param = txtbox.Text; // set value for checking when control is entered next time

			Setup_vehicle_details(Vehicle_ds.Select_vehicle_latest_record("", txtbox.Text));
		}
		private void Setup_vehicle_details(Vehicle_ds.sp_select_vehicleDataTable dttable)
		{
			if (dttable.Rows.Count == 0) return;

			if (txt_reg_no.Text.Trim() == "")
			{
				// if registration no. no input yet, input latest record's
				_str_reg_no = dttable[0].registration_no;
				txt_reg_no.Text = _str_reg_no;
			}
			if (txt_chassis.Text.Trim() == "")
			{
				// if chassis no. no input yet, input latest record's
				_str_chassis_no = dttable[0].chassis_no;
				txt_chassis.Text = _str_chassis_no;
			}

			btn_vehicle_model.Enabled = false;
			num_vehicle_model_id.Value = dttable[0].vehicle_model;
			txt_vehicle_model.Text = dttable[0].vehicle_model_name;
			txt_vehicle_group.Text = dttable[0].vehicle_group_name;
			txt_vehicle_brand.Text = dttable[0].vehicle_brand_name;
			txt_year_make.Text = dttable[0].year_make.ToString();

			if (txt_engine_no.Text.Trim() == "") txt_engine_no.Text = dttable[0].engine_no;
			if (num_engine_cc.Value == 0) num_engine_cc.Value = (decimal)dttable[0].engine_cc;
			if (txt_ignition_key.Text.Trim() == "") txt_ignition_key.Text = dttable[0].ignition_key;
			if (txt_door_key.Text.Trim() == "") txt_door_key.Text = dttable[0].door_key;
			if (cmb_vehicle_colour.SelectedIndex == 0) cmb_vehicle_colour.SelectedValue = dttable[0].colour;
			rad_vehicle_new.Checked = false;
			rad_vehicle_old.Checked = true;
			if (num_year_registered.Value == 0) num_year_registered.Value = (decimal)dttable[0].year_registered;
		}
		private void Btn_vehicle_model_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("VEHICLE_MODEL", num_vehicle_model_id.Value.ToString());

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				num_vehicle_model_id.Value = dlg_select.Get_selected_value_as_int("vehicle_model");
				txt_vehicle_model.Text = dlg_select.Get_selected_value_as_string("vehicle_model_name");
				txt_vehicle_group.Text = dlg_select.Get_selected_value_as_string("vehicle_group_name");
				txt_vehicle_brand.Text = dlg_select.Get_selected_value_as_string("vehicle_brand_name");
				txt_year_make.Text = dlg_select.Get_selected_value_as_string("year_make");
			}
		}

		private void Btn_vehicle_location_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("LOCATION",
				num_vehicle_location.Value.ToString());

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				num_vehicle_location.Value = dlg_select.Get_selected_value_as_int("location");
				txt_vehicle_location.Text = dlg_select.Get_selected_value_as_string("location_name");
			}
		}

		private void Btn_seller_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("PERSON_ORGANISATION");

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				txt_seller_type.Text = dlg_select.cmb_type.SelectedItem.ToString().ToUpper();

				if (txt_seller_type.Text == "PERSON")
				{
					num_seller_id.Value = dlg_select.Get_selected_value_as_int("person");
					txt_seller_name.Text = dlg_select.Get_selected_value_as_string("name");
				}
				else
				{
					num_seller_id.Value = dlg_select.Get_selected_value_as_int("organisation");
					txt_seller_name.Text = dlg_select.Get_selected_value_as_string("name");
					txt_seller_branch.Text = dlg_select.Get_selected_value_as_string("branch_name");
				}
			}
		}

		private void Btn_checked_by_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("USER");

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				txt_checked_by.Text = dlg_select.Get_selected_value_as_string("name");
				num_checked_by_id.Value = dlg_select.Get_selected_value_as_int("user");
			}
		}
		private void Cmb_acquire_method_SelectedIndexChanged(object sender, EventArgs e)
		{
			btn_sales_order.Enabled = cmb_acquire_method.SelectedItem.ToString() == "TRADE-IN";
		}
		private void Btn_sales_order_Click(object sender, EventArgs e)
		{
			// TODO: in the future when sales feature is done
		}
		private void Recalculate_nums(object sender, EventArgs e)
		{
			num_net_purchase.Value = num_purchase_price.Value - num_overtrade.Value;
			num_total_cost.Value = num_net_purchase.Value + num_expenses.Value;
			num_gross_profit.Value = num_list_price.Value - num_total_cost.Value;
			num_to_pay_seller.Value = num_total_cost.Value - num_loan_balance.Value;
			num_to_pay.Value = num_to_pay_seller.Value - num_paid.Value;
		}
		private void Num_loan_balance_ValueChanged(object sender, EventArgs e)
		{
			num_loan_balance_readonly.Value = num_loan_balance.Value;
		}
		private void Btn_loan_finance_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("FINANCE", num_loan_finance_id.Value.ToString());

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				txt_loan_finance.Text = dlg_select.Get_selected_value_as_string("name");
				txt_loan_branch.Text = dlg_select.Get_selected_value_as_string("branch_name");
				num_loan_finance_id.Value = dlg_select.Get_selected_value_as_int("finance");
			}
		}

		private void Btn_add_expenses_Click(object sender, EventArgs e)
		{
			Form_edit_payment dlg_payment = new Form_edit_payment(0, (int)num_seller_id.Value, txt_seller_name.Text, txt_seller_type.Text);

			if (dlg_payment.ShowDialog() != DialogResult.OK) return;


		}

		private void Btn_edit_expenses_Click(object sender, EventArgs e)
		{

		}

		private void Btn_delete_expenses_Click(object sender, EventArgs e)
		{

		}

		private void Btn_add_payment_Click(object sender, EventArgs e)
		{

		}

		private void Btn_edit_payment_Click(object sender, EventArgs e)
		{

		}

		private void Btn_delete_payment_Click(object sender, EventArgs e)
		{

		}
	}
}
