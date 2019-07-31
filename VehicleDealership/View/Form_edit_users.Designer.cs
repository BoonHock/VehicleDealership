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
			this.btn_remove_image = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.ch_empty_leave_date = new System.Windows.Forms.CheckBox();
			this.btn_change_image = new System.Windows.Forms.Button();
			this.picbox_image = new System.Windows.Forms.PictureBox();
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
			this.tab_permission = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.grd_usergroup = new System.Windows.Forms.DataGridView();
			this.label11 = new System.Windows.Forms.Label();
			this.grd_permission = new System.Windows.Forms.DataGridView();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.filedlg_img = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picbox_image)).BeginInit();
			this.tab_permission.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_usergroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grd_permission)).BeginInit();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tab_permission);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(975, 592);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btn_remove_image);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.ch_empty_leave_date);
			this.tabPage1.Controls.Add(this.btn_change_image);
			this.tabPage1.Controls.Add(this.picbox_image);
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
			// btn_remove_image
			// 
			this.btn_remove_image.AutoSize = true;
			this.btn_remove_image.Location = new System.Drawing.Point(652, 167);
			this.btn_remove_image.Name = "btn_remove_image";
			this.btn_remove_image.Size = new System.Drawing.Size(75, 30);
			this.btn_remove_image.TabIndex = 17;
			this.btn_remove_image.Text = "Remove";
			this.btn_remove_image.UseVisualStyleBackColor = true;
			this.btn_remove_image.Click += new System.EventHandler(this.Btn_remove_image_Click);
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
			// btn_change_image
			// 
			this.btn_change_image.AutoSize = true;
			this.btn_change_image.Location = new System.Drawing.Point(568, 167);
			this.btn_change_image.Name = "btn_change_image";
			this.btn_change_image.Size = new System.Drawing.Size(75, 30);
			this.btn_change_image.TabIndex = 11;
			this.btn_change_image.Text = "Change";
			this.btn_change_image.UseVisualStyleBackColor = true;
			this.btn_change_image.Click += new System.EventHandler(this.Btn_change_image_Click);
			// 
			// picbox_image
			// 
			this.picbox_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picbox_image.Location = new System.Drawing.Point(568, 6);
			this.picbox_image.Name = "picbox_image";
			this.picbox_image.Size = new System.Drawing.Size(159, 155);
			this.picbox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picbox_image.TabIndex = 10;
			this.picbox_image.TabStop = false;
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
			// tab_permission
			// 
			this.tab_permission.Controls.Add(this.splitContainer1);
			this.tab_permission.Location = new System.Drawing.Point(4, 29);
			this.tab_permission.Name = "tab_permission";
			this.tab_permission.Padding = new System.Windows.Forms.Padding(3);
			this.tab_permission.Size = new System.Drawing.Size(967, 559);
			this.tab_permission.TabIndex = 1;
			this.tab_permission.Text = "Permissions";
			this.tab_permission.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.grd_usergroup);
			this.splitContainer1.Panel1.Controls.Add(this.label11);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.grd_permission);
			this.splitContainer1.Panel2.Controls.Add(this.label10);
			this.splitContainer1.Size = new System.Drawing.Size(961, 553);
			this.splitContainer1.SplitterDistance = 459;
			this.splitContainer1.TabIndex = 2;
			// 
			// grd_usergroup
			// 
			this.grd_usergroup.AllowUserToAddRows = false;
			this.grd_usergroup.AllowUserToDeleteRows = false;
			this.grd_usergroup.AllowUserToResizeRows = false;
			this.grd_usergroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_usergroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_usergroup.Location = new System.Drawing.Point(0, 20);
			this.grd_usergroup.MultiSelect = false;
			this.grd_usergroup.Name = "grd_usergroup";
			this.grd_usergroup.ReadOnly = true;
			this.grd_usergroup.RowHeadersVisible = false;
			this.grd_usergroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grd_usergroup.Size = new System.Drawing.Size(459, 533);
			this.grd_usergroup.TabIndex = 4;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Dock = System.Windows.Forms.DockStyle.Top;
			this.label11.Location = new System.Drawing.Point(0, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 20);
			this.label11.TabIndex = 3;
			this.label11.Text = "Select usergroup";
			// 
			// grd_permission
			// 
			this.grd_permission.AllowUserToAddRows = false;
			this.grd_permission.AllowUserToDeleteRows = false;
			this.grd_permission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_permission.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_permission.Location = new System.Drawing.Point(0, 20);
			this.grd_permission.Name = "grd_permission";
			this.grd_permission.ReadOnly = true;
			this.grd_permission.RowHeadersVisible = false;
			this.grd_permission.Size = new System.Drawing.Size(498, 533);
			this.grd_permission.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Top;
			this.label10.Location = new System.Drawing.Point(0, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 20);
			this.label10.TabIndex = 2;
			this.label10.Text = "Permissions";
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
			((System.ComponentModel.ISupportInitialize)(this.picbox_image)).EndInit();
			this.tab_permission.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_usergroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grd_permission)).EndInit();
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tab_permission;
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
		private System.Windows.Forms.PictureBox picbox_image;
		private System.Windows.Forms.Button btn_change_image;
		private System.Windows.Forms.CheckBox ch_empty_leave_date;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.OpenFileDialog filedlg_img;
		private System.Windows.Forms.Button btn_remove_image;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView grd_permission;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DataGridView grd_usergroup;
	}
}