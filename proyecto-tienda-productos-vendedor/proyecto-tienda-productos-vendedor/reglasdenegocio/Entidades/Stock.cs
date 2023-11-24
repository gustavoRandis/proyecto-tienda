using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Entity.Common;

namespace Tiendita.Entity.Entidades
{
    //REPRESENTA INFORMACION RELACIONADA CON STOCK, DE ESTA CLASE SE PODRAN CREAR INSTANCIAS.
    public class Stock:Entitycommon
    {
        public int id {  get; set; }
        public Producto Producto { get; set; }  
        public int CantidadUnidades {  get; set; }
    }
}
