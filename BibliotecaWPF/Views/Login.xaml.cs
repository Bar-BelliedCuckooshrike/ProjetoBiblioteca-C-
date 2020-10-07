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
       


        Usuario usuario = new Usuario();

        public Login()
        {
            InitializeComponent();
        }

        //metodo de login
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            usuario = new Usuario();

            //recebe os dados
            usuario.Cpf = TxtCPFlogin.Text;
            usuario.senha = TxtSenhaLogin.Text;

            //medo para validar
            if (UsuarioDAL.Logar(usuario.Cpf, usuario.senha))
            {
                
                MenuUsuario menuUsuario = new MenuUsuario();
                menuUsuario.Show();

                //isso mostra qual usuario está logado:
                usuario = UsuarioDAL.buscarCPF(TxtCPFlogin.Text);
                menuUsuario.txtConfirmLogin.Text = usuario.Nome.ToString();

                SETUsuarioDAL.UsuarioLogadoSET(usuario);  //guarda o usuario logado 
                SETUsuarioDAL.carregarLista(usuario, LivroDAL.ListarLivros()); //guarda a estante do usuario
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!", "Login", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
