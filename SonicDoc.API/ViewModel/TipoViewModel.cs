using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class TipoViewModel
    {
        public int ID { set; get; }
        public string Nombre { set; get; }

        public TipoViewModel(int ID,string Nombre) {
            this.ID = ID;
            this.Nombre = Nombre;
        }
    }
}