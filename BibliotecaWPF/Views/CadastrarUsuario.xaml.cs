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
            string UserName = TxtNome.Text;
            try
            {
                int Cpf = Convert.ToInt32(TxtCPF.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("CPF: Digite apenas Números!");
            }
            string Pass = TxtSenha.Text;            
            
            MessageBox.Show($"Nome: {UserName}");
        }
    }
}
