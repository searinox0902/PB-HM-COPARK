﻿using System;
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
    /// Lógica de interacción para AdminUsuarioEdit.xaml
    /// </summary>
    public partial class AdminUsuarioEdit : Window
    {
        public AdminUsuarioEdit()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_back(object sender, RoutedEventArgs e)
        {
            Principal ventanaprincipal = new Principal();
            ventanaprincipal.Show();
            this.Close();
        }







    }
}