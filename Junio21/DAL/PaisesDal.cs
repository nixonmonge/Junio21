using Junio21.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio21.DAL
{
    public class PaisesDal
    {
        public static List<Paises> ListarTodo()
        {
            var resultado = new List<Paises>();
            using (var grupo = new IF.junio21Entities1())
            {
                resultado = grupo.Paises.ToList();

            }

            return resultado;
        }
    }
}