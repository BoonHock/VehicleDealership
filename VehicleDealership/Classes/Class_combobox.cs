using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDealership.Classes
{
	class Class_combobox
	{
		public static void Setup_combobox(System.Windows.Forms.ComboBox cmb, System.Data.DataTable dttable, string value_col, string display_col)
		{
			cmb.DataSource = null;

			cmb.DisplayMember = display_col;
			cmb.ValueMember = value_col;
			cmb.DataSource = dttable;
		}
	}
}
