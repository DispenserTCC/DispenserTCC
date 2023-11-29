using Antlr.Runtime.Misc;
using Cassandra.Mapping;
using Google.Protobuf.WellKnownTypes;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace DispenserTCC.Objetos
{
    public class Relatorios
    {
        #region ConnectionStrings
        public readonly string strConexao = ConfigurationManager.ConnectionStrings["TCC"].ConnectionString;
        #endregion

        public List<Horarios> BuscarRelatorio()
        {
            MySqlConnection conn = new MySqlConnection(strConexao);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("Select * from Horarios", conn);

            IDataReader reader = cmd.ExecuteReader();

            List<Horarios> listaRetorno = new List<Horarios>();

            while (reader.Read())
            {
                listaRetorno.Add(new Horarios()
                {
                    Id = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Medicamento = reader.GetString(2),
                    Quantidade = reader.GetInt32(3),
                    DatPrescricao = reader.GetDateTime(4),
                    HoraPrescricao = reader.GetValue(5).ToString(),
                    Dispensado = reader.GetInt32(6)
                });
            }

            return listaRetorno;
        }
    }
}