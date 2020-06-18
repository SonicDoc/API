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
    public class LoginController : ApiController
    {
        public LoginRespuesta Post(LoginModel mLogin)
        {
            UsuarioBL bl = new UsuarioBL();
            var logR = bl.LoginUser(mLogin.Username, mLogin.Password);
            return logR;
        }

        public List<TipoModel> Get()
        {
            DoctorBL bl = new DoctorBL();
            return bl.AllTurno();
        }
    }
}
