using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.IO;


namespace WpfApp1
{
    
    public partial class AdminPuestosEdit : Window
    {
        ObservableCollection<DataPuesto> listaPuestosEdit = new ObservableCollection<DataPuesto>();


        int countPuesto = 0;
        int index = 0;
        bool state = false;

        // Aquí resivo la lista 
        public AdminPuestosEdit(ObservableCollection<DataPuesto> listaPuestos)
        {

            InitializeComponent();

            listaPuestosEdit = listaPuestos;

            ListBoxPuestos.ItemsSource = listaPuestosEdit;
            count_puestos();
        }


        // BOTON DE EDITAR EDITAR 
        public void Edit_Puesto(object sender, RoutedEventArgs e)
        {

            if (ListBoxPuestos.SelectedItem != null)
            {
                index = ListBoxPuestos.SelectedIndex;
                listaPuestosEdit.RemoveAt(index);
                listaPuestosEdit.Insert(index, new DataPuesto() { id = PuestoId.Text, estado = state, desc = PuestoDesc.Text, dateInit = "s", dateEnd = "s" });
            }

            // SE GUARDA LA LISTA EDITADA EN EL ARCHIVO PLANO
            using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataPuesto.txt"))
              {

                  foreach (DataPuesto item in listaPuestosEdit)
                  {
                      outputFile.WriteLine(item.id);
                      outputFile.WriteLine(item.estado);
                      outputFile.WriteLine(item.desc);
                      outputFile.WriteLine(item.dateInit);
                      outputFile.WriteLine(item.dateEnd);
                  }
              } 
        }


        private void seleccted_change(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPuestos.SelectedItem != null)
            {
                bool state = (ListBoxPuestos.SelectedItem as DataPuesto).estado;

                PuestoId.Text = (ListBoxPuestos.SelectedItem as DataPuesto).id;
                PuestoState.Text = Convert.ToString((ListBoxPuestos.SelectedItem as DataPuesto).estado);
                PuestoDesc.Text = (ListBoxPuestos.SelectedItem as DataPuesto).desc;
                status_update(state);
            }


            count_puestos();
        }

        public void count_puestos()
        {
          countPuesto = listaPuestosEdit.Count;
          CountPuestos.Text = Convert.ToString(countPuesto);
        }


        // metodo para guardar en una variable el estado del campo Radio (true or false) 

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            state = Convert.ToBoolean(RadioTrue.IsChecked);
        }

        // metodo para actualizar el Estado, cambia el texto a 'verdadero' o 'falso' y el color. 
        public void status_update(bool state)
        {
            if (state == false)
            {
                PuestoState.Text = "Inactivo";
                PuestoState.Foreground = Brushes.Red;

            }
            else if (state == true)
            {
                PuestoState.Text = "Activo";
                PuestoState.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2F70FE"));


            }
            else
            {
                PuestoState.Text = "Error";
            }
        }

        // BOTON DE RETROCEDER
        private void btn_back(object sender, RoutedEventArgs e)
        {
            Principal ventanaprincipal = new Principal();
            ventanaprincipal.Show();
            this.Close();
         
        }
    }
}
