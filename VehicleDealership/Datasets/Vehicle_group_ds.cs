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
		/// <param name="int_vbrand">-1 to select all vehicle groups</param>
		/// <returns></returns>
		public static sp_select_vehicle_brand_n_groupDataTable Select_vehicle_brand_n_group(int int_vbrand = -1)
		{
			try
			{
				return (new Vehicle_group_dsTableAdapters.sp_select_vehicle_brand_n_groupTableAdapter()).GetData(int_vbrand);
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
		/// check is vehicle group name is available because there mustn't be two vehicle group with same name
		/// under one vehicle brand
		/// </summary>
		/// <param name="str_group_name"></param>
		/// <param name="int_group_to_exclude"></param>
		/// <returns></returns>
		public static bool Is_vehicle_group_name_available(string str_group_name, int int_group_to_exclude)
		{
			try
			{
				return (int)QueriesTableAdapter().sp_is_vehicle_group_name_available(int_group_to_exclude, str_group_name) == 0;
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		/// <summary>
		/// update vehicle group if there any changes. case sensitve - will update if VIOS was updates to Vios
		/// </summary>
		/// <param name="int_vgroup"></param>
		/// <param name="str_vgroup_name"></param>
		/// <param name="int_vbrand"></param>
		public static void Update_vehicle_group(int int_vgroup, string str_vgroup_name, int int_vbrand)
		{
			try
			{
				QueriesTableAdapter().sp_update_vehicle_group(int_vgroup, str_vgroup_name, int_vbrand, Program.System_user.UserID);
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
