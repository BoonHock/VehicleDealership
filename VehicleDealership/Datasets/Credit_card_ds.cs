using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Credit_card_ds
	{
		private static Credit_card_dsTableAdapters.sp_select_credit_cardTableAdapter Select_Credit_CardTableAdapter()
		{
			return new Credit_card_dsTableAdapters.sp_select_credit_cardTableAdapter();
		}
		private static Credit_card_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Credit_card_dsTableAdapters.QueriesTableAdapter();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str_credit_card_no">empty string to select all</param>
		/// <returns></returns>
		public static sp_select_credit_cardDataTable Select_credit_card(string str_credit_card_no = "")
		{
			try
			{
				return Select_Credit_CardTableAdapter().GetData(str_credit_card_no);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_credit_cardDataTable();
		}
		public static int Update_insert_credit_card(string cc_no, int cc_type, int finance, System.DateTime expiry_date)
		{
			try
			{
				return (int)QueriesTableAdapter().sp_update_insert_credit_card(cc_no,
					cc_type, finance, expiry_date, Program.System_user.UserID);
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
