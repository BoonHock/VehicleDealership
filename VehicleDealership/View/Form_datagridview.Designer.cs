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
			this.ts_add_edit_delete = new System.Windows.Forms.ToolStrip();
			this.btn_add = new System.Windows.Forms.ToolStripButton();
			this.btn_edit = new System.Windows.Forms.ToolStripButton();
			this.btn_delete = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
			this.txt_search = new System.Windows.Forms.ToolStripTextBox();
			this.lbl_status = new System.Windows.Forms.ToolStripLabel();
			this.cmb_status = new System.Windows.Forms.ToolStripComboBox();
			this.ts_vehicle = new System.Windows.Forms.ToolStrip();
			this.btn_add_vehicle = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_vehicle = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_vehicle = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
			this.txt_search_vehicle = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
			this.cmb_vehicle_acquire = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
			this.cmb_vehicle_status = new System.Windows.Forms.ToolStripComboBox();
			this.btn_print_vehicle_in = new System.Windows.Forms.ToolStripDropDownButton();
			this.vehicleReceivedNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.evidenceOfPurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hirePurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesPurchaseAgreementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lbl_edit_will_affect_all = new System.Windows.Forms.Label();
			this.ts_vehicle_sale = new System.Windows.Forms.ToolStrip();
			this.btn_add_vehicle_sale = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_vehicle_sale = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_vehicle_sale = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
			this.txt_search_vehicle_sale = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aPFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.soldSlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ownershipClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jPJSalesLetter1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jPJSalesLetter2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ts_user.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_main)).BeginInit();
			this.cms_grd_main.SuspendLayout();
			this.ts_save_only.SuspendLayout();
			this.ts_add_edit_delete.SuspendLayout();
			this.ts_vehicle.SuspendLayout();
			this.ts_vehicle_sale.SuspendLayout();
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
			this.cmb_is_active_user.Items.AddRange(new object[] {
            "ALL",
            "ACTIVE",
            "INACTIVE"});
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
			this.grd_main.Location = new System.Drawing.Point(0, 145);
			this.grd_main.Name = "grd_main";
			this.grd_main.ReadOnly = true;
			this.grd_main.Size = new System.Drawing.Size(1212, 643);
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
            this.cmb_vehicle_acquire,
            this.toolStripLabel7,
            this.cmb_vehicle_status,
            this.btn_print_vehicle_in});
			this.ts_vehicle.Location = new System.Drawing.Point(0, 75);
			this.ts_vehicle.Name = "ts_vehicle";
			this.ts_vehicle.Size = new System.Drawing.Size(1212, 25);
			this.ts_vehicle.TabIndex = 6;
			this.ts_vehicle.Text = "toolStrip2";
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
			this.toolStripLabel6.Size = new System.Drawing.Size(96, 22);
			this.toolStripLabel6.Text = "Acquire method:";
			// 
			// cmb_vehicle_acquire
			// 
			this.cmb_vehicle_acquire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_vehicle_acquire.Items.AddRange(new object[] {
            "ALL",
            "CONSIGNMENT",
            "MORTGAGE",
            "PURCHASE",
            "TRADE-IN"});
			this.cmb_vehicle_acquire.Name = "cmb_vehicle_acquire";
			this.cmb_vehicle_acquire.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripLabel7
			// 
			this.toolStripLabel7.Name = "toolStripLabel7";
			this.toolStripLabel7.Size = new System.Drawing.Size(42, 22);
			this.toolStripLabel7.Text = "Status:";
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
			// btn_print_vehicle_in
			// 
			this.btn_print_vehicle_in.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_print_vehicle_in.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleReceivedNoteToolStripMenuItem,
            this.evidenceOfPurchaseToolStripMenuItem,
            this.hirePurchaseToolStripMenuItem,
            this.salesPurchaseAgreementToolStripMenuItem});
			this.btn_print_vehicle_in.Image = global::VehicleDealership.Properties.Resources.Print_16x;
			this.btn_print_vehicle_in.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_print_vehicle_in.Name = "btn_print_vehicle_in";
			this.btn_print_vehicle_in.Size = new System.Drawing.Size(29, 22);
			this.btn_print_vehicle_in.Text = "Print";
			// 
			// vehicleReceivedNoteToolStripMenuItem
			// 
			this.vehicleReceivedNoteToolStripMenuItem.Name = "vehicleReceivedNoteToolStripMenuItem";
			this.vehicleReceivedNoteToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.vehicleReceivedNoteToolStripMenuItem.Text = "Vehicle Received Note";
			this.vehicleReceivedNoteToolStripMenuItem.Click += new System.EventHandler(this.VehicleReceivedNoteToolStripMenuItem_Click);
			// 
			// evidenceOfPurchaseToolStripMenuItem
			// 
			this.evidenceOfPurchaseToolStripMenuItem.Name = "evidenceOfPurchaseToolStripMenuItem";
			this.evidenceOfPurchaseToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.evidenceOfPurchaseToolStripMenuItem.Text = "Evidence of Purchase";
			this.evidenceOfPurchaseToolStripMenuItem.Click += new System.EventHandler(this.EvidenceOfPurchaseToolStripMenuItem_Click);
			// 
			// hirePurchaseToolStripMenuItem
			// 
			this.hirePurchaseToolStripMenuItem.Name = "hirePurchaseToolStripMenuItem";
			this.hirePurchaseToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.hirePurchaseToolStripMenuItem.Text = "Hire Purchase";
			this.hirePurchaseToolStripMenuItem.Click += new System.EventHandler(this.HirePurchaseToolStripMenuItem_Click);
			// 
			// salesPurchaseAgreementToolStripMenuItem
			// 
			this.salesPurchaseAgreementToolStripMenuItem.Name = "salesPurchaseAgreementToolStripMenuItem";
			this.salesPurchaseAgreementToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.salesPurchaseAgreementToolStripMenuItem.Text = "Sales && Purchase Agreement";
			this.salesPurchaseAgreementToolStripMenuItem.Click += new System.EventHandler(this.SalesPurchaseAgreementToolStripMenuItem_Click);
			// 
			// lbl_edit_will_affect_all
			// 
			this.lbl_edit_will_affect_all.AutoSize = true;
			this.lbl_edit_will_affect_all.BackColor = System.Drawing.Color.Yellow;
			this.lbl_edit_will_affect_all.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_edit_will_affect_all.Location = new System.Drawing.Point(0, 125);
			this.lbl_edit_will_affect_all.Name = "lbl_edit_will_affect_all";
			this.lbl_edit_will_affect_all.Size = new System.Drawing.Size(296, 20);
			this.lbl_edit_will_affect_all.TabIndex = 7;
			this.lbl_edit_will_affect_all.Text = "NOTE: Positive ID indicates existing record. ";
			this.lbl_edit_will_affect_all.Visible = false;
			// 
			// ts_vehicle_sale
			// 
			this.ts_vehicle_sale.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts_vehicle_sale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_vehicle_sale,
            this.btn_edit_vehicle_sale,
            this.btn_delete_vehicle_sale,
            this.toolStripLabel8,
            this.txt_search_vehicle_sale,
            this.toolStripDropDownButton1});
			this.ts_vehicle_sale.Location = new System.Drawing.Point(0, 100);
			this.ts_vehicle_sale.Name = "ts_vehicle_sale";
			this.ts_vehicle_sale.Size = new System.Drawing.Size(1212, 25);
			this.ts_vehicle_sale.TabIndex = 8;
			this.ts_vehicle_sale.Text = "toolStrip2";
			// 
			// btn_add_vehicle_sale
			// 
			this.btn_add_vehicle_sale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_vehicle_sale.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_vehicle_sale.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_vehicle_sale.Name = "btn_add_vehicle_sale";
			this.btn_add_vehicle_sale.Size = new System.Drawing.Size(23, 22);
			this.btn_add_vehicle_sale.Text = "Add";
			// 
			// btn_edit_vehicle_sale
			// 
			this.btn_edit_vehicle_sale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_vehicle_sale.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_vehicle_sale.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_vehicle_sale.Name = "btn_edit_vehicle_sale";
			this.btn_edit_vehicle_sale.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_vehicle_sale.Text = "Edit";
			// 
			// btn_delete_vehicle_sale
			// 
			this.btn_delete_vehicle_sale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete_vehicle_sale.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete_vehicle_sale.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete_vehicle_sale.Name = "btn_delete_vehicle_sale";
			this.btn_delete_vehicle_sale.Size = new System.Drawing.Size(23, 22);
			this.btn_delete_vehicle_sale.Text = "Delete";
			// 
			// toolStripLabel8
			// 
			this.toolStripLabel8.Name = "toolStripLabel8";
			this.toolStripLabel8.Size = new System.Drawing.Size(45, 22);
			this.toolStripLabel8.Text = "Search:";
			// 
			// txt_search_vehicle_sale
			// 
			this.txt_search_vehicle_sale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_search_vehicle_sale.Name = "txt_search_vehicle_sale";
			this.txt_search_vehicle_sale.Size = new System.Drawing.Size(150, 25);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesOrderToolStripMenuItem,
            this.aPFormToolStripMenuItem,
            this.soldSlipToolStripMenuItem,
            this.ownershipClaimToolStripMenuItem,
            this.jPJSalesLetter1ToolStripMenuItem,
            this.jPJSalesLetter2ToolStripMenuItem});
			this.toolStripDropDownButton1.Image = global::VehicleDealership.Properties.Resources.Print_16x;
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
			this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
			// 
			// salesOrderToolStripMenuItem
			// 
			this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
			this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salesOrderToolStripMenuItem.Text = "Sales Order";
			this.salesOrderToolStripMenuItem.Click += new System.EventHandler(this.SalesOrderToolStripMenuItem_Click);
			// 
			// aPFormToolStripMenuItem
			// 
			this.aPFormToolStripMenuItem.Name = "aPFormToolStripMenuItem";
			this.aPFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aPFormToolStripMenuItem.Text = "AP Form";
			this.aPFormToolStripMenuItem.Click += new System.EventHandler(this.APFormToolStripMenuItem_Click);
			// 
			// soldSlipToolStripMenuItem
			// 
			this.soldSlipToolStripMenuItem.Name = "soldSlipToolStripMenuItem";
			this.soldSlipToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.soldSlipToolStripMenuItem.Text = "Sold Slip";
			this.soldSlipToolStripMenuItem.Click += new System.EventHandler(this.SoldSlipToolStripMenuItem_Click);
			// 
			// ownershipClaimToolStripMenuItem
			// 
			this.ownershipClaimToolStripMenuItem.Name = "ownershipClaimToolStripMenuItem";
			this.ownershipClaimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.ownershipClaimToolStripMenuItem.Text = "Ownership Claim";
			this.ownershipClaimToolStripMenuItem.Click += new System.EventHandler(this.OwnershipClaimToolStripMenuItem_Click);
			// 
			// jPJSalesLetter1ToolStripMenuItem
			// 
			this.jPJSalesLetter1ToolStripMenuItem.Name = "jPJSalesLetter1ToolStripMenuItem";
			this.jPJSalesLetter1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.jPJSalesLetter1ToolStripMenuItem.Text = "JPJ Sales Letter 1";
			this.jPJSalesLetter1ToolStripMenuItem.Click += new System.EventHandler(this.JPJSalesLetter1ToolStripMenuItem_Click);
			// 
			// jPJSalesLetter2ToolStripMenuItem
			// 
			this.jPJSalesLetter2ToolStripMenuItem.Name = "jPJSalesLetter2ToolStripMenuItem";
			this.jPJSalesLetter2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.jPJSalesLetter2ToolStripMenuItem.Text = "JPJ Sales Letter 2";
			this.jPJSalesLetter2ToolStripMenuItem.Click += new System.EventHandler(this.JPJSalesLetter2ToolStripMenuItem_Click);
			// 
			// Form_datagridview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1212, 788);
			this.Controls.Add(this.grd_main);
			this.Controls.Add(this.lbl_edit_will_affect_all);
			this.Controls.Add(this.ts_vehicle_sale);
			this.Controls.Add(this.ts_vehicle);
			this.Controls.Add(this.ts_add_edit_delete);
			this.Controls.Add(this.ts_save_only);
			this.Controls.Add(this.ts_user);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_datagridview";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
			this.ts_vehicle_sale.ResumeLayout(false);
			this.ts_vehicle_sale.PerformLayout();
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
		private System.Windows.Forms.ToolStripLabel toolStripLabel7;
		private System.Windows.Forms.ToolStripComboBox cmb_vehicle_acquire;
		private System.Windows.Forms.ToolStripDropDownButton btn_print_vehicle_in;
		private System.Windows.Forms.ToolStripMenuItem vehicleReceivedNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem evidenceOfPurchaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hirePurchaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesPurchaseAgreementToolStripMenuItem;
		private System.Windows.Forms.Label lbl_edit_will_affect_all;
		private System.Windows.Forms.ToolStrip ts_vehicle_sale;
		private System.Windows.Forms.ToolStripButton btn_add_vehicle_sale;
		private System.Windows.Forms.ToolStripButton btn_edit_vehicle_sale;
		private System.Windows.Forms.ToolStripButton btn_delete_vehicle_sale;
		private System.Windows.Forms.ToolStripLabel toolStripLabel8;
		private System.Windows.Forms.ToolStripTextBox txt_search_vehicle_sale;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aPFormToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem soldSlipToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ownershipClaimToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem jPJSalesLetter1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem jPJSalesLetter2ToolStripMenuItem;
	}
}