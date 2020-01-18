using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{


	partial class Transmission_ds
	{
		private static Transmission_dsTableAdapters.sp_select_transmissionTableAdapter TransmissionTableAdapter()
		{
			return new Transmission_dsTableAdapters.sp_select_transmissionTableAdapter();
		}
		private static Transmission_dsTableAdapters.QueriesTableAdapter QueriesAdapter()
		{
			return new Transmission_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_transmissionDataTable Select_transmission()
		{
			try
			{
				return TransmissionTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_transmissionDataTable();
		}
		public static bool Update_insert_transmission()
		{
			try
			{
				QueriesAdapter().sp_update_insert_transmission(Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
				return false;
			}
			return true;
		}
		public static bool Delete_transmission()
		{
			try
			{
				return (int)QueriesAdapter().sp_delete_transmission(Program.System_user.UserID) == 0;
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
