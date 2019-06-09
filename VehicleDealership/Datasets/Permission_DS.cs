using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{


	partial class Permission_ds
	{
		private static Permission_dsTableAdapters.usergroupTableAdapter UsergroupTableAdapter()
		{
			return new Permission_dsTableAdapters.usergroupTableAdapter();
		}
		private static Permission_dsTableAdapters.permissionTableAdapter PermissionTableAdapter()
		{
			return new Permission_dsTableAdapters.permissionTableAdapter();
		}
		private static Permission_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Permission_dsTableAdapters.QueriesTableAdapter();
		}
		public static Permission_ds.usergroupDataTable Select_usergroup()
		{
			try
			{
				return UsergroupTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new usergroupDataTable();
		}
		public static Permission_ds.permissionDataTable Select_permission_by_usergroup(string str_usergroup)
		{
			try
			{
				return PermissionTableAdapter().sp_select_usergroup_permission(str_usergroup);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new permissionDataTable();
		}
		public static bool Usergroup_available(string str_usergroup_to_check, string str_usergroup_to_exclude)
		{
			try
			{
				return (int)QueriesTableAdapter().sp_check_usergroup_available(str_usergroup_to_check, str_usergroup_to_exclude) == 0;
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}
