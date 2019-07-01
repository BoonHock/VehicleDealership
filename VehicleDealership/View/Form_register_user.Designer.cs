namespace VehicleDealership.View
{
	partial class Form_register_user
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
			this.txt_username = new System.Windows.Forms.TextBox();
			this.txt_fullname = new System.Windows.Forms.TextBox();
			this.txt_pw1 = new System.Windows.Forms.TextBox();
			this.btn_register = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtp_join_date = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_ic_no = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(339, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username (only alphanumeric characters allowed)";
			// 
			// txt_username
			// 
			this.txt_username.Location = new System.Drawing.Point(11, 31);
			this.txt_username.MaxLength = 20;
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(353, 27);
			this.txt_username.TabIndex = 1;
			// 
			// txt_fullname
			// 
			this.txt_fullname.Location = new System.Drawing.Point(12, 137);
			this.txt_fullname.MaxLength = 20;
			this.txt_fullname.Name = "txt_fullname";
			this.txt_fullname.Size = new System.Drawing.Size(353, 27);
			this.txt_fullname.TabIndex = 5;
			// 
			// txt_pw1
			// 
			this.txt_pw1.Location = new System.Drawing.Point(12, 84);
			this.txt_pw1.MaxLength = 20;
			this.txt_pw1.Name = "txt_pw1";
			this.txt_pw1.PasswordChar = '*';
			this.txt_pw1.Size = new System.Drawing.Size(353, 27);
			this.txt_pw1.TabIndex = 3;
			// 
			// btn_register
			// 
			this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_register.AutoSize = true;
			this.btn_register.Location = new System.Drawing.Point(228, 320);
			this.btn_register.Name = "btn_register";
			this.btn_register.Size = new System.Drawing.Size(73, 30);
			this.btn_register.TabIndex = 10;
			this.btn_register.Text = "Register";
			this.btn_register.UseVisualStyleBackColor = true;
			this.btn_register.Click += new System.EventHandler(this.Btn_register_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_cancel.AutoSize = true;
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Location = new System.Drawing.Point(307, 320);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(68, 30);
			this.btn_cancel.TabIndex = 11;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Full name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 20);
			this.label5.TabIndex = 8;
			this.label5.Text = "Joined on";
			// 
			// dtp_join_date
			// 
			this.dtp_join_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_join_date.Location = new System.Drawing.Point(11, 245);
			this.dtp_join_date.Name = "dtp_join_date";
			this.dtp_join_date.Size = new System.Drawing.Size(128, 27);
			this.dtp_join_date.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 167);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(174, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "New IC no. / Passport no.";
			// 
			// txt_ic_no
			// 
			this.txt_ic_no.Location = new System.Drawing.Point(12, 190);
			this.txt_ic_no.MaxLength = 30;
			this.txt_ic_no.Name = "txt_ic_no";
			this.txt_ic_no.Size = new System.Drawing.Size(353, 27);
			this.txt_ic_no.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(87, 115);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(15, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "*";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(86, 61);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 20);
			this.label7.TabIndex = 13;
			this.label7.Text = "*";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(353, 8);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(15, 20);
			this.label8.TabIndex = 14;
			this.label8.Text = "*";
			// 
			// Form_register_user
			// 
			this.AcceptButton = this.btn_register;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(386, 361);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_ic_no);
			this.Controls.Add(this.dtp_join_date);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_register);
			this.Controls.Add(this.txt_pw1);
			this.Controls.Add(this.txt_fullname);
			this.Controls.Add(this.txt_username);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_register_user";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Register user";
			this.Load += new System.EventHandler(this.Form_register_user_Load);
			this.Shown += new System.EventHandler(this.Form_register_user_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_username;
		private System.Windows.Forms.TextBox txt_fullname;
		private System.Windows.Forms.TextBox txt_pw1;
		private System.Windows.Forms.Button btn_register;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtp_join_date;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_ic_no;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}