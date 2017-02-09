﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Modelo;

namespace Dominio.Abstracto
{
   public interface IWebAdminRespositorio
    {
     IEnumerable<WebAdminUser> WebAdminUser {get;}
    }
}
