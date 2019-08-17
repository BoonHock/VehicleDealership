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
			this.btn_edit_user = new System.Windows.Forms.ToolStripButton();
			this.btn_add_user = new System.Windows.Forms.ToolStripButton();
			this.btn_activate_user = new System.Windows.Forms.ToolStripButton();
			this.btn_deactivate_user = new System.Windows.Forms.ToolStripButton();
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
			this.btn_save = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_filter_vehicle_purchase = new System.Windows.Forms.ToolStripButton();
			this.btn_add_vehicle_purchase = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_vehicle_purchase = new System.Windows.Forms.ToolStripButton();
			this.ts_finance = new System.Windows.Forms.ToolStrip();
			this.btn_add_finance = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_finance = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_finance = new System.Windows.Forms.ToolStripButton();
			this.ts_user.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_main)).BeginInit();
			this.cms_grd_main.SuspendLayout();
			this.ts_save_only.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.ts_finance.SuspendLayout();
			this.SuspendLayout();
			// 
			// ts_user
			// 
			this.ts_user.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_edit_user,
            this.btn_add_user,
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
			// btn_save
			// 
			this.btn_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_save.Image = global::VehicleDealership.Properties.Resources.Save_16x;
			this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(23, 22);
			this.btn_save.Text = "Save changes";
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(432, 22);
			this.toolStripLabel3.Text = "Instruction: Edit directly to grid below and click save button to save any change" +
    "s.";
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_filter_vehicle_purchase,
            this.btn_add_vehicle_purchase,
            this.btn_edit_vehicle_purchase});
			this.toolStrip1.Location = new System.Drawing.Point(0, 75);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1212, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_filter_vehicle_purchase
			// 
			this.btn_filter_vehicle_purchase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_filter_vehicle_purchase.Image = global::VehicleDealership.Properties.Resources.Filter_16x;
			this.btn_filter_vehicle_purchase.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_filter_vehicle_purchase.Name = "btn_filter_vehicle_purchase";
			this.btn_filter_vehicle_purchase.Size = new System.Drawing.Size(23, 22);
			this.btn_filter_vehicle_purchase.Text = "Filter";
			// 
			// btn_add_vehicle_purchase
			// 
			this.btn_add_vehicle_purchase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_vehicle_purchase.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_vehicle_purchase.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_vehicle_purchase.Name = "btn_add_vehicle_purchase";
			this.btn_add_vehicle_purchase.Size = new System.Drawing.Size(23, 22);
			this.btn_add_vehicle_purchase.Text = "Add";
			// 
			// btn_edit_vehicle_purchase
			// 
			this.btn_edit_vehicle_purchase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_vehicle_purchase.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_vehicle_purchase.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_vehicle_purchase.Name = "btn_edit_vehicle_purchase";
			this.btn_edit_vehicle_purchase.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_vehicle_purchase.Text = "Edit";
			// 
			// ts_finance
			// 
			this.ts_finance.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts_finance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_finance,
            this.btn_edit_finance,
            this.btn_delete_finance});
			this.ts_finance.Location = new System.Drawing.Point(0, 50);
			this.ts_finance.Name = "ts_finance";
			this.ts_finance.Size = new System.Drawing.Size(1212, 25);
			this.ts_finance.TabIndex = 5;
			this.ts_finance.Text = "toolStrip2";
			// 
			// btn_add_finance
			// 
			this.btn_add_finance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_finance.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_finance.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_finance.Name = "btn_add_finance";
			this.btn_add_finance.Size = new System.Drawing.Size(23, 22);
			this.btn_add_finance.Text = "Add";
			// 
			// btn_edit_finance
			// 
			this.btn_edit_finance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_finance.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_finance.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_finance.Name = "btn_edit_finance";
			this.btn_edit_finance.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_finance.Text = "Edit";
			// 
			// btn_delete_finance
			// 
			this.btn_delete_finance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete_finance.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete_finance.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete_finance.Name = "btn_delete_finance";
			this.btn_delete_finance.Size = new System.Drawing.Size(23, 22);
			this.btn_delete_finance.Text = "Delete";
			// 
			// Form_datagridview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1212, 788);
			this.Controls.Add(this.grd_main);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.ts_finance);
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
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ts_finance.ResumeLayout(false);
			this.ts_finance.PerformLayout();
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
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_filter_vehicle_purchase;
		private System.Windows.Forms.ToolStripButton btn_add_vehicle_purchase;
		private System.Windows.Forms.ToolStripButton btn_edit_vehicle_purchase;
		private System.Windows.Forms.ToolStrip ts_finance;
		private System.Windows.Forms.ToolStripButton btn_add_finance;
		private System.Windows.Forms.ToolStripButton btn_edit_finance;
		private System.Windows.Forms.ToolStripButton btn_delete_finance;
	}
}