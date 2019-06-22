using Junio21.DAL;
using Junio21.Sakila;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio21.DAL
{
    public class FilmDal
    {
        public static List<film> ListarTodo()
        {
            var resultado = new List<film>();
            using (var grupo = new Sakila.sakilaEntities())
            {

                grupo.Configuration.ProxyCreationEnabled = true;
                resultado = grupo.film
                    .Include("language")

                    .ToList();

            }




            return resultado;
        }
    }
}