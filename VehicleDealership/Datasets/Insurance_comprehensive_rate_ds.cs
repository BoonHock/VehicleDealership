using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Insurance_comprehensive_rate_ds
	{
		public static sp_select_insurance_comprehensive_rateDataTable Select_insurance_comprehensive_rate(int int_insurance_comprehensive, int int_cc)
		{
			try
			{
				using (Insurance_comprehensive_rate_dsTableAdapters.sp_select_insurance_comprehensive_rateTableAdapter adapter =
					new Insurance_comprehensive_rate_dsTableAdapters.sp_select_insurance_comprehensive_rateTableAdapter())
				{
					return adapter.GetData(int_insurance_comprehensive, int_cc);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_insurance_comprehensive_rateDataTable();
		}
		public static bool Update_insert_ins_com_rate(int int_insurance_comprehensive)
		{
			try
			{
				using (Insurance_comprehensive_rate_dsTableAdapters.QueriesTableAdapter adapter =
					new Insurance_comprehensive_rate_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_insert_ins_com_rate(int_insurance_comprehensive, Program.System_user.UserID);
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
