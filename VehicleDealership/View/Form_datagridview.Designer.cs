namespace VehicleDealership.View
{
	partial class Form_datagridview
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ts_user = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txt_search_user = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.cmb_is_active_user = new System.Windows.Forms.ToolStripComboBox();
			this.grd_main = new System.Windows.Forms.DataGridView();
			this.cms_grd_main = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ts_save_only = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.ts_add_edit_delete = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
			this.txt_search = new System.Windows.Forms.ToolStripTextBox();
			this.lbl_status = new System.Windows.Forms.ToolStripLabel();
			this.cmb_status = new System.Windows.Forms.ToolStripComboBox();
			this.ts_vehicle = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
			this.txt_search_vehicle = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
			this.cmb_vehicle_status = new System.Windows.Forms.ToolStripComboBox();
			this.btn_add_vehicle = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_vehicle = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_vehicle = new System.Windows.Forms.ToolStripButton();
			this.btn_received_note = new System.Windows.Forms.ToolStripButton();
			this.btn_add = new System.Windows.Forms.ToolStripButton();
			this.btn_edit = new System.Windows.Forms.ToolStripButton();
			this.btn_delete = new System.Windows.Forms.ToolStripButton();
			this.btn_save = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_user = new System.Windows.Forms.ToolStripButton();
			this.btn_add_user = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_user = new System.Windows.Forms.ToolStripButton();
			this.btn_activate_user = new System.Windows.Forms.ToolStripButton();
			this.btn_deactivate_user = new System.Windows.Forms.ToolStripButton();
			this.btn_eop = new System.Windows.Forms.ToolStripButton();
			this.btn_hire_purchase = new System.Windows.Forms.ToolStripButton();
			this.btn_spa = new System.Windows.Forms.ToolStripButton();
			this.ts_user.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_main)).BeginInit();
			this.cms_grd_main.SuspendLayout();
			this.ts_save_only.SuspendLayout();
			this.ts_add_edit_delete.SuspendLayout();
			this.ts_vehicle.SuspendLayout();
			this.SuspendLayout();
			// 
			// ts_user
			// 
			this.ts_user.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_edit_user,
            this.btn_add_user,
            this.btn_delete_user,
            this.btn_activate_user,
            this.btn_deactivate_user,
            this.toolStripLabel1,
            this.txt_search_user,
            this.toolStripLabel2,
            this.cmb_is_active_user});
			this.ts_user.Location = new System.Drawing.Point(0, 0);
			this.ts_user.Name = "ts_user";
			this.ts_user.Size = new System.Drawing.Size(1212, 25);
			this.ts_user.TabIndex = 1;
			this.ts_user.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
			this.toolStripLabel1.Text = "Search:";
			// 
			// txt_search_user
			// 
			this.txt_search_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_search_user.Name = "txt_search_user";
			this.txt_search_user.Size = new System.Drawing.Size(150, 25);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(42, 22);
			this.toolStripLabel2.Text = "Status:";
			// 
			// cmb_is_active_user
			// 
			this.cmb_is_active_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_is_active_user.Name = "cmb_is_active_user";
			this.cmb_is_active_user.Size = new System.Drawing.Size(121, 25);
			// 
			// grd_main
			// 
			this.grd_main.AllowUserToAddRows = false;
			this.grd_main.AllowUserToDeleteRows = false;
			this.grd_main.AllowUserToResizeRows = false;
			this.grd_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_main.ContextMenuStrip = this.cms_grd_main;
			this.grd_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_main.Location = new System.Drawing.Point(0, 100);
			this.grd_main.Name = "grd_main";
			this.grd_main.ReadOnly = true;
			this.grd_main.Size = new System.Drawing.Size(1212, 688);
			this.grd_main.TabIndex = 2;
			// 
			// cms_grd_main
			// 
			this.cms_grd_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.cms_grd_main.Name = "cms_user";
			this.cms_grd_main.Size = new System.Drawing.Size(108, 70);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.addToolStripMenuItem.Text = "Add";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// ts_save_only
			// 
			this.ts_save_only.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts_save_only.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_save,
            this.toolStripLabel3});
			this.ts_save_only.Location = new System.Drawing.Point(0, 25);
			this.ts_save_only.Name = "ts_save_only";
			this.ts_save_only.Size = new System.Drawing.Size(1212, 25);
			this.ts_save_only.TabIndex = 3;
			this.ts_save_only.Text = "toolStrip1";
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(432, 22);
			this.toolStripLabel3.Text = "Instruction: Edit directly to grid below and click save button to save any change" +
    "s.";
			// 
			// ts_add_edit_delete
			// 
			this.ts_add_edit_delete.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts_add_edit_delete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.btn_edit,
            this.btn_delete,
            this.toolStripLabel4,
            this.txt_search,
            this.lbl_status,
            this.cmb_status});
			this.ts_add_edit_delete.Location = new System.Drawing.Point(0, 50);
			this.ts_add_edit_delete.Name = "ts_add_edit_delete";
			this.ts_add_edit_delete.Size = new System.Drawing.Size(1212, 25);
			this.ts_add_edit_delete.TabIndex = 5;
			this.ts_add_edit_delete.Text = "toolStrip2";
			// 
			// toolStripLabel4
			// 
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new System.Drawing.Size(45, 22);
			this.toolStripLabel4.Text = "Search:";
			// 
			// txt_search
			// 
			this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(150, 25);
			// 
			// lbl_status
			// 
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(42, 22);
			this.lbl_status.Text = "Status:";
			// 
			// cmb_status
			// 
			this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_status.Name = "cmb_status";
			this.cmb_status.Size = new System.Drawing.Size(121, 25);
			// 
			// ts_vehicle
			// 
			this.ts_vehicle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts_vehicle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_vehicle,
            this.btn_edit_vehicle,
            this.btn_delete_vehicle,
            this.toolStripLabel5,
            this.txt_search_vehicle,
            this.toolStripLabel6,
            this.cmb_vehicle_status,
            this.btn_received_note,
            this.btn_eop,
            this.btn_hire_purchase,
            this.btn_spa});
			this.ts_vehicle.Location = new System.Drawing.Point(0, 75);
			this.ts_vehicle.Name = "ts_vehicle";
			this.ts_vehicle.Size = new System.Drawing.Size(1212, 25);
			this.ts_vehicle.TabIndex = 6;
			this.ts_vehicle.Text = "toolStrip2";
			// 
			// toolStripLabel5
			// 
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new System.Drawing.Size(45, 22);
			this.toolStripLabel5.Text = "Search:";
			// 
			// txt_search_vehicle
			// 
			this.txt_search_vehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_search_vehicle.Name = "txt_search_vehicle";
			this.txt_search_vehicle.Size = new System.Drawing.Size(150, 25);
			// 
			// toolStripLabel6
			// 
			this.toolStripLabel6.Name = "toolStripLabel6";
			this.toolStripLabel6.Size = new System.Drawing.Size(42, 22);
			this.toolStripLabel6.Text = "Status:";
			// 
			// cmb_vehicle_status
			// 
			this.cmb_vehicle_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_vehicle_status.Items.AddRange(new object[] {
            "ALL",
            "UNSOLD",
            "SOLD",
            "RETURNED"});
			this.cmb_vehicle_status.Name = "cmb_vehicle_status";
			this.cmb_vehicle_status.Size = new System.Drawing.Size(121, 25);
			// 
			// btn_add_vehicle
			// 
			this.btn_add_vehicle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_vehicle.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_vehicle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_vehicle.Name = "btn_add_vehicle";
			this.btn_add_vehicle.Size = new System.Drawing.Size(23, 22);
			this.btn_add_vehicle.Text = "Add";
			// 
			// btn_edit_vehicle
			// 
			this.btn_edit_vehicle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_vehicle.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_vehicle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_vehicle.Name = "btn_edit_vehicle";
			this.btn_edit_vehicle.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_vehicle.Text = "Edit";
			// 
			// btn_delete_vehicle
			// 
			this.btn_delete_vehicle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete_vehicle.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete_vehicle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete_vehicle.Name = "btn_delete_vehicle";
			this.btn_delete_vehicle.Size = new System.Drawing.Size(23, 22);
			this.btn_delete_vehicle.Text = "Delete";
			// 
			// btn_received_note
			// 
			this.btn_received_note.Image = global::VehicleDealership.Properties.Resources.Print_16x;
			this.btn_received_note.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_received_note.Name = "btn_received_note";
			this.btn_received_note.Size = new System.Drawing.Size(101, 22);
			this.btn_received_note.Text = "Received note";
			// 
			// btn_add
			// 
			this.btn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(23, 22);
			this.btn_add.Text = "Add";
			// 
			// btn_edit
			// 
			this.btn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(23, 22);
			this.btn_edit.Text = "Edit";
			// 
			// btn_delete
			// 
			this.btn_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(23, 22);
			this.btn_delete.Text = "Delete";
			// 
			// btn_save
			// 
			this.btn_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_save.Image = global::VehicleDealership.Properties.Resources.Save_16x;
			this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(23, 22);
			this.btn_save.Text = "Save changes";
			// 
			// btn_edit_user
			// 
			this.btn_edit_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_user.Enabled = false;
			this.btn_edit_user.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_user.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_user.Name = "btn_edit_user";
			this.btn_edit_user.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_user.Text = "Edit";
			// 
			// btn_add_user
			// 
			this.btn_add_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_user.Enabled = false;
			this.btn_add_user.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_user.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_user.Name = "btn_add_user";
			this.btn_add_user.Size = new System.Drawing.Size(23, 22);
			this.btn_add_user.Text = "Add";
			// 
			// btn_delete_user
			// 
			this.btn_delete_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete_user.Enabled = false;
			this.btn_delete_user.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete_user.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete_user.Name = "btn_delete_user";
			this.btn_delete_user.Size = new System.Drawing.Size(23, 22);
			this.btn_delete_user.Text = "Delete";
			// 
			// btn_activate_user
			// 
			this.btn_activate_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_activate_user.Enabled = false;
			this.btn_activate_user.Image = global::VehicleDealership.Properties.Resources.StatusRun_16x;
			this.btn_activate_user.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_activate_user.Name = "btn_activate_user";
			this.btn_activate_user.Size = new System.Drawing.Size(23, 22);
			this.btn_activate_user.Text = "Activate";
			// 
			// btn_deactivate_user
			// 
			this.btn_deactivate_user.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_deactivate_user.Enabled = false;
			this.btn_deactivate_user.Image = global::VehicleDealership.Properties.Resources.StatusStop_16x;
			this.btn_deactivate_user.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_deactivate_user.Name = "btn_deactivate_user";
			this.btn_deactivate_user.Size = new System.Drawing.Size(23, 22);
			this.btn_deactivate_user.Text = "Deactivate";
			// 
			// btn_eop
			// 
			this.btn_eop.Image = global::VehicleDealership.Properties.Resources.Print_16x;
			this.btn_eop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_eop.Name = "btn_eop";
			this.btn_eop.Size = new System.Drawing.Size(49, 22);
			this.btn_eop.Text = "EOP";
			this.btn_eop.ToolTipText = "Evidence of Purchase";
			// 
			// btn_hire_purchase
			// 
			this.btn_hire_purchase.Image = global::VehicleDealership.Properties.Resources.Print_16x;
			this.btn_hire_purchase.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_hire_purchase.Name = "btn_hire_purchase";
			this.btn_hire_purchase.Size = new System.Drawing.Size(100, 22);
			this.btn_hire_purchase.Text = "Hire purchase";
			// 
			// btn_spa
			// 
			this.btn_spa.Image = global::VehicleDealership.Properties.Resources.Print_16x;
			this.btn_spa.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_spa.Name = "btn_spa";
			this.btn_spa.Size = new System.Drawing.Size(48, 22);
			this.btn_spa.Text = "SPA";
			this.btn_spa.ToolTipText = "Sales && Purchase Agreement";
			// 
			// Form_datagridview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1212, 788);
			this.Controls.Add(this.grd_main);
			this.Controls.Add(this.ts_vehicle);
			this.Controls.Add(this.ts_add_edit_delete);
			this.Controls.Add(this.ts_save_only);
			this.Controls.Add(this.ts_user);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_datagridview";
			this.Text = "Manage";
			this.Load += new System.EventHandler(this.Form_datagridview_Load);
			this.Shown += new System.EventHandler(this.Form_datagridview_Shown);
			this.ts_user.ResumeLayout(false);
			this.ts_user.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_main)).EndInit();
			this.cms_grd_main.ResumeLayout(false);
			this.ts_save_only.ResumeLayout(false);
			this.ts_save_only.PerformLayout();
			this.ts_add_edit_delete.ResumeLayout(false);
			this.ts_add_edit_delete.PerformLayout();
			this.ts_vehicle.ResumeLayout(false);
			this.ts_vehicle.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip ts_user;
		private System.Windows.Forms.ToolStripButton btn_edit_user;
		private System.Windows.Forms.ToolStripButton btn_add_user;
		private System.Windows.Forms.ToolStripButton btn_activate_user;
		private System.Windows.Forms.ToolStripButton btn_deactivate_user;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox txt_search_user;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripComboBox cmb_is_active_user;
		private System.Windows.Forms.DataGridView grd_main;
		private System.Windows.Forms.ContextMenuStrip cms_grd_main;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStrip ts_save_only;
		private System.Windows.Forms.ToolStripButton btn_save;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStrip ts_add_edit_delete;
		private System.Windows.Forms.ToolStripButton btn_add;
		private System.Windows.Forms.ToolStripButton btn_edit;
		private System.Windows.Forms.ToolStripButton btn_delete;
		private System.Windows.Forms.ToolStripButton btn_delete_user;
		private System.Windows.Forms.ToolStripLabel toolStripLabel4;
		private System.Windows.Forms.ToolStripTextBox txt_search;
		private System.Windows.Forms.ToolStripLabel lbl_status;
		private System.Windows.Forms.ToolStripComboBox cmb_status;
		private System.Windows.Forms.ToolStrip ts_vehicle;
		private System.Windows.Forms.ToolStripButton btn_add_vehicle;
		private System.Windows.Forms.ToolStripButton btn_edit_vehicle;
		private System.Windows.Forms.ToolStripButton btn_delete_vehicle;
		private System.Windows.Forms.ToolStripLabel toolStripLabel5;
		private System.Windows.Forms.ToolStripTextBox txt_search_vehicle;
		private System.Windows.Forms.ToolStripLabel toolStripLabel6;
		private System.Windows.Forms.ToolStripComboBox cmb_vehicle_status;
		private System.Windows.Forms.ToolStripButton btn_received_note;
		private System.Windows.Forms.ToolStripButton btn_eop;
		private System.Windows.Forms.ToolStripButton btn_hire_purchase;
		private System.Windows.Forms.ToolStripButton btn_spa;
	}
}