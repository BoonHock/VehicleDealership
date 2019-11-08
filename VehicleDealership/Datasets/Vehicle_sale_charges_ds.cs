using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_sale_charges_ds
	{
		public static sp_select_vehicle_sale_chargesDataTable Select_vehicle_sale_charges(int int_vehicle)
		{
			try
			{
				using (Vehicle_sale_charges_dsTableAdapters.sp_select_vehicle_sale_chargesTableAdapter adapter =
					new Vehicle_sale_charges_dsTableAdapters.sp_select_vehicle_sale_chargesTableAdapter())
				{
					return adapter.GetData(int_vehicle);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_sale_chargesDataTable();
		}
	}
}
