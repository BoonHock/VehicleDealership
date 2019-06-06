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

			string str_username;

			if (Datasets.user_ds.Check_db_has_user())
				str_username = Log_in();
			else
				str_username = View.Form_register_user.Register_user();

			if (str_username != null)
			{
				System_user = new Classes.User(str_username);
				////Gets the icon associated with the currently executing assembly
				////(or pass a different file path and name for a different executable)
				//Icon appIcon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
				//View.Form_main_menu form_Main_Menu = new View.Form_main_menu();
				//form_Main_Menu.Icon = appIcon;

				Application.Run(new View.Form_main_menu());
			}

		}
		public static Classes.User System_user;
		static string Log_in()
		{
			View.Form_log_in form_login = new View.Form_log_in();
			if (form_login.ShowDialog() != DialogResult.OK) return null;

			//System_user = new Classes.System_user(form_login.Username);
			return form_login.Username;
		}
	}
}
