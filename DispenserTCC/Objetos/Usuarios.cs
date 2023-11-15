using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace DispenserTCC.Objetos
{
    public class Usuarios
    {
        #region prop
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NumDocumento { get; set; }
        public string NumTelefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        #endregion

        #region ConnectionStrings
        public readonly string strConexao = ConfigurationManager.ConnectionStrings["TCC"].ConnectionString;
        #endregion

        public String VerificaUsuario(string email, string senha)
        {
            MySqlConnection conn = new MySqlConnection(strConexao);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("Select Nome from Usuario where Email = '" + email + "' AND Senha = '" + senha + "'", conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            string nome = "";
            while (dr.Read())
            {
                nome = dr.GetString(0);
            }

            return nome;
        }

        public void InserirUsuario(string nome, string numDocumento, string numTelefone, string email, string senha)
        {
            MySqlConnection conn = new MySqlConnection(strConexao);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO Usuario Values ('" + nome + "', '" + numDocumento + "', '" + numTelefone + "', '" + email + "', '" + senha + "')", conn);

            cmd.ExecuteNonQuery();
        }
    }
}