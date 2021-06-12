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
    /// Lógica de interacción para Administrarusuarioseliminar.xaml
    /// </summary>
    public partial class Administrarusuarioseliminar : Window
    {
        ObservableCollection<DataPuesto> listaPuestosEliminar = new ObservableCollection<DataPuesto>();

        int index = 0;
        public Administrarusuarioseliminar(ObservableCollection<DataPuesto> listaPuestos)
        {

            InitializeComponent();
            listaPuestosEliminar = listaPuestos;

            ListBoxPuestos.ItemsSource = listaPuestosEliminar;
   

        }

        private void btnatras_Click(object sender, RoutedEventArgs e)
        {
            
        }
       
        private void btnatras_Click_1(object sender, RoutedEventArgs e)
        {
            AdminPuestoCrear Administrarusuarioseliminar = new AdminPuestoCrear();
            Administrarusuarioseliminar.Show();
            Close();
        }

        private void Elim_Puesto(object sender, RoutedEventArgs e)
        {
            if (ListBoxPuestos.SelectedItem != null)
            {
                index = ListBoxPuestos.SelectedIndex;
                listaPuestosEliminar.RemoveAt(index);
            }
            using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataPuesto.txt"))
            {

                foreach (DataPuesto item in listaPuestosEliminar)
                {
                    outputFile.WriteLine(item.id);
                    outputFile.WriteLine(item.estado);
                    outputFile.WriteLine(item.desc);
                    outputFile.WriteLine(item.dateInit);
                    outputFile.WriteLine(item.dateEnd);
                }
            }
        }
        private void btn_back(object sender, RoutedEventArgs e)
        {

        }

        private void seleccted_change(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPuestos.SelectedItem != null)
            {
                bool state = (ListBoxPuestos.SelectedItem as DataPuesto).estado;

                txtIdentificador.Text = (ListBoxPuestos.SelectedItem as DataPuesto).id;
                txtEstado.Text = Convert.ToString((ListBoxPuestos.SelectedItem as DataPuesto).estado);
                txtDescripcion.Text = (ListBoxPuestos.SelectedItem as DataPuesto).desc;
                txtFecha.Text = (ListBoxPuestos.SelectedItem as DataPuesto).dateInit;
                //status_update(state);
            }
        }

    }
}
