using MySqlConnector;
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
        public int Id { get; set; }
        public int Nome { get; set; }
        public string Medicamento { get; set; }
        public int Quantidade { get; set; }
        public DateTime DatPrescricao { get; set; }
        public string HoraPrescricao { get; set; }
        #endregion

        #region ConnectionStrings
        public readonly string strConexao = ConfigurationManager.ConnectionStrings["TCC"].ConnectionString;
        #endregion

        public void InserirHorario(string nome, string medicamento, int quantidade, string datPrescricao, string horaPrescricao, int dispensado)
        {
            var id = ObterIdHorario();

            MySqlConnection conn = new MySqlConnection(strConexao);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO Horarios Values (" + id + ", '" + nome + "', '" + medicamento + "', " + quantidade + ", '" + datPrescricao + "', '" + horaPrescricao + "', " + dispensado + ")", conn);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int ObterIdHorario()
        {
            MySqlConnection conn = new MySqlConnection(strConexao);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT MAX(Id) from Horarios", conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            int id = 0;
            while (dr.Read())
            {
                if (dr.FieldCount == 0)
                {
                    id = 0;
                }
                else
                {
                    id = dr.GetInt32(0);
                }
            }

            conn.Close();

            return id + 1;
        }
    }
}