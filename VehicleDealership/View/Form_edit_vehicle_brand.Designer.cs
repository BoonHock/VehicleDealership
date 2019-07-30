namespace VehicleDealership.View
{
	partial class Form_edit_vehicle_brand
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
			this.label3 = new System.Windows.Forms.Label();
			this.grd_main = new System.Windows.Forms.DataGridView();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmb1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grd_main)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "Vehicle groups:";
			// 
			// grd_main
			// 
			this.grd_main.AllowUserToResizeRows = false;
			this.grd_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grd_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.grd_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_main.Location = new System.Drawing.Point(11, 106);
			this.grd_main.Name = "grd_main";
			this.grd_main.Size = new System.Drawing.Size(366, 341);
			this.grd_main.TabIndex = 5;
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(132, 12);
			this.txt_name.MaxLength = 20;
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(207, 27);
			this.txt_name.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Brand name:";
			// 
			// cmb1
			// 
			this.cmb1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmb1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmb1.FormattingEnabled = true;
			this.cmb1.Location = new System.Drawing.Point(132, 45);
			this.cmb1.Name = "cmb1";
			this.cmb1.Size = new System.Drawing.Size(207, 28);
			this.cmb1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Country:";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(158, 453);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 41);
			this.tableLayoutPanel1.TabIndex = 6;
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
			// Form_edit_vehicle_brand
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(387, 506);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.grd_main);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmb1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_edit_vehicle_brand";
			this.Text = "Edit";
			this.Shown += new System.EventHandler(this.Form_edit_vehicle_brand_Shown);
			((System.ComponentModel.ISupportInitialize)(this.grd_main)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView grd_main;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmb1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
	}
}