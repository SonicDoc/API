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
    public class ReservaController : ApiController
    {
        //Id 
        public DefaultRespuesta Post(ReservaModel mReserva) {

            ReservaBL bl = new ReservaBL();

            return bl.AddReserva(mReserva);
        }
       
    }
}
