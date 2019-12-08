using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_expenses_ds
	{
		public static sp_select_vehicle_expensesDataTable Select_vehicle_expenses(int vehicle)
		{
			try
			{
				using (Vehicle_expenses_dsTableAdapters.sp_select_vehicle_expensesTableAdapter adapter = 
					new Vehicle_expenses_dsTableAdapters.sp_select_vehicle_expensesTableAdapter())
				{
					return adapter.GetData(vehicle);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return new sp_select_vehicle_expensesDataTable();
		}
		public static bool Update_vehicle_expenses(int vehicle, string payment_combine, string payment_charge_to_customer)
		{
			try
			{
				using (Vehicle_expenses_dsTableAdapters.QueriesTableAdapter adapter =
					new Vehicle_expenses_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_vehicle_expenses(vehicle, payment_combine, payment_charge_to_customer, Program.System_user.UserID);
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
