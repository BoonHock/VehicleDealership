﻿namespace VehicleDealership.View
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
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.grd_img = new System.Windows.Forms.DataGridView();
			this.picbox = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.txt_img_caption = new System.Windows.Forms.TextBox();
			this.btn_add_img = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_img = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_img_desc = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.num_engine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_no_of_door)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_seat_capacity)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_img)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
			this.panel2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
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
			this.txt_model_name.Location = new System.Drawing.Point(191, 6);
			this.txt_model_name.MaxLength = 50;
			this.txt_model_name.Name = "txt_model_name";
			this.txt_model_name.Size = new System.Drawing.Size(446, 27);
			this.txt_model_name.TabIndex = 1;
			// 
			// cmb_brand
			// 
			this.cmb_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_brand.FormattingEnabled = true;
			this.cmb_brand.Location = new System.Drawing.Point(191, 39);
			this.cmb_brand.Name = "cmb_brand";
			this.cmb_brand.Size = new System.Drawing.Size(175, 28);
			this.cmb_brand.TabIndex = 5;
			this.cmb_brand.SelectedIndexChanged += new System.EventHandler(this.Cmb_brand_SelectedIndexChanged);
			// 
			// cmb_group
			// 
			this.cmb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_group.FormattingEnabled = true;
			this.cmb_group.Location = new System.Drawing.Point(191, 73);
			this.cmb_group.Name = "cmb_group";
			this.cmb_group.Size = new System.Drawing.Size(175, 28);
			this.cmb_group.TabIndex = 7;
			this.cmb_group.SelectedIndexChanged += new System.EventHandler(this.Cmb_group_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 42);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 4;
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
			this.num_engine.Location = new System.Drawing.Point(191, 107);
			this.num_engine.Name = "num_engine";
			this.num_engine.Size = new System.Drawing.Size(123, 27);
			this.num_engine.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 110);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Engine capacity (cc):";
			// 
			// num_no_of_door
			// 
			this.num_no_of_door.Location = new System.Drawing.Point(191, 140);
			this.num_no_of_door.Name = "num_no_of_door";
			this.num_no_of_door.Size = new System.Drawing.Size(123, 27);
			this.num_no_of_door.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 143);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "No. of door:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 176);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Seat capacity:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 210);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 20);
			this.label7.TabIndex = 14;
			this.label7.Text = "Fuel type:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 244);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 20);
			this.label8.TabIndex = 16;
			this.label8.Text = "Transmission:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 277);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 20);
			this.label10.TabIndex = 18;
			this.label10.Text = "Remarks:";
			// 
			// num_seat_capacity
			// 
			this.num_seat_capacity.Location = new System.Drawing.Point(191, 173);
			this.num_seat_capacity.Name = "num_seat_capacity";
			this.num_seat_capacity.Size = new System.Drawing.Size(123, 27);
			this.num_seat_capacity.TabIndex = 13;
			// 
			// cmb_fuel_type
			// 
			this.cmb_fuel_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_fuel_type.FormattingEnabled = true;
			this.cmb_fuel_type.Location = new System.Drawing.Point(191, 206);
			this.cmb_fuel_type.Name = "cmb_fuel_type";
			this.cmb_fuel_type.Size = new System.Drawing.Size(264, 28);
			this.cmb_fuel_type.TabIndex = 15;
			// 
			// cmb_transmission
			// 
			this.cmb_transmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_transmission.FormattingEnabled = true;
			this.cmb_transmission.Location = new System.Drawing.Point(191, 240);
			this.cmb_transmission.Name = "cmb_transmission";
			this.cmb_transmission.Size = new System.Drawing.Size(264, 28);
			this.cmb_transmission.TabIndex = 17;
			// 
			// txt_remarks
			// 
			this.txt_remarks.Location = new System.Drawing.Point(191, 274);
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
			this.tableLayoutPanel1.Location = new System.Drawing.Point(593, 6);
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
			this.label9.Location = new System.Drawing.Point(373, 42);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 20);
			this.label9.TabIndex = 2;
			this.label9.Text = "Country:";
			// 
			// txt_country
			// 
			this.txt_country.Location = new System.Drawing.Point(443, 39);
			this.txt_country.Name = "txt_country";
			this.txt_country.ReadOnly = true;
			this.txt_country.Size = new System.Drawing.Size(194, 27);
			this.txt_country.TabIndex = 21;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(822, 485);
			this.tabControl1.TabIndex = 22;
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
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.num_engine);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.num_no_of_door);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(814, 452);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Details";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btn_edit_img_desc);
			this.tabPage2.Controls.Add(this.txt_img_caption);
			this.tabPage2.Controls.Add(this.panel2);
			this.tabPage2.Controls.Add(this.picbox);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(814, 452);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Images";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 485);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(822, 59);
			this.panel1.TabIndex = 23;
			// 
			// grd_img
			// 
			this.grd_img.AllowUserToAddRows = false;
			this.grd_img.AllowUserToDeleteRows = false;
			this.grd_img.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_img.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_img.Location = new System.Drawing.Point(0, 25);
			this.grd_img.Name = "grd_img";
			this.grd_img.ReadOnly = true;
			this.grd_img.Size = new System.Drawing.Size(367, 421);
			this.grd_img.TabIndex = 0;
			// 
			// picbox
			// 
			this.picbox.Location = new System.Drawing.Point(402, 6);
			this.picbox.Name = "picbox";
			this.picbox.Size = new System.Drawing.Size(380, 351);
			this.picbox.TabIndex = 1;
			this.picbox.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.grd_img);
			this.panel2.Controls.Add(this.toolStrip1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(367, 446);
			this.panel2.TabIndex = 2;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_img,
            this.btn_delete_img});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(367, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// txt_img_caption
			// 
			this.txt_img_caption.Location = new System.Drawing.Point(437, 363);
			this.txt_img_caption.Multiline = true;
			this.txt_img_caption.Name = "txt_img_caption";
			this.txt_img_caption.ReadOnly = true;
			this.txt_img_caption.Size = new System.Drawing.Size(359, 83);
			this.txt_img_caption.TabIndex = 3;
			// 
			// btn_add_img
			// 
			this.btn_add_img.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_img.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_img.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_img.Name = "btn_add_img";
			this.btn_add_img.Size = new System.Drawing.Size(23, 22);
			this.btn_add_img.Text = "Add image";
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
			// btn_edit_img_desc
			// 
			this.btn_edit_img_desc.AutoSize = true;
			this.btn_edit_img_desc.Location = new System.Drawing.Point(376, 363);
			this.btn_edit_img_desc.Name = "btn_edit_img_desc";
			this.btn_edit_img_desc.Size = new System.Drawing.Size(55, 30);
			this.btn_edit_img_desc.TabIndex = 4;
			this.btn_edit_img_desc.Text = "Edit";
			this.btn_edit_img_desc.UseVisualStyleBackColor = true;
			// 
			// Form_edit_vehicle_model
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(822, 544);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_edit_vehicle_model";
			this.Text = "Vehicle model";
			((System.ComponentModel.ISupportInitialize)(this.num_engine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_no_of_door)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_seat_capacity)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_img)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
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
		private System.Windows.Forms.TextBox txt_img_caption;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_add_img;
		private System.Windows.Forms.ToolStripButton btn_delete_img;
		private System.Windows.Forms.Button btn_edit_img_desc;
	}
}