using System;
using System.Collections.Generic;

namespace MULTI_ProWeb.Models
{
    public partial class Categorium
    {
        public Categorium()
        {
            Torta = new HashSet<Tortum>();
        }

        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Tortum> Torta { get; set; }
    }
}
