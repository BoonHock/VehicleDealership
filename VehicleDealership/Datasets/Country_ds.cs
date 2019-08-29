using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Country_ds
	{
		private static Country_dsTableAdapters.sp_select_countryTableAdapter Select_CountryTableAdapter()
		{
			return new Country_dsTableAdapters.sp_select_countryTableAdapter();
		}
		public static sp_select_countryDataTable Select_country()
		{
			try
			{
				return Select_CountryTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_countryDataTable();
		}
	}
}
