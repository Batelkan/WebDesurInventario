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
        private InformaticaEntities contexto = new InformaticaEntities();
        
       public IEnumerable<Usuarios> Usuarios {
            get { return contexto.Usuarios; }
        } 

    }
}
