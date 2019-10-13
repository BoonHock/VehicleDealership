using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_image_ds
	{
		private static Vehicle_image_dsTableAdapters.sp_select_vehicle_imageTableAdapter Select_Vehicle_ImageTableAdapter()
		{
			return new Vehicle_image_dsTableAdapters.sp_select_vehicle_imageTableAdapter();
		}
		private static Vehicle_image_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Vehicle_image_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_vehicle_imageDataTable Select_vehicle_image(int vehicle)
		{
			try
			{
				using (Vehicle_image_dsTableAdapters.sp_select_vehicle_imageTableAdapter adapter = Select_Vehicle_ImageTableAdapter())
				{
					return adapter.GetData(vehicle);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_imageDataTable();
		}
		public static int Insert_vehicle_image(int int_vehicle, string str_filename, string str_description)
		{
			try
			{
				using (Vehicle_image_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					return int.Parse(adapter.sp_insert_vehicle_image(int_vehicle,
						str_filename, str_description, Program.System_user.UserID).ToString());
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Delete_vehicle_image(int int_vimage, int int_vehicle)
		{
			try
			{
				using (Vehicle_image_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					adapter.sp_delete_vehicle_image(int_vimage, int_vehicle);
					return true;
				}
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
