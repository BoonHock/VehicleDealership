using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{


	partial class vehicle_model_image_ds
	{
		/// <summary>
		/// select images for a vehicle model
		/// </summary>
		/// <param name="vmodel"></param>
		/// <returns></returns>
		public static sp_select_vehicle_model_imageDataTable Select_vehicle_model_image(int vmodel)
		{
			try
			{
				using (vehicle_model_image_dsTableAdapters.sp_select_vehicle_model_imageTableAdapter adapter = 
					new vehicle_model_image_dsTableAdapters.sp_select_vehicle_model_imageTableAdapter())
				{
					return adapter.GetData(vmodel);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_model_imageDataTable();
		}
		public static bool Insert_vehicle_model_image(int int_vmodel, byte[] byte_image, string str_description)
		{
			try
			{
				using (vehicle_model_image_dsTableAdapters.QueriesTableAdapter adapter = new vehicle_model_image_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_insert_vehicle_model_image(int_vmodel, byte_image, str_description, Program.System_user.UserID);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
				return false;
			}
			return true;
		}
		public static bool Update_vehicle_model_image(string str_description, int int_vmodel_img)
		{
			try
			{
				using (vehicle_model_image_dsTableAdapters.QueriesTableAdapter adapter = new vehicle_model_image_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_vehicle_model_image(str_description, int_vmodel_img);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
				return false;
			}
			return true;
		}
	}
}
