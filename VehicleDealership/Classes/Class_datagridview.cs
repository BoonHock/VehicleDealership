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
		//public static void Setup_and_preselect(DataGridView grd, DataTable dttable, string value_col)
		//{
		//	string cell_value = "";
		//	string selected_col_name = "";
		//	bool has_current_cell = false;

		//	// if datagridview has row and has current cell initially, store its value and position
		//	if (grd.Rows.Count > 0 && grd.CurrentCell != null)
		//	{
		//		has_current_cell = true;
		//		cell_value = grd.Rows[grd.CurrentCell.RowIndex].Cells[value_col].Value.ToString();
		//		selected_col_name = grd.Columns[grd.CurrentCell.ColumnIndex].Name;
		//	}

		//	// setup datagridview
		//	grd.DataSource = null;
		//	grd.DataSource = dttable;

		//	// if previously has current cell, select same cell back.
		//	if (has_current_cell)
		//	{
		//		foreach (DataGridViewRow grd_row in grd.Rows)
		//		{
		//			if (grd_row.IsNewRow) continue;

		//			if (grd_row.Cells[value_col].Value.ToString() == cell_value)
		//			{
		//				grd.CurrentCell = null;
		//				grd.ClearSelection();

		//				grd_row.Cells[selected_col_name].Selected = true;
		//				grd.CurrentCell = grd_row.Cells[selected_col_name];
		//				break;
		//			}
		//		}
		//	}
		//}
		public static void Setup_and_preselect(DataGridView grd, DataTable dttable, string value_col, string[] cols_to_view = null, string preselect_value = "")
		{
			string cell_value = preselect_value;

			if (grd.Rows.Count > 0 && grd.CurrentCell != null && preselect_value == "")
			{
				// if datagridview has row and has current cell initially, store its value and position
				cell_value = grd.Rows[grd.CurrentCell.RowIndex].Cells[value_col].Value.ToString();
			}

			// setup datagridview
			grd.DataSource = null;
			grd.DataSource = dttable;

			if (cols_to_view != null)
				Class_datagridview.Hide_unnecessary_columns(grd, cols_to_view);

			foreach (DataGridViewRow grd_row in grd.Rows)
			{
				if (grd_row.IsNewRow) continue;

				if (grd_row.Cells[value_col].Value.ToString() == cell_value)
				{
					Set_current_cell_to_first_visible_column(grd_row);
					break;
				}
			}
		}
		public static void Select_row_by_value(DataGridView grd, string value_col, string str_value)
		{
			foreach (DataGridViewRow grd_row in grd.Rows)
			{
				if (grd_row.Cells[value_col].Value != DBNull.Value &&
					grd_row.Cells[value_col].Value.ToString() == str_value)
				{
					grd.ClearSelection();
					grd_row.Selected = true;
					Set_current_cell_to_first_visible_column(grd_row);
					break;
				}
			}
		}
		/// <summary>
		/// settting current cell to an invisible column will cause error. 
		/// use this function to set current cell to row's first visible column
		/// </summary>
		/// <param name="grd_row"></param>
		public static void Set_current_cell_to_first_visible_column(DataGridViewRow grd_row)
		{
			foreach (DataGridViewColumn grd_col in grd_row.DataGridView.Columns)
			{
				if (grd_col.Visible)
				{
					grd_row.DataGridView.ClearSelection();
					grd_row.DataGridView.CurrentCell = null;

					grd_row.Cells[grd_col.Index].Selected = true;
					grd_row.DataGridView.CurrentCell = grd_row.Cells[grd_col.Index];
					break;
				}
			}
		}
		/// <summary>
		/// hide datagridview columns
		/// </summary>
		/// <param name="grd">datagridview to hide columns</param>
		/// <param name="cols_to_hide">columns to hide</param>
		public static void Hide_columns(DataGridView grd, params string[] cols_to_hide)
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
		public static void Hide_unnecessary_columns(DataGridView grd, params string[] cols_to_view)
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
			try
			{
				DataGridView grd = (DataGridView)sender;

				var hti = grd.HitTest(e.X, e.Y);

				if (hti.RowIndex != -1 && hti.ColumnIndex != -1)
				{
					// if cell being right-clicked is already selected, then no need to clear selection and reselect
					if (grd[hti.ColumnIndex, hti.RowIndex].Selected) return;

					grd.ClearSelection();
					grd[hti.ColumnIndex, hti.RowIndex].Selected = true;
					grd.CurrentCell = grd[hti.ColumnIndex, hti.RowIndex];
				}
			}
			catch (Exception)
			{
				// ignore error
			}
		}
		public static void Apply_all_changes(DataGridView grd)
		{
			if (grd.CurrentCell != null)
			{
				// store row and column index to set current cell to null and then back to the cell
				// this will force dgv to "apply" changes in all edited cells
				int cell_row = grd.CurrentCell.RowIndex;
				int cell_col = grd.CurrentCell.ColumnIndex;

				grd.CurrentCell = null;
				grd.CurrentCell = grd[cell_col, cell_row];
			}
		}
		/// <summary>
		/// remove rows where cells are selected. will skip new row for editing
		/// </summary>
		/// <param name="grd"></param>
		public static void Remove_row_of_selected_cells(DataGridView grd)
		{
			if (grd.SelectedCells.Count == 0) return;

			List<int> list_int = new List<int>();

			foreach (DataGridViewCell grd_cell in grd.SelectedCells)
			{
				if (grd_cell.OwningRow.IsNewRow) continue;

				list_int.Add(grd_cell.RowIndex);
			}

			list_int = list_int.Distinct().ToList();
			list_int.Sort();
			list_int.Reverse();

			foreach (int i in list_int)
			{
				if (!grd.Rows[i].IsNewRow) grd.Rows.RemoveAt(i);
			}
		}
		/// <summary>
		/// set DataGridViewTextBoxColumn column max length to be similar with datatable column
		/// </summary>
		/// <param name="grd"></param>
		/// <param name="str_col_name"></param>
		public static void Set_max_length_grd_col_same_with_datatable_col(DataGridView grd, params string[] arr_col_name)
		{
			foreach (string str_tmp in arr_col_name)
			{
				((DataGridViewTextBoxColumn)grd.Columns[str_tmp]).MaxInputLength =
					((DataTable)grd.DataSource).Columns[str_tmp].MaxLength;
			}
		}
		public static void Convert_column_to_link_column(DataGridView grd, string str_data_property_name, string str_col_name)
		{
			if (!grd.Columns.Contains(str_col_name)) return;

			grd.Columns.Remove(str_col_name);

			DataGridViewLinkColumn col_link = new DataGridViewLinkColumn
			{
				DataPropertyName = str_data_property_name,
				Name = str_col_name
			};
			grd.Columns.Add(col_link);
		}
		public static void Replace_column_with_combobox_column(DataGridView grd, string str_col_name,
			DataTable dttable, string str_display_member, string str_value_member)
		{
			int col_index = grd.Columns[str_col_name].Index;

			DataGridViewComboBoxColumn grd_col = new DataGridViewComboBoxColumn
			{
				DataSource = dttable,
				DisplayMember = str_display_member,
				ValueMember = str_value_member,
				Name = str_col_name,
				DataPropertyName = str_col_name
			};

			grd.Columns.RemoveAt(col_index);
			grd.Columns.Insert(col_index, grd_col);
		}
	}
}
