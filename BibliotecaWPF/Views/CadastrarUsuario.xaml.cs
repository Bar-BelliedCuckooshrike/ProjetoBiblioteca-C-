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
    /// Interaction logic for CadastrarUsuario.xaml
    /// </summary>
    public partial class CadastrarUsuario : Window
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario
            {
                Nome = TxtNome.Text,
                Cpf = TxtCPF.Text,
                senha = TxtSenha.Text
            };

            if (UsuarioDAL.Cadastrar(usuario))
            {
                MessageBox.Show("Usuário cadastrado com sucesso!", "Minha Biblioteca",
                    MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBox.Show("Esse usuário já existe!", "Minha Biblioteca", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
