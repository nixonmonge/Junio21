using Junio21.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio21.DAL
{
    public class CiudadDal
    {
        public static List<Ciudades> ListarTodo()
        {
            var resultado = new List<Ciudades>();
            using (var grupo = new IF.junio21Entities1())
            {
                
                grupo.Configuration.ProxyCreationEnabled = true;
                resultado = grupo.Ciudades
                    .Include("Paises")
                    .Include("Paises.Continentes")
                    .ToList();

            }




            return resultado;
        }
    }
}