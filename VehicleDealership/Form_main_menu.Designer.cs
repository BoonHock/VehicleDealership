namespace VehicleDealership.View
{
	partial class Form_main_menu
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.grd_test = new System.Windows.Forms.DataGridView();
			this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_test)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.administratorToolStripMenuItem,
            this.salesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// logInToolStripMenuItem
			// 
			this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
			this.logInToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.logInToolStripMenuItem.Text = "Log In";
			// 
			// grd_test
			// 
			this.grd_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_test.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_test.Location = new System.Drawing.Point(0, 24);
			this.grd_test.Name = "grd_test";
			this.grd_test.Size = new System.Drawing.Size(800, 426);
			this.grd_test.TabIndex = 2;
			// 
			// administratorToolStripMenuItem
			// 
			this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
			this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
			this.administratorToolStripMenuItem.Text = "Administrator";
			// 
			// salesToolStripMenuItem
			// 
			this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
			this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.salesToolStripMenuItem.Text = "Sales";
			// 
			// Form_main_menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.grd_test);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form_main_menu";
			this.Text = "Form_main_menu";
			this.Load += new System.EventHandler(this.Form_main_menu_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_test)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
		private System.Windows.Forms.DataGridView grd_test;
		private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
	}
}