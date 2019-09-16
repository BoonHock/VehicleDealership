namespace VehicleDealership.View
{
	partial class Form_edit_finance
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
			this.btn_view_edit = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.txt_country = new System.Windows.Forms.TextBox();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_postcode = new System.Windows.Forms.TextBox();
			this.lbl_ic_reg = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txt_ic_reg = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txt_state = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txt_city = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_address = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.link_lbl_url = new System.Windows.Forms.LinkLabel();
			this.lbl_url = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.grd_contact = new System.Windows.Forms.DataGridView();
			this.txt_remark = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_contact)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_view_edit);
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 395);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(883, 50);
			this.panel1.TabIndex = 30;
			// 
			// btn_view_edit
			// 
			this.btn_view_edit.AutoSize = true;
			this.btn_view_edit.Location = new System.Drawing.Point(12, 8);
			this.btn_view_edit.Name = "btn_view_edit";
			this.btn_view_edit.Size = new System.Drawing.Size(91, 36);
			this.btn_view_edit.TabIndex = 2;
			this.btn_view_edit.Text = "View/edit";
			this.btn_view_edit.UseVisualStyleBackColor = true;
			this.btn_view_edit.Click += new System.EventHandler(this.Btn_view_edit_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(663, 6);
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
			// txt_country
			// 
			this.txt_country.Location = new System.Drawing.Point(134, 324);
			this.txt_country.MaxLength = 100;
			this.txt_country.Name = "txt_country";
			this.txt_country.ReadOnly = true;
			this.txt_country.Size = new System.Drawing.Size(236, 27);
			this.txt_country.TabIndex = 8;
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(134, 12);
			this.txt_name.MaxLength = 100;
			this.txt_name.Name = "txt_name";
			this.txt_name.ReadOnly = true;
			this.txt_name.Size = new System.Drawing.Size(236, 27);
			this.txt_name.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 49;
			this.label1.Text = "Name:";
			// 
			// txt_postcode
			// 
			this.txt_postcode.Location = new System.Drawing.Point(134, 291);
			this.txt_postcode.MaxLength = 10;
			this.txt_postcode.Name = "txt_postcode";
			this.txt_postcode.ReadOnly = true;
			this.txt_postcode.Size = new System.Drawing.Size(236, 27);
			this.txt_postcode.TabIndex = 7;
			// 
			// lbl_ic_reg
			// 
			this.lbl_ic_reg.AutoSize = true;
			this.lbl_ic_reg.Location = new System.Drawing.Point(12, 48);
			this.lbl_ic_reg.Name = "lbl_ic_reg";
			this.lbl_ic_reg.Size = new System.Drawing.Size(116, 20);
			this.lbl_ic_reg.TabIndex = 51;
			this.lbl_ic_reg.Text = "Registration no.:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(12, 294);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(73, 20);
			this.label16.TabIndex = 62;
			this.label16.Text = "Postcode:";
			// 
			// txt_ic_reg
			// 
			this.txt_ic_reg.Location = new System.Drawing.Point(134, 45);
			this.txt_ic_reg.MaxLength = 50;
			this.txt_ic_reg.Name = "txt_ic_reg";
			this.txt_ic_reg.ReadOnly = true;
			this.txt_ic_reg.Size = new System.Drawing.Size(236, 27);
			this.txt_ic_reg.TabIndex = 2;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 327);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(63, 20);
			this.label12.TabIndex = 61;
			this.label12.Text = "Country:";
			// 
			// txt_state
			// 
			this.txt_state.Location = new System.Drawing.Point(134, 258);
			this.txt_state.MaxLength = 15;
			this.txt_state.Name = "txt_state";
			this.txt_state.ReadOnly = true;
			this.txt_state.Size = new System.Drawing.Size(236, 27);
			this.txt_state.TabIndex = 6;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 261);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 20);
			this.label11.TabIndex = 59;
			this.label11.Text = "State:";
			// 
			// txt_city
			// 
			this.txt_city.Location = new System.Drawing.Point(134, 225);
			this.txt_city.MaxLength = 15;
			this.txt_city.Name = "txt_city";
			this.txt_city.ReadOnly = true;
			this.txt_city.Size = new System.Drawing.Size(236, 27);
			this.txt_city.TabIndex = 5;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 228);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 20);
			this.label10.TabIndex = 57;
			this.label10.Text = "City:";
			// 
			// txt_address
			// 
			this.txt_address.Location = new System.Drawing.Point(134, 78);
			this.txt_address.MaxLength = 255;
			this.txt_address.Multiline = true;
			this.txt_address.Name = "txt_address";
			this.txt_address.ReadOnly = true;
			this.txt_address.Size = new System.Drawing.Size(281, 141);
			this.txt_address.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 81);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 20);
			this.label9.TabIndex = 55;
			this.label9.Text = "Address:";
			// 
			// link_lbl_url
			// 
			this.link_lbl_url.AutoSize = true;
			this.link_lbl_url.Location = new System.Drawing.Point(134, 360);
			this.link_lbl_url.Name = "link_lbl_url";
			this.link_lbl_url.Size = new System.Drawing.Size(76, 20);
			this.link_lbl_url.TabIndex = 9;
			this.link_lbl_url.TabStop = true;
			this.link_lbl_url.Text = "linkLabel1";
			this.link_lbl_url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_lbl_url_LinkClicked);
			// 
			// lbl_url
			// 
			this.lbl_url.AutoSize = true;
			this.lbl_url.Location = new System.Drawing.Point(12, 360);
			this.lbl_url.Name = "lbl_url";
			this.lbl_url.Size = new System.Drawing.Size(38, 20);
			this.lbl_url.TabIndex = 66;
			this.lbl_url.Text = "URL:";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.grd_contact);
			this.groupBox1.Location = new System.Drawing.Point(421, 125);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(450, 255);
			this.groupBox1.TabIndex = 10;
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
			this.grd_contact.Size = new System.Drawing.Size(444, 229);
			this.grd_contact.TabIndex = 1;
			// 
			// txt_remark
			// 
			this.txt_remark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_remark.Location = new System.Drawing.Point(489, 12);
			this.txt_remark.MaxLength = 255;
			this.txt_remark.Multiline = true;
			this.txt_remark.Name = "txt_remark";
			this.txt_remark.Size = new System.Drawing.Size(382, 107);
			this.txt_remark.TabIndex = 0;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(421, 15);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(62, 20);
			this.label17.TabIndex = 72;
			this.label17.Text = "Remark:";
			// 
			// Form_edit_finance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(883, 445);
			this.Controls.Add(this.txt_remark);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.link_lbl_url);
			this.Controls.Add(this.lbl_url);
			this.Controls.Add(this.txt_country);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_postcode);
			this.Controls.Add(this.lbl_ic_reg);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.txt_ic_reg);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txt_state);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txt_city);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txt_address);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_edit_finance";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Finance";
			this.Shown += new System.EventHandler(this.Form_edit_finance_Shown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_contact)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.TextBox txt_country;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_postcode;
		private System.Windows.Forms.Label lbl_ic_reg;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txt_ic_reg;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txt_state;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txt_city;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_address;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.LinkLabel link_lbl_url;
		private System.Windows.Forms.Label lbl_url;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grd_contact;
		private System.Windows.Forms.TextBox txt_remark;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button btn_view_edit;
	}
}