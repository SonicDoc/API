using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class TipoModel
    {
        public int ID { set; get; }
        public string Nombres { set; get; }

        public TipoModel(int ID,string Nombres) {
            this.ID = ID;
            this.Nombres = Nombres;
        }
    }
}