using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Abstracto;
using Dominio.Modelo;


namespace Dominio.Concreto
{
   public class EFUsuarioRepositorio:IUsuarioRepositorio
    {
        private AlmacenEntidadesConexion contexto = new AlmacenEntidadesConexion();
        
       public IEnumerable<Usuario> Usuarios {
            get { return contexto.Usuarios; }
        } 

    }
}
