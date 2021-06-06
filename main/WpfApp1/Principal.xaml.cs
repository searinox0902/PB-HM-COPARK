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
    /// Interaction logic for Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }


        private void Editar_Puesto(object sender, RoutedEventArgs e)
        {
            AdminPuestosEdit AdminPuestosEditWindow = new AdminPuestosEdit();
            AdminPuestosEditWindow.Show();
            this.Close();
        }

        private void Crear_Puesto(object sender, RoutedEventArgs e)
        {
            AdminPuestoCrear AdminPuestoCrear = new AdminPuestoCrear();
            AdminPuestoCrear.Show();
            this.Close();

        }

        private void Eliminar_Puesto(object sender, RoutedEventArgs e)
        {

        }

        // ===================  ADMIN USER =============== //

        private void Editar_Usuario(object sender, RoutedEventArgs e)
        {

            AdminUsuarioEdit AdminUsuarioEdit = new AdminUsuarioEdit();
            AdminUsuarioEdit.Show();
            this.Close();
        }

        private void Eliminar_Usuario(object sender, RoutedEventArgs e)
        {
        }


        private void Crear_Usuario(object sender, RoutedEventArgs e)
        {
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
        }
    }
}
