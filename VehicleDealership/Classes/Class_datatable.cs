using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace VehicleDealership.Classes
{
	class Class_datatable
	{
		public static void Remove_columns(DataTable dataTable, string[] cols_to_remove)
		{
			for (int i = dataTable.Columns.Count - 1; i >= 0; i--)
			{
				if (cols_to_remove.Contains(dataTable.Columns[i].ColumnName, StringComparer.OrdinalIgnoreCase))
				{
					dataTable.Columns.RemoveAt(i);
				}
			}
		}
		public static void Remove_unnecessary_columns(DataTable dataTable, string[] cols_to_keep)
		{
			for (int i = dataTable.Columns.Count - 1; i >= 0; i--)
			{
				if (!cols_to_keep.Contains(dataTable.Columns[i].ColumnName, StringComparer.OrdinalIgnoreCase))
				{
					dataTable.Columns.RemoveAt(i);
				}
			}
		}
		public static void Change_header_text(DataGridView grd, Dictionary<string, string> change_pairs)
		{
			foreach (KeyValuePair<string, string> entry in change_pairs)
			{
				if (grd.Columns.Contains(entry.Key))
				{
					grd.Columns[entry.Key].HeaderText = entry.Value;
				}
			}
		}
		public static Dictionary<string, string> Get_column_captions(DataTable dataTable)
		{
			Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

			foreach (DataColumn dt_col in dataTable.Columns)
			{
				keyValuePairs.Add(dt_col.ColumnName, dt_col.ColumnName.Replace("_", " "));
			}

			return keyValuePairs;
		}

	}
}
