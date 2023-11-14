using System.Security;
using Tiendita.Entity.Common;

namespace reglasdenegocio.Entidades
{
    //REPRESENTA LAS PROPIEDADES REACIONADAS A VENDEDORES, HEREDA DE USUARIO COMMON Y SE PODRAN INSTANCIAR VENDEDORES DE ESTA CLASE
    public class Vendedor : Usuariocommon
    {

        public string Dni {get; set;}
        public string Cvu_cbu { get; set; }
   

    }
}
