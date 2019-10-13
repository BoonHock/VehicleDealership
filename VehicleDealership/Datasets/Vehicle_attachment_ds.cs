using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_attachment_ds
	{
		private static Vehicle_attachment_dsTableAdapters.sp_select_vehicle_attachmentTableAdapter Select_Vehicle_AttachmentTableAdapter()
		{
			return new Vehicle_attachment_dsTableAdapters.sp_select_vehicle_attachmentTableAdapter();
		}
		public static Vehicle_attachment_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Vehicle_attachment_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_vehicle_attachmentDataTable Select_vehicle_attachment(int vehicle)
		{
			try
			{
				using (Vehicle_attachment_dsTableAdapters.sp_select_vehicle_attachmentTableAdapter adapter = Select_Vehicle_AttachmentTableAdapter())
				{
					return adapter.GetData(vehicle);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_attachmentDataTable();
		}
		public static int Insert_vehicle_attachment(int int_vehicle, string str_filename)
		{
			try
			{
				using (Vehicle_attachment_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					return int.Parse(adapter.sp_insert_vehicle_attachment(int_vehicle,
						str_filename, Program.System_user.UserID).ToString());
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Delete_vehicle_attachment(int vattach_id, int int_vehicle)
		{
			try
			{
				using (Vehicle_attachment_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					adapter.sp_delete_vehicle_attachment(vattach_id, int_vehicle);
					return true;
				}
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
