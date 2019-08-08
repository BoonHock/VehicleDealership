using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Classes;
using VehicleDealership.Datasets;

namespace VehicleDealership.View
{
	public partial class Form_datagridview : Form
	{
		public Form_datagridview()
		{
			InitializeComponent();
		}
		private void Form_datagridview_Load(object sender, EventArgs e)
		{
			// hide all toolstrip. will show them accordingly depending on what the user is using this form for
			foreach (Control ctrl in this.Controls)
			{
				if (ctrl is ToolStrip) ctrl.Visible = false;
			}
		}
		private void Form_datagridview_Shown(object sender, EventArgs e)
		{
			bool permission_denied = false;

			switch (this.Tag.ToString().ToUpper())
			{
				case "USER":
					Class_style.Grd_style.Common_style(grd_main);

					if (!Program.System_user.Has_permission(User_permission.ADD_USER) &&
						!Program.System_user.Has_permission(User_permission.EDIT_USER))
						permission_denied = true;
					else
						Setup_form_users();
					break;
				case "FUEL_TYPE":
					if (!Program.System_user.Has_permission(User_permission.ADD_EDIT_FUEL_TYPE) &&
						!Program.System_user.Has_permission(User_permission.DELETE_FUEL_TYPE))
						permission_denied = true;
					else
						Setup_form_fuel_type();
					break;
			}

			if (permission_denied)
			{
				MessageBox.Show("PERMISSION DENIED", "PERMISSION DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}
		}
		#region USERS
		private void Setup_form_users()
		{
			ts_user.Visible = true;

			DataTable dttable_active = new DataTable();
			dttable_active.Columns.Add("display", typeof(string));
			dttable_active.Columns.Add("value", typeof(int));

			dttable_active.Rows.Add("All", -1);
			dttable_active.Rows.Add("Active", 1);
			dttable_active.Rows.Add("Inactive", 0);

			cmb_is_active_user.ComboBox.DisplayMember = "display";
			cmb_is_active_user.ComboBox.ValueMember = "value";
			cmb_is_active_user.ComboBox.DataSource = dttable_active;
			cmb_is_active_user.ComboBox.SelectedValue = 1; // select active user as default

			if (Program.System_user.Has_permission(User_permission.EDIT_USER))
			{
				btn_edit_user.Enabled = true;
				editToolStripMenuItem.Enabled = true;
				btn_activate_user.Enabled = true;
				btn_deactivate_user.Enabled = true;
			}
			if (Program.System_user.Has_permission(User_permission.ADD_USER))
			{
				btn_add_user.Enabled = true;
				addToolStripMenuItem.Enabled = true;
			}

			Setup_grd_users();

			txt_search_user.TextChanged += Setup_grd_users;
			cmb_is_active_user.ComboBox.SelectedIndexChanged += Setup_grd_users;
			grd_main.MouseDown += Class_datagridview.MouseDown_select_cell;
			btn_add_user.Click += Add_user;
			addToolStripMenuItem.Click += Add_user;
			btn_edit_user.Click += Edit_user;
			editToolStripMenuItem.Click += Edit_user;
			btn_deactivate_user.Click += Btn_activate_deactivate_user_Click;
			btn_activate_user.Click += Btn_activate_deactivate_user_Click;
		}
		private void Setup_grd_users(object sender = null, EventArgs e = null)
		{
			// setup grd_main
			grd_main.RowEnter -= Grd_users_RowEnter;
			string str_search = txt_search_user.Text.Trim();

			DataTable dttable = new User_ds.sp_search_userDataTable();

			switch ((int)cmb_is_active_user.ComboBox.SelectedValue)
			{
				case 0:
					dttable = User_ds.Search_user(str_search, false);
					break;
				case 1:
					dttable = User_ds.Search_user(str_search, true);
					break;
				default:
					dttable = User_ds.Search_user(str_search, null);
					break;
			}

			Class_datagridview.Setup_and_preselect(grd_main, dttable, "user");

			grd_main.AutoResizeColumns();

			Class_datagridview.Hide_columns(grd_main, new string[] { "user" });

			Setup_buttons_enable();
			grd_main.RowEnter += Grd_users_RowEnter;
		}
		private void Edit_user(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0)
			{
				MessageBox.Show("Select a user to edit.");
				return;
			}
			int int_user = (int)grd_main.Rows[grd_main.SelectedCells[0].RowIndex].Cells["user"].Value;
			if (int_user == 1)
			{
				MessageBox.Show("ADMIN cannot be activated or deactivated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			Form_edit_users form_edit = new Form_edit_users(int_user);

			if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_users();
		}
		private void Add_user(object sender, EventArgs e)
		{
			string str_username = View.Form_register_user.Register_user();

			if (str_username == null) return;

			Setup_grd_users();
			MessageBox.Show("New user added");
		}
		private void Btn_activate_deactivate_user_Click(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0)
			{
				MessageBox.Show("Select a user to edit.");
				return;
			}

			int int_user = (int)grd_main.Rows[grd_main.SelectedCells[0].RowIndex].Cells["user"].Value;
			bool is_activate = ((ToolStripButton)sender == btn_activate_user) ? true : false;

			if (int_user == 1)
			{
				MessageBox.Show("ADMIN cannot be activated or deactivated", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			User_ds.Update_user_active(int_user, is_activate);
			Setup_grd_users();
		}
		private void Grd_users_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			Setup_buttons_enable();
		}
		private void Setup_buttons_enable()
		{
			if (grd_main.Rows.Count == 0 || grd_main.SelectedCells.Count == 0) return;

			int int_user = (int)grd_main.Rows[grd_main.SelectedCells[0].RowIndex].Cells["user"].Value;

			bool is_admin = (int_user == 1);

			btn_edit_user.Enabled = !is_admin;
			btn_deactivate_user.Enabled = !is_admin;
			btn_activate_user.Enabled = !is_admin;
			editToolStripMenuItem.Enabled = !is_admin;
		}
		#endregion
		#region FUEL_TYPE
		private void Setup_form_fuel_type()
		{
			ts_fuel_type.Visible = true;
			Setup_grd_fuel_type();
		}
		private void Setup_grd_fuel_type()
		{
			Fuel_type_ds.sp_select_fuel_typeDataTable dttable = Fuel_type_ds.Select_fuel_type();

			dttable.Columns["modified_by"].DefaultValue = Program.System_user.Name;
			dttable.Columns["modified_by"].ReadOnly = true;

			grd_main.DataSource = null;
			grd_main.DataSource = dttable;
			grd_main.AutoResizeColumns();

			grd_main.Columns["modified_by"].DefaultCellStyle.BackColor = Color.LightGray;

			if (Program.System_user.Has_permission(User_permission.ADD_EDIT_FUEL_TYPE))
			{
				grd_main.ReadOnly = false;
				grd_main.AllowUserToAddRows = true;
			}
			if (Program.System_user.Has_permission(User_permission.DELETE_FUEL_TYPE))
			{
				grd_main.AllowUserToDeleteRows = true;
			}

			if (!Program.System_user.IsDeveloper)
				Class_datagridview.Hide_columns(grd_main, new string[] { "fuel_type" });
		}
		private void Btn_save_fuel_type_Click(object sender, EventArgs e)
		{
			int cell_row = grd_main.CurrentCell.RowIndex;
			int cell_col = grd_main.CurrentCell.ColumnIndex;

			grd_main.CurrentCell = null;
			grd_main.CurrentCell = grd_main[cell_col, cell_row];

			DataTable dttable = ((DataTable)grd_main.DataSource).Copy();

			Class_datatable.Remove_unnecessary_columns(dttable, new string[] { "fuel_type", "fuel_type_name" });

			DataColumn dt_col = new DataColumn("modified_by");
			dt_col.DefaultValue = Program.System_user.UserID;

			dttable.Columns.Add(dt_col);

			Bulkcopy_table_ds.Delete_by_user();

			using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VehicleDealershipConnectionString))
			{
				conn.Open();

				using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
				{
					bulkCopy.DestinationTableName = "[misc].[bulkcopy_table]";

					try
					{
						bulkCopy.ColumnMappings.Add("fuel_type", "int1");
						bulkCopy.ColumnMappings.Add("fuel_type_name", "nvarchar1");
						bulkCopy.ColumnMappings.Add("modified_by", "created_by");
						bulkCopy.WriteToServer(dttable);
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error has occurred. Vehicle groups cannot be updated. \n\n Message: " +
							ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				conn.Close();
			}

			// bulkcopy done. update fuel_type table!
			Fuel_type_ds.Update_insert_fuel_type();

			MessageBox.Show("All items have been saved successfully.", "Item saved", MessageBoxButtons.OK);
		}
		#endregion
	}
}
