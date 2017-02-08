using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using Dominio.Entidades;*/
using Dominio.Modelo;

namespace Dominio.Abstracto
{
    public  interface IUsuarioRepositorio
    {
        IEnumerable<Usuarios> Usuarios { get;}
    }
}
