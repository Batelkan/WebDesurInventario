using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Abstracto;
using Dominio.Modelo;

namespace Dominio.Concreto
{
    class EFWebAdminRespositorio:IWebAdminRespositorio
    {
        private InformaticaEntities contexto = new InformaticaEntities();

        public IEnumerable<WebAdminUser> WebAdminUser
        {
            get { return contexto.WebAdminUser; }
        }
    }
}
