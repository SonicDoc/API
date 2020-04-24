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

        public LoginViewModel Get(string DNI,string Clave)
        {
            UsuarioBL bl = new UsuarioBL();
            return bl.Login();
        }

    }
}
