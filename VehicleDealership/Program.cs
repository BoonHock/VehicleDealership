using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.View;

namespace VehicleDealership
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (Log_in())
			{
				Application.Run(new Form_main_menu());
			}
		}
		static bool Log_in()
		{
			return (new Form_log_in()).ShowDialog() == DialogResult.OK;
		}
	}
}
