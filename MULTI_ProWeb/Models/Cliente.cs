using System;
using System.Collections.Generic;

namespace MULTI_ProWeb.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
            Usuarios = new HashSet<Usuario>();
        }

        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Dni { get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
