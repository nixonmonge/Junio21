using Junio21.Sakila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio21.DAL
{
    public class LenguageDal
    {
        public static List<language> ListarTodo()
        {
            var resultado = new List<language>();
            using (var grupo = new Sakila.sakilaEntities())
            {
                resultado = grupo.language.ToList();

            }

            return resultado;
        }
    }
}