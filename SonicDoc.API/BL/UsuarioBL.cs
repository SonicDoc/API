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
        SonicdocEntities context = new SonicdocEntities();
        public LoginRespuesta LoginUser(string Username,string Password) {

            try {
                LoginRespuesta mLogin = new LoginRespuesta("Usuario y/o Contraseña Incorrectos");
                var objModel = context.Usuario.Where(x => x.DNI == Username && x.Clave == Password).FirstOrDefault();

                if (objModel != null) {
                    mLogin.ID = objModel.ID;
                    mLogin.Estado = objModel.ID_Estado;
                    mLogin.Mensaje = "Bienvenido " + objModel.Nombres;
                    mLogin.Error = false;
                }

                return mLogin;
            } catch {
                return new LoginRespuesta();
            }
        }

        public DefaultRespuesta AddUsuario(UsuarioModel mUser) {
            try {

                var resultado = new System.Data.Entity.Core.Objects.ObjectParameter("ID", 0);
                var temp = context.sp_Insert_Usuario(mUser.DNI,mUser.Clave,mUser.Nombres,mUser.Apellidos,mUser.Sexo, resultado);
                int objId = Convert.ToInt32(resultado.Value);

                if (objId > 0) {
                    return new DefaultRespuesta(objId,false,"Guardado Satisfactoriamente");
                }

                return new DefaultRespuesta(objId,true,"Error al Guardar");

            } catch {
                return new DefaultRespuesta();
            }
        }

        public List<UsuarioModel> getUsuarios() {
            try {
                List<UsuarioModel> vmLista = new List<UsuarioModel>();

                var lista = context.Usuario.ToList();

                if (lista != null) {
                    foreach (var item in lista) {
                        UsuarioModel temp = new UsuarioModel();
                        temp.ID = item.ID;
                        temp.DNI = item.DNI;
                        temp.Nombres = item.Nombres;
                        temp.Apellidos = item.Apellidos;
                        temp.Sexo = item.Sexo;
                        temp.Estado = item.ID_Estado;
                        temp.Clave = item.Clave;

                        vmLista.Add(temp);
                    }
                }

                return vmLista;

            } catch {
                return null;
            }
        }
                
    }
}