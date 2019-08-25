using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Organisation_ds
	{
		private static Organisation_dsTableAdapters.sp_select_organisation1TableAdapter Select_Organisation1TableAdapter()
		{
			return new Organisation_dsTableAdapters.sp_select_organisation1TableAdapter();
		}
		public static sp_select_organisation1DataTable Select_organisation1()
		{
			try
			{
				return Select_Organisation1TableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_organisation1DataTable();
		}
	}
}
