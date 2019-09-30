using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_attachment_ds
	{
		private static Vehicle_attachment_dsTableAdapters.sp_select_vehicle_attachmentTableAdapter Select_Vehicle_AttachmentTableAdapter()
		{
			return new Vehicle_attachment_dsTableAdapters.sp_select_vehicle_attachmentTableAdapter();
		}
		public static sp_select_vehicle_attachmentDataTable Select_vehicle_attachment(int vehicle)
		{
			try
			{
				return Select_Vehicle_AttachmentTableAdapter().GetData(vehicle);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_attachmentDataTable();
		}
	}
}
