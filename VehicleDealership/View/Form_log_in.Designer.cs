namespace VehicleDealership.View
{
	partial class Form_log_in
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_log_in));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_username = new System.Windows.Forms.TextBox();
			this.txt_password = new System.Windows.Forms.TextBox();
			this.btn_log_in = new System.Windows.Forms.Button();
			this.lbl_invalid_login = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.lbl_developer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 49);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password:";
			// 
			// txt_username
			// 
			this.txt_username.Location = new System.Drawing.Point(91, 11);
			this.txt_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(234, 27);
			this.txt_username.TabIndex = 2;
			this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_username_KeyDown);
			// 
			// txt_password
			// 
			this.txt_password.Location = new System.Drawing.Point(91, 45);
			this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txt_password.Name = "txt_password";
			this.txt_password.PasswordChar = '*';
			this.txt_password.Size = new System.Drawing.Size(234, 27);
			this.txt_password.TabIndex = 3;
			// 
			// btn_log_in
			// 
			this.btn_log_in.Location = new System.Drawing.Point(177, 105);
			this.btn_log_in.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_log_in.Name = "btn_log_in";
			this.btn_log_in.Size = new System.Drawing.Size(67, 28);
			this.btn_log_in.TabIndex = 4;
			this.btn_log_in.Text = "Log In";
			this.btn_log_in.UseVisualStyleBackColor = true;
			this.btn_log_in.Click += new System.EventHandler(this.Btn_log_in_Click);
			// 
			// lbl_invalid_login
			// 
			this.lbl_invalid_login.AutoSize = true;
			this.lbl_invalid_login.ForeColor = System.Drawing.Color.Red;
			this.lbl_invalid_login.Location = new System.Drawing.Point(11, 109);
			this.lbl_invalid_login.Name = "lbl_invalid_login";
			this.lbl_invalid_login.Size = new System.Drawing.Size(97, 20);
			this.lbl_invalid_login.TabIndex = 5;
			this.lbl_invalid_login.Text = "Login invalid.";
			this.lbl_invalid_login.Visible = false;
			// 
			// btn_cancel
			// 
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Location = new System.Drawing.Point(250, 106);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 28);
			this.btn_cancel.TabIndex = 6;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			// 
			// lbl_developer
			// 
			this.lbl_developer.AutoSize = true;
			this.lbl_developer.Location = new System.Drawing.Point(91, 76);
			this.lbl_developer.Name = "lbl_developer";
			this.lbl_developer.Size = new System.Drawing.Size(147, 20);
			this.lbl_developer.TabIndex = 7;
			this.lbl_developer.Text = "Developer mode ON";
			this.lbl_developer.Visible = false;
			// 
			// Form_log_in
			// 
			this.AcceptButton = this.btn_log_in;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(337, 146);
			this.Controls.Add(this.lbl_developer);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.lbl_invalid_login);
			this.Controls.Add(this.btn_log_in);
			this.Controls.Add(this.txt_password);
			this.Controls.Add(this.txt_username);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "Form_log_in";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Log In";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_username;
		private System.Windows.Forms.TextBox txt_password;
		private System.Windows.Forms.Button btn_log_in;
		private System.Windows.Forms.Label lbl_invalid_login;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Label lbl_developer;
	}
}