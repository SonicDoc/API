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
    public class EspecialidadController : ApiController
    {
        public List<TipoModel> Get()
        {
            EspecialidadBL bl = new EspecialidadBL();
            return bl.ListaEsp();
        }

        public List<DoctorModel> Get(int ID)
        {
            DoctorBL bl = new DoctorBL();
            return bl.ListaDoctor(ID);
        }
    }
}
