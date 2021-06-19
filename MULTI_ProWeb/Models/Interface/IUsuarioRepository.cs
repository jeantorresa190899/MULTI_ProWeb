using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MULTI_ProWeb.Models.Interface
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> GetAllUsuarios();
        void Add(Usuario usuario);
    }
}
