using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Organisation_type_ds
	{
		private static Organisation_type_dsTableAdapters.sp_select_organisation_typeTableAdapter Select_Organisation_TypeTableAdapter()
		{
			return new Organisation_type_dsTableAdapters.sp_select_organisation_typeTableAdapter();
		}
		public static sp_select_organisation_typeDataTable Select_organisation_type()
		{
			try
			{
				return Select_Organisation_TypeTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_organisation_typeDataTable();
		}
	}
}
