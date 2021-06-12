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
    /// Interaction logic for UserEdit.xaml
    /// </summary>
    public partial class UserEdit : Window
    {
        ObservableCollection<DataUser> ListaUserEdit = new ObservableCollection<DataUser>();

        public UserEdit(ObservableCollection<DataUser> ListaUser)
        {
            InitializeComponent();
            ListaUserEdit = ListaUser;
        }


        private void btn_editar(object sender, RoutedEventArgs e)
        {
            int i = 0, aux = ListaUserEdit.Count, ban = 0;

            string username = "";
            string pass = "";
            bool state;

            while (i < aux)
            {
                if (ListaUserEdit[i].Name == txtUsuario.Text && ListaUserEdit[i].Pass == txtContrasena.Text)
                {

                    if (
                        (txtNewName.Text != "" && txtNewName != null) &&
                        (txtNewPass.Text != "" && txtNewPass.Text != null) &&
                        (txtNewPassConfirm.Text != "" && txtNewPassConfirm.Text != null) &&
                        (txtNewPass.Text == txtNewPassConfirm.Text)
                       )
                    {
                        MessageBox.Show("Se ha Editado el Usuario");

                        username = txtNewName.Text;
                        pass = txtNewPass.Text;
                        state = ListaUserEdit[i].State;

                        ListaUserEdit.RemoveAt(i);
                        ListaUserEdit.Insert(i, new DataUser() { Name = username, State = state, Pass = pass });

                        //GUARDAMOS LA EDICION DEL USUARIO

                        using (StreamWriter outputFile = new StreamWriter("C:\\proyectos\\PB-HM-COPARK\\datafiles\\dataUser.txt"))
                        {
                            foreach (DataUser item in ListaUserEdit)
                            {
                                outputFile.WriteLine(item.Name);
                                outputFile.WriteLine(item.Pass);
                                outputFile.WriteLine(Convert.ToString(item.State));
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Datos incompletos o no Confirmados");
                    }


                    i = aux;


                }
                else if (i == aux)
                {

                    MessageBox.Show("Credenciales Incorrectas, No puede editar este usuario");
                }
                else
                {
                    MessageBox.Show("Ingrese datos en los campos");
                    i = aux;
                }


                i++;
            }
        }

        private void btn_back(object sender, RoutedEventArgs e)
        {
            Principal ventanaprincipal = new Principal();
            ventanaprincipal.Show();
            this.Close();

        }

        private void txtDato1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDato2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtDato_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
