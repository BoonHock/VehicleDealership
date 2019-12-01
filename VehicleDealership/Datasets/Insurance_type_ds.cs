using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Insurance_type_ds
	{
		public static sp_select_insurance_typeDataTable Select_insurance_type()
		{
			try
			{
				using (Insurance_type_dsTableAdapters.sp_select_insurance_typeTableAdapter adapter =
					new Insurance_type_dsTableAdapters.sp_select_insurance_typeTableAdapter())
				{
					return adapter.GetData();
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_insurance_typeDataTable();
		}
		public static bool Delete_insurance_type()
		{
			try
			{
				using (Insurance_type_dsTableAdapters.QueriesTableAdapter adapter =
					new Insurance_type_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_delete_insurance_type(Program.System_user.UserID);
				}
				return true;
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				//Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
				//	MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
		public static bool Update_insert_insurance_type()
		{
			try
			{
				using (Insurance_type_dsTableAdapters.QueriesTableAdapter adapter =
					new Insurance_type_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_insert_insurance_type(Program.System_user.UserID);
				}
				return true;
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
	}
}
