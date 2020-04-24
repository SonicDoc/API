using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class LoginViewModel
    {
        public int ID { set; get; }
        public string DNI { set; get; }
        public int IdDoctor { set; get; }
        public string Nombres { set; get; }

        public LoginViewModel(int ID,string DNI,string Nombres) {
            this.ID = ID;
            this.DNI = DNI;
            this.Nombres = Nombres;
            this.IdDoctor = 0;
        }
    }
}