using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Filepath_ds
	{
		private static Filepath_dsTableAdapters.sp_select_filepathTableAdapter Select_FilepathTableAdapter()
		{
			return new Filepath_dsTableAdapters.sp_select_filepathTableAdapter();
		}
		public static sp_select_filepathDataTable Select_filepath(string str_filepath)
		{
			try
			{
				using (Filepath_dsTableAdapters.sp_select_filepathTableAdapter adapter = Select_FilepathTableAdapter())
				{
					return adapter.GetData(str_filepath);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_filepathDataTable();
		}
		public static string Select_filepath_dir(string str_filepath)
		{
			string return_value = "";

			using (sp_select_filepathDataTable dttable = Select_filepath(str_filepath))
			{
				if (dttable.Rows.Count > 0) return_value = dttable[0].filepath_dir;
			}

			return return_value;
		}
	}
}
