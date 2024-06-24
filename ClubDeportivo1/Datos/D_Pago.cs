using ClubDeportivo1.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo1.Datos
{
    internal class D_Pago
    {
        public string Nuevo_Pago(E_Pago pago)
        {
            string Rpta = "";
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // Todavia no investigue como realizar el insert a la tabla cuota luego del insert a la tabla pago
                sqlCon = Conexion.getInstancia().CrearConexion();


                string query = "INSERT INTO Pago (IdPers, Monto, FechaPago, TipoPago) VALUES (@IdPers, @Monto, @FechaPago,@tipoPago)";
               // string query2 = "INSERT INTO Cuota (FechaPagoC, TipoCuota,Monto,Estado,idPers) VALUES (@FechaPago, @TipoCuota, @Monto, @Estado, @IdPers)";


                MySqlCommand comando = new MySqlCommand(query, sqlCon);
              
                {
                    comando.Parameters.AddWithValue("@IdPers", pago.idPers);
                    comando.Parameters.AddWithValue("@Monto", pago.monto);
                    comando.Parameters.AddWithValue("@FechaPago", pago.fechaPago);
                    comando.Parameters.AddWithValue("@tipoPago", pago.tipoPago);

                    //  MySqlCommand comando2 = new MySqlCommand(query2, sqlCon);
                    //  comando.Parameters.AddWithValue("@TipoCuota", cuota.TipoCuota);
                    //  comando.Parameters.AddWithValue("@Estado", cuota.Estado);

                    //comando2.Parameters.AddWithValue("@FechaPago", cuota.FechaPagoC);
                    //comando2.Parameters.AddWithValue("@TipoCuota", cuota.TipoCuota);
                    //comando2.Parameters.AddWithValue("@Monto", cuota.Monto);
                    //comando2.Parameters.AddWithValue("@Estado", cuota.Estado);
                    // comando2.Parameters.AddWithValue("@idPago", cuota.idPago);
                    //comando2.Parameters.AddWithValue("@IdPers", cuota.IdPers);

                    sqlCon.Open();
                    int rowsAffected = comando.ExecuteNonQuery();
                    //int rowsAffected2 = comando2.ExecuteNonQuery();
                    if (rowsAffected >= 1)
                    {

                        MessageBox.Show("Pago Registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Rpta = "Pago Registrado";
                        //DialogResult resultado = MessageBox.Show("Desea realizar otro pago?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //if(resultado == DialogResult.Yes)
                        //{                           

                        //}
                        //else
                        //{
                        //    Principal principal = new Principal();
                        //    principal.Show();                            
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al registrar el Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Rpta = "Ocurrio un error al registrar el Pago";

                    }
                }

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }

            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return Rpta;

        }

    }
}
