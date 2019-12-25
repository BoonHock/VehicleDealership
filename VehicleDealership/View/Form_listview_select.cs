using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Classes;

namespace VehicleDealership.View
{
	public partial class Form_listview_select : Form
	{
		readonly string _value_colname = "";
		public List<string> SelectedValuesString
		{
			get
			{
				List<string> list_string = new List<string>();

				if (Listview_main.Items.Count > 0)
				{
					foreach (ListViewItem lv_item in Listview_main.CheckedItems)
					{
						list_string.Add(lv_item.SubItems[Listview_main.
							Columns.IndexOfKey(_value_colname)].Text);
					}
				}

				return list_string;
			}
		}
		public List<int> SelectedValuesInt
		{
			get
			{
				List<int> list_int = new List<int>();

				if (Listview_main.Items.Count > 0)
				{
					foreach (ListViewItem lv_item in Listview_main.CheckedItems)
					{
						list_int.Add(int.Parse(lv_item.SubItems[Listview_main.
							Columns.IndexOfKey(_value_colname)].Text));
					}
				}

				return list_int;
			}
		}
		public Form_listview_select(DataTable dttable, string value_colname = "",
			string[] cols_to_hide = null, string[] cols_money = null)
		{
			InitializeComponent();

			// if value col name is not given, assume first column of datatable
			if (value_colname == "")
				_value_colname = dttable.Columns[0].ColumnName;
			else
				_value_colname = value_colname;

			Class_listview.Setup_listview(Listview_main, dttable,
				cols_to_hide, cols_money);
		}

		private void Form_listview_select_Shown(object sender, EventArgs e)
		{
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void Txt_search_TextChanged(object sender, EventArgs e)
		{
			ListViewItem lv_item = Listview_main.FindItemWithText(txt_search.Text.Trim());

			if (lv_item != null) Listview_main.TopItem = lv_item;
		}
	}
}
