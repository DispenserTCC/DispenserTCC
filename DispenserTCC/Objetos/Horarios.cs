using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DispenserTCC.Objetos
{
    public class Horarios
    {
        #region prop
        public int IdHorario { get; set; }
        public int IdUsuario { get; set; }
        public string Medicamento { get; set; }
        public int Quantidade { get; set; }
        public DateTime DatPrescricao { get; set; }
        #endregion

        #region ConnectionStrings
        public readonly string strConexao = ConfigurationManager.ConnectionStrings["TCC"].ConnectionString;
        #endregion
    }
}