using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Person_type_ds
	{
		private static Person_type_dsTableAdapters.sp_select_person_typeTableAdapter Select_Person_TypeTableAdapter()
		{
			return new Person_type_dsTableAdapters.sp_select_person_typeTableAdapter();
		}
		public static sp_select_person_typeDataTable Select_person_type()
		{
			try
			{
				return Select_Person_TypeTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_person_typeDataTable();
		}
	}
}
