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
		public static void Setup_listview(ListView lv_setup, DataTable dttable)
		{
			lv_setup.BeginUpdate();
			lv_setup.Clear();

			foreach (DataColumn dtcol in dttable.Columns)
			{
				lv_setup.Columns.Add(dtcol.Caption);
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
		}
	}
}
