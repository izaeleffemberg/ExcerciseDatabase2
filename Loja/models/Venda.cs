using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.models
{
    class Venda
    {
        private int id;
        private int cliente_id;
        private DateTime data_hora;
        private Double valor_total;

        public static List<Venda> all()
        {
            // Fazer
        }

        // método não estático
        public List<ProdutoVendido> produtos_vendidos()
        {
            string sql = "SELECT * FROM produtos_vendidos WHERE venda_id = " + this.id.ToString();
            // fazer
        }
    }
}
