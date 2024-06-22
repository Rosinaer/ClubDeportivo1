using ClubDeportivo1.Datos;
using ClubDeportivo1.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ClubDeportivo1
{
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
            // Carga DataGridView

            DataTable Tabla = new DataTable();
            MySqlDataReader resultado;
            MySqlConnection sqlCon = null;
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("SELECT * FROM persona", sqlCon);
                comando.CommandType = CommandType.Text;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }

            dgvListaPers.DataSource = Tabla;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }


        private void btnComprobante_Click(object sender, EventArgs e)
        {
            frmCarnet doc = new frmCarnet(); 
            doc.Show();
            this.Hide();
        }
        // BTN PAGO
        private void btnPago_Click(object sender, EventArgs e)
        {

            if (txtIDcliente.Text == "" || cmbTcliente.Text == "" ||
                cmbTcuota.Text == "" || txtMonto.Text == "" ||
                cboTpago.Text == "")
            {
                MessageBox.Show("Debe ingresar datos validos",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               int idPers = Convert.ToInt32(txtIDcliente.Text);


                // Comprueba que id exista y no haya pagado

                MySqlConnection sqlCon = null;
                {
                    try
                    {
                        // Crear y abrir la conexión
                        sqlCon = Conexion.getInstancia().CrearConexion();
                        if (sqlCon == null)
                        {
                            throw new Exception("No se pudo crear la conexión.");
                        }

                        sqlCon.Open();
                        string query = "SELECT COUNT(*) FROM pago WHERE IdPers = @IdPers;";
                        MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                        cmd.Parameters.AddWithValue("@IdPers", idPers);
                        
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 0)
                        {

                            // Insertar nuevo pago
                            E_Pago pago = new E_Pago();

                            Datos.D_Pago nuevoPago = new Datos.D_Pago();
                            nuevoPago.Nuevo_Pago(pago);


                            // DateTime FechaPago = DateTime.Now;
                            // decimal Monto = Convert.ToDecimal(txtMonto.Text.Trim());
                            // string Estado = "PAGADO";
                            // Cuota nuevaCuota = new Cuota(FechaPago, Monto, Estado);

                            // Consulta para obtener los datos del cliente
                            string queryDatos = @"SELECT p.NombreP, p.ApellidoP, pa.FechaPago, s.nroSocio
                                                    FROM persona p
                                                    INNER JOIN pago pa ON p.IdPers = pa.IdPers
                                                    LEFT JOIN socio s ON p.IdPers = s.IdPers
                                                    WHERE p.IdPers = @IdPers;";

                            MySqlCommand cmdDatos = new MySqlCommand(queryDatos, sqlCon);
                            cmdDatos.Parameters.AddWithValue("@IdPers", idPers);

                            MySqlDataReader reader = cmdDatos.ExecuteReader();
                            {
                                if (reader.HasRows)
                                {
                                    reader.Read();
                                    string nombre = reader.GetString("NombreP");
                                    string apellido = reader.GetString("ApellidoP");
                                    DateTime fechaPago = reader.GetDateTime("FechaPago");
                                    int nroSocio = reader.IsDBNull(reader.GetOrdinal("nroSocio")) ? 0 : reader.GetInt32("nroSocio");

                                    frmCarnet carnet = new frmCarnet
                                    {
                                        nombre_f = nombre,
                                        apellido_f = apellido,
                                        nrosocio_f = nroSocio,
                                        fecha_f = fechaPago
                                    };
                                    carnet.Show();
                              }

                        };


                         btnComprobante.Enabled = true;
                         MessageBox.Show("Pago registrado exitosamente.");

                        }
                        else
                        {
                            MessageBox.Show("El IdPers ya existe en la tabla de pagos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                    }
                    finally
                    {
                        if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                        {
                            sqlCon.Close();
                        }
                    }
                }
            }

        }


        private void dgvListaPers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int numero = e.RowIndex;


            if (numero != 1)
            {
                txtIDcliente.Text = Convert.ToString(dgvListaPers.Rows[numero].Cells[0].Value);
                // Int32 idper = Convert.ToInt32(dgvListaPers.CurrentRow.Cells[0].Value);


            }
        }

        private void dgvListaPers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) 
            {
                DataGridViewRow row = this.dgvListaPers.Rows[e.RowIndex];

                txtIDcliente.Text = row.Cells["IdPers"].Value.ToString();
                cmbTcliente.Text = row.Cells[6].Value.ToString();

            }
        }
    }
}
