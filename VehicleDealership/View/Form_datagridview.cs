using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
			foreach (ToolStripMenuItem ts in cms_grd_main.Items)
			{
				ts.Visible = false;
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

			this.Text = this.Tag.ToString().ToUpper();

			switch (this.Tag.ToString().ToUpper())
			{
				case "USER":
					addToolStripMenuItem.Visible = true;
					editToolStripMenuItem.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.ADD_USER) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.EDIT_USER))
						permission_denied = true;
					else
						Setup_form_users();
					break;
				case "FUEL TYPE":
					// user will be editing straight to cell so display delete only
					deleteToolStripMenuItem.Visible = true;
					lbl_edit_will_affect_all.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_FUEL_TYPE) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.DELETE_FUEL_TYPE))
						permission_denied = true;
					else
						Setup_form_fuel_type();
					break;
				case "TRANSMISSION":
					// user will be editing straight to cell so display delete only
					deleteToolStripMenuItem.Visible = true;
					lbl_edit_will_affect_all.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_TRANSMISSION) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.DELETE_TRANSMISSION))
						permission_denied = true;
					else
						Setup_form_transmission();
					break;
				case "COLOUR":
					// user will be editing straight to cell so display delete only
					deleteToolStripMenuItem.Visible = true;
					lbl_edit_will_affect_all.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_COLOUR) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.DELETE_COLOUR))
						permission_denied = true;
					else
						Setup_form_colour();
					break;
				case "SALESPERSON":
					// salesperson cannot be deleted for now...
					addToolStripMenuItem.Visible = true;
					editToolStripMenuItem.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_SALESPERSON) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.VIEW_SALESPERSON))
						permission_denied = true;
					else
						Setup_form_salesperson();
					break;
				case "FINANCE":
					// finance cannot be deleted for now...
					addToolStripMenuItem.Visible = true;
					editToolStripMenuItem.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_FINANCE))
						permission_denied = true;
					else
						Setup_form_finance();
					break;
				case "INSURANCE":
					addToolStripMenuItem.Visible = true;
					editToolStripMenuItem.Visible = true;
					deleteToolStripMenuItem.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_ADD_EDIT) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_DELETE))
						permission_denied = true;
					else
						Setup_form_finance();
					break;
				case "LOAN":
					addToolStripMenuItem.Visible = true;
					editToolStripMenuItem.Visible = true;
					deleteToolStripMenuItem.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.LOAN_ADD_EDIT) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.LOAN_DELETE))
						permission_denied = true;
					else
						Setup_form_finance(); // TODO
					break;
				case "VEHICLE":
					addToolStripMenuItem.Visible = true;
					editToolStripMenuItem.Visible = true;
					deleteToolStripMenuItem.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_VIEW) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_ADD_EDIT) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_DELETE))
						permission_denied = true;
					else
						Setup_form_vehicle();
					break;
				case "VEHICLE SALE":
					addToolStripMenuItem.Visible = true;
					editToolStripMenuItem.Visible = true;
					deleteToolStripMenuItem.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_SALE_ADD_EDIT) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_SALE_DELETE))
						permission_denied = true;
					else
						Setup_form_vehicle_sale();
					break;
				case "VEHICLE RETURN":
					addToolStripMenuItem.Visible = true;
					editToolStripMenuItem.Visible = true;
					deleteToolStripMenuItem.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_VIEW) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_RETURN_ADD_EDIT) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_RETURN_DELETE))
						permission_denied = true;
					else
						Setup_form_vehicle_return();
					break;
				case "LOCATION":
					// user will be editing straight to cell so display delete only
					deleteToolStripMenuItem.Visible = true;
					lbl_edit_will_affect_all.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.LOCATION_ADD_EDIT) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.LOCATION_DELETE))
						permission_denied = true;
					else
						Setup_form_location();
					break;
				case "INSURANCE_TYPE":
					// user will be editing straight to cell so display delete only
					deleteToolStripMenuItem.Visible = true;
					lbl_edit_will_affect_all.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_ADD_EDIT) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_DELETE))
						permission_denied = true;
					else
						Setup_form_insurance_type();
					break;
				case "INSURANCE_CATEGORY":
					// user will be editing straight to cell so display delete only
					deleteToolStripMenuItem.Visible = true;

					if (!Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_ADD_EDIT) &&
						!Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_DELETE))
						permission_denied = true;
					else
						Setup_form_insurance_category();
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
			cmb_is_active_user.SelectedIndex = 0;

			if (Program.System_user.Has_permission(Class_enum.User_permission.EDIT_USER))
			{
				btn_edit_user.Enabled = true;
				editToolStripMenuItem.Enabled = true;
				btn_activate_user.Enabled = true;
				btn_deactivate_user.Enabled = true;
			}
			if (Program.System_user.Has_permission(Class_enum.User_permission.ADD_USER))
			{
				btn_add_user.Enabled = true;
				addToolStripMenuItem.Enabled = true;
			}

			Setup_grd_users();

			txt_search_user.TextChanged += (sender2, e2) => Apply_filter_user();
			cmb_is_active_user.ComboBox.SelectedIndexChanged += (sender2, e2) => Apply_filter_user();

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

			if (Program.System_user.IsDeveloper)
			{
				Class_datagridview.Setup_and_preselect(grd_main, User_ds.Select_user_all(), "user");
			}
			else
			{
				Class_datagridview.Setup_and_preselect(grd_main, User_ds.Select_user_all(), "user",
					new string[] { "username", "name", "ic_no", "usergroup",
						"ic_no", "is_active", "join_date", "leave_date" });
			}

			//Apply_filter_user();
			grd_main.AutoResizeColumns();

			Setup_buttons_enable();
			grd_main.RowEnter += Grd_users_RowEnter;
		}
		private void Apply_filter_user()
		{
			string str_search = txt_search_user.Text.Trim();

			string str_filter = "[username] LIKE '%" + str_search +
				"%' OR [name] LIKE '%" + str_search +
				"%' OR [usergroup] LIKE '%" + str_search +
				"%' OR [ic_no] LIKE '%" + str_search + "%'";

			if (cmb_is_active_user.ComboBox.SelectedItem.ToString() != "ALL")
			{
				str_filter = "(" + str_filter + ") AND [is_active] = '" +
					cmb_is_active_user.ComboBox.SelectedItem.ToString() + "'";
			}

			((DataTable)grd_main.DataSource).DefaultView.RowFilter = str_filter;
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

			using (Form_edit_users form_edit = new Form_edit_users(int_user))
			{
				if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_users();
			}
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
			if (Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_FUEL_TYPE))
			{
				grd_main.ReadOnly = false;
				grd_main.AllowUserToAddRows = true;
			}
			deleteToolStripMenuItem.Enabled = false; // default
			if (Program.System_user.Has_permission(Class_enum.User_permission.DELETE_FUEL_TYPE))
			{
				grd_main.AllowUserToDeleteRows = true;
				deleteToolStripMenuItem.Enabled = true;
			}

			ts_save_only.Visible = true;
			Setup_grd_fuel_type();
			btn_save.Click += Btn_save_fuel_type_Click;
			deleteToolStripMenuItem.Click += Delete_grd_main_row;
		}
		private void Setup_grd_fuel_type()
		{
			Fuel_type_ds.sp_select_fuel_typeDataTable dttable = Fuel_type_ds.Select_fuel_type();

			dttable.modified_byColumn.DefaultValue = Program.System_user.Name;
			dttable.modified_byColumn.ReadOnly = true;

			Class_datagridview.Setup_and_preselect(grd_main, dttable, "fuel_type_name");

			grd_main.AutoResizeColumns();
			grd_main.Columns["fuel_type"].DefaultCellStyle.BackColor = Color.LightGray;
			grd_main.Columns["modified_by"].DefaultCellStyle.BackColor = Color.LightGray;
			Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_main, "fuel_type_name");
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

			if (Program.System_user.Has_permission(Class_enum.User_permission.DELETE_FUEL_TYPE))
				is_deleted = Fuel_type_ds.Delete_fuel_type();

			if (Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_FUEL_TYPE))
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
			if (Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_TRANSMISSION))
			{
				grd_main.ReadOnly = false;
				grd_main.AllowUserToAddRows = true;
			}
			deleteToolStripMenuItem.Enabled = false; // default
			if (Program.System_user.Has_permission(Class_enum.User_permission.DELETE_TRANSMISSION))
			{
				grd_main.AllowUserToDeleteRows = true;
				deleteToolStripMenuItem.Enabled = true;
			}

			ts_save_only.Visible = true;

			Setup_grd_transmission();
			btn_save.Click += Btn_save_transmission_Click;
			deleteToolStripMenuItem.Click += Delete_grd_main_row;
		}
		private void Setup_grd_transmission()
		{
			Transmission_ds.sp_select_transmissionDataTable dttable = Transmission_ds.Select_transmission();

			dttable.modified_byColumn.DefaultValue = Program.System_user.Name;
			dttable.modified_byColumn.ReadOnly = true;

			Class_datagridview.Setup_and_preselect(grd_main, dttable, "transmission_name");

			grd_main.AutoResizeColumns();
			grd_main.Columns["transmission"].DefaultCellStyle.BackColor = Color.LightGray;
			grd_main.Columns["modified_by"].DefaultCellStyle.BackColor = Color.LightGray;
			Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_main, "transmission_name");
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

			if (Program.System_user.Has_permission(Class_enum.User_permission.DELETE_TRANSMISSION))
				is_deleted = Transmission_ds.Delete_transmission();

			if (Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_TRANSMISSION))
				is_updated = Transmission_ds.Update_insert_transmission();

			Setup_grd_transmission();

			if (!is_deleted)
				MessageBox.Show("One or more transmission cannot be deleted because there are vehicle models applying this transmission",
					"Some items cannot be deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else if (is_updated && is_deleted)
				MessageBox.Show("All items have been saved successfully.", "Item saved", MessageBoxButtons.OK);
		}
		#endregion
		#region COLOUR
		private void Setup_form_colour()
		{
			if (Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_COLOUR))
			{
				grd_main.ReadOnly = false;
				grd_main.AllowUserToAddRows = true;
			}
			deleteToolStripMenuItem.Enabled = false; // default
			if (Program.System_user.Has_permission(Class_enum.User_permission.DELETE_COLOUR))
			{
				grd_main.AllowUserToDeleteRows = true;
				deleteToolStripMenuItem.Enabled = true;
			}

			ts_save_only.Visible = true;
			Setup_grd_colour();
			btn_save.Click += Btn_save_colour_Click;
			deleteToolStripMenuItem.Click += Delete_grd_main_row;
		}
		private void Setup_grd_colour()
		{
			Colour_ds.sp_select_colourDataTable dttable = Colour_ds.Select_colour();
			dttable.Columns.Remove("modified_by"); // no need this

			Class_datagridview.Setup_and_preselect(grd_main, dttable, "colour_name");

			grd_main.AutoResizeColumns();
			grd_main.Columns["colour"].DefaultCellStyle.BackColor = Color.LightGray;
			Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_main, "colour_name");
		}
		private void Btn_save_colour_Click(object sender, EventArgs e)
		{
			Class_datagridview.Apply_all_changes(grd_main);

			DataTable dttable = Class_datatable.Remove_unnecessary_columns(((DataTable)grd_main.DataSource).Copy(),
				new string[] { "colour", "colour_name" });

			if (dttable.Select().GroupBy(c => c["colour_name"].ToString().ToUpper()).Where(c => c.Count() > 1).Count() > 0)
			{
				MessageBox.Show("Duplicate colour names are not allowed", "Invalid input",
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
						bulkCopy.ColumnMappings.Add("colour", "int1");
						bulkCopy.ColumnMappings.Add("colour_name", "nvarchar1");
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

			if (Program.System_user.Has_permission(Class_enum.User_permission.DELETE_COLOUR))
				is_deleted = Colour_ds.Delete_colour();

			if (Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_COLOUR))
				is_updated = Colour_ds.Update_insert_colour();

			Setup_grd_colour();

			if (!is_deleted)
				MessageBox.Show("One or more colour cannot be deleted because there are items applying this colour.",
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

			bool has_add_edit_permission = Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_SALESPERSON);

			btn_add.Enabled = has_add_edit_permission;
			btn_edit.Enabled = has_add_edit_permission;
			addToolStripMenuItem.Enabled = has_add_edit_permission;
			editToolStripMenuItem.Enabled = has_add_edit_permission;

			btn_delete.Visible = false; // salesperson cannot be deleted

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
				Class_datagridview.Select_row_by_value(grd_main, "salesperson", int_salesperson);
		}
		private void Add_salesperson(object sender, EventArgs e)
		{
			using (Form_person_organisation form_select_person_org = new Form_person_organisation("SALESPERSON"))
			{
				if (form_select_person_org.ShowDialog() != DialogResult.OK) return;

				bool is_person = (form_select_person_org.SelectedType == "PERSON") ? true : false;

				using (Form_edit_salesperson form_edit = new Form_edit_salesperson(is_person ? form_select_person_org.SelectedID : form_select_person_org.SelectedBranchID, is_person))
				{
					if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_salesperson(form_edit.SalespersonID);
				}
			}
		}
		private void Edit_salesperson(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;

			using (Form_edit_salesperson form_edit = new Form_edit_salesperson((int)grd_main.SelectedCells[0].OwningRow.Cells["salesperson"].Value))
			{
				if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_salesperson(form_edit.SalespersonID);
			}
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
		#region FINANCE / INSURANCE / LOAN
		private void Setup_form_finance()
		{
			ts_add_edit_delete.Visible = true;

			// finance / insurance does not have active or inactive
			lbl_status.Visible = false;
			cmb_status.Visible = false;

			bool has_add_edit_permission = Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_FINANCE);
			bool has_delete_permission = false; // TODO: create permission to delete finance

			switch (this.Tag.ToString().ToUpper())
			{
				case "INSURANCE":
					has_add_edit_permission = Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_ADD_EDIT);
					has_delete_permission = Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_DELETE);
					break;
				case "LOAN":
					has_add_edit_permission = Program.System_user.Has_permission(Class_enum.User_permission.LOAN_ADD_EDIT);
					has_delete_permission = Program.System_user.Has_permission(Class_enum.User_permission.LOAN_DELETE);
					break;
			}

			btn_add.Enabled = has_add_edit_permission;
			btn_edit.Enabled = has_add_edit_permission;
			addToolStripMenuItem.Enabled = has_add_edit_permission;
			editToolStripMenuItem.Enabled = has_add_edit_permission;
			btn_delete.Enabled = has_delete_permission;
			deleteToolStripMenuItem.Enabled = has_delete_permission;

			Setup_grd_finance();

			txt_search.TextChanged += (sender2, e2) => Apply_filter_finance();
			btn_add.Click += Add_finance;
			addToolStripMenuItem.Click += Add_finance;
			btn_edit.Click += Edit_finance;
			editToolStripMenuItem.Click += Edit_finance;
			btn_delete.Click += Delete_finance;
			deleteToolStripMenuItem.Click += Delete_finance;
		}
		private void Setup_grd_finance(int int_id = 0)
		{
			grd_main.DataSource = null;

			switch (this.Tag.ToString().ToUpper())
			{
				case "FINANCE":
					grd_main.DataSource = Finance_ds.Select_finance(-1);
					break;
				case "INSURANCE":
					grd_main.DataSource = Insurance_ds.Select_insurance(-1);
					break;
				case "LOAN":
					grd_main.DataSource = Loan_ds.Select_loan(-1);
					break;
			}

			Class_datagridview.Hide_unnecessary_columns(grd_main, "name", "branch_name", "registration_no",
				"address", "city", "state", "postcode", "country_name", "url", "remark");

			grd_main.AutoResizeColumns();
			Apply_filter_finance();

			if (int_id != 0)
				Class_datagridview.Select_row_by_value(grd_main, this.Tag.ToString().ToLower(), int_id);
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
			using (Form_person_organisation form_select_person_org =
				new Form_person_organisation(this.Tag.ToString().ToUpper()))
			{
				if (form_select_person_org.ShowDialog() != DialogResult.OK) return;

				using (Form_edit_finance form_edit = new Form_edit_finance(form_select_person_org.SelectedBranchID, this.Tag.ToString().ToUpper()))
				{
					if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_finance(form_select_person_org.SelectedBranchID);
				}
			}
		}
		private void Edit_finance(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;

			int int_org_id = (int)grd_main.SelectedCells[0].OwningRow.Cells["finance"].Value;

			using (Form_edit_finance form_edit = new Form_edit_finance(int_org_id, this.Tag.ToString().ToUpper()))
			{
				if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_finance(int_org_id);
			}
		}
		private void Delete_finance(object sender, EventArgs e)
		{
			// TODO
			MessageBox.Show("This feature is not available yet.", "",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion
		#region VEHICLE
		private void Setup_form_vehicle()
		{
			ts_vehicle.Visible = true;
			btn_print_vehicle_out.Visible = false;

			cmb_vehicle_acquire.SelectedItem = "ALL";
			cmb_vehicle_status.SelectedItem = "ALL";

			bool has_add_edit_permission = Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_ADD_EDIT);
			bool has_delete_permission = Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_DELETE);

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
			grd_main.DataSource = Vehicle_ds.Select_vehicle_simplified();

			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_columns(grd_main, new string[] { "vehicle" });
			grd_main.AutoResizeColumns();

			Apply_filter_vehicle();

			if (int_vehicle != 0)
				Class_datagridview.Select_row_by_value(grd_main, "vehicle", int_vehicle);
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
			using (Form_edit_vehicle form_edit = new Form_edit_vehicle())
			{
				if (form_edit.ShowDialog() == DialogResult.OK)
					Setup_grd_vehicle(form_edit.VehicleID);
			}
		}
		private void Edit_vehicle(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;

			int int_vehicle_id = (int)grd_main.SelectedCells[0].OwningRow.Cells["vehicle"].Value;

			using (Form_edit_vehicle form_edit = new Form_edit_vehicle(int_vehicle_id))
			{
				if (form_edit.ShowDialog() == DialogResult.OK) Setup_grd_vehicle(int_vehicle_id);
			}
		}
		private void Delete_vehicle(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;
			if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				int vehicle_id = (int)grd_main.SelectedCells[0].OwningRow.Cells["vehicle"].Value;
				if (Vehicle_ds.Delete_vehicle(vehicle_id))
				{
					try
					{
						Directory.Delete(Path.Combine(Filepath_ds.Select_filepath_dir("VEHICLE_UPLOAD"), vehicle_id.ToString()), true);
					}
					catch (Exception)
					{
						// ignore error
					}
					Setup_grd_vehicle();
				}
				else
				{
					MessageBox.Show("Delete failed. Possible reasons :- \n - Have sale/return record.",
						"Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
		private void VehicleReceivedNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;

			Cursor = Cursors.WaitCursor;
			using (Crystal_report.CR_vehicle_received_note cr_report = new Crystal_report.CR_vehicle_received_note())
			{
				cr_report.SetDataSource(Vehicle_ds.Vehicle_incoming_doc((int)grd_main.SelectedCells[0].OwningRow.Cells["vehicle"].Value).CopyToDataTable());

				using (Crystal_report.Form_crystal_report dlg_cr = new Crystal_report.Form_crystal_report(cr_report))
				{
					dlg_cr.Text = "Vehicle Received Note";
					dlg_cr.ShowDialog();
				}
			}
			Cursor = Cursors.Default;
		}
		private void EvidenceOfPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;

			Cursor = Cursors.WaitCursor;
			using (Crystal_report.CR_evidence_of_purchase cr_report = new Crystal_report.CR_evidence_of_purchase())
			{
				cr_report.SetDataSource(Vehicle_ds.Vehicle_incoming_doc((int)grd_main.SelectedCells[0].OwningRow.Cells["vehicle"].Value).CopyToDataTable());

				using (Crystal_report.Form_crystal_report dlg_cr = new Crystal_report.Form_crystal_report(cr_report))
				{
					dlg_cr.Text = "Evidence of Purchase";
					dlg_cr.ShowDialog();
				}
			}
			Cursor = Cursors.Default;
		}
		private void HirePurchaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;

			Cursor = Cursors.WaitCursor;
			using (Crystal_report.CR_hire_purchase cr_report = new Crystal_report.CR_hire_purchase())
			{
				cr_report.SetDataSource(Vehicle_ds.Vehicle_incoming_doc((int)grd_main.SelectedCells[0].OwningRow.Cells["vehicle"].Value).CopyToDataTable());

				using (Crystal_report.Form_crystal_report dlg_cr = new Crystal_report.Form_crystal_report(cr_report))
				{
					dlg_cr.Text = "Hire Purchase";
					dlg_cr.ShowDialog();
				}
			}
			Cursor = Cursors.Default;
		}
		private void SalesPurchaseAgreementToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;

			Cursor = Cursors.WaitCursor;
			using (Crystal_report.CR_sales_n_purchase_agreement cr_report = new Crystal_report.CR_sales_n_purchase_agreement())
			{
				cr_report.SetDataSource(Vehicle_ds.Vehicle_incoming_doc((int)grd_main.SelectedCells[0].OwningRow.Cells["vehicle"].Value).CopyToDataTable());

				using (Crystal_report.Form_crystal_report dlg_cr = new Crystal_report.Form_crystal_report(cr_report))
				{
					dlg_cr.Text = "Sales & Purchase Agreement";
					dlg_cr.ShowDialog();
				}
			}
			Cursor = Cursors.Default;
		}
		#endregion
		#region VEHICLE SALE
		private void Setup_form_vehicle_sale()
		{
			ts_vehicle.Visible = true;
			btn_print_vehicle_in.Visible = false;
			cmb_vehicle_status.Visible = false; // all vehicles are sold status.

			cmb_vehicle_acquire.SelectedItem = "ALL";

			bool has_add_edit_permission = Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_SALE_ADD_EDIT);
			bool has_delete_permission = Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_SALE_DELETE);

			btn_add_vehicle.Enabled = has_add_edit_permission;
			btn_edit_vehicle.Enabled = has_add_edit_permission;
			btn_delete_vehicle.Enabled = has_delete_permission;

			addToolStripMenuItem.Enabled = has_add_edit_permission;
			editToolStripMenuItem.Enabled = has_add_edit_permission;
			deleteToolStripMenuItem.Enabled = has_delete_permission;

			Setup_grd_vehicle_sale();

			txt_search_vehicle.TextChanged += (sender2, e2) => Apply_filter_vehicle_sale();
			cmb_vehicle_acquire.ComboBox.SelectedIndexChanged += (sender2, e2) => Apply_filter_vehicle_sale();

			btn_add_vehicle.Click += Add_vehicle_sale;
			addToolStripMenuItem.Click += Add_vehicle_sale;
			btn_edit_vehicle.Click += Edit_vehicle_sale;
			editToolStripMenuItem.Click += Edit_vehicle_sale;
			btn_delete_vehicle.Click += Delete_vehicle_sale;
			deleteToolStripMenuItem.Click += Delete_vehicle_sale;
		}
		private void Setup_grd_vehicle_sale(int int_vehicle = 0)
		{
			grd_main.DataSource = null;
			grd_main.DataSource = Vehicle_sale_ds.Select_vehicle_sale_simplified();
			grd_main.Columns["sale_price"].DefaultCellStyle.Format = "N2";
			grd_main.AutoResizeColumns();

			Apply_filter_vehicle_sale();

			if (int_vehicle != 0)
				Class_datagridview.Select_row_by_value(grd_main, "vehicle", int_vehicle);
		}
		private void Apply_filter_vehicle_sale()
		{

		}
		private void Add_vehicle_sale(object sender, EventArgs e)
		{

			using (Form_datagridview_select dlg_select = new Form_datagridview_select(Vehicle_ds.Select_unsold_vehicle(),
				new string[] { "purchase_date", "registration_no", "chassis_no", "vehcle_model_name",
	 "vehicle_group_name", "vehicle_brand_name", "colour_name", "acquire_method" }))
			{
				if (dlg_select.ShowDialog() != DialogResult.OK) return;

				using (Form_vehicle_sale form_sale = new Form_vehicle_sale(dlg_select.Get_selected_value_as_int("vehicle")))
				{
					if (form_sale.ShowDialog() == DialogResult.OK)
						Setup_grd_vehicle_sale(dlg_select.Get_selected_value_as_int("vehicle"));
				}

			}
		}
		private void Edit_vehicle_sale(object sender, EventArgs e)
		{

		}
		private void Delete_vehicle_sale(object sender, EventArgs e)
		{

		}
		#endregion
		#region VEHICLE RETURN
		private void Setup_form_vehicle_return()
		{
			ts_add_edit_delete.Visible = true;

			lbl_status.Visible = false;
			cmb_status.Visible = false;

			bool has_add_edit_permission = Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_RETURN_ADD_EDIT);
			bool has_delete_permission = Program.System_user.Has_permission(Class_enum.User_permission.VEHICLE_RETURN_DELETE);

			btn_add.Enabled = has_add_edit_permission;
			btn_edit.Enabled = has_add_edit_permission;
			btn_delete.Enabled = has_delete_permission;

			addToolStripMenuItem.Enabled = has_add_edit_permission;
			editToolStripMenuItem.Enabled = has_add_edit_permission;
			deleteToolStripMenuItem.Enabled = has_delete_permission;

			Setup_grd_vehicle_return();

			txt_search_vehicle.TextChanged += (sender2, e2) => Apply_filter_vehicle_return();
			cmb_vehicle_acquire.ComboBox.SelectedIndexChanged += (sender2, e2) => Apply_filter_vehicle_return();
			cmb_vehicle_status.ComboBox.SelectedIndexChanged += (sender2, e2) => Apply_filter_vehicle_return();

			btn_add.Click += Add_vehicle_return;
			addToolStripMenuItem.Click += Add_vehicle_return;
			btn_edit.Click += Edit_vehicle_return;
			editToolStripMenuItem.Click += Edit_vehicle_return;
			btn_delete.Click += Delete_vehicle_return;
			deleteToolStripMenuItem.Click += Delete_vehicle_return;
		}
		private void Setup_grd_vehicle_return(int int_vehicle = 0)
		{
			grd_main.DataSource = null;
			grd_main.DataSource = Vehicle_return_ds.Select_vehicle_return(-1);

			grd_main.Columns["compensation"].DefaultCellStyle.Format = "N2";

			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_columns(grd_main, new string[] { "vehicle", "returb_by_id" });
			grd_main.AutoResizeColumns();

			Apply_filter_vehicle_return();

			if (int_vehicle != 0)
				Class_datagridview.Select_row_by_value(grd_main, "vehicle", int_vehicle);
		}
		private void Apply_filter_vehicle_return()
		{
			if (grd_main.DataSource == null) return;

			string str_search = txt_search.Text.Trim();

			((DataTable)grd_main.DataSource).DefaultView.RowFilter = "[registration_no] LIKE '%" + str_search +
				"%' OR [seller_name] LIKE '%" + str_search + "%' OR [seller_branch] LIKE '%" + str_search +
				"%' OR [vehicle_brand] LIKE '%" + str_search + "%' OR [vehicle_group] LIKE '%" + str_search +
				"%' OR [vehicle_model] LIKE '%" + str_search + "%' OR [return_by] LIKE '%" + str_search +
				"%' OR [remark] LIKE '%" + str_search + "%'";
		}
		private void Add_vehicle_return(object sender, EventArgs e)
		{
			using (Form_datagridview_select dlg_select = new Form_datagridview_select(Vehicle_ds.
				Select_vehicle_simplified().Where(x => x.vehicle_status == "UNSOLD").CopyToDataTable(),
				new string[] { "acquire_method", "registration_no", "seller_name", "branch_name",
	 "vehicle_model", "purchase_date", "location", "chassis_no", "engine_no", "year_make" }))
			{
				if (dlg_select.ShowDialog() == DialogResult.OK)
					Show_form_return_edit(dlg_select.Get_selected_value_as_int("vehicle"));
			}
		}
		private void Edit_vehicle_return(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;
			Show_form_return_edit((int)grd_main.SelectedCells[0].OwningRow.Cells["vehicle"].Value);
		}
		private void Show_form_return_edit(int int_vehicle)
		{
			using (Form_vehicle_return dlg_edit = new Form_vehicle_return(int_vehicle))
			{
				if (dlg_edit.ShowDialog() == DialogResult.OK)
					Setup_grd_vehicle_return(int_vehicle);
			}
		}
		private void Delete_vehicle_return(object sender, EventArgs e)
		{
			if (grd_main.SelectedCells.Count == 0) return;

			if (MessageBox.Show("Vehicle status will be reverted to \"UNSOLD\". Proceed?", "Confirm",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK) return;

			if (Vehicle_return_ds.Delete_vehicle_return((int)grd_main.SelectedCells[0].OwningRow.Cells["vehicle"].Value))
				Setup_grd_vehicle_return();
		}
		#endregion
		#region LOCATION
		private void Setup_form_location()
		{
			if (Program.System_user.Has_permission(Class_enum.User_permission.LOCATION_ADD_EDIT))
			{
				grd_main.ReadOnly = false;
				grd_main.AllowUserToAddRows = true;
			}
			deleteToolStripMenuItem.Enabled = false; // default
			if (Program.System_user.Has_permission(Class_enum.User_permission.LOCATION_DELETE))
			{
				grd_main.AllowUserToDeleteRows = true;
				deleteToolStripMenuItem.Enabled = true;
			}

			ts_save_only.Visible = true;
			Setup_grd_location();
			btn_save.Click += Btn_save_location_Click;
			deleteToolStripMenuItem.Click += Delete_grd_main_row;
		}
		private void Setup_grd_location()
		{
			Class_datagridview.Setup_and_preselect(grd_main, Location_ds.Select_location(), "colour_name");
			grd_main.AutoResizeColumns();

			grd_main.Columns["location"].DefaultCellStyle.BackColor = Color.LightGray;
			Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_main, "location_name");
		}
		private void Btn_save_location_Click(object sender, EventArgs e)
		{
			Class_datagridview.Apply_all_changes(grd_main);

			DataTable dttable = Class_datatable.Remove_unnecessary_columns(((DataTable)grd_main.DataSource).Copy(),
				new string[] { "location", "location_name" });

			if (dttable.Select().GroupBy(c => c["location_name"].ToString().ToUpper()).Where(c => c.Count() > 1).Count() > 0)
			{
				MessageBox.Show("Duplicate location names are not allowed", "Invalid",
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
						bulkCopy.ColumnMappings.Add("location", "int1");
						bulkCopy.ColumnMappings.Add("location_name", "nvarchar1");
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
			if (Program.System_user.Has_permission(Class_enum.User_permission.DELETE_COLOUR))
				if (!Location_ds.Delete_location())
					MessageBox.Show("One or more location cannot be deleted because there are items applying this setting.",
						"Some items cannot be deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

			if (Program.System_user.Has_permission(Class_enum.User_permission.ADD_EDIT_COLOUR))
				if (!Location_ds.Update_insert_location())
					MessageBox.Show("Update failed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

			Setup_grd_location();
		}
		#endregion
		#region INSURANCE_TYPE 
		private void Setup_form_insurance_type()
		{
			if (Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_ADD_EDIT))
			{
				grd_main.ReadOnly = false;
				grd_main.AllowUserToAddRows = true;
			}
			deleteToolStripMenuItem.Enabled = false; // default
			if (Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_DELETE))
			{
				grd_main.AllowUserToDeleteRows = true;
				deleteToolStripMenuItem.Enabled = true;
			}
			ts_save_only.Visible = true;
			Setup_grd_insurance_type();
			btn_save.Click += Btn_save_insurance_type_Click;
			deleteToolStripMenuItem.Click += Delete_grd_main_row;
		}
		private void Setup_grd_insurance_type()
		{
			Class_datagridview.Setup_and_preselect(grd_main, Insurance_type_ds.Select_insurance_type(), "insurance_type");
			grd_main.AutoResizeColumns();
			grd_main.Columns["insurance_type"].DefaultCellStyle.BackColor = Color.LightGray;
			Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_main, "description");
		}
		private void Btn_save_insurance_type_Click(object sender, EventArgs e)
		{
			Class_datagridview.Apply_all_changes(grd_main);
			DataTable dttable = ((DataTable)grd_main.DataSource).Copy();
			Class_datatable.Add_uploaded_by_columns(ref dttable);

			if (dttable.Select().GroupBy(c => c["description"].ToString().ToUpper()).Where(c => c.Count() > 1).Count() > 0)
			{
				MessageBox.Show("Duplicate descriptions are not allowed", "Invalid",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Class_bulkcopy bk = new Class_bulkcopy(dttable)
			{
				INT1 = "insurance_type",
				NVARCHAR1 = "description"
			};
			if (!bk.Write_to_db()) return;

			if (Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_DELETE))
				if (!Insurance_type_ds.Delete_insurance_type())
					MessageBox.Show("One or more insurance type cannot be deleted because there are items applying this setting.",
						"Some items cannot be deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

			if (Program.System_user.Has_permission(Class_enum.User_permission.INSURANCE_ADD_EDIT))
				if (!Insurance_type_ds.Update_insert_insurance_type())
					MessageBox.Show("Update failed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

			Setup_grd_insurance_type();
		}
		#endregion
		#region INSURANCE_CATEGORY
		private void Setup_form_insurance_category()
		{

		}
		private void Setup_grd_insurance_category()
		{

		}
		private void Btn_save_insurance_category_Click(object sender, EventArgs e)
		{

		}
		#endregion
	}
}
