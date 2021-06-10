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
        ObservableCollection    <DataPuesto>    listaPuestos      =   new ObservableCollection<DataPuesto>  ();
        ObservableCollection    <DataParking>   listaParking      =   new ObservableCollection<DataParking> ();
        ObservableCollection    <DataUser>      listaUser         =   new ObservableCollection<DataUser>    ();
       
        public PrincipalUser()
        {   
            InitializeComponent();

       
            // leer archivo plano dataPuesto    PUESTOS
            using (StreamReader inputFile = new StreamReader("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataPuesto.txt"))
            {
                while (inputFile.Peek() >= 0)
                {
                    listaPuestos.Add(new DataPuesto() { id = inputFile.ReadLine(), estado = Convert.ToBoolean(inputFile.ReadLine()), desc = inputFile.ReadLine(), dateInit = inputFile.ReadLine(), dateEnd = inputFile.ReadLine() });
                }
            }

            // leer archivo plano dataParking   PARQUEADERO
            using (StreamReader inputFile2 = new StreamReader("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataParking.txt"))
            {
                while (inputFile2.Peek() >= 0)
                {
                    string idPark;
                    bool statePark; string stateParkString;
                    string dateInitPark;

                    idPark = inputFile2.ReadLine();
                    stateParkString = inputFile2.ReadLine();
                        if(stateParkString == "False" || stateParkString == "false")
                        {
                            statePark = false;
                        }
                        else {
                            statePark = true;
                        }
                    dateInitPark = inputFile2.ReadLine();

                    listaParking.Add(new DataParking() { id = idPark, estado = statePark, dateInit = dateInitPark });
                }
            }

            // leer archivo plano dataUser      USUARIOS
            using (StreamReader inputFileUser = new StreamReader("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataUser.txt"))
            {
                while (inputFileUser.Peek() >= 0)
                {
                    listaUser.Add(new DataUser() { Name = inputFileUser.ReadLine(), Pass = inputFileUser.ReadLine(), State = Convert.ToBoolean(inputFileUser.ReadLine()) });
                }
            }
        }


        public void Reservar_Puesto(object sender, RoutedEventArgs e)
        {
           UserReservar userReservar = new UserReservar(listaPuestos);
           userReservar.Show();
           this.Close();
        }

        public void Reservar_Parqueadero(object sender, RoutedEventArgs e)
        {
            UserReservarParking userParking = new UserReservarParking(listaParking);
            userParking.Show();
            this.Close(); 
        }

        public void Editar_Usuario(object sender, RoutedEventArgs e)
        {
            /*
            UserEdit userEdit = new UserEdit(listaUser);
            userEdit.Show();
            this.Close();
            */
        }

        public void Btn_Back(object sender, RoutedEventArgs e)
        {
            MainWindow InicioSesion = new MainWindow();
            InicioSesion.Show();
            this.Close();
        }

    }
}
