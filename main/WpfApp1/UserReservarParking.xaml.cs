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
    /// Interaction logic for UserReservarParking.xaml
    /// </summary>
    public partial class UserReservarParking : Window
    {
        ObservableCollection<DataParking> ListaUserParking = new ObservableCollection<DataParking>();

        string date = "";
        int index = 0;

        public UserReservarParking(ObservableCollection<DataParking> listaParking)
        {
            InitializeComponent();
            ListaUserParking = listaParking;

            ListBoxPark.ItemsSource = ListaUserParking;
        }

        private void btn_Reservar(object sender, RoutedEventArgs e)
        {

            index = ListBoxPark.SelectedIndex;

            if (date != "" && date != null && ListBoxPark.SelectedItem != null)
            {

                if (ListaUserParking[index].estado == true)
                {
                    index = ListBoxPark.SelectedIndex;
                    ListaUserParking.RemoveAt(index);

                    ListaUserParking.Insert(index, new DataParking() { id = ParkId.Text, estado = false, dateInit = date });

                    status_update(false);

                    MessageBox.Show("se ha reservado");


                    // SE GUARDA LA LISTA EDITADA EN EL ARCHIVO PLANO
                    using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataParking.txt"))
                    {

                        foreach (DataParking item in ListaUserParking)
                        {
                            outputFile.WriteLine(item.id);
                            outputFile.WriteLine(item.estado);
                            outputFile.WriteLine(item.dateInit);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Este lugar de parqueadero ya se ha reservado");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un lugar de parqueadero y una fecha de reserva");
            }
        }



        private void seleccted_change(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPark.SelectedItem != null)
            {
                ParkId.Text = (ListBoxPark.SelectedItem as DataParking).id;
                bool state = (ListBoxPark.SelectedItem as DataParking).estado;
                ParkState.Text = Convert.ToString(state);
                ParkDate.Text = Convert.ToString((ListBoxPark.SelectedItem as DataParking).dateInit);


                status_update(state);
            }
        }


        private void selecteDate(object sender, SelectionChangedEventArgs e)
        {
            date = Convert.ToString(fechaReserva.SelectedDate.Value);
            ParkDate.Text = date;
        }

        public void status_update(bool state)
        {
            if (state == false)
            {
                ParkState.Text = "Inactivo";
                ParkState.Foreground = Brushes.Red;

            }
            else if (state == true)
            {
                ParkState.Text = "Activo";
                ParkState.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF2F70FE"));
            }
        }

        private void btn_back(object sender, RoutedEventArgs e)
        {
            PrincipalUser principalUser = new PrincipalUser();
            principalUser.Show();
            this.Close();

        }
    }
}
