using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Document_prefix_ds
	{
		public static string Select_document_prefix(string str_doc_prefix)
		{
			try
			{
				using (Document_prefix_dsTableAdapters.sp_select_document_prefixTableAdapter adapter =
					new Document_prefix_dsTableAdapters.sp_select_document_prefixTableAdapter())
				{
					using (sp_select_document_prefixDataTable dttable = adapter.GetData(str_doc_prefix))
					{
						if (dttable.Rows.Count > 0) return dttable[0].document_prefix_text;
					}
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return "";
		}
	}
}
