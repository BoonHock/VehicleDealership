using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDealership.Classes
{
	class Class_style
	{
		public class Grd_style
		{
			public static void Common_style(DataGridView grd, int row_header_width = 15)
			{
				grd.AllowUserToResizeRows = false;
				grd.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
				if (row_header_width > 0) grd.RowHeadersWidth = row_header_width;
			}
		}
	}
}
