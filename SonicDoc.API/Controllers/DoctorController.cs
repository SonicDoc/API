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

        public List<ReservaRespuesta> Get(int ID)
        {
            ReservaBL bl = new ReservaBL();
            return bl.ReservaDoctor(ID);
        }

        public DefaultRespuesta Post(UsuarioModel mDoctor)
        {
            DoctorBL bl = new DoctorBL();

            return bl.AddDoctor(mDoctor);

        }

        public List<DoctorModel> Get()
        {
            DoctorBL bl = new DoctorBL();

            return bl.ListaDoctor();

        }

    }
}
