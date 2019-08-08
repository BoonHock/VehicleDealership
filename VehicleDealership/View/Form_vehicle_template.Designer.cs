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
			this.addModelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_add_brand = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_brand_group = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_brand_group = new System.Windows.Forms.ToolStripButton();
			this.label2 = new System.Windows.Forms.Label();
			this.grd_model = new System.Windows.Forms.DataGridView();
			this.cms_model = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btn_add_model = new System.Windows.Forms.ToolStripButton();
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
			this.cms_model.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tv_vehicle
			// 
			this.tv_vehicle.ContextMenuStrip = this.cms_vehicle;
			this.tv_vehicle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tv_vehicle.Location = new System.Drawing.Point(0, 45);
			this.tv_vehicle.Name = "tv_vehicle";
			this.tv_vehicle.Size = new System.Drawing.Size(262, 737);
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
            this.addModelToolStripMenuItem1});
			this.cms_vehicle.Name = "cms_vehicle";
			this.cms_vehicle.Size = new System.Drawing.Size(134, 92);
			// 
			// editBrandGroupToolStripMenuItem
			// 
			this.editBrandGroupToolStripMenuItem.Name = "editBrandGroupToolStripMenuItem";
			this.editBrandGroupToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.editBrandGroupToolStripMenuItem.Text = "Edit";
			this.editBrandGroupToolStripMenuItem.Click += new System.EventHandler(this.Btn_edit_brand_group_Click);
			// 
			// deleteBrandGroupToolStripMenuItem
			// 
			this.deleteBrandGroupToolStripMenuItem.Name = "deleteBrandGroupToolStripMenuItem";
			this.deleteBrandGroupToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.deleteBrandGroupToolStripMenuItem.Text = "Delete";
			this.deleteBrandGroupToolStripMenuItem.Click += new System.EventHandler(this.Btn_delete_brand_group_Click);
			// 
			// addBrandToolStripMenuItem
			// 
			this.addBrandToolStripMenuItem.Name = "addBrandToolStripMenuItem";
			this.addBrandToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.addBrandToolStripMenuItem.Text = "Add brand";
			this.addBrandToolStripMenuItem.Click += new System.EventHandler(this.Add_brand);
			// 
			// addModelToolStripMenuItem1
			// 
			this.addModelToolStripMenuItem1.Name = "addModelToolStripMenuItem1";
			this.addModelToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
			this.addModelToolStripMenuItem1.Text = "Add model";
			this.addModelToolStripMenuItem1.Click += new System.EventHandler(this.Btn_add_model_Click);
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
			this.splitContainer1.Size = new System.Drawing.Size(1386, 782);
			this.splitContainer1.SplitterDistance = 262;
			this.splitContainer1.TabIndex = 3;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_brand,
            this.btn_edit_brand_group,
            this.btn_delete_brand_group});
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
			// btn_edit_brand_group
			// 
			this.btn_edit_brand_group.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_brand_group.Enabled = false;
			this.btn_edit_brand_group.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_brand_group.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_brand_group.Name = "btn_edit_brand_group";
			this.btn_edit_brand_group.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_brand_group.Text = "Edit";
			this.btn_edit_brand_group.Click += new System.EventHandler(this.Btn_edit_brand_group_Click);
			// 
			// btn_delete_brand_group
			// 
			this.btn_delete_brand_group.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete_brand_group.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete_brand_group.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete_brand_group.Name = "btn_delete_brand_group";
			this.btn_delete_brand_group.Size = new System.Drawing.Size(23, 22);
			this.btn_delete_brand_group.Text = "Delete";
			this.btn_delete_brand_group.Click += new System.EventHandler(this.Btn_delete_brand_group_Click);
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
			this.grd_model.ContextMenuStrip = this.cms_model;
			this.grd_model.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_model.Location = new System.Drawing.Point(0, 45);
			this.grd_model.Name = "grd_model";
			this.grd_model.ReadOnly = true;
			this.grd_model.Size = new System.Drawing.Size(1120, 737);
			this.grd_model.TabIndex = 3;
			// 
			// cms_model
			// 
			this.cms_model.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editModelToolStripMenuItem,
            this.addModelToolStripMenuItem,
            this.deleteModelToolStripMenuItem});
			this.cms_model.Name = "cms_model";
			this.cms_model.Size = new System.Drawing.Size(108, 70);
			// 
			// editModelToolStripMenuItem
			// 
			this.editModelToolStripMenuItem.Name = "editModelToolStripMenuItem";
			this.editModelToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.editModelToolStripMenuItem.Text = "Edit";
			this.editModelToolStripMenuItem.Click += new System.EventHandler(this.Btn_edit_model_Click);
			// 
			// addModelToolStripMenuItem
			// 
			this.addModelToolStripMenuItem.Name = "addModelToolStripMenuItem";
			this.addModelToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.addModelToolStripMenuItem.Text = "Add";
			this.addModelToolStripMenuItem.Click += new System.EventHandler(this.AddModelToolStripMenuItem_Click);
			// 
			// deleteModelToolStripMenuItem
			// 
			this.deleteModelToolStripMenuItem.Name = "deleteModelToolStripMenuItem";
			this.deleteModelToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.deleteModelToolStripMenuItem.Text = "Delete";
			// 
			// toolStrip2
			// 
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_model,
            this.btn_edit_model,
            this.btn_delete_model});
			this.toolStrip2.Location = new System.Drawing.Point(0, 20);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(1120, 25);
			this.toolStrip2.TabIndex = 2;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btn_add_model
			// 
			this.btn_add_model.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_model.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_model.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_model.Name = "btn_add_model";
			this.btn_add_model.Size = new System.Drawing.Size(23, 22);
			this.btn_add_model.Text = "Add model";
			this.btn_add_model.Click += new System.EventHandler(this.Btn_add_model_Click);
			// 
			// btn_edit_model
			// 
			this.btn_edit_model.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_model.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_model.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_model.Name = "btn_edit_model";
			this.btn_edit_model.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_model.Text = "Edit model";
			this.btn_edit_model.Click += new System.EventHandler(this.Btn_edit_model_Click);
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
			this.ClientSize = new System.Drawing.Size(1386, 782);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_vehicle_template";
			this.Text = "Vehicle";
			this.Shown += new System.EventHandler(this.Form_vehicle_template_Shown);
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
			this.cms_model.ResumeLayout(false);
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView tv_vehicle;
		private System.Windows.Forms.ContextMenuStrip cms_vehicle;
		private System.Windows.Forms.ToolStripMenuItem addBrandToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_add_brand;
		private System.Windows.Forms.ToolStripButton btn_edit_brand_group;
		private System.Windows.Forms.ToolStripButton btn_delete_brand_group;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btn_add_model;
		private System.Windows.Forms.ToolStripButton btn_edit_model;
		private System.Windows.Forms.ToolStripButton btn_delete_model;
		private System.Windows.Forms.DataGridView grd_model;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem editBrandGroupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteBrandGroupToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip cms_model;
		private System.Windows.Forms.ToolStripMenuItem editModelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addModelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteModelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addModelToolStripMenuItem1;
	}
}