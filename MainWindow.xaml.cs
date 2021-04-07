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
                //Sterge toate OP/FV-urile
                string[] filePaths = Directory.GetFiles(@""); //folderul unde sunt stocate
                foreach (string filePath in filePaths)
                    File.Delete(filePath);
            }
        }

        private void LegislatieClick(object sender, RoutedEventArgs e)
        {
            //deschide in notepad legistalia
            //Process.Start("notepad.exe", "D:\\My stuff\\Licență\\legi.txt");

            Fereastra_Legislatie legislatie = new Fereastra_Legislatie();
            legislatie.Show();

        }

        private void Instruct_Click(System.Object sender, System.EventArgs e)
        {
            Fereastra_Instructiuni instructiuni = new Fereastra_Instructiuni();
            instructiuni.Show();

        }

        private void Structuri_Click(object sender, RoutedEventArgs e)
        {
            Fereastra_Structuri structuri = new Fereastra_Structuri();
            structuri.Show();
        }

        private void Qst_Click(object sender, RoutedEventArgs e)
        {
            string message = "Numărul de ordine se găsește în partea stângă jos a OP/FV-ului listat, între paranteze.\r\n" 
                +"Puteți reveni oricând pentru modificări de conținut dacă introduceți nr. de ordine sau dacă îl selectați din listă.\r\n"
                +"Pentru un OP/FV nou încărcat, nr. de ordine este egal cu numărul de OP/FV-uri încărcate plus unu.";
            string title = "Informații";
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ListarePachet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Borderou1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Borderou2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Formulare_Click(object sender, RoutedEventArgs e)
        {

        }

        
        private void Incarcare_Click(object sender, RoutedEventArgs e)
        {
            Fereastra_Incarcare incarcare = new Fereastra_Incarcare();
            Fereastra_Incarcare_FV incarcare_FV = new Fereastra_Incarcare_FV();
            if ((bool)OPRadiobtn.IsChecked)
            {
                incarcare.Show();

            } else
            {
                incarcare_FV.Show();
            }

        }
    }
}
