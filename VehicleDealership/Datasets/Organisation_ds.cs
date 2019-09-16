using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Organisation_ds
	{
		private static Organisation_dsTableAdapters.sp_select_organisationTableAdapter Select_OrganisationTableAdapter()
		{
			return new Organisation_dsTableAdapters.sp_select_organisationTableAdapter();
		}
		private static Organisation_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Organisation_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_organisationDataTable Select_organisation(int int_org)
		{
			try
			{
				return Select_OrganisationTableAdapter().GetData(int_org);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_organisationDataTable();
		}
		/// <summary>
		/// insert new organisation
		/// </summary>
		/// <param name="str_name"></param>
		/// <param name="str_registration_no"></param>
		/// <param name="int_org_type"></param>
		/// <param name="str_branch"></param>
		/// <param name="str_address"></param>
		/// <param name="str_city"></param>
		/// <param name="str_state"></param>
		/// <param name="str_postcode"></param>
		/// <param name="short_country"></param>
		/// <param name="str_url"></param>
		/// <returns>last inserted id</returns>
		public static int Insert_organisation(string str_name, string str_registration_no,
			int int_org_type, short short_country, string str_url)
		{
			try
			{
				return int.Parse(QueriesTableAdapter().sp_insert_organisation(str_name,
					str_registration_no, int_org_type, short_country, str_url, Program.System_user.UserID).ToString());
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Update_organisation(int int_org, string str_name,
			string str_registration_no, int int_org_type, short short_country, string str_url)
		{
			try
			{
				QueriesTableAdapter().sp_update_organisation(int_org, str_name,
					str_registration_no, int_org_type, short_country, str_url, Program.System_user.UserID);
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
