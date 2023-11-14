﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita.ReglasdeNegocio.ExcepcionesPersonales
{
    //Esta clase ayuda a personalizar y manejar excepciones específicas de MySQL de una manera más comprensible y adecuada
    //para el contexto de la tienda. Por ejemplo, asigna códigos HTTP más familiares y mensajes personalizados a ciertos
    //códigos de error MySQL.
    public class DBMySqlException : Exception
    {

        public int Number { get; private set; }
        public string MessageError { get; private set; }
        public DBMySqlException(int number, string message)
        {
            switch (number)
            {
                case 1045:
                    Number = 401;
                    MessageError = "Usuario o contraseña inválido.";
                    break;
                case 1042:
                    Number = 503;
                    MessageError = "El servidor no es accesible.";
                    break;
                case 1049:
                    Number = 404;
                    MessageError = "La base de datos no existe.";
                    break;
                default:
                    Number = number;
                    MessageError = message;
                    break;
            }
        }
    }
}


