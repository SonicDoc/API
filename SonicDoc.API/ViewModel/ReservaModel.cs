using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class ReservaModel
    {
        public int ID_Doctor { set; get; }
        public int ID_User { set; get; }
        public string Fecha { set; get; }
        public int ID_Turno{ set; get; } 
    }
}