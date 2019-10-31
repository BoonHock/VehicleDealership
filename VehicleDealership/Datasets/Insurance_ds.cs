using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Insurance_ds
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_insurance">-1 to select all</param>
		/// <returns></returns>
		public static sp_select_insuranceDataTable Select_insurance(int int_insurance)
		{
			try
			{
				using (Insurance_dsTableAdapters.sp_select_insuranceTableAdapter adapter =
					new Insurance_dsTableAdapters.sp_select_insuranceTableAdapter())
				{
					return adapter.GetData(int_insurance);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_insuranceDataTable();
		}
		public static bool Update_insert_insurance(int int_orgbranch, string str_remark)
		{
			try
			{
				using (Insurance_dsTableAdapters.QueriesTableAdapter adapter =
					new Insurance_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_insert_insurance(int_orgbranch,str_remark,Program.System_user.UserID);
				}
				return true;
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
