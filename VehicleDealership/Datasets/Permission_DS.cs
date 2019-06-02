
using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{
	partial class Permission_DS
	{
		public static PermissionDataTable SELECT_permissions()
		{
			try
			{
				return (new Permission_DSTableAdapters.PermissionTableAdapter()).GetData();
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new PermissionDataTable();
		}
	}
}
