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
		/// <summary>
		/// setup datagridview. will select back cell after setting up based on @value_col
		/// </summary>
		/// <param name="grd"></param>
		/// <param name="dttable"></param>
		/// <param name="value_col"></param>
		public static void Setup_and_preselect(DataGridView grd, DataTable dttable, string value_col)
		{
			string cell_value = "";
			string selected_col_name = "";
			bool has_current_cell = false;

			// if datagridview has row and has current cell initially, store its value and position
			if (grd.Rows.Count > 0 && grd.CurrentCell != null)
			{
				has_current_cell = true;
				cell_value = grd.Rows[grd.CurrentCell.RowIndex].Cells[value_col].Value.ToString();
				selected_col_name = grd.Columns[grd.CurrentCell.ColumnIndex].Name;
			}

			// setup datagridview
			grd.DataSource = null;
			grd.DataSource = dttable;

			// if previously has current cell, select same cell back.
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
		/// <summary>
		/// hide datagridview columns
		/// </summary>
		/// <param name="grd">datagridview to hide columns</param>
		/// <param name="cols_to_hide">columns to hide</param>
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
		/// <summary>
		/// hide columns where column name not in @cols_to_view array
		/// </summary>
		/// <param name="grd"></param>
		/// <param name="cols_to_view"></param>
		public static void Hide_unnecessary_columns(DataGridView grd, string[] cols_to_view)
		{
			foreach (DataGridViewColumn grd_col in grd.Columns)
			{
				if (!cols_to_view.Contains(grd_col.Name, StringComparer.OrdinalIgnoreCase))
				{
					grd_col.Visible = false;
				}
			}
		}
		/// <summary>
		/// change header text
		/// </summary>
		/// <param name="grd">datagridview to process</param>
		/// <param name="change_pairs">dictionary. key - column name, value - header text</param>
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
		/// <summary>
		/// right click will not select cell.
		/// attach mousedown event of datagridview to this function to make right click also select cell.
		/// this is so that if there is a context menu strip, right clicking a cell will select that cell for the cms.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
