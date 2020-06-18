using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class UsuarioModel
    {
        public int ID { set; get; }
        public int ID_Esp { set; get; }
        public string DNI { set; get; }
        public string Clave { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public int Sexo { set; get; }
        public int Estado { set; get; }
    }
}