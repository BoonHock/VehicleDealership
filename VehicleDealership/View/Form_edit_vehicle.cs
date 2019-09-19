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

		private void Btn_vehicle_model_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("VEHICLE_MODEL", num_vehicle_model_id.Value.ToString());

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				num_vehicle_model_id.Value = dlg_select.Get_selected_value_as_int("vehicle_model");
				txt_vehicle_model.Text = dlg_select.Get_selected_value_as_string("vehicle_model_name");
				txt_vehicle_group.Text = dlg_select.Get_selected_value_as_string("vehicle_group_name");
				txt_vehicle_brand.Text = dlg_select.Get_selected_value_as_string("vehicle_brand_name");
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
					num_vehicle_location.Value = dlg_select.Get_selected_value_as_int("person");
					txt_seller_name.Text = dlg_select.Get_selected_value_as_string("name");
				}
				else
				{
					num_vehicle_location.Value = dlg_select.Get_selected_value_as_int("organisation");
					txt_seller_name.Text = dlg_select.Get_selected_value_as_string("name");
					txt_seller_branch.Text = dlg_select.Get_selected_value_as_string("branch_name");
				}
			}
		}

		private void Btn_checked_by_Click(object sender, EventArgs e)
		{
			// TODO
		}

		private void Btn_sales_order_Click(object sender, EventArgs e)
		{

		}

		private void Btn_loan_finance_Click(object sender, EventArgs e)
		{

		}

		private void Txt_reg_no_Leave(object sender, EventArgs e)
		{

		}

		private void Txt_chassis_Leave(object sender, EventArgs e)
		{

		}

		private void Num_purchase_price_ValueChanged(object sender, EventArgs e)
		{

		}

		private void Num_overtrade_ValueChanged(object sender, EventArgs e)
		{

		}

		private void Num_list_price_ValueChanged(object sender, EventArgs e)
		{

		}

		private void Num_loan_finance_id_ValueChanged(object sender, EventArgs e)
		{
			txt_loan_finance.Text = "";
			txt_loan_branch.Text = "";

			Finance_ds.sp_select_financeDataTable dttable = Finance_ds.Select_finance((int)num_loan_finance_id.Value);

			if (dttable.Rows.Count == 0) return;

			txt_loan_finance.Text = dttable[0].name;
			txt_loan_branch.Text = dttable[0].branch_name;
		}
	}
}
