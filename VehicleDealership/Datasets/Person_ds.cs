using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Person_ds
	{
		private static Person_dsTableAdapters.sp_select_personTableAdapter Select_PersonTableAdapter()
		{
			return new Person_dsTableAdapters.sp_select_personTableAdapter();
		}
		private static Person_dsTableAdapters.Person_simplifiedTableAdapter Select_Person1TableAdapter()
		{
			return new Person_dsTableAdapters.Person_simplifiedTableAdapter();
		}
		private static Person_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Person_dsTableAdapters.QueriesTableAdapter();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_person">person id</param>
		/// <returns></returns>
		public static sp_select_personDataTable Select_person(int int_person)
		{
			try
			{
				return Select_PersonTableAdapter().GetData(int_person);
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
			string str_postcode, int int_country, string str_occupation, string str_company)
		{
			try
			{
				return (int)QueriesTableAdapter().sp_insert_person(str_name, str_ic_no, byte_img, int_person_type,
					str_driving_license, bool_gender, int_race, str_address, str_city, str_state,
					str_postcode, (short)int_country, str_occupation, str_company, Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static Person_simplifiedDataTable Select_person1()
		{
			try
			{
				return Select_Person1TableAdapter().sp_select_person1();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new Person_simplifiedDataTable();
		}
		public static Person_simplifiedDataTable Select_person_not_salesperson()
		{
			try
			{
				return Select_Person1TableAdapter().sp_select_person_not_salesperson();
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
