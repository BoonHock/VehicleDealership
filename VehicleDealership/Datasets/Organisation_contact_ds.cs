using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Organisation_contact_ds
	{
		private static Organisation_contact_dsTableAdapters.sp_select_organisation_contactTableAdapter Select_Organisation_ContactTableAdapter()
		{
			return new Organisation_contact_dsTableAdapters.sp_select_organisation_contactTableAdapter();
		}
		private static Organisation_contact_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Organisation_contact_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_organisation_contactDataTable Select_organisation_contact(int int_org)
		{
			try
			{
				return Select_Organisation_ContactTableAdapter().GetData(int_org);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_organisation_contactDataTable();
		}
		public static bool Update_insert_organisation_contact(int int_org)
		{
			try
			{
				QueriesTableAdapter().sp_update_insert_organisation_contact(int_org, Program.System_user.UserID);
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
