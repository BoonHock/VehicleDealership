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
			this.main_menu_strip = new System.Windows.Forms.MenuStrip();
			this.gODMODEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.simulateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userGroupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.log_in_menustrip = new System.Windows.Forms.MenuStrip();
			this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ssl_usergroup = new System.Windows.Forms.ToolStripStatusLabel();
			this.ssl_username = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.main_menu_strip.SuspendLayout();
			this.log_in_menustrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// main_menu_strip
			// 
			this.main_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gODMODEToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.logOutToolStripMenuItem});
			this.main_menu_strip.Location = new System.Drawing.Point(0, 24);
			this.main_menu_strip.Name = "main_menu_strip";
			this.main_menu_strip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
			this.main_menu_strip.Size = new System.Drawing.Size(841, 25);
			this.main_menu_strip.TabIndex = 1;
			this.main_menu_strip.Text = "menuStrip1";
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
			// administrationToolStripMenuItem
			// 
			this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.userGroupsToolStripMenuItem,
            this.vehicleToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
			this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
			this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 19);
			this.administrationToolStripMenuItem.Text = "Administration";
			// 
			// usersToolStripMenuItem
			// 
			this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.usersToolStripMenuItem.Text = "Users";
			// 
			// userGroupsToolStripMenuItem
			// 
			this.userGroupsToolStripMenuItem.Name = "userGroupsToolStripMenuItem";
			this.userGroupsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.userGroupsToolStripMenuItem.Text = "Usergroups";
			// 
			// changePasswordToolStripMenuItem
			// 
			this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.changePasswordToolStripMenuItem.Text = "Change password";
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
			// logOutToolStripMenuItem
			// 
			this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
			this.logOutToolStripMenuItem.Text = "Log out";
			this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
			// 
			// log_in_menustrip
			// 
			this.log_in_menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem});
			this.log_in_menustrip.Location = new System.Drawing.Point(0, 0);
			this.log_in_menustrip.Name = "log_in_menustrip";
			this.log_in_menustrip.Size = new System.Drawing.Size(841, 24);
			this.log_in_menustrip.TabIndex = 3;
			this.log_in_menustrip.Text = "menuStrip1";
			// 
			// logInToolStripMenuItem
			// 
			this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
			this.logInToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.logInToolStripMenuItem.Text = "Log in";
			this.logInToolStripMenuItem.Click += new System.EventHandler(this.LogInToolStripMenuItem_Click);
			// 
			// vehicleToolStripMenuItem
			// 
			this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelToolStripMenuItem,
            this.brandToolStripMenuItem});
			this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
			this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.vehicleToolStripMenuItem.Text = "Vehicle";
			// 
			// modelToolStripMenuItem
			// 
			this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
			this.modelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.modelToolStripMenuItem.Text = "Model";
			// 
			// brandToolStripMenuItem
			// 
			this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
			this.brandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.brandToolStripMenuItem.Text = "Brand";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ssl_username,
            this.toolStripStatusLabel2,
            this.ssl_usergroup});
			this.statusStrip1.Location = new System.Drawing.Point(0, 572);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(841, 24);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// ssl_usergroup
			// 
			this.ssl_usergroup.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.ssl_usergroup.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.ssl_usergroup.Name = "ssl_usergroup";
			this.ssl_usergroup.Size = new System.Drawing.Size(66, 19);
			this.ssl_usergroup.Text = "Usergroup";
			// 
			// ssl_username
			// 
			this.ssl_username.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.ssl_username.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.ssl_username.Name = "ssl_username";
			this.ssl_username.Size = new System.Drawing.Size(64, 19);
			this.ssl_username.Text = "Username";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(70, 19);
			this.toolStripStatusLabel1.Text = "Username :";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
			this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(72, 19);
			this.toolStripStatusLabel2.Text = "Usergroup :";
			// 
			// Form_main_menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 596);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.main_menu_strip);
			this.Controls.Add(this.log_in_menustrip);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.main_menu_strip;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_main_menu";
			this.Text = "Vehicle Dealership";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form_main_menu_Load);
			this.Shown += new System.EventHandler(this.Form_main_menu_Shown);
			this.main_menu_strip.ResumeLayout(false);
			this.main_menu_strip.PerformLayout();
			this.log_in_menustrip.ResumeLayout(false);
			this.log_in_menustrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip main_menu_strip;
		private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesOrderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gODMODEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem simulateUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem userGroupsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
		private System.Windows.Forms.MenuStrip log_in_menustrip;
		private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel ssl_username;
		private System.Windows.Forms.ToolStripStatusLabel ssl_usergroup;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
	}
}