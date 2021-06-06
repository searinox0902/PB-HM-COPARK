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
        public  Principal()
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AdminPuestosEdit AdminPuestosEditWindow = new AdminPuestosEdit();

            AdminPuestosEditWindow.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow AdminPuestosEdit = new MainWindow();
            AdminPuestosEdit.Show();
            this.Close();
        }

        private void EditarUsuario(object sender, RoutedEventArgs e)
        {
            AdminUsuarioEdit AdminUsuarioEdit = new AdminUsuarioEdit();
            AdminUsuarioEdit.Show();
            this.Close();
        }
    }
}
