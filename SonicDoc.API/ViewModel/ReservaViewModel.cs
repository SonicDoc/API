using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class ReservaViewModel
    {
        public int ID { set; get; }
        public int IdDoc { set; get; }
        public int IdPac { set; get; }
        public string Fecha { set; get; }
        public int IdHora { set; get; }  // 8 am a 18 horas 10 horas cada 30 min = 20 atenciones por dia
        public int Sede { set; get; }

    }
}