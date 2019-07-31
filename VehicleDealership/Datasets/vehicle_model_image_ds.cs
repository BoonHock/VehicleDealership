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
	}
}
