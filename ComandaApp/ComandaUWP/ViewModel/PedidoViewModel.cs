using ComandaUWP.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandaUWP.ViewModel
{
    public class PedidoViewModel
    {
        public ObservableCollection<Pedido> Pedidos;

        public PedidoViewModel()
        {
            Pedidos = new ObservableCollection<Pedido>();

            for (int i = 0; i < 3; i++)
            {
                Pedido pedido = new Pedido(i, 40, FormaPgto.debito, "Jorge");
                Pedidos.Add(pedido);
            }
        }
    }
}
