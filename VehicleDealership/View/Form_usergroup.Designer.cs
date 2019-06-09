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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txt_search = new System.Windows.Forms.ToolStripTextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btn_edit = new System.Windows.Forms.ToolStripButton();
			this.btn_add = new System.Windows.Forms.ToolStripButton();
			this.btn_remove = new System.Windows.Forms.ToolStripButton();
			this.Grd_usergroup = new System.Windows.Forms.DataGridView();
			this.listview_permissions = new System.Windows.Forms.ListView();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Grd_usergroup)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_edit,
            this.btn_add,
            this.btn_remove,
            this.toolStripLabel1,
            this.txt_search});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(896, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
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
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.Grd_usergroup);
			this.splitContainer1.Panel1.Controls.Add(this.label11);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.listview_permissions);
			this.splitContainer1.Panel2.Controls.Add(this.label10);
			this.splitContainer1.Size = new System.Drawing.Size(896, 588);
			this.splitContainer1.SplitterDistance = 427;
			this.splitContainer1.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Dock = System.Windows.Forms.DockStyle.Top;
			this.label11.Location = new System.Drawing.Point(0, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(78, 20);
			this.label11.TabIndex = 3;
			this.label11.Text = "Usergroup";
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
			// btn_edit
			// 
			this.btn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(23, 22);
			this.btn_edit.Text = "Edit";
			this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
			// 
			// btn_add
			// 
			this.btn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(23, 22);
			this.btn_add.Text = "Add";
			this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
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
			// Grd_usergroup
			// 
			this.Grd_usergroup.AllowUserToAddRows = false;
			this.Grd_usergroup.AllowUserToDeleteRows = false;
			this.Grd_usergroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_usergroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Grd_usergroup.Location = new System.Drawing.Point(0, 20);
			this.Grd_usergroup.Name = "Grd_usergroup";
			this.Grd_usergroup.ReadOnly = true;
			this.Grd_usergroup.RowHeadersVisible = false;
			this.Grd_usergroup.Size = new System.Drawing.Size(427, 568);
			this.Grd_usergroup.TabIndex = 4;
			// 
			// listview_permissions
			// 
			this.listview_permissions.CheckBoxes = true;
			this.listview_permissions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listview_permissions.GridLines = true;
			this.listview_permissions.Location = new System.Drawing.Point(0, 20);
			this.listview_permissions.Name = "listview_permissions";
			this.listview_permissions.Size = new System.Drawing.Size(465, 568);
			this.listview_permissions.TabIndex = 3;
			this.listview_permissions.UseCompatibleStateImageBehavior = false;
			this.listview_permissions.View = System.Windows.Forms.View.Details;
			// 
			// Form_usergroup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 613);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_usergroup";
			this.Text = "Usergroup";
			this.Load += new System.EventHandler(this.Form_usergroup_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Grd_usergroup)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_edit;
		private System.Windows.Forms.ToolStripButton btn_add;
		private System.Windows.Forms.ToolStripButton btn_remove;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox txt_search;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView Grd_usergroup;
		private System.Windows.Forms.ListView listview_permissions;
	}
}