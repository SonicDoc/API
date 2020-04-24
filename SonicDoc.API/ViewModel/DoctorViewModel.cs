using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class DoctorViewModel
    {
        public int ID { set; get; }
        public int IdEspe { set; get; }
        public int Estado { set; get; }

        public DoctorViewModel(int ID, int IdEspe) {
            this.ID = ID;
            this.IdEspe = IdEspe;
            this.Estado = 1;
        }
    }
}