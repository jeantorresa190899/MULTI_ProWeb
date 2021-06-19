using System;
using System.Collections.Generic;

namespace MULTI_ProWeb.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public string IdPedido { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal MontoTotal { get; set; }
        public int Cantidad { get; set; }
        public string Estado { get; set; }
        public int? IdEntrega { get; set; }
        public string IdCliente { get; set; }
        public int? IdPago { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Entrega IdEntregaNavigation { get; set; }
        public virtual MetodoPago IdPagoNavigation { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
