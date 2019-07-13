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
		public static string ADD_USER { get { return "ADD_USER"; } }
		public static string EDIT_USER { get { return "EDIT_USER"; } }
		public static string EDIT_USERGROUP { get { return "EDIT_USERGROUP"; } }
		public static string ADD_USERGROUP { get { return "ADD_USERGROUP"; } }
		public static string VIEW_USER { get { return "VIEW_USER"; } }
		public static string ADD_VEHICLE_MODEL { get { return "ADD_VEHICLE_MODEL"; } }
		public static string EDIT_VEHICLE_MODEL { get { return "EDIT_VEHICLE_MODEL"; } }
		public static string DELETE_VEHICLE_MODEL { get { return "DELETE_VEHICLE_MODEL"; } }

		//private User_permission(string value) { Value = value; }
		//public string Value { get; private set; }
		//public static User_permission ADMINISTRATOR { get { return new User_permission("ADMINISTRATOR"); } }
		//public static User_permission EDIT_USERS { get { return new User_permission("EDIT_USERS"); } }
		//public static User_permission VIEW_USERS { get { return new User_permission("VIEW_USERS"); } }
	}
}
