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
		public static void Setup_listview(ListView lv_setup, DataTable dttable, string value_colname = "", string[] cols_to_hide = null)
		{
			lv_setup.BeginUpdate();
			lv_setup.Clear();

			if (value_colname.Trim() != "" && dttable.Columns.Contains(value_colname))
			{
				dttable.Columns[value_colname].SetOrdinal(0);
			}

			foreach (DataColumn dtcol in dttable.Columns)
			{
				lv_setup.Columns.Add(dtcol.Caption,dtcol.Caption);
			}
			for (int i = 0; i < dttable.Rows.Count; i++)
			{
				ListViewItem lv_item = new ListViewItem();

				lv_item.Text = dttable.Rows[i][0].ToString();

				for (int j = 1; j < dttable.Columns.Count; j++)
				{
					lv_item.SubItems.Add(dttable.Rows[i][j].ToString());
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
					if (cols_to_hide.Contains(dttable.Columns[i].Caption)) lv_setup.Columns[i].Width = 0;
				}
			}
		}
	}
}
