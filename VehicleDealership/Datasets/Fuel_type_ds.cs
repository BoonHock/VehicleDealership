using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{


	partial class Fuel_type_ds
	{
		private static Fuel_type_dsTableAdapters.QueriesTableAdapter QueriesAdapter()
		{
			return new Fuel_type_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_fuel_typeDataTable Select_fuel_type()
		{
			try
			{
				return (new Fuel_type_dsTableAdapters.sp_select_fuel_typeTableAdapter()).GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_fuel_typeDataTable();
		}
		public static bool Update_insert_fuel_type()
		{
			try
			{
				QueriesAdapter().sp_update_insert_fuel_type(Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
				return false;
			}
			return true;
		}
		public static bool Delete_fuel_type()
		{
			try
			{
				return (int)QueriesAdapter().sp_delete_fuel_type(Program.System_user.UserID) == 0;
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
