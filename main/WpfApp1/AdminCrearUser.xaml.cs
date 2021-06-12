using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
    /// Interaction logic for AdminCrearUser.xaml
    /// </summary>
    public partial class AdminCrearUser : Window
    {
        ObservableCollection<DataUser> listaUserCrear = new ObservableCollection<DataUser>();
        string name;
        string pass;
        bool estado = true;

        public AdminCrearUser(ObservableCollection<DataUser> listaUser)
        {
            InitializeComponent();
            listaUserCrear = listaUser;
        }

        private void btn_back(object sender, RoutedEventArgs e)
        {
            Principal ventanaprincipal = new Principal();
            ventanaprincipal.Show();
            this.Close();
        }

        private void crearUser(object sender, RoutedEventArgs e)
        {
            name = txtName.Text;
            pass = txtPass.Text;

            listaUserCrear.Add(new DataUser() { Name = name, Pass = pass, State = estado});
            using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataUser.txt"))
            {

                foreach (DataUser item in listaUserCrear)
                {
                    outputFile.WriteLine(item.Name);
                    outputFile.WriteLine(item.Pass);
                    outputFile.WriteLine(item.State);
                }
            }
            MessageBox.Show("Usuario Creado");

            estado = true;
        }

        private void txtDato1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Radio_Checked(object sender, RoutedEventArgs e)
        {

            if (Radiotrue.IsChecked == true)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
        }
    }
}
