using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{
	partial class User_permission_DS
	{

		private static User_permission_DSTableAdapters.User_permissionTableAdapter UserPermissionAdapter()
		{
			return new User_permission_DSTableAdapters.User_permissionTableAdapter();
		}
		private static User_permission_DSTableAdapters.QueriesTableAdapter QueriesAdapter()
		{
			return new User_permission_DSTableAdapters.QueriesTableAdapter();
		}
		public static User_permissionDataTable SELECT_user_permission(int int_user_id)
		{
			try
			{
				return UserPermissionAdapter().sp_SELECT_user_permission(int_user_id);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new User_permissionDataTable();
		}
		public static bool Has_permission(int int_user_id, string permission)
		{
			try
			{
				return ((int)QueriesAdapter().sp_COUNT_permisison(int_user_id, permission) > 0);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		public static void INSERT_user_permission(int int_user_id, string str_permission)
		{
			try
			{
				QueriesAdapter().sp_INSERT_user_permission(int_user_id, str_permission, Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static void DELETE_user_permission(int int_user_id, string str_permission)
		{
			try
			{
				QueriesAdapter().sp_DELETE_user_permission(int_user_id, str_permission);
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
