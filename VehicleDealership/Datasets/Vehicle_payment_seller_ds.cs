using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_payment_seller_ds
	{
		public static sp_select_vehicle_payment_sellerDataTable Select_vehicle_payment_seller(int vehicle)
		{
			try
			{
				using (Vehicle_payment_seller_dsTableAdapters.sp_select_vehicle_payment_sellerTableAdapter adapter =
					new Vehicle_payment_seller_dsTableAdapters.sp_select_vehicle_payment_sellerTableAdapter())
				{
					return adapter.GetData(vehicle);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return new sp_select_vehicle_payment_sellerDataTable();
		}
		public static bool Update_vehicle_payment_seller(int vehicle, string payment_combine)
		{
			try
			{
				using (Vehicle_payment_seller_dsTableAdapters.QueriesTableAdapter adapter =
					new Vehicle_payment_seller_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_vehicle_payment_seller(vehicle, payment_combine, Program.System_user.UserID);
					return true;
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return false;
		}
	}
}
