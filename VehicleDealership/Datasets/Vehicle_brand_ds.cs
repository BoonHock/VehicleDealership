using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{
	partial class Vehicle_brand_ds
	{
		private static Vehicle_brand_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Vehicle_brand_dsTableAdapters.QueriesTableAdapter();
		}
		public static bool Is_vehicle_brand_name_available(string str_brandname, int int_brand)
		{
			try
			{
				return (bool)QueriesTableAdapter().sp_is_vehicle_brand_name_available(int_brand, str_brandname);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}
		public static int Insert_vehicle_brand(string str_brand_name, int int_country)
		{
			try
			{
				return int.Parse(QueriesTableAdapter().sp_insert_vehicle_brand(str_brand_name, int_country, Program.System_user.UserID).ToString());
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return 0;
		}
		public static void Update_vehicle_brand(int int_vbrand, string str_vbrand_name, int int_country)
		{
			try
			{
				QueriesTableAdapter().sp_update_vehicle_brand(int_vbrand, str_vbrand_name, int_country, Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
