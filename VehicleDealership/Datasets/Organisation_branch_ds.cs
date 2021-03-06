﻿using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Organisation_branch_ds
	{
		//private static Organisation_branch_dsTableAdapters.sp_select_organisation_branch_by_orgTableAdapter Select_Organisation_BranchTableAdapter()
		//{
		//	return new Organisation_branch_dsTableAdapters.sp_select_organisation_branch_by_orgTableAdapter();
		//}
		//private static Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter Organisation_Branch_SimplifiedTableAdapter()
		//{
		//	return new Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter();
		//}
		//private static Organisation_branch_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		//{
		//	return new Organisation_branch_dsTableAdapters.QueriesTableAdapter();
		//}
		//private static Organisation_branch_dsTableAdapters.sp_select_organisation_branch_with_org_detailsTableAdapter Select_Organisation_Branch_With_Org_DetailsTableAdapter()
		//{
		//	return new Organisation_branch_dsTableAdapters.sp_select_organisation_branch_with_org_detailsTableAdapter();
		//}
		public static sp_select_organisation_branch_by_orgDataTable Select_organisation_branch_by_org(int int_org)
		{
			try
			{
				using (Organisation_branch_dsTableAdapters.sp_select_organisation_branch_by_orgTableAdapter adapter = new Organisation_branch_dsTableAdapters.sp_select_organisation_branch_by_orgTableAdapter())
				{
					return adapter.GetData(int_org);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_organisation_branch_by_orgDataTable();
		}
		public static void Update_insert_organisation_branch(int int_org)
		{
			try
			{
				using (Organisation_branch_dsTableAdapters.QueriesTableAdapter adapter =
					new Organisation_branch_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_insert_organisation_branch(int_org, Program.System_user.UserID);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
		}
		public static Organisation_branch_simplifiedDataTable Select_organisation_not_salesperson()
		{
			try
			{
				using (Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter adapter = new Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter())
				{
					return adapter.sp_select_organisation_not_salesperson();
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new Organisation_branch_simplifiedDataTable();
		}
		public static Organisation_branch_simplifiedDataTable Select_organisation_not_finance()
		{
			try
			{
				using (Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter adapter = new Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter())
				{
					return adapter.sp_select_organisation_not_finance();
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new Organisation_branch_simplifiedDataTable();
		}
		public static sp_select_organisation_branch_with_org_detailsDataTable Select_organisation_branch_with_org_details(int int_org_branch)
		{
			try
			{
				using (Organisation_branch_dsTableAdapters.sp_select_organisation_branch_with_org_detailsTableAdapter adapter = new Organisation_branch_dsTableAdapters.sp_select_organisation_branch_with_org_detailsTableAdapter())
				{
					return adapter.GetData(int_org_branch);
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_organisation_branch_with_org_detailsDataTable();
		}
		public static Organisation_branch_simplifiedDataTable Select_organisation_simplified()
		{
			try
			{
				using (Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter adapter = new Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter())
				{
					return adapter.sp_select_organisation_simplified();
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new Organisation_branch_simplifiedDataTable();
		}
		public static Organisation_branch_simplifiedDataTable Select_organisation_not_insurance()
		{
			try
			{
				using (Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter adapter =
					new Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter())
				{
					return adapter.sp_select_organisation_not_insurance();
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new Organisation_branch_simplifiedDataTable();
		}
		public static Organisation_branch_simplifiedDataTable Select_organisation_not_loan()
		{
			try
			{
				using (Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter adapter =
					new Organisation_branch_dsTableAdapters.Organisation_branch_simplifiedTableAdapter())
				{
					return adapter.sp_select_organisation_not_loan();
				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new Organisation_branch_simplifiedDataTable();
		}
	}
}
