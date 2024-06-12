using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClubDeportivo1.Entidades;

namespace ClubDeportivo1.Datos
{
    internal class Persona
    {
        public string Nueva_Pers(E_Persona pers)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevaPers", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = pers.NombreP;

                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = pers.ApellidoP;

                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = pers.DocP;

                comando.Parameters.Add("Dir", MySqlDbType.VarChar).Value = pers.DireccionP;

                comando.Parameters.Add("Con", MySqlDbType.VarChar).Value = pers.ContactoP;

                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = pers.TipoP;

               

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
          
             // como proceso final
             finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return salida;
        }
    }
}

