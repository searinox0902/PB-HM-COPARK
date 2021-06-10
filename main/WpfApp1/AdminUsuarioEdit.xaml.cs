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
    /// Lógica de interacción para AdminUsuarioEdit.xaml
    /// </summary>
    public partial class AdminUsuarioEdit : Window
    {
        ObservableCollection<DataUser> Lista_User = new ObservableCollection<DataUser>();

        bool estado = false;
        int index = 0;
        int Count = 0;
        
        //Se recibe la lista
        public AdminUsuarioEdit(ObservableCollection<DataUser> Usuarios)
        {
            InitializeComponent();
            Lista_User = Usuarios;
            listDeUsuarios.ItemsSource = Lista_User;
            Contador();
        }
        
        //Contador de usuarios
        public void Contador()
        {
            Count = Lista_User.Count;
            CountUsuarios.Text = Convert.ToString(Count);
        }

        //Radibutton que define el estado de la cuenta de usuario
        private void RadioActive_Checked(object sender, RoutedEventArgs e)
        {
            estado = Convert.ToBoolean(RadioActive.IsChecked);
        }
        
        //Boton de Editar
        private void Button_Editar_Click(object sender, RoutedEventArgs e)
        {
            if (listDeUsuarios.SelectedItem != null)
            {
                index = listDeUsuarios.SelectedIndex;
                Lista_User.RemoveAt(index);
                Lista_User.Insert(index, new DataUser() { Name = Nombre_us.Text, Pass = Contrasena_us.Text, State = estado });
            }
            MessageBox.Show("El usuario ha sido editado ");

            //Guarda lista actulizada en el archivo plano 
            using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataUser.txt"))
            {
                foreach (DataUser item in Lista_User)
                {
                    outputFile.WriteLine(item.Name);
                    outputFile.WriteLine(item.Pass);
                    outputFile.WriteLine(item.State);
                }
            }
        }

        //Boton de Atras
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Principal ventanaprincipal = new Principal();
            ventanaprincipal.Show();
            this.Close();
        }
    }
}
