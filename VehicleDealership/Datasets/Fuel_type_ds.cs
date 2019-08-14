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
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
		public static bool Delete_fuel_type()
		{
			try
			{
				QueriesAdapter().sp_delete_fuel_type(Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
	}
}
