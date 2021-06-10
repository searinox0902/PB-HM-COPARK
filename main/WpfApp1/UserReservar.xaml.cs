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
    /// Interaction logic for UserReservar.xaml
    /// </summary>
    public partial class UserReservar : Window
    {
        ObservableCollection<DataPuesto> listaPuestosReservar = new ObservableCollection<DataPuesto>();
        string date = "";
        int index = 0;

        public UserReservar(ObservableCollection<DataPuesto> listaPuestos)
        {
            InitializeComponent();
            listaPuestosReservar = listaPuestos;
            ListBoxPuestos.ItemsSource = listaPuestosReservar;
        }

        private void btn_Reservar(object sender, RoutedEventArgs e)
        {
            index = ListBoxPuestos.SelectedIndex;

            if (date != "" && date != null && ListBoxPuestos.SelectedItem != null)
            {
               
                if (listaPuestosReservar[index].estado == true)
                {
                    index = ListBoxPuestos.SelectedIndex;
                    listaPuestosReservar.RemoveAt(index);

                    listaPuestosReservar.Insert(index, new DataPuesto() { id = PuestoId.Text, estado = false, desc = PuestoDesc.Text, dateInit = date, dateEnd = date });

                    status_update(false);

                    MessageBox.Show("se ha reservado");
                   

                    // SE GUARDA LA LISTA EDITADA EN EL ARCHIVO PLANO
                    using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataPuesto.txt"))
                    {

                        foreach (DataPuesto item in listaPuestosReservar)
                        {
                            outputFile.WriteLine(item.id);
                            outputFile.WriteLine(item.estado);
                            outputFile.WriteLine(item.desc);
                            outputFile.WriteLine(item.dateInit);
                            outputFile.WriteLine(item.dateEnd);
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Este puesto ya se ha reservado");
                } 
            }
            else
            {
                MessageBox.Show("Seleccione un Puesto y una fecha de reserva");
            }
        }

     
        private void seleccted_change(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPuestos.SelectedItem != null)
            {
                bool state = (ListBoxPuestos.SelectedItem as DataPuesto).estado;
                PuestoState.Text = Convert.ToString(state);
                PuestoId.Text = (ListBoxPuestos.SelectedItem as DataPuesto).id;
                PuestoState.Text = Convert.ToString((ListBoxPuestos.SelectedItem as DataPuesto).estado);
                PuestoDesc.Text = (ListBoxPuestos.SelectedItem as DataPuesto).desc;

                status_update(state);
            }

        }

        public void status_update(bool state)
        {   
            
            if (state == false)
            {
                PuestoState.Text = "Reservado";
                PuestoState.Foreground = Brushes.Red;

            }
            else
            {
                PuestoState.Text = "Disponible";
                PuestoState.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF16C319"));
            }
        }


        private void selecteDate(object sender, SelectionChangedEventArgs e)
        {
            date = Convert.ToString(fechaReserva.SelectedDate.Value);
            fechaReservaText.Text = date;
        }



        private void btn_back(object sender, RoutedEventArgs e)
        {
            PrincipalUser principalUser = new PrincipalUser();
            principalUser.Show();
            this.Close();
        }

    }
}
