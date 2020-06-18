using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SonicDoc.API.ViewModel;
using SonicDoc.API.Models;
namespace SonicDoc.API.BL
{
    public class DoctorBL
    {

        SonicdocEntities context = new SonicdocEntities();
               
        public List<DoctorModel> ListaDoctor(int IdEsp)
        {
            try
            {
                List<DoctorModel> vmLista = new List<DoctorModel>();

                var listamodel = context.Doctor.Where(x => x.ID_Espec == IdEsp).ToList();
                if (listamodel != null) {
                    foreach (var item in listamodel) {
                        var nombre = item.Usuario.Nombres + " " + item.Usuario.Apellidos;
                        DoctorModel temp = new DoctorModel();
                        temp.ID = item.ID;
                        temp.Nombres = nombre;
                        temp.Especialidad = item.Especialidad.Nombre;
                        temp.Sexo = item.Usuario.Sexo;

                        vmLista.Add(temp);
                    }                    
                }
                return vmLista;
            }
            catch
            {
                return null;
            }
        }

        public List<DoctorModel> ListaDoctor()
        {
            try
            {
                List<DoctorModel> vmLista = new List<DoctorModel>();

                var listamodel = context.Doctor.ToList();
                if (listamodel != null)
                {
                    foreach (var item in listamodel)
                    {
                        var nombre = item.Usuario.Nombres + " " + item.Usuario.Apellidos;
                        DoctorModel temp = new DoctorModel();
                        temp.ID = item.ID;
                        temp.Nombres = nombre;
                        temp.Especialidad = item.Especialidad.Nombre;
                        temp.Sexo = item.Usuario.Sexo;
                        vmLista.Add(temp);
                    }
                }
                return vmLista;
            }
            catch
            {
                return null;
            }
        }

        public DefaultRespuesta AddDoctor(UsuarioModel mDoc)
        {
            try
            {                
                var resultado = new System.Data.Entity.Core.Objects.ObjectParameter("ID", 0);
                var temp = context.sp_Insert_Doctor(mDoc.ID_Esp, mDoc.DNI, mDoc.Clave, mDoc.Nombres, mDoc.Apellidos, mDoc.Sexo, resultado);
                int objId = Convert.ToInt32(resultado.Value);

                if (objId > 0)
                {
                    return new DefaultRespuesta(objId, false, "Guardado Satisfactoriamente");
                }
                return new DefaultRespuesta(objId, true, "Error al Guardar");
            }
            catch
            {
                return new DefaultRespuesta();
            }
        }

        public DefaultRespuesta AddEspecialidad(int IdUser,int IdEsp)
        {
            try
            {
                var resultado = new System.Data.Entity.Core.Objects.ObjectParameter("ID", 0);
                var temp = context.sp_Insert_Especialidad(IdUser, IdEsp, resultado);
                int objId = Convert.ToInt32(resultado.Value);

                if (objId > 0)
                {
                    return new DefaultRespuesta(objId, false, "Guardado Satisfactoriamente");
                }
                return new DefaultRespuesta(objId, true, "Error al Guardar");
            }
            catch
            {
                return new DefaultRespuesta();
            }
        }

        public List<TipoModel> ListaTurno(int IdDoc, string Fecha) {
            try {
                List<TipoModel> mLista = new List<TipoModel>();                
                var lstaTurno = context.Turno.ToList();

                foreach (var item in lstaTurno) {
                    TipoModel temp = new TipoModel(item.ID, item.Nombre);

                    mLista.Add(temp);
                }

                DateTime fecha = Convert.ToDateTime(Fecha);
                var lista = context.Reserva.Where(x => x.Fecha == fecha && x.ID_Doc == IdDoc).ToList();
                if (lista != null) {
                    foreach (var item in lista) {
                        mLista.RemoveAt(item.ID_Turno - 1);
                    }
                }
                return mLista;

            } catch { return null; }
        }

        public List<TipoModel> AllTurno()
        {
            try
            {
                List<TipoModel> mLista = new List<TipoModel>();
                var lstaTurno = context.Turno.ToList();

                foreach (var item in lstaTurno)
                {
                    TipoModel temp = new TipoModel(item.ID, item.Nombre);

                    mLista.Add(temp);
                }
                
                return mLista;

            }
            catch { return null; }
        }
    }
}