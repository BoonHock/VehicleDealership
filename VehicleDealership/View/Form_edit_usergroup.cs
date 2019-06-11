using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Datasets;


namespace VehicleDealership.View
{
	public partial class Form_edit_usergroup : Form
	{
		private string EditUserGroup { get; } = "";
		public Form_edit_usergroup()
		{
			InitializeComponent();
		}
		public Form_edit_usergroup(string str_usergroup, string str_usergroup_desc)
		{
			InitializeComponent();

			EditUserGroup = str_usergroup;

			txt_name.Text = str_usergroup;
			txt_description.Text = str_usergroup_desc;
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			string str_usergroup = txt_name.Text.Trim();
			string str_usergroup_description = txt_description.Text.Trim();

			if (str_usergroup.Length == 0)
			{
				MessageBox.Show("Usergroup name is required.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Permission_ds.Usergroup_available(str_usergroup,EditUserGroup))
			{
				MessageBox.Show("Usergroup name already in use.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (EditUserGroup == "")
			{
				// Adding new usergroup
				Permission_ds.Insert_usergroup(str_usergroup, str_usergroup_description);
			}
			else
			{
				// editing existing usergroup
				Permission_ds.Update_usergroup(str_usergroup, str_usergroup_description, EditUserGroup);
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
