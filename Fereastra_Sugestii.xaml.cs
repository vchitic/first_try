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
    /// Interaction logic for Fereastra_Sugestii.xaml
    /// </summary>
    public partial class Fereastra_Sugestii : Window
    {
        public Fereastra_Sugestii()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtCoduri.Text = Setari.Default.Setting;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Setari.Default.Save();
        }

        private void txtCoduri_TextChanged(object sender, TextChangedEventArgs e)
        {
            Setari.Default.Setting = txtCoduri.Text;
        }
    }
}
