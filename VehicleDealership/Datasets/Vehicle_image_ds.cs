using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_image_ds
	{
		private static Vehicle_image_dsTableAdapters.sp_select_vehicle_imageTableAdapter Select_Vehicle_ImageTableAdapter()
		{
			return new Vehicle_image_dsTableAdapters.sp_select_vehicle_imageTableAdapter();
		}
		public static sp_select_vehicle_imageDataTable Select_vehicle_image(int vehicle)
		{
			try
			{
				return Select_Vehicle_ImageTableAdapter().GetData(vehicle);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}

			return new sp_select_vehicle_imageDataTable();
		}
	}
}
