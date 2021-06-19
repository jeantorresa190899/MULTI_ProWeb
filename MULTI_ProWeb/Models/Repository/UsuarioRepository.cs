using MULTI_ProWeb.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MULTI_ProWeb.Models.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {

        ColegioContext db = new ColegioContext();           //llamada a la cadena de conexion a la base de datos

      
        public void Add(Usuario usuario)
        {
            try
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();  //Actualizar la tabla 
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public IEnumerable<Usuario> GetAllUsuarios()
        {
            return db.Usuarios;
        }
    }
}
