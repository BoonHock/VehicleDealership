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
			Vehicle_brand_ds.sp_select_vehicle_brand_n_groupDataTable dttable = Vehicle_brand_ds.Select_vehicle_brand_n_group();

			foreach (var i in dttable.Select(i => new { i.country, i.country_name }).Distinct().OrderBy(i => i.country_name))
			{
				tv_vehicle.Nodes.Add(i.country.ToString(), i.country_name);
			}
			foreach (var i in dttable.Select(i => new { i.country, i.vehicle_brand, i.vehicle_brand_name }).Distinct().OrderBy(i => i.vehicle_brand_name))
			{
				tv_vehicle.Nodes[i.country.ToString()].Nodes.Add(i.vehicle_brand.ToString(), i.vehicle_brand_name);
			}
			foreach (var i in dttable.Select(i => new { i.country, i.vehicle_brand, i.vehicle_group, i.vehicle_group_name }).OrderBy(i => i.vehicle_group_name))
			{
				tv_vehicle.Nodes[i.country.ToString()].Nodes[i.vehicle_brand.ToString()].Nodes.Add(i.vehicle_group.ToString(), i.vehicle_group_name);
			}

			tv_vehicle.ExpandAll();
		}
		private void Cms_vehicle_Opening(object sender, CancelEventArgs e)
		{
			addBrandToolStripMenuItem.Enabled = true;
			addGroupToolStripMenuItem.Enabled = (tv_vehicle.SelectedNode != null && tv_vehicle.SelectedNode.Level >= 1);
		}

		private void Tv_vehicle_AfterSelect(object sender, TreeViewEventArgs e)
		{
			btn_add_group.Enabled = false;
			btn_edit.Enabled = false;
			btn_delete.Enabled = false;

			if (tv_vehicle.SelectedNode.Level >= 1)
			{
				btn_add_group.Enabled = true;
				btn_edit.Enabled = true;
				btn_delete.Enabled = true;
			}
		}

		private void Tv_vehicle_MouseDown(object sender, MouseEventArgs e)
		{
			// if user click on something, then select that node. if click on nothing, ignore
			if (tv_vehicle.GetNodeAt(e.X, e.Y) != null) tv_vehicle.SelectedNode = tv_vehicle.GetNodeAt(e.X, e.Y);
		}
	}
}
