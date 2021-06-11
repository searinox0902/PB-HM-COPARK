using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para Administrarusuarioseliminar.xaml
    /// </summary>
    public partial class Administrarusuarioseliminar : Window
    {
        public Administrarusuarioseliminar(ObservableCollection<DataPuesto> listaPuestos)
        {

            InitializeComponent();

        }

        private void btnatras_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void btnatras_Click_1(object sender, RoutedEventArgs e)
        {
            AdminPuestoCrear Administrarusuarioseliminar = new AdminPuestoCrear();
            Administrarusuarioseliminar.Show();
            Close();
        }

        private void Edit_Puesto(object sender, RoutedEventArgs e)
        {

        }

        private void btn_back(object sender, RoutedEventArgs e)
        {

        }

        private void seleccted_change(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
