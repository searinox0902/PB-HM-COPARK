using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Administracion_crear_puesto.xaml
    /// </summary>
    public partial class Administracion_crear_puesto : Window
    {
        List<string> dato = new List<string>();
        

        public Administracion_crear_puesto()
        {
            InitializeComponent();
        }


        private void seleccted_change(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminPuestosEdit Administracion_crear_puesto = new AdminPuestosEdit();
            Administracion_crear_puesto.Show();
            this.Close();

        }

        private void Button_Click_1()
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Administrarusuarioseliminar Administracion_crear_puesto = new Administrarusuarioseliminar
            Administracion_crear_puesto.Show();
                               Close();

            foreach (String item in dato)
            {
                
            }

            this.Close();
        }

        private void txtDato1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lbxidentificar_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
