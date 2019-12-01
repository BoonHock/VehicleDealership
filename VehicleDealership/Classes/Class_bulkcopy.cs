using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDealership.Classes
{
	class Class_bulkcopy
	{
		public readonly System.Data.DataTable _dttable;

		// provide datadatable column name to match database table column name
		public string INT1 = "";
		public string INT2 = "";
		public string NVARCHAR1 = "";
		public string NVARCHAR2 = "";
		public string NVARCHAR3 = "";
		public string NVARCHAR4 = "";
		public string NVARCHAR5 = "";
		public string DECIMAL18_4 = "";

		public Class_bulkcopy(System.Data.DataTable dttable, bool clean_db = true)
		{
			_dttable = dttable;

			if (!_dttable.Columns.Contains("uploaded_by"))
				Class_datatable.Add_uploaded_by_columns(ref _dttable);

			if (clean_db) Datasets.Bulkcopy_table_ds.Delete_by_user();
		}

		public bool Write_to_db()
		{
			using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VehicleDealershipConnectionString))
			{
				conn.Open();

				using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
				{
					bulkCopy.DestinationTableName = "[misc].[bulkcopy_table]";

					try
					{
						bulkCopy.ColumnMappings.Add(INT1, "int1");
						bulkCopy.ColumnMappings.Add(INT2, "int2");
						bulkCopy.ColumnMappings.Add(NVARCHAR1, "nvarchar1");
						bulkCopy.ColumnMappings.Add(NVARCHAR2, "nvarchar2");
						bulkCopy.ColumnMappings.Add(NVARCHAR3, "nvarchar3");
						bulkCopy.ColumnMappings.Add(NVARCHAR4, "nvarchar4");
						bulkCopy.ColumnMappings.Add(NVARCHAR5, "nvarchar5");
						bulkCopy.ColumnMappings.Add(DECIMAL18_4, "decimal18_4");
						bulkCopy.ColumnMappings.Add("uploaded_by", "created_by");
						bulkCopy.WriteToServer(_dttable);
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error has occurred. \n\n Message: " + ex.Message,
							"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
						conn.Close();
						return false;
					}
				}
				conn.Close();
			}
			return true;
		}

		/*
		 nvarchar1	nvarchar(MAX)	Checked
		nvarchar2	nvarchar(MAX)	Checked
		nvarchar3	nvarchar(MAX)	Checked
		nvarchar4	nvarchar(MAX)	Checked
		nvarchar5	nvarchar(MAX)	Checked
		int1	int	Checked
		int2	int	Checked
		decimal18_4	decimal(18, 4)	Checked
		created_by	int	Unchecked
				 */

	}
}
