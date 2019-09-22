using System.Reflection;
using System.Linq;
using System.Data;

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
				return Select_VehicleTableAdapter().GetData(int_vehicle, "", "");
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicleDataTable();
		}
		public static sp_select_vehicleDataTable Select_vehicle_latest_record(string str_reg_no, string str_chassis_no)
		{
			try
			{
				sp_select_vehicleDataTable dttable =
					Select_VehicleTableAdapter().GetData(-1, str_reg_no, str_chassis_no);

				if (dttable.Rows.Count > 0)
				{
					// select first row. vehicle id is in descending order so will be latest record
					sp_select_vehicleRow query = (from row in dttable
												  orderby row.vehicle descending
												  select row).FirstOrDefault();
					dttable.Clear(); // clear all rows
					dttable.ImportRow(query); // insert selected row from linq
					return dttable; // return datatable
				}
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
