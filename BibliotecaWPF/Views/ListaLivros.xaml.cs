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
    /// Lógica interna para ListaLivros.xaml
    /// </summary>
    public partial class ListaLivros : Window
    {
        public ListaLivros()
        {
            InitializeComponent();

            List<Livro> Mylivros = new List<Livro>();

            ID_LISTA.ItemsSource = LivroDAL.ListarLivros(); //carrega a lista
            

              // ID_LISTA.DisplayMemberPath = "TituloLivro";
             // ID_LISTA.SelectedValuePath = "usuariolog";
           // Mylivros = LivroDAL.ListarLivros();
        }

        
        
    }
}
