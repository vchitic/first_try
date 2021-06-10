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
    /// Interaction logic for Fereastra_Tip_Completare_OP.xaml
    /// </summary>
    public partial class Fereastra_Tip_Completare_OP : Window
    {
        public Fereastra_Tip_Completare_OP()
        {
            InitializeComponent();
        }

        private void btnComplManOP_Click(object sender, RoutedEventArgs e)
        {
            Fereastra_Incarcare incarcare_OP = new Fereastra_Incarcare();
            incarcare_OP.Show();
            this.Close();
        }

        private void btnComplAutOP_Click(object sender, RoutedEventArgs e)
        {
            Formular_Import_OP formular_Import_OP = new Formular_Import_OP();
            formular_Import_OP.Show();
            this.Close();
        }
    }
}
