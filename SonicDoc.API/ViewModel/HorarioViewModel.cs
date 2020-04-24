using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SonicDoc.API.ViewModel
{
    public class HorarioViewModel
    {
        public int Dia { set; get; } /// lunes - sabado 1-6
        public int IdTurno { set; get; }
        public HorarioViewModel(int Dia,int IdTurno) {
            this.Dia = Dia;
            this.IdTurno = IdTurno;
        }
    }
}