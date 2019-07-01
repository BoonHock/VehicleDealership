using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace VehicleDealership.Classes
{
	class Class_datagridview
	{
		public static void Setup_and_preselect(DataGridView grd, DataTable dttable, string value_col)
		{
			string cell_value = "";
			string selected_col_name = "";
			bool has_current_cell = false;

			if (grd.Rows.Count > 0 && grd.CurrentCell != null)
			{
				has_current_cell = true;
				cell_value = grd.Rows[grd.CurrentCell.RowIndex].Cells[value_col].Value.ToString();
				selected_col_name = grd.Columns[grd.CurrentCell.ColumnIndex].Name;
			}

			grd.DataSource = null;
			grd.DataSource = dttable;

			if (has_current_cell)
			{
				foreach (DataGridViewRow grd_row in grd.Rows)
				{
					if (grd_row.Cells[value_col].Value.ToString() == cell_value)
					{
						grd.CurrentCell = null;
						grd.ClearSelection();

						grd_row.Cells[selected_col_name].Selected = true;
						grd.CurrentCell = grd_row.Cells[selected_col_name];
						break;
					}
				}
			}

		}
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
				if (grd.Columns.Contains(entry.Key))
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
