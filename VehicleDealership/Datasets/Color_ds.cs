using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{


	partial class Color_ds
	{
		private static Color_dsTableAdapters.sp_select_colorTableAdapter ColorTableAdapter()
		{
			return new Color_dsTableAdapters.sp_select_colorTableAdapter();
		}
		private static Color_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Color_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_colorDataTable Select_color()
		{
			try
			{
				return ColorTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new sp_select_colorDataTable();
		}
		public static bool Delete_color()
		{
			try
			{
				QueriesTableAdapter().sp_delete_color(Program.System_user.UserID);
				return true;
			}
			catch (System.Exception e)
			{
				MessageBox.Show("Delete color failed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				//MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
				//	"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
				//	"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		public static bool Update_insert_color()
		{
			try
			{
				QueriesTableAdapter().sp_update_insert_color(Program.System_user.UserID);
				return true;
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}
