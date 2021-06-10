using ExcelDataReader;
using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_try
{
    public partial class Formular_Import_OP : Form
    {
        public Formular_Import_OP()
        {
            InitializeComponent();
        }

        private void btnSaveToDB_OP_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My stuff\Licență\Baza de date\DateIncarcare.mdf;Integrated Security=True;Connect Timeout=30");

            for (int i = 0; i < dataGridViewOP.Rows.Count - 1; i++)
            {
                SqlCommand command = new SqlCommand(@"INSERT INTO DateFormIncarcare (nr, platiti, numarInCuvinte, plat, codPlat, adresaPlat, ibanPlat, bicPlat, deLa, angajament, indicator, codProgr, benef, codBenef, ibanBenef, bicBenef, la, nrEvid, reprez, dataEmit) VALUES('" + dataGridViewOP.Rows[i].Cells[0].Value + "','" + dataGridViewOP.Rows[i].Cells[1].Value + "','" + dataGridViewOP.Rows[i].Cells[2].Value + "','" + dataGridViewOP.Rows[i].Cells[3].Value + "','" + dataGridViewOP.Rows[i].Cells[4].Value + "','" + dataGridViewOP.Rows[i].Cells[5].Value + "','" + dataGridViewOP.Rows[i].Cells[6].Value + "','" + dataGridViewOP.Rows[i].Cells[7].Value + "','" + dataGridViewOP.Rows[i].Cells[8].Value + "','" + dataGridViewOP.Rows[i].Cells[9].Value + "','" + dataGridViewOP.Rows[i].Cells[10].Value + "','" + dataGridViewOP.Rows[i].Cells[11].Value + "','" + dataGridViewOP.Rows[i].Cells[12].Value + "','" + dataGridViewOP.Rows[i].Cells[13].Value + "','" + dataGridViewOP.Rows[i].Cells[14].Value + "','" + dataGridViewOP.Rows[i].Cells[15].Value + "','" + dataGridViewOP.Rows[i].Cells[16].Value + "','" + dataGridViewOP.Rows[i].Cells[17].Value + "','" + dataGridViewOP.Rows[i].Cells[18].Value + "','" + dataGridViewOP.Rows[i].Cells[19].Value + "')", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            Fereastra_Incarcare fereastra_Incarcare_OP = new Fereastra_Incarcare();
            fereastra_Incarcare_OP.Show();
            this.Close();
        }

        DataTableCollection tableCollection;
        private void cmbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = tableCollection[cmbSheet.SelectedItem.ToString()];
            dataGridViewOP.DataSource = dataTable;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFile = new OpenFileDialog() { Filter="Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    txtNumeFisier.Text = openFile.FileName;
                    using(var stream = File.Open(openFile.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable=(_)=> new ExcelDataTableConfiguration() { UseHeaderRow=true }
                            });

                            tableCollection = result.Tables;
                            cmbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cmbSheet.Items.Add(table.TableName);    //adaugare sheet la combobox
                        }
                    }
                }
            }
        }
    }
}
