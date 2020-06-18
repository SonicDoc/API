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
    public class TurnoController : ApiController
    {
        public string Post(TipoModel mDoc)
        {
            DoctorBL bl = new DoctorBL();

            var lista = bl.ListaTurno(mDoc.ID, mDoc.Nombres);

            return "lISTA : " + lista.Count().ToString();
        }

        public List<TipoModel> Get(TipoModel mDoc)
        {
            DoctorBL bl = new DoctorBL();
            return bl.ListaTurno(mDoc.ID, mDoc.Nombres);
        }
        
    }
}
