using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SonicDoc.API.ViewModel;
using SonicDoc.API.Models;
namespace SonicDoc.API.BL
{
    public class EspecialidadBL
    {
        SonicdocEntities context = new SonicdocEntities();

        public List<TipoModel> ListaEsp() {
            try {
                List<TipoModel> mLista = new List<TipoModel>();
                var lista = context.Especialidad.ToList();
                if (lista != null) {
                    foreach(var item in lista){
                        TipoModel temp = new TipoModel(item.ID, item.Nombre);
                        mLista.Add(temp);
                    }
                }

                return mLista;

            } catch { return new List<TipoModel>(); }
        }
        
    }
}