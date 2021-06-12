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
    /// Interaction logic for AdminPuestoCrear.xaml
    /// </summary>
    public partial class AdminPuestoCrear : Window
    {
        bool estado;
        ObservableCollection<DataPuesto> listaPuestoscrear = new ObservableCollection<DataPuesto>();
        public AdminPuestoCrear(ObservableCollection<DataPuesto> listaPuestos)
        {
            InitializeComponent();
            listaPuestoscrear = listaPuestos;
        }

      

        private void btn_back()
        {
            Principal ventanaprincipal = new Principal();
            ventanaprincipal.Show();
            this.Close();
        }

        private void txtDato2_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btn_back(object sender, RoutedEventArgs e)
        {
            Principal ventanaprincipal = new Principal();
            ventanaprincipal.Show();
            this.Close();

        }

        private void crearpuesto(object sender, RoutedEventArgs e)
        {
            string id = txtidentificador.Text;
          
            listaPuestoscrear.Add( new DataPuesto() { id = id, estado = estado, desc = txtDescripcion.Text, dateInit = "00", dateEnd = "00" });
            using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataPuesto.txt"))
            {

                foreach (DataPuesto item in listaPuestoscrear)
                {
                    outputFile.WriteLine(item.id);
                    outputFile.WriteLine(item.estado);
                    outputFile.WriteLine(item.desc);
                    outputFile.WriteLine(item.dateInit);
                    outputFile.WriteLine(item.dateEnd);
                }
            }
            MessageBox.Show("PUESTO CREADO");
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

        private void true_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
