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



namespace WpfApp1
{
    /// ==================== COMO SACAR UN INDEX OF DE UNA LISTA MULTIDIMENSIONAL
    public partial class AdminPuestosEdit : Window
    {

        ObservableCollection<Puestos> listaPuestos = new ObservableCollection<Puestos>();
      
        int countPuesto = 0;

 


        public AdminPuestosEdit()
        {
            InitializeComponent();
           


            listaPuestos.Add(new Puestos() { id = "A-001", estado = false, desc = "Silla bonita", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new Puestos() { id = "A-002", estado = true, desc = "Silla verde", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new Puestos() { id = "A-003", estado = false, desc = "Silla roja", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new Puestos() { id = "A-004", estado = true, desc = "Silla cerca de la cafetera", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new Puestos() { id = "A-005", estado = false, desc = "Con vista bonita", dateInit = "s", dateEnd = "s" });

            //listaDePuestos.ItemsSource = listaPuestos;

            listaDePuestos.ItemsSource = listaPuestos;

            count_puestos();
        }

        // BOTON DE RETROCEDER
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Principal AdminPuestosEdit = new Principal();
            AdminPuestosEdit.Show();
            Close();
        }

       

        // EDITAR 
        private void Edit_Puesto(object sender, RoutedEventArgs e)
        {
            Administracion_crear_puesto AdminPuestosEdit = new Administracion_crear_puesto();
            AdminPuestosEdit.Show();
            this.Close();
        }

       

        private void seleccted_change(object sender, SelectionChangedEventArgs e)
        {

            count_puestos();

            if (listaDePuestos.SelectedItem != null)
            {
                PuestoId.Text = (listaDePuestos.SelectedItem as Puestos).id;
                PuestoState.Text = Convert.ToString((listaDePuestos.SelectedItem as Puestos).estado);
                PuestoDesc.Text = (listaDePuestos.SelectedItem as Puestos).desc; 
            }
        }

        public void count_puestos()
        {
            countPuesto = listaPuestos.Count;
            CountPuestos.Text = Convert.ToString(countPuesto);
        }

      

        private void PuestoId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    public class Puestos
    {
        public string id        { get; set; }
        public bool   estado    { get; set; }
        public string desc      { get; set; }
        public string dateInit  { get; set; }
        public string dateEnd   { get; set; }
    }


}
