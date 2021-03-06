﻿
using StorageProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StorageProject.DAL
{
    public class UsuarioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static bool CadastrarUsuario(Usuario u)
        {
            if (BuscarUserLogin(u) == null)
            {
                u.Imagem = "semimagem.jpeg";
                ctx.Usuario.Add(u);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Usuario BuscarUserLogin(Usuario u)
        {
            return ctx.Usuario.FirstOrDefault(x => x.Username.Equals(u));
        }
        public static Usuario BuscarUserLoginString(string u)
        {
            return ctx.Usuario.Include("Endereco").FirstOrDefault(x => x.Username.Equals(u));
        }

        public static Usuario BuscarUsuarioId(int? id)
        {
            return ctx.Usuario.Find(id);
        }

        public static Endereco BuscarEndereco(Usuario u)
        {
            return ctx.Endereco.FirstOrDefault(x => x.EnderecoID.Equals(u.Endereco.EnderecoID));
        }


        public static Usuario BuscarUserLoginPassword(Usuario usuario)
        {
            return ctx.Usuario.FirstOrDefault(x => x.Username.Equals(usuario.Username) && x.Password.Equals(usuario.Password));
        }

        public static void AlterarUsuario(Usuario u)
        {
            ctx.Entry(u).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }


    }
}