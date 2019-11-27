using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{


	partial class Bulkcopy_table_ds
	{
		public static void Delete_by_user()
		{
			try
			{
				using (Bulkcopy_table_dsTableAdapters.QueriesTableAdapter adapter = 
					new Bulkcopy_table_dsTableAdapters.QueriesTableAdapter())
				{
					adapter.DeleteQuery(Program.System_user.UserID);
				}
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
