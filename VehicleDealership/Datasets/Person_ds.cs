using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Person_ds
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_person">person id</param>
		/// <returns></returns>
		public static sp_select_personDataTable Select_person(int int_person)
		{
			try
			{
				using (Person_dsTableAdapters.sp_select_personTableAdapter adapter = new Person_dsTableAdapters.sp_select_personTableAdapter())
				{
					return adapter.GetData(int_person);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_personDataTable();
		}
		public static int Insert_person(string str_name, string str_ic_no, byte[] byte_img,
			int int_person_type, string str_driving_license, bool bool_gender,
			int int_race, string str_address, string str_city, string str_state,
			string str_postcode, short short_country, string str_occupation, string str_company, string str_url)
		{
			try
			{
				using (Person_dsTableAdapters.QueriesTableAdapter adapter = new Person_dsTableAdapters.QueriesTableAdapter())
				{
					return int.Parse(adapter.sp_insert_person(str_name, str_ic_no, byte_img, int_person_type,
						str_driving_license, bool_gender, int_race, str_address, str_city, str_state, str_postcode,
						short_country, str_occupation, str_company, str_url, Program.System_user.UserID).ToString());
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Update_person(int int_person, string str_name, string str_ic_no,
			byte[] byte_img, int int_person_type, string str_driving_license, bool bool_gender,
			int int_race, string str_address, string str_city, string str_state,
			string str_postcode, short short_country, string str_occupation, string str_company, string str_url)
		{
			try
			{
				using (Person_dsTableAdapters.QueriesTableAdapter adapter = new Person_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_person(int_person, str_name, str_ic_no, byte_img, int_person_type,
						str_driving_license, bool_gender, int_race, str_address, str_city, str_state, str_postcode,
						short_country, str_occupation, str_company, str_url, Program.System_user.UserID);
				}
				return true;
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
		public static Person_simplifiedDataTable Select_person_not_salesperson()
		{
			try
			{
				using (Person_dsTableAdapters.Person_simplifiedTableAdapter adapter = new Person_dsTableAdapters.Person_simplifiedTableAdapter())
				{
					return adapter.sp_select_person_not_salesperson();
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new Person_simplifiedDataTable();
		}
		public static Person_simplifiedDataTable Select_person_simplified()
		{
			try
			{
				using (Person_dsTableAdapters.Person_simplifiedTableAdapter adapter = new Person_dsTableAdapters.Person_simplifiedTableAdapter())
				{
					return adapter.sp_select_person_simplified();
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new Person_simplifiedDataTable();
		}
	}
}
