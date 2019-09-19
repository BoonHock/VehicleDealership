using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_ds
	{
		private static Vehicle_dsTableAdapters.sp_select_vehicle_simplifiedTableAdapter Select_Vehicle_SimplifiedTableAdapter()
		{
			return new Vehicle_dsTableAdapters.sp_select_vehicle_simplifiedTableAdapter();
		}
		private static Vehicle_dsTableAdapters.sp_select_vehicleTableAdapter Select_VehicleTableAdapter()
		{
			return new Vehicle_dsTableAdapters.sp_select_vehicleTableAdapter();
		}
		public static sp_select_vehicle_simplifiedDataTable Select_vehicle_simplified()
		{
			try
			{
				return Select_Vehicle_SimplifiedTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_simplifiedDataTable();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_vehicle">-1 to select all</param>
		/// <returns></returns>
		public static sp_select_vehicleDataTable Select_vehicle(int int_vehicle)
		{
			try
			{
				return Select_VehicleTableAdapter().GetData(int_vehicle);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicleDataTable();
		}
	}
}
