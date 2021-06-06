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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AdminPuestoCrear.xaml
    /// </summary>
    public partial class AdminPuestoCrear : Window
    {
        public AdminPuestoCrear()
        {
            InitializeComponent();
        }

      

        private void btn_back()
        {
            Principal ventanaprincipal = new Principal();
            ventanaprincipal.Show();
            this.Close();
        }

        private void txtDato2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDato1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDato3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_back(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
