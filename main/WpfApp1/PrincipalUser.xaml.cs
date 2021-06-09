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
using System.IO;

namespace WpfApp1
{
  
    public partial class PrincipalUser : Window
    {
        List<DataUser> listaUsuarios = new List<DataUser>();

        public PrincipalUser()
        {
            InitializeComponent();

            //Leemos todos los Usuarios del arhivo plano
            using (StreamReader inputFile = new StreamReader("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataUser.txt"))
            {
                int i = 0;

                while (inputFile.Peek() >= 0)
                {
                    listaUsuarios.Add(new DataUser() { Name = inputFile.ReadLine(), Pass = inputFile.ReadLine(), State = Convert.ToBoolean(inputFile.ReadLine()) });
                    i++;
                }
            }
        }

      
        private void Reservar_Puesto(object sender, RoutedEventArgs e)
        {

        }

        private void Reservar_Parqueadero(object sender, RoutedEventArgs e)
        {

        }

        private void Editar_Usuario(object sender, RoutedEventArgs e)
        {

        }



        private void Btn_Back(object sender, RoutedEventArgs e)
        {
            MainWindow InicioSesion = new MainWindow();
            InicioSesion.Show();
            this.Close();
        }

    }
}
