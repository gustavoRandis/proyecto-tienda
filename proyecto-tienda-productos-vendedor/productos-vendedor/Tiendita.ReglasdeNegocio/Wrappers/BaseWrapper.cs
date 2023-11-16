using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.ReglasdeNegocio.Wrappers
{
    public class BaseWrapper
    {
        public int NumeroError { get; set; }
        public string? Mensaje { get; set; }
    }
}
//Dotnet add package MySql.Data