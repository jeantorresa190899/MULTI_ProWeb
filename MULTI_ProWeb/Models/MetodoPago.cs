using System;
using System.Collections.Generic;

namespace MULTI_ProWeb.Models
{
    public partial class MetodoPago
    {
        public MetodoPago()
        {
            Pedidos = new HashSet<Pedido>();
        }

        public int IdPago { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
