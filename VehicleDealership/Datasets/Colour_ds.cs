using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{


	partial class Colour_ds
	{
		private static Colour_dsTableAdapters.sp_select_colourTableAdapter Select_ColourTableAdapter()
		{
			return new Colour_dsTableAdapters.sp_select_colourTableAdapter();
		}
		private static Colour_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Colour_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_colourDataTable Select_colour()
		{
			try
			{
				return Select_ColourTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_colourDataTable();
		}
		public static bool Delete_colour()
		{
			try
			{
				QueriesTableAdapter().sp_delete_colour(Program.System_user.UserID);
				return true;
			}
			catch (System.Exception)
			{
				//MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
				//	"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
				//	"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		public static bool Update_insert_colour()
		{
			try
			{
				QueriesTableAdapter().sp_update_insert_colour(Program.System_user.UserID);
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
