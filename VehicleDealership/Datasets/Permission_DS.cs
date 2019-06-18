﻿using System.Reflection;
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
		public static void Insert_usergroup(string str_usergroup, string str_usergroup_desc)
		{
			try
			{
				QueriesTableAdapter().sp_insert_usergroup(str_usergroup, str_usergroup_desc);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static void Update_usergroup(string str_usergroup_new, string str_usergroup_desc, string str_usergroup_old)
		{
			try
			{
				QueriesTableAdapter().sp_update_usergroup(str_usergroup_new, str_usergroup_desc, str_usergroup_old);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static void Update_usergroup_permission(string str_usergroup, string str_permission_combine)
		{
			try
			{
				QueriesTableAdapter().sp_update_usergroup_permission(str_usergroup, str_permission_combine);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static void Delete_usergroup(string str_usergroup)
		{
			try
			{
				QueriesTableAdapter().sp_delete_usergroup(str_usergroup);
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
