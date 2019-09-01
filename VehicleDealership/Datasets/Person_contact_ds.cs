using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Person_contact_ds
	{
		private static Person_contact_dsTableAdapters.sp_select_person_contactTableAdapter Select_Person_ContactTableAdapter()
		{
			return new Person_contact_dsTableAdapters.sp_select_person_contactTableAdapter();
		}
		private static Person_contact_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Person_contact_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_person_contactDataTable Select_person_contact(int int_person)
		{
			try
			{
				return Select_Person_ContactTableAdapter().GetData(int_person);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_person_contactDataTable();
		}
		public static bool Update_insert_person_contact(int int_person)
		{
			try
			{
				QueriesTableAdapter().sp_update_insert_person_contact(int_person, Program.System_user.UserID);
				return true;
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
	}
}
