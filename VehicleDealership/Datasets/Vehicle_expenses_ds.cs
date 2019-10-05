using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_expenses_ds
	{
		private static Vehicle_expenses_dsTableAdapters.sp_select_vehicle_expensesTableAdapter Select_Vehicle_ExpensesTableAdapter()
		{
			return new Vehicle_expenses_dsTableAdapters.sp_select_vehicle_expensesTableAdapter();
		}
		private static Vehicle_expenses_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Vehicle_expenses_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_vehicle_expensesDataTable Select_vehicle_expenses(int vehicle)
		{
			try
			{
				using (Vehicle_expenses_dsTableAdapters.sp_select_vehicle_expensesTableAdapter adapter = Select_Vehicle_ExpensesTableAdapter())
				{
					sp_select_vehicle_expensesDataTable dttable = adapter.GetData(vehicle);

					foreach (System.Data.DataColumn dt_col in dttable.Columns)
					{
						dt_col.ReadOnly = false;
					}
					return dttable;
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_expensesDataTable();
		}
		public static bool Update_vehicle_expenses(int int_vehicle, string str_payment_combine)
		{
			try
			{
				using (Vehicle_expenses_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					adapter.sp_update_vehicle_expenses(int_vehicle, str_payment_combine);
				}
				return true;
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
