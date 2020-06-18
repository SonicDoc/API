using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class LoginRespuesta
    {
        public int ID { set; get; }
        public int Estado { set; get; }
        public bool Error { set; get; }
        public string Mensaje { set; get; }
        public LoginRespuesta(string Mensaje) {
            this.Error = true;
            ID = 0;
            this.Mensaje = Mensaje;

        }

        public LoginRespuesta()
        {
            this.Error = true;
            ID = 0;
            this.Mensaje = "Error de Conexion";
        }
    }
}