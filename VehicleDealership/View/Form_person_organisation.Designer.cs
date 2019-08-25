namespace VehicleDealership.View
{
	partial class Form_person_organisation
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tab_person = new System.Windows.Forms.TabPage();
			this.grd_person = new System.Windows.Forms.DataGridView();
			this.tab_organisation = new System.Windows.Forms.TabPage();
			this.grd_organisation = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tab_person.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_person)).BeginInit();
			this.tab_organisation.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_organisation)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 517);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(761, 59);
			this.panel1.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(532, 6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(217, 41);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_cancel.AutoSize = true;
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Location = new System.Drawing.Point(115, 5);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(95, 30);
			this.btn_cancel.TabIndex = 0;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
			// 
			// btn_ok
			// 
			this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_ok.AutoSize = true;
			this.btn_ok.Location = new System.Drawing.Point(6, 5);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(95, 30);
			this.btn_ok.TabIndex = 1;
			this.btn_ok.Text = "OK";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tab_person);
			this.tabControl1.Controls.Add(this.tab_organisation);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(761, 517);
			this.tabControl1.TabIndex = 4;
			// 
			// tab_person
			// 
			this.tab_person.Controls.Add(this.grd_person);
			this.tab_person.Location = new System.Drawing.Point(4, 29);
			this.tab_person.Name = "tab_person";
			this.tab_person.Padding = new System.Windows.Forms.Padding(3);
			this.tab_person.Size = new System.Drawing.Size(753, 484);
			this.tab_person.TabIndex = 0;
			this.tab_person.Text = "Person";
			this.tab_person.UseVisualStyleBackColor = true;
			// 
			// grd_person
			// 
			this.grd_person.AllowUserToAddRows = false;
			this.grd_person.AllowUserToDeleteRows = false;
			this.grd_person.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_person.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_person.Location = new System.Drawing.Point(3, 3);
			this.grd_person.MultiSelect = false;
			this.grd_person.Name = "grd_person";
			this.grd_person.ReadOnly = true;
			this.grd_person.Size = new System.Drawing.Size(747, 478);
			this.grd_person.TabIndex = 1;
			// 
			// tab_organisation
			// 
			this.tab_organisation.Controls.Add(this.grd_organisation);
			this.tab_organisation.Location = new System.Drawing.Point(4, 29);
			this.tab_organisation.Name = "tab_organisation";
			this.tab_organisation.Padding = new System.Windows.Forms.Padding(3);
			this.tab_organisation.Size = new System.Drawing.Size(753, 484);
			this.tab_organisation.TabIndex = 1;
			this.tab_organisation.Text = "Organisation";
			this.tab_organisation.UseVisualStyleBackColor = true;
			// 
			// grd_organisation
			// 
			this.grd_organisation.AllowUserToAddRows = false;
			this.grd_organisation.AllowUserToDeleteRows = false;
			this.grd_organisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_organisation.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_organisation.Location = new System.Drawing.Point(3, 3);
			this.grd_organisation.MultiSelect = false;
			this.grd_organisation.Name = "grd_organisation";
			this.grd_organisation.ReadOnly = true;
			this.grd_organisation.Size = new System.Drawing.Size(747, 478);
			this.grd_organisation.TabIndex = 0;
			// 
			// Form_person_organisation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 576);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_person_organisation";
			this.Text = "Select";
			this.Shown += new System.EventHandler(this.Form_person_organisation_Shown);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tab_person.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_person)).EndInit();
			this.tab_organisation.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_organisation)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tab_person;
		private System.Windows.Forms.TabPage tab_organisation;
		private System.Windows.Forms.DataGridView grd_person;
		private System.Windows.Forms.DataGridView grd_organisation;
	}
}