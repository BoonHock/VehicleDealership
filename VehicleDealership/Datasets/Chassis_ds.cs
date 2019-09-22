using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Chassis_ds
	{
		private static Chassis_dsTableAdapters.sp_select_chassisTableAdapter Select_ChassisTableAdapter()
		{
			return new Chassis_dsTableAdapters.sp_select_chassisTableAdapter();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str_chassis_no">pass empty string to select all chassis</param>
		/// <returns></returns>
		public static sp_select_chassisDataTable Select_chassis(string str_chassis_no)
		{
			try
			{
				return Select_ChassisTableAdapter().GetData(str_chassis_no);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_chassisDataTable();
		}
	}
}
