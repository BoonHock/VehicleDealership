﻿using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_sale_ds
	{
		public static sp_select_vehicle_saleDataTable Select_vehicle_sale(int int_vehicle)
		{
			try
			{
				using (Vehicle_sale_dsTableAdapters.sp_select_vehicle_saleTableAdapter adapter = new Vehicle_sale_dsTableAdapters.sp_select_vehicle_saleTableAdapter())
				{
					return adapter.GetData(int_vehicle);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return new sp_select_vehicle_saleDataTable();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_exclude_vehicle"></param>
		/// <returns></returns>
		public static sp_select_vehicle_sale_simplifiedDataTable Select_vehicle_sale_simplified(int int_exclude_vehicle = 0)
		{
			try
			{
				using (Vehicle_sale_dsTableAdapters.sp_select_vehicle_sale_simplifiedTableAdapter adapter =
					new Vehicle_sale_dsTableAdapters.sp_select_vehicle_sale_simplifiedTableAdapter())
				{
					return adapter.GetData(int_exclude_vehicle);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return new sp_select_vehicle_sale_simplifiedDataTable();
		}
		public static bool Insert_vehicle_sale(int vehicle, string ref_no_prefix, int? customer_person,
			int? customer_org_branch, System.DateTime sale_date, decimal sale_price, decimal road_tax_amount,
			byte? road_tax_month, int? loan, decimal loan_amount, int loan_month, decimal loan_interest_percentage,
			decimal loan_monthly_installment, string loan_ref_no, System.DateTime loan_approval_date,
			string loan_ownership_claim_no, int? guarantor_person, int? insurance,
			string insurance_cover_note_no, string insurance_endorsement_no, string insurance_policy_no,
			System.DateTime insurance_date, bool insurance_type, decimal insurance_basic,
			decimal insurance_sum_insured, int? insurance_comprehensive, decimal insurance_add_comprehensive,
			decimal insurance_adjustment, decimal insurance_loading_age_percent, decimal insurance_loading_percent,
			decimal insurance_ncd_percent, decimal insurance_stamp_duty, decimal insurance_windscreen_sum_insured,
			decimal insurance_windscreen, decimal insurance_total_payable, int salesperson, string remark)
		{
			try
			{
				using (Vehicle_sale_dsTableAdapters.QueriesTableAdapter adapter = new Vehicle_sale_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_insert_vehicle_sale(vehicle, ref_no_prefix, customer_person, customer_org_branch,
						sale_date, sale_price, road_tax_amount, road_tax_month, loan, loan_amount, loan_month,
						loan_interest_percentage, loan_monthly_installment, loan_ref_no, loan_approval_date,
						loan_ownership_claim_no, guarantor_person, insurance, insurance_cover_note_no,
						insurance_endorsement_no, insurance_policy_no, insurance_date, insurance_type,
						insurance_basic, insurance_sum_insured, insurance_comprehensive,
						insurance_add_comprehensive, insurance_adjustment, insurance_loading_age_percent,
						insurance_loading_percent, insurance_ncd_percent, insurance_stamp_duty,
						insurance_windscreen_sum_insured, insurance_windscreen, insurance_total_payable,
						salesperson, remark, Program.System_user.UserID);
					return true;
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return false;
		}
		public static bool Update_vehicle_sale(int vehicle, int? customer_person,
			int? customer_org_branch, System.DateTime sale_date, decimal sale_price, decimal road_tax_amount,
			byte? road_tax_month, int? loan, decimal loan_amount, int loan_month, decimal loan_interest_percentage,
			decimal loan_monthly_installment, string loan_ref_no, System.DateTime loan_approval_date,
			string loan_ownership_claim_no, int? guarantor_person, int? insurance,
			string insurance_cover_note_no, string insurance_endorsement_no, string insurance_policy_no,
			System.DateTime insurance_date, bool insurance_type, decimal insurance_basic,
			decimal insurance_sum_insured, int? insurance_comprehensive, decimal insurance_add_comprehensive,
			decimal insurance_adjustment, decimal insurance_loading_age_percent, decimal insurance_loading_percent,
			decimal insurance_ncd_percent, decimal insurance_stamp_duty, decimal insurance_windscreen_sum_insured,
			decimal insurance_windscreen, decimal insurance_total_payable, int salesperson, string remark)
		{
			try
			{
				using (Vehicle_sale_dsTableAdapters.QueriesTableAdapter adapter = new Vehicle_sale_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_update_vehicle_sale(vehicle, customer_person, customer_org_branch,
						sale_date, sale_price, road_tax_amount, road_tax_month, loan, loan_amount, loan_month,
						loan_interest_percentage, loan_monthly_installment, loan_ref_no, loan_approval_date,
						loan_ownership_claim_no, guarantor_person, insurance, insurance_cover_note_no,
						insurance_endorsement_no, insurance_policy_no, insurance_date,
						insurance_type, insurance_basic, insurance_sum_insured, insurance_comprehensive,
						insurance_add_comprehensive, insurance_adjustment, insurance_loading_age_percent,
						insurance_loading_percent, insurance_ncd_percent, insurance_stamp_duty,
						insurance_windscreen_sum_insured, insurance_windscreen, insurance_total_payable,
						salesperson, remark, Program.System_user.UserID);
					return true;
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return false;
		}
		public static bool Delete_vehicle_sale(int int_vehicle)
		{
			try
			{
				using (Vehicle_sale_dsTableAdapters.QueriesTableAdapter adapter =
					new Vehicle_sale_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.sp_delete_vehicle_sale(int_vehicle, Program.System_user.UserID);
					return true;
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return false;
		}
		public static sp_vehicle_sale_docDataTable Vehicle_sale_doc(int int_vehicle)
		{
			try
			{
				using (Vehicle_sale_dsTableAdapters.sp_vehicle_sale_docTableAdapter adapter =
					new Vehicle_sale_dsTableAdapters.sp_vehicle_sale_docTableAdapter())
				{
					return adapter.GetData(int_vehicle);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod(), e.Message);
			}
			return new sp_vehicle_sale_docDataTable();
		}
	}
}
