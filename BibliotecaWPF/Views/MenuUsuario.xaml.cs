using BibliotecaWPF.DAL;
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

            CboLivros.ItemsSource = SETUsuarioDAL.ListaUsuarioLogadoGET(); // manda a lista do usuario

            // CboLivros.ItemsSource = LivroDAL.ListarLivros(); //retorna a lista de livros
             CboLivros.DisplayMemberPath = "TituloLivro";
             CboLivros.SelectedValuePath = "usuariolog";


        }


        //botão cadastrar livro
        private void btnCadastrarLivro_Click(object sender, RoutedEventArgs e)
        {
            CadastrarLivro cadastrarLivro = new CadastrarLivro();
            cadastrarLivro.Show();
        }

        //botão para abrir o menu estante
        private void btnListarLivros_Click(object sender, RoutedEventArgs e)
        {
            

            ListaLivros listaLivros = new ListaLivros();

            listaLivros.Show();


        }
    }
}
