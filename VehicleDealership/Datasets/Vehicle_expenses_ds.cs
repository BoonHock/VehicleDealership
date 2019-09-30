using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_expenses_ds
	{
		private static Vehicle_expenses_dsTableAdapters.sp_select_vehicle_expensesTableAdapter Select_Vehicle_ExpensesTableAdapter()
		{
			return new Vehicle_expenses_dsTableAdapters.sp_select_vehicle_expensesTableAdapter();
		}
		public static sp_select_vehicle_expensesDataTable Select_vehicle_expenses(int vehicle)
		{
			sp_select_vehicle_expensesDataTable dttable = new sp_select_vehicle_expensesDataTable();
			try
			{
				dttable = Select_Vehicle_ExpensesTableAdapter().GetData(vehicle);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			foreach (System.Data.DataColumn dt_col in dttable.Columns)
			{
				dt_col.ReadOnly = false;
			}
			return dttable;
		}
	}
}
