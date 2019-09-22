using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{
	partial class Vehicle_model_ds
	{
		private static Vehicle_model_dsTableAdapters.QueriesTableAdapter QueriesAdapter()
		{
			return new Vehicle_model_dsTableAdapters.QueriesTableAdapter();
		}
		private static Vehicle_model_dsTableAdapters.sp_select_vehicle_modelTableAdapter Select_Vehicle_ModelTableAdapter()
		{
			return new Vehicle_model_dsTableAdapters.sp_select_vehicle_modelTableAdapter();
		}
		/// <summary>
		/// check if there is model name under a specific brand. if no, model name is available. else, not available
		/// </summary>
		/// <param name="str_model_name"></param>
		/// <param name="int_vgroup"></param>
		/// <returns></returns>
		public static bool Is_vehicle_model_name_available(string str_model_name, int int_vgroup)
		{
			try
			{
				return (int)QueriesAdapter().sp_is_vehicle_model_name_available(str_model_name, int_vgroup) == 0;
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
		/// <summary>
		/// insert vehicle model and get vehicle id
		/// </summary>
		/// <param name="str_model_name"></param>
		/// <param name="int_vgroup"></param>
		/// <param name="int_year_make"></param>
		/// <param name="int_engine_capacity"></param>
		/// <param name="int_no_of_door"></param>
		/// <param name="int_seat_capacity"></param>
		/// <param name="int_fuel_type"></param>
		/// <param name="int_transmission"></param>
		/// <param name="str_remarks"></param>
		/// <returns>newly inserted vehicle id</returns>
		public static int Insert_vehicle_model(string str_model_name, int int_vgroup,
			int int_year_make, int int_engine_capacity, int int_no_of_door, int int_seat_capacity,
			int int_fuel_type, int int_transmission, string str_remarks)
		{
			try
			{
				return int.Parse(QueriesAdapter().sp_insert_vehicle_model(str_model_name, int_vgroup,
					(short)int_year_make, (short)int_engine_capacity, (byte)int_no_of_door,
					(byte)int_seat_capacity, int_fuel_type, int_transmission, str_remarks,
					Program.System_user.UserID).ToString());
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		/// <summary>
		/// select vehicle model to display
		/// </summary>
		/// <param name="int_country">country id. -1 to select all</param>
		/// <param name="int_vbrand">vehicle brand id. -1 to select all</param>
		/// <param name="int_vgroup">vehicle group id. -1 to select all</param>
		/// <param name="int_vmodel">vehicle group id. -1 to select all</param>
		/// <returns></returns>
		public static sp_select_vehicle_modelDataTable Select_vehicle_model(int int_country, int int_vbrand,
			int int_vgroup, int int_vmodel)
		{
			try
			{
				return Select_Vehicle_ModelTableAdapter().GetData(int_country, int_vbrand, int_vgroup, int_vmodel);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_modelDataTable();
		}
		public static bool Update_vehicle_model(string str_model_name, int int_vgroup, int int_year_make,
			int int_engine_capacity, int int_no_of_door, int int_seat_capacity, int int_fuel_type,
			int int_transmission, string str_remarks, int int_vmodel)
		{
			try
			{
				QueriesAdapter().sp_update_vehicle_model(str_model_name, int_vgroup, (short)int_year_make, (short)int_engine_capacity, (byte)int_no_of_door,
					(byte)int_seat_capacity, int_fuel_type, int_transmission, str_remarks, int_vmodel, Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
				return false;
			}
			return true;
		}
	}
}
