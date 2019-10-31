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
		public static string ADD_EDIT_VEHICLE_BRAND_GROUP_MODEL { get { return "ADD_EDIT_VEHICLE_BRAND_GROUP_MODEL"; } }
		public static string DELETE_VEHICLE_BRAND_GROUP_MODEL { get { return "DELETE_VEHICLE_BRAND_GROUP_MODEL"; } }
		public static string ADD_EDIT_FUEL_TYPE { get { return "ADD_EDIT_FUEL_TYPE"; } }
		public static string DELETE_FUEL_TYPE { get { return "DELETE_FUEL_TYPE"; } }
		public static string ADD_EDIT_TRANSMISSION { get { return "ADD_EDIT_TRANSMISSION"; } }
		public static string DELETE_TRANSMISSION { get { return "DELETE_TRANSMISSION"; } }
		public static string ADD_EDIT_COLOUR { get { return "ADD_EDIT_COLOUR"; } }
		public static string DELETE_COLOUR { get { return "DELETE_COLOUR"; } }
		public static string ADD_EDIT_SALESPERSON { get { return "ADD_EDIT_SALESPERSON"; } }
		public static string VIEW_SALESPERSON { get { return "VIEW_SALESPERSON"; } }
		public static string VIEW_PERSON { get { return "VIEW_PERSON"; } }
		public static string ADD_EDIT_PERSON { get { return "ADD_EDIT_PERSON"; } }
		public static string VIEW_ORGANISATION { get { return "VIEW_ORGANISATION"; } }
		public static string ADD_EDIT_ORGANISATION { get { return "ADD_EDIT_ORGANISATION"; } }
		public static string ADD_EDIT_FINANCE { get { return "ADD_EDIT_FINANCE"; } }
		public static string VIEW_FINANCE { get { return "VIEW_FINANCE"; } }
		public static string VEHICLE_ADD_EDIT { get { return "VEHICLE_ADD_EDIT"; } }
		public static string VEHICLE_DELETE { get { return "VEHICLE_DELETE"; } }
		public static string VEHICLE_SALE_ADD_EDIT { get { return "VEHICLE_SALE_ADD_EDIT"; } }
		public static string VEHICLE_SALE_DELETE { get { return "VEHICLE_SALE_DELETE"; } }
		public static string VEHICLE_VIEW { get { return "VEHICLE_VIEW"; } }
		public static string LOCATION_ADD_EDIT { get { return "LOCATION_ADD_EDIT"; } }
		public static string LOCATION_DELETE { get { return "LOCATION_DELETE"; } }
		public static string VEHICLE_RETURN_ADD_EDIT { get { return "VEHICLE_RETURN_ADD_EDIT"; } }
		public static string VEHICLE_RETURN_DELETE { get { return "VEHICLE_RETURN_DELETE"; } }
		public static string INSURANCE_ADD_EDIT { get { return "INSURANCE_ADD_EDIT"; } }
		public static string INSURANCE_DELETE { get { return "INSURANCE_DELETE"; } }


		//private User_permission(string value) { Value = value; }
		//public string Value { get; private set; }
		//public static User_permission ADMINISTRATOR { get { return new User_permission("ADMINISTRATOR"); } }
		//public static User_permission EDIT_USERS { get { return new User_permission("EDIT_USERS"); } }
		//public static User_permission VIEW_USERS { get { return new User_permission("VIEW_USERS"); } }
	}
}
