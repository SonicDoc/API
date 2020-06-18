using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class DefaultRespuesta
    {
        public int ID { set; get; }
        public bool error { set; get; }
        public string message { set; get; }
        public DefaultRespuesta(int ID, bool error, string message)
        {
            this.ID = ID;
            this.error = error;
            this.message = message;
        }

        public DefaultRespuesta()
        {
            this.error = true;
            this.message = "Error Conexion!!!";
        }
    }
}