using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MULTI_ProWeb.Models
{
    public partial class Usuario
    {
        [Required(ErrorMessage = "El campo ID es obligatorio")]
        public string IdUsuario { get; set; }
        [Required(ErrorMessage = "El campo Username es obligatorio")]
        public string Username { get; set; }
        [Required(ErrorMessage = "El campo Pass es obligatorio")]
        public string Password { get; set; }
        [Required(ErrorMessage = "El campo idCliente es obligatorio")]
        public string IdCliente { get; set; }

       
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
