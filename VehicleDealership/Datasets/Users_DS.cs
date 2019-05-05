using System;
using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{
	partial class Users_DS
	{
		public static UsersDataTable SELECT_users()
		{
			try
			{
				return (new Users_DSTableAdapters.UsersTableAdapter()).GetData();
			}
			catch (Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new UsersDataTable();
		}
		public static UsersDataTable SELECT_user_by_username(string str_username)
		{
			try
			{
				return (new Users_DSTableAdapters.UsersTableAdapter()).sp_SELECT_user_by_username(str_username);
			}
			catch (Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new UsersDataTable();
		}
		public static int COUNT_user()
		{
			try
			{
				return (int)(new Users_DSTableAdapters.UsersTableAdapter()).sp_COUNT_users();
			}
			catch (Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			return 0;
		}
		public static void INSERT_user(string username, string name, string password, string ic_no, DateTime join_date)
		{
			try
			{
				(new Users_DSTableAdapters.UsersTableAdapter()).sp_INSERT_user(username,name,password,ic_no,join_date, Program.System_user.UserID);
			}
			catch (Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
