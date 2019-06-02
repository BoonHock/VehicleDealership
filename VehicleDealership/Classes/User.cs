using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VehicleDealership.Datasets;

namespace VehicleDealership.Classes
{
	class User
	{
		public int UserID { get; private set; } = 0;
		public string Username { get; private set; } = "";
		public string Name { get; private set; } = "";
		public string IcNo { get; private set; } = "";
		public bool IsActivated { get; private set; } = true;
		public DateTime JoinDate { get; private set; }
		public DateTime? LeaveDate { get; private set; }
		public byte[] Photo { get; private set; }

		public User(string username)
		{
			Users_DS.UsersDataTable users = Users_DS.SELECT_user(username);

			if (users.Rows.Count == 0) throw new Exception("NO USER FOUND");

			Init_obj((int)users[0]["User_id"]);
		}
		public User(int user_id)
		{
			Init_obj(user_id);
		}
		private void Init_obj(int int_user_id)
		{
			Users_DS.UsersDataTable users = Users_DS.SELECT_user(int_user_id);

			if (users.Rows.Count == 0) throw new Exception("NO USER FOUND");

			System.Data.DataRow dt_row = users.Rows[0];

			UserID = int_user_id;
			Username = dt_row["Username"].ToString();
			Name = dt_row["Name"].ToString();
			IcNo = dt_row["IC_no"].ToString();
			IsActivated = (bool)dt_row["Is_activated"];
			JoinDate = (DateTime)dt_row["Join_date"];
			LeaveDate = (dt_row["Leave_date"] == DBNull.Value) ? (DateTime?)null : (DateTime)dt_row["Leave_date"];
			Photo = (dt_row["Photo"] == DBNull.Value) ? null : (byte[])dt_row["Photo"];
		}
		public bool Has_permission (User_permission permission)
		{
			return User_permission_DS.Has_permission(UserID, permission);
		}
		#region static stuffs

		public static bool Is_username_valid(string str_username)
		{
			Regex r = new Regex("^[a-zA-Z0-9]*$");

			return !(str_username.Length == 0 || !r.IsMatch(str_username));
		}
		public static bool Is_username_taken(string str_username, int exclude_user_id = 0)
		{
			return (Users_DS.COUNT_user(str_username, exclude_user_id) > 0);
		}

		#endregion
	}
}
