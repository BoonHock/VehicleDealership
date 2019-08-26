﻿namespace VehicleDealership.View
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
			this.tab_details_person = new System.Windows.Forms.TabPage();
			this.dtp_person_leave = new System.Windows.Forms.DateTimePicker();
			this.txt_person_country = new System.Windows.Forms.TextBox();
			this.txt_gender = new System.Windows.Forms.TextBox();
			this.txt_race = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtp_person_join = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_person_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_person_postcode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txt_person_type = new System.Windows.Forms.TextBox();
			this.txt_ic_no = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_driving_license = new System.Windows.Forms.TextBox();
			this.txt_person_state = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_person_city = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_person_address = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tab_details_org = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.grd_salestarget = new System.Windows.Forms.DataGridView();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.grd_contact_info = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tab_details_person.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_salestarget)).BeginInit();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_contact_info)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 521);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(846, 59);
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
			this.tableLayoutPanel1.Location = new System.Drawing.Point(617, 6);
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
			this.tabControl1.Controls.Add(this.tab_details_person);
			this.tabControl1.Controls.Add(this.tab_details_org);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(846, 521);
			this.tabControl1.TabIndex = 3;
			// 
			// tab_details_person
			// 
			this.tab_details_person.Controls.Add(this.dtp_person_leave);
			this.tab_details_person.Controls.Add(this.txt_person_country);
			this.tab_details_person.Controls.Add(this.txt_gender);
			this.tab_details_person.Controls.Add(this.txt_race);
			this.tab_details_person.Controls.Add(this.label5);
			this.tab_details_person.Controls.Add(this.dtp_person_join);
			this.tab_details_person.Controls.Add(this.label4);
			this.tab_details_person.Controls.Add(this.txt_person_name);
			this.tab_details_person.Controls.Add(this.label1);
			this.tab_details_person.Controls.Add(this.txt_person_postcode);
			this.tab_details_person.Controls.Add(this.label2);
			this.tab_details_person.Controls.Add(this.label16);
			this.tab_details_person.Controls.Add(this.txt_person_type);
			this.tab_details_person.Controls.Add(this.txt_ic_no);
			this.tab_details_person.Controls.Add(this.label12);
			this.tab_details_person.Controls.Add(this.label3);
			this.tab_details_person.Controls.Add(this.txt_driving_license);
			this.tab_details_person.Controls.Add(this.txt_person_state);
			this.tab_details_person.Controls.Add(this.label11);
			this.tab_details_person.Controls.Add(this.label6);
			this.tab_details_person.Controls.Add(this.txt_person_city);
			this.tab_details_person.Controls.Add(this.label10);
			this.tab_details_person.Controls.Add(this.txt_person_address);
			this.tab_details_person.Controls.Add(this.label7);
			this.tab_details_person.Controls.Add(this.label9);
			this.tab_details_person.Controls.Add(this.label8);
			this.tab_details_person.Location = new System.Drawing.Point(4, 29);
			this.tab_details_person.Name = "tab_details_person";
			this.tab_details_person.Padding = new System.Windows.Forms.Padding(3);
			this.tab_details_person.Size = new System.Drawing.Size(838, 488);
			this.tab_details_person.TabIndex = 0;
			this.tab_details_person.Text = "Details";
			this.tab_details_person.UseVisualStyleBackColor = true;
			// 
			// dtp_person_leave
			// 
			this.dtp_person_leave.Checked = false;
			this.dtp_person_leave.CustomFormat = "";
			this.dtp_person_leave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_person_leave.Location = new System.Drawing.Point(574, 39);
			this.dtp_person_leave.Name = "dtp_person_leave";
			this.dtp_person_leave.ShowCheckBox = true;
			this.dtp_person_leave.Size = new System.Drawing.Size(187, 27);
			this.dtp_person_leave.TabIndex = 49;
			// 
			// txt_person_country
			// 
			this.txt_person_country.Location = new System.Drawing.Point(125, 450);
			this.txt_person_country.MaxLength = 100;
			this.txt_person_country.Name = "txt_person_country";
			this.txt_person_country.Size = new System.Drawing.Size(236, 27);
			this.txt_person_country.TabIndex = 48;
			// 
			// txt_gender
			// 
			this.txt_gender.Location = new System.Drawing.Point(125, 138);
			this.txt_gender.MaxLength = 10;
			this.txt_gender.Name = "txt_gender";
			this.txt_gender.Size = new System.Drawing.Size(236, 27);
			this.txt_gender.TabIndex = 46;
			// 
			// txt_race
			// 
			this.txt_race.Location = new System.Drawing.Point(125, 171);
			this.txt_race.MaxLength = 50;
			this.txt_race.Name = "txt_race";
			this.txt_race.Size = new System.Drawing.Size(236, 27);
			this.txt_race.TabIndex = 47;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(485, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Date leave:";
			// 
			// dtp_person_join
			// 
			this.dtp_person_join.CustomFormat = "";
			this.dtp_person_join.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_person_join.Location = new System.Drawing.Point(574, 6);
			this.dtp_person_join.Name = "dtp_person_join";
			this.dtp_person_join.Size = new System.Drawing.Size(187, 27);
			this.dtp_person_join.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(485, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Date join:";
			// 
			// txt_person_name
			// 
			this.txt_person_name.Location = new System.Drawing.Point(125, 6);
			this.txt_person_name.MaxLength = 100;
			this.txt_person_name.Name = "txt_person_name";
			this.txt_person_name.Size = new System.Drawing.Size(236, 27);
			this.txt_person_name.TabIndex = 1;
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
			// txt_person_postcode
			// 
			this.txt_person_postcode.Location = new System.Drawing.Point(125, 417);
			this.txt_person_postcode.MaxLength = 10;
			this.txt_person_postcode.Name = "txt_person_postcode";
			this.txt_person_postcode.Size = new System.Drawing.Size(236, 27);
			this.txt_person_postcode.TabIndex = 45;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "IC no.:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(8, 420);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(73, 20);
			this.label16.TabIndex = 44;
			this.label16.Text = "Postcode:";
			// 
			// txt_person_type
			// 
			this.txt_person_type.Location = new System.Drawing.Point(125, 72);
			this.txt_person_type.MaxLength = 50;
			this.txt_person_type.Name = "txt_person_type";
			this.txt_person_type.Size = new System.Drawing.Size(236, 27);
			this.txt_person_type.TabIndex = 3;
			// 
			// txt_ic_no
			// 
			this.txt_ic_no.Location = new System.Drawing.Point(125, 39);
			this.txt_ic_no.MaxLength = 50;
			this.txt_ic_no.Name = "txt_ic_no";
			this.txt_ic_no.Size = new System.Drawing.Size(236, 27);
			this.txt_ic_no.TabIndex = 3;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(8, 453);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(63, 20);
			this.label12.TabIndex = 33;
			this.label12.Text = "Country:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(109, 20);
			this.label3.TabIndex = 18;
			this.label3.Text = "Driving license:";
			// 
			// txt_driving_license
			// 
			this.txt_driving_license.Location = new System.Drawing.Point(125, 105);
			this.txt_driving_license.MaxLength = 15;
			this.txt_driving_license.Name = "txt_driving_license";
			this.txt_driving_license.Size = new System.Drawing.Size(236, 27);
			this.txt_driving_license.TabIndex = 19;
			// 
			// txt_person_state
			// 
			this.txt_person_state.Location = new System.Drawing.Point(125, 384);
			this.txt_person_state.MaxLength = 15;
			this.txt_person_state.Name = "txt_person_state";
			this.txt_person_state.Size = new System.Drawing.Size(236, 27);
			this.txt_person_state.TabIndex = 29;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(8, 387);
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
			// txt_person_city
			// 
			this.txt_person_city.Location = new System.Drawing.Point(125, 351);
			this.txt_person_city.MaxLength = 15;
			this.txt_person_city.Name = "txt_person_city";
			this.txt_person_city.Size = new System.Drawing.Size(236, 27);
			this.txt_person_city.TabIndex = 27;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(8, 354);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 20);
			this.label10.TabIndex = 26;
			this.label10.Text = "City:";
			// 
			// txt_person_address
			// 
			this.txt_person_address.Location = new System.Drawing.Point(125, 204);
			this.txt_person_address.MaxLength = 255;
			this.txt_person_address.Multiline = true;
			this.txt_person_address.Name = "txt_person_address";
			this.txt_person_address.Size = new System.Drawing.Size(281, 141);
			this.txt_person_address.TabIndex = 25;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 141);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 20);
			this.label7.TabIndex = 23;
			this.label7.Text = "Gender:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 207);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 20);
			this.label9.TabIndex = 24;
			this.label9.Text = "Address:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 174);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 20);
			this.label8.TabIndex = 23;
			this.label8.Text = "Race:";
			// 
			// tab_details_org
			// 
			this.tab_details_org.Location = new System.Drawing.Point(4, 29);
			this.tab_details_org.Name = "tab_details_org";
			this.tab_details_org.Padding = new System.Windows.Forms.Padding(3);
			this.tab_details_org.Size = new System.Drawing.Size(838, 488);
			this.tab_details_org.TabIndex = 2;
			this.tab_details_org.Text = "Details";
			this.tab_details_org.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.grd_salestarget);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(838, 488);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Target";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// grd_salestarget
			// 
			this.grd_salestarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_salestarget.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_salestarget.Location = new System.Drawing.Point(3, 3);
			this.grd_salestarget.Name = "grd_salestarget";
			this.grd_salestarget.Size = new System.Drawing.Size(832, 482);
			this.grd_salestarget.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.grd_contact_info);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(838, 488);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Contact information";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// grd_contact_info
			// 
			this.grd_contact_info.AllowUserToAddRows = false;
			this.grd_contact_info.AllowUserToDeleteRows = false;
			this.grd_contact_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_contact_info.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_contact_info.Location = new System.Drawing.Point(3, 3);
			this.grd_contact_info.Name = "grd_contact_info";
			this.grd_contact_info.ReadOnly = true;
			this.grd_contact_info.Size = new System.Drawing.Size(832, 482);
			this.grd_contact_info.TabIndex = 0;
			// 
			// Form_edit_salesperson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(846, 580);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_edit_salesperson";
			this.Text = "Salesperson";
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tab_details_person.ResumeLayout(false);
			this.tab_details_person.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_salestarget)).EndInit();
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_contact_info)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tab_details_person;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DateTimePicker dtp_person_join;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView grd_salestarget;
		private System.Windows.Forms.TabPage tab_details_org;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_person_postcode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txt_ic_no;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_driving_license;
		private System.Windows.Forms.TextBox txt_person_state;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_person_city;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_person_address;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_gender;
		private System.Windows.Forms.TextBox txt_race;
		private System.Windows.Forms.TextBox txt_person_type;
		private System.Windows.Forms.DateTimePicker dtp_person_leave;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView grd_contact_info;
		private System.Windows.Forms.TextBox txt_person_name;
		private System.Windows.Forms.TextBox txt_person_country;
	}
}