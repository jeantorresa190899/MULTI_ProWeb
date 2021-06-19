using System;
using System.Collections.Generic;

namespace MULTI_ProWeb.Models
{
    public partial class DetallePedido
    {
        public string IdPedido { get; set; }
        public string IdTorta { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual Tortum IdTortaNavigation { get; set; }
    }
}
