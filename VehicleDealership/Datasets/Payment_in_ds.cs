using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Payment_in_ds
	{
		public static int Insert_payment_in(string str_payment_doc_prefix, string payment_desc,
			System.DateTime payment_date, decimal amount, int cheque, int credit_card,
			int payment_method, string remark)
		{
			try
			{
				using (Payment_in_dsTableAdapters.QueriesTableAdapter adapter =
					new Payment_in_dsTableAdapters.QueriesTableAdapter())
				{
					return int.Parse(adapter.sp_insert_payment_in(str_payment_doc_prefix,
						payment_desc, payment_date, amount, cheque, credit_card, payment_method,
						remark, Program.System_user.UserID).ToString());
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Update_payment_in(int int_payment, string payment_desc,
			System.DateTime payment_date, decimal amount, int cheque,
			int credit_card, int payment_method, string remark)
		{
			try
			{
				using (Payment_in_dsTableAdapters.QueriesTableAdapter adapter =
					new Payment_in_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_payment_in(int_payment, payment_desc, payment_date, amount,
						cheque, credit_card, payment_method, remark, Program.System_user.UserID);
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
