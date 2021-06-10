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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Principal.xaml
    /// </summary>
    /// 

    public partial class Principal : Window
    {

        ObservableCollection<DataPuesto> listaPuestos = new ObservableCollection<DataPuesto>();
            
        public Principal()
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

        // ===================  ADMIN PUESTO =============== //

        private void Editar_Puesto(object sender, RoutedEventArgs e)
        {
            AdminPuestosEdit AdminPuestosEditWindow = new AdminPuestosEdit(listaPuestos);

            AdminPuestosEditWindow.Show();
            this.Close();
        }

        private void Crear_Puesto(object sender, RoutedEventArgs e)
        {
        }

        private void Eliminar_Puesto(object sender, RoutedEventArgs e)
        {

        }

        // ===================  ADMIN USER =============== //

        private void Editar_Usuario(object sender, RoutedEventArgs e)
        {
        }

        private void Eliminar_Usuario(object sender, RoutedEventArgs e)
        {
        }


        private void Crear_Usuario(object sender, RoutedEventArgs e)
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
