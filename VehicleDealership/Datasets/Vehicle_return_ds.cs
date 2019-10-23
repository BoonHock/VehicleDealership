using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_return_ds
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_vehicle">-1 to select all</param>
		/// <returns></returns>
		public static sp_select_vehicle_returnDataTable Select_vehicle_return(int int_vehicle)
		{
			try
			{
				using (Vehicle_return_dsTableAdapters.sp_select_vehicle_returnTableAdapter adapter =
					new Vehicle_return_dsTableAdapters.sp_select_vehicle_returnTableAdapter())
				{
					return adapter.GetData(int_vehicle);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_returnDataTable();
		}
		public static bool Insert_vehicle_return(int int_vehicle, System.DateTime return_date, int return_by, decimal compensation, string str_remark)
		{
			try
			{
				using (Vehicle_return_dsTableAdapters.QueriesTableAdapter adapter = new Vehicle_return_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_insert_vehicle_return(int_vehicle, return_date, return_by, compensation, str_remark, Program.System_user.UserID);
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
		public static bool Update_vehicle_return(int int_vehicle, System.DateTime return_date, int return_by, decimal compensation, string str_remark)
		{
			try
			{
				using (Vehicle_return_dsTableAdapters.QueriesTableAdapter adapter = new Vehicle_return_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_vehicle_return(int_vehicle, return_date, return_by, compensation, str_remark, Program.System_user.UserID);
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
		public static bool Delete_vehicle_return(int int_vehicle)
		{
			try
			{
				using (Vehicle_return_dsTableAdapters.QueriesTableAdapter adapter = new Vehicle_return_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_delete_vehicle_return(int_vehicle);
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
