using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Loja.models;
using System.Data.SqlClient;

namespace Loja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_produto_all_Click(object sender, RoutedEventArgs e)
        {
            // Testar trazer todos os produtos
            List<Produto> lista = Produto.all();
            muda_cor_da_conexao();

            dataGrid1.ItemsSource = lista;



            // TESTANDO VENDAS
            //List<Venda> vendas = Venda.all();
            //List<ProdutoVendido> produtos_vendidos = vendas[0].produtos_vendidos;

        }

        private void muda_cor_da_conexao()
        {
            if (Conexao.EstaAberta())
            {
                lb_conn.Content = "Conectado!";
                lb_conn.Foreground = Brushes.Lavender;
            }
            else
            {
                lb_conn.Content = "Desconectado";
                lb_conn.Foreground = Brushes.HotPink;
            }
        }

        private void btn_connection_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = Conexao.Abrir();
            muda_cor_da_conexao();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Conexao.Fechar();
            muda_cor_da_conexao();
        }
    }
}
