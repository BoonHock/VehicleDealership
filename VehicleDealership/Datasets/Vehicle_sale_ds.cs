using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_sale_ds
	{
		public static sp_select_vehicle_saleDataTable Select_vehicle_sale(int int_vehicle)
		{
			try
			{
				using (Vehicle_sale_dsTableAdapters.sp_select_vehicle_saleTableAdapter adapter = new Vehicle_sale_dsTableAdapters.sp_select_vehicle_saleTableAdapter())
				{
					return adapter.GetData(int_vehicle);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_saleDataTable();
		}
		public static sp_select_vehicle_sale_simplifiedDataTable Select_vehicle_sale_simplified()
		{
			try
			{
				using (Vehicle_sale_dsTableAdapters.sp_select_vehicle_sale_simplifiedTableAdapter adapter =
					new Vehicle_sale_dsTableAdapters.sp_select_vehicle_sale_simplifiedTableAdapter())
				{
					return adapter.GetData();
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_sale_simplifiedDataTable();
		}
	}
}
