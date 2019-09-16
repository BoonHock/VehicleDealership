using System;
using System.Reflection;

namespace VehicleDealership.Datasets
{
	partial class Salesperson_ds
	{
		private static Salesperson_dsTableAdapters.sp_select_salespersonTableAdapter Select_SalespersonTableAdapter()
		{
			return new Salesperson_dsTableAdapters.sp_select_salespersonTableAdapter();
		}
		private static Salesperson_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Salesperson_dsTableAdapters.QueriesTableAdapter();
		}
		/// <summary>
		/// select salesperson
		/// </summary>
		/// <param name="int_salesperson">-1 to select all</param>
		/// <returns></returns>
		public static sp_select_salespersonDataTable Select_salesperson(int int_salesperson)
		{
			try
			{
				return Select_SalespersonTableAdapter().GetData(int_salesperson);
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
				return int.Parse(QueriesTableAdapter().sp_insert_salesperson(int_person_orgbranch, is_person,
					str_location, date_join, date_leave, str_remark, Program.System_user.UserID).ToString());
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
				QueriesTableAdapter().sp_update_salesperson(int_salesperson, str_location,
					date_join, date_leave, str_remark, Program.System_user.UserID);
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
