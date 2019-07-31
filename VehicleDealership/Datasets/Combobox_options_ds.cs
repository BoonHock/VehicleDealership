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
		public static Combobox_optionsDataTable Option_vehicle_brand()
		{
			try
			{
				return ComboboxAdapter().sp_option_vehicle_brand();
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new Combobox_optionsDataTable();
		}
		public static Combobox_optionsDataTable Select_transmission()
		{
			try
			{
				return ComboboxAdapter().select_transmission();
			}
			catch (System.Exception e)
			{
				MessageBox.Show("An error has occured. \n" + MethodBase.GetCurrentMethod().DeclaringType.ToString() +
					"." + MethodBase.GetCurrentMethod().Name + "\n Error:" + e.Message,
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return new Combobox_optionsDataTable();
		}
		public static Combobox_optionsDataTable Select_fuel_type()
		{
			try
			{
				return ComboboxAdapter().select_fuel_type();
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
