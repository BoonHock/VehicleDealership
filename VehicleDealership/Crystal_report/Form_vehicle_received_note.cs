using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Datasets;

namespace VehicleDealership.Crystal_report
{
	public partial class Form_vehicle_received_note : Form
	{
		readonly int _vehicle_id = 0;
		public Form_vehicle_received_note(int int_vehicle)
		{
			_vehicle_id = int_vehicle;

			InitializeComponent();
		}

		private void Form_vehicle_received_note_Load(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			//Vehicle_ds.sp_vehicle_received_noteDataTable dttable = Vehicle_ds.
			CR_vehicle_received_note cr_vehicle = new CR_vehicle_received_note();
			cr_vehicle.Load();
			cr_vehicle.SetParameterValue("My Parameter", _vehicle_id);

			crystalReportViewer1.ReportSource = cr_vehicle;
			crystalReportViewer1.Refresh();

			Cursor = Cursors.Default;
		}
	}
}
