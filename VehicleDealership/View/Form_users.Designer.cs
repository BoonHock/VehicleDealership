namespace VehicleDealership.View
{
	partial class Form_users
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
			this.components = new System.ComponentModel.Container();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_edit = new System.Windows.Forms.ToolStripButton();
			this.btn_change_pw = new System.Windows.Forms.ToolStripButton();
			this.btn_add = new System.Windows.Forms.ToolStripButton();
			this.btn_activate = new System.Windows.Forms.ToolStripButton();
			this.btn_deactivate = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txt_search = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.cmb_is_active = new System.Windows.Forms.ToolStripComboBox();
			this.grd_users = new System.Windows.Forms.DataGridView();
			this.cms_user = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_users)).BeginInit();
			this.cms_user.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_edit,
            this.btn_change_pw,
            this.btn_add,
            this.btn_activate,
            this.btn_deactivate,
            this.toolStripLabel1,
            this.txt_search,
            this.toolStripLabel2,
            this.cmb_is_active});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1202, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_edit
			// 
			this.btn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(23, 22);
			this.btn_edit.Text = "Edit";
			this.btn_edit.Click += new System.EventHandler(this.Edit_user);
			// 
			// btn_change_pw
			// 
			this.btn_change_pw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_change_pw.Image = global::VehicleDealership.Properties.Resources.ChangePassword_16x;
			this.btn_change_pw.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_change_pw.Name = "btn_change_pw";
			this.btn_change_pw.Size = new System.Drawing.Size(23, 22);
			this.btn_change_pw.Text = "Change password";
			this.btn_change_pw.Click += new System.EventHandler(this.Btn_change_pw_Click);
			// 
			// btn_add
			// 
			this.btn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(23, 22);
			this.btn_add.Text = "Add";
			this.btn_add.Click += new System.EventHandler(this.Add_user);
			// 
			// btn_activate
			// 
			this.btn_activate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_activate.Image = global::VehicleDealership.Properties.Resources.StatusRun_16x;
			this.btn_activate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_activate.Name = "btn_activate";
			this.btn_activate.Size = new System.Drawing.Size(23, 22);
			this.btn_activate.Text = "Activate";
			this.btn_activate.Click += new System.EventHandler(this.Btn_activate_deactivate_Click);
			// 
			// btn_deactivate
			// 
			this.btn_deactivate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_deactivate.Image = global::VehicleDealership.Properties.Resources.StatusStop_16x;
			this.btn_deactivate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_deactivate.Name = "btn_deactivate";
			this.btn_deactivate.Size = new System.Drawing.Size(23, 22);
			this.btn_deactivate.Text = "Deactivate";
			this.btn_deactivate.Click += new System.EventHandler(this.Btn_activate_deactivate_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
			this.toolStripLabel1.Text = "Search:";
			// 
			// txt_search
			// 
			this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(150, 25);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(42, 22);
			this.toolStripLabel2.Text = "Status:";
			// 
			// cmb_is_active
			// 
			this.cmb_is_active.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_is_active.Name = "cmb_is_active";
			this.cmb_is_active.Size = new System.Drawing.Size(121, 25);
			// 
			// grd_users
			// 
			this.grd_users.AllowUserToAddRows = false;
			this.grd_users.AllowUserToDeleteRows = false;
			this.grd_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_users.ContextMenuStrip = this.cms_user;
			this.grd_users.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_users.Location = new System.Drawing.Point(0, 25);
			this.grd_users.Name = "grd_users";
			this.grd_users.ReadOnly = true;
			this.grd_users.Size = new System.Drawing.Size(1202, 614);
			this.grd_users.TabIndex = 1;
			// 
			// cms_user
			// 
			this.cms_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
			this.cms_user.Name = "cms_user";
			this.cms_user.Size = new System.Drawing.Size(181, 114);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.Edit_user);
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.changePasswordToolStripMenuItem.Text = "Change password";
			this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.Btn_change_pw_Click);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.Add_user);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			// 
			// Form_users
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1202, 639);
			this.Controls.Add(this.grd_users);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_users";
			this.Text = "Users";
			this.Load += new System.EventHandler(this.Form_users_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_users)).EndInit();
			this.cms_user.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_add;
		private System.Windows.Forms.ToolStripButton btn_activate;
		private System.Windows.Forms.ToolStripButton btn_deactivate;
		private System.Windows.Forms.DataGridView grd_users;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox txt_search;
		private System.Windows.Forms.ContextMenuStrip cms_user;
		private System.Windows.Forms.ToolStripButton btn_edit;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripComboBox cmb_is_active;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton btn_change_pw;
	}
}