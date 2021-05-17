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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AdminPuestosEdit.xaml
    /// </summary>
    public partial class AdminPuestosEdit : Window
    {
        public AdminPuestosEdit()
        {
            InitializeComponent();

            List<Puestos> listaPuestos = new List<Puestos>();

            listaPuestos.Add(new Puestos() { id = "A-001", estado = false, desc = "Silla bonita", dateInit = "s", dateEnd = "s"});
            listaPuestos.Add(new Puestos() { id = "A-002", estado = true, desc = "Silla verde", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new Puestos() { id = "A-003", estado = false, desc = "Silla roja", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new Puestos() { id = "A-004", estado = true, desc = "Silla cerca de la cafetera", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new Puestos() { id = "A-005", estado = false, desc = "Con vista bonita", dateInit = "s", dateEnd = "s" });


            listaDePuestos.ItemsSource = listaPuestos;




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

    

        private void listaDePuestos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // this.listaDePuestos.ItemsSource = 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            if(listaDePuestos.SelectedItem != null)
            {
                MessageBox.Show((listaDePuestos.SelectedItem as Puestos).id);

                //listaDePuestos.ItemsSource = listaPuestos;
               
            }
      
        }

        private void seleccted_change(object sender, SelectionChangedEventArgs e)
        {
            if (listaDePuestos.SelectedItem != null)
            {
              //  MessageBox.Show((listaDePuestos.SelectedItem as Puestos).id);
                PuestoId.Text = (listaDePuestos.SelectedItem as Puestos).id;
                PuestoState.Text = Convert.ToString((listaDePuestos.SelectedItem as Puestos).estado);
                PuestoDesc.Text = (listaDePuestos.SelectedItem as Puestos).desc;
                //listaDePuestos.ItemsSource = listaPuestos;

            }
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
