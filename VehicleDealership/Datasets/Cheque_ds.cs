using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Cheque_ds
	{
		private static Cheque_dsTableAdapters.sp_select_chequeTableAdapter Select_ChequeTableAdapter()
		{
			return new Cheque_dsTableAdapters.sp_select_chequeTableAdapter();
		}
		private static Cheque_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Cheque_dsTableAdapters.QueriesTableAdapter();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cheque_no">empty string to select all</param>
		/// <returns></returns>
		public static sp_select_chequeDataTable Select_cheque(string cheque_no = "")
		{
			try
			{
				return Select_ChequeTableAdapter().GetData(cheque_no);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_chequeDataTable();
		}
		public static int Update_insert_cheque(string cheque_no, System.DateTime cheque_date, int finance)
		{
			try
			{
				return int.Parse(QueriesTableAdapter().sp_update_insert_cheque(cheque_no,
					cheque_date, finance, Program.System_user.UserID).ToString());
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
	}
}
