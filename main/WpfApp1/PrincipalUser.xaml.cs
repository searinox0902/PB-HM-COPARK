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
using System.Collections.ObjectModel;

namespace WpfApp1
{
  
    public partial class PrincipalUser : Window
    {
        ObservableCollection<DataPuesto> listaPuestos = new ObservableCollection<DataPuesto>();

        public PrincipalUser()
        {
            InitializeComponent();

       
            // leer archivo plano dataPuesto
            using (StreamReader inputFile = new StreamReader("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataPuesto.txt"))
            {

                while (inputFile.Peek() >= 0)
                {
                    listaPuestos.Add(new DataPuesto() { id = inputFile.ReadLine(), estado = Convert.ToBoolean(inputFile.ReadLine()), desc = inputFile.ReadLine(), dateInit = inputFile.ReadLine(), dateEnd = inputFile.ReadLine() });
                }
            }
        }


        private void Reservar_Puesto(object sender, RoutedEventArgs e)
        {
            UserReservar userReservar = new UserReservar(listaPuestos);
            userReservar.Show();
            this.Close();
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
