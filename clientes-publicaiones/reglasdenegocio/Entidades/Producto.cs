﻿using Tiendita.Entity.Common;
using Tiendita.Entity.Enums;

namespace reglasdenegocio.Entidades
{
    public class Producto: Entitycommon
    {
        public string Nombre { get; set; }
        public string descripcion { get; set; }
        public short Cant_producto { get; set; }
        public string identificador { get; set; }

    }
}
