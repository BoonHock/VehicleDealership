﻿using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Insurance_driver_ds
	{
		public static sp_select_insurance_driverDataTable Select_insurance_driver(int int_vehicle)
		{
			try
			{
				using (Insurance_driver_dsTableAdapters.sp_select_insurance_driverTableAdapter adapter =
					new Insurance_driver_dsTableAdapters.sp_select_insurance_driverTableAdapter())
				{
					return adapter.GetData(int_vehicle);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_insurance_driverDataTable();
		}
	}
}
