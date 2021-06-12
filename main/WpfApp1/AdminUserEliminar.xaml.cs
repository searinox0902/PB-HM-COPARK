using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
    /// Interaction logic for AdminUserEliminar.xaml
    /// </summary>
    public partial class AdminUserEliminar : Window
    {
        ObservableCollection<DataUser> ListaUsuarioEliminar = new ObservableCollection<DataUser>();
        int index = 0;
        public AdminUserEliminar(ObservableCollection<DataUser> ListaUsuario)
        {
            InitializeComponent();

            ListaUsuarioEliminar = ListaUsuario;
            ListBoxUser.ItemsSource = ListaUsuarioEliminar;
        }

        private void seleccted_change(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxUser.SelectedItem != null)
            {

                bool state = (ListBoxUser.SelectedItem as DataUser).State;
                txtName.Text = (ListBoxUser.SelectedItem as DataUser).Name;
                txtPass.Text = Convert.ToString((ListBoxUser.SelectedItem as DataUser).Pass);
                if(state == true)
                {
                    txtState.Text = "Activo";
                }
                else
                {
                    txtState.Text = "Bloqueado";
                }
              
            }
        }

        private void Elim_Puesto(object sender, RoutedEventArgs e)
        {
            if (ListBoxUser.SelectedItem != null)
            {
                index = ListBoxUser.SelectedIndex;
                ListaUsuarioEliminar.RemoveAt(index);
            }
            using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataUser.txt"))
            {

                foreach (DataUser item in ListaUsuarioEliminar)
                {
                    outputFile.WriteLine(item.Name);
                    outputFile.WriteLine(item.Pass);
                    outputFile.WriteLine(item.State);
                }
            }
        }

        private void btn_back(object sender, RoutedEventArgs e)
        {
            Principal ventanaprincipal = new Principal();
            ventanaprincipal.Show();
            this.Close();
        }
    }
}
