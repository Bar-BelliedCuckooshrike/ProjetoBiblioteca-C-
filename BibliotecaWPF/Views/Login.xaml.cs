using BibliotecaWPF.DAL;
using BibliotecaWPF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BibliotecaWPF.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
       static Usuario usuariologado = new Usuario();
        Usuario usuario = new Usuario();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            usuario = new Usuario();

            usuario.Cpf = TxtCPFlogin.Text;
            usuario.senha = TxtSenhaLogin.Text;

            if (UsuarioDAL.Logar(usuario.Cpf, usuario.senha))
            {
                
                MenuUsuario menuUsuario = new MenuUsuario();
                menuUsuario.Show();

                //isso mostra qual usuario está logado:
                usuario = UsuarioDAL.buscarCPF(TxtCPFlogin.Text);
                menuUsuario.txtConfirmLogin.Text = usuario.Cpf.ToString();
                //-------------------------------------------------------
                usuariologado = SETUsuarioDAL.UsuarioLogadoSET(usuario);
                if (usuariologado != null)
                {
                    MessageBox.Show($"Usuario Logado: {usuariologado.Nome}", "Login", MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Nao está guardando!", "login", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
