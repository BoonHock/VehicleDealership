using System.Reflection;

namespace VehicleDealership.Datasets
{
	partial class Person_org_type_ds
	{
		private static Person_org_type_dsTableAdapters.sp_select_person_org_typeTableAdapter Select_Person_Org_TypeTableAdapter()
		{
			return new Person_org_type_dsTableAdapters.sp_select_person_org_typeTableAdapter();
		}
		public static sp_select_person_org_typeDataTable Select_person_org_type()
		{
			try
			{
				return Select_Person_Org_TypeTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_person_org_typeDataTable();
		}
	}
}
