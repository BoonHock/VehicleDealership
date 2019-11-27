using System;
using System.Reflection;

namespace VehicleDealership.Datasets
{
	partial class Salesperson_ds
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_salesperson">-1 to select all</param>
		/// <param name="is_active">-1 to select all; 1 to select active; 0 to select inactive</param>
		/// <returns></returns>
		public static sp_select_salespersonDataTable Select_salesperson(int int_salesperson, int is_active = -1)
		{
			try
			{
				using (Salesperson_dsTableAdapters.sp_select_salespersonTableAdapter adapter =
					new Salesperson_dsTableAdapters.sp_select_salespersonTableAdapter())
				{
					return adapter.GetData(int_salesperson, is_active);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_salespersonDataTable();
		}
		public static int Insert_salesperson(int int_person_orgbranch, bool is_person, string str_location,
			DateTime date_join, DateTime? date_leave, string str_remark)
		{
			try
			{
				using (Salesperson_dsTableAdapters.QueriesTableAdapter adapter =
					new Salesperson_dsTableAdapters.QueriesTableAdapter())
				{
					return int.Parse(adapter.sp_insert_salesperson(int_person_orgbranch, is_person,
						str_location, date_join, date_leave, str_remark, Program.System_user.UserID).ToString());
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Update_salesperson(int int_salesperson, string str_location,
			DateTime date_join, DateTime? date_leave, string str_remark)
		{
			try
			{
				using (Salesperson_dsTableAdapters.QueriesTableAdapter adapter =
					new Salesperson_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_salesperson(int_salesperson, str_location,
						date_join, date_leave, str_remark, Program.System_user.UserID);
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
