﻿using System;
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

          

          // leer id
            using (StreamReader inputFile = new StreamReader("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataPuesto.txt"))
            {
              

                while(inputFile.Peek() >= 0)
                {   
           
                    listaPuestos.Add(new DataPuesto() { id = inputFile.ReadLine(), estado = Convert.ToBoolean(inputFile.ReadLine()), desc = inputFile.ReadLine(), dateInit = inputFile.ReadLine(), dateEnd = inputFile.ReadLine() });

                }
                // listaPuestos.Add(new DataPuesto() { id = "pedro", estado = false, desc = "System.IO", dateInit = "s", dateEnd = "s" });

            }
          
          // escribir id
          /* 
           using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataPuesto.txt"))
            {

                foreach (DataPuesto item in listaPuestos)
                {
                    outputFile.WriteLine(item.id);
                    outputFile.WriteLine(item.estado);
                    outputFile.WriteLine(item.desc);
                    outputFile.WriteLine(item.dateInit);
                    outputFile.WriteLine(item.dateEnd);
                }
            } */

        }


        private void Editar_Puesto(object sender, RoutedEventArgs e)
        {
            AdminPuestosEdit AdminPuestosEditWindow = new AdminPuestosEdit(listaPuestos);

            AdminPuestosEditWindow.Show();
            this.Close();
        }

        private void Crear_Puesto(object sender, RoutedEventArgs e)
        {
            AdminPuestoCrear AdminPuestoCrear = new AdminPuestoCrear();
            AdminPuestoCrear.Show();
            this.Close();

        }

        private void Eliminar_Puesto(object sender, RoutedEventArgs e)
        {

        }

        // ===================  ADMIN USER =============== //

        private void Editar_Usuario(object sender, RoutedEventArgs e)
        {

            AdminUsuarioEdit AdminUsuarioEdit = new AdminUsuarioEdit();
            AdminUsuarioEdit.Show();
            this.Close();
        }

        private void Eliminar_Usuario(object sender, RoutedEventArgs e)
        {
        }


        private void Crear_Usuario(object sender, RoutedEventArgs e)
        {
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
        }

        public void agg_puestos_quemados()
        {

            listaPuestos.Add(new DataPuesto() { id = "A-001", estado = false, desc = "Silla bonita", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new DataPuesto() { id = "A-002", estado = true, desc = "Silla verde", dateInit = "s", dateEnd = "s" });
            listaPuestos.Add(new DataPuesto() { id = "A-003", estado = false, desc = "Silla roja", dateInit = "s", dateEnd = "s" });
        }
    }
}
