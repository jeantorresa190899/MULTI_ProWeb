using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MULTI_ProWeb.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Pedidos = new HashSet<Pedido>();
            Usuarios = new HashSet<Usuario>();
        }
        [Required(ErrorMessage = "El campo ID es obligatorio")]
        public string IdCliente { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Apellido es obligatorio")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El campo DNI es obligatorio")]
        public int Dni { get; set; }
        [Required(ErrorMessage = "El campo Domicilio es obligatorio")]
        public string Domicilio { get; set; }
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public string Correo { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
