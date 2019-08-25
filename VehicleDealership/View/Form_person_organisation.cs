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
	public partial class Form_person_organisation : Form
	{
		//string SelectedType
		//{
		//	get
		//	{
		//		if (tabControl1.SelectedTab == tab_person)
		//			return "PERSON";
		//		else
		//			return "ORGANISATION";
		//	}
		//}
		public string SelectedType { get; private set; }
		public int SelectedID { get; private set; } = 0;
		//int SelectedID
		//{
		//	get
		//	{
		//		if (tabControl1.SelectedTab == tab_person)
		//		{
		//			if (grd_person.SelectedCells.Count > 0)
		//				return int.Parse(grd_person.SelectedCells[0].OwningRow.Cells["person"].Value.ToString());
		//		}
		//		else
		//		{
		//			if (grd_organisation.SelectedCells.Count > 0)
		//				return int.Parse(grd_organisation.SelectedCells[0].OwningRow.Cells["organisation"].Value.ToString());
		//		}
		//		return 0;
		//	}
		//}
		public Form_person_organisation()
		{
			InitializeComponent();
		}
		private void Form_person_organisation_Shown(object sender, EventArgs e)
		{
			Class_style.Grd_style.Common_style(grd_person);
			Class_style.Grd_style.Common_style(grd_organisation);

			grd_person.DataSource = Person_ds.Select_person1();
			grd_organisation.DataSource = Organisation_ds.Select_organisation1();

			grd_person.Columns["person"].Visible = false;
			grd_organisation.Columns["organisation"].Visible = false;

			grd_person.AutoResizeColumns();
			tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{
			SelectedType = (tabControl1.SelectedTab == tab_person) ? "PERSON" : "ORGANISATION";

			if (tabControl1.SelectedTab == tab_person)
			{
				if (grd_person.SelectedCells.Count > 0)
					SelectedID = int.Parse(grd_person.SelectedCells[0].OwningRow.Cells["person"].Value.ToString());
			}
			else
			{
				if (grd_organisation.SelectedCells.Count > 0)
					SelectedID = int.Parse(grd_organisation.SelectedCells[0].OwningRow.Cells["organisation"].Value.ToString());
			}


			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		/// <summary>
		/// because datagridview will not be resized when not shown, auto resize grd_organisation the FIRST time grd_organisation is shown.
		/// after that, unattach this event handler
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedTab == tab_organisation)
			{
				grd_organisation.AutoResizeColumns();
				tabControl1.SelectedIndexChanged -= TabControl1_SelectedIndexChanged;
			}
		}
	}
}
