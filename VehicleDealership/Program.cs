using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

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

			bool enter_program = false;

			if (Datasets.Users_DS.COUNT_user() == 0)
				enter_program = Register_user();
			else
				enter_program = Log_in();

			if (enter_program)
			{
				////Gets the icon associated with the currently executing assembly
				////(or pass a different file path and name for a different executable)
				//Icon appIcon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
				//View.Form_main_menu form_Main_Menu = new View.Form_main_menu();
				//form_Main_Menu.Icon = appIcon;
				
				Application.Run(new View.Form_main_menu());

			}

		}
		public static Classes.System_user System_user = new Classes.System_user(""); // just to initialise
		static bool Log_in()
		{
			View.Form_log_in form_login = new View.Form_log_in();
			if (form_login.ShowDialog() != DialogResult.OK) return false;

			System_user = new Classes.System_user(form_login.Username);
			return true;
		}
		static bool Register_user() 
		{
			View.Form_register_user form_register = new View.Form_register_user();
			if (form_register.ShowDialog() != DialogResult.OK) return false;

			System_user = new Classes.System_user(form_register.Username);
			return true;
		}
	}
}
