namespace VehicleDealership.View
{
	partial class Form_edit_payment
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
			this.label1 = new System.Windows.Forms.Label();
			this.dtp_payment_date = new System.Windows.Forms.DateTimePicker();
			this.num_amount = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.rad_paid = new System.Windows.Forms.RadioButton();
			this.rad_unpaid = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_ok = new System.Windows.Forms.Button();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.rad_credit_debit_card = new System.Windows.Forms.RadioButton();
			this.rad_cheque = new System.Windows.Forms.RadioButton();
			this.rad_other = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.maskedtxt_credit_card_no = new System.Windows.Forms.MaskedTextBox();
			this.lbl_credit_card_no = new System.Windows.Forms.Label();
			this.cmb_payment_method = new System.Windows.Forms.ComboBox();
			this.lbl_payment_method = new System.Windows.Forms.Label();
			this.dtp_payment_method_date = new System.Windows.Forms.DateTimePicker();
			this.txt_payment_method_finance = new System.Windows.Forms.TextBox();
			this.cmb_credit_card_type = new System.Windows.Forms.ComboBox();
			this.btn_payment_method_finance = new System.Windows.Forms.Button();
			this.lbl_credit_card_type = new System.Windows.Forms.Label();
			this.lbl_payment_method_date = new System.Windows.Forms.Label();
			this.lbl_payment_method_finance = new System.Windows.Forms.Label();
			this.txt_cheque_no = new System.Windows.Forms.TextBox();
			this.lbl_cheque_no = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_remark = new System.Windows.Forms.TextBox();
			this.txt_pay_to = new System.Windows.Forms.TextBox();
			this.btn_pay_to = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_description = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_payment_no = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_pay_to_type = new System.Windows.Forms.TextBox();
			this.num_pay_to_id = new System.Windows.Forms.NumericUpDown();
			this.num_payment_method_finance = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.num_amount)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_pay_to_id)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_payment_method_finance)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(330, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Payment date:";
			// 
			// dtp_payment_date
			// 
			this.dtp_payment_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_payment_date.Location = new System.Drawing.Point(445, 45);
			this.dtp_payment_date.Name = "dtp_payment_date";
			this.dtp_payment_date.Size = new System.Drawing.Size(133, 27);
			this.dtp_payment_date.TabIndex = 2;
			// 
			// num_amount
			// 
			this.num_amount.DecimalPlaces = 2;
			this.num_amount.Location = new System.Drawing.Point(445, 80);
			this.num_amount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
			this.num_amount.Name = "num_amount";
			this.num_amount.Size = new System.Drawing.Size(133, 27);
			this.num_amount.TabIndex = 4;
			this.num_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.num_amount.ThousandsSeparator = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(330, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Amount (MYR):";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.rad_paid);
			this.flowLayoutPanel1.Controls.Add(this.rad_unpaid);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(111, 78);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(160, 31);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// rad_paid
			// 
			this.rad_paid.AutoSize = true;
			this.rad_paid.Checked = true;
			this.rad_paid.Location = new System.Drawing.Point(3, 3);
			this.rad_paid.Name = "rad_paid";
			this.rad_paid.Size = new System.Drawing.Size(49, 24);
			this.rad_paid.TabIndex = 0;
			this.rad_paid.TabStop = true;
			this.rad_paid.Text = "Yes";
			this.rad_paid.UseVisualStyleBackColor = true;
			// 
			// rad_unpaid
			// 
			this.rad_unpaid.AutoSize = true;
			this.rad_unpaid.Location = new System.Drawing.Point(58, 3);
			this.rad_unpaid.Name = "rad_unpaid";
			this.rad_unpaid.Size = new System.Drawing.Size(47, 24);
			this.rad_unpaid.TabIndex = 1;
			this.rad_unpaid.Text = "No";
			this.rad_unpaid.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Paid:";
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.tableLayoutPanel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 513);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(594, 47);
			this.panel1.TabIndex = 9;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.btn_cancel, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btn_ok, 0, 0);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(422, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 39);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// btn_cancel
			// 
			this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_cancel.AutoSize = true;
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Location = new System.Drawing.Point(89, 4);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(74, 31);
			this.btn_cancel.TabIndex = 1;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
			// 
			// btn_ok
			// 
			this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_ok.AutoSize = true;
			this.btn_ok.Location = new System.Drawing.Point(5, 4);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(74, 31);
			this.btn_ok.TabIndex = 0;
			this.btn_ok.Text = "OK";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Controls.Add(this.rad_credit_debit_card);
			this.flowLayoutPanel2.Controls.Add(this.rad_cheque);
			this.flowLayoutPanel2.Controls.Add(this.rad_other);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 23);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(423, 30);
			this.flowLayoutPanel2.TabIndex = 5;
			// 
			// rad_credit_debit_card
			// 
			this.rad_credit_debit_card.AutoSize = true;
			this.rad_credit_debit_card.Checked = true;
			this.rad_credit_debit_card.Location = new System.Drawing.Point(3, 3);
			this.rad_credit_debit_card.Name = "rad_credit_debit_card";
			this.rad_credit_debit_card.Size = new System.Drawing.Size(141, 24);
			this.rad_credit_debit_card.TabIndex = 0;
			this.rad_credit_debit_card.TabStop = true;
			this.rad_credit_debit_card.Text = "Credit/debit card";
			this.rad_credit_debit_card.UseVisualStyleBackColor = true;
			this.rad_credit_debit_card.CheckedChanged += new System.EventHandler(this.Rad_payment_method_CheckedChanged);
			// 
			// rad_cheque
			// 
			this.rad_cheque.AutoSize = true;
			this.rad_cheque.Location = new System.Drawing.Point(150, 3);
			this.rad_cheque.Name = "rad_cheque";
			this.rad_cheque.Size = new System.Drawing.Size(77, 24);
			this.rad_cheque.TabIndex = 1;
			this.rad_cheque.Text = "Cheque";
			this.rad_cheque.UseVisualStyleBackColor = true;
			this.rad_cheque.CheckedChanged += new System.EventHandler(this.Rad_payment_method_CheckedChanged);
			// 
			// rad_other
			// 
			this.rad_other.AutoSize = true;
			this.rad_other.Location = new System.Drawing.Point(233, 3);
			this.rad_other.Name = "rad_other";
			this.rad_other.Size = new System.Drawing.Size(64, 24);
			this.rad_other.TabIndex = 2;
			this.rad_other.Text = "Other";
			this.rad_other.UseVisualStyleBackColor = true;
			this.rad_other.CheckedChanged += new System.EventHandler(this.Rad_payment_method_CheckedChanged);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.maskedtxt_credit_card_no, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.lbl_credit_card_no, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.cmb_payment_method, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.lbl_payment_method, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.dtp_payment_method_date, 1, 5);
			this.tableLayoutPanel3.Controls.Add(this.txt_payment_method_finance, 1, 4);
			this.tableLayoutPanel3.Controls.Add(this.cmb_credit_card_type, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.btn_payment_method_finance, 2, 4);
			this.tableLayoutPanel3.Controls.Add(this.lbl_credit_card_type, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.lbl_payment_method_date, 0, 5);
			this.tableLayoutPanel3.Controls.Add(this.lbl_payment_method_finance, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.txt_cheque_no, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.lbl_cheque_no, 0, 2);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 53);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 7;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(423, 208);
			this.tableLayoutPanel3.TabIndex = 7;
			// 
			// maskedtxt_credit_card_no
			// 
			this.maskedtxt_credit_card_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.maskedtxt_credit_card_no.Location = new System.Drawing.Point(134, 37);
			this.maskedtxt_credit_card_no.Mask = "0000 0000 0000 0000";
			this.maskedtxt_credit_card_no.Name = "maskedtxt_credit_card_no";
			this.maskedtxt_credit_card_no.Size = new System.Drawing.Size(253, 27);
			this.maskedtxt_credit_card_no.TabIndex = 1;
			this.maskedtxt_credit_card_no.Leave += new System.EventHandler(this.Maskedtxt_credit_card_no_Leave);
			// 
			// lbl_credit_card_no
			// 
			this.lbl_credit_card_no.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_credit_card_no.AutoSize = true;
			this.lbl_credit_card_no.BackColor = System.Drawing.Color.Yellow;
			this.lbl_credit_card_no.Location = new System.Drawing.Point(3, 40);
			this.lbl_credit_card_no.Name = "lbl_credit_card_no";
			this.lbl_credit_card_no.Size = new System.Drawing.Size(98, 20);
			this.lbl_credit_card_no.TabIndex = 0;
			this.lbl_credit_card_no.Text = "Card number:";
			// 
			// cmb_payment_method
			// 
			this.cmb_payment_method.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cmb_payment_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_payment_method.FormattingEnabled = true;
			this.cmb_payment_method.Location = new System.Drawing.Point(134, 3);
			this.cmb_payment_method.Name = "cmb_payment_method";
			this.cmb_payment_method.Size = new System.Drawing.Size(253, 28);
			this.cmb_payment_method.TabIndex = 0;
			// 
			// lbl_payment_method
			// 
			this.lbl_payment_method.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_payment_method.AutoSize = true;
			this.lbl_payment_method.Location = new System.Drawing.Point(3, 7);
			this.lbl_payment_method.Name = "lbl_payment_method";
			this.lbl_payment_method.Size = new System.Drawing.Size(125, 20);
			this.lbl_payment_method.TabIndex = 0;
			this.lbl_payment_method.Text = "Payment method:";
			// 
			// dtp_payment_method_date
			// 
			this.dtp_payment_method_date.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtp_payment_method_date.CustomFormat = "MM/yy";
			this.dtp_payment_method_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_payment_method_date.Location = new System.Drawing.Point(134, 170);
			this.dtp_payment_method_date.Name = "dtp_payment_method_date";
			this.dtp_payment_method_date.Size = new System.Drawing.Size(122, 27);
			this.dtp_payment_method_date.TabIndex = 6;
			// 
			// txt_payment_method_finance
			// 
			this.txt_payment_method_finance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_payment_method_finance.Enabled = false;
			this.txt_payment_method_finance.Location = new System.Drawing.Point(134, 137);
			this.txt_payment_method_finance.Name = "txt_payment_method_finance";
			this.txt_payment_method_finance.ReadOnly = true;
			this.txt_payment_method_finance.Size = new System.Drawing.Size(253, 27);
			this.txt_payment_method_finance.TabIndex = 4;
			// 
			// cmb_credit_card_type
			// 
			this.cmb_credit_card_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cmb_credit_card_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb_credit_card_type.FormattingEnabled = true;
			this.cmb_credit_card_type.Location = new System.Drawing.Point(134, 103);
			this.cmb_credit_card_type.Name = "cmb_credit_card_type";
			this.cmb_credit_card_type.Size = new System.Drawing.Size(253, 28);
			this.cmb_credit_card_type.TabIndex = 3;
			// 
			// btn_payment_method_finance
			// 
			this.btn_payment_method_finance.Location = new System.Drawing.Point(393, 137);
			this.btn_payment_method_finance.Name = "btn_payment_method_finance";
			this.btn_payment_method_finance.Size = new System.Drawing.Size(27, 27);
			this.btn_payment_method_finance.TabIndex = 5;
			this.btn_payment_method_finance.Text = "...";
			this.btn_payment_method_finance.UseVisualStyleBackColor = true;
			this.btn_payment_method_finance.Click += new System.EventHandler(this.Btn_payment_method_finance_Click);
			// 
			// lbl_credit_card_type
			// 
			this.lbl_credit_card_type.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_credit_card_type.AutoSize = true;
			this.lbl_credit_card_type.Location = new System.Drawing.Point(3, 107);
			this.lbl_credit_card_type.Name = "lbl_credit_card_type";
			this.lbl_credit_card_type.Size = new System.Drawing.Size(118, 20);
			this.lbl_credit_card_type.TabIndex = 0;
			this.lbl_credit_card_type.Text = "Credit card type:";
			// 
			// lbl_payment_method_date
			// 
			this.lbl_payment_method_date.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_payment_method_date.AutoSize = true;
			this.lbl_payment_method_date.Location = new System.Drawing.Point(3, 173);
			this.lbl_payment_method_date.Name = "lbl_payment_method_date";
			this.lbl_payment_method_date.Size = new System.Drawing.Size(52, 20);
			this.lbl_payment_method_date.TabIndex = 0;
			this.lbl_payment_method_date.Text = "Expiry:";
			// 
			// lbl_payment_method_finance
			// 
			this.lbl_payment_method_finance.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_payment_method_finance.AutoSize = true;
			this.lbl_payment_method_finance.Location = new System.Drawing.Point(3, 140);
			this.lbl_payment_method_finance.Name = "lbl_payment_method_finance";
			this.lbl_payment_method_finance.Size = new System.Drawing.Size(62, 20);
			this.lbl_payment_method_finance.TabIndex = 0;
			this.lbl_payment_method_finance.Text = "Finance:";
			// 
			// txt_cheque_no
			// 
			this.txt_cheque_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_cheque_no.Location = new System.Drawing.Point(134, 70);
			this.txt_cheque_no.MaxLength = 20;
			this.txt_cheque_no.Name = "txt_cheque_no";
			this.txt_cheque_no.Size = new System.Drawing.Size(253, 27);
			this.txt_cheque_no.TabIndex = 2;
			this.txt_cheque_no.Leave += new System.EventHandler(this.Txt_cheque_no_Leave);
			// 
			// lbl_cheque_no
			// 
			this.lbl_cheque_no.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lbl_cheque_no.AutoSize = true;
			this.lbl_cheque_no.BackColor = System.Drawing.Color.Yellow;
			this.lbl_cheque_no.Location = new System.Drawing.Point(3, 73);
			this.lbl_cheque_no.Name = "lbl_cheque_no";
			this.lbl_cheque_no.Size = new System.Drawing.Size(117, 20);
			this.lbl_cheque_no.TabIndex = 0;
			this.lbl_cheque_no.Text = "Cheque number:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel3);
			this.groupBox1.Controls.Add(this.flowLayoutPanel2);
			this.groupBox1.Location = new System.Drawing.Point(12, 148);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(429, 264);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Payment method";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 421);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Remark:";
			// 
			// txt_remark
			// 
			this.txt_remark.Location = new System.Drawing.Point(111, 418);
			this.txt_remark.MaxLength = 255;
			this.txt_remark.Multiline = true;
			this.txt_remark.Name = "txt_remark";
			this.txt_remark.Size = new System.Drawing.Size(327, 89);
			this.txt_remark.TabIndex = 8;
			// 
			// txt_pay_to
			// 
			this.txt_pay_to.Enabled = false;
			this.txt_pay_to.Location = new System.Drawing.Point(111, 115);
			this.txt_pay_to.Name = "txt_pay_to";
			this.txt_pay_to.ReadOnly = true;
			this.txt_pay_to.Size = new System.Drawing.Size(297, 27);
			this.txt_pay_to.TabIndex = 5;
			// 
			// btn_pay_to
			// 
			this.btn_pay_to.Location = new System.Drawing.Point(414, 115);
			this.btn_pay_to.Name = "btn_pay_to";
			this.btn_pay_to.Size = new System.Drawing.Size(27, 27);
			this.btn_pay_to.TabIndex = 6;
			this.btn_pay_to.Text = "...";
			this.btn_pay_to.UseVisualStyleBackColor = true;
			this.btn_pay_to.Click += new System.EventHandler(this.Btn_pay_to_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Yellow;
			this.label6.Location = new System.Drawing.Point(9, 118);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 20);
			this.label6.TabIndex = 0;
			this.label6.Text = "Pay to:";
			// 
			// txt_description
			// 
			this.txt_description.Location = new System.Drawing.Point(111, 45);
			this.txt_description.MaxLength = 50;
			this.txt_description.Name = "txt_description";
			this.txt_description.Size = new System.Drawing.Size(213, 27);
			this.txt_description.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Yellow;
			this.label9.Location = new System.Drawing.Point(12, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 20);
			this.label9.TabIndex = 0;
			this.label9.Text = "Description:";
			// 
			// txt_payment_no
			// 
			this.txt_payment_no.Enabled = false;
			this.txt_payment_no.Location = new System.Drawing.Point(111, 12);
			this.txt_payment_no.MaxLength = 50;
			this.txt_payment_no.Name = "txt_payment_no";
			this.txt_payment_no.ReadOnly = true;
			this.txt_payment_no.Size = new System.Drawing.Size(213, 27);
			this.txt_payment_no.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 15);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(93, 20);
			this.label10.TabIndex = 0;
			this.label10.Text = "Payment no.:";
			// 
			// txt_pay_to_type
			// 
			this.txt_pay_to_type.Location = new System.Drawing.Point(495, 219);
			this.txt_pay_to_type.Name = "txt_pay_to_type";
			this.txt_pay_to_type.Size = new System.Drawing.Size(18, 27);
			this.txt_pay_to_type.TabIndex = 11;
			this.txt_pay_to_type.Visible = false;
			// 
			// num_pay_to_id
			// 
			this.num_pay_to_id.Location = new System.Drawing.Point(523, 257);
			this.num_pay_to_id.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.num_pay_to_id.Name = "num_pay_to_id";
			this.num_pay_to_id.Size = new System.Drawing.Size(35, 27);
			this.num_pay_to_id.TabIndex = 12;
			this.num_pay_to_id.Visible = false;
			// 
			// num_payment_method_finance
			// 
			this.num_payment_method_finance.Location = new System.Drawing.Point(536, 171);
			this.num_payment_method_finance.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.num_payment_method_finance.Name = "num_payment_method_finance";
			this.num_payment_method_finance.Size = new System.Drawing.Size(27, 27);
			this.num_payment_method_finance.TabIndex = 12;
			this.num_payment_method_finance.Visible = false;
			// 
			// Form_edit_payment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(594, 560);
			this.Controls.Add(this.num_payment_method_finance);
			this.Controls.Add(this.num_pay_to_id);
			this.Controls.Add(this.txt_pay_to_type);
			this.Controls.Add(this.txt_payment_no);
			this.Controls.Add(this.txt_description);
			this.Controls.Add(this.btn_pay_to);
			this.Controls.Add(this.txt_pay_to);
			this.Controls.Add(this.txt_remark);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.num_amount);
			this.Controls.Add(this.dtp_payment_date);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form_edit_payment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Payment";
			this.Shown += new System.EventHandler(this.Form_edit_payment_Shown);
			((System.ComponentModel.ISupportInitialize)(this.num_amount)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_pay_to_id)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_payment_method_finance)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtp_payment_date;
		private System.Windows.Forms.NumericUpDown num_amount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.RadioButton rad_paid;
		private System.Windows.Forms.RadioButton rad_unpaid;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.RadioButton rad_credit_debit_card;
		private System.Windows.Forms.RadioButton rad_cheque;
		private System.Windows.Forms.RadioButton rad_other;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label lbl_credit_card_no;
		private System.Windows.Forms.Label lbl_payment_method_date;
		private System.Windows.Forms.ComboBox cmb_payment_method;
		private System.Windows.Forms.DateTimePicker dtp_payment_method_date;
		private System.Windows.Forms.Label lbl_payment_method;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_remark;
		private System.Windows.Forms.TextBox txt_pay_to;
		private System.Windows.Forms.Button btn_pay_to;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_description;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txt_payment_no;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_pay_to_type;
		private System.Windows.Forms.NumericUpDown num_pay_to_id;
		private System.Windows.Forms.ComboBox cmb_credit_card_type;
		private System.Windows.Forms.Label lbl_payment_method_finance;
		private System.Windows.Forms.Button btn_payment_method_finance;
		private System.Windows.Forms.TextBox txt_payment_method_finance;
		private System.Windows.Forms.Label lbl_credit_card_type;
		private System.Windows.Forms.NumericUpDown num_payment_method_finance;
		private System.Windows.Forms.MaskedTextBox maskedtxt_credit_card_no;
		private System.Windows.Forms.TextBox txt_cheque_no;
		private System.Windows.Forms.Label lbl_cheque_no;
	}
}