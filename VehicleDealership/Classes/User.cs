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
		public bool IsDeveloper { get; set; } = false;
		public int UserID { get; private set; } = 0;
		public string Username { get; private set; } = "";
		public string Name { get; private set; } = "";
		public string IcNo { get; private set; } = "";
		public bool IsActive { get; private set; } = true;
		public DateTime JoinDate { get; private set; }
		public DateTime? LeaveDate { get; private set; }
		public byte[] UserImage { get; private set; }
		public string UserGroup { get; private set; }
		public string Password
		{
			get
			{
				User_ds.sp_user_loginDataTable dttable_user = User_ds.Select_password(Username);

				if (dttable_user.Rows.Count > 0) return User_ds.Select_password(Username).Rows[0]["password"].ToString();

				return "";
			}
		}
		public User(string str_username)
		{
			Init_obj(User_ds.Select_user(str_username));
		}
		public User(int user_id)
		{
			Init_obj(User_ds.Select_user(user_id));
		}
		private void Init_obj(User_ds.userDataTable dttable_user)
		{
			if (dttable_user.Rows.Count == 0) throw new Exception("NO USER FOUND");

			System.Data.DataRow dt_row = dttable_user.Rows[0];

			UserID = (int)dt_row["user"];
			Username = dt_row["username"].ToString();
			Name = dt_row["name"].ToString();
			IcNo = dt_row["ic_no"].ToString();
			IsActive = (bool)dt_row["is_active"];
			JoinDate = (DateTime)dt_row["join_date"];
			LeaveDate = (dt_row["leave_date"] == DBNull.Value) ? (DateTime?)null : (DateTime)dt_row["leave_date"];
			UserImage = (dt_row["image"] == DBNull.Value) ? null : (byte[])dt_row["image"];
			UserGroup = (dt_row["usergroup"] == DBNull.Value) ? null : dt_row["usergroup"].ToString();
		}
		public bool Has_permission(string permission)
		{
			return User_ds.Check_user_has_permission(UserID, permission);
		}
		#region static stuffs
		public static bool Is_username_valid(string str_username)
		{
			Regex r = new Regex("^[a-zA-Z0-9]*$");

			return !(str_username.Length == 0 || !r.IsMatch(str_username));
		}
		public static bool Is_username_available(string str_username, int exclude_user_id = 0)
		{
			return User_ds.Check_username_available(str_username, exclude_user_id);
		}
		#endregion
	}
}
