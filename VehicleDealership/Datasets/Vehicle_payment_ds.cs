using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_payment_ds
	{
		private static Vehicle_payment_dsTableAdapters.sp_select_vehicle_paymentTableAdapter Select_Vehicle_PaymentTableAdapter()
		{
			return new Vehicle_payment_dsTableAdapters.sp_select_vehicle_paymentTableAdapter();
		}
		public static sp_select_vehicle_paymentDataTable Select_vehicle_payment(int vehicle)
		{
			sp_select_vehicle_paymentDataTable dttable = new sp_select_vehicle_paymentDataTable();
			try
			{
				dttable = Select_Vehicle_PaymentTableAdapter().GetData(vehicle);
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
