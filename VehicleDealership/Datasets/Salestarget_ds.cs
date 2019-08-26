using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Salestarget_ds
	{
		private static Salestarget_dsTableAdapters.sp_select_salestargetTableAdapter Select_SalestargetTableAdapter()
		{
			return new Salestarget_dsTableAdapters.sp_select_salestargetTableAdapter();
		}
		public static sp_select_salestargetDataTable Select_salestarget(int int_salesperson)
		{
			try
			{
				return Select_SalestargetTableAdapter().GetData(int_salesperson);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_salestargetDataTable();
		}
	}
}
