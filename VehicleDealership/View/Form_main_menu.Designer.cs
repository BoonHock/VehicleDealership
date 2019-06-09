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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main_menu));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.gODMODEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.simulateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gODMODEToolStripMenuItem,
            this.administratorToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(841, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// gODMODEToolStripMenuItem
			// 
			this.gODMODEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulateUserToolStripMenuItem});
			this.gODMODEToolStripMenuItem.Name = "gODMODEToolStripMenuItem";
			this.gODMODEToolStripMenuItem.Size = new System.Drawing.Size(81, 19);
			this.gODMODEToolStripMenuItem.Text = "GOD MODE";
			// 
			// simulateUserToolStripMenuItem
			// 
			this.simulateUserToolStripMenuItem.Name = "simulateUserToolStripMenuItem";
			this.simulateUserToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.simulateUserToolStripMenuItem.Text = "Simulate user";
			// 
			// administratorToolStripMenuItem
			// 
			this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.userGroupsToolStripMenuItem});
			this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
			this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 19);
			this.administratorToolStripMenuItem.Text = "Administrator";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.usersToolStripMenuItem.Text = "Users";
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
			this.salesOrderToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.salesOrderToolStripMenuItem.Text = "Sales order";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// userGroupsToolStripMenuItem
			// 
			this.userGroupsToolStripMenuItem.Name = "userGroupsToolStripMenuItem";
			this.userGroupsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.userGroupsToolStripMenuItem.Text = "Usergroups";
			// 
			// Form_main_menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 596);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_main_menu";
			this.Text = "Vehicle Dealership";
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
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gODMODEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem simulateUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userGroupsToolStripMenuItem;
	}
}