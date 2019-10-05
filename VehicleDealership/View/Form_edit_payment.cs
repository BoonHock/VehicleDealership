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
		public int PaymentID { get; private set; }
		public string PaymentNo { get { return txt_payment_no.Text.Trim(); } }
		public string PaymentDescription { get { return txt_description.Text.Trim(); } }
		public bool IsPaid { get { return rad_paid.Checked; } }
		public int PayToId { get { return (int)num_pay_to_id.Value; } }
		public string PayToName { get { return txt_pay_to.Text.Trim(); } }
		public string PayToType { get { return txt_pay_to_type.Text.Trim().ToUpper(); } }
		public DateTime PaymentDate { get { return dtp_payment_date.Value; } }
		public decimal PaymentAmount { get { return num_amount.Value; } }
		public string PaymentMethodType
		{
			get
			{
				if (rad_credit_debit_card.Checked)
					return "CREDIT_CARD";
				else if (rad_cheque.Checked)
					return "CHEQUE";
				else
					return "OTHER";
			}
		}
		public int PaymentMethod { get { return (int)cmb_payment_method.SelectedValue; } }
		public string PaymentMethodDescription { get { return !rad_credit_debit_card.Checked && !rad_cheque.Checked ? ((DataRowView)cmb_payment_method.SelectedItem).Row["payment_method_description"].ToString() : ""; } }
		public string CreditCardNo { get { return rad_credit_debit_card.Checked ? maskedtxt_credit_card_no.Text.Trim() : ""; } }
		public string ChequeNo { get { return rad_cheque.Checked ? txt_cheque_no.Text.Trim() : ""; } }
		public int CreditCardTypeId { get { return (int)cmb_credit_card_type.SelectedValue; } }
		public string CreditCardTypeName
		{
			get
			{
				return rad_credit_debit_card.Checked ? ((DataRowView)cmb_credit_card_type.SelectedItem).Row["type_name"].ToString() : "";
			}
		}
		public int PaymentMethodFinance { get { return (int)num_payment_method_finance.Value; } }
		public string PaymentMethodFinanceName
		{
			get
			{
				return rad_credit_debit_card.Checked || rad_cheque.Checked ? txt_payment_method_finance.Text.Trim() : "";
			}
		}
		public DateTime PaymentMethodDate { get { return dtp_payment_method_date.Value; } }
		public string PaymentRemark { get { return txt_remark.Text.Trim(); } }
		public Form_edit_payment(int payment_id)
		{
			InitializeComponent();
			// edit existing payment. need to get payment details from db
			Init_form();
		}
		public Form_edit_payment(int payment_id, string payment_no, string payment_desc, bool is_paid,
			int pay_to_id, string pay_to_name, string pay_to_type, DateTime payment_date,
			decimal payment_amount, string payment_method_type, int payment_method, string credit_card_no,
			string cheque_no, int credit_card_type, int payment_method_finance,
			string payment_method_finance_name, DateTime payment_method_date, string payment_remark)
		{
			InitializeComponent();

			Init_form();

			PaymentID = payment_id;
			txt_payment_no.Text = payment_no;
			txt_description.Text = payment_desc;
			rad_paid.Checked = is_paid;
			rad_unpaid.Checked = !is_paid;
			num_pay_to_id.Value = pay_to_id;
			txt_pay_to.Text = pay_to_name;
			txt_pay_to_type.Text = pay_to_type;
			dtp_payment_date.Value = payment_date;
			num_amount.Value = payment_amount;
			rad_credit_debit_card.Checked = payment_method_type == "CREDIT_CARD";
			rad_cheque.Checked = payment_method_type == "CHEQUE";
			rad_other.Checked = !rad_credit_debit_card.Checked && !rad_cheque.Checked;
			cmb_payment_method.SelectedValue = payment_method;
			maskedtxt_credit_card_no.Text = credit_card_no;
			txt_cheque_no.Text = cheque_no;
			cmb_credit_card_type.SelectedValue = credit_card_type;
			num_payment_method_finance.Value = payment_method_finance;
			txt_payment_method_finance.Text = payment_method_finance_name;
			dtp_payment_method_date.Value = payment_method_date;
			txt_remark.Text = payment_remark;
		}
		/// <summary>
		/// Add new payment
		/// </summary>
		/// <param name="int_payment">payment id. 0 for new payment</param>
		/// <param name="int_pay_to"></param>
		/// <param name="str_pay_to_name"></param>
		/// <param name="str_pay_to_type"></param>
		public Form_edit_payment(int int_pay_to = 0, string str_pay_to_name = "",
			string str_pay_to_type = "")
		{
			InitializeComponent();

			Init_form();

			num_pay_to_id.Value = int_pay_to;
			txt_pay_to_type.Text = str_pay_to_type;
			txt_pay_to.Text = str_pay_to_name;

		}
		private void Init_form()
		{
			cmb_payment_method.DataSource = Payment_method_ds.Select_payment_method(-1);
			cmb_payment_method.DisplayMember = "payment_method_description";
			cmb_payment_method.ValueMember = "payment_method";

			cmb_credit_card_type.DataSource = Credit_card_type_ds.Select_credit_card_type();
			cmb_credit_card_type.DisplayMember = "type_name";
			cmb_credit_card_type.ValueMember = "credit_card_type";
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.None;

			string str_description = txt_description.Text.Trim();
			string str_credit_card_no = maskedtxt_credit_card_no.Text.Trim();
			string str_cheque_no = txt_cheque_no.Text.Trim();

			if (str_description == "")
			{
				MessageBox.Show("Payment description is required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (num_pay_to_id.Value == 0)
			{
				MessageBox.Show("Payment receiver (pay to) not selected.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (rad_credit_debit_card.Checked)
			{
				if (str_credit_card_no == "")
				{
					MessageBox.Show("Credit card number is required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (num_payment_method_finance.Value == 0)
				{
					MessageBox.Show("Payment method finance is required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			else if (rad_cheque.Checked)
			{
				if (str_cheque_no == "")
				{
					MessageBox.Show("Cheque number is required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (num_payment_method_finance.Value == 0)
				{
					MessageBox.Show("Payment method finance is required.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Form_edit_payment_Shown(object sender, EventArgs e)
		{
			Setup_payment_method_groupbox();
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
			Setup_payment_method_groupbox();
		}
		private void Setup_payment_method_groupbox()
		{
			lbl_payment_method.Visible = rad_other.Checked;
			cmb_payment_method.Visible = rad_other.Checked;

			lbl_credit_card_no.Visible = rad_credit_debit_card.Checked;
			maskedtxt_credit_card_no.Visible = rad_credit_debit_card.Checked;

			lbl_cheque_no.Visible = rad_cheque.Checked;
			txt_cheque_no.Visible = rad_cheque.Checked;

			lbl_credit_card_type.Visible = rad_credit_debit_card.Checked;
			cmb_credit_card_type.Visible = rad_credit_debit_card.Checked;

			lbl_payment_method_finance.Visible = rad_credit_debit_card.Checked || rad_cheque.Checked;
			txt_payment_method_finance.Visible = rad_credit_debit_card.Checked || rad_cheque.Checked;
			btn_payment_method_finance.Visible = rad_credit_debit_card.Checked || rad_cheque.Checked;

			lbl_payment_method_date.Visible = rad_credit_debit_card.Checked || rad_cheque.Checked;
			dtp_payment_method_date.Visible = rad_credit_debit_card.Checked || rad_cheque.Checked;

			if (rad_credit_debit_card.Checked)
			{
				lbl_payment_method_date.Text = "Expiry:";
				dtp_payment_method_date.Format = DateTimePickerFormat.Custom;
				dtp_payment_method_date.CustomFormat = "MM/yy";
			}
			else if (rad_cheque.Checked)
			{
				lbl_payment_method_date.Text = "Cheque date:";
				dtp_payment_method_date.Format = DateTimePickerFormat.Short;
			}
		}
		private void Btn_payment_method_finance_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("FINANCE", num_payment_method_finance.Value.ToString());

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				txt_payment_method_finance.Text = dlg_select.Get_selected_value_as_string("name");
				num_payment_method_finance.Value = dlg_select.Get_selected_value_as_int("finance");
			}
		}
		private void Maskedtxt_credit_card_no_Leave(object sender, EventArgs e)
		{
			Credit_card_ds.sp_select_credit_cardDataTable dttable = Credit_card_ds.Select_credit_card(maskedtxt_credit_card_no.Text);

			if (dttable.Rows.Count > 0)
			{
				cmb_credit_card_type.SelectedValue = dttable[0].credit_card_type;
				txt_payment_method_finance.Text = dttable[0].name;
				num_payment_method_finance.Value = dttable[0].finance;
				dtp_payment_method_date.Value = dttable[0].expiry_date;
			}
		}
		private void Txt_cheque_no_Leave(object sender, EventArgs e)
		{
			Cheque_ds.sp_select_chequeDataTable dttable = Cheque_ds.Select_cheque(maskedtxt_credit_card_no.Text);
			if (dttable.Rows.Count > 0)
			{
				txt_payment_method_finance.Text = dttable[0].name;
				num_payment_method_finance.Value = dttable[0].finance;
				dtp_payment_method_date.Value = dttable[0].cheque_date;
			}
		}
	}
}
