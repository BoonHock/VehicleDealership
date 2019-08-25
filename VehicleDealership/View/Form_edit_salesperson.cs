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
	public partial class Form_edit_salesperson : Form
	{
		private readonly int SalespersonID = 0;
		public Form_edit_salesperson(int int_salesperson = 0)
		{
			InitializeComponent();

			SalespersonID = int_salesperson;
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
	}
}
