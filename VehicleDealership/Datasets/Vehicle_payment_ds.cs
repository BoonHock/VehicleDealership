using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_payment_ds
	{
		private static Vehicle_payment_dsTableAdapters.sp_select_vehicle_paymentTableAdapter Select_Vehicle_PaymentTableAdapter()
		{
			return new Vehicle_payment_dsTableAdapters.sp_select_vehicle_paymentTableAdapter();
		}
		private static Vehicle_payment_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Vehicle_payment_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_vehicle_paymentDataTable Select_vehicle_payment(int vehicle, Classes.Class_enum.Payment_function payment_function)
		{
			try
			{
				using (Vehicle_payment_dsTableAdapters.sp_select_vehicle_paymentTableAdapter adapter = Select_Vehicle_PaymentTableAdapter())
				{
					sp_select_vehicle_paymentDataTable dttable = adapter.GetData(vehicle, (int)payment_function);
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
			return new sp_select_vehicle_paymentDataTable();
		}
		public static bool Update_vehicle_payment(int vehicle, string payment_combine,
			Classes.Class_enum.Payment_function payment_function, string payment_charge_to_customer)
		{
			try
			{
				using (Vehicle_payment_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					adapter.sp_update_vehicle_payment(vehicle, payment_combine,
						(int)payment_function, payment_charge_to_customer, Program.System_user.UserID);
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
