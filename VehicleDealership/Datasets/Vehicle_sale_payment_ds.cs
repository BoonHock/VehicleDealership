using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_sale_payment_ds
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_vehicle"></param>
		/// <param name="int_payment_function">
		/// 1 - payment received from customers (vehicle sale)
		/// 2 - expenses (vehicle sale)
		/// 3 - misc paid (vehicle sale)
		/// 4 - misc received (vehicle sale)
		/// </param>
		/// <returns></returns>
		public static sp_select_vehicle_sale_paymentDataTable Select_vehicle_sale_payment(int int_vehicle, int int_payment_function)
		{
			try
			{
				using (Vehicle_sale_payment_dsTableAdapters.sp_select_vehicle_sale_paymentTableAdapter adapter = new Vehicle_sale_payment_dsTableAdapters.sp_select_vehicle_sale_paymentTableAdapter())
				{
					return adapter.GetData(int_vehicle,int_payment_function);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_sale_paymentDataTable();
		}
	}
}
