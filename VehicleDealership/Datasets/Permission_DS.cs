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
		/// <summary>
		/// select all user group
		/// </summary>
		/// <returns></returns>
		public static usergroupDataTable Select_usergroup()
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
		/// <summary>
		/// select usergroup's permissions
		/// </summary>
		/// <param name="str_usergroup">usergroup name</param>
		/// <returns></returns>
		public static permissionDataTable Select_permission_by_usergroup(string str_usergroup)
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
		/// <summary>
		/// select all permissions
		/// </summary>
		/// <returns></returns>
		public static permissionDataTable Select_all_permission()
		{
			try
			{
				return PermissionTableAdapter().select_all_permission();
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return new permissionDataTable();
		}
		/// <summary>
		/// check usergroup is available
		/// </summary>
		/// <param name="str_usergroup_to_check">usergroup to check if exists in database</param>
		/// <param name="str_usergroup_to_exclude">usergroup to exclude in the check. 
		/// useful if updating usergroup and user did not change usergroup name.</param>
		/// <returns></returns>
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
		/// <summary>
		/// insert new usergroup
		/// </summary>
		/// <param name="str_usergroup">usergroup name. primary key</param>
		/// <param name="str_usergroup_desc">usergroup description</param>
		public static void Insert_usergroup(string str_usergroup, string str_usergroup_desc)
		{
			try
			{
				if (User_ds.Check_user_has_permission(Program.System_user.UserID, Classes.User_permission.ADD_USERGROUP))
				{
					QueriesTableAdapter().sp_insert_usergroup(str_usergroup, str_usergroup_desc);
				}
				else
				{
					MessageBox.Show("PERMISSION DENIED", "PERMISSION DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		/// <summary>
		/// update usergroup
		/// </summary>
		/// <param name="str_usergroup_new">new usergroup name</param>
		/// <param name="str_usergroup_desc">new usergroup description</param>
		/// <param name="str_usergroup_old">old usergroup name</param>
		public static void Update_usergroup(string str_usergroup_new, string str_usergroup_desc, string str_usergroup_old)
		{
			try
			{
				if (User_ds.Check_user_has_permission(Program.System_user.UserID, Classes.User_permission.EDIT_USERGROUP))
				{
					QueriesTableAdapter().sp_update_usergroup(str_usergroup_new, str_usergroup_desc, str_usergroup_old);
				}
				else
				{
					MessageBox.Show("PERMISSION DENIED", "PERMISSION DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		/// <summary>
		/// update permissions of a usergroup
		/// </summary>
		/// <param name="str_usergroup">usergroup to update permission for.</param>
		/// <param name="str_permission_combine">comma separated strings</param>
		public static void Update_usergroup_permission(string str_usergroup, string str_permission_combine)
		{
			try
			{
				if (User_ds.Check_user_has_permission(Program.System_user.UserID, Classes.User_permission.EDIT_USERGROUP))
				{
					QueriesTableAdapter().sp_update_usergroup_permission(str_usergroup, 
						str_permission_combine, Program.System_user.UserID);
				}
				else
				{
					MessageBox.Show("PERMISSION DENIED", "PERMISSION DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		/// <summary>
		///  delete usergroup
		/// </summary>
		/// <param name="str_usergroup"></param>
		public static void Delete_usergroup(string str_usergroup)
		{
			try
			{
				if (User_ds.Check_user_has_permission(Program.System_user.UserID, Classes.User_permission.EDIT_USERGROUP))
				{
					QueriesTableAdapter().sp_delete_usergroup(Program.System_user.UserID, str_usergroup);
				}
				else
				{
					MessageBox.Show("PERMISSION DENIED", "PERMISSION DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		/// <summary>
		/// assign all permissions to the usergroup
		/// </summary>
		public static void Assign_all_permission_to_administrator()
		{
			try
			{
				QueriesTableAdapter().usp_assign_all_permission_to_administrator();
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
