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
        private List<DoctorViewModel> LstaEspecialidad(int IdEspe) {
            try {
                List<DoctorViewModel> vmLista = new List<DoctorViewModel>();


                return vmLista;
            } catch {
                return null;
            }
        }

        private List<DoctorViewModel> LstaNombre(string Filtro)
        {
            // filtro nombre u apellido
            try
            {
                List<DoctorViewModel> vmLista = new List<DoctorViewModel>();


                return vmLista;
            }
            catch
            {
                return null;
            }
        }



        public List<DoctorViewModel> ListaDoctor(string Filtro)
        {
            // filtro nombre u apellido
            try
            {
                int IdEsp = getFiltroDoc(Filtro);
                if (IdEsp > 0)
                    return LstaEspecialidad(IdEsp);
                else
                    return LstaNombre(Filtro);
            }
            catch
            {
                return null;
            }
        }

        private int getFiltroDoc(string Filtro) {
            try {
                return Convert.ToInt32(Filtro);
            } catch {
                return 0;
            }
        }
    }
}