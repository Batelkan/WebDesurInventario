﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;

namespace Dominio.Abstracto
{
    public interface IDepartamentoRepositorio
    {
     IEnumerable<Departamentos> Departamentos { get; set; }
    }
}
