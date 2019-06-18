﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorageProject.Utils
{
    public class Sessao
    {
        private static string usuario = "USUARIO";


        public static string Login(string login)
        {
            HttpContext.Current.Session[usuario] = login;
            return HttpContext.Current.Session[usuario].ToString();
        }
        public static string RetornarUsuario()
        {
            if (HttpContext.Current.Session[usuario] == null)
            {
                return null;
            }
            return HttpContext.Current.Session[usuario].ToString();
        }
    }

}

