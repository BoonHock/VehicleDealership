using System;
using System.Windows.Forms;
using VehicleDealership.Model;

namespace VehicleDealership.Model
{
	partial class Users_DS
	{
		public static UsersDataTable SELECT_user(string str_username, string str_password)
		{
			try
			{
				Users_DSTableAdapters.UsersTableAdapter adapter = new Users_DSTableAdapters.UsersTableAdapter();
				Users_DS.UsersDataTable usersRows = new Users_DS.UsersDataTable();
				return adapter.GetDataBy();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new UsersDataTable();
		}
	}
}
