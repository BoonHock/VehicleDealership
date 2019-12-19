using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Insurance_comprehensive_ds
	{
		public static sp_select_insurance_comprehensiveDataTable Select_insurance_comprehensive(int int_ins_comprehensive = -1)
		{
			try
			{
				using (Insurance_comprehensive_dsTableAdapters.sp_select_insurance_comprehensiveTableAdapter adapter =
					new Insurance_comprehensive_dsTableAdapters.sp_select_insurance_comprehensiveTableAdapter())
				{
					return adapter.GetData(int_ins_comprehensive);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_insurance_comprehensiveDataTable();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str_title"></param>
		/// <param name="int_exclude_ins_com"></param>
		/// <returns>true if title available; false otherwise</returns>
		public static bool Check_ins_com_title_available(string str_title, int int_exclude_ins_com)
		{
			try
			{
				using (Insurance_comprehensive_dsTableAdapters.QueriesTableAdapter adapter =
					new Insurance_comprehensive_dsTableAdapters.QueriesTableAdapter())
				{
					return (int)adapter.sp_check_ins_com_title_available(str_title, int_exclude_ins_com) == 0;
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
		public static int Insert_insurance_comprehensive(string str_title)
		{
			try
			{
				using (Insurance_comprehensive_dsTableAdapters.QueriesTableAdapter adapter =
					new Insurance_comprehensive_dsTableAdapters.QueriesTableAdapter())
				{
					return (int)adapter.sp_insert_insurance_comprehensive(str_title, Program.System_user.UserID);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Update_insurance_comprehensive(int int_insurance_comprehensive, string str_title)
		{
			try
			{
				using (Insurance_comprehensive_dsTableAdapters.QueriesTableAdapter adapter =
					new Insurance_comprehensive_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_insurance_comprehensive(int_insurance_comprehensive,
						str_title, Program.System_user.UserID);
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
