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
	public partial class Form_edit_payment : Form
	{
		readonly int _payment_id = 0;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_payment">payment id. 0 for new payment</param>
		/// <param name="int_pay_to"></param>
		/// <param name="str_pay_to_name"></param>
		/// <param name="str_pay_to_type"></param>
		public Form_edit_payment(int int_payment, int int_pay_to = 0, string str_pay_to_name = "", string str_pay_to_type = "")
		{
			InitializeComponent();
			_payment_id = int_payment;

			num_pay_to_id.Value = int_pay_to;
			txt_pay_to_type.Text = str_pay_to_type;
			txt_pay_to.Text = str_pay_to_name;
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.None;

			string str_description = txt_description.Text.Trim();
			string str_payment_method_no = txt_payment_method_no.Text.Trim();

			// TODO
			if (str_description == "")
			{

			}
			if (num_pay_to_id.Value == 0)
			{

			}
			if ((rad_credit_debit_card.Checked || rad_cheque.Checked) && str_payment_method_no == "")
			{

			}
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Form_edit_payment_Shown(object sender, EventArgs e)
		{
			cmb_payment_method.DataSource = Payment_method_ds.Select_payment_method(-1);
			cmb_payment_method.DisplayMember = "payment_method_description";
			cmb_payment_method.ValueMember = "payment_method";
		}
		private void Btn_pay_to_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("PERSON_ORGANISATION");

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				txt_pay_to_type.Text = dlg_select.cmb_type.SelectedItem.ToString().ToUpper();

				if (txt_pay_to_type.Text == "PERSON")
					num_pay_to_id.Value = dlg_select.Get_selected_value_as_int("person");
				else
					num_pay_to_id.Value = dlg_select.Get_selected_value_as_int("organisation");

				txt_pay_to.Text = dlg_select.Get_selected_value_as_string("name");
			}
		}

		private void Rad_payment_method_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rad = (RadioButton)sender;

			// set fields default visibility
			lbl_payment_method.Visible = false;
			cmb_payment_method.Visible = false;

			lbl_payment_method_no.Visible = true;
			txt_payment_method_no.Visible = true;

			lbl_credit_card_expiry.Visible = false;
			dtp_credit_card_expiry.Visible = false;

			if (rad == rad_credit_debit_card)
			{
				lbl_payment_method_no.Text = "Card number:";

				lbl_credit_card_expiry.Visible = true;
				dtp_credit_card_expiry.Visible = true;
			}
			else if (rad == rad_cheque)
			{
				lbl_payment_method_no.Text = "Cheque number:";
			}
			else if (rad == rad_other)
			{
				lbl_payment_method.Visible = true;
				cmb_payment_method.Visible = true;

				lbl_payment_method_no.Visible = false;
				txt_payment_method_no.Visible = false;
			}
		}
	}
}
