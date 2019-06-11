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
			this.Btn_edit = new System.Windows.Forms.ToolStripButton();
			this.btn_add = new System.Windows.Forms.ToolStripButton();
			this.btn_remove = new System.Windows.Forms.ToolStripButton();
			this.btn_activate = new System.Windows.Forms.ToolStripButton();
			this.btn_deactivate = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txt_search = new System.Windows.Forms.ToolStripTextBox();
			this.Grd_users = new System.Windows.Forms.DataGridView();
			this.cms_user = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Grd_users)).BeginInit();
			this.cms_user.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_edit,
            this.btn_add,
            this.btn_remove,
            this.btn_activate,
            this.btn_deactivate,
            this.toolStripLabel1,
            this.txt_search});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1202, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// Btn_edit
			// 
			this.Btn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Btn_edit.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.Btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Btn_edit.Name = "Btn_edit";
			this.Btn_edit.Size = new System.Drawing.Size(23, 22);
			this.Btn_edit.Text = "Edit";
			this.Btn_edit.Click += new System.EventHandler(this.Edit_user);
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
			// btn_remove
			// 
			this.btn_remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_remove.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_remove.Name = "btn_remove";
			this.btn_remove.Size = new System.Drawing.Size(23, 22);
			this.btn_remove.Text = "Remove";
			this.btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
			// 
			// btn_activate
			// 
			this.btn_activate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_activate.Image = global::VehicleDealership.Properties.Resources.StatusRun_16x;
			this.btn_activate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_activate.Name = "btn_activate";
			this.btn_activate.Size = new System.Drawing.Size(23, 22);
			this.btn_activate.Text = "Activate";
			this.btn_activate.Click += new System.EventHandler(this.Btn_activate_Click);
			// 
			// btn_deactivate
			// 
			this.btn_deactivate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_deactivate.Image = global::VehicleDealership.Properties.Resources.StatusStop_16x;
			this.btn_deactivate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_deactivate.Name = "btn_deactivate";
			this.btn_deactivate.Size = new System.Drawing.Size(23, 22);
			this.btn_deactivate.Text = "Deactivate";
			this.btn_deactivate.Click += new System.EventHandler(this.Btn_deactivate_Click);
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
			// Grd_users
			// 
			this.Grd_users.AllowUserToAddRows = false;
			this.Grd_users.AllowUserToDeleteRows = false;
			this.Grd_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_users.ContextMenuStrip = this.cms_user;
			this.Grd_users.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Grd_users.Location = new System.Drawing.Point(0, 25);
			this.Grd_users.Name = "Grd_users";
			this.Grd_users.ReadOnly = true;
			this.Grd_users.Size = new System.Drawing.Size(1202, 614);
			this.Grd_users.TabIndex = 1;
			// 
			// cms_user
			// 
			this.cms_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
			this.cms_user.Name = "cms_user";
			this.cms_user.Size = new System.Drawing.Size(118, 70);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.Edit_user);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.Add_user);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			// 
			// Form_users
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1202, 639);
			this.Controls.Add(this.Grd_users);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_users";
			this.Text = "Users";
			this.Load += new System.EventHandler(this.Form_users_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Grd_users)).EndInit();
			this.cms_user.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_add;
		private System.Windows.Forms.ToolStripButton btn_remove;
		private System.Windows.Forms.ToolStripButton btn_activate;
		private System.Windows.Forms.ToolStripButton btn_deactivate;
		private System.Windows.Forms.DataGridView Grd_users;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox txt_search;
		private System.Windows.Forms.ContextMenuStrip cms_user;
		private System.Windows.Forms.ToolStripButton Btn_edit;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
	}
}