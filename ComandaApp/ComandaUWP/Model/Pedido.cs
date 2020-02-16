using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaUWP.Model
{

    public enum FormaPgto
    {
        debito,
        credito,
        dinheiro
    }

    public class Pedido
    {
        public int NumeroPedido { get; set; }
        public double PrecoTotal { get; set; } 
        public DateTime Hora { get; set; }
        public FormaPgto FormaPgto { get; set; }
        public string NomeCliente { get; set; }

        public Pedido(int numPedido, double precoTotal, FormaPgto pgto, string cliente)
        {
            NumeroPedido = numPedido;
            PrecoTotal = precoTotal;
            Hora = DateTime.Now;
            FormaPgto = pgto;
            NomeCliente = cliente;
        }
    }
}
