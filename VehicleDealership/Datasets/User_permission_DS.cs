using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{


	partial class User_permission_DS
	{
		public static bool Has_permission(int int_user_id, Classes.User_permission permission)
		{
			try
			{
				User_permission_DSTableAdapters.QueriesTableAdapter adapter = new User_permission_DSTableAdapters.QueriesTableAdapter();
				if ((int)(new User_permission_DSTableAdapters.QueriesTableAdapter()).sp_COUNT_permisison(int_user_id, permission.Value) > 0)
				{
					return true;
				}
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}
