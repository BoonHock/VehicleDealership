using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{


	partial class User_ds
	{
		private static User_dsTableAdapters.userTableAdapter userTableAdapter()
		{
			return new User_dsTableAdapters.userTableAdapter();
		}
		private static User_dsTableAdapters.sp_search_userTableAdapter Search_UserTableAdapter()
		{
			return new User_dsTableAdapters.sp_search_userTableAdapter();
		}
		private static User_dsTableAdapters.QueriesTableAdapter QueriesAdapter()
		{
			return new User_dsTableAdapters.QueriesTableAdapter();
		}
		private static User_dsTableAdapters.sp_user_loginTableAdapter PasswordTableAdapter()
		{
			return new User_dsTableAdapters.sp_user_loginTableAdapter();
		}

		public static bool Check_username_available(string str_username, int user_id = 0)
		{
			try
			{
				return (int)QueriesAdapter().sp_check_username_available(str_username, user_id) == 0;
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		public static bool Check_user_has_permission(int int_user_id, string str_permission)
		{
			try
			{
				return (int)QueriesAdapter().sp_check_user_permission(int_user_id, str_permission) > 0;
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
		/// 
		/// </summary>
		/// <param name="str_search">if not passed, will select all user</param>
		/// <returns></returns>
		public static userDataTable Select_user(string str_username)
		{
			try
			{
				return userTableAdapter().sp_select_user_by_username(str_username);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new userDataTable();
		}
		public static userDataTable Select_user(int int_user)
		{
			try
			{
				return userTableAdapter().sp_select_user(int_user);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new userDataTable();
		}
		public static sp_search_userDataTable Search_user(string str_search, bool? is_active)
		{
			try
			{
				return Search_UserTableAdapter().GetData(str_search, is_active);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new sp_search_userDataTable();
		}
		public static sp_user_loginDataTable Select_password(string str_username)
		{
			try
			{
				return PasswordTableAdapter().GetData(str_username);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new sp_user_loginDataTable();
		}
		public static void Insert_user(string str_username, string str_name, string str_password, string str_ic_no, System.DateTime date_join)
		{
			try
			{
				QueriesAdapter().sp_insert_user(str_username, str_name, str_password, str_ic_no, date_join, Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static void Update_user(int int_user, string str_username, string str_name, string str_ic_no,
			System.DateTime date_join, System.DateTime? date_leave, byte[] byte_image, string str_usergroup)
		{
			try
			{
				userTableAdapter().sp_update_user(int_user, str_username, str_name, str_ic_no,
					date_join, date_leave, byte_image, str_usergroup, Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static void Update_user_active(int int_user, bool is_active)
		{
			try
			{
				QueriesAdapter().sp_update_user_active(int_user, is_active, Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		public static void Update_user_password(string str_password)
		{
			try
			{
				QueriesAdapter().sp_update_user_password(str_password, Program.System_user.UserID);
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
