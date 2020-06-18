using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class DoctorModel
    {
        public int ID { set; get; }
        public string Especialidad { set; get; }
        public string Nombres { set; get; }
        public int Sexo { set; get; }
    }
}