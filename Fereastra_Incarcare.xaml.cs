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
using System.Windows.Shapes;

namespace first_try
{
    /// <summary>
    /// Interaction logic for Fereastra_Incarcare.xaml
    /// </summary>
    public partial class Fereastra_Incarcare : Window
    {
        public Fereastra_Incarcare()
        {
            InitializeComponent();
        }

        private void LegislatieClick(object sender, RoutedEventArgs e)
        {
            //deschide in notepad legistalia
            //Process.Start("notepad.exe", "D:\\My stuff\\Licență\\legi.txt");
            
            Fereastra_Legislatie legislatie = new Fereastra_Legislatie();
            legislatie.Show();
        }

        private void InstrClick(object sender, RoutedEventArgs e)
        {
            Fereastra_Instructiuni instructiuni = new Fereastra_Instructiuni();
            instructiuni.Show();
        }

        private void InfUtile(object sender, RoutedEventArgs e)
        {
            Fereastra_InfUtile infUtile = new Fereastra_InfUtile();
            infUtile.Show();
        }

        private void SugestiiClick(object sender, RoutedEventArgs e)
        {
            Fereastra_Sugestii sugestii = new Fereastra_Sugestii();
            sugestii.Show();
        }

        private void FisierDateClick(object sender, RoutedEventArgs e)
        {

        }

        private void FondMediuClick(object sender, RoutedEventArgs e)
        {
            //completare câmpuri BENEFICIAR
        }

        private void OPFVtextClick(object sender, RoutedEventArgs e)
        {
            //LOPFV.txt
        }

        private void SalvareClick(object sender, RoutedEventArgs e)
        {
            //salvare în bd
        }

        private void ExportareClick(object sender, RoutedEventArgs e)
        {
            //exportare ca PDF
        }
    }
}
