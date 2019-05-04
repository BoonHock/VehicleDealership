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
			this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem,
            this.salesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(850, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// administratorToolStripMenuItem
			// 
			this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
			this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 19);
			this.administratorToolStripMenuItem.Text = "Administrator";
			// 
			// salesToolStripMenuItem
			// 
			this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesOrderToolStripMenuItem});
			this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
			this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
			this.salesToolStripMenuItem.Text = "Sales";
			// 
			// salesOrderToolStripMenuItem
			// 
			this.salesOrderToolStripMenuItem.Name = "salesOrderToolStripMenuItem";
			this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.salesOrderToolStripMenuItem.Text = "Sales order";
			// 
			// Form_main_menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 727);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_main_menu";
			this.Text = "Form_main_menu";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form_main_menu_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
	}
}