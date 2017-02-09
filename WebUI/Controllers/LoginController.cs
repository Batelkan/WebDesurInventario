﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Modelo;

namespace WebUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginForm(WebAdminUser usr)
        {
            if(ModelState.IsValid)
            {
                using (AlmacenEntidadesConexion context = new AlmacenEntidadesConexion())
                {
                    var obj = context.WebAdminUsers.Where(x => x.Correo.Equals(usr.Correo) && x.contraseña.Equals(usr.contraseña)).FirstOrDefault();
                    if (obj != null)
                    {
                        return RedirectToAction("UserDashBoard");
                    }
                }
            }
            return View(usr);
        }
    }
}