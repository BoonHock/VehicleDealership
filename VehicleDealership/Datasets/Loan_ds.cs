using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Loan_ds
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_loan">-1 to select all</param>
		/// <returns></returns>
		public static sp_select_loanDataTable Select_loan(int int_loan)
		{
			try
			{
				using (Loan_dsTableAdapters.sp_select_loanTableAdapter adapter = new Loan_dsTableAdapters.sp_select_loanTableAdapter())
				{
					return adapter.GetData(int_loan);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_loanDataTable();
		}
		public static bool Update_insert_loan(int int_orgbranch, string str_remark)
		{
			try
			{
				using (Loan_dsTableAdapters.QueriesTableAdapter adapter = new Loan_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_insert_loan(int_orgbranch, str_remark, Program.System_user.UserID);
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
