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
    /// Interaction logic for Fereastra_Tip_Completare_FV.xaml
    /// </summary>
    public partial class Fereastra_Tip_Completare_FV : Window
    {
        public Fereastra_Tip_Completare_FV()
        {
            InitializeComponent();
        }

        private void btnComplManFV_Click(object sender, RoutedEventArgs e)
        {
            Fereastra_Incarcare_FV incarcare_FV = new Fereastra_Incarcare_FV();
            incarcare_FV.Show();
            this.Close();
        }

        private void btnComplAutFV_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
