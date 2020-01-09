using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Payment_out_ds
	{
		public static int Insert_payment_out(string str_payment_doc_prefix, string payment_desc,
			System.DateTime payment_date, decimal amount, int cheque, int credit_card, int payment_method,
			bool payment_made, int pay_to_person_org, bool is_pay_to_person, string remark)
		{
			try
			{
				using (Payment_out_dsTableAdapters.QueriesTableAdapter adapter =
					new Payment_out_dsTableAdapters.QueriesTableAdapter())
				{
					return int.Parse(adapter.sp_insert_payment_out(str_payment_doc_prefix, payment_desc,
						payment_date, amount, cheque, credit_card, payment_method, payment_made,
						pay_to_person_org, is_pay_to_person, remark, Program.System_user.UserID).ToString());
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Update_payment_out(int payment, string payment_desc, System.DateTime payment_date,
			decimal amount, int cheque, int credit_card, int payment_method, bool payment_made,
			int pay_to_person_org, bool is_pay_to_person, string remark)
		{
			try
			{
				using (Payment_out_dsTableAdapters.QueriesTableAdapter adapter =
					new Payment_out_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_payment_out(payment, payment_desc, payment_date, amount,
						cheque, credit_card, payment_method, payment_made, pay_to_person_org,
						is_pay_to_person, remark, Program.System_user.UserID);
					return true;
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
	}
}
