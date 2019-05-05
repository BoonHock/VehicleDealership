using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleDealership.Datasets;

namespace VehicleDealership.Classes
{
	class System_user
	{
		public int UserID { get; private set; } = 0;
		public string Username { get; } = "";
		public string Name { get; } = "";
		public string IcNo { get; } = "";
		public System_user(string username)
		{
			Users_DS.UsersDataTable users = Users_DS.SELECT_user_by_username(username);

			if (users.Rows.Count == 0) return; // no record found

			Username = username;
			Name = users[0]["Name"].ToString();
			IcNo = users[0]["Ic_no"].ToString();
		}
	}
}
