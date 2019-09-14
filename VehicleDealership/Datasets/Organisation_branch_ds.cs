using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Organisation_branch_ds
	{
		private static Organisation_branch_dsTableAdapters.sp_select_organisation_branchTableAdapter Select_Organisation_BranchTableAdapter()
		{
			return new Organisation_branch_dsTableAdapters.sp_select_organisation_branchTableAdapter();
		}
		private static Organisation_branch_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Organisation_branch_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_organisation_branchDataTable Select_organisation_branch(int int_org)
		{
			try
			{
				return Select_Organisation_BranchTableAdapter().GetData(int_org);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_organisation_branchDataTable();
		}
		public static void Update_insert_organisation_branch(int int_org)
		{
			try
			{
				QueriesTableAdapter().sp_update_insert_organisation_branch(int_org, Program.System_user.UserID);
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
		}
	}
}
