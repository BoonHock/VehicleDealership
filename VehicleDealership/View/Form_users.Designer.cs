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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_add = new System.Windows.Forms.ToolStripButton();
			this.btn_remove = new System.Windows.Forms.ToolStripButton();
			this.btn_activate = new System.Windows.Forms.ToolStripButton();
			this.btn_deactivate = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txt_search = new System.Windows.Forms.ToolStripTextBox();
			this.grd_users = new System.Windows.Forms.DataGridView();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_users)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.btn_remove,
            this.btn_activate,
            this.btn_deactivate,
            this.toolStripLabel1,
            this.txt_search});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1292, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
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
			// btn_activate
			// 
			this.btn_activate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_activate.Image = global::VehicleDealership.Properties.Resources.StatusRun_16x;
			this.btn_activate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_activate.Name = "btn_activate";
			this.btn_activate.Size = new System.Drawing.Size(23, 22);
			this.btn_activate.Text = "Activate";
			// 
			// btn_deactivate
			// 
			this.btn_deactivate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_deactivate.Image = global::VehicleDealership.Properties.Resources.StatusStop_16x;
			this.btn_deactivate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_deactivate.Name = "btn_deactivate";
			this.btn_deactivate.Size = new System.Drawing.Size(23, 22);
			this.btn_deactivate.Text = "Deactivate";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
			this.toolStripLabel1.Text = "Search:";
			// 
			// txt_search
			// 
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(100, 25);
			// 
			// grd_users
			// 
			this.grd_users.AllowUserToAddRows = false;
			this.grd_users.AllowUserToDeleteRows = false;
			this.grd_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_users.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_users.Location = new System.Drawing.Point(0, 25);
			this.grd_users.Name = "grd_users";
			this.grd_users.ReadOnly = true;
			this.grd_users.Size = new System.Drawing.Size(1292, 614);
			this.grd_users.TabIndex = 1;
			// 
			// Form_users
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1292, 639);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_add;
		private System.Windows.Forms.ToolStripButton btn_remove;
		private System.Windows.Forms.ToolStripButton btn_activate;
		private System.Windows.Forms.ToolStripButton btn_deactivate;
		private System.Windows.Forms.DataGridView grd_users;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox txt_search;
	}
}