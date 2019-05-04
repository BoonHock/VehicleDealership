namespace VehicleDealership.View
{
	partial class Form_sales_order
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
			this.grd_sales_order = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.Txt_search = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.rad_all = new System.Windows.Forms.RadioButton();
			this.rad_active = new System.Windows.Forms.RadioButton();
			this.rad_inactive = new System.Windows.Forms.RadioButton();
			this.ts_insert = new System.Windows.Forms.ToolStripButton();
			this.ts_edit = new System.Windows.Forms.ToolStripButton();
			this.ts_delete = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.grd_sales_order)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grd_sales_order
			// 
			this.grd_sales_order.AllowUserToAddRows = false;
			this.grd_sales_order.AllowUserToDeleteRows = false;
			this.grd_sales_order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grd_sales_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_sales_order.Location = new System.Drawing.Point(13, 65);
			this.grd_sales_order.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.grd_sales_order.Name = "grd_sales_order";
			this.grd_sales_order.ReadOnly = true;
			this.grd_sales_order.Size = new System.Drawing.Size(1123, 555);
			this.grd_sales_order.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 32);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Search:";
			// 
			// Txt_search
			// 
			this.Txt_search.Location = new System.Drawing.Point(80, 28);
			this.Txt_search.Name = "Txt_search";
			this.Txt_search.Size = new System.Drawing.Size(378, 29);
			this.Txt_search.TabIndex = 2;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_insert,
            this.ts_edit,
            this.ts_delete});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1149, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// rad_all
			// 
			this.rad_all.AutoSize = true;
			this.rad_all.Checked = true;
			this.rad_all.Location = new System.Drawing.Point(927, 30);
			this.rad_all.Name = "rad_all";
			this.rad_all.Size = new System.Drawing.Size(46, 25);
			this.rad_all.TabIndex = 0;
			this.rad_all.TabStop = true;
			this.rad_all.Text = "All";
			this.rad_all.UseVisualStyleBackColor = true;
			// 
			// rad_active
			// 
			this.rad_active.AutoSize = true;
			this.rad_active.Location = new System.Drawing.Point(979, 30);
			this.rad_active.Name = "rad_active";
			this.rad_active.Size = new System.Drawing.Size(70, 25);
			this.rad_active.TabIndex = 1;
			this.rad_active.Text = "Active";
			this.rad_active.UseVisualStyleBackColor = true;
			// 
			// rad_inactive
			// 
			this.rad_inactive.AutoSize = true;
			this.rad_inactive.Location = new System.Drawing.Point(1055, 30);
			this.rad_inactive.Name = "rad_inactive";
			this.rad_inactive.Size = new System.Drawing.Size(81, 25);
			this.rad_inactive.TabIndex = 2;
			this.rad_inactive.Text = "Inactive";
			this.rad_inactive.UseVisualStyleBackColor = true;
			// 
			// ts_insert
			// 
			this.ts_insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ts_insert.Image = global::VehicleDealership.Properties.Resources.Add_16x;
			this.ts_insert.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ts_insert.Name = "ts_insert";
			this.ts_insert.Size = new System.Drawing.Size(23, 22);
			this.ts_insert.Text = "Insert";
			this.ts_insert.Click += new System.EventHandler(this.Ts_insert_Click);
			// 
			// ts_edit
			// 
			this.ts_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ts_edit.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.ts_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ts_edit.Name = "ts_edit";
			this.ts_edit.Size = new System.Drawing.Size(23, 22);
			this.ts_edit.Text = "Edit";
			this.ts_edit.Click += new System.EventHandler(this.Ts_edit_Click);
			// 
			// ts_delete
			// 
			this.ts_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ts_delete.Image = global::VehicleDealership.Properties.Resources.Cancel_16x;
			this.ts_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ts_delete.Name = "ts_delete";
			this.ts_delete.Size = new System.Drawing.Size(23, 22);
			this.ts_delete.Text = "Delete";
			this.ts_delete.Click += new System.EventHandler(this.Ts_delete_Click);
			// 
			// Form_sales_order
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1149, 634);
			this.Controls.Add(this.rad_inactive);
			this.Controls.Add(this.rad_active);
			this.Controls.Add(this.rad_all);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.Txt_search);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grd_sales_order);
			this.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_sales_order";
			this.Text = "Sales order";
			this.Load += new System.EventHandler(this.Form_sales_order_Load);
			((System.ComponentModel.ISupportInitialize)(this.grd_sales_order)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grd_sales_order;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Txt_search;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton ts_insert;
		private System.Windows.Forms.ToolStripButton ts_edit;
		private System.Windows.Forms.ToolStripButton ts_delete;
		private System.Windows.Forms.RadioButton rad_all;
		private System.Windows.Forms.RadioButton rad_inactive;
		private System.Windows.Forms.RadioButton rad_active;
	}
}