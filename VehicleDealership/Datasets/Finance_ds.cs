using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Finance_ds
	{
		private static Finance_dsTableAdapters.sp_select_financeTableAdapter Select_FinanceTableAdapter()
		{
			return new Finance_dsTableAdapters.sp_select_financeTableAdapter();
		}
		private static Finance_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Finance_dsTableAdapters.QueriesTableAdapter();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_finance">-1 to select all</param>
		/// <returns></returns>
		public static sp_select_financeDataTable Select_finance(int int_finance)
		{
			try
			{
				return Select_FinanceTableAdapter().GetData(int_finance);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_financeDataTable();
		}
		public static void Update_insert_finance(int int_orgbranch, string str_remark)
		{
			try
			{
				QueriesTableAdapter().sp_update_insert_finance(int_orgbranch, str_remark, Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
		}
	}
}
