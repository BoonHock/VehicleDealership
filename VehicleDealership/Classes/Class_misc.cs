using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace VehicleDealership.Classes
{
	class Class_misc
	{
		public static void Display_dataset_error(string class_name, string function_name, string error_msg)
		{
			MessageBox.Show("An error has occured. \n" + class_name + "." + function_name +
				"\n Error:" + error_msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		public static void Go_url(string str_url)
		{
			try
			{
				Process.Start(str_url);
			}
			catch (Exception)
			{
				MessageBox.Show("URL invalid.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
