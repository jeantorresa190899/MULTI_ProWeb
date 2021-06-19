using System;
using System.Collections.Generic;

namespace MULTI_ProWeb.Models
{
    public partial class Tortum
    {
        public Tortum()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public string IdTorta { get; set; }
        public int? Nivel { get; set; }
        public string Tamaño { get; set; }
        public string Dimension { get; set; }
        public string Sabor { get; set; }
        public string Relleno { get; set; }
        public string Topping { get; set; }
        public string Ganache { get; set; }
        public string Color { get; set; }
        public string Dedicatoria { get; set; }
        public decimal? Precio { get; set; }
        public int? IdCategoria { get; set; }

        public virtual Categorium IdCategoriaNavigation { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
