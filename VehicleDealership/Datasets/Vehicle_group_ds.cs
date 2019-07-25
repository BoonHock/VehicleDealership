using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{
	partial class Vehicle_group_ds
	{
		public static Vehicle_group_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Vehicle_group_dsTableAdapters.QueriesTableAdapter();
		}
		/// <summary>
		/// select 
		/// </summary>
		/// <param name="vbrand_to_ignore">-1 to select all</param>
		/// <returns></returns>
		public static sp_select_vehicle_brand_n_groupDataTable Select_vehicle_brand_n_group(int vbrand_to_ignore = -1)
		{
			try
			{
				return (new Vehicle_group_dsTableAdapters.sp_select_vehicle_brand_n_groupTableAdapter()).GetData(vbrand_to_ignore);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new sp_select_vehicle_brand_n_groupDataTable();
		}
		/// <summary>
		/// select all vehicle group under give vehicle brand
		/// </summary>
		/// <param name="int_vbrand"></param>
		/// <returns></returns>
		public static sp_select_vehicle_group_for_editDataTable Select_vehicle_group_for_edit(int int_vbrand)
		{
			try
			{
				return (new Vehicle_group_dsTableAdapters.sp_select_vehicle_group_for_editTableAdapter()).GetData(int_vbrand);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new sp_select_vehicle_group_for_editDataTable();
		}
		/// <summary>
		/// update/insert [veh].[vehicle_group] from [misc].[bulkcopy_table] by vehicle brand
		/// </summary>
		/// <param name="int_vehicle_brand"></param>
		public static void Update_insert_vehicle_group(int int_vehicle_brand)
		{
			try
			{
				QueriesTableAdapter().sp_update_insert_vehicle_group(int_vehicle_brand, Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		/// <summary>
		/// select vehicle group and its models
		/// </summary>
		/// <param name="int_vgroup"></param>
		/// <returns></returns>
		public static sp_select_vehicle_group_n_modelDataTable Select_vehicle_group_n_model(int int_vgroup)
		{
			try
			{
				return (new Vehicle_group_dsTableAdapters.sp_select_vehicle_group_n_modelTableAdapter()).GetData(int_vgroup);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new sp_select_vehicle_group_n_modelDataTable();
		}
	}
}
