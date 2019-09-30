namespace VehicleDealership.View
{
	partial class Form_edit_vehicle_model
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
			this.label1 = new System.Windows.Forms.Label();
			this.txt_model_name = new System.Windows.Forms.TextBox();
			this.cmb_brand = new System.Windows.Forms.ComboBox();
			this.cmb_group = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.num_engine = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.num_no_of_door = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.num_seat_capacity = new System.Windows.Forms.NumericUpDown();
			this.cmb_fuel_type = new System.Windows.Forms.ComboBox();
			this.cmb_transmission = new System.Windows.Forms.ComboBox();
			this.txt_remarks = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_country = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label13 = new System.Windows.Forms.Label();
			this.num_year_make = new System.Windows.Forms.NumericUpDown();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.grd_img = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_add_img = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_img = new System.Windows.Forms.ToolStripButton();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.picbox = new System.Windows.Forms.PictureBox();
			this.txt_img_created_on = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txt_img_created_by = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btn_update_img_desc = new System.Windows.Forms.Button();
			this.txt_img_description = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.filedlg_img = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.num_engine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_no_of_door)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_seat_capacity)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_year_make)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_img)).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Model name:";
			// 
			// txt_model_name
			// 
			this.txt_model_name.Location = new System.Drawing.Point(169, 6);
			this.txt_model_name.MaxLength = 50;
			this.txt_model_name.Name = "txt_model_name";
			this.txt_model_name.Size = new System.Drawing.Size(446, 27);
			this.txt_model_name.TabIndex = 1;
			// 
			// cmb_brand
			// 
			this.cmb_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_brand.FormattingEnabled = true;
			this.cmb_brand.Location = new System.Drawing.Point(169, 39);
			this.cmb_brand.Name = "cmb_brand";
			this.cmb_brand.Size = new System.Drawing.Size(175, 28);
			this.cmb_brand.TabIndex = 3;
			this.cmb_brand.SelectedIndexChanged += new System.EventHandler(this.Cmb_brand_SelectedIndexChanged);
			// 
			// cmb_group
			// 
			this.cmb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_group.FormattingEnabled = true;
			this.cmb_group.Location = new System.Drawing.Point(169, 73);
			this.cmb_group.Name = "cmb_group";
			this.cmb_group.Size = new System.Drawing.Size(175, 28);
			this.cmb_group.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 42);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Brand:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 77);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Group:";
			// 
			// num_engine
			// 
			this.num_engine.Location = new System.Drawing.Point(169, 140);
			this.num_engine.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.num_engine.Name = "num_engine";
			this.num_engine.Size = new System.Drawing.Size(123, 27);
			this.num_engine.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 143);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Engine capacity (cc):";
			// 
			// num_no_of_door
			// 
			this.num_no_of_door.Location = new System.Drawing.Point(169, 173);
			this.num_no_of_door.Name = "num_no_of_door";
			this.num_no_of_door.Size = new System.Drawing.Size(123, 27);
			this.num_no_of_door.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 176);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "No. of door:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 209);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Seat capacity:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 243);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 20);
			this.label7.TabIndex = 14;
			this.label7.Text = "Fuel type:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 277);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 20);
			this.label8.TabIndex = 16;
			this.label8.Text = "Transmission:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 310);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 20);
			this.label10.TabIndex = 18;
			this.label10.Text = "Remarks:";
			// 
			// num_seat_capacity
			// 
			this.num_seat_capacity.Location = new System.Drawing.Point(169, 206);
			this.num_seat_capacity.Name = "num_seat_capacity";
			this.num_seat_capacity.Size = new System.Drawing.Size(123, 27);
			this.num_seat_capacity.TabIndex = 13;
			// 
			// cmb_fuel_type
			// 
			this.cmb_fuel_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_fuel_type.FormattingEnabled = true;
			this.cmb_fuel_type.Location = new System.Drawing.Point(169, 239);
			this.cmb_fuel_type.Name = "cmb_fuel_type";
			this.cmb_fuel_type.Size = new System.Drawing.Size(175, 28);
			this.cmb_fuel_type.TabIndex = 15;
			// 
			// cmb_transmission
			// 
			this.cmb_transmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_transmission.FormattingEnabled = true;
			this.cmb_transmission.Location = new System.Drawing.Point(169, 273);
			this.cmb_transmission.Name = "cmb_transmission";
			this.cmb_transmission.Size = new System.Drawing.Size(175, 28);
			this.cmb_transmission.TabIndex = 17;
			// 
			// txt_remarks
			// 
			this.txt_remarks.Location = new System.Drawing.Point(169, 307);
			this.txt_remarks.Multiline = true;
			this.txt_remarks.Name = "txt_remarks";
			this.txt_remarks.Size = new System.Drawing.Size(446, 172);
			this.txt_remarks.TabIndex = 19;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(949, 6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 41);
			this.tableLayoutPanel1.TabIndex = 20;
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_cancel.AutoSize = true;
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Location = new System.Drawing.Point(115, 5);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(95, 30);
			this.btn_cancel.TabIndex = 1;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
			// 
			// btn_ok
			// 
			this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_ok.AutoSize = true;
			this.btn_ok.Location = new System.Drawing.Point(6, 5);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(95, 30);
			this.btn_ok.TabIndex = 0;
			this.btn_ok.Text = "OK";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(351, 42);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 20);
			this.label9.TabIndex = 4;
			this.label9.Text = "Country:";
			// 
			// txt_country
			// 
			this.txt_country.Location = new System.Drawing.Point(421, 39);
			this.txt_country.Name = "txt_country";
			this.txt_country.ReadOnly = true;
			this.txt_country.Size = new System.Drawing.Size(194, 27);
			this.txt_country.TabIndex = 5;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1178, 658);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.txt_country);
			this.tabPage1.Controls.Add(this.txt_remarks);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.txt_model_name);
			this.tabPage1.Controls.Add(this.cmb_transmission);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.cmb_fuel_type);
			this.tabPage1.Controls.Add(this.cmb_brand);
			this.tabPage1.Controls.Add(this.num_seat_capacity);
			this.tabPage1.Controls.Add(this.cmb_group);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.num_year_make);
			this.tabPage1.Controls.Add(this.num_engine);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.num_no_of_door);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1170, 625);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Details";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(7, 110);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(81, 20);
			this.label13.TabIndex = 8;
			this.label13.Text = "Year make:";
			// 
			// num_year_make
			// 
			this.num_year_make.Location = new System.Drawing.Point(169, 107);
			this.num_year_make.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.num_year_make.Name = "num_year_make";
			this.num_year_make.Size = new System.Drawing.Size(123, 27);
			this.num_year_make.TabIndex = 9;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.splitContainer1);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1170, 625);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Images";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.grd_img);
			this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1164, 619);
			this.splitContainer1.SplitterDistance = 220;
			this.splitContainer1.TabIndex = 1;
			// 
			// grd_img
			// 
			this.grd_img.AllowUserToAddRows = false;
			this.grd_img.AllowUserToDeleteRows = false;
			this.grd_img.AllowUserToResizeRows = false;
			this.grd_img.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grd_img.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_img.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_img.Location = new System.Drawing.Point(0, 25);
			this.grd_img.Name = "grd_img";
			this.grd_img.ReadOnly = true;
			this.grd_img.RowHeadersVisible = false;
			this.grd_img.Size = new System.Drawing.Size(220, 594);
			this.grd_img.TabIndex = 0;
			this.grd_img.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grd_img_RowEnter);
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_img,
            this.btn_delete_img});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(220, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_add_img
			// 
			this.btn_add_img.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_img.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_img.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_img.Name = "btn_add_img";
			this.btn_add_img.Size = new System.Drawing.Size(23, 22);
			this.btn_add_img.Text = "Add image";
			this.btn_add_img.Click += new System.EventHandler(this.Btn_add_img_Click);
			// 
			// btn_delete_img
			// 
			this.btn_delete_img.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete_img.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete_img.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete_img.Name = "btn_delete_img";
			this.btn_delete_img.Size = new System.Drawing.Size(23, 22);
			this.btn_delete_img.Text = "Delete image";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.picbox);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.txt_img_created_on);
			this.splitContainer2.Panel2.Controls.Add(this.label12);
			this.splitContainer2.Panel2.Controls.Add(this.txt_img_created_by);
			this.splitContainer2.Panel2.Controls.Add(this.label11);
			this.splitContainer2.Panel2.Controls.Add(this.btn_update_img_desc);
			this.splitContainer2.Panel2.Controls.Add(this.txt_img_description);
			this.splitContainer2.Size = new System.Drawing.Size(940, 619);
			this.splitContainer2.SplitterDistance = 546;
			this.splitContainer2.TabIndex = 5;
			// 
			// picbox
			// 
			this.picbox.BackColor = System.Drawing.Color.Black;
			this.picbox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picbox.Location = new System.Drawing.Point(0, 0);
			this.picbox.Name = "picbox";
			this.picbox.Size = new System.Drawing.Size(546, 619);
			this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picbox.TabIndex = 1;
			this.picbox.TabStop = false;
			// 
			// txt_img_created_on
			// 
			this.txt_img_created_on.Location = new System.Drawing.Point(3, 365);
			this.txt_img_created_on.Name = "txt_img_created_on";
			this.txt_img_created_on.ReadOnly = true;
			this.txt_img_created_on.Size = new System.Drawing.Size(297, 27);
			this.txt_img_created_on.TabIndex = 8;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 342);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(85, 20);
			this.label12.TabIndex = 7;
			this.label12.Text = "Created on:";
			// 
			// txt_img_created_by
			// 
			this.txt_img_created_by.Location = new System.Drawing.Point(3, 299);
			this.txt_img_created_by.Name = "txt_img_created_by";
			this.txt_img_created_by.ReadOnly = true;
			this.txt_img_created_by.Size = new System.Drawing.Size(297, 27);
			this.txt_img_created_by.TabIndex = 6;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 276);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(84, 20);
			this.label11.TabIndex = 5;
			this.label11.Text = "Created by:";
			// 
			// btn_update_img_desc
			// 
			this.btn_update_img_desc.AutoSize = true;
			this.btn_update_img_desc.Enabled = false;
			this.btn_update_img_desc.Location = new System.Drawing.Point(3, 209);
			this.btn_update_img_desc.Name = "btn_update_img_desc";
			this.btn_update_img_desc.Size = new System.Drawing.Size(146, 30);
			this.btn_update_img_desc.TabIndex = 4;
			this.btn_update_img_desc.Text = "Update description";
			this.btn_update_img_desc.UseVisualStyleBackColor = true;
			this.btn_update_img_desc.Click += new System.EventHandler(this.Btn_update_img_desc_Click);
			// 
			// txt_img_description
			// 
			this.txt_img_description.Location = new System.Drawing.Point(3, 39);
			this.txt_img_description.MaxLength = 100;
			this.txt_img_description.Multiline = true;
			this.txt_img_description.Name = "txt_img_description";
			this.txt_img_description.ReadOnly = true;
			this.txt_img_description.Size = new System.Drawing.Size(384, 164);
			this.txt_img_description.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 658);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1178, 59);
			this.panel1.TabIndex = 23;
			// 
			// filedlg_img
			// 
			this.filedlg_img.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
			this.filedlg_img.Multiselect = true;
			this.filedlg_img.Title = "Upload image";
			// 
			// Form_edit_vehicle_model
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(1178, 717);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_edit_vehicle_model";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Vehicle model";
			((System.ComponentModel.ISupportInitialize)(this.num_engine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_no_of_door)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_seat_capacity)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_year_make)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_img)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_model_name;
		private System.Windows.Forms.ComboBox cmb_brand;
		private System.Windows.Forms.ComboBox cmb_group;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown num_engine;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown num_no_of_door;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown num_seat_capacity;
		private System.Windows.Forms.ComboBox cmb_fuel_type;
		private System.Windows.Forms.ComboBox cmb_transmission;
		private System.Windows.Forms.TextBox txt_remarks;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_country;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox picbox;
		private System.Windows.Forms.DataGridView grd_img;
		private System.Windows.Forms.TextBox txt_img_description;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_add_img;
		private System.Windows.Forms.ToolStripButton btn_delete_img;
		private System.Windows.Forms.Button btn_update_img_desc;
		private System.Windows.Forms.OpenFileDialog filedlg_img;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.TextBox txt_img_created_on;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txt_img_created_by;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown num_year_make;
	}
}