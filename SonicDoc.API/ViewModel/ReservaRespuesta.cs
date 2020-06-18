using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class ReservaRespuesta
    {
        public int ID { set; get; }
        public string Nombre { set; get; }
        public string Fecha { set; get; }
        public string Turno { set; get; }  // 8 am a 18 horas 10 horas cada 30 min = 20 atenciones por dia
        public int Sexo { set; get; }
        public int Estado { set; get; }
        public int Tipo { set; get; }
        public string Especialidad { set; get; }
    }
}