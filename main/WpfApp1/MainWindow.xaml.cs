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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        //List<string> usuario = new List<string>();
        //List<string> contrasena = new List<string>();

        List<DataUser> listaUsuarios = new List<DataUser>();

        int aux = 0;
       
        public MainWindow()
        {
            InitializeComponent();

           
            string name     = "";
            string pass     = "";
            string estado   = "";
            

            listaUsuarios.Add(new DataUser() { Name =  "sebastian", Pass = "1234", State = false });
            listaUsuarios.Add(new DataUser() { Name = "juan", Pass = "1234", State = false });

            // escribir usuario
            using (StreamWriter inputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataPuesto.txt"))
            {
                foreach (DataUser item in listaUsuarios)
                {
                    inputFile.WriteLine(item.Name);
                    inputFile.WriteLine(item.Pass);
                    inputFile.WriteLine(item.State);
                }
            }


            //Leemos todos los Usuarios del arhivo plano
            using (StreamReader inputFile = new StreamReader("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataPuesto.txt"))
            {   
                while (inputFile.Peek() >= 0)
                {
                    name    = inputFile.ReadLine();
                    pass    = inputFile.ReadLine();
                    estado  = inputFile.ReadLine();
                   
                    listaUsuarios.Add(new DataUser() { Name = inputFile.ReadLine(), Pass = inputFile.ReadLine(), State = Convert.ToBoolean(estado)});
                } 
            }

            MessageBox.Show(Convert.ToString(listaUsuarios.Count));
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            int i = 0, aux = listaUsuarios.Count, ban = 0;
            while (i < aux)
            {
            
                if (listaUsuarios[i].Name == txtUsuario.Text && listaUsuarios[i].Pass == txtContrasena.Text)
                {
                    Principal ventanaprincipal = new Principal();
                   // ventanaprincipal.Show();
                   // this.Close();
                    ban = 1;
                    MessageBox.Show("El usuario Existe...");
                }
                else if ("admin" == txtUsuario.Text && "admin" == txtContrasena.Text)
                {
                    Principal ventanaprincipal = new Principal();
                    ventanaprincipal.Show();
                    this.Close();
                    ban = 1;
                }
                i++;
            }
            if (ban == 0)
            {
              MessageBox.Show("Usuario no Registrado...");
            }
        }


        private void btnRegistrarse_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            for (i = 0; i <= aux; i++)
            {
                listaUsuarios.Add(new DataUser() { Name = txtUsuario.Text, Pass = txtContrasena.Text, State = true });
            }
            aux = aux + 1;

            if(txtUsuario.Text == "" || txtUsuario.Text == null ){
                MessageBox.Show("Ingrese correctaente los datos");
            }
            else
            {
                //guardamos los datos del usuario registrado en el archivo plano
                using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataUser.txt"))
                {
                    foreach (DataUser item in listaUsuarios)
                    {
                        outputFile.WriteLine(item.Name);
                        outputFile.WriteLine(item.Pass);
                        outputFile.WriteLine(item.Pass);
                    }
                }
            }
        
 
        }
    }
}
