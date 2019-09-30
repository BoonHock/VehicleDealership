using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Classes;
using VehicleDealership.Datasets;

namespace VehicleDealership.View
{
	public partial class Form_edit_vehicle : Form
	{
		public int VehicleID { get; private set; }

		string _str_reg_no;
		string _str_chassis_no;

		public Form_edit_vehicle(int int_vehicle = 0)
		{
			InitializeComponent();

			VehicleID = int_vehicle;

			Class_style.Grd_style.Common_style(grd_expenses);
			Class_style.Grd_style.Common_style(grd_payment);

			grd_file_attachment.MouseDown += Class_datagridview.MouseDown_select_cell;
			grd_image.MouseDown += Class_datagridview.MouseDown_select_cell;
		}

		private void Btn_ok_Click(object sender, EventArgs e)
		{
			string str_reg_no = txt_reg_no.Text.Trim();
			string str_chassis = txt_chassis.Text.Trim();
			string str_engine_no = txt_engine_no.Text.Trim();

			if (str_reg_no == "" || str_chassis == "" || str_engine_no == "" || str_chassis == "" ||
				num_vehicle_model_id.Value == 0 || num_seller_id.Value == 0 || num_checked_by_id.Value == 0)
			{
				MessageBox.Show("All highlighted fields are required. Please input and retry.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void Form_edit_vehicle_Shown(object sender, EventArgs e)
		{
			cmb_vehicle_colour.DisplayMember = "colour_name";
			cmb_vehicle_colour.ValueMember = "colour";
			cmb_vehicle_colour.DataSource = Colour_ds.Select_colour();

			cmb_acquire_method.SelectedItem = "PURCHASE"; // DEFAULT

			grd_expenses.DataSource = Vehicle_expenses_ds.Select_vehicle_expenses(VehicleID);
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_expenses,
				"payment_no", "payment_description", "pay_to", "amount", "payment_date", "is_paid",
				"payment_method_type", "cheque_no", "credit_card_no", "payment_method", "finance", "remark", "modified_by");

			grd_payment.DataSource = Vehicle_payment_ds.Select_vehicle_payment(VehicleID);
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_payment,
				"payment_no", "payment_description", "pay_to", "amount", "payment_date", "is_paid",
				"payment_method_type", "cheque_no", "credit_card_no", "payment_method", "finance", "remark", "modified_by");

			// VEHICLE IMAGE
			{
				// set default height for datagridviewrow
				grd_image.RowTemplate.Height = Program.GRD_IMAGE_ROW_HEIGHT;
				Vehicle_image_ds.sp_select_vehicle_imageDataTable dttable_image = Vehicle_image_ds.Select_vehicle_image(VehicleID);
				// load images to datatable from filename
				foreach (Vehicle_image_ds.sp_select_vehicle_imageRow dt_row in dttable_image.Rows)
				{
					dt_row.image = Class_image.Image_to_byte_array(Image.FromFile(dt_row.image_filename));
				}

				grd_image.DataSource = dttable_image;
				if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_image,
					"image", "image_description");
				((DataGridViewImageColumn)grd_image.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
				grd_image.Columns["image_description"].Width = 300; // set wider
				Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_image, "image_description");
			}

			grd_file_attachment.DataSource = Vehicle_attachment_ds.Select_vehicle_attachment(VehicleID);
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_file_attachment, "filename");

			if (VehicleID == 0) return;

