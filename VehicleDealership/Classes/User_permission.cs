using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDealership.Classes
{
	public class User_permission
	{
		public static string ADMINISTRATOR { get { return "ADMINISTRATOR"; } }
		public static string EDIT_USER { get { return "EDIT_USER"; } }
		public static string VIEW_USER { get { return "VIEW_USER"; } }

		//private User_permission(string value) { Value = value; }
		//public string Value { get; private set; }
		//public static User_permission ADMINISTRATOR { get { return new User_permission("ADMINISTRATOR"); } }
		//public static User_permission EDIT_USERS { get { return new User_permission("EDIT_USERS"); } }
		//public static User_permission VIEW_USERS { get { return new User_permission("VIEW_USERS"); } }
	}
}
