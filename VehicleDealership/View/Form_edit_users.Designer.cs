namespace VehicleDealership.View
{
	partial class Form_edit_users
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btn_remove_photo = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ch_empty_leave_date = new System.Windows.Forms.CheckBox();
			this.btn_change_photo = new System.Windows.Forms.Button();
			this.picbox_photo = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dtp_leave = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtp_join = new System.Windows.Forms.DateTimePicker();
			this.txt_ic_no = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_username = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.filedlg_img = new System.Windows.Forms.OpenFileDialog();
			this.listview_permissions = new System.Windows.Forms.ListView();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picbox_photo)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(975, 592);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btn_remove_photo);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.ch_empty_leave_date);
			this.tabPage1.Controls.Add(this.btn_change_photo);
			this.tabPage1.Controls.Add(this.picbox_photo);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.dtp_leave);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.dtp_join);
			this.tabPage1.Controls.Add(this.txt_ic_no);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.txt_name);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.txt_username);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(967, 559);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btn_remove_photo
			// 
			this.btn_remove_photo.AutoSize = true;
			this.btn_remove_photo.Location = new System.Drawing.Point(652, 167);
			this.btn_remove_photo.Name = "btn_remove_photo";
			this.btn_remove_photo.Size = new System.Drawing.Size(75, 30);
			this.btn_remove_photo.TabIndex = 17;
			this.btn_remove_photo.Text = "Remove";
			this.btn_remove_photo.UseVisualStyleBackColor = true;
			this.btn_remove_photo.Click += new System.EventHandler(this.Btn_remove_photo_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(208, 110);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(15, 20);
			this.label9.TabIndex = 16;
			this.label9.Text = "*";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(208, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(15, 20);
			this.label8.TabIndex = 15;
			this.label8.Text = "*";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(208, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 20);
			this.label7.TabIndex = 14;
			this.label7.Text = "*";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(208, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(15, 20);
			this.label6.TabIndex = 13;
			this.label6.Text = "*";
			// 
			// ch_empty_leave_date
			// 
			this.ch_empty_leave_date.AutoSize = true;
			this.ch_empty_leave_date.Location = new System.Drawing.Point(361, 139);
			this.ch_empty_leave_date.Name = "ch_empty_leave_date";
			this.ch_empty_leave_date.Size = new System.Drawing.Size(95, 24);
			this.ch_empty_leave_date.TabIndex = 12;
			this.ch_empty_leave_date.Text = "Set empty";
			this.ch_empty_leave_date.UseVisualStyleBackColor = true;
			this.ch_empty_leave_date.CheckedChanged += new System.EventHandler(this.Ch_empty_leave_date_CheckedChanged);
			// 
			// btn_change_photo
			// 
			this.btn_change_photo.AutoSize = true;
			this.btn_change_photo.Location = new System.Drawing.Point(568, 167);
			this.btn_change_photo.Name = "btn_change_photo";
			this.btn_change_photo.Size = new System.Drawing.Size(75, 30);
			this.btn_change_photo.TabIndex = 11;
			this.btn_change_photo.Text = "Change";
			this.btn_change_photo.UseVisualStyleBackColor = true;
			this.btn_change_photo.Click += new System.EventHandler(this.Btn_change_photo_Click);
			// 
			// picbox_photo
			// 
			this.picbox_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picbox_photo.Location = new System.Drawing.Point(568, 6);
			this.picbox_photo.Name = "picbox_photo";
			this.picbox_photo.Size = new System.Drawing.Size(159, 155);
			this.picbox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picbox_photo.TabIndex = 10;
			this.picbox_photo.TabStop = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Leave date:";
			// 
			// dtp_leave
			// 
			this.dtp_leave.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_leave.Location = new System.Drawing.Point(229, 138);
			this.dtp_leave.Name = "dtp_leave";
			this.dtp_leave.Size = new System.Drawing.Size(125, 27);
			this.dtp_leave.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Join date:";
			// 
			// dtp_join
			// 
			this.dtp_join.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_join.Location = new System.Drawing.Point(229, 105);
			this.dtp_join.Name = "dtp_join";
			this.dtp_join.Size = new System.Drawing.Size(125, 27);
			this.dtp_join.TabIndex = 6;
			// 
			// txt_ic_no
			// 
			this.txt_ic_no.Location = new System.Drawing.Point(229, 72);
			this.txt_ic_no.MaxLength = 30;
			this.txt_ic_no.Name = "txt_ic_no";
			this.txt_ic_no.Size = new System.Drawing.Size(301, 27);
			this.txt_ic_no.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(174, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "New IC no. / Passport no.";
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(229, 39);
			this.txt_name.MaxLength = 200;
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(301, 27);
			this.txt_name.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name:";
			// 
			// txt_username
			// 
			this.txt_username.Location = new System.Drawing.Point(229, 6);
			this.txt_username.MaxLength = 20;
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(301, 27);
			this.txt_username.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.listview_permissions);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(967, 559);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Permissions";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 592);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(975, 59);
			this.panel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(746, 6);
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
			// filedlg_img
			// 
			this.filedlg_img.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
			// 
			// listview_permissions
			// 
			this.listview_permissions.CheckBoxes = true;
			this.listview_permissions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listview_permissions.GridLines = true;
			this.listview_permissions.Location = new System.Drawing.Point(3, 3);
			this.listview_permissions.Name = "listview_permissions";
			this.listview_permissions.Size = new System.Drawing.Size(961, 553);
			this.listview_permissions.TabIndex = 0;
			this.listview_permissions.UseCompatibleStateImageBehavior = false;
			this.listview_permissions.View = System.Windows.Forms.View.Details;
			// 
			// Form_edit_users
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(975, 651);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_edit_users";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User";
			this.Shown += new System.EventHandler(this.Form_edit_users_Shown);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picbox_photo)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.TextBox txt_username;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtp_leave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtp_join;
		private System.Windows.Forms.TextBox txt_ic_no;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox picbox_photo;
		private System.Windows.Forms.Button btn_change_photo;
		private System.Windows.Forms.CheckBox ch_empty_leave_date;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.OpenFileDialog filedlg_img;
		private System.Windows.Forms.Button btn_remove_photo;
		private System.Windows.Forms.ListView listview_permissions;
	}
}