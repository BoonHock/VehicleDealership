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
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return new sp_select_insurance_categoryDataTable();
		}
		public static bool Update_insert_insurance_category()
		{
			try
			{
				using (Insurance_category_dsTableAdapters.QueriesTableAdapter adapter =
					new Insurance_category_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_insert_insurance_category(Program.System_user.UserID);
					return true;
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return false;
		}
		public static bool Delete_insurance_category()
		{
			try
			{
				using (Insurance_category_dsTableAdapters.QueriesTableAdapter adapter =
					new Insurance_category_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_delete_insurance_category(Program.System_user.UserID);
					return true;
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return false;
		}
	}
}
