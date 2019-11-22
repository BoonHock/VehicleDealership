using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
		string _str_reg_no = "";
		string _str_chassis_no = "";

		public Form_edit_vehicle(int int_vehicle = 0)
		{
			InitializeComponent();

			VehicleID = int_vehicle;

			Class_style.Grd_style.Common_style(grd_expenses);
			Class_style.Grd_style.Common_style(grd_payment);

			grd_file_attachment.MouseDown += Class_datagridview.MouseDown_select_cell;
			grd_image.MouseDown += Class_datagridview.MouseDown_select_cell;
			grd_expenses.MouseDown += Class_datagridview.MouseDown_select_cell;
			grd_payment.MouseDown += Class_datagridview.MouseDown_select_cell;
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			string str_reg_no = txt_reg_no.Text.Trim();
			string str_chassis = txt_chassis.Text.Trim();
			string str_engine_no = txt_engine_no.Text.Trim();
			int int_chassis;

			if (str_reg_no == "" || str_chassis == "" || str_engine_no == "" || str_chassis == "" ||
				num_vehicle_model_id.Value == 0 || num_seller_id.Value == 0 || num_checked_by_id.Value == 0)
			{
				MessageBox.Show("All highlighted fields are required. Please input and retry.",
					"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			using (Vehicle_ds.sp_select_vehicleDataTable dttable = Vehicle_ds.Select_vehicle_latest_record("", str_chassis))
			{
				// if creating vehicle record, check chassis is one of unsold/unreturned vehicle. if it is, then cannot create duplicate!
				if (VehicleID == 0 && dttable.Rows.Count > 0 && dttable[0].vehicle_status == "UNSOLD")
				{
					MessageBox.Show("Vehicle record already existed and unsold. Cannot create another record until vehicle returned/sold.",
						"Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			using (Chassis_ds.sp_select_chassisDataTable dttable_chassis = Chassis_ds.Select_chassis(txt_chassis.Text.Trim()))
			{
				if (dttable_chassis.Rows.Count == 0)
				{
					// chassis not found. new chassis. insert
					int_chassis = Chassis_ds.Insert_chassis(str_chassis, (int)num_vehicle_model_id.Value, dtp_registered.Value);
				}
				else
				{
					// EDIT CHASSIS
					int_chassis = Chassis_ds.Update_chassis(dttable_chassis[0].chassis, str_chassis,
						(int)num_vehicle_model_id.Value, dtp_registered.Value) ? dttable_chassis[0].chassis : 0;
				}
			}
			if (int_chassis == 0)
			{
				// insert_chassis() return last insert id. therefore shouldn't be zero
				MessageBox.Show("Insert chassis failed. Vehicle record cannot be created.",
					"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			int? int_vehicle_sale = null;
			int? int_loan_finance = null;
			int? int_location = null;
			bool? consignment_mortgage = null;

			switch (cmb_acquire_method.SelectedItem.ToString())
			{
				case "TRADE-IN":
					int_vehicle_sale = (int)num_sale.Value;
					break;
				case "CONSIGNMENT":
					consignment_mortgage = true;
					break;
				case "MORTGAGE":
					consignment_mortgage = false;
					break;
			}

			if (num_loan_finance_id.Value != 0) int_loan_finance = (int)num_loan_finance_id.Value;
			if (num_vehicle_location.Value != 0) int_location = (int)num_vehicle_location.Value;

			if (VehicleID == 0)
			{
				VehicleID = Vehicle_ds.Insert_vehicle((int)num_seller_id.Value, txt_seller_type.Text == "PERSON",
					str_reg_no, int_chassis, (int)cmb_vehicle_colour.SelectedValue, rad_vehicle_new.Checked,
					int_location, str_engine_no, (double)num_engine_cc.Value, (int)num_mileage.Value,
					int_vehicle_sale, consignment_mortgage, txt_door_key.Text.Trim(), txt_ignition_key.Text.Trim(),
					dtp_purchase_date.Value, dtp_date_received.Value, dtp_settle_by.Value,
					txt_invoice_no.Text.Trim(), num_road_tax_amount.Value, dtp_road_tax_expiry.Value,
					num_purchase_price.Value, num_overtrade.Value, num_list_price.Value, num_max_can_loan.Value,
					num_loan_balance_readonly.Value, num_installment_amount.Value, int_loan_finance,
					(int)num_installment_day.Value, dtp_loan_settlement_date.Value, txt_loan_agreement_no.Text.Trim(),
					txt_remark.Text.Trim(), (int)num_checked_by_id.Value);
			}
			else
			{
				// update vehicle
				Vehicle_ds.Update_vehicle(VehicleID, (int)num_seller_id.Value, txt_seller_type.Text == "PERSON",
					str_reg_no, int_chassis, (int)cmb_vehicle_colour.SelectedValue, rad_vehicle_new.Checked,
					int_location, str_engine_no, (double)num_engine_cc.Value, (int)num_mileage.Value,
					int_vehicle_sale, consignment_mortgage, txt_door_key.Text.Trim(), txt_ignition_key.Text.Trim(),
					dtp_purchase_date.Value, dtp_date_received.Value, dtp_settle_by.Value,
					txt_invoice_no.Text.Trim(), num_road_tax_amount.Value, dtp_road_tax_expiry.Value,
					num_purchase_price.Value, num_overtrade.Value, num_list_price.Value, num_max_can_loan.Value,
					num_loan_balance_readonly.Value, num_installment_amount.Value, int_loan_finance,
					(int)num_installment_day.Value, dtp_loan_settlement_date.Value, txt_loan_agreement_no.Text.Trim(),
					txt_remark.Text.Trim(), (int)num_checked_by_id.Value);
			}

			if (VehicleID == 0)
			{
				MessageBox.Show("An error has occurred.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Cursor = Cursors.WaitCursor;

			using (Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable_expenses =
				(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_expenses.DataSource)
			{
				List<int> list_payment_id = new List<int>();
				List<int> list_charge_to_customer = new List<int>();

				dttable_expenses.AcceptChanges();

				string str_doc_prefix = "";
				using (Document_prefix_ds.sp_select_document_prefixDataTable dttable_prefix =
					Document_prefix_ds.Select_document_prefix("VEHICLE_EXPENSES"))
				{
					if (dttable_prefix.Rows.Count > 0) str_doc_prefix = dttable_prefix[0].document_prefix_text;
				}

				foreach (Vehicle_payment_ds.sp_select_vehicle_paymentRow dt_row in dttable_expenses)
				{
					int int_payment_id = Update_insert_payment(str_doc_prefix, dt_row.payment,
						dt_row.payment_description, dt_row.pay_to_id, dt_row.pay_to_type, dt_row.amount,
						dt_row.payment_date, dt_row.is_paid, dt_row.payment_method_type,
						(dt_row["payment_method_id"] == DBNull.Value) ? 0 : dt_row.payment_method_id,
						(dt_row["cheque_no"] == DBNull.Value) ? "" : dt_row.cheque_no,
						(dt_row["credit_card_no"] == DBNull.Value) ? "" : dt_row.credit_card_no,
						(dt_row["credit_card_type_id"] == DBNull.Value) ? 0 : dt_row.credit_card_type_id,
						(dt_row["finance_id"] == DBNull.Value) ? 0 : dt_row.finance_id,
						(dt_row["payment_method_date"] == DBNull.Value) ? DateTime.Today : dt_row.payment_method_date,
						dt_row.remark);

					if (int_payment_id == 0) continue;

					list_payment_id.Add(int_payment_id);
					if (dt_row.charge_to_customer) list_charge_to_customer.Add(int_payment_id);
				}

				if (!Vehicle_payment_ds.Update_vehicle_payment(VehicleID, string.Join(",", list_payment_id),
					Class_enum.Payment_function.VEHICLE_EXPENSES, string.Join(",", list_charge_to_customer)))
				{
					MessageBox.Show("Vehicle expenses update failed.", "ERROR",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			using (Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable_payment =
				(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_payment.DataSource)
			{
				List<int> list_payment_id = new List<int>();
				List<int> list_charge_to_customer = new List<int>();

				dttable_payment.AcceptChanges();

				string str_doc_prefix = "";
				using (Document_prefix_ds.sp_select_document_prefixDataTable dttable_prefix =
					Document_prefix_ds.Select_document_prefix("VEHICLE_PAYMENT"))
				{
					if (dttable_prefix.Rows.Count > 0) str_doc_prefix = dttable_prefix[0].document_prefix_text;
				}

				foreach (Vehicle_payment_ds.sp_select_vehicle_paymentRow dt_row in dttable_payment)
				{
					int int_payment_id = Update_insert_payment(str_doc_prefix, dt_row.payment,
						dt_row.payment_description, dt_row.pay_to_id, dt_row.pay_to_type, dt_row.amount,
						dt_row.payment_date, dt_row.is_paid, dt_row.payment_method_type,
						(dt_row["payment_method_id"] == DBNull.Value) ? 0 : dt_row.payment_method_id,
						(dt_row["cheque_no"] == DBNull.Value) ? "" : dt_row.cheque_no,
						(dt_row["credit_card_no"] == DBNull.Value) ? "" : dt_row.credit_card_no,
						(dt_row["credit_card_type_id"] == DBNull.Value) ? 0 : dt_row.credit_card_type_id,
						(dt_row["finance_id"] == DBNull.Value) ? 0 : dt_row.finance_id,
						(dt_row["payment_method_date"] == DBNull.Value) ? DateTime.Today : dt_row.payment_method_date,
						dt_row.remark);

					if (int_payment_id == 0) continue;

					list_payment_id.Add(int_payment_id);
					if (dt_row.charge_to_customer) list_charge_to_customer.Add(int_payment_id);
				}
				if (!Vehicle_payment_ds.Update_vehicle_payment(VehicleID, string.Join(",", list_payment_id),
					Class_enum.Payment_function.VEHICLE_PAY_TO_SELLER, string.Join(",", list_charge_to_customer)))
				{
					MessageBox.Show("Vehicle payment update failed.", "ERROR",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			string str_upload_dir = Filepath_ds.Select_filepath_dir("VEHICLE_UPLOAD").Trim();

			if (str_upload_dir == "")
			{
				MessageBox.Show("Root folder for vehicle attachment is not set. Please check and retry.",
					"ROOT FOLDER INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (!Directory.Exists(str_upload_dir))
			{
				MessageBox.Show(str_upload_dir + " cannot be found. Please check and retry.",
					"ROOT FOLDER INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				str_upload_dir = Path.Combine(str_upload_dir, VehicleID.ToString());
				// if vehicle's upload dir not created before, create it now
				if (!Directory.Exists(str_upload_dir))
				{
					try
					{
						Directory.CreateDirectory(str_upload_dir);
					}
					catch (Exception)
					{
						// ignore
					}
				}

				// check again. by now it MUST be available
				if (Directory.Exists(str_upload_dir))
				{
					using (Vehicle_attachment_ds.sp_select_vehicle_attachmentDataTable dttable =
						(Vehicle_attachment_ds.sp_select_vehicle_attachmentDataTable)grd_file_attachment.DataSource)
					{
						using (Vehicle_attachment_ds.sp_select_vehicle_attachmentDataTable ori_table =
							Vehicle_attachment_ds.Select_vehicle_attachment(VehicleID))
						{
							List<int> list_keep_id = (from row in dttable select row.vehicle_attachment).ToList();

							foreach (Vehicle_attachment_ds.sp_select_vehicle_attachmentRow ori_row in ori_table)
							{
								if (!list_keep_id.Contains(ori_row.vehicle_attachment))
								{
									try
									{
										File.Delete(ori_row.full_pathfilename);
										Vehicle_attachment_ds.Delete_vehicle_attachment(ori_row.vehicle_attachment, VehicleID);
									}
									catch (Exception)
									{
										MessageBox.Show("File delete failed...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}
							}
						}
						foreach (Vehicle_attachment_ds.sp_select_vehicle_attachmentRow dt_row in dttable)
						{
							if (dt_row.vehicle_attachment < 0)
							{
								// new file added. copy to upload location first then insert to DB
								try
								{
									string new_filename = Class_misc.Copy_file(dt_row.full_pathfilename, str_upload_dir);
									Vehicle_attachment_ds.Insert_vehicle_attachment(VehicleID, new_filename);
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
							}
						}
					}
					using (Vehicle_image_ds.sp_select_vehicle_imageDataTable dttable =
						(Vehicle_image_ds.sp_select_vehicle_imageDataTable)grd_image.DataSource)
					{
						using (Vehicle_image_ds.sp_select_vehicle_imageDataTable ori_dttable =
							Vehicle_image_ds.Select_vehicle_image(VehicleID))
						{
							List<int> list_keep_id = (from row in dttable select row.vehicle_image).ToList();

							foreach (Vehicle_image_ds.sp_select_vehicle_imageRow ori_row in ori_dttable)
							{
								if (!list_keep_id.Contains(ori_row.vehicle_image))
								{
									try
									{
										File.Delete(ori_row.filename);
										Vehicle_image_ds.Delete_vehicle_image(ori_row.vehicle_image, VehicleID);
									}
									catch (Exception)
									{
										MessageBox.Show("Image delete failed...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}
							}
						}
						foreach (Vehicle_image_ds.sp_select_vehicle_imageRow dt_row in dttable)
						{
							if (dt_row.vehicle_image < 0)
							{
								// new image
								try
								{
									string new_filename = Path.Combine(str_upload_dir, Class_misc.Generate_random_string(dt_row.vehicle_image) + ".jpg");
									MemoryStream ms = new MemoryStream(dt_row.image);
									Image.FromStream(ms).Save(new_filename, System.Drawing.Imaging.ImageFormat.Jpeg);
									ms.Dispose();
									Vehicle_image_ds.Insert_vehicle_image(VehicleID, new_filename, dt_row.description);
								}
								catch (Exception ex)
								{
									MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
							}
						}
					}
				}
				else
				{
					MessageBox.Show("Upload directory could not be created...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			Cursor = Cursors.Default;

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private int Update_insert_payment(string str_doc_prefix, int int_payment_id,
			string str_payment_description, int int_pay_to_id,
			string str_pay_to_type, decimal dec_amount, DateTime payment_date, bool is_paid,
			string str_payment_method_type, int int_payment_method_id, string str_cheque_no, string str_cc_no,
			int int_cc_type, int int_finance_id, DateTime payment_method_date, string str_remark)
		{
			int int_credit_card = 0; // default value is 0. only set value if right payment method type selected
			int int_cheque = 0; // default value is 0. only set value if right payment method type selected
			int int_payment_method = 0; // default value is 0. only set value if right payment method type selected

			switch (str_payment_method_type)
			{
				case "CREDIT_CARD":
					int_credit_card = Credit_card_ds.Update_insert_credit_card(str_cc_no,
						int_cc_type, int_finance_id, payment_method_date);
					break;
				case "CHEQUE":
					int_cheque = Cheque_ds.Update_insert_cheque(str_cheque_no, payment_method_date, int_finance_id);
					break;
				default:
					int_payment_method = int_payment_method_id;
					break;
			}
			if (int_payment_id > 0)
			{
				// update
				Payment_ds.Update_payment(int_payment_id, str_payment_description, payment_date,
					dec_amount, int_cheque, int_credit_card, int_payment_method, is_paid,
					int_pay_to_id, (str_pay_to_type == "PERSON"), str_remark);
			}
			else
			{
				// insert
				int_payment_id = Payment_ds.Insert_payment(str_doc_prefix, str_payment_description,
					payment_date, dec_amount, int_cheque, int_credit_card, int_payment_method,
					is_paid, int_pay_to_id, (str_pay_to_type == "PERSON"), str_remark);
			}

			return int_payment_id;
		}

		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Form_edit_vehicle_Shown(object sender, EventArgs e)
		{
			if (!Program.System_user.Has_permission("VEHICLE_ADD_EDIT"))
			{
				MessageBox.Show("You do not have sufficient permission to perform this action!",
					"ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
				return;
			}

			cmb_vehicle_colour.DisplayMember = "colour_name";
			cmb_vehicle_colour.ValueMember = "colour";
			cmb_vehicle_colour.DataSource = Colour_ds.Select_colour();

			cmb_acquire_method.SelectedItem = "PURCHASE"; // DEFAULT

			grd_expenses.DataSource = Vehicle_payment_ds.Select_vehicle_payment(VehicleID, Class_enum.Payment_function.VEHICLE_EXPENSES);
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_expenses,
				"charge_to_customer", "payment_no", "payment_description", "pay_to", "amount",
				"payment_date", "is_paid", "payment_method_type", "cheque_no", "credit_card_no",
				"payment_method", "finance", "remark", "modified_by");
			// column charge_to_customer will be checkbox. allow user to tick/untick. other columns cannot edit
			foreach (DataGridViewColumn grd_col in grd_expenses.Columns)
			{
				grd_col.ReadOnly = true;
				if (grd_col.Name == "charge_to_customer")
				{
					grd_col.ReadOnly = false;
					grd_col.DefaultCellStyle.BackColor = Color.Yellow;
				}
			}

			grd_expenses.Columns["amount"].DefaultCellStyle.Format = "N2";
			grd_expenses.Columns["amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

			grd_payment.DataSource = Vehicle_payment_ds.Select_vehicle_payment(VehicleID,
				Class_enum.Payment_function.VEHICLE_PAY_TO_SELLER);
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_payment,
				"payment_no", "payment_description", "pay_to", "amount",
				"payment_date", "is_paid", "payment_method_type", "cheque_no", "credit_card_no",
				"payment_method", "finance", "remark", "modified_by");

			grd_payment.Columns["amount"].DefaultCellStyle.Format = "N2";
			grd_payment.Columns["amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

			// VEHICLE IMAGE
			{
				// set default height for datagridviewrow
				grd_image.RowTemplate.Height = Program.GRD_IMAGE_ROW_HEIGHT;
				Vehicle_image_ds.sp_select_vehicle_imageDataTable dttable_image = Vehicle_image_ds.Select_vehicle_image(VehicleID);
				dttable_image.imageColumn.ReadOnly = false;
				// load images to datatable from filename
				foreach (Vehicle_image_ds.sp_select_vehicle_imageRow dt_row in dttable_image.Rows)
				{
					if (File.Exists(dt_row.filename))
						dt_row.image = Class_image.Image_to_byte_array(Image.FromFile(dt_row.filename));
				}

				grd_image.DataSource = dttable_image;
				if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_image,
					"image", "description");
				((DataGridViewImageColumn)grd_image.Columns["image"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
				grd_image.Columns["description"].Width = 300; // set wider
				Class_datagridview.Set_max_length_grd_col_same_with_datatable_col(grd_image, "description");
			}

			grd_file_attachment.DataSource = Vehicle_attachment_ds.Select_vehicle_attachment(VehicleID);
			if (!Program.System_user.IsDeveloper) Class_datagridview.Hide_unnecessary_columns(grd_file_attachment, "filename");
			grd_file_attachment.Columns["filename"].Width = 300;

			if (VehicleID == 0) return;

			// select vehicle and populate controls
			using (Vehicle_ds.sp_select_vehicleDataTable dttable = Vehicle_ds.Select_vehicle(VehicleID))
			{
				if (dttable.Rows.Count == 0) return;

				txt_status.Text = dttable[0].vehicle_status;
				txt_last_modified_by.Text = dttable[0].modified_by;
				txt_last_modified_on.Text = dttable[0].last_modified_on.ToString();
				txt_ref_no.Text = dttable[0].reference_no;
				txt_reg_no.Text = dttable[0].registration_no;
				txt_chassis.Text = dttable[0].chassis_no;
				txt_vehicle_model.Text = dttable[0].vehicle_model_name;
				num_vehicle_model_id.Value = dttable[0].vehicle_model;
				txt_vehicle_group.Text = dttable[0].vehicle_group_name;
				txt_vehicle_brand.Text = dttable[0].vehicle_brand_name;

				if (dttable[0]["location"] != DBNull.Value)
				{
					txt_vehicle_location.Text = dttable[0].location_name;
					num_vehicle_location.Value = dttable[0].location;
				}
				txt_year_make.Text = dttable[0].year_make.ToString();
				txt_engine_no.Text = dttable[0].engine_no;
				num_engine_cc.Value = (decimal)dttable[0].engine_cc;
				txt_ignition_key.Text = dttable[0].ignition_key;
				txt_door_key.Text = dttable[0].door_key;
				num_mileage.Value = dttable[0].mileage;
				cmb_vehicle_colour.SelectedValue = dttable[0].colour;
				rad_vehicle_new.Checked = dttable[0].is_new;
				rad_vehicle_old.Checked = !dttable[0].is_new;
				dtp_registered.Value = dttable[0].registration_date;
				dtp_road_tax_expiry.Value = dttable[0].road_tax_expiry_date;
				num_road_tax_amount.Value = dttable[0].road_tax;

				if (dttable[0]["seller_person"] != DBNull.Value)
				{
					// seller is person
					txt_seller_type.Text = "PERSON";
					txt_seller_name.Text = dttable[0].seller_person_name;
					num_seller_id.Value = dttable[0].seller_person;
				}
				else
				{
					// seller is organisation
					txt_seller_type.Text = "ORGANISATION";
					txt_seller_name.Text = dttable[0].seller_org_name;
					txt_seller_branch.Text = dttable[0].seller_branch_name;
					num_seller_id.Value = dttable[0].seller_organisation_branch;
				}

				txt_checked_by.Text = dttable[0].checked_by;
				num_checked_by_id.Value = dttable[0].checked_by_id;
				txt_invoice_no.Text = dttable[0].invoice_no;
				cmb_acquire_method.SelectedItem = dttable[0].acquire_method;
				dtp_purchase_date.Value = dttable[0].purchase_date;
				dtp_date_received.Value = dttable[0].date_received;
				dtp_settle_by.Value = dttable[0].settlement_date;

				if (dttable[0]["sale_ref_no"] != DBNull.Value)
					txt_sale_order.Text = dttable[0].sale_ref_no;

				num_purchase_price.Value = dttable[0].purchase_price;
				num_overtrade.Value = dttable[0].overtrade;
				num_list_price.Value = dttable[0].list_price;

				num_loan_balance.Value = dttable[0].loan_balance;

				if (dttable[0]["loan_finance"] != DBNull.Value)
				{
					num_loan_finance_id.Value = dttable[0].loan_finance;
					txt_loan_finance.Text = dttable[0].loan_org_name;
					txt_loan_branch.Text = dttable[0].loan_branch_name;
				}

				num_installment_amount.Value = dttable[0].loan_installment_amount;
				num_installment_day.Value = dttable[0].loan_installment_day_of_month;
				dtp_loan_settlement_date.Value = dttable[0].loan_settlement_date;
				txt_loan_agreement_no.Text = dttable[0].loan_agreement_no;

				txt_remark.Text = dttable[0].remark;
			}
			Process_vehicle_expenses();
			Process_vehicle_payment();
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

			str_param = txtbox.Text.Trim(); // set value for checking when control is entered next time

			string str_reg_no = "";
			string str_chassis_no = "";

			if (txtbox == txt_reg_no)
				str_reg_no = str_param;
			else
				str_chassis_no = str_param;

			Setup_vehicle_details(str_reg_no, str_chassis_no);
		}
		private void Setup_vehicle_details(string str_reg_no, string str_chassis_no)
		{
			using (Vehicle_ds.sp_select_vehicleDataTable dttable =
					Vehicle_ds.Select_vehicle_latest_record(str_reg_no, str_chassis_no))
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
				dtp_registered.Value = dttable[0].registration_date;
			}
		}
		private void Btn_vehicle_model_Click(object sender, EventArgs e)
		{
			using (Form_datagridview_select dlg_select = new Form_datagridview_select(
				Vehicle_model_ds.Select_vehicle_model(-1, -1, -1, -1), new string[] { "vehicle_model_name", "year_make",
	 "engine_capacity", "no_of_door", "seat_capacity", "fuel_type_name", "transmission_name", "vehicle_group_name",
	 "vehicle_brand_name" }, "vehicle_model", num_vehicle_model_id.Value.ToString()))
			{
				if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
				{
					num_vehicle_model_id.Value = dlg_select.Get_selected_value_as_int("vehicle_model");
					txt_vehicle_model.Text = dlg_select.Get_selected_value_as_string("vehicle_model_name");
					txt_vehicle_group.Text = dlg_select.Get_selected_value_as_string("vehicle_group_name");
					txt_vehicle_brand.Text = dlg_select.Get_selected_value_as_string("vehicle_brand_name");
					txt_year_make.Text = dlg_select.Get_selected_value_as_string("year_make");
				}
			}
		}

		private void Btn_vehicle_location_Click(object sender, EventArgs e)
		{
			using (Form_datagridview_select dlg_select = new Form_datagridview_select(Location_ds.Select_location(),
				new string[] { "location_name" }, "location", num_vehicle_location.Value.ToString()))
			{
				if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
				{
					num_vehicle_location.Value = dlg_select.Get_selected_value_as_int("location");
					txt_vehicle_location.Text = dlg_select.Get_selected_value_as_string("location_name");
				}
			}
		}

		private void Btn_seller_Click(object sender, EventArgs e)
		{
			using (Form_datagridview_select dlg_select = new Form_datagridview_select("PERSON_ORGANISATION"))
			{
				if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
				{
					txt_seller_type.Text = dlg_select.cmb_type.SelectedItem.ToString().ToUpper();

					if (txt_seller_type.Text == "PERSON")
					{
						num_seller_id.Value = dlg_select.Get_selected_value_as_int("person");
						txt_seller_name.Text = dlg_select.Get_selected_value_as_string("name");
						txt_seller_branch.Text = "";
					}
					else
					{
						num_seller_id.Value = dlg_select.Get_selected_value_as_int("organisation");
						txt_seller_name.Text = dlg_select.Get_selected_value_as_string("name");
						txt_seller_branch.Text = dlg_select.Get_selected_value_as_string("branch_name");
					}
				}
			}
		}

		private void Btn_checked_by_Click(object sender, EventArgs e)
		{
			using (Form_datagridview_select dlg_select = new Form_datagridview_select(User_ds.Select_user_all(),
				new string[] { "name", "usergroup", "ic_no", "is_active", "join_date", "leave_date" }, "user",
				num_checked_by_id.Value.ToString()))
			{
				if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
				{
					txt_checked_by.Text = dlg_select.Get_selected_value_as_string("name");
					num_checked_by_id.Value = dlg_select.Get_selected_value_as_int("user");
				}
			}
		}
		private void Cmb_acquire_method_SelectedIndexChanged(object sender, EventArgs e)
		{
			btn_sales_order.Enabled = cmb_acquire_method.SelectedItem.ToString() == "TRADE-IN";
		}
		private void Btn_sales_order_Click(object sender, EventArgs e)
		{
			// TODO

		}
		private void Recalculate_nums(object sender, EventArgs e)
		{
			num_net_purchase.Value = num_purchase_price.Value - num_overtrade.Value;
			num_to_pay.Value = num_net_purchase.Value - num_loan_balance.Value - num_paid.Value;
			num_total_cost.Value = num_net_purchase.Value + num_expenses.Value;
			num_gross_profit.Value = num_list_price.Value + num_expenses_charged.Value - num_total_cost.Value;
		}
		private void Num_loan_balance_ValueChanged(object sender, EventArgs e)
		{
			num_loan_balance_readonly.Value = num_loan_balance.Value;
		}
		private void Btn_loan_finance_Click(object sender, EventArgs e)
		{
			using (Form_datagridview_select dlg_select = new Form_datagridview_select(Finance_ds.Select_finance(-1),
				new string[] { "name", "branch_name", "registration_no", "address", "city", "state", "postcode",
	 "country_name", "url", "remark" }, "finance", num_loan_finance_id.Value.ToString()))
			{
				if (dlg_select.ShowDialog() == DialogResult.OK && dlg_select.grd_main.SelectedCells.Count > 0)
				{
					txt_loan_finance.Text = dlg_select.Get_selected_value_as_string("name");
					txt_loan_branch.Text = dlg_select.Get_selected_value_as_string("branch_name");
					num_loan_finance_id.Value = dlg_select.Get_selected_value_as_int("finance");
				}
			}
		}
		private void Btn_add_expenses_Click(object sender, EventArgs e)
		{
			using (Form_edit_payment dlg_payment = new Form_edit_payment())
			{
				if (dlg_payment.ShowDialog() != DialogResult.OK) return;

				Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable =
					(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_expenses.DataSource;

				dttable.Addsp_select_vehicle_paymentRow(true, dlg_payment.PaymentNo,
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
		}
		private void Btn_edit_expenses_Click(object sender, EventArgs e)
		{
			if (grd_expenses.SelectedCells.Count == 0) return;

			Vehicle_payment_ds.sp_select_vehicle_paymentRow dt_row =
				(from row in (Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_expenses.DataSource
				 where row.payment == (int)grd_expenses.SelectedCells[0].OwningRow.Cells["payment"].Value
				 select row).ToList()[0];

			using (Form_edit_payment dlg_payment = new Form_edit_payment(dt_row.payment, dt_row.payment_no,
				dt_row.payment_description, dt_row.is_paid, dt_row.pay_to_id, dt_row.pay_to,
				dt_row.pay_to_type, dt_row.payment_date, dt_row.amount, dt_row.payment_method_type,
				(dt_row["payment_method_id"] == DBNull.Value) ? 0 : dt_row.payment_method_id,
				(dt_row["credit_card_no"] == DBNull.Value) ? "" : dt_row.credit_card_no,
				(dt_row["cheque_no"] == DBNull.Value) ? "" : dt_row.cheque_no,
				(dt_row["credit_card_type_id"] == DBNull.Value) ? 0 : dt_row.credit_card_type_id,
				(dt_row["finance_id"] == DBNull.Value) ? 0 : dt_row.finance_id,
				(dt_row["finance"] == DBNull.Value) ? "" : dt_row.finance,
				(dt_row["payment_method_date"] == DBNull.Value) ? DateTime.Today : dt_row.payment_method_date,
				dt_row.remark))
			{
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
			}

			Process_vehicle_expenses();
		}
		private void Btn_delete_expenses_Click(object sender, EventArgs e)
		{
			if (grd_expenses.SelectedCells.Count == 0) return;

			if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning) != DialogResult.Yes) return;

			List<int> list_payment_id = new List<int>();

			Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable =
				(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_expenses.DataSource;

			foreach (DataGridViewCell grd_cell in grd_expenses.SelectedCells)
			{
				list_payment_id.Add((int)grd_cell.OwningRow.Cells["payment"].Value);
			}
			for (int i = dttable.Rows.Count - 1; i >= 0; i--)
			{
				if (list_payment_id.Contains(dttable[i].payment)) dttable.Rows.RemoveAt(i);
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

			Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable =
				(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_expenses.DataSource;

			decimal dcml_expenses = (from row in dttable select row.amount).Sum();
			decimal dcml_expenses_charged = 0;

			var query_charged = (from row in dttable where row.charge_to_customer select row.amount);
			if (query_charged.Count() > 0) dcml_expenses_charged = query_charged.Sum();

			lbl_total_expenses.Text = dcml_expenses.ToString("#,##0.00");
			lbl_expenses_charged.Text = dcml_expenses_charged.ToString("#,##0.00");
			num_expenses.Value = dcml_expenses;
			num_expenses_charged.Value = dcml_expenses_charged;
		}
		private void Btn_add_payment_Click(object sender, EventArgs e)
		{
			using (Form_edit_payment dlg_payment = new Form_edit_payment((int)num_seller_id.Value,
				txt_seller_name.Text, txt_seller_type.Text))
			{
				if (dlg_payment.ShowDialog() != DialogResult.OK) return;

				Vehicle_payment_ds.sp_select_vehicle_paymentDataTable dttable =
					(Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_payment.DataSource;

				dttable.Addsp_select_vehicle_paymentRow(false, dlg_payment.PaymentNo,
					dlg_payment.PaymentDescription, dlg_payment.PayToId, dlg_payment.PayToName,
					dlg_payment.PayToType, dlg_payment.PaymentAmount, dlg_payment.PaymentDate,
					dlg_payment.IsPaid, dlg_payment.PaymentMethodType,
					dlg_payment.PaymentMethodDescription, dlg_payment.PaymentMethod,
					dlg_payment.ChequeNo, dlg_payment.CreditCardNo, dlg_payment.CreditCardTypeId,
					dlg_payment.CreditCardTypeName, dlg_payment.PaymentMethodFinance,
					dlg_payment.PaymentMethodFinanceName, dlg_payment.PaymentMethodDate,
					dlg_payment.PaymentRemark, Program.System_user.Name);
			}

			Process_vehicle_payment();
		}
		private void Btn_edit_payment_Click(object sender, EventArgs e)
		{
			if (grd_payment.Rows.Count == 0) return;

			Vehicle_payment_ds.sp_select_vehicle_paymentRow dt_row =
				(from row in (Vehicle_payment_ds.sp_select_vehicle_paymentDataTable)grd_payment.DataSource
				 where row.payment == (int)grd_payment.SelectedCells[0].OwningRow.Cells["payment"].Value
				 select row).ToList()[0];

			using (Form_edit_payment dlg_payment = new Form_edit_payment(dt_row.payment, dt_row.payment_no,
				dt_row.payment_description, dt_row.is_paid, dt_row.pay_to_id, dt_row.pay_to,
				dt_row.pay_to_type, dt_row.payment_date, dt_row.amount, dt_row.payment_method_type,
				(dt_row["payment_method_id"] == DBNull.Value) ? 0 : dt_row.payment_method_id,
				(dt_row["credit_card_no"] == DBNull.Value) ? "" : dt_row.credit_card_no,
				(dt_row["cheque_no"] == DBNull.Value) ? "" : dt_row.cheque_no,
				(dt_row["credit_card_type_id"] == DBNull.Value) ? 0 : dt_row.credit_card_type_id,
				(dt_row["finance_id"] == DBNull.Value) ? 0 : dt_row.finance_id,
				(dt_row["finance"] == DBNull.Value) ? "" : dt_row.finance,
				(dt_row["payment_method_date"] == DBNull.Value) ? DateTime.Today : dt_row.payment_method_date,
				dt_row.remark))
			{
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
			}

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
			for (int i = dttable.Rows.Count - 1; i >= 0; i--)
			{
				if (list_payment_id.Contains(dttable[i].payment)) dttable.Rows.RemoveAt(i);
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
				using (Image resized_image = Class_image.Resize_image(Image.FromFile(str_filename), 900))
				{
					dttable.Addsp_select_vehicle_imageRow(Class_image.Image_to_byte_array(resized_image), "", "");
				}
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

			for (int i = dttable.Rows.Count - 1; i >= 0; i--)
			{
				if (list_id.Contains(dttable[i].vehicle_image)) dttable.Rows.RemoveAt(i);
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
			try
			{
				picbox_image.Image = Class_image.Byte_array_to_image((byte[])grd_row.Cells["image"].Value);
			}
			catch (Exception)
			{
				// image display failed...
			}
			txt_image_description.Text = grd_row.Cells["description"].Value.ToString();
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
					File.SetLastWriteTime(Path.Combine(download_folder, new_filename), DateTime.Now);
				}
				Process.Start(download_folder); // open folder for view
			}
		}
		private void Grd_expenses_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			// charge to customer column is checkbox. allow user to click without triggering this function
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && grd_expenses.Columns[e.ColumnIndex].Name.ToUpper() != "CHARGE_TO_CUSTOMER")
				btn_edit_expenses.PerformClick();
		}
		private void Grd_expenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (grd_expenses.Columns[e.ColumnIndex].Name.ToUpper() == "CHARGE_TO_CUSTOMER")
			{
				grd_expenses.CommitEdit(DataGridViewDataErrorContexts.Commit);
				Process_vehicle_expenses();
			}
		}
		private void Grd_payment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0) btn_edit_payment.PerformClick();
		}
		private void Btn_clear_loan_finance_Click(object sender, EventArgs e)
		{
			num_loan_finance_id.Value = 0;
			txt_loan_finance.Text = "";
			txt_loan_branch.Text = "";
		}
		private void Grd_image_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			// column does not allow null. convert to empty string!!
			if (grd_image.Columns[e.ColumnIndex].Name.ToUpper() == "DESCRIPTION")
				grd_image[e.ColumnIndex, e.RowIndex].Value = "";
		}

	}
}
