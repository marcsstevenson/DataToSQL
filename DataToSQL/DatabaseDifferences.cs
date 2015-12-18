#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text;

#endregion

namespace DisplayLayer
{
	partial class DataToSQL : Form
	{
		private const string strLastConnectionString1FileName = "LastConnectionString1.txt";
		private const string strLastConnectionString2FileName = "LastConnectionString2.txt";
		private const string strLastSQL = "LastSQL.txt";

		private string LastConnectionString1
		{
			get
			{
				string strReturn = null;

				if (clsFileController.FileExists(strLastConnectionString1FileName))
				{
					try
					{
						strReturn = clsFileController.ReadFileToEnd(strLastConnectionString1FileName).Trim();
					}
					catch
					{
						strReturn = null;
					}
				}

				return strReturn;
			}
			set
			{
				if (clsFileController.FileExists(strLastConnectionString1FileName))
				{
					clsFileController.DeleteFile(strLastConnectionString1FileName);
				}

				clsFileController.WriteTextToFile(strLastConnectionString1FileName, value);
			}
		}

		private string LastConnectionString2
		{
			get
			{
				string strReturn = null;

				if (clsFileController.FileExists(strLastConnectionString2FileName))
				{
					try
					{
						strReturn = clsFileController.ReadFileToEnd(strLastConnectionString2FileName).Trim();
					}
					catch
					{
						strReturn = null;
					}
				}

				return strReturn;
			}
			set
			{
				if (clsFileController.FileExists(strLastConnectionString2FileName))
				{
					clsFileController.DeleteFile(strLastConnectionString2FileName);
				}

				clsFileController.WriteTextToFile(strLastConnectionString2FileName, value);
			}
		}

		private string LastSQL
		{
			get
			{
				string strReturn = null;

				if (clsFileController.FileExists(strLastSQL))
				{
					try
					{
						strReturn = clsFileController.ReadFileToEnd(strLastSQL).Trim();
					}
					catch
					{
						strReturn = null;
					}
				}

				return strReturn;
			}
			set
			{
				if (clsFileController.FileExists(strLastSQL))
				{
					clsFileController.DeleteFile(strLastSQL);
				}

				clsFileController.WriteTextToFile(strLastSQL, value);
			}
		}

		private GenerateResponse GetFromData()
		{
			DataTable dtReturn = null;
			DataLayer.DataRunner objDR = null;

			var generateResponse = new GenerateResponse();

            var myConnection = new SqlConnection(this.txtConnectionString1.Text);

            try
			{
                myConnection.Open();
                var myCommand = new SqlCommand(this.txtConnectionString1.Text, myConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);

                DataSet customers = new DataSet();
                adapter.Fill(customers, "Customers");

                using (SqlDataReader oReader = myCommand.ExecuteReader())
                {
                    oReader.Read()

                    while (oReader.Read())
                    {
                        matchingPerson.firstName = oReader["FirstName"].ToString();
                        matchingPerson.lastName = oReader["LastName"].ToString();
                    }

                    myConnection.Close();
                }



                objDR = new DataLayer.DataRunner(this.txtConnectionString1.Text);
				dtReturn = objDR.ExecuteDataTableSQL(this.txtSQLSelect.Text);
				this.lblCount.Text = dtReturn.Rows.Count.ToString();

				generateResponse.SQL = GetSQLFromDataText(dtReturn);
				generateResponse.QueryResult = dtReturn;
			}
			catch (System.Exception ex)
			{
				MessageBox.Show(ex.Message, "Problem", MessageBoxButtons.OK);
			}
			finally
			{
                myConnection.Close();
            }

			//Save the connection string and the SQL
			this.LastConnectionString1 = this.txtConnectionString1.Text;
			this.LastSQL = this.txtSQLSelect.Text;

			//dtReturn.DefaultView.RowFilter = "Name = 'sourcing'";

			return generateResponse;
		}

