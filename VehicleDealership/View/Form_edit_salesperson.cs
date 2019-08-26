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
	public partial class Form_edit_salesperson : Form
	{
		private readonly int SalespersonID = 0;
		/// <summary>
		/// this constructor is for EDITING existing salesperson
		/// </summary>
		/// <param name="int_salesperson"></param>
		public Form_edit_salesperson(int int_salesperson)
		{
			InitializeComponent();

			SalespersonID = int_salesperson;

			Setup_grd_salestarget();
		}
		/// <summary>
		/// this constructor is for ADDING new salesperson
		/// </summary>
		/// <param name="int_person_org">person ID or organisation ID</param>
		/// <param name="is_person">true if is person, false if is organisation</param>
		public Form_edit_salesperson(int int_person_org, bool is_person)
		{
			InitializeComponent();

			Setup_grd_salestarget();

			if (is_person)
			{
				Person_ds.sp_select_personDataTable dttable_person = Person_ds.Select_person(int_person_org);

				if (dttable_person.Rows.Count > 0)
				{
					DataRow dt_row = dttable_person.Rows[0];

					txt_person_name.Text = dt_row["name"].ToString();
					txt_ic_no.Text = dt_row["ic_no"].ToString();
					txt_person_type.Text = dt_row["person_org_description"].ToString();
					txt_driving_license.Text = dt_row["driving_license"].ToString();
					txt_gender.Text = ((bool)dt_row["gender"]) ? "MALE" : "FEMALE";
					txt_race.Text = dt_row["race_description"].ToString();
					txt_person_address.Text = dt_row["address"].ToString();
					txt_person_city.Text = dt_row["city"].ToString();
					txt_person_state.Text = dt_row["state"].ToString();
					txt_person_postcode.Text = dt_row["postcode"].ToString();
					txt_person_country.Text = dt_row["country_name"].ToString();
					//txt_person_name.Text = dt_row["occupation"].ToString();
					//txt_person_name.Text = dt_row["company"].ToString();
				}
			}
			else
			{

			}
		}
		private void Btn_ok_Click(object sender, EventArgs e)
		{


			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		private void Btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void Setup_grd_salestarget()
		{
			if (SalespersonID == 0)
				grd_salestarget.DataSource = new Salestarget_ds.sp_select_salestargetDataTable();
			else
				grd_salestarget.DataSource = Salestarget_ds.Select_salestarget(SalespersonID);

			Class_datagridview.Hide_columns(grd_salestarget, new string[] { "salestarget", "salesperson", "person" });
		}
	}
}
