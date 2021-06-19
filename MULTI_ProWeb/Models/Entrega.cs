using System;
using System.Collections.Generic;

namespace MULTI_ProWeb.Models
{
    public partial class Entrega
    {
        public Entrega()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int IdEntrega { get; set; }
        public string Nombre { get; set; }
        public double? Monto { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
