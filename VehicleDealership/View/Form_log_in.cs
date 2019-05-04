using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDealership.View
{
	public partial class Form_log_in : Form
	{
		public Form_log_in()
		{
			InitializeComponent();
		}

		private void Btn_log_in_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
