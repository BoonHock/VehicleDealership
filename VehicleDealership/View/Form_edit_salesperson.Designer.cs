namespace VehicleDealership.View
{
	partial class Form_edit_salesperson
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tab_details = new System.Windows.Forms.TabPage();
			this.txt_remark = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.txt_location = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grd_contact = new System.Windows.Forms.DataGridView();
			this.link_lbl_url = new System.Windows.Forms.LinkLabel();
			this.lbl_url = new System.Windows.Forms.Label();
			this.split_cont_person_org = new System.Windows.Forms.SplitContainer();
			this.txt_driving_license = new System.Windows.Forms.TextBox();
			this.txt_gender = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_race = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_branch = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.dtp_leave = new System.Windows.Forms.DateTimePicker();
			this.txt_country = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtp_join = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_postcode = new System.Windows.Forms.TextBox();
			this.lbl_ic_reg = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txt_type = new System.Windows.Forms.TextBox();
			this.txt_ic_reg = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txt_state = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_city = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_address = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tab_target = new System.Windows.Forms.TabPage();
			this.label14 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tab_details.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_contact)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.split_cont_person_org)).BeginInit();
			this.split_cont_person_org.Panel1.SuspendLayout();
			this.split_cont_person_org.Panel2.SuspendLayout();
			this.split_cont_person_org.SuspendLayout();
			this.tab_target.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 609);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(911, 50);
			this.panel1.TabIndex = 2;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(691, 6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 41);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_cancel.AutoSize = true;
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Location = new System.Drawing.Point(115, 5);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(95, 30);
			this.btn_cancel.TabIndex = 0;
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
			this.btn_ok.TabIndex = 1;
			this.btn_ok.Text = "OK";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tab_details);
			this.tabControl1.Controls.Add(this.tab_target);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(911, 609);
			this.tabControl1.TabIndex = 3;
			// 
			// tab_details
			// 
			this.tab_details.Controls.Add(this.txt_remark);
			this.tab_details.Controls.Add(this.label17);
			this.tab_details.Controls.Add(this.txt_location);
			this.tab_details.Controls.Add(this.label15);
			this.tab_details.Controls.Add(this.groupBox1);
			this.tab_details.Controls.Add(this.link_lbl_url);
			this.tab_details.Controls.Add(this.lbl_url);
			this.tab_details.Controls.Add(this.split_cont_person_org);
			this.tab_details.Controls.Add(this.dtp_leave);
			this.tab_details.Controls.Add(this.txt_country);
			this.tab_details.Controls.Add(this.label5);
			this.tab_details.Controls.Add(this.dtp_join);
			this.tab_details.Controls.Add(this.label4);
			this.tab_details.Controls.Add(this.txt_name);
			this.tab_details.Controls.Add(this.label1);
			this.tab_details.Controls.Add(this.txt_postcode);
			this.tab_details.Controls.Add(this.lbl_ic_reg);
			this.tab_details.Controls.Add(this.label16);
			this.tab_details.Controls.Add(this.txt_type);
			this.tab_details.Controls.Add(this.txt_ic_reg);
			this.tab_details.Controls.Add(this.label12);
			this.tab_details.Controls.Add(this.txt_state);
			this.tab_details.Controls.Add(this.label11);
			this.tab_details.Controls.Add(this.label6);
			this.tab_details.Controls.Add(this.txt_city);
			this.tab_details.Controls.Add(this.label10);
			this.tab_details.Controls.Add(this.txt_address);
			this.tab_details.Controls.Add(this.label9);
			this.tab_details.Location = new System.Drawing.Point(4, 29);
			this.tab_details.Name = "tab_details";
			this.tab_details.Padding = new System.Windows.Forms.Padding(3);
			this.tab_details.Size = new System.Drawing.Size(903, 576);
			this.tab_details.TabIndex = 0;
			this.tab_details.Text = "Details";
			this.tab_details.UseVisualStyleBackColor = true;
			// 
			// txt_remark
			// 
			this.txt_remark.Location = new System.Drawing.Point(535, 105);
			this.txt_remark.MaxLength = 255;
			this.txt_remark.Multiline = true;
			this.txt_remark.Name = "txt_remark";
			this.txt_remark.Size = new System.Drawing.Size(312, 107);
			this.txt_remark.TabIndex = 69;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(446, 108);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(62, 20);
			this.label17.TabIndex = 70;
			this.label17.Text = "Remark:";
			// 
			// txt_location
			// 
			this.txt_location.Location = new System.Drawing.Point(535, 72);
			this.txt_location.MaxLength = 50;
			this.txt_location.Name = "txt_location";
			this.txt_location.Size = new System.Drawing.Size(312, 27);
			this.txt_location.TabIndex = 67;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(446, 75);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(69, 20);
			this.label15.TabIndex = 68;
			this.label15.Text = "Location:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.grd_contact);
			this.groupBox1.Location = new System.Drawing.Point(417, 218);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(467, 288);
			this.groupBox1.TabIndex = 66;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Contact information";
			// 
			// grd_contact
			// 
			this.grd_contact.AllowUserToAddRows = false;
			this.grd_contact.AllowUserToDeleteRows = false;
			this.grd_contact.AllowUserToResizeRows = false;
			this.grd_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_contact.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_contact.Location = new System.Drawing.Point(3, 23);
			this.grd_contact.Name = "grd_contact";
			this.grd_contact.ReadOnly = true;
			this.grd_contact.Size = new System.Drawing.Size(461, 262);
			this.grd_contact.TabIndex = 1;
			// 
			// link_lbl_url
			// 
			this.link_lbl_url.AutoSize = true;
			this.link_lbl_url.Location = new System.Drawing.Point(130, 387);
			this.link_lbl_url.Name = "link_lbl_url";
			this.link_lbl_url.Size = new System.Drawing.Size(76, 20);
			this.link_lbl_url.TabIndex = 65;
			this.link_lbl_url.TabStop = true;
			this.link_lbl_url.Text = "linkLabel1";
			this.link_lbl_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_lbl_url_LinkClicked);
			// 
			// lbl_url
			// 
			this.lbl_url.AutoSize = true;
			this.lbl_url.Location = new System.Drawing.Point(8, 387);
			this.lbl_url.Name = "lbl_url";
			this.lbl_url.Size = new System.Drawing.Size(38, 20);
			this.lbl_url.TabIndex = 64;
			this.lbl_url.Text = "URL:";
			// 
			// split_cont_person_org
			// 
			this.split_cont_person_org.Location = new System.Drawing.Point(6, 410);
			this.split_cont_person_org.Name = "split_cont_person_org";
			this.split_cont_person_org.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// split_cont_person_org.Panel1
			// 
			this.split_cont_person_org.Panel1.Controls.Add(this.txt_driving_license);
			this.split_cont_person_org.Panel1.Controls.Add(this.txt_gender);
			this.split_cont_person_org.Panel1.Controls.Add(this.label8);
			this.split_cont_person_org.Panel1.Controls.Add(this.txt_race);
			this.split_cont_person_org.Panel1.Controls.Add(this.label7);
			this.split_cont_person_org.Panel1.Controls.Add(this.label3);
			// 
			// split_cont_person_org.Panel2
			// 
			this.split_cont_person_org.Panel2.Controls.Add(this.txt_branch);
			this.split_cont_person_org.Panel2.Controls.Add(this.label13);
			this.split_cont_person_org.Size = new System.Drawing.Size(358, 143);
			this.split_cont_person_org.SplitterDistance = 100;
			this.split_cont_person_org.TabIndex = 60;
			// 
			// txt_driving_license
			// 
			this.txt_driving_license.Location = new System.Drawing.Point(124, 3);
			this.txt_driving_license.MaxLength = 15;
			this.txt_driving_license.Name = "txt_driving_license";
			this.txt_driving_license.ReadOnly = true;
			this.txt_driving_license.Size = new System.Drawing.Size(231, 27);
			this.txt_driving_license.TabIndex = 55;
			// 
			// txt_gender
			// 
			this.txt_gender.Location = new System.Drawing.Point(124, 36);
			this.txt_gender.MaxLength = 10;
			this.txt_gender.Name = "txt_gender";
			this.txt_gender.ReadOnly = true;
			this.txt_gender.Size = new System.Drawing.Size(231, 27);
			this.txt_gender.TabIndex = 58;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(2, 72);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 20);
			this.label8.TabIndex = 57;
			this.label8.Text = "Race:";
			// 
			// txt_race
			// 
			this.txt_race.Location = new System.Drawing.Point(124, 69);
			this.txt_race.MaxLength = 50;
			this.txt_race.Name = "txt_race";
			this.txt_race.ReadOnly = true;
			this.txt_race.Size = new System.Drawing.Size(231, 27);
			this.txt_race.TabIndex = 59;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(2, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 20);
			this.label7.TabIndex = 56;
			this.label7.Text = "Gender:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 20);
			this.label3.TabIndex = 54;
			this.label3.Text = "Driving license:";
			// 
			// txt_branch
			// 
			this.txt_branch.Location = new System.Drawing.Point(124, 3);
			this.txt_branch.MaxLength = 10;
			this.txt_branch.Name = "txt_branch";
			this.txt_branch.ReadOnly = true;
			this.txt_branch.Size = new System.Drawing.Size(231, 27);
			this.txt_branch.TabIndex = 62;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(2, 6);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(57, 20);
			this.label13.TabIndex = 60;
			this.label13.Text = "Branch:";
			// 
			// dtp_leave
			// 
			this.dtp_leave.Checked = false;
			this.dtp_leave.CustomFormat = "";
			this.dtp_leave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_leave.Location = new System.Drawing.Point(535, 39);
			this.dtp_leave.Name = "dtp_leave";
			this.dtp_leave.ShowCheckBox = true;
			this.dtp_leave.Size = new System.Drawing.Size(156, 27);
			this.dtp_leave.TabIndex = 49;
			// 
			// txt_country
			// 
			this.txt_country.Location = new System.Drawing.Point(130, 351);
			this.txt_country.MaxLength = 100;
			this.txt_country.Name = "txt_country";
			this.txt_country.ReadOnly = true;
			this.txt_country.Size = new System.Drawing.Size(236, 27);
			this.txt_country.TabIndex = 48;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(446, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Date leave:";
			// 
			// dtp_join
			// 
			this.dtp_join.CustomFormat = "";
			this.dtp_join.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_join.Location = new System.Drawing.Point(535, 6);
			this.dtp_join.Name = "dtp_join";
			this.dtp_join.Size = new System.Drawing.Size(156, 27);
			this.dtp_join.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(446, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Date join:";
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(130, 6);
			this.txt_name.MaxLength = 100;
			this.txt_name.Name = "txt_name";
			this.txt_name.ReadOnly = true;
			this.txt_name.Size = new System.Drawing.Size(236, 27);
			this.txt_name.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// txt_postcode
			// 
			this.txt_postcode.Location = new System.Drawing.Point(130, 318);
			this.txt_postcode.MaxLength = 10;
			this.txt_postcode.Name = "txt_postcode";
			this.txt_postcode.ReadOnly = true;
			this.txt_postcode.Size = new System.Drawing.Size(236, 27);
			this.txt_postcode.TabIndex = 45;
			// 
			// lbl_ic_reg
			// 
			this.lbl_ic_reg.AutoSize = true;
			this.lbl_ic_reg.Location = new System.Drawing.Point(8, 42);
			this.lbl_ic_reg.Name = "lbl_ic_reg";
			this.lbl_ic_reg.Size = new System.Drawing.Size(116, 20);
			this.lbl_ic_reg.TabIndex = 2;
			this.lbl_ic_reg.Text = "Registration no.:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(8, 321);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(73, 20);
			this.label16.TabIndex = 44;
			this.label16.Text = "Postcode:";
			// 
			// txt_type
			// 
			this.txt_type.Location = new System.Drawing.Point(130, 72);
			this.txt_type.MaxLength = 50;
			this.txt_type.Name = "txt_type";
			this.txt_type.ReadOnly = true;
			this.txt_type.Size = new System.Drawing.Size(236, 27);
			this.txt_type.TabIndex = 3;
			// 
			// txt_ic_reg
			// 
			this.txt_ic_reg.Location = new System.Drawing.Point(130, 39);
			this.txt_ic_reg.MaxLength = 50;
			this.txt_ic_reg.Name = "txt_ic_reg";
			this.txt_ic_reg.ReadOnly = true;
			this.txt_ic_reg.Size = new System.Drawing.Size(236, 27);
			this.txt_ic_reg.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(8, 354);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(63, 20);
			this.label12.TabIndex = 33;
			this.label12.Text = "Country:";
			// 
			// txt_state
			// 
			this.txt_state.Location = new System.Drawing.Point(130, 285);
			this.txt_state.MaxLength = 15;
			this.txt_state.Name = "txt_state";
			this.txt_state.ReadOnly = true;
			this.txt_state.Size = new System.Drawing.Size(236, 27);
			this.txt_state.TabIndex = 29;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(8, 288);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 20);
			this.label11.TabIndex = 28;
			this.label11.Text = "State:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 75);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 20);
			this.label6.TabIndex = 21;
			this.label6.Text = "Type:";
			// 
			// txt_city
			// 
			this.txt_city.Location = new System.Drawing.Point(130, 252);
			this.txt_city.MaxLength = 15;
			this.txt_city.Name = "txt_city";
			this.txt_city.ReadOnly = true;
			this.txt_city.Size = new System.Drawing.Size(236, 27);
			this.txt_city.TabIndex = 27;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(8, 255);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 20);
			this.label10.TabIndex = 26;
			this.label10.Text = "City:";
			// 
			// txt_address
			// 
			this.txt_address.Location = new System.Drawing.Point(130, 105);
			this.txt_address.MaxLength = 255;
			this.txt_address.Multiline = true;
			this.txt_address.Name = "txt_address";
			this.txt_address.ReadOnly = true;
			this.txt_address.Size = new System.Drawing.Size(281, 141);
			this.txt_address.TabIndex = 25;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 108);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 20);
			this.label9.TabIndex = 24;
			this.label9.Text = "Address:";
			// 
			// tab_target
			// 
			this.tab_target.Controls.Add(this.label14);
			this.tab_target.Location = new System.Drawing.Point(4, 29);
			this.tab_target.Name = "tab_target";
			this.tab_target.Padding = new System.Windows.Forms.Padding(3);
			this.tab_target.Size = new System.Drawing.Size(903, 576);
			this.tab_target.TabIndex = 1;
			this.tab_target.Text = "Target";
			this.tab_target.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Red;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Yellow;
			this.label14.Location = new System.Drawing.Point(21, 26);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(221, 30);
			this.label14.TabIndex = 1;
			this.label14.Text = "WORK IN PROGRESS";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(903, 576);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Sales";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Red;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(8, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 30);
			this.label2.TabIndex = 0;
			this.label2.Text = "WORK IN PROGRESS";
			// 
			// Form_edit_salesperson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(911, 659);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_edit_salesperson";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Salesperson";
			this.Shown += new System.EventHandler(this.Form_edit_salesperson_Shown);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tab_details.ResumeLayout(false);
			this.tab_details.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_contact)).EndInit();
			this.split_cont_person_org.Panel1.ResumeLayout(false);
			this.split_cont_person_org.Panel1.PerformLayout();
			this.split_cont_person_org.Panel2.ResumeLayout(false);
			this.split_cont_person_org.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.split_cont_person_org)).EndInit();
			this.split_cont_person_org.ResumeLayout(false);
			this.tab_target.ResumeLayout(false);
			this.tab_target.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tab_details;
		private System.Windows.Forms.TabPage tab_target;
		private System.Windows.Forms.DateTimePicker dtp_join;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_postcode;
		private System.Windows.Forms.Label lbl_ic_reg;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txt_ic_reg;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txt_state;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_city;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_address;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_type;
		private System.Windows.Forms.DateTimePicker dtp_leave;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TextBox txt_country;
		private System.Windows.Forms.TextBox txt_gender;
		private System.Windows.Forms.TextBox txt_race;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_driving_license;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.SplitContainer split_cont_person_org;
		private System.Windows.Forms.TextBox txt_branch;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.LinkLabel link_lbl_url;
		private System.Windows.Forms.Label lbl_url;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grd_contact;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txt_location;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txt_remark;
		private System.Windows.Forms.Label label17;
	}
}