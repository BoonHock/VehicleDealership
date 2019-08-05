using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{


	partial class vehicle_model_image_ds
	{
		private static vehicle_model_image_dsTableAdapters.QueriesTableAdapter QueriesAdapter()
		{
			return new vehicle_model_image_dsTableAdapters.QueriesTableAdapter();
		}
		/// <summary>
		/// select images for a vehicle model
		/// </summary>
		/// <param name="vmodel"></param>
		/// <returns></returns>
		public static sp_select_vehicle_model_imageDataTable Select_vehicle_model_image(int vmodel)
		{
			try
			{
				return (new vehicle_model_image_dsTableAdapters.sp_select_vehicle_model_imageTableAdapter()).GetData(vmodel);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new sp_select_vehicle_model_imageDataTable();
		}
		public static bool Insert_vehicle_model_image(int int_vmodel, byte[] byte_image, string str_description)
		{
			try
			{
				QueriesAdapter().sp_insert_vehicle_model_image(int_vmodel, byte_image, str_description, Program.System_user.UserID);
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
		public static bool Update_vehicle_model_image(string str_description, int int_vmodel_img)
		{
			try
			{
				QueriesAdapter().sp_update_vehicle_model_image(str_description, int_vmodel_img);
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
