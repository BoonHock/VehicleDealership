using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Race_ds
	{
		private static Race_dsTableAdapters.sp_select_raceTableAdapter Select_RaceTableAdapter()
		{
			return new Race_dsTableAdapters.sp_select_raceTableAdapter();
		}
		public static sp_select_raceDataTable Select_race()
		{
			try
			{
				return Select_RaceTableAdapter().GetData();
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_raceDataTable();
		}
	}
}
