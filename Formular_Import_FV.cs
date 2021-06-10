using Spire.Xls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_try
{
    public partial class Formular_Import_FV : Form
    {
        public Formular_Import_FV()
        {
            InitializeComponent();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            Workbook workbook = new Workbook();
            workbook.LoadFromFile(@"");
            Worksheet sheet = workbook.Worksheets[0];
            this.dataGridViewFV.DataSource = sheet.ExportDataTable();
        }

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My stuff\Licență\Baza de date\DateIncarcare.mdf;Integrated Security=True;Connect Timeout=30");

            for(int i=0; i< dataGridViewFV.Rows.Count-1; i++)
            {
                SqlCommand command = new SqlCommand(@"INSERT INTO DateFormIncarcare (Id, nr, platiti, numarInCuvinte, plat, codPlat, adresaPlat, ibanPlat, bicPlat, deLa, angajament, indicator, codProgr, benef, codBenef, ibanBenef, bicBenef, la, nrEvid, reprez, dataEmit) VALUES('"+ dataGridViewFV.Rows[i].Cells[0].Value + "','" + dataGridViewFV.Rows[i].Cells[1].Value + "','" + dataGridViewFV.Rows[i].Cells[2].Value + "','" + dataGridViewFV.Rows[i].Cells[3].Value + "','" + dataGridViewFV.Rows[i].Cells[4].Value + "','" + dataGridViewFV.Rows[i].Cells[5].Value + "','" + dataGridViewFV.Rows[i].Cells[6].Value + "','" + dataGridViewFV.Rows[i].Cells[7].Value + "','" + dataGridViewFV.Rows[i].Cells[8].Value + "','" + dataGridViewFV.Rows[i].Cells[9].Value + "','" + dataGridViewFV.Rows[i].Cells[10].Value + "','" + dataGridViewFV.Rows[i].Cells[11].Value + "','" + dataGridViewFV.Rows[i].Cells[12].Value + "','" + dataGridViewFV.Rows[i].Cells[13].Value + "','" + dataGridViewFV.Rows[i].Cells[14].Value + "','" + dataGridViewFV.Rows[i].Cells[15].Value + "','" + dataGridViewFV.Rows[i].Cells[16].Value + "','" + dataGridViewFV.Rows[i].Cells[17].Value + "','" + dataGridViewFV.Rows[i].Cells[18].Value + "','" + dataGridViewFV.Rows[i].Cells[19].Value + "','" + dataGridViewFV.Rows[i].Cells[20].Value + "')", connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            Fereastra_Incarcare_FV fereastra_Incarcare_FV = new Fereastra_Incarcare_FV();
            fereastra_Incarcare_FV.Show();
            this.Close();
        }
    }
}
