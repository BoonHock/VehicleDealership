namespace VehicleDealership.View
{
	partial class Form_insurance_comprehensive
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
			this.btn_edit = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.grd_ins = new System.Windows.Forms.DataGridView();
			this.listbox_ins = new System.Windows.Forms.ListBox();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grd_ins)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_add,
            this.btn_edit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(716, 25);
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
			this.btn_add.Text = "Add new title";
			this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_edit.Image = global::VehicleDealership.Properties.Resources.CustomActionEditor_16x;
			this.btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(23, 22);
			this.btn_edit.Text = "Edit title";
			this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.89386F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.10615F));
			this.tableLayoutPanel1.Controls.Add(this.grd_ins, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.listbox_ins, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 543);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// grd_ins
			// 
			this.grd_ins.AllowUserToAddRows = false;
			this.grd_ins.AllowUserToDeleteRows = false;
			this.grd_ins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd_ins.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd_ins.Location = new System.Drawing.Point(260, 3);
			this.grd_ins.Name = "grd_ins";
			this.grd_ins.ReadOnly = true;
			this.grd_ins.Size = new System.Drawing.Size(453, 537);
			this.grd_ins.TabIndex = 0;
			// 
			// listbox_ins
			// 
			this.listbox_ins.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listbox_ins.FormattingEnabled = true;
			this.listbox_ins.ItemHeight = 17;
			this.listbox_ins.Location = new System.Drawing.Point(3, 3);
			this.listbox_ins.Name = "listbox_ins";
			this.listbox_ins.Size = new System.Drawing.Size(251, 537);
			this.listbox_ins.TabIndex = 1;
			this.listbox_ins.SelectedValueChanged += new System.EventHandler(this.Listbox_ins_SelectedValueChanged);
			// 
			// Form_insurance_comprehensive
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 568);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form_insurance_comprehensive";
			this.Text = "Insurance comprehensive";
			this.Shown += new System.EventHandler(this.Form_insurance_comprehensive_Shown);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grd_ins)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView grd_ins;
		private System.Windows.Forms.ToolStripButton btn_add;
		private System.Windows.Forms.ListBox listbox_ins;
		private System.Windows.Forms.ToolStripButton btn_edit;
	}
}