			// select vehicle and populate controls

		}
		private void Txt_reg_no_Enter(object sender, EventArgs e)
		{
			_str_reg_no = txt_reg_no.Text;
		}
		private void Txt_chassis_Enter(object sender, EventArgs e)
		{
			_str_chassis_no = txt_chassis.Text;
		}
		private void Txt_reg_no_Leave(object sender, EventArgs e)
		{
			Txt_reg_chassis_leave(txt_reg_no, ref _str_reg_no);
		}
		private void Txt_chassis_Leave(object sender, EventArgs e)
		{
			Txt_reg_chassis_leave(txt_chassis, ref _str_chassis_no);
		}
		private void Txt_reg_chassis_leave(TextBox txtbox, ref string str_param)
		{
			if (str_param == txtbox.Text) return; // user didn't make any changes. do nothing

			btn_vehicle_model.Enabled = true; // default is enabled	

			txtbox.Text = txtbox.Text.Trim(); // trim input

			if (txtbox.Text == "") return;

			str_param = txtbox.Text; // set value for checking when control is entered next time

			Setup_vehicle_details(Vehicle_ds.Select_vehicle_latest_record("", txtbox.Text));
		}
		private void Setup_vehicle_details(Vehicle_ds.sp_select_vehicleDataTable dttable)
		{
			if (dttable.Rows.Count == 0) return;

			if (txt_reg_no.Text.Trim() == "")
			{
				// if registration no. no input yet, input latest record's
				_str_reg_no = dttable[0].registration_no;
				txt_reg_no.Text = _str_reg_no;
			}
			if (txt_chassis.Text.Trim() == "")
			{
				// if chassis no. no input yet, input latest record's
				_str_chassis_no = dttable[0].chassis_no;
				txt_chassis.Text = _str_chassis_no;
			}

			btn_vehicle_model.Enabled = false;
			num_vehicle_model_id.Value = dttable[0].vehicle_model;
			txt_vehicle_model.Text = dttable[0].vehicle_model_name;
			txt_vehicle_group.Text = dttable[0].vehicle_group_name;
			txt_vehicle_brand.Text = dttable[0].vehicle_brand_name;
			txt_year_make.Text = dttable[0].year_make.ToString();

			if (txt_engine_no.Text.Trim() == "") txt_engine_no.Text = dttable[0].engine_no;
			if (num_engine_cc.Value == 0) num_engine_cc.Value = (decimal)dttable[0].engine_cc;
			if (txt_ignition_key.Text.Trim() == "") txt_ignition_key.Text = dttable[0].ignition_key;
			if (txt_door_key.Text.Trim() == "") txt_door_key.Text = dttable[0].door_key;
			if (cmb_vehicle_colour.SelectedIndex == 0) cmb_vehicle_colour.SelectedValue = dttable[0].colour;
			rad_vehicle_new.Checked = false;
			rad_vehicle_old.Checked = true;
			if (num_year_registered.Value == 0) num_year_registered.Value = (decimal)dttable[0].year_registered;
		}
		private void Btn_vehicle_model_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("VEHICLE_MODEL", num_vehicle_model_id.Value.ToString());

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				num_vehicle_model_id.Value = dlg_select.Get_selected_value_as_int("vehicle_model");
				txt_vehicle_model.Text = dlg_select.Get_selected_value_as_string("vehicle_model_name");
				txt_vehicle_group.Text = dlg_select.Get_selected_value_as_string("vehicle_group_name");
				txt_vehicle_brand.Text = dlg_select.Get_selected_value_as_string("vehicle_brand_name");
				txt_year_make.Text = dlg_select.Get_selected_value_as_string("year_make");
			}
		}

		private void Btn_vehicle_location_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("LOCATION",
				num_vehicle_location.Value.ToString());

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				num_vehicle_location.Value = dlg_select.Get_selected_value_as_int("location");
				txt_vehicle_location.Text = dlg_select.Get_selected_value_as_string("location_name");
			}
		}

		private void Btn_seller_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("PERSON_ORGANISATION");

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				txt_seller_type.Text = dlg_select.cmb_type.SelectedItem.ToString().ToUpper();

				if (txt_seller_type.Text == "PERSON")
				{
					num_seller_id.Value = dlg_select.Get_selected_value_as_int("person");
					txt_seller_name.Text = dlg_select.Get_selected_value_as_string("name");
				}
				else
				{
					num_seller_id.Value = dlg_select.Get_selected_value_as_int("organisation");
					txt_seller_name.Text = dlg_select.Get_selected_value_as_string("name");
					txt_seller_branch.Text = dlg_select.Get_selected_value_as_string("branch_name");
				}
			}
		}

		private void Btn_checked_by_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("USER");

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				txt_checked_by.Text = dlg_select.Get_selected_value_as_string("name");
				num_checked_by_id.Value = dlg_select.Get_selected_value_as_int("user");
			}
		}
		private void Cmb_acquire_method_SelectedIndexChanged(object sender, EventArgs e)
		{
			btn_sales_order.Enabled = cmb_acquire_method.SelectedItem.ToString() == "TRADE-IN";
		}
		private void Btn_sales_order_Click(object sender, EventArgs e)
		{
			// TODO: in the future when sales feature is done
		}
		private void Recalculate_nums(object sender, EventArgs e)
		{
			num_net_purchase.Value = num_purchase_price.Value - num_overtrade.Value;
			num_to_pay.Value = num_net_purchase.Value - num_loan_balance.Value - num_paid.Value;
			num_total_cost.Value = num_net_purchase.Value + num_expenses.Value;
			num_gross_profit.Value = num_list_price.Value - num_total_cost.Value;
		}
		private void Num_loan_balance_ValueChanged(object sender, EventArgs e)
		{
			num_loan_balance_readonly.Value = num_loan_balance.Value;
		}
		private void Btn_loan_finance_Click(object sender, EventArgs e)
		{
			Form_datagridview_select dlg_select = new Form_datagridview_select("FINANCE", num_loan_finance_id.Value.ToString());

			if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
			{
				txt_loan_finance.Text = dlg_select.Get_selected_value_as_string("name");
				txt_loan_branch.Text = dlg_select.Get_selected_value_as_string("branch_name");
				num_loan_finance_id.Value = dlg_select.Get_selected_value_as_int("finance");
			}
		}
		private void Btn_add_expenses_Click(object sender, EventArgs e)
		{
			Form_edit_payment dlg_payment = new Form_edit_payment();

			if (dlg_payment.ShowDialog() != DialogResult.OK) return;

			Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable dttable = (Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable)grd_expenses.DataSource;

			int new_payment_id = -1;

			if (dttable.Rows.Count > 0)
			{
				// new payment id must be negative number. select the smallest payment id and minus one.
				// if more than 0, set to -1
				new_payment_id = (from row in dttable select row.payment).ToList().Min() - 1;
				if (new_payment_id >= 0) new_payment_id = -1;
			}

			dttable.Addsp_select_vehicle_expensesRow(new_payment_id, dlg_payment.PaymentNo,
				dlg_payment.PaymentDescription, dlg_payment.PayToId, dlg_payment.PayToName,
				dlg_payment.PayToType, dlg_payment.PaymentAmount, dlg_payment.PaymentDate,
				dlg_payment.IsPaid, dlg_payment.PaymentMethodType,
				dlg_payment.PaymentMethodDescription, dlg_payment.PaymentMethod,
				dlg_payment.ChequeNo, dlg_payment.CreditCardNo, dlg_payment.CreditCardTypeId,
				dlg_payment.CreditCardTypeName, dlg_payment.PaymentMethodFinance,
				dlg_payment.PaymentMethodFinanceName, dlg_payment.PaymentMethodDate,
				dlg_payment.PaymentRemark, Program.System_user.Name);

			Process_vehicle_expenses();
		}
		private void Btn_edit_expenses_Click(object sender, EventArgs e)
		{
			if (grd_expenses.SelectedCells.Count == 0) return;

			Vehicle_expenses_ds.sp_select_vehicle_expensesRow dt_row =
				(from row in (Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable)grd_expenses.DataSource
				 where row.payment == (int)grd_expenses.SelectedCells[0].OwningRow.Cells["payment"].Value
				 select row).ToList()[0];

			Form_edit_payment dlg_payment = new Form_edit_payment(dt_row.payment, dt_row.payment_no,
				dt_row.payment_description, dt_row.is_paid, dt_row.pay_to_id, dt_row.pay_to,
				dt_row.pay_to_type, dt_row.payment_date, dt_row.amount, dt_row.payment_method_type,
				dt_row.payment_method_id, dt_row.credit_card_no, dt_row.cheque_no, dt_row.credit_card_type_id,
				dt_row.finance_id, dt_row.finance, dt_row.payment_method_date, dt_row.remark);

			if (dlg_payment.ShowDialog() != DialogResult.OK) return;

			dt_row.payment_description = dlg_payment.PaymentDescription;
			dt_row.pay_to_id = dlg_payment.PayToId;
			dt_row.pay_to = dlg_payment.PayToName;
			dt_row.pay_to_type = dlg_payment.PayToType;
			dt_row.amount = dlg_payment.PaymentAmount;
			dt_row.payment_date = dlg_payment.PaymentDate;
			dt_row.is_paid = dlg_payment.IsPaid;
			dt_row.payment_method_type = dlg_payment.PaymentMethodType;
			dt_row.payment_method = dlg_payment.PaymentMethodDescription;
			dt_row.payment_method_id = dlg_payment.PaymentMethod;

			dt_row.cheque_no = dlg_payment.ChequeNo;
			dt_row.credit_card_no = dlg_payment.CreditCardNo;
			dt_row.credit_card_type_id = dlg_payment.CreditCardTypeId;
			dt_row.credit_card_type = dlg_payment.CreditCardTypeName;
			dt_row.finance_id = dlg_payment.PaymentMethodFinance;
			dt_row.finance = dlg_payment.PaymentMethodFinanceName;

			dt_row.payment_method_date = dlg_payment.PaymentMethodDate;
			dt_row.remark = dlg_payment.PaymentRemark;
			dt_row.modified_by = Program.System_user.Name;

			Process_vehicle_expenses();
		}
		private void Btn_delete_expenses_Click(object sender, EventArgs e)
		{
			if (grd_expenses.SelectedCells.Count == 0) return;

			if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning) != DialogResult.Yes) return;

			List<int> list_payment_id = new List<int>();

			Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable dttable =
				(Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable)grd_expenses.DataSource;

			foreach (DataGridViewCell grd_cell in grd_expenses.SelectedCells)
			{
				list_payment_id.Add((int)grd_cell.OwningRow.Cells["payment"].Value);
			}

			foreach (int tmp_id in list_payment_id.Distinct().ToList())
			{
				for (int i = 0, j = dttable.Rows.Count; i < j; i++)
				{
					if (dttable[i].payment == tmp_id)
					{
						dttable.Rows.RemoveAt(i);
						break;
					}
				}
			}
			Process_vehicle_expenses();
		}
		private void Process_vehicle_expenses()
		{
			if (grd_expenses.Rows.Count == 0)
			{
				lbl_total_expenses.Text = "0.00";
				num_expenses.Value = 0;
				return;
			}

			Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable dttable =
				(Vehicle_expenses_ds.sp_select_vehicle_expensesDataTable)grd_expenses.DataSource;

			decimal dcml_expenses = (from row in dttable select row.amount).Sum();

			lbl_total_expenses.Text = dcml_expenses.ToString("#,##0.00");
			num_expenses.Value = dcml_expenses;
		}
		private void Btn_add_payment_Click(object sender, EventArgs e)
		{
			Form_edit_payment dlg_payment = new Form_edit_payment((int)num_seller_id.Value, txt_seller_name.Text, txt_seller_type.Text);

			if (dlg_payment.ShowDialog() != DialogResult.OK) return;

			Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable = (Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_payment.DataSource;

			int new_payment_id = -1;

			if (dttable.Rows.Count > 0)
			{
				// new payment id must be negative number. select the smallest payment id and minus one.
				// if more than 0, set to -1
				new_payment_id = (from row in dttable select row.payment).ToList().Min() - 1;
				if (new_payment_id >= 0) new_payment_id = -1;
			}

			dttable.Addsp_select_vehicle_paymentRow(new_payment_id, dlg_payment.PaymentNo,
				dlg_payment.PaymentDescription, dlg_payment.PayToId, dlg_payment.PayToName,
				dlg_payment.PayToType, dlg_payment.PaymentAmount, dlg_payment.PaymentDate,
				dlg_payment.IsPaid, dlg_payment.PaymentMethodType,
				dlg_payment.PaymentMethodDescription, dlg_payment.PaymentMethod,
				dlg_payment.ChequeNo, dlg_payment.CreditCardNo, dlg_payment.CreditCardTypeId,
				dlg_payment.CreditCardTypeName, dlg_payment.PaymentMethodFinance,
				dlg_payment.PaymentMethodFinanceName, dlg_payment.PaymentMethodDate,
				dlg_payment.PaymentRemark, Program.System_user.Name);

			Process_vehicle_payment();
		}
		private void Btn_edit_payment_Click(object sender, EventArgs e)
		{
			if (grd_payment.Rows.Count == 0) return;

			Vehicle_payment_ds.sp_select_vehicle_paymentRow dt_row =
				(from row in (Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_payment.DataSource
				 where row.payment == (int)grd_payment.SelectedCells[0].OwningRow.Cells["payment"].Value
				 select row).ToList()[0];

			Form_edit_payment dlg_payment = new Form_edit_payment(dt_row.payment, dt_row.payment_no,
				dt_row.payment_description, dt_row.is_paid, dt_row.pay_to_id, dt_row.pay_to,
				dt_row.pay_to_type, dt_row.payment_date, dt_row.amount, dt_row.payment_method_type,
				dt_row.payment_method_id, dt_row.credit_card_no, dt_row.cheque_no, dt_row.credit_card_type_id,
				dt_row.finance_id, dt_row.finance, dt_row.payment_method_date, dt_row.remark);

			if (dlg_payment.ShowDialog() != DialogResult.OK) return;

			dt_row.payment_description = dlg_payment.PaymentDescription;
			dt_row.pay_to_id = dlg_payment.PayToId;
			dt_row.pay_to = dlg_payment.PayToName;
			dt_row.pay_to_type = dlg_payment.PayToType;
			dt_row.amount = dlg_payment.PaymentAmount;
			dt_row.payment_date = dlg_payment.PaymentDate;
			dt_row.is_paid = dlg_payment.IsPaid;
			dt_row.payment_method_type = dlg_payment.PaymentMethodType;
			dt_row.payment_method = dlg_payment.PaymentMethodDescription;
			dt_row.payment_method_id = dlg_payment.PaymentMethod;

			dt_row.cheque_no = dlg_payment.ChequeNo;
			dt_row.credit_card_no = dlg_payment.CreditCardNo;
			dt_row.credit_card_type_id = dlg_payment.CreditCardTypeId;
			dt_row.credit_card_type = dlg_payment.CreditCardTypeName;
			dt_row.finance_id = dlg_payment.PaymentMethodFinance;
			dt_row.finance = dlg_payment.PaymentMethodFinanceName;

			dt_row.payment_method_date = dlg_payment.PaymentMethodDate;
			dt_row.remark = dlg_payment.PaymentRemark;
			dt_row.modified_by = Program.System_user.Name;

			Process_vehicle_payment();
		}
		private void Btn_delete_payment_Click(object sender, EventArgs e)
		{
			if (grd_payment.SelectedCells.Count == 0) return;

			if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning) != DialogResult.Yes) return;

			List<int> list_payment_id = new List<int>();

			Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable =
				(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_payment.DataSource;

			foreach (DataGridViewCell grd_cell in grd_payment.SelectedCells)
			{
				list_payment_id.Add((int)grd_cell.OwningRow.Cells["payment"].Value);
			}
			foreach (int tmp_id in list_payment_id.Distinct().ToList())
			{
				for (int i = 0, j = dttable.Rows.Count; i < j; i++)
				{
					if (dttable[i].payment == tmp_id)
					{
						dttable.Rows.RemoveAt(i);
						break;
					}
				}
			}
			Process_vehicle_payment();
		}
		private void Process_vehicle_payment()
		{
			if (grd_payment.Rows.Count == 0)
			{
				lbl_total_payment.Text = "0.00";
				num_paid.Value = 0;
				return;
			}
			Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable =
				(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_payment.DataSource;

			decimal dcml_payment = (from row in dttable select row.amount).Sum();

			lbl_total_payment.Text = dcml_payment.ToString("#,##0.00");
			num_paid.Value = dcml_payment;
		}
		private void Btn_add_image_Click(object sender, EventArgs e)
		{
			if (filedlg_img.ShowDialog() != DialogResult.OK) return;
			Cursor = Cursors.WaitCursor;
			Vehicle_image_ds.sp_select_vehicle_imageDataTable dttable =
				(Vehicle_image_ds.sp_select_vehicle_imageDataTable)grd_image.DataSource;

			foreach (string str_filename in filedlg_img.FileNames)
			{
				dttable.Addsp_select_vehicle_imageRow(Class_image.Image_to_byte_array(
					Class_image.Resize_image(Image.FromFile(str_filename), 900)), "", "");
			}
			Cursor = Cursors.Default;
		}
		private void Btn_delete_image_Click(object sender, EventArgs e)
		{
			if (grd_image.SelectedCells.Count == 0) return;

			if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel,
				MessageBoxIcon.Warning) != DialogResult.OK) return;

			Vehicle_image_ds.sp_select_vehicle_imageDataTable dttable =
				(Vehicle_image_ds.sp_select_vehicle_imageDataTable)grd_image.DataSource;

			List<int> list_id = new List<int>();

			foreach (DataGridViewCell grd_cell in grd_image.SelectedCells)
			{
				list_id.Add((int)grd_cell.OwningRow.Cells["vehicle_image"].Value);
			}

			list_id = list_id.Distinct().ToList();

			foreach (int tmp_id in list_id)
			{
				for (int i = 0, j = dttable.Rows.Count; i < j; i++)
				{
					if (dttable[i].vehicle_image == tmp_id)
					{
						dttable.Rows.RemoveAt(i);
						break;
					}
				}
			}
			// if no more rows then clear picbox and txt
			if (grd_image.Rows.Count == 0)
			{
				picbox_image.Image = null;
				txt_image_description.Text = "";
			}
		}
		private void Grd_image_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			picbox_image.Image = null;
			txt_image_description.Text = "";

			if (grd_image.Rows.Count == 0) return;

			DataGridViewRow grd_row = grd_image[e.ColumnIndex, e.RowIndex].OwningRow;
			picbox_image.Image = Class_image.Byte_array_to_image((byte[])grd_row.Cells["image"].Value);
			txt_image_description.Text = grd_row.Cells["image_description"].Value.ToString();
		}
		private void Btn_add_attachment_Click(object sender, EventArgs e)
		{
			if (filedlg_attachment.ShowDialog() != DialogResult.OK) return;

			Cursor = Cursors.WaitCursor;

			Vehicle_attachment_ds.sp_select_vehicle_attachmentDataTable dttable =
				(Vehicle_attachment_ds.sp_select_vehicle_attachmentDataTable)grd_file_attachment.DataSource;

			foreach (string str_filename in filedlg_attachment.FileNames)
			{
				string new_filename = Path.GetFileName(str_filename); // default new filename is user's filename
				int int_counter = 0;

				// if filename already exists, attach filename with counter until new filename is generated
				while (dttable.Where(e_filename => e_filename.filename.ToUpper() == new_filename.ToUpper()).Count() > 0)
				{
					int_counter += 1;
					new_filename = Path.GetFileNameWithoutExtension(str_filename) + "_" +
						int_counter.ToString() + Path.GetExtension(str_filename);
				}
				dttable.Addsp_select_vehicle_attachmentRow(Path.GetFileName(new_filename), str_filename);
			}
			Cursor = Cursors.Default;
		}
		private void Btn_delete_attachment_Click(object sender, EventArgs e)
		{
			if (grd_file_attachment.SelectedCells.Count == 0) return;

			if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel,
				MessageBoxIcon.Warning) != DialogResult.OK) return;

			Vehicle_attachment_ds.sp_select_vehicle_attachmentDataTable dttable =
				(Vehicle_attachment_ds.sp_select_vehicle_attachmentDataTable)grd_file_attachment.DataSource;

			List<int> list_id = new List<int>();

			foreach (DataGridViewCell grd_cell in grd_file_attachment.SelectedCells)
			{
				list_id.Add((int)grd_cell.OwningRow.Cells["vehicle_attachment"].Value);
			}

			for (int i = dttable.Rows.Count - 1; i >= 0; i--)
			{
				if (list_id.Contains(dttable[i].vehicle_attachment)) dttable.Rows.RemoveAt(i);
			}
		}
		private void Grd_file_attachment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) Download_attachment();
		}
		private void Btn_download_attachment_Click(object sender, EventArgs e)
		{
			Download_attachment();
		}
		private void Download_attachment()
		{
			if (grd_file_attachment.SelectedCells.Count == 0) return;

			List<int> list_file = new List<int>();

			foreach (DataGridViewCell grd_cell in grd_file_attachment.SelectedCells)
			{
				list_file.Add((int)grd_cell.OwningRow.Cells["vehicle_attachment"].Value);
			}

			list_file = list_file.Distinct().ToList();
			string MY_DOCUMENTS = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string download_folder = MY_DOCUMENTS;

			if (list_file.Count > 1)
			{
				download_folder = Path.Combine(MY_DOCUMENTS, "vehicle_attachment");
				int folder_counter = 0;

				while (Directory.Exists(download_folder))
				{
					folder_counter += 1;
					download_folder = Path.Combine(MY_DOCUMENTS, "vehicle_attachment" + "_" + folder_counter.ToString());
				}
				Directory.CreateDirectory(download_folder);
			}
			foreach (Vehicle_attachment_ds.sp_select_vehicle_attachmentRow dt_row in
				(Vehicle_attachment_ds.sp_select_vehicle_attachmentDataTable)grd_file_attachment.DataSource)
			{
				if (list_file.Contains(dt_row.vehicle_attachment))
				{
					string new_filename = dt_row.filename;
					int file_counter = 0;

					while (File.Exists(Path.Combine(download_folder, new_filename)))
					{
						file_counter += 1;
						new_filename = Path.GetFileNameWithoutExtension(dt_row.filename) + "_" +
							file_counter.ToString() + Path.GetExtension(dt_row.filename);
					}
					File.Copy(dt_row.full_pathfilename, Path.Combine(download_folder, new_filename));
				}
				Process.Start(download_folder); // open folder for view
			}
		}
	}
}
