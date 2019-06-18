using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDealership.Classes
{
	class Class_datagridview
	{
		public static void Hide_columns(DataGridView grd, string[] cols_to_hide)
		{
			for (int i = 0, j = grd.Columns.Count - 1; i < j; i++)
			{
				if (cols_to_hide.Contains(grd.Columns[i].Name, StringComparer.OrdinalIgnoreCase))
				{
					grd.Columns[i].Visible = false;
				}
			}
		}
		public static void Change_header_text(DataGridView grd, Dictionary<string, string> change_pairs)
		{
			foreach (KeyValuePair<string, string> entry in change_pairs)
			{
				if(grd.Columns.Contains(entry.Key))
				{
					grd.Columns[entry.Key].HeaderText = entry.Value;
				}
			}
		}
		public static void MouseDown_select_cell(object sender, MouseEventArgs e)
		{
			DataGridView grd = (DataGridView)sender;

			var hti = grd.HitTest(e.X, e.Y);

			if (hti.RowIndex != -1)
			{
				grd.ClearSelection();
				grd[hti.ColumnIndex, hti.RowIndex].Selected = true;
				grd.CurrentCell = grd[hti.ColumnIndex, hti.RowIndex];
			}
		}
	}
}
