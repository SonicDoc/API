using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class DefaultRespuesta
    {
        public bool error { set; get; }
        public string message { set; get; }
        public int ID { set; get; }
        public DefaultRespuesta(bool error, string message)
        {
            this.error = error;
            this.message = message;
        }
    }
}