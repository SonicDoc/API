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
    public class UsuarioController : ApiController
    {
        public List<ReservaRespuesta> Get(int ID) {
            ReservaBL bl = new ReservaBL();
            return bl.ReservaUser(ID);
        }

        public DefaultRespuesta Post(UsuarioModel mUser)
        {
            UsuarioBL bl = new UsuarioBL();

            return bl.AddUsuario(mUser);

        }

        public List<UsuarioModel> Get()
        {
            UsuarioBL bl = new UsuarioBL();

            return bl.getUsuarios();

        }
    }
}
