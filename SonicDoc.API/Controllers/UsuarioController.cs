﻿using System;
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

        public List<ReservaViewModel> Get(int ID) {

            return new List<ReservaViewModel>();
        }

        [HttpPost]
        public DefaultRespuesta Post(UsuarioViewModel vmUsuario)
        {
            return new DefaultRespuesta(true,"");
        }
    }
}
