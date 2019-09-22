using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Payment_method_ds
	{
		private static Payment_method_dsTableAdapters.sp_select_payment_methodTableAdapter Select_Payment_MethodTableAdapter()
		{
			return new Payment_method_dsTableAdapters.sp_select_payment_methodTableAdapter();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_payment_id">-1 to select all</param>
		/// <returns></returns>
		public static sp_select_payment_methodDataTable Select_payment_method(int int_payment_id)
		{
			try
			{
				return Select_Payment_MethodTableAdapter().GetData(int_payment_id);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_payment_methodDataTable();
		}

	}
}
