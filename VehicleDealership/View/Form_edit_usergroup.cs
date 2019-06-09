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
		public Form_edit_usergroup(string str_usergroup)
		{
			InitializeComponent();

			EditUserGroup = str_usergroup;
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			string str_name = txt_name.Text.Trim();
			string str_description = txt_description.Text.Trim();

			if (str_name.Length == 0)
			{
				MessageBox.Show("Usergroup name is required.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Permission_ds.Usergroup_available(str_name,EditUserGroup))
			{
				MessageBox.Show("Usergroup name already in use.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
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
