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
    /// Interaction logic for CadastrarLivro.xaml
    /// </summary>
    public partial class CadastrarLivro : Window
    {
        public CadastrarLivro()
        {
            InitializeComponent();
        }

        

        private void btnCadastrarLivro_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario();
            Livro livro = new Livro()
            {
                TituloLivro = TxtTitulo.Text,
                Autor = TxtAutor.Text,
                Edicao = Convert.ToInt32(TxtEdicao.Text),
                Editora = TxtEditora.Text,
                Genero = TxtGenero.Text,
                NumeroPaginas = Convert.ToInt32(TxtPaginas.Text),
                Isbn = TxtISBN.Text               
            };

            livro.usuariolog = SETUsuarioDAL.UsuarioLogadoGET();

            if (LivroDAL.CadastrarLivro(livro)) //essa parte que eu nao sei como coloco um livro num usuario e numa estante; Usuario tem que possuir uma estante que possui livros;
            {
                    
                MessageBox.Show("Livro cadastrado com sucesso!", "Cadastrar livro",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Não é permitido o mesmo ISBN!", "Cadastrar livro",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }



        }
    }
}
