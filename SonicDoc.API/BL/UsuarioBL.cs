using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SonicDoc.API.ViewModel;
using SonicDoc.API.Models;
namespace SonicDoc.API.BL
{
    public class UsuarioBL
    {
        public LoginViewModel Login() {

            try {
                LoginViewModel vmLogin = new LoginViewModel(0,"","");
                return vmLogin;
            } catch {
                return null;
            }
        }
    }
}