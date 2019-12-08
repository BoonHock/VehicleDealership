using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Veh_sale_payment_customer_ds
	{
		public static sp_select_veh_sale_payment_customerDataTable Select_veh_sale_payment_customer(int vehicle)
		{
			try
			{
				using (Veh_sale_payment_customer_dsTableAdapters.sp_select_veh_sale_payment_customerTableAdapter adapter = 
					new Veh_sale_payment_customer_dsTableAdapters.sp_select_veh_sale_payment_customerTableAdapter())
				{
					return adapter.GetData(vehicle);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return new sp_select_veh_sale_payment_customerDataTable();
		}
		public static bool Update_veh_sale_payment_customer(int vehicle, string payment_combine)
		{
			try
			{
				using (Veh_sale_payment_customer_dsTableAdapters.QueriesTableAdapter adapter =
					new Veh_sale_payment_customer_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_veh_sale_payment_customer(vehicle, payment_combine, Program.System_user.UserID);
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
