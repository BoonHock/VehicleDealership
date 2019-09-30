using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Credit_card_type_ds
	{
		private static Credit_card_type_dsTableAdapters.sp_select_credit_card_typeTableAdapter Select_Credit_Card_TypeTableAdapter()
		{
			return new Credit_card_type_dsTableAdapters.sp_select_credit_card_typeTableAdapter();
		}
		public static sp_select_credit_card_typeDataTable Select_credit_card_type()
		{
			try
			{
				return Select_Credit_Card_TypeTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_credit_card_typeDataTable();
		}
	}
}
