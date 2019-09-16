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

			Class_style.Grd_style.Common_style(grd_main);

			switch (this.Tag.ToString().ToUpper())
			{
				case "USER":
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
						!Program.System_user.Has_permission(User_permission.VIEW_SALESPERSON))
						permission_denied = true;
					else
						Setup_form_salesperson();
					break;
				case "FINANCE":
					if (!Program.System_user.Has_permission(User_permission.ADD_EDIT_FINANCE))
						permission_denied = true;
					else
						Setup_form_finance();
					break;
				case "VEHICLE":
					if (!Program.System_user.Has_permission(User_permission.VEHICLE_VIEW) &&
						!Program.System_user.Has_permission(User_permission.VEHICLE_ADD_EDIT) &&
						!Program.System_user.Has_permission(User_permission.VEHICLE_DELETE))
						permission_denied = true;
					else
						Setup_form_vehicle();
					break;
			}

			if (permission_denied)
			{
				MessageBox.Show("ACCESS DENIED", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}
		}
		private void Delete_grd_main_row(object sender, EventArgs e)
		{
			if (grd_main.CurrentCell != null)
				grd_main.Rows.Remove(grd_main.CurrentCell.OwningRow);
		}
		private void Setup_cmb_is_active(ComboBox cmb)
		{
			DataTable dttable_active = new DataTable();
			dttable_active.Columns.Add("display", typeof(string));
			dttable_active.Columns.Add("value", typeof(int));

			dttable_active.Rows.Add("All", -1);
			dttable_active.Rows.Add("Active", 1);
			dttable_active.Rows.Add("Inactive", 0);

			cmb.DisplayMember = "display";
			cmb.ValueMember = "value";
			cmb.DataSource = dttable_active;
			cmb.SelectedValue = 1; // select active as default
		}
		#region USERS
		private void Setup_form_users()
		{
			ts_user.Visible = true;

			deleteToolStripMenuItem.Visible = false; // cannot delete user
			btn_delete_user.Visible = false;

			Setup_cmb_is_active(cmb_is_active_user.ComboBox);

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

			DataColumn dt_col = new DataColumn("modified_by")
			{
				DefaultValue = Program.System_user.UserID
			};

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

			dttable.Columns.Add(new DataColumn("modified_by") { DefaultValue = Program.System_user.UserID });

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

			dttable.Columns.Add(new DataColumn("modified_by") { DefaultValue = Program.System_user.UserID });

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
		private void Setup_form_salesperson()
		{
			ts_add_edit_delete.Visible = true;
			Setup_cmb_is_active(cmb_status.ComboBox);

			bool has_add_edit_permission = Program.System_user.Has_permission(User_permission.ADD_EDIT_SALESPERSON);

			btn_add.Enabled = has_add_edit_permission;
			btn_edit.Enabled = has_add_edit_permission;
			addToolStripMenuItem.Enabled = has_add_edit_permission;
			editToolStripMenuItem.Enabled = has_add_edit_permission;

			btn_delete.Visible = false; // salesperson cannot be deleted
			deleteToolStripMenuItem.Visible = false;

			Setup_grd_salesperson();

			txt_search.TextChanged += (sender2, e2) => Apply_filter_salesperson();
			cmb_status.ComboBox.SelectedIndexChanged += (sender2, e2) => Apply_filter_salesperson();
			btn_add.Click += Add_salesperson;
			addToolStripMenuItem.Click += Add_salesperson;
			btn_edit.Click += Edit_salesperson;
			editToolStripMenuItem.Click += Edit_salesperson;
		}
		private void Setup_grd_salesperson(int int_salesperson = 0)
		{
			grd_main.DataSource = null;

			Salesperson_ds.sp_select_salespersonDataTable dttable = Salesperson_ds.Select_salesperson(-1);

			grd_main.DataSource = dttable;

			Class_datagridview.Hide_unnecessary_columns(grd_main, new string[] { "name",
				"registration_no", "location", "date_join", "date_leave", "remark" });

			grd_main.AutoResizeColumns();
			Apply_filter_salesperson();

			if (int_salesperson != 0)
				Class_datagridview.Select_row_by_value(grd_main, "salesperson", int_salesperson.ToString());
		}
		private void Add_salesperson(object sender, EventArgs e)
		{
			Form_person_organisation form_select_person_org = new Form_person_organisation("SALESPERSON");

			if (form_select_person_org.ShowDialog() != DialogResult.OK) return;

			bool is_person = (form_select_person_org.SelectedType == "PERSON") ? true : false;

			Form_edit_salesperson form_edit = new Form_edit_salesperson(is_person ? form_select_person_org.SelectedID : form_select_person_org.SelectedBranchID, is_person);

			if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_salesperson(form_edit.SalespersonID);
		}
		private void Edit_salesperson(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;

			Form_edit_salesperson form_edit = new Form_edit_salesperson((int)grd_main.SelectedCells[0].OwningRow.Cells["salesperson"].Value);

			if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_salesperson(form_edit.SalespersonID);
		}
		private void Apply_filter_salesperson()
		{
			if (grd_main.DataSource == null) return;

			string str_search = txt_search.Text.Trim();

			string str_filter = "[name] LIKE '%" + str_search + "%' OR [registration_no] LIKE '%" +
				str_search + "%' OR [location] LIKE '%" + str_search +
				"%' OR [remark] LIKE '%" + str_search + "%'";

			string str_today = DateTime.Today.ToShortDateString();

			if ((int)cmb_status.ComboBox.SelectedValue == 1)
			{
				str_filter = "(" + str_filter + ") AND [date_join] <= '" + str_today +
					"' AND ('" + str_today + "' < [date_leave] OR [date_leave] IS NULL) ";
			}
			else if ((int)cmb_status.ComboBox.SelectedValue == 0)
			{
				str_filter = "(" + str_filter + ") AND ('" + str_today +
					"' < [date_join] OR [date_leave] <= '" + str_today + "')";
			}

			((DataTable)grd_main.DataSource).DefaultView.RowFilter = str_filter;
		}
		#endregion
		#region FINANCE
		private void Setup_form_finance()
		{
			ts_add_edit_delete.Visible = true;

			// finance does not have active or inactive
			lbl_status.Visible = false;
			cmb_status.Visible = false;

			btn_delete.Visible = false; // finance cannot be deleted
			deleteToolStripMenuItem.Visible = false;

			bool has_add_edit_permission = Program.System_user.Has_permission(User_permission.ADD_EDIT_FINANCE);

			btn_add.Enabled = has_add_edit_permission;
			btn_edit.Enabled = has_add_edit_permission;
			addToolStripMenuItem.Enabled = has_add_edit_permission;
			editToolStripMenuItem.Enabled = has_add_edit_permission;

			Setup_grd_finance();

			txt_search.TextChanged += (sender2, e2) => Apply_filter_finance();
			btn_add.Click += Add_finance;
			addToolStripMenuItem.Click += Add_finance;
			btn_edit.Click += Edit_finance;
			editToolStripMenuItem.Click += Edit_finance;
		}
		private void Setup_grd_finance(int int_finance = 0)
		{
			grd_main.DataSource = null;

			grd_main.DataSource = Finance_ds.Select_finance(-1);

			Class_datagridview.Hide_unnecessary_columns(grd_main, "name", "branch_name", "registration_no",
				"address", "city", "state", "postcode", "country_name", "url", "remark");

			grd_main.AutoResizeColumns();
			Apply_filter_finance();

			if (int_finance != 0)
				Class_datagridview.Select_row_by_value(grd_main, "finance", int_finance.ToString());
		}
		private void Apply_filter_finance()
		{
			if (grd_main.DataSource == null) return;

			string str_search = txt_search.Text.Trim();

			string str_filter = "[name] LIKE '%" + str_search + "%' OR [registration_no] LIKE '%" +
				str_search + "%' OR [branch_name] LIKE '%" + str_search +
				"%' OR [remark] LIKE '%" + str_search + "%'";

			((DataTable)grd_main.DataSource).DefaultView.RowFilter = str_filter;
		}
		private void Add_finance(object sender, EventArgs e)
		{
			Form_person_organisation form_select_person_org = new Form_person_organisation("FINANCE");

			if (form_select_person_org.ShowDialog() != DialogResult.OK) return;

			Form_edit_finance form_edit = new Form_edit_finance(form_select_person_org.SelectedBranchID);

			if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_finance(form_select_person_org.SelectedBranchID);
		}
		private void Edit_finance(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;

			int int_org_id = (int)grd_main.SelectedCells[0].OwningRow.Cells["finance"].Value;

			Form_edit_finance form_edit = new Form_edit_finance(int_org_id);

			if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_finance(int_org_id);
		}
		#endregion
		#region VEHICLE
		private void Setup_form_vehicle()
		{
			ts_vehicle.Visible = true;

			cmb_vehicle_acquire.SelectedItem = "ALL";
			cmb_vehicle_status.SelectedItem = "ALL";

			bool has_add_edit_permission = Program.System_user.Has_permission(User_permission.VEHICLE_ADD_EDIT);
			bool has_delete_permission = Program.System_user.Has_permission(User_permission.VEHICLE_DELETE);

			btn_add_vehicle.Enabled = has_add_edit_permission;
			btn_edit_vehicle.Enabled = has_add_edit_permission;
			btn_delete_vehicle.Enabled = has_delete_permission;

			addToolStripMenuItem.Enabled = has_add_edit_permission;
			editToolStripMenuItem.Enabled = has_add_edit_permission;
			deleteToolStripMenuItem.Enabled = has_delete_permission;

			Setup_grd_vehicle();

			txt_search_vehicle.TextChanged += (sender2, e2) => Apply_filter_vehicle();
			cmb_vehicle_acquire.ComboBox.SelectedIndexChanged += (sender2, e2) => Apply_filter_vehicle();
			cmb_vehicle_status.ComboBox.SelectedIndexChanged += (sender2, e2) => Apply_filter_vehicle();

			btn_add_vehicle.Click += Add_vehicle;
			addToolStripMenuItem.Click += Add_vehicle;
			btn_edit_vehicle.Click += Edit_vehicle;
			editToolStripMenuItem.Click += Edit_vehicle;
			btn_delete_vehicle.Click += Delete_vehicle;
			deleteToolStripMenuItem.Click += Delete_vehicle;
		}
		private void Setup_grd_vehicle(int int_vehicle = 0)
		{
			grd_main.DataSource = null;
			grd_main.DataSource = Vehicle_ds.Select_vehicle();

			Class_datagridview.Hide_columns(grd_main, new string[] { "vehicle" });
			grd_main.AutoResizeColumns();

			Apply_filter_vehicle();

			if (int_vehicle != 0)
				Class_datagridview.Select_row_by_value(grd_main, "vehicle", int_vehicle.ToString());
		}
		private void Apply_filter_vehicle()
		{
			if (grd_main.DataSource == null) return;

			string str_search = txt_search_vehicle.Text.Trim();

			string str_filter = "[registration_no] LIKE '%" + str_search +
				"%' OR [seller_name] LIKE '%" + str_search + "%' OR [vehicle_model] LIKE '%" + str_search +
				"%' OR [location] LIKE '%" + str_search + "%' OR [chassis_no] LIKE '%" + str_search +
				"%' OR [engine_no] LIKE '%" + str_search + "%'";

			// if specific vehicle acquire method selected, filter dgv
			if (cmb_vehicle_acquire.SelectedItem.ToString() != "ALL")
				str_filter = "(" + str_filter + ") AND [acquire_method] = '" +
					cmb_vehicle_acquire.SelectedItem.ToString() + "'";

			if (cmb_vehicle_status.SelectedItem.ToString() != "ALL")
				str_filter = "(" + str_filter + ") AND [vehicle_status] = '" +
					cmb_vehicle_status.SelectedItem.ToString() + "'";

			((DataTable)grd_main.DataSource).DefaultView.RowFilter = str_filter;
		}
		private void Add_vehicle(object sender, EventArgs e)
		{

		}
		private void Edit_vehicle(object sender, EventArgs e)
		{

		}
		private void Delete_vehicle(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
