namespace VehicleDealership.View
{
	partial class Form_usergroup
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
			this.btn_add = new System.Windows.Forms.ToolStripButton();
			this.btn_remove = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.grd_usergroup = new System.Windows.Forms.DataGridView();
			this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label11 = new System.Windows.Forms.Label();
			this.grd_permission = new System.Windows.Forms.DataGridView();
			this.label10 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_usergroup)).BeginInit();
			this.cms.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_permission)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_edit,
            this.btn_add,
            this.btn_remove});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.toolStrip1.Size = new System.Drawing.Size(1159, 25);
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
			// 
			// btn_add
			// 
			this.btn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(23, 22);
			this.btn_add.Text = "Add";
			// 
			// btn_remove
			// 
			this.btn_remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_remove.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_remove.Name = "btn_remove";
			this.btn_remove.Size = new System.Drawing.Size(23, 22);
			this.btn_remove.Text = "Remove";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
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
			this.splitContainer1.Size = new System.Drawing.Size(1159, 745);
			this.splitContainer1.SplitterDistance = 552;
			this.splitContainer1.TabIndex = 3;
			// 
			// grd_usergroup
			// 
			this.grd_usergroup.AllowUserToAddRows = false;
			this.grd_usergroup.AllowUserToDeleteRows = false;
			this.grd_usergroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_usergroup.ContextMenuStrip = this.cms;
			this.grd_usergroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_usergroup.Location = new System.Drawing.Point(0, 20);
			this.grd_usergroup.MultiSelect = false;
			this.grd_usergroup.Name = "grd_usergroup";
			this.grd_usergroup.ReadOnly = true;
			this.grd_usergroup.RowHeadersVisible = false;
			this.grd_usergroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grd_usergroup.Size = new System.Drawing.Size(552, 725);
			this.grd_usergroup.TabIndex = 1;
			// 
			// cms
			// 
			this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
			this.cms.Name = "cms";
			this.cms.Size = new System.Drawing.Size(118, 70);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.addToolStripMenuItem.Text = "Add";
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Dock = System.Windows.Forms.DockStyle.Top;
			this.label11.Location = new System.Drawing.Point(0, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 20);
			this.label11.TabIndex = 0;
			this.label11.Text = "Usergroup";
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
			this.grd_permission.Size = new System.Drawing.Size(603, 725);
			this.grd_permission.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Top;
			this.label10.Location = new System.Drawing.Point(0, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 20);
			this.label10.TabIndex = 0;
			this.label10.Text = "Permissions";
			// 
			// Form_usergroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1159, 770);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_usergroup";
			this.Text = "Usergroup";
			this.Shown += new System.EventHandler(this.Form_usergroup_Shown);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_usergroup)).EndInit();
			this.cms.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_permission)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_edit;
		private System.Windows.Forms.ToolStripButton btn_add;
		private System.Windows.Forms.ToolStripButton btn_remove;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView grd_permission;
		private System.Windows.Forms.ContextMenuStrip cms;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.DataGridView grd_usergroup;
	}
}