using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Person_ds
	{
		private static Person_dsTableAdapters.sp_select_personTableAdapter Select_PersonTableAdapter()
		{
			return new Person_dsTableAdapters.sp_select_personTableAdapter();
		}
		private static Person_dsTableAdapters.sp_select_person1TableAdapter Select_Person1TableAdapter()
		{
			return new Person_dsTableAdapters.sp_select_person1TableAdapter();
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
		public static bool Insert_person(string str_name, string str_ic_no, byte[] byte_img, int int_person_org_type, string str_driving_license, bool bool_gender,
			int int_race, string str_address, string str_city, string str_state, string str_postcode, int int_country, string str_occupation, string str_company)
		{
			try
			{
				QueriesTableAdapter().sp_insert_person(str_name, str_ic_no, byte_img, int_person_org_type, str_driving_license, bool_gender, int_race,
					str_address, str_city, str_state, str_postcode, (short)int_country, str_occupation, str_company, Program.System_user.UserID);
				return true;
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
		public static sp_select_person1DataTable Select_person1()
		{
			try
			{
				return Select_Person1TableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_person1DataTable();
		}
	}
}
