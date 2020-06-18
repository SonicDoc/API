using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SonicDoc.API.Models;
using SonicDoc.API.ViewModel;
namespace SonicDoc.API.BL
{
    public class ReservaBL
    {
        SonicdocEntities context = new SonicdocEntities();
        
        //envia doctores
        public List<ReservaRespuesta> ReservaUser(int IdUsuario) {
            try {
                List<ReservaRespuesta> mLista = new List<ReservaRespuesta>();
                List<Reserva> modelLista = context.Reserva.Where(x => x.ID_Usuario == IdUsuario).ToList();                
                
                if (modelLista != null) {
                    foreach (var item in modelLista) {
                        ReservaRespuesta temp = new ReservaRespuesta();
                        temp.ID = item.ID;
                        temp.Nombre = item.Doctor.Usuario.Nombres +" " + item.Doctor.Usuario.Apellidos; ;
                        temp.Turno = item.Turno.Nombre;
                        temp.Fecha = item.Fecha.ToShortDateString();
                        temp.Estado = item.ID_Estado;
                        temp.Sexo = item.Doctor.Usuario.Sexo;
                        temp.Tipo = 2;
                        temp.Especialidad = item.Doctor.Especialidad.Nombre;
                        mLista.Add(temp);
                    }
                }

                return mLista;
            } catch {
                return null;
            }
        }

        // Envia Usuarios
        public List<ReservaRespuesta> ReservaDoctor(int IdUsuario)
        {
            try
            {
                List<ReservaRespuesta> mLista = new List<ReservaRespuesta>();

                var modelLista = context.Reserva.Where(x => x.ID_Doc == IdUsuario).ToList();

                if (modelLista != null)
                {
                    foreach (var item in modelLista)
                    {
                        ReservaRespuesta temp = new ReservaRespuesta();
                        temp.ID = item.ID;
                        temp.Nombre = item.Usuario.Nombres +" "+ item.Usuario.Apellidos; ;
                        temp.Turno = item.Turno.Nombre;
                        temp.Fecha = item.Fecha.ToShortDateString();
                        temp.Estado = item.ID_Estado;
                        temp.Sexo = item.Usuario.Sexo;
                        temp.Tipo = 1;
                        temp.Especialidad = "";
                        mLista.Add(temp);
                    }
                }

                return mLista;
            }
            catch
            {
                return null;
            }
        }

        public DefaultRespuesta AddReserva(ReservaModel mReserva) {
            try
            {
                DateTime fecha = Convert.ToDateTime(mReserva.Fecha);
                
                var resultado = new System.Data.Entity.Core.Objects.ObjectParameter("ID", 0);
                var temp = context.sp_Insert_Reserva(mReserva.ID_User, mReserva.ID_Doctor,fecha,mReserva.ID_Turno,1, resultado);
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

        //private bool VerificaReserva(int IdDoc,DateTime fecha,int IdTurno) {
        //    var model = context.Reserva.Where(x => x.Fecha.Year == fecha.Year && x.Fecha.Month == fecha.Month && fecha.Day == fecha.Day && x.ID_Doc == IdDoc && x.ID_Turno == IdTurno).FirstOrDefault();
        //    if (model != null) {
        //        return true;
        //    }

        //    return false;
        //}
    }
}