using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace VehicleDealership.Classes
{
	class Class_listview
	{
		public static void Setup_listview(ListView lv_setup, DataTable dttable,
			string[] cols_to_hide = null, string[] cols_money = null)
		{
			lv_setup.BeginUpdate();
			lv_setup.Clear();

			foreach (DataColumn dtcol in dttable.Columns)
			{
				lv_setup.Columns.Add(dtcol.Caption, dtcol.Caption);
			}
			for (int i = 0; i < dttable.Rows.Count; i++)
			{
				ListViewItem lv_item = new ListViewItem
				{
					Text = dttable.Rows[i][0].ToString()
				};

				for (int j = 1; j < dttable.Columns.Count; j++)
				{
					if (cols_money.Contains(dttable.Columns[j].ColumnName,
						StringComparer.OrdinalIgnoreCase))
					{
						lv_item.SubItems.Add(((decimal)dttable.Rows[i][j]).
							ToString("#,##0.00"));
					}
					else
					{
						lv_item.SubItems.Add(dttable.Rows[i][j].ToString());
					}
				}
				lv_setup.Items.Add(lv_item);
			}

			lv_setup.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			lv_setup.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			lv_setup.EndUpdate();

			if (cols_to_hide != null)
			{
				for (int i = 0; i < dttable.Columns.Count; i++)
				{
					if (cols_to_hide.Contains(dttable.Columns[i].Caption,
						StringComparer.OrdinalIgnoreCase))
						lv_setup.Columns[i].Width = 0;
				}
			}
		}
		public static string Get_checked_results_as_string(ListView lv, string str_value_col = "")
		{
			List<string> list_results = new List<string>();
			int int_subitem_index = 0;

			if (lv.Columns.ContainsKey(str_value_col))
			{
				int_subitem_index = lv.Columns[str_value_col].Index;
			}
			foreach (ListViewItem lv_item in lv.CheckedItems)
			{
				list_results.Add(lv_item.SubItems[int_subitem_index].Text);
			}

			return string.Join(",", list_results);
		}
	}
}
