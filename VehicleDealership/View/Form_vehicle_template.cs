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
	public partial class Form_vehicle_template : Form
	{
		public Form_vehicle_template()
		{
			InitializeComponent();
		}

		private void Form_vehicle_template_Load(object sender, EventArgs e)
		{
			Setup_tv_vehicle();
		}
		private void Setup_tv_vehicle(int preselect_brand = 0)
		{
			Cursor.Current = Cursors.WaitCursor;

			tv_vehicle.Nodes.Clear();

			Vehicle_group_ds.sp_select_vehicle_brand_n_groupDataTable dttable = Vehicle_group_ds.Select_vehicle_brand_n_group();

			// country node
			foreach (var i in dttable.Select(i => new { i.country, i.country_name }).Distinct().OrderBy(i => i.country_name))
			{
				tv_vehicle.Nodes.Add(i.country.ToString(), i.country_name);
			}
			// vehicle brand node
			foreach (var i in dttable.Select(i => new { i.country, i.vehicle_brand, i.vehicle_brand_name }).Distinct().OrderBy(i => i.vehicle_brand_name))
			{
				tv_vehicle.Nodes[i.country.ToString()].Nodes.Add(i.vehicle_brand.ToString(), i.vehicle_brand_name);
			}
			// vehicle group name node
			foreach (var i in dttable.Select(i => new { i.country, i.vehicle_brand, i.vehicle_group, i.vehicle_group_name }).OrderBy(i => i.vehicle_group_name))
			{
				tv_vehicle.Nodes[i.country.ToString()].Nodes[i.vehicle_brand.ToString()].Nodes.Add(i.vehicle_group.ToString(), i.vehicle_group_name);
			}

			Format_brand_group_buttons();

			tv_vehicle.ExpandAll();

			Cursor.Current = Cursors.Default;
		}
		private void Format_brand_group_buttons()
		{
			btn_add_group.Enabled = false;
			btn_edit.Enabled = false;

			editBrandGroupToolStripMenuItem.Enabled = false;
			addGroupToolStripMenuItem.Enabled = false;

			if (tv_vehicle.SelectedNode != null && tv_vehicle.SelectedNode.Level >= 1)
			{
				btn_add_group.Enabled = true;
				btn_edit.Enabled = true;

				editBrandGroupToolStripMenuItem.Enabled = true;
				addGroupToolStripMenuItem.Enabled = true;
			}
		}
		private void Tv_vehicle_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Format_brand_group_buttons();
		}

		private void Tv_vehicle_MouseDown(object sender, MouseEventArgs e)
		{
			// if user click on something, then select that node. if click on nothing, ignore
			if (tv_vehicle.GetNodeAt(e.X, e.Y) != null) tv_vehicle.SelectedNode = tv_vehicle.GetNodeAt(e.X, e.Y);
		}

		private void Add_brand(object sender, EventArgs e)
		{
			int int_country = 0;

			if (tv_vehicle.SelectedNode != null)
				int_country = int.Parse(Class_treeview.Get_parent_node_by_level(tv_vehicle.SelectedNode, 0).Name);

			Form_add_vehicle_brand form_brand = new Form_add_vehicle_brand(0, int_country);

			if (form_brand.ShowDialog() == DialogResult.OK)
				Setup_tv_vehicle(form_brand.BrandID);
		}
		private void Add_group(object sender, EventArgs e)
		{
			// TODO
		}

		private void Btn_edit_Click(object sender, EventArgs e)
		{
			if (tv_vehicle.SelectedNode == null) return;

			switch (tv_vehicle.SelectedNode.Level)
			{
				case 1:
					Form_add_vehicle_brand form_brand = new Form_add_vehicle_brand(int.Parse(tv_vehicle.SelectedNode.Name));

					if (form_brand.ShowDialog() == DialogResult.OK) Setup_tv_vehicle(form_brand.BrandID);
					break;
			}
		}
	}
}
