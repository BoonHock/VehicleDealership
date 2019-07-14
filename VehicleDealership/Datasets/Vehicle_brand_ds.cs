using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{
	partial class Vehicle_brand_ds
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="vbrand">-1 to select all</param>
		/// <returns></returns>
		public static sp_select_vehicle_brand_n_groupDataTable Select_vehicle_brand_n_group(int vbrand = -1)
		{
			try
			{
				return (new Vehicle_brand_dsTableAdapters.sp_select_vehicle_brand_n_groupTableAdapter()).GetData(vbrand);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return new sp_select_vehicle_brand_n_groupDataTable();
		}
	}
}
