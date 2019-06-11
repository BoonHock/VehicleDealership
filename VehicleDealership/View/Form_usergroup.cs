using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleDealership.Classes;
using VehicleDealership.Datasets;

namespace VehicleDealership.View
{
	public partial class Form_usergroup : Form
	{
		public Form_usergroup()
		{
			InitializeComponent();
		}

		private void Form_usergroup_Load(object sender, EventArgs e)
		{
			Class_style.Grd_style.Common_style(Grd_usergroup);

			Setup_grd_usergroup();
		}
		private void Setup_grd_usergroup()
		{
			Grd_usergroup.DataSource = Permission_ds.Select_usergroup();
			Grd_usergroup.AutoResizeColumns();
		}
		private void Btn_add_Click(object sender, EventArgs e)
		{
			Form_edit_usergroup form_edit = new Form_edit_usergroup();
			if (form_edit.ShowDialog() != DialogResult.OK) return;

			Setup_grd_usergroup();


		}
		private void Btn_edit_Click(object sender, EventArgs e)
		{
			if (Grd_usergroup.SelectedCells.Count == 0)
			{
				MessageBox.Show("Select a usergroup to edit.");
				return;
			}

			DataGridViewRow grd_row = Grd_usergroup.Rows[Grd_usergroup.SelectedCells[0].RowIndex];

			Form_edit_usergroup form_edit = new Form_edit_usergroup(grd_row.Cells["usergroup"].Value.ToString(), 
				grd_row.Cells["usergroup_desc"].Value.ToString());

			if (form_edit.ShowDialog() == DialogResult.OK)
			{
				Setup_grd_usergroup();
			}
		}
	}
}
