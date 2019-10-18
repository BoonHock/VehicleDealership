﻿using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Payment_ds
	{
		private static Payment_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Payment_dsTableAdapters.QueriesTableAdapter();
		}
		public static int Insert_payment(string str_payment_doc_prefix, string payment_desc,
			System.DateTime payment_date, decimal amount, int cheque, int credit_card, int payment_method,
			bool payment_made, int pay_to_person_org, bool is_pay_to_person, string remark)
		{
			try
			{
				using (Payment_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					return int.Parse(adapter.sp_insert_payment(str_payment_doc_prefix, payment_desc,
						payment_date, amount, cheque, credit_card, payment_method, payment_made,
						pay_to_person_org, is_pay_to_person, remark, Program.System_user.UserID).ToString());
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Update_payment(int payment, string payment_desc, System.DateTime payment_date,
			decimal amount, int cheque, int credit_card, int payment_method, bool payment_made,
			int pay_to_person_org, bool is_pay_to_person, string remark)
		{
			try
			{
				using (Payment_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					adapter.sp_update_payment(payment, payment_desc, payment_date, amount,
						cheque, credit_card, payment_method, payment_made, pay_to_person_org,
						is_pay_to_person, remark, Program.System_user.UserID);
				}
				return true;
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
	}
}