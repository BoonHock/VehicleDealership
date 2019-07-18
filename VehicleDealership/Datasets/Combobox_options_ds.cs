using System.Reflection;
using System.Windows.Forms;

namespace VehicleDealership.Datasets
{

	partial class Combobox_options_ds
	{
		public static Combobox_options_dsTableAdapters.Combobox_optionsTableAdapter ComboboxAdapter()
		{
			return new Combobox_options_dsTableAdapters.Combobox_optionsTableAdapter();
		}
		public static Combobox_optionsDataTable Select_country()
		{
			try
			{
				return ComboboxAdapter().select_country();
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new Combobox_optionsDataTable();
		}
	}
}
