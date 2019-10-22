using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Datasets;
using VehicleDealership.Classes;

namespace VehicleDealership.View
{
	public partial class Form_vehicle_return : Form
	{
		readonly int _vehicle_id;
		bool _is_updating = false;
		public Form_vehicle_return(int int_vehicle)
		{
			InitializeComponent();

			_vehicle_id = int_vehicle;
		}

		private void Form_vehicle_return_Shown(object sender, EventArgs e)
		{
			using (Vehicle_ds.sp_select_vehicleDataTable dttable = Vehicle_ds.Select_vehicle(_vehicle_id))
			{
				// no vehicle found. should not display form
				if (dttable.Rows.Count == 0)
				{
					this.Close();
					return;
				}

				txt_reg_no.Text = dttable[0].registration_no;
				txt_vbrand.Text = dttable[0].vehicle_brand_name;
				txt_vgroup.Text = dttable[0].vehicle_group_name;
				txt_vmodel.Text = dttable[0].vehicle_model_name;
				dtp_purchase.Value = dttable[0].purchase_date;
				if (dttable[0]["seller_person"] != DBNull.Value)
					txt_seller.Text = dttable[0].seller_person_name; // seller is person
				else
					txt_seller.Text = dttable[0].seller_org_name + '\n' + dttable[0].seller_branch_name; // seller is organisation
			}

			using (Vehicle_return_ds.sp_select_vehicle_returnDataTable dttable = Vehicle_return_ds.Select_vehicle_return(_vehicle_id))
			{
				if (dttable.Rows.Count > 0)
				{
					_is_updating = true;
					dtp_return.Value = dttable[0].return_date;
					txt_return_by.Text = dttable[0].return_by;
					btn_return_by.Tag = dttable[0].return_by_id;
					num_compensation.Value = dttable[0].compensation;
					txt_remark.Text = dttable[0].remark;
				}
			}
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			int return_by = (int)btn_return_by.Tag;
			if (return_by == 0)
			{
				MessageBox.Show("'Return by' not selected.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (_is_updating)
			{
				if (Vehicle_return_ds.Update_vehicle_return(_vehicle_id, dtp_return.Value, return_by, num_compensation.Value, txt_remark.Text.Trim()))
				{
					MessageBox.Show("Update failed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			else
			{
				if (Vehicle_return_ds.Insert_vehicle_return(_vehicle_id, dtp_return.Value, return_by, num_compensation.Value, txt_remark.Text.Trim()))
				{
					MessageBox.Show("Insert failed.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
