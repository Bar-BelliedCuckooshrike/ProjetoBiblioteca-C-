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
    /// Interaction logic for MenuUsuario.xaml
    /// </summary>
    public partial class MenuUsuario : Window
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrarLivro_Click(object sender, RoutedEventArgs e)
        {
            CadastrarLivro cadastrarLivro = new CadastrarLivro();
            cadastrarLivro.Show();
        }
    }
}
