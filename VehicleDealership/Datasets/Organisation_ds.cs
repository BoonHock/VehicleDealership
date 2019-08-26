using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Organisation_ds
	{
		private static Organisation_dsTableAdapters.Organisation_simplifiedTableAdapter Select_Organisation1TableAdapter()
		{
			return new Organisation_dsTableAdapters.Organisation_simplifiedTableAdapter();
		}
		public static Organisation_simplifiedDataTable Select_organisation1()
		{
			try
			{
				return Select_Organisation1TableAdapter().sp_select_organisation1();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new Organisation_simplifiedDataTable();
		}
		public static Organisation_simplifiedDataTable Select_organisation_not_salesperson()
		{
			try
			{
				return Select_Organisation1TableAdapter().sp_select_organisation_not_salesperson();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new Organisation_simplifiedDataTable();
		}
	}
}
