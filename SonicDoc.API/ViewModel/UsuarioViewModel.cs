using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class UsuarioViewModel
    {
        public int ID { set; get; }
        public string DNI { set; get; }
        public string Clave { set; get; }
        public int IdDoctor { set; get; }
        public string Nombres { set; get; }
        public string Apellidos { set; get; }
        public int Sexo { set; get; }
        public string Fecha_nac { set; get; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { set; get; }
        public int Estado { set; get; }

        public UsuarioViewModel(int ID, string DNI, string Nombres,string Apellidos) {
            this.ID = ID;
            this.DNI = DNI;
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Estado = 1;
        }

    }
}