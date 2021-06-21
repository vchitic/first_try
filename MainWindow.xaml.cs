using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using System.Activities.Expressions;
using System.Data.SqlClient;

namespace first_try
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StergeClick(object sender, RoutedEventArgs e)
        {
            const string message = "Doriți să ștergeți toate OP/FV-urile?";
            const string caption = "Ștergere OP/FV-uri";
            MessageBoxResult result = MessageBox.Show(message, caption,
                                 MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My stuff\Licență\Baza de date\DateIncarcare.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand comm = new SqlCommand(@"DELETE FROM DateFormIncarcare", conn);
                SqlCommand comm2 = new SqlCommand(@"DELETE FROM DateFormIncarcareFV", conn);
                conn.Open();
                comm.ExecuteNonQuery();
                comm2.ExecuteNonQuery();
                if(comm.ExecuteNonQuery()!=-1 && comm2.ExecuteNonQuery()!=-1)
                {
                    const string mess = "Datele au fost șterse cu succes";
                    const string capt = "OP/FV-uri șterse";
                    MessageBoxButton boxButton = MessageBoxButton.OK;
                    MessageBoxImage boxImage = MessageBoxImage.Information;
                    MessageBox.Show(mess, capt, boxButton, boxImage);
                }
                conn.Close();
            }
        }

        private void LegislatieClick(object sender, RoutedEventArgs e)
        {
            
            Fereastra_Legislatie legislatie = new Fereastra_Legislatie();
            legislatie.Show();

        }

        private void Instruct_Click(System.Object sender, System.EventArgs e)
        {
            Fereastra_Instructiuni instructiuni = new Fereastra_Instructiuni();
            instructiuni.Show();

        }

        private void Qst_Click(object sender, RoutedEventArgs e)
        {
            string message = "Numărul de ordine se găsește în partea stângă sus a OP/FV-ului.\r\n" 
                +"Puteți reveni oricând pentru modificări de conținut dacă îl selectați din listă.\r\n"
                +"Pentru un OP/FV nou încărcat, nr. de ordine este egal cu numărul de OP/FV-uri încărcate plus unu.";
            string title = "Informații";
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ListarePachet_Click(object sender, RoutedEventArgs e)
        {

        }


        private void Formulare_Click(object sender, RoutedEventArgs e)
        {
           
            //printare formular gol

            /* PrintDialog print = new PrintDialog();
            if(print.ShowDialog()==true)
            {
                print.PrintVisual(Fereastra_Incarcare., "OP");
            }*/

            //să printeze formularul gol, n-am idee cum ajung la fereastra aia (Fereastra_Incarcare) 
            
        }

        
        private void Incarcare_Click(object sender, RoutedEventArgs e)
        {
            Fereastra_Tip_Completare_OP incarcare_completare_OP = new Fereastra_Tip_Completare_OP();
            Fereastra_Tip_Completare_FV incarcare_completare_FV = new Fereastra_Tip_Completare_FV();
            String nr_op_selectat, nr_fv_selectat;

            if ((bool)OPRadiobtn.IsChecked)
            {
                if (NrOrdCmbOP.SelectedIndex > -1)
                {
                    nr_op_selectat = NrOrdCmbOP.SelectedItem.ToString();
                    Fereastra_Incarcare fereastra_Incarcare = new Fereastra_Incarcare();
                    fereastra_Incarcare.Show();
                    while (fereastra_Incarcare.txtNr.Text != nr_op_selectat)
                    {
                        fereastra_Incarcare.click_btn_next(sender, e);
                    }

                    //fereastra_Incarcare.printare(sender, e);
                }
                else
                {
                    incarcare_completare_OP.Show();
                }
            }
            else
            {
                if(NrOrdCmb.SelectedIndex > -1)
                {
                    nr_fv_selectat = NrOrdCmb.SelectedItem.ToString();
                    Fereastra_Incarcare_FV fereastra_Incarcare_FV = new Fereastra_Incarcare_FV();
                    fereastra_Incarcare_FV.Show();
                    while(fereastra_Incarcare_FV.txtNr.Text != nr_fv_selectat)
                    {
                        fereastra_Incarcare_FV.click_btn_next(sender, e);
                    }
                }
                else
                {
                    incarcare_completare_FV.Show();
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NrOrdCmb_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My stuff\Licență\Baza de date\DateIncarcare.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand(@"SELECT nr FROM DateFormIncarcareFV", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                NrOrdCmb.Items.Add(reader[0]).ToString();
            }

            connection.Close();
        }

        private void NrOrdCmbOP_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My stuff\Licență\Baza de date\DateIncarcare.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand command = new SqlCommand(@"SELECT nr FROM DateFormIncarcare", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                NrOrdCmbOP.Items.Add(reader[0]).ToString();
            }

            connection.Close();
        }

        private void ListareButton_Click(object sender, RoutedEventArgs e)
        {
            String nr_op_selectat, nr_fv_selectat;

            if ((bool)OPRadiobtn.IsChecked)
            {
                if (NrOrdCmbOP.SelectedIndex > -1)
                {
                    nr_op_selectat = NrOrdCmbOP.SelectedItem.ToString();
                    Fereastra_Incarcare fereastra_Incarcare = new Fereastra_Incarcare();
                   // fereastra_Incarcare.Show().;
                    while (fereastra_Incarcare.txtNr.Text != nr_op_selectat)
                    {
                        fereastra_Incarcare.click_btn_next(sender, e);
                    }

                    fereastra_Incarcare.printare(sender, e);
                }
                else
                {
                    MessageBox.Show("Alegeți un OP din listă");
                }
            }
            else
            {
                if (NrOrdCmb.SelectedIndex > -1)
                {
                    nr_fv_selectat = NrOrdCmb.SelectedItem.ToString();
                    Fereastra_Incarcare_FV fereastra_Incarcare_FV = new Fereastra_Incarcare_FV();
                    //fereastra_Incarcare_FV.Show();
                    while (fereastra_Incarcare_FV.txtNr.Text != nr_fv_selectat)
                    {
                        fereastra_Incarcare_FV.click_btn_next(sender, e);
                    }

                    fereastra_Incarcare_FV.printare(sender, e);
                }
                else
                {
                    MessageBox.Show("Alegeți un FV din listă");
                }
            }
        }
    }
}
