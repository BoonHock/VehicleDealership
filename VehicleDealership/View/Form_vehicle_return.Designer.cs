namespace VehicleDealership.View
{
	partial class Form_vehicle_return
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
			this.txt_vbrand = new System.Windows.Forms.TextBox();
			this.txt_vgroup = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_vmodel = new System.Windows.Forms.TextBox();
			this.dtp_return = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_return_by = new System.Windows.Forms.TextBox();
			this.btn_return_by = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.num_compensation = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_remark = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.txt_reg_no = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dtp_purchase = new System.Windows.Forms.DateTimePicker();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_seller = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.num_compensation)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(444, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Vehicle brand:";
			// 
			// txt_vbrand
			// 
			this.txt_vbrand.Location = new System.Drawing.Point(565, 12);
			this.txt_vbrand.Name = "txt_vbrand";
			this.txt_vbrand.ReadOnly = true;
			this.txt_vbrand.Size = new System.Drawing.Size(241, 27);
			this.txt_vbrand.TabIndex = 1;
			// 
			// txt_vgroup
			// 
			this.txt_vgroup.Location = new System.Drawing.Point(565, 45);
			this.txt_vgroup.Name = "txt_vgroup";
			this.txt_vgroup.ReadOnly = true;
			this.txt_vgroup.Size = new System.Drawing.Size(241, 27);
			this.txt_vgroup.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(444, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Vehicle group:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(444, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Vehicle model:";
			// 
			// txt_vmodel
			// 
			this.txt_vmodel.Location = new System.Drawing.Point(565, 78);
			this.txt_vmodel.Name = "txt_vmodel";
			this.txt_vmodel.ReadOnly = true;
			this.txt_vmodel.Size = new System.Drawing.Size(241, 27);
			this.txt_vmodel.TabIndex = 3;
			// 
			// dtp_return
			// 
			this.dtp_return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_return.Location = new System.Drawing.Point(134, 45);
			this.dtp_return.Name = "dtp_return";
			this.dtp_return.Size = new System.Drawing.Size(155, 27);
			this.dtp_return.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Return date:";
			// 
			// txt_return_by
			// 
			this.txt_return_by.Location = new System.Drawing.Point(134, 78);
			this.txt_return_by.Name = "txt_return_by";
			this.txt_return_by.ReadOnly = true;
			this.txt_return_by.Size = new System.Drawing.Size(240, 27);
			this.txt_return_by.TabIndex = 3;
			// 
			// btn_return_by
			// 
			this.btn_return_by.Location = new System.Drawing.Point(380, 78);
			this.btn_return_by.Name = "btn_return_by";
			this.btn_return_by.Size = new System.Drawing.Size(27, 27);
			this.btn_return_by.TabIndex = 5;
			this.btn_return_by.Tag = "0";
			this.btn_return_by.Text = "...";
			this.btn_return_by.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 81);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Return by:";
			// 
			// num_compensation
			// 
			this.num_compensation.DecimalPlaces = 2;
			this.num_compensation.Location = new System.Drawing.Point(171, 111);
			this.num_compensation.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.num_compensation.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
			this.num_compensation.Name = "num_compensation";
			this.num_compensation.Size = new System.Drawing.Size(155, 27);
			this.num_compensation.TabIndex = 6;
			this.num_compensation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.num_compensation.ThousandsSeparator = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Compensation:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(134, 114);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "RM";
			// 
			// txt_remark
			// 
			this.txt_remark.Location = new System.Drawing.Point(134, 144);
			this.txt_remark.MaxLength = 100;
			this.txt_remark.Multiline = true;
			this.txt_remark.Name = "txt_remark";
			this.txt_remark.Size = new System.Drawing.Size(273, 173);
			this.txt_remark.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 147);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "Remark:";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(589, 348);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 41);
			this.tableLayoutPanel1.TabIndex = 8;
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
			// txt_reg_no
			// 
			this.txt_reg_no.Location = new System.Drawing.Point(134, 12);
			this.txt_reg_no.Name = "txt_reg_no";
			this.txt_reg_no.ReadOnly = true;
			this.txt_reg_no.Size = new System.Drawing.Size(217, 27);
			this.txt_reg_no.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 15);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(116, 20);
			this.label9.TabIndex = 9;
			this.label9.Text = "Registration no.:";
			// 
			// dtp_purchase
			// 
			this.dtp_purchase.Enabled = false;
			this.dtp_purchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_purchase.Location = new System.Drawing.Point(565, 111);
			this.dtp_purchase.Name = "dtp_purchase";
			this.dtp_purchase.Size = new System.Drawing.Size(172, 27);
			this.dtp_purchase.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(444, 114);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(104, 20);
			this.label10.TabIndex = 2;
			this.label10.Text = "Purchase date:";
			// 
			// txt_seller
			// 
			this.txt_seller.Location = new System.Drawing.Point(565, 144);
			this.txt_seller.Multiline = true;
			this.txt_seller.Name = "txt_seller";
			this.txt_seller.ReadOnly = true;
			this.txt_seller.Size = new System.Drawing.Size(241, 92);
			this.txt_seller.TabIndex = 7;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(444, 147);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(49, 20);
			this.label11.TabIndex = 2;
			this.label11.Text = "Seller:";
			// 
			// Form_vehicle_return
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 401);
			this.Controls.Add(this.txt_reg_no);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.txt_seller);
			this.Controls.Add(this.txt_remark);
			this.Controls.Add(this.num_compensation);
			this.Controls.Add(this.btn_return_by);
			this.Controls.Add(this.dtp_purchase);
			this.Controls.Add(this.dtp_return);
			this.Controls.Add(this.txt_return_by);
			this.Controls.Add(this.txt_vmodel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_vgroup);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_vbrand);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_vehicle_return";
			this.Text = "Vehicle return";
			this.Shown += new System.EventHandler(this.Form_vehicle_return_Shown);
			((System.ComponentModel.ISupportInitialize)(this.num_compensation)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_vbrand;
		private System.Windows.Forms.TextBox txt_vgroup;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_vmodel;
		private System.Windows.Forms.DateTimePicker dtp_return;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_return_by;
		private System.Windows.Forms.Button btn_return_by;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown num_compensation;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt_remark;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.TextBox txt_reg_no;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DateTimePicker dtp_purchase;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_seller;
		private System.Windows.Forms.Label label11;
	}
}