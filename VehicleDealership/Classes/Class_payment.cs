using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleDealership.Datasets;

namespace VehicleDealership.Classes
{
	class Class_payment
	{
		public static int Update_insert_payment_out(string str_doc_prefix, int int_payment_id,
			string str_payment_description, int int_pay_to_id,
			string str_pay_to_type, decimal dec_amount, DateTime payment_date, bool is_paid,
			string str_payment_method_type, int int_payment_method_id, string str_cheque_no, string str_cc_no,
			int int_cc_type, int int_finance_id, DateTime payment_method_date, string str_remark)
		{
			int int_credit_card = 0; // default value is 0. only set value if right payment method type selected
			int int_cheque = 0; // default value is 0. only set value if right payment method type selected
			int int_payment_method = 0; // default value is 0. only set value if right payment method type selected

			switch (str_payment_method_type)
			{
				case "CREDIT_CARD":
					int_credit_card = Credit_card_ds.Update_insert_credit_card(str_cc_no,
						int_cc_type, int_finance_id, payment_method_date);
					break;
				case "CHEQUE":
					int_cheque = Cheque_ds.Update_insert_cheque(str_cheque_no, payment_method_date, int_finance_id);
					break;
				default:
					int_payment_method = int_payment_method_id;
					break;
			}
			if (int_payment_id > 0)
			{
				// update
				Payment_out_ds.Update_payment_out(int_payment_id, str_payment_description, payment_date,
					dec_amount, int_cheque, int_credit_card, int_payment_method, is_paid,
					int_pay_to_id, (str_pay_to_type == "PERSON"), str_remark);
			}
			else
			{
				// insert
				int_payment_id = Payment_out_ds.Insert_payment_out(str_doc_prefix, str_payment_description,
					payment_date, dec_amount, int_cheque, int_credit_card, int_payment_method,
					is_paid, int_pay_to_id, (str_pay_to_type == "PERSON"), str_remark);
			}

			return int_payment_id;
		}
		public static int Update_insert_payment_in(string str_doc_prefix, int int_payment_id,
			string str_payment_description, decimal dec_amount, DateTime payment_date,
			string str_payment_method_type, int int_payment_method_id, string str_cheque_no, string str_cc_no,
			int int_cc_type, int int_finance_id, DateTime payment_method_date, string str_remark)
		{
			int int_credit_card = 0; // default value is 0. only set value if right payment method type selected
			int int_cheque = 0; // default value is 0. only set value if right payment method type selected
			int int_payment_method = 0; // default value is 0. only set value if right payment method type selected

			switch (str_payment_method_type)
			{
				case "CREDIT_CARD":
					int_credit_card = Credit_card_ds.Update_insert_credit_card(str_cc_no,
						int_cc_type, int_finance_id, payment_method_date);
					break;
				case "CHEQUE":
					int_cheque = Cheque_ds.Update_insert_cheque(str_cheque_no, payment_method_date, int_finance_id);
					break;
				default:
					int_payment_method = int_payment_method_id;
					break;
			}
			if (int_payment_id > 0)
			{
				// update
				Payment_in_ds.Update_payment_in(int_payment_id, str_payment_description, payment_date,
					dec_amount, int_cheque, int_credit_card, int_payment_method, str_remark);
			}
			else
			{
				// insert
				int_payment_id = Payment_in_ds.Insert_payment_in(str_doc_prefix,
					str_payment_description, payment_date, dec_amount, int_cheque,
					int_credit_card, int_payment_method, str_remark);
			}

			return int_payment_id;
		}
	}
}
