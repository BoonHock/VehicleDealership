﻿namespace VehicleDealership.View
{
	partial class Form_organisation
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grd_contact = new System.Windows.Forms.DataGridView();
			this.cms_contact = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txt_postcode = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cmb_country = new System.Windows.Forms.ComboBox();
			this.txt_state = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_city = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_address = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmb_type = new System.Windows.Forms.ComboBox();
			this.txt_branch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_registration_no = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_url = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_contact)).BeginInit();
			this.cms_contact.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 364);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(860, 59);
			this.panel1.TabIndex = 51;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(631, 6);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.grd_contact);
			this.groupBox1.Location = new System.Drawing.Point(421, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(427, 240);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Contact information";
			// 
			// grd_contact
			// 
			this.grd_contact.AllowUserToResizeRows = false;
			this.grd_contact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_contact.ContextMenuStrip = this.cms_contact;
			this.grd_contact.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_contact.Location = new System.Drawing.Point(3, 23);
			this.grd_contact.Name = "grd_contact";
			this.grd_contact.Size = new System.Drawing.Size(421, 214);
			this.grd_contact.TabIndex = 0;
			this.grd_contact.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Grd_contact_DataError);
			this.grd_contact.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.Grd_contact_DefaultValuesNeeded);
			// 
			// cms_contact
			// 
			this.cms_contact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
			this.cms_contact.Name = "cms_contact";
			this.cms_contact.Size = new System.Drawing.Size(108, 26);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
			// 
			// txt_postcode
			// 
			this.txt_postcode.Location = new System.Drawing.Point(134, 291);
			this.txt_postcode.MaxLength = 10;
			this.txt_postcode.Name = "txt_postcode";
			this.txt_postcode.Size = new System.Drawing.Size(236, 27);
			this.txt_postcode.TabIndex = 5;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(12, 294);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(73, 20);
			this.label16.TabIndex = 75;
			this.label16.Text = "Postcode:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 328);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(63, 20);
			this.label11.TabIndex = 76;
			this.label11.Text = "Country:";
			// 
			// cmb_country
			// 
			this.cmb_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_country.FormattingEnabled = true;
			this.cmb_country.Location = new System.Drawing.Point(134, 324);
			this.cmb_country.Name = "cmb_country";
			this.cmb_country.Size = new System.Drawing.Size(236, 28);
			this.cmb_country.TabIndex = 6;
			// 
			// txt_state
			// 
			this.txt_state.Location = new System.Drawing.Point(134, 258);
			this.txt_state.MaxLength = 15;
			this.txt_state.Name = "txt_state";
			this.txt_state.Size = new System.Drawing.Size(236, 27);
			this.txt_state.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 261);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(46, 20);
			this.label9.TabIndex = 74;
			this.label9.Text = "State:";
			// 
			// txt_city
			// 
			this.txt_city.Location = new System.Drawing.Point(134, 225);
			this.txt_city.MaxLength = 15;
			this.txt_city.Name = "txt_city";
			this.txt_city.Size = new System.Drawing.Size(236, 27);
			this.txt_city.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 228);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 20);
			this.label8.TabIndex = 72;
			this.label8.Text = "City:";
			// 
			// txt_address
			// 
			this.txt_address.Location = new System.Drawing.Point(134, 78);
			this.txt_address.MaxLength = 200;
			this.txt_address.Multiline = true;
			this.txt_address.Name = "txt_address";
			this.txt_address.Size = new System.Drawing.Size(281, 141);
			this.txt_address.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 20);
			this.label7.TabIndex = 69;
			this.label7.Text = "Address:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(432, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 20);
			this.label4.TabIndex = 55;
			this.label4.Text = "Type:";
			// 
			// cmb_type
			// 
			this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_type.FormattingEnabled = true;
			this.cmb_type.Location = new System.Drawing.Point(495, 12);
			this.cmb_type.Name = "cmb_type";
			this.cmb_type.Size = new System.Drawing.Size(253, 28);
			this.cmb_type.TabIndex = 7;
			// 
			// txt_branch
			// 
			this.txt_branch.Location = new System.Drawing.Point(495, 46);
			this.txt_branch.MaxLength = 20;
			this.txt_branch.Name = "txt_branch";
			this.txt_branch.Size = new System.Drawing.Size(253, 27);
			this.txt_branch.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(432, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 20);
			this.label3.TabIndex = 58;
			this.label3.Text = "Branch:";
			// 
			// txt_registration_no
			// 
			this.txt_registration_no.Location = new System.Drawing.Point(134, 45);
			this.txt_registration_no.MaxLength = 30;
			this.txt_registration_no.Name = "txt_registration_no";
			this.txt_registration_no.Size = new System.Drawing.Size(236, 27);
			this.txt_registration_no.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 20);
			this.label2.TabIndex = 52;
			this.label2.Text = "Registration no.:";
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(134, 12);
			this.txt_name.MaxLength = 150;
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(236, 27);
			this.txt_name.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 49;
			this.label1.Text = "Name:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(432, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 20);
			this.label5.TabIndex = 78;
			this.label5.Text = "URL:";
			// 
			// txt_url
			// 
			this.txt_url.Location = new System.Drawing.Point(495, 79);
			this.txt_url.MaxLength = 2083;
			this.txt_url.Name = "txt_url";
			this.txt_url.Size = new System.Drawing.Size(353, 27);
			this.txt_url.TabIndex = 9;
			// 
			// Form_organisation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(860, 423);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_url);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_postcode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.txt_registration_no);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cmb_country);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_state);
			this.Controls.Add(this.txt_branch);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cmb_type);
			this.Controls.Add(this.txt_city);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txt_address);
			this.Controls.Add(this.label7);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_organisation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Organisation";
			this.Shown += new System.EventHandler(this.Form_organisation_Shown);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_contact)).EndInit();
			this.cms_contact.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grd_contact;
		private System.Windows.Forms.TextBox txt_postcode;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmb_country;
		private System.Windows.Forms.TextBox txt_state;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_city;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txt_address;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmb_type;
		private System.Windows.Forms.TextBox txt_branch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_registration_no;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_url;
		private System.Windows.Forms.ContextMenuStrip cms_contact;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
	}
}