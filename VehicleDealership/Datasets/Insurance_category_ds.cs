using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Insurance_category_ds
	{
		public static sp_select_insurance_categoryDataTable Select_insurance_category()
		{
			try
			{
				using (Insurance_category_dsTableAdapters.sp_select_insurance_categoryTableAdapter adapter = 
					new Insurance_category_dsTableAdapters.sp_select_insurance_categoryTableAdapter())
				{
					return adapter.GetData();
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_insurance_categoryDataTable();
		}
	}
}
