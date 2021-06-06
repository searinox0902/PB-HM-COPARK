using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;



namespace WpfApp1
{
    public partial class AdminPuestosEdit : Window
    {

        ObservableCollection<DataPuesto> listaPuestos = new ObservableCollection<DataPuesto>();
      
        int countPuesto = 0;
        int index = 0;
        bool state = false;

        public AdminPuestosEdit()
        {
            InitializeComponent();
           


            listaPuestos.Add(new DataPuesto() { id = "A-001", estado = false, desc = "Silla bonita", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new DataPuesto() { id = "A-002", estado = true, desc = "Silla verde", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new DataPuesto() { id = "A-003", estado = false, desc = "Silla roja", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new DataPuesto() { id = "A-004", estado = true, desc = "Silla cerca de la cafetera", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new DataPuesto() { id = "A-005", estado = false, desc = "Con vista bonita", dateInit = "s", dateEnd = "s" });


            ListBoxPuestos.ItemsSource = listaPuestos;

            count_puestos();
        }

        // BOTON DE RETROCEDER
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Principal ventanaprincipal = new Principal();
            ventanaprincipal.Show();
            this.Close();
        }


        // EDITAR 
        private void Edit_Puesto(object sender, RoutedEventArgs e)
        {

            if (ListBoxPuestos.SelectedItem != null)
            {
                index = ListBoxPuestos.SelectedIndex;
                listaPuestos.RemoveAt(index);
                listaPuestos.Insert(index, new DataPuesto() { id = PuestoId.Text, estado = state, desc = PuestoDesc.Text, dateInit = "s", dateEnd = "s" });
            }
        }

       

        private void seleccted_change(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPuestos.SelectedItem != null)
            {
                PuestoId.Text = (ListBoxPuestos.SelectedItem as DataPuesto).id;
                PuestoState.Text = Convert.ToString((ListBoxPuestos.SelectedItem as DataPuesto).estado);
                PuestoDesc.Text = (ListBoxPuestos.SelectedItem as DataPuesto).desc;

                 RadioButton_Insert();
            }


            count_puestos();
        }

        public void count_puestos()
        {
            countPuesto = listaPuestos.Count;
            CountPuestos.Text = Convert.ToString(countPuesto);
        }

      

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            state = Convert.ToBoolean(RadioTrue.IsChecked);
        }



        public void RadioButton_Insert()
        {
          

        }

 
    }

  


}
