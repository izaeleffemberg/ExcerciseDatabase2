using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Loja.models
{
    class Produto
    {
        //Propriedades
        public int id;
        public string nome;
        public double preco;

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }
        }
        public double Preco
        {
            get
            {
                return preco;
            }
        }
        public string EhCaro
        {
            get
            {
                if (preco > 3)
                {
                    return "Sim!";
                }
                else
                {
                    return "Não";
                }
            }
        }

        // métodos de produto (executa em um Produto(linha))

        // metodos estáticos (executa na tabela produtos(retorna linhas))
        public static List<Produto> all()
        {
            string sql = "SELECT * FROM produtos";
            SqlConnection con = Conexao.Abrir();
            List<Produto> lista = new List<Produto>();
            
            if (Conexao.EstaAberta())
            {
                SqlCommand cmd_produto = new SqlCommand(sql, con);
                SqlDataReader leitor = cmd_produto.ExecuteReader();
                while (leitor.Read())
                {
                    Produto p = new Produto();
                    p.nome = leitor["nome"].ToString();
                    p.id = Convert.ToInt32(leitor["id"]);
                    p.preco = Convert.ToDouble(leitor["preco"]);
                    
                    lista.Add(p);
                }
            }

            return lista;
            
        }

    }
}
