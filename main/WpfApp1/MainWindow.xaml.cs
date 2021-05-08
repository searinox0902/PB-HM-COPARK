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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> usuario = new List<string>();
        List<string> contrasena = new List<string>();
        int aux = 0;
       
        public MainWindow()
        {
            InitializeComponent();
            //asdasd
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            int i = 0, ban = 0;
            while (i < aux)
            {
                if (usuario[i] == txtUsuario.Text && contrasena[i] == txtContrasena.Text)
                {
                    Principal ventanaprincipal = new Principal(usuario[i]);
                    ventanaprincipal.Show();
                    this.Close();
                    ban = 1;
                }
                i++;
            }
            if (ban == 0)
            {
                MessageBox.Show("Dato no encontrado...");
            }
        }


        private void btnRegistrarse_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            for (i = 0; i <= aux; i++)
            {
                usuario.Add(txtUsuario.Text);
                contrasena.Add(txtContrasena.Text);
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
            aux = aux + 1;
            MessageBox.Show("Usuario registrado en la posicion: " + aux);
        }
    }
}
