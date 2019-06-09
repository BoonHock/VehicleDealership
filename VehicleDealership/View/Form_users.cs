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
using VehicleDealership.Classes;

namespace VehicleDealership.View
{
	public partial class Form_users : Form
	{
		public Form_users()
		{
			InitializeComponent();
		}

		private void Form_users_Load(object sender, EventArgs e)
		{
			Setup_grd_users();
			txt_search.TextChanged += Txt_search_TextChanged;

			Class_style.Grd_style.Common_style(Grd_users);
		}
		private void Txt_search_TextChanged(object sender, EventArgs e)
		{
			Setup_grd_users();
		}
		private void Setup_grd_users()
		{
			string str_search = txt_search.Text.Trim();

			Grd_users.DataSource = null;
			Grd_users.DataSource = User_ds.Search_user(str_search);

			Grd_users.AutoResizeColumns();

			Class_datagridview.Hide_columns(Grd_users, new string[] { "user" });
		}
		private void Edit_user(object sender, EventArgs e)
		{
			if (Grd_users.SelectedCells.Count == 0)
			{
				MessageBox.Show("Select a user to edit.");
				return;
			}

			DataGridViewRow grd_row = Grd_users.Rows[Grd_users.SelectedCells[0].RowIndex];

			Form_edit_users form_edit = new Form_edit_users((int)grd_row.Cells["user"].Value);

			if (form_edit.ShowDialog() == DialogResult.OK)
			{
				Setup_grd_users();
			}
		}
		private void Add_user(object sender, EventArgs e)
		{
			string str_username = View.Form_register_user.Register_user();

			if (str_username == null) return;

			MessageBox.Show("New user added");
			Setup_grd_users();
		}
	}
}
