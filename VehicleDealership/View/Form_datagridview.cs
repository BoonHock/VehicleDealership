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

			// when user mousedown, even right click, select cell
			grd_main.MouseDown += Class_datagridview.MouseDown_select_cell;
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

			if (this.Tag == null)
			{
				this.Close();
				return;
			}

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
				case "TRANSMISSION":
					if (!Program.System_user.Has_permission(User_permission.ADD_EDIT_TRANSMISSION) &&
						!Program.System_user.Has_permission(User_permission.DELETE_TRANSMISSION))
						permission_denied = true;
					else
						Setup_form_transmission();
					break;
				case "COLOR":
					if (!Program.System_user.Has_permission(User_permission.ADD_EDIT_COLOR) &&
						!Program.System_user.Has_permission(User_permission.DELETE_COLOR))
						permission_denied = true;
					else
						Setup_form_color();
					break;
				case "SALESPERSON":
					if (!Program.System_user.Has_permission(User_permission.ADD_EDIT_SALESPERSON) &&
						!Program.System_user.Has_permission(User_permission.DELETE_SALESPERSON))
						permission_denied = true;
					else
						Setup_form_edit_salesperson();
					break;
			}

			if (permission_denied)
			{
				MessageBox.Show("PERMISSION DENIED", "PERMISSION DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}
		}
		private void Delete_grd_main_row(object sender, EventArgs e)
		{
			if (grd_main.CurrentCell != null)
				grd_main.Rows.Remove(grd_main.CurrentCell.OwningRow);
		}
		private void Setup_cmb_is_active()
		{
			DataTable dttable_active = new DataTable();
			dttable_active.Columns.Add("display", typeof(string));
			dttable_active.Columns.Add("value", typeof(int));

			dttable_active.Rows.Add("All", -1);
			dttable_active.Rows.Add("Active", 1);
			dttable_active.Rows.Add("Inactive", 0);

			cmb_is_active_user.ComboBox.DisplayMember = "display";
			cmb_is_active_user.ComboBox.ValueMember = "value";
			cmb_is_active_user.ComboBox.DataSource = dttable_active;
			cmb_is_active_user.ComboBox.SelectedValue = 1; // select active as default
		}
		#region USERS
		private void Setup_form_users()
		{
			ts_user.Visible = true;

			deleteToolStripMenuItem.Visible = false; // cannot delete user
			btn_delete_user.Visible = false;

			Setup_cmb_is_active();

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
			// user will be editing straight to cell so no need display these two
			editToolStripMenuItem.Visible = false;
			addToolStripMenuItem.Visible = false;

			if (Program.System_user.Has_permission(User_permission.ADD_EDIT_FUEL_TYPE))
			{
				grd_main.ReadOnly = false;
				grd_main.AllowUserToAddRows = true;
			}
			grd_main.AllowUserToDeleteRows =
				Program.System_user.Has_permission(User_permission.DELETE_FUEL_TYPE);

			ts_save_only.Visible = true;
			Setup_grd_fuel_type();

			btn_save.Click += Btn_save_fuel_type_Click;
			deleteToolStripMenuItem.Click += Delete_grd_main_row;
		}
		private void Setup_grd_fuel_type()
		{
			Fuel_type_ds.sp_select_fuel_typeDataTable dttable = Fuel_type_ds.Select_fuel_type();

			dttable.Columns["modified_by"].DefaultValue = Program.System_user.Name;
			dttable.Columns["modified_by"].ReadOnly = true;

			Class_datagridview.Setup_and_preselect(grd_main, dttable, "fuel_type_name");

			grd_main.AutoResizeColumns();

			grd_main.Columns["modified_by"].DefaultCellStyle.BackColor = Color.LightGray;
			((DataGridViewTextBoxColumn)grd_main.Columns["fuel_type_name"]).MaxInputLength = 20;

			if (!Program.System_user.IsDeveloper)
				Class_datagridview.Hide_columns(grd_main, new string[] { "fuel_type" });
		}
		private void Btn_save_fuel_type_Click(object sender, EventArgs e)
		{
			Class_datagridview.Apply_all_changes(grd_main);

			DataTable dttable = Class_datatable.
				Remove_unnecessary_columns(((DataTable)grd_main.DataSource).Copy(),
				new string[] { "fuel_type", "fuel_type_name" });

			if (dttable.Select().GroupBy(c => c["fuel_type_name"].ToString().ToUpper()).Where(c => c.Count() > 1).Count() > 0)
			{
				MessageBox.Show("Duplicate fuel names are not allowed", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

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
						MessageBox.Show("An error has occurred. \n\n Message: " + ex.Message,
							"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
						conn.Close();
						return;
					}
				}
				conn.Close();
			}

			// bulkcopy done. update fuel_type table!
			bool is_deleted = true;
			bool is_updated = true;

			if (Program.System_user.Has_permission(User_permission.DELETE_FUEL_TYPE))
				is_deleted = Fuel_type_ds.Delete_fuel_type();

			if (Program.System_user.Has_permission(User_permission.ADD_EDIT_FUEL_TYPE))
				is_updated = Fuel_type_ds.Update_insert_fuel_type();

			Setup_grd_fuel_type();

			if (!is_deleted)
				MessageBox.Show("One or more fuel type cannot be deleted because there are vehicle models applying this fuel type",
					"Some items cannot be deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (is_updated && is_deleted) MessageBox.Show("All items have been saved successfully.", "Item saved", MessageBoxButtons.OK);
		}
		#endregion
		#region TRANSMISSION
		private void Setup_form_transmission()
		{
			// user will be editing straight to cell so no need display these two
			editToolStripMenuItem.Visible = false;
			addToolStripMenuItem.Visible = false;

			if (Program.System_user.Has_permission(User_permission.ADD_EDIT_TRANSMISSION))
			{
				grd_main.ReadOnly = false;
				grd_main.AllowUserToAddRows = true;
			}
			grd_main.AllowUserToDeleteRows =
				Program.System_user.Has_permission(User_permission.DELETE_TRANSMISSION);

			ts_save_only.Visible = true;

			Setup_grd_transmission();
			btn_save.Click += Btn_save_transmission_Click;
			deleteToolStripMenuItem.Click += Delete_grd_main_row;
		}
		private void Setup_grd_transmission()
		{
			Transmission_ds.sp_select_transmissionDataTable dttable = Transmission_ds.Select_transmission();

			dttable.Columns["modified_by"].DefaultValue = Program.System_user.Name;
			dttable.Columns["modified_by"].ReadOnly = true;

			Class_datagridview.Setup_and_preselect(grd_main, dttable, "transmission_name");

			grd_main.AutoResizeColumns();

			grd_main.Columns["modified_by"].DefaultCellStyle.BackColor = Color.LightGray;
			((DataGridViewTextBoxColumn)grd_main.Columns["transmission_name"]).MaxInputLength = 20;

			if (!Program.System_user.IsDeveloper)
				Class_datagridview.Hide_columns(grd_main, new string[] { "transmission" });
		}
		private void Btn_save_transmission_Click(object sender, EventArgs e)
		{
			Class_datagridview.Apply_all_changes(grd_main);

			DataTable dttable = Class_datatable.Remove_unnecessary_columns(((DataTable)grd_main.DataSource).Copy(),
				new string[] { "transmission", "transmission_name" });

			if (dttable.Select().GroupBy(c => c["transmission_name"].ToString().ToUpper()).Where(c => c.Count() > 1).Count() > 0)
			{
				MessageBox.Show("Duplicate transmission names are not allowed", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

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
						bulkCopy.ColumnMappings.Add("transmission", "int1");
						bulkCopy.ColumnMappings.Add("transmission_name", "nvarchar1");
						bulkCopy.ColumnMappings.Add("modified_by", "created_by");
						bulkCopy.WriteToServer(dttable);
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error has occurred. \n\n Message: " + ex.Message,
							"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
						conn.Close();
						return;
					}
				}
				conn.Close();
			}

			// insert, update and delete transmission
			bool is_deleted = true;
			bool is_updated = true;

			if (Program.System_user.Has_permission(User_permission.DELETE_TRANSMISSION))
				is_deleted = Transmission_ds.Delete_transmission();

			if (Program.System_user.Has_permission(User_permission.ADD_EDIT_TRANSMISSION))
				is_updated = Transmission_ds.Update_insert_transmission();

			Setup_grd_transmission();

			if (!is_deleted)
				MessageBox.Show("One or more transmission cannot be deleted because there are vehicle models applying this transmission",
					"Some items cannot be deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (is_updated && is_deleted)
				MessageBox.Show("All items have been saved successfully.", "Item saved", MessageBoxButtons.OK);
		}
		#endregion
		#region COLOR
		private void Setup_form_color()
		{
			// user will be editing straight to cell so no need display these two
			editToolStripMenuItem.Visible = false;
			addToolStripMenuItem.Visible = false;

			if (Program.System_user.Has_permission(User_permission.ADD_EDIT_COLOR))
			{
				grd_main.ReadOnly = false;
				grd_main.AllowUserToAddRows = true;
			}
			grd_main.AllowUserToDeleteRows =
				Program.System_user.Has_permission(User_permission.DELETE_COLOR);

			ts_save_only.Visible = true;

			Setup_grd_color();
			btn_save.Click += Btn_save_color_Click;
			deleteToolStripMenuItem.Click += Delete_grd_main_row;
		}
		private void Setup_grd_color()
		{
			Color_ds.sp_select_colorDataTable dttable = Color_ds.Select_color();

			dttable.Columns["modified_by"].DefaultValue = Program.System_user.Name;
			dttable.Columns["modified_by"].ReadOnly = true;

			Class_datagridview.Setup_and_preselect(grd_main, dttable, "color_name");

			grd_main.AutoResizeColumns();

			grd_main.Columns["modified_by"].DefaultCellStyle.BackColor = Color.LightGray;
			((DataGridViewTextBoxColumn)grd_main.Columns["color_name"]).MaxInputLength = 20;

			if (!Program.System_user.IsDeveloper)
				Class_datagridview.Hide_columns(grd_main, new string[] { "color" });
		}
		private void Btn_save_color_Click(object sender, EventArgs e)
		{
			Class_datagridview.Apply_all_changes(grd_main);

			DataTable dttable = Class_datatable.Remove_unnecessary_columns(((DataTable)grd_main.DataSource).Copy(),
				new string[] { "color", "color_name" });

			if (dttable.Select().GroupBy(c => c["color_name"].ToString().ToUpper()).Where(c => c.Count() > 1).Count() > 0)
			{
				MessageBox.Show("Duplicate color_names are not allowed", "Invalid input",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

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
						bulkCopy.ColumnMappings.Add("color", "int1");
						bulkCopy.ColumnMappings.Add("color_name", "nvarchar1");
						bulkCopy.ColumnMappings.Add("modified_by", "created_by");
						bulkCopy.WriteToServer(dttable);
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error has occurred. \n\n Message: " + ex.Message,
							"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
						conn.Close();
						return;
					}
				}
				conn.Close();
			}

			// insert, update and delete transmission
			bool is_deleted = true;
			bool is_updated = true;

			if (Program.System_user.Has_permission(User_permission.DELETE_COLOR))
				is_deleted = Color_ds.Delete_color();

			if (Program.System_user.Has_permission(User_permission.ADD_EDIT_COLOR))
				is_updated = Color_ds.Update_insert_color();

			Setup_grd_color();

			if (!is_deleted)
				MessageBox.Show("One or more color cannot be deleted because there are items applying this color.",
					"Some items cannot be deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (is_updated && is_deleted)
				MessageBox.Show("All items have been saved successfully.", "Item saved", MessageBoxButtons.OK);

		}
		#endregion
		#region SALESPERSON
		private void Setup_form_edit_salesperson()
		{
			ts_add_edit_delete.Visible = true;
			Setup_cmb_is_active();

			bool has_add_edit_permission = Program.System_user.Has_permission(User_permission.ADD_EDIT_SALESPERSON);
			bool has_delete_permission = Program.System_user.Has_permission(User_permission.ADD_USER);

			btn_add.Enabled = has_add_edit_permission;
			btn_edit.Enabled = has_add_edit_permission;
			btn_delete.Enabled = has_add_edit_permission;

			Setup_grd_salesperson();

			txt_search.TextChanged += (sender2, e2) => Setup_grd_salesperson();
			cmb_status.ComboBox.SelectedIndexChanged += (sender2, e2) => Setup_grd_salesperson();
			btn_add.Click += Add_salesperson;
			addToolStripMenuItem.Click += Add_salesperson;
			btn_edit.Click += Edit_salesperson;
			editToolStripMenuItem.Click += Edit_salesperson;
		}
		private void Setup_grd_salesperson(int int_salesperson = 0)
		{
			grd_main.DataSource = null;

			Salesperson_ds.sp_select_salespersonDataTable dttable = Salesperson_ds.Select_salesperson();

			string str_search = txt_search.Text.Trim();
			if (str_search == "")
				grd_main.DataSource = dttable;
			else
			{
				var query = from row in dttable
							where row.name.Contains(str_search) || row.registration_no.Contains(str_search) || row.location.Contains(str_search)
							select row;

				if (query.Count() > 0)
					grd_main.DataSource = query.CopyToDataTable();
				else
					grd_main.DataSource = new Salesperson_ds.sp_select_salespersonDataTable();
			}

			if (int_salesperson != 0)
				Class_datagridview.Select_row_by_value(grd_main, "salesperson", int_salesperson.ToString());
		}
		private void Add_salesperson(object sender, EventArgs e)
		{
			Form_person_organisation form_select_person_org = new Form_person_organisation();

			if (form_select_person_org.ShowDialog() != DialogResult.OK) return;

			bool is_person = (form_select_person_org.SelectedType == "PERSON") ? true : false;

			Form_edit_salesperson form_salesperson = new Form_edit_salesperson(form_select_person_org.SelectedID, is_person);

			if (form_salesperson.ShowDialog() != DialogResult.OK) return;

			Setup_grd_salesperson();
		}
		private void Edit_salesperson(object sender, EventArgs e)
		{

		}
		#endregion
		#region FINANCE
		private void Setup_form_finance()
		{

		}
		private void Txt_search_finance_TextChanged(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
