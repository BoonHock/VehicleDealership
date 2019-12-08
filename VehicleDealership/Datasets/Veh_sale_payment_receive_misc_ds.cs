using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Veh_sale_payment_receive_misc_ds
	{
		public static sp_select_veh_sale_payment_receive_miscDataTable Select_veh_sale_payment_receive_misc(int vehicle)
		{
			try
			{
				using (Veh_sale_payment_receive_misc_dsTableAdapters.sp_select_veh_sale_payment_receive_miscTableAdapter adapter =
					new Veh_sale_payment_receive_misc_dsTableAdapters.sp_select_veh_sale_payment_receive_miscTableAdapter())
				{
					return adapter.GetData(vehicle);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return new sp_select_veh_sale_payment_receive_miscDataTable();
		}
		public static bool Update_veh_sale_payment_receive_misc (int vehicle, string payment_combine)
		{
			try
			{
				using (Veh_sale_payment_receive_misc_dsTableAdapters.QueriesTableAdapter adapter =
					new Veh_sale_payment_receive_misc_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_veh_sale_payment_receive_misc(vehicle, payment_combine, Program.System_user.UserID);
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
