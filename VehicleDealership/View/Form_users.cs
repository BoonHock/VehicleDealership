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
		}

		private void Txt_search_TextChanged(object sender, EventArgs e)
		{

			Setup_grd_users();
		}

		private void Setup_grd_users()
		{
			string str_search = txt_search.Text.Trim();
			Users_DS.UsersDataTable users = new Users_DS.UsersDataTable();

			if (str_search == "")
			{
				users = Users_DS.SELECT_users();
			}
			else
			{
				users = Users_DS.SELECT_user_by_search(str_search);
			}

			Class_datatable.Remove_columns(users, new string[] { "Password", "Modified_by", "Modified_on" });

			grd_users.DataSource = users;
			grd_users.AutoResizeColumns();

			Class_datagridview.Hide_columns(grd_users, new string[] { "User_id" });
			Class_datagridview.Change_header_text(grd_users, Users_DS.UsersDataTable_cols_caption());
		}
	}
}
