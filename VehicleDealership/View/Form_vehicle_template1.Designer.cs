namespace VehicleDealership.View
{
	partial class Form_vehicle_template1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_add_brand = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_brand = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_brand = new System.Windows.Forms.ToolStripButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btn_add_group = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_group = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_group = new System.Windows.Forms.ToolStripButton();
			this.lv_brand = new System.Windows.Forms.ListView();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.cmb_brand_country = new System.Windows.Forms.ToolStripComboBox();
			this.lv_group = new System.Windows.Forms.ListView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.toolStrip3 = new System.Windows.Forms.ToolStrip();
			this.btn_add_model = new System.Windows.Forms.ToolStripButton();
			this.btn_edit_model = new System.Windows.Forms.ToolStripButton();
			this.btn_delete_model = new System.Windows.Forms.ToolStripButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.toolStrip4 = new System.Windows.Forms.ToolStrip();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.toolStrip3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lv_brand);
			this.groupBox1.Controls.Add(this.toolStrip1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(332, 345);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Brand";
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_brand,
            this.btn_edit_brand,
            this.btn_delete_brand,
            this.toolStripLabel1,
            this.cmb_brand_country});
			this.toolStrip1.Location = new System.Drawing.Point(3, 23);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(326, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_add_brand
			// 
			this.btn_add_brand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_brand.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_brand.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_brand.Name = "btn_add_brand";
			this.btn_add_brand.Size = new System.Drawing.Size(23, 22);
			this.btn_add_brand.Text = "Add";
			// 
			// btn_edit_brand
			// 
			this.btn_edit_brand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_brand.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_brand.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_brand.Name = "btn_edit_brand";
			this.btn_edit_brand.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_brand.Text = "Edit";
			// 
			// btn_delete_brand
			// 
			this.btn_delete_brand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete_brand.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete_brand.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete_brand.Name = "btn_delete_brand";
			this.btn_delete_brand.Size = new System.Drawing.Size(23, 22);
			this.btn_delete_brand.Text = "Delete";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lv_group);
			this.groupBox2.Controls.Add(this.toolStrip2);
			this.groupBox2.Location = new System.Drawing.Point(350, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(351, 345);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Group";
			// 
			// toolStrip2
			// 
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_group,
            this.btn_edit_group,
            this.btn_delete_group});
			this.toolStrip2.Location = new System.Drawing.Point(3, 23);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(345, 25);
			this.toolStrip2.TabIndex = 0;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// btn_add_group
			// 
			this.btn_add_group.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_group.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_group.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_group.Name = "btn_add_group";
			this.btn_add_group.Size = new System.Drawing.Size(23, 22);
			this.btn_add_group.Text = "Add";
			// 
			// btn_edit_group
			// 
			this.btn_edit_group.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_group.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_group.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_group.Name = "btn_edit_group";
			this.btn_edit_group.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_group.Text = "Edit";
			// 
			// btn_delete_group
			// 
			this.btn_delete_group.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete_group.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete_group.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete_group.Name = "btn_delete_group";
			this.btn_delete_group.Size = new System.Drawing.Size(23, 22);
			this.btn_delete_group.Text = "Delete";
			// 
			// lv_brand
			// 
			this.lv_brand.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_brand.FullRowSelect = true;
			this.lv_brand.GridLines = true;
			this.lv_brand.HideSelection = false;
			this.lv_brand.Location = new System.Drawing.Point(3, 48);
			this.lv_brand.Name = "lv_brand";
			this.lv_brand.Size = new System.Drawing.Size(326, 294);
			this.lv_brand.TabIndex = 1;
			this.lv_brand.UseCompatibleStateImageBehavior = false;
			this.lv_brand.View = System.Windows.Forms.View.Details;
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(53, 22);
			this.toolStripLabel1.Text = "Country:";
			// 
			// cmb_brand_country
			// 
			this.cmb_brand_country.Name = "cmb_brand_country";
			this.cmb_brand_country.Size = new System.Drawing.Size(140, 25);
			// 
			// lv_group
			// 
			this.lv_group.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv_group.FullRowSelect = true;
			this.lv_group.GridLines = true;
			this.lv_group.HideSelection = false;
			this.lv_group.Location = new System.Drawing.Point(3, 48);
			this.lv_group.Name = "lv_group";
			this.lv_group.Size = new System.Drawing.Size(345, 294);
			this.lv_group.TabIndex = 2;
			this.lv_group.UseCompatibleStateImageBehavior = false;
			this.lv_group.View = System.Windows.Forms.View.Details;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Controls.Add(this.toolStrip3);
			this.groupBox3.Location = new System.Drawing.Point(12, 363);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1103, 390);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Model";
			// 
			// toolStrip3
			// 
			this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add_model,
            this.btn_edit_model,
            this.btn_delete_model});
			this.toolStrip3.Location = new System.Drawing.Point(3, 23);
			this.toolStrip3.Name = "toolStrip3";
			this.toolStrip3.Size = new System.Drawing.Size(1097, 25);
			this.toolStrip3.TabIndex = 0;
			this.toolStrip3.Text = "toolStrip3";
			// 
			// btn_add_model
			// 
			this.btn_add_model.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_add_model.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.btn_add_model.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_add_model.Name = "btn_add_model";
			this.btn_add_model.Size = new System.Drawing.Size(23, 22);
			this.btn_add_model.Text = "Add";
			// 
			// btn_edit_model
			// 
			this.btn_edit_model.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit_model.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit_model.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit_model.Name = "btn_edit_model";
			this.btn_edit_model.Size = new System.Drawing.Size(23, 22);
			this.btn_edit_model.Text = "Edit";
			// 
			// btn_delete_model
			// 
			this.btn_delete_model.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_delete_model.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.btn_delete_model.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_delete_model.Name = "btn_delete_model";
			this.btn_delete_model.Size = new System.Drawing.Size(23, 22);
			this.btn_delete_model.Text = "Delete";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 48);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1097, 339);
			this.dataGridView1.TabIndex = 1;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.treeView1);
			this.groupBox4.Controls.Add(this.toolStrip4);
			this.groupBox4.Location = new System.Drawing.Point(707, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(408, 345);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Treeview";
			// 
			// toolStrip4
			// 
			this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip4.Location = new System.Drawing.Point(3, 23);
			this.toolStrip4.Name = "toolStrip4";
			this.toolStrip4.Size = new System.Drawing.Size(402, 25);
			this.toolStrip4.TabIndex = 0;
			this.toolStrip4.Text = "toolStrip4";
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(3, 48);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(402, 294);
			this.treeView1.TabIndex = 1;
			// 
			// Form_vehicle_template1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1127, 765);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_vehicle_template1";
			this.Text = "Vehicle";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.toolStrip3.ResumeLayout(false);
			this.toolStrip3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_add_brand;
		private System.Windows.Forms.ToolStripButton btn_edit_brand;
		private System.Windows.Forms.ToolStripButton btn_delete_brand;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btn_add_group;
		private System.Windows.Forms.ToolStripButton btn_edit_group;
		private System.Windows.Forms.ToolStripButton btn_delete_group;
		private System.Windows.Forms.ListView lv_brand;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripComboBox cmb_brand_country;
		private System.Windows.Forms.ListView lv_group;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ToolStrip toolStrip3;
		private System.Windows.Forms.ToolStripButton btn_add_model;
		private System.Windows.Forms.ToolStripButton btn_edit_model;
		private System.Windows.Forms.ToolStripButton btn_delete_model;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ToolStrip toolStrip4;
	}
}