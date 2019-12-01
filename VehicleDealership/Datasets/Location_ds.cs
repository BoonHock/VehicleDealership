using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Location_ds
	{
		private static Location_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Location_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_locationDataTable Select_location()
		{
			try
			{
				using (Location_dsTableAdapters.sp_select_locationTableAdapter adapter =
					new Location_dsTableAdapters.sp_select_locationTableAdapter())
				{
					return adapter.GetData();
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_locationDataTable();
		}
		public static bool Delete_location()
		{
			try
			{
				using (Location_dsTableAdapters.QueriesTableAdapter adapter =
					new Location_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_delete_location(Program.System_user.UserID);
				}
				return true;
			}
			catch (System.Exception)
			{
				//Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
				//	MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
		public static bool Update_insert_location()
		{
			try
			{
				using (Location_dsTableAdapters.QueriesTableAdapter adapter =
					new Location_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_insert_location(Program.System_user.UserID);
				}
				return true;
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
	}
}
