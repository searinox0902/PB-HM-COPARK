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
    /// Lógica de interacción para administracionpuesto.xaml
    /// </summary>
    public partial class administracionpuesto : Window
    {
        public administracionpuesto()
        {
            InitializeComponent();
        }

        private void btnatras_Click(object sender, RoutedEventArgs e)
        {
            Administracion_crear_puesto administracionpuesto = new Administracion_crear_puesto();
            administracionpuesto.Show();
            this.Close();
        }
    }
}
