using System.Reflection;

namespace VehicleDealership.Datasets
{
	partial class Person_contact_info_DS
	{
		private static Person_contact_info_DSTableAdapters.sp_select_person_contact_infoTableAdapter Person_Contact_InfoTableAdapter()
		{
			return new Person_contact_info_DSTableAdapters.sp_select_person_contact_infoTableAdapter();
		}
		public static sp_select_person_contact_infoDataTable Select_Person_Contact_Info(int int_person)
		{
			try
			{
				return Person_Contact_InfoTableAdapter().GetData(int_person);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_person_contact_infoDataTable();
		}
	}
}
