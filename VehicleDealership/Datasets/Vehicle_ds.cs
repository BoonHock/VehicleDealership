using System.Reflection;
using System.Linq;
using System.Data;

namespace VehicleDealership.Datasets
{


	partial class Vehicle_ds
	{
		partial class sp_vehicle_incoming_docDataTable
		{
		}

		private static Vehicle_dsTableAdapters.sp_select_vehicle_simplifiedTableAdapter Select_Vehicle_SimplifiedTableAdapter()
		{
			return new Vehicle_dsTableAdapters.sp_select_vehicle_simplifiedTableAdapter();
		}
		private static Vehicle_dsTableAdapters.sp_select_vehicleTableAdapter Select_VehicleTableAdapter()
		{
			return new Vehicle_dsTableAdapters.sp_select_vehicleTableAdapter();
		}
		private static Vehicle_dsTableAdapters.QueriesTableAdapter QueriesTableAdapter()
		{
			return new Vehicle_dsTableAdapters.QueriesTableAdapter();
		}
		public static sp_select_vehicle_simplifiedDataTable Select_vehicle_simplified()
		{
			try
			{
				using (Vehicle_dsTableAdapters.sp_select_vehicle_simplifiedTableAdapter adapter = Select_Vehicle_SimplifiedTableAdapter())
				{
					return adapter.GetData();
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicle_simplifiedDataTable();
		}
		//public static sp_select_vehicle_simplifiedDataTable Select_vehicle_simplified_unsold()
		//{
		//	try
		//	{
		//		using (Vehicle_dsTableAdapters.sp_select_vehicle_simplifiedTableAdapter adapter = Select_Vehicle_SimplifiedTableAdapter())
		//		{
		//			sp_select_vehicle_simplifiedDataTable dttable =(sp_select_vehicle_simplifiedDataTable) adapter.GetData().Where(x => x.vehicle_status == "UNSOLD").CopyToDataTable();
		//			return adapter.GetData();
		//		}
		//	}
		//	catch (System.Exception e)
		//	{
		//		Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
		//			MethodBase.GetCurrentMethod().Name, e.Message);
		//	}
		//	return new sp_select_vehicle_simplifiedDataTable();
		//}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="int_vehicle">-1 to select all</param>
		/// <returns></returns>
		public static sp_select_vehicleDataTable Select_vehicle(int int_vehicle)
		{
			try
			{
				using (Vehicle_dsTableAdapters.sp_select_vehicleTableAdapter adapter = Select_VehicleTableAdapter())
				{
					return adapter.GetData(int_vehicle, "", "");
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicleDataTable();
		}
		public static sp_select_vehicleDataTable Select_vehicle_latest_record(string str_reg_no, string str_chassis_no)
		{
			try
			{
				using (Vehicle_dsTableAdapters.sp_select_vehicleTableAdapter adapter = Select_VehicleTableAdapter())
				{
					sp_select_vehicleDataTable dttable = adapter.GetData(-1, str_reg_no, str_chassis_no);

					if (dttable.Rows.Count > 0)
					{
						// select first row. vehicle id is in descending order so will be latest record
						sp_select_vehicleRow query = (from row in dttable
													  orderby row.vehicle descending
													  select row).First();

						sp_select_vehicleDataTable new_dttable = new sp_select_vehicleDataTable();
						new_dttable.ImportRow(query); // insert selected row from linq
						return new_dttable; // return datatable
					}
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_vehicleDataTable();
		}
		public static int Insert_vehicle(int int_seller, bool seller_is_person, string str_reg_no, int int_chassis,
			int int_colour, bool is_new, int? int_location, string str_engine_no, double doub_engine_cc, int int_mileage,
			int? int_vehicle_sale, bool? consignment_mortgage, string str_door_key, string str_ignition_key,
			System.DateTime purchase_date, System.DateTime date_received, System.DateTime settlement_date,
			string str_invoice_no, decimal dec_road_tax, System.DateTime road_tax_expiry, decimal dec_purchase_price,
			decimal dec_overtrade, decimal dec_list_price, decimal dec_max_can_loan, decimal dec_loan_balance,
			decimal dec_loan_installment_amount, int? int_loan_finance, int installment_day_of_month,
			System.DateTime loan_settlement_date, string str_loan_agreement_no, string str_remark, int int_checked_by)
		{
			try
			{
				using (Vehicle_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					return int.Parse(adapter.sp_insert_vehicle(int_seller, seller_is_person, str_reg_no,
						int_chassis, int_colour, is_new, int_location, str_engine_no, doub_engine_cc, int_mileage,
						int_vehicle_sale, consignment_mortgage, str_door_key, str_ignition_key, purchase_date,
						date_received, settlement_date, str_invoice_no, dec_road_tax, road_tax_expiry, dec_purchase_price,
						dec_overtrade, dec_list_price, dec_max_can_loan, dec_loan_balance, dec_loan_installment_amount,
						int_loan_finance, (byte)installment_day_of_month, loan_settlement_date, str_loan_agreement_no,
						str_remark, int_checked_by, Program.System_user.UserID).ToString());
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return 0;
		}
		public static bool Update_vehicle(int int_vehicle, int int_seller, bool seller_is_person, string str_reg_no,
			int int_chassis, int int_colour, bool is_new, int? int_location, string str_engine_no, double doub_engine_cc,
			int int_mileage, int? int_vehicle_sale, bool? consignment_mortgage, string str_door_key,
			string str_ignition_key, System.DateTime purchase_date, System.DateTime date_received,
			System.DateTime settlement_date, string str_invoice_no, decimal dec_road_tax, System.DateTime road_tax_expiry,
			decimal dec_purchase_price, decimal dec_overtrade, decimal dec_list_price, decimal dec_max_can_loan,
			decimal dec_loan_balance, decimal dec_loan_installment_amount, int? int_loan_finance, int installment_day_of_month,
			System.DateTime loan_settlement_date, string str_loan_agreement_no, string str_remark, int int_checked_by)
		{
			try
			{
				using (Vehicle_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					adapter.sp_update_vehicle(int_vehicle, int_seller, seller_is_person, str_reg_no,
						int_chassis, int_colour, is_new, int_location, str_engine_no, doub_engine_cc, int_mileage,
						int_vehicle_sale, consignment_mortgage, str_door_key, str_ignition_key, purchase_date,
						date_received, settlement_date, str_invoice_no, dec_road_tax, road_tax_expiry, dec_purchase_price,
						dec_overtrade, dec_list_price, dec_max_can_loan, dec_loan_balance, dec_loan_installment_amount,
						int_loan_finance, (byte)installment_day_of_month, loan_settlement_date, str_loan_agreement_no,
						str_remark, int_checked_by, Program.System_user.UserID);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
		public static bool Delete_vehicle(int int_vehicle)
		{
			try
			{
				using (Vehicle_dsTableAdapters.QueriesTableAdapter adapter = QueriesTableAdapter())
				{
					adapter.sp_delete_vehicle(int_vehicle);
					return true;
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return false;
		}
		public static sp_vehicle_incoming_docDataTable Vehicle_incoming_doc(int int_vehicle)
		{
			try
			{
				using (Vehicle_dsTableAdapters.sp_vehicle_incoming_docTableAdapter adapter =
					new Vehicle_dsTableAdapters.sp_vehicle_incoming_docTableAdapter())
				{
					return adapter.GetData(int_vehicle);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_vehicle_incoming_docDataTable();
		}
	}
}
