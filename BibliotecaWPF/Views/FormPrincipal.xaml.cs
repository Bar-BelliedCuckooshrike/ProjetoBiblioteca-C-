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
    /// Interaction logic for FormPrincipal.xaml
    /// </summary>
    public partial class FormPrincipal : Window
    {
        public FormPrincipal()
        {
            InitializeComponent();
           
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Minha Biblioteca",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void CadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            CadastrarUsuario CadUser = new CadastrarUsuario();
            CadUser.Show();
        }
    }
}
