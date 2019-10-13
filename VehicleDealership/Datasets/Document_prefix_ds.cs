using System.Reflection;

namespace VehicleDealership.Datasets
{


	partial class Document_prefix_ds
	{
		private static Document_prefix_dsTableAdapters.sp_select_document_prefixTableAdapter Select_Document_PrefixTableAdapter()
		{
			return new Document_prefix_dsTableAdapters.sp_select_document_prefixTableAdapter();
		}
		public static sp_select_document_prefixDataTable Select_document_prefix(string str_doc_prefix)
		{
			try
			{
				using (Document_prefix_dsTableAdapters.sp_select_document_prefixTableAdapter adapter = Select_Document_PrefixTableAdapter())
				{
					return adapter.GetData(str_doc_prefix);
				}
			}
			catch (System.Exception e)
			{
				Classes.Class_misc.Display_dataset_error(MethodBase.GetCurrentMethod().DeclaringType.ToString(),
					MethodBase.GetCurrentMethod().Name, e.Message);
			}
			return new sp_select_document_prefixDataTable();
		}
	}
}
