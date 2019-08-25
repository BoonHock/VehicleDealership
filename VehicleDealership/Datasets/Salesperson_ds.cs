using System.Reflection;

namespace VehicleDealership.Datasets
{
	partial class Salesperson_ds
	{
		private static Salesperson_dsTableAdapters.sp_select_salespersonTableAdapter Select_SalespersonTableAdapter()
		{
			return new Salesperson_dsTableAdapters.sp_select_salespersonTableAdapter();
		}
		public static sp_select_salespersonDataTable Select_salesperson()
		{
			try
			{
				return Select_SalespersonTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_salespersonDataTable();
		}
	}
}
