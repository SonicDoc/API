using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SonicDoc.API.ViewModel;
using SonicDoc.API.BL;
namespace SonicDoc.API.Controllers
{
    public class DoctorController : ApiController
    {

        public List<DoctorViewModel> Get(string Filtro)
        {
            DoctorBL bl = new DoctorBL();
            return bl.ListaDoctor(Filtro);
        }

        public DefaultRespuesta Post(DoctorViewModel vmDoctor)
        {
            return new DefaultRespuesta(true,"Felicidades");
        }

    }
}
