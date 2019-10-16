using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDealership.Crystal_report
{
	public partial class Form_crystal_report : Form
	{
		public Form_crystal_report(CrystalDecisions.CrystalReports.Engine.ReportClass rpt_class)
		{
			InitializeComponent();
			crystalReportViewer1.ReportSource = rpt_class;
		}
	}
}
