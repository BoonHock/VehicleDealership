﻿namespace VehicleDealership.View
{
	partial class Form_change_pw
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
			this.txt_old_pw = new System.Windows.Forms.TextBox();
			this.txt_new_pw = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.Ch_display_text = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Old password:";
			// 
			// txt_old_pw
			// 
			this.txt_old_pw.Location = new System.Drawing.Point(128, 12);
			this.txt_old_pw.Name = "txt_old_pw";
			this.txt_old_pw.Size = new System.Drawing.Size(260, 27);
			this.txt_old_pw.TabIndex = 1;
			this.txt_old_pw.UseSystemPasswordChar = true;
			// 
			// txt_new_pw
			// 
			this.txt_new_pw.Location = new System.Drawing.Point(128, 45);
			this.txt_new_pw.Name = "txt_new_pw";
			this.txt_new_pw.Size = new System.Drawing.Size(260, 27);
			this.txt_new_pw.TabIndex = 3;
			this.txt_new_pw.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "New password:";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(171, 132);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 41);
			this.tableLayoutPanel1.TabIndex = 5;
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
			// Ch_display_text
			// 
			this.Ch_display_text.AutoSize = true;
			this.Ch_display_text.Location = new System.Drawing.Point(128, 78);
			this.Ch_display_text.Name = "Ch_display_text";
			this.Ch_display_text.Size = new System.Drawing.Size(106, 24);
			this.Ch_display_text.TabIndex = 4;
			this.Ch_display_text.Text = "Display text";
			this.Ch_display_text.UseVisualStyleBackColor = true;
			this.Ch_display_text.CheckedChanged += new System.EventHandler(this.Ch_display_text_CheckedChanged);
			// 
			// Form_change_pw
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(400, 185);
			this.Controls.Add(this.Ch_display_text);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.txt_new_pw);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_old_pw);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_change_pw";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Change password";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_old_pw;
		private System.Windows.Forms.TextBox txt_new_pw;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.CheckBox Ch_display_text;
	}
}