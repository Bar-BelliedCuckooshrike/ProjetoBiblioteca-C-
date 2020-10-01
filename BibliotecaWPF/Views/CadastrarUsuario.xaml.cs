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
        Usuario usuario = new Usuario();

        public CadastrarUsuario()
        {
            InitializeComponent();
            LimparFomulario();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNome.Text) && !string.IsNullOrWhiteSpace(TxtSenha.Text) 
                && !string.IsNullOrWhiteSpace(TxtCPF.Text))
            {
                usuario = new Usuario
                {
                    Nome = TxtNome.Text,
                    Cpf = TxtCPF.Text,
                    senha = TxtSenha.Text
                };

                if (UsuarioDAL.Cadastrar(usuario))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!", "Minha Biblioteca",
                        MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    LimparFomulario();
                }
                else
                {
                    MessageBox.Show("Esse usuário já existe!", "Minha Biblioteca",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                } 
            }
            else
            {
                MessageBox.Show("Preencha o campo vazio", "Minha Biblioteca",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void LimparFomulario()
        {
            TxtNome.Clear();
            TxtCPF.Clear();
            TxtSenha.Clear();

            usuario = new Usuario();
        }
    }
}
