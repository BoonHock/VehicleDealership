using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{
	partial class user_ds
	{
		private static user_dsTableAdapters.userTableAdapter UserAdapter()
		{
			return new user_dsTableAdapters.userTableAdapter();
		}
		private static user_dsTableAdapters.QueriesTableAdapter QueriesAdapter()
		{
			return new user_dsTableAdapters.QueriesTableAdapter();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="str_search">if not passed, will select all user</param>
		/// <returns></returns>
		public static userDataTable Select_user(string str_search = "ALL")
		{
			try
			{
				return UserAdapter().GetData(str_search);
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new userDataTable();
		}

		public static bool Check_db_has_user()
		{
			try
			{
				return (int)QueriesAdapter().check_db_has_user() > 0;
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		public static bool Check_username_available(string str_username)
		{
			try
			{
				return (int)QueriesAdapter().sp_check_username_available(str_username, Program.System_user.UserID) == 0;
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
