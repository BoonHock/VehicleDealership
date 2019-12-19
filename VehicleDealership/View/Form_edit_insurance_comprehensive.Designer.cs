namespace VehicleDealership.View
{
	partial class Form_edit_insurance_comprehensive
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
			this.txt_title = new System.Windows.Forms.TextBox();
			this.grd_ins = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grd_ins)).BeginInit();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Title:";
			// 
			// txt_title
			// 
			this.txt_title.Location = new System.Drawing.Point(76, 14);
			this.txt_title.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txt_title.MaxLength = 20;
			this.txt_title.Name = "txt_title";
			this.txt_title.Size = new System.Drawing.Size(269, 27);
			this.txt_title.TabIndex = 5;
			// 
			// grd_ins
			// 
			this.grd_ins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grd_ins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_ins.Location = new System.Drawing.Point(12, 75);
			this.grd_ins.Name = "grd_ins";
			this.grd_ins.Size = new System.Drawing.Size(668, 264);
			this.grd_ins.TabIndex = 6;
			this.grd_ins.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Grd_ins_DataError);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Rates:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 362);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(692, 50);
			this.panel1.TabIndex = 31;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(472, 6);
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
			this.btn_cancel.Size = new System.Drawing.Size(94, 30);
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
			// Form_edit_insurance_comprehensive
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 412);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.grd_ins);
			this.Controls.Add(this.txt_title);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.Name = "Form_edit_insurance_comprehensive";
			this.Text = "Insurance comprehensive";
			this.Shown += new System.EventHandler(this.Form_edit_insurance_comprehensive_Shown);
			((System.ComponentModel.ISupportInitialize)(this.grd_ins)).EndInit();
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_title;
		private System.Windows.Forms.DataGridView grd_ins;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
	}
}