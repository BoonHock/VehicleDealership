using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Insurance_misc_charges_ds
	{
		public static sp_select_insurance_misc_chargesDataTable Select_insurance_misc_charges(int int_vehicle)
		{
			try
			{
				using (Insurance_misc_charges_dsTableAdapters.sp_select_insurance_misc_chargesTableAdapter adapter =
					new Insurance_misc_charges_dsTableAdapters.sp_select_insurance_misc_chargesTableAdapter())
				{
					return adapter.GetData(int_vehicle);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_insurance_misc_chargesDataTable();
		}
		public static bool Update_insert_insurance_misc_charges(int int_vehicle)
		{
			try
			{
				using (Insurance_misc_charges_dsTableAdapters.QueriesTableAdapter adapter =
					new Insurance_misc_charges_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_insert_insurance_misc_charges(int_vehicle, Program.System_user.UserID);
					return true;
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
	}
}
