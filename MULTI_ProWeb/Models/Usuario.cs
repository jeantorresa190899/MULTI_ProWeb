using System;
using System.Collections.Generic;

namespace MULTI_ProWeb.Models
{
    public partial class Usuario
    {
        public string IdUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
