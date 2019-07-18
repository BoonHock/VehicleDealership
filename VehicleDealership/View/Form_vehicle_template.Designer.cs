namespace VehicleDealership.View
{
	partial class Form_vehicle_template
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
			this.tv_vehicle = new System.Windows.Forms.TreeView();
			this.cms_vehicle = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editBrandGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteBrandGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_add_brand = new System.Windows.Forms.ToolStripButton();
			this.btn_add_group = new System.Windows.Forms.ToolStripButton();
			this.btn_edit = new System.Windows.Forms.ToolStripButton();
			this.btn_delete = new System.Windows.Forms.ToolStripButton();
			this.label2 = new System.Windows.Forms.Label();
			this.grd_model = new System.Windows.Forms.DataGridView();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_model = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_model = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.cms_vehicle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_model)).BeginInit();
			this.toolStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tv_vehicle
			// 
			this.tv_vehicle.ContextMenuStrip = this.cms_vehicle;
			this.tv_vehicle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tv_vehicle.Location = new System.Drawing.Point(0, 45);
			this.tv_vehicle.Name = "tv_vehicle";
			this.tv_vehicle.Size = new System.Drawing.Size(262, 498);
			this.tv_vehicle.TabIndex = 0;
			this.tv_vehicle.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tv_vehicle_AfterSelect);
			this.tv_vehicle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tv_vehicle_MouseDown);
			// 
			// cms_vehicle
			// 
			this.cms_vehicle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBrandGroupToolStripMenuItem,
            this.deleteBrandGroupToolStripMenuItem,
            this.addBrandToolStripMenuItem,
            this.addGroupToolStripMenuItem});
			this.cms_vehicle.Name = "cms_vehicle";
			this.cms_vehicle.Size = new System.Drawing.Size(132, 92);
			// 
			// editBrandGroupToolStripMenuItem
			// 
			this.editBrandGroupToolStripMenuItem.Name = "editBrandGroupToolStripMenuItem";
			this.editBrandGroupToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.editBrandGroupToolStripMenuItem.Text = "Edit";
			// 
			// deleteBrandGroupToolStripMenuItem
			// 
			this.deleteBrandGroupToolStripMenuItem.Name = "deleteBrandGroupToolStripMenuItem";
			this.deleteBrandGroupToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.deleteBrandGroupToolStripMenuItem.Text = "Delete";
			// 
			// addBrandToolStripMenuItem
			// 
			this.addBrandToolStripMenuItem.Name = "addBrandToolStripMenuItem";
			this.addBrandToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.addBrandToolStripMenuItem.Text = "Add brand";
			this.addBrandToolStripMenuItem.Click += new System.EventHandler(this.Add_brand);
			// 
			// addGroupToolStripMenuItem
			// 
			this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
			this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.addGroupToolStripMenuItem.Text = "Add group";
			this.addGroupToolStripMenuItem.Click += new System.EventHandler(this.Add_group);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tv_vehicle);
			this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.grd_model);
			this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Size = new System.Drawing.Size(955, 543);
			this.splitContainer1.SplitterDistance = 262;
			this.splitContainer1.TabIndex = 3;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_brand,
            this.btn_add_group,
            this.btn_edit,
            this.btn_delete});
			this.toolStrip1.Location = new System.Drawing.Point(0, 20);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(262, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_add_brand
			// 
			this.btn_add_brand.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_brand.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_brand.Name = "btn_add_brand";
			this.btn_add_brand.Size = new System.Drawing.Size(58, 22);
			this.btn_add_brand.Text = "Brand";
			this.btn_add_brand.ToolTipText = "Add brand";
			this.btn_add_brand.Click += new System.EventHandler(this.Add_brand);
			// 
			// btn_add_group
			// 
			this.btn_add_group.Enabled = false;
			this.btn_add_group.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_group.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_group.Name = "btn_add_group";
			this.btn_add_group.Size = new System.Drawing.Size(60, 22);
			this.btn_add_group.Text = "Group";
			this.btn_add_group.ToolTipText = "Add group";
			this.btn_add_group.Click += new System.EventHandler(this.Add_group);
			// 
			// btn_edit
			// 
			this.btn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit.Enabled = false;
			this.btn_edit.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(23, 22);
			this.btn_edit.Text = "Edit";
			this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete.Enabled = false;
			this.btn_delete.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(23, 22);
			this.btn_delete.Text = "Delete";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Brand and Group";
			// 
			// grd_model
			// 
			this.grd_model.AllowUserToAddRows = false;
			this.grd_model.AllowUserToDeleteRows = false;
			this.grd_model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_model.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_model.Location = new System.Drawing.Point(0, 45);
			this.grd_model.Name = "grd_model";
			this.grd_model.ReadOnly = true;
			this.grd_model.Size = new System.Drawing.Size(689, 498);
			this.grd_model.TabIndex = 3;
			// 
			// toolStrip2
			// 
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.btn_edit_model,
            this.btn_delete_model});
			this.toolStrip2.Location = new System.Drawing.Point(0, 20);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(689, 25);
			this.toolStrip2.TabIndex = 2;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "Add model";
			// 
			// btn_edit_model
			// 
			this.btn_edit_model.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_model.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_model.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_model.Name = "btn_edit_model";
			this.btn_edit_model.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_model.Text = "Edit model";
			// 
			// btn_delete_model
			// 
			this.btn_delete_model.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete_model.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete_model.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete_model.Name = "btn_delete_model";
			this.btn_delete_model.Size = new System.Drawing.Size(23, 22);
			this.btn_delete_model.Text = "Delete model";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Model";
			// 
			// Form_vehicle_template
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(955, 543);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_vehicle_template";
			this.Text = "Vehicle";
			this.Load += new System.EventHandler(this.Form_vehicle_template_Load);
			this.cms_vehicle.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_model)).EndInit();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView tv_vehicle;
		private System.Windows.Forms.ContextMenuStrip cms_vehicle;
		private System.Windows.Forms.ToolStripMenuItem addBrandToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_add_brand;
		private System.Windows.Forms.ToolStripButton btn_edit;
		private System.Windows.Forms.ToolStripButton btn_add_group;
		private System.Windows.Forms.ToolStripButton btn_delete;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton btn_edit_model;
		private System.Windows.Forms.ToolStripButton btn_delete_model;
		private System.Windows.Forms.DataGridView grd_model;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem editBrandGroupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteBrandGroupToolStripMenuItem;
	}
}