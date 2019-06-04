namespace VehicleDealership.View
{
	partial class Form_simulate_user
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
			this.Grd_users = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.Txt_search = new System.Windows.Forms.ToolStripTextBox();
			((System.ComponentModel.ISupportInitialize)(this.Grd_users)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Grd_users
			// 
			this.Grd_users.AllowUserToAddRows = false;
			this.Grd_users.AllowUserToDeleteRows = false;
			this.Grd_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_users.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Grd_users.Location = new System.Drawing.Point(0, 25);
			this.Grd_users.MultiSelect = false;
			this.Grd_users.Name = "Grd_users";
			this.Grd_users.ReadOnly = true;
			this.Grd_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Grd_users.Size = new System.Drawing.Size(881, 571);
			this.Grd_users.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.Txt_search});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(881, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
			this.toolStripLabel1.Text = "Search:";
			// 
			// Txt_search
			// 
			this.Txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Txt_search.Name = "Txt_search";
			this.Txt_search.Size = new System.Drawing.Size(200, 25);
			this.Txt_search.TextChanged += new System.EventHandler(this.Txt_search_TextChanged);
			// 
			// Form_simulate_user
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(881, 596);
			this.Controls.Add(this.Grd_users);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_simulate_user";
			this.Text = "Simulate user";
			this.Load += new System.EventHandler(this.Form_simulate_user_Load);
			((System.ComponentModel.ISupportInitialize)(this.Grd_users)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView Grd_users;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox Txt_search;
	}
}