		private class GenerateResponse
		{
			public DataTable QueryResult { get; set; }
			public StringBuilder SQL { get; set; }
		}

		private StringBuilder GetSQLFromDataText(DataTable dtData)
		{
			string strTableName = GetFromTableName(this.txtSQLSelect.Text);
			StringBuilder objSB = new System.Text.StringBuilder();

			for (int i = 0; i < dtData.Rows.Count; i++)
				objSB.Append(GenerateSQL(dtData.Rows[i], strTableName));

			return objSB;
		}

		private string GenerateSQL(DataRow objDR, string strTableName)
		{
			string strComma = "";
			System.Type objType;
			System.Text.StringBuilder objSB = new System.Text.StringBuilder();
			System.Text.StringBuilder objSBTop = new System.Text.StringBuilder();
			System.Text.StringBuilder objSBBottom = new System.Text.StringBuilder();

			objSB.Append("INSERT INTO [" + strTableName + "]");

			foreach (DataColumn objCol in objDR.Table.Columns)
			{
				objSBTop.Append(strComma + "[" + objCol.ColumnName + "]");

				if (objDR[objCol.ColumnName] == DBNull.Value)
					objSBBottom.Append(strComma + "null");
				else
				{
					objType = objDR[objCol.ColumnName].GetType();

					if (objType == int.MaxValue.GetType())
						objSBBottom.Append(strComma + objDR[objCol.ColumnName]);
					else if (objType == DateTime.Now.GetType() && objDR[objCol.ColumnName] != DBNull.Value)
					{
						DateTime dateTime = (DateTime)objDR[objCol.ColumnName];

						objSBBottom.Append(strComma + "convert(datetime, '" + dateTime.Day + "/" + dateTime.Month + "/" + dateTime.Year + "', 103)");
					}
					else
						objSBBottom.Append(strComma + "'" + objDR[objCol.ColumnName] + "'");
				}

				strComma = " ,";
			}

			objSB.Append("(");
			objSB.Append(objSBTop.ToString());
			objSB.AppendLine(")");
			objSB.AppendLine("VALUES");
			objSB.Append("(");
			objSB.Append(objSBBottom.ToString());
			objSB.AppendLine(")");

			return objSB.ToString();
		}

		private string GetFromTableName(string strSQL)
		{
			string[] arrFROM = strSQL.ToUpper().Split(new string[] { "FROM" }, StringSplitOptions.RemoveEmptyEntries);
			string[] arrTable = arrFROM[1].ToUpper().Split(new string[] { " ", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

			return arrTable[0];
		}

		public DataToSQL()
		{
			InitializeComponent();
		}

		private void DataDifferences_Load(object sender, EventArgs e)
		{
			if (this.LastConnectionString1 != null)
			{
				this.txtConnectionString1.Text = this.LastConnectionString1;
			}

			if (this.LastConnectionString2 != null)
			{
				this.txtConnectionString2.Text = this.LastConnectionString2;
			}

			if (this.LastSQL != null)
			{
				this.txtSQLSelect.Text = this.LastSQL;
			}
		}

		private void btnPreview_Click(object sender, EventArgs e)
		{
			GenerateResponse generateResponse = GetFromData();

			this.dataGridView1.DataSource = generateResponse.QueryResult;
			this.txtDataSQL.Text = generateResponse.SQL.ToString();
		}

		private void txtSQLSelect_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
				this.txtSQLSelect.SelectAll();
		}

		private void txtDataSQL_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
				this.txtDataSQL.SelectAll();
		}

		private void btnSaveSQL_Click(object sender, EventArgs e)
		{
			GenerateResponse generateResponse = GetFromData();

			using (SaveFileDialog dialog = new SaveFileDialog())
			{
				if (dialog.ShowDialog(this) == DialogResult.OK)
				{
					File.WriteAllText(dialog.FileName, generateResponse.SQL.ToString());
				}
			}
		}
	}
}