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
		public static string Copy_file(string source_path, string dest_dir)
		{
			string str_file = Path.GetFileNameWithoutExtension(source_path);
			string str_ext = Path.GetExtension(source_path);

			int file_counter = 0;

			string new_file_path = Path.Combine(dest_dir, str_file + str_ext);

			while (File.Exists(new_file_path))
			{
				file_counter++;

				new_file_path = Path.Combine(dest_dir, str_file + "_" + file_counter + str_ext);
			}

			File.Copy(source_path, new_file_path, false);

			return new_file_path;
		}
		public static string Generate_random_string(bool prepend_date = true, int length = 10)
		{
			Random random = new Random();
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

			string str_prepend = "";

			if (prepend_date)
				str_prepend = DateTime.Today.Year.ToString() + 
					DateTime.Today.Month.ToString("00") + DateTime.Today.Day.ToString("00");

			return str_prepend + new string(Enumerable.Repeat(chars, length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());

		}
	}
}
