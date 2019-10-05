using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Chassis_ds
	{
		private static Chassis_dsTableAdapters.sp_select_chassisTableAdapter Select_ChassisTableAdapter()
		{
			return new Chassis_dsTableAdapters.sp_select_chassisTableAdapter();
		}
		private static Chassis_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Chassis_dsTableAdapters.QueriesTableAdapter();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str_chassis_no">pass empty string to select all chassis</param>
		/// <returns></returns>
		public static sp_select_chassisDataTable Select_chassis(string str_chassis_no)
		{
			try
			{
				return Select_ChassisTableAdapter().GetData(str_chassis_no);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_chassisDataTable();
		}
		public static int Insert_chassis(string str_chassis_no, int int_vehicle_model, System.DateTime registration_date)
		{
			try
			{
				return int.Parse(QueriesTableAdapter().sp_insert_chassis(str_chassis_no, int_vehicle_model,
					registration_date, Program.System_user.UserID).ToString());
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Update_chassis(int int_chassis, string str_chassis_no,
			int int_vehicle_model, System.DateTime registration_date)
		{
			try
			{
				QueriesTableAdapter().sp_update_chassis(int_chassis, str_chassis_no,
					int_vehicle_model, registration_date, Program.System_user.UserID);
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
