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
        private void InitializeComboBoxes()
        {
            // Inicializar ComboBoxes
            cmbTcliente.Items.AddRange(new object[] { "Socio", "No Socio" });
            cmbTcuota.Items.AddRange(new object[] { "Mensual", "Diaria" });
        }

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si el tipo de cliente es Socio, selecciona la cuota Mensual
            if (cmbTcliente.SelectedItem != null && cmbTcliente.SelectedItem.ToString() == "Socio")
            {
                cmbTcuota.SelectedItem = "Mensual";
            }
            else
            {
                cmbTcuota.SelectedItem = null; // Resetea la selección si es necesario
            }
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
            frmCarnet carnet = new frmCarnet();
            carnet.Show();
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
                // Comprueba que id exista y no haya pagado
                int idPers = Convert.ToInt32(txtIDcliente.Text);
                MySqlConnection sqlCon = null;
                try
                {
                    // Crear y abrir la conexión
                    sqlCon = Conexion.getInstancia().CrearConexion();
                    //if (sqlCon == null)
                    //{
                    //    throw new Exception("No se pudo crear la conexión.");
                    //}

                    sqlCon.Open();
                    string query = "SELECT COUNT(*) FROM pago WHERE IdPers = @IdPers;";
                    MySqlCommand cmd = new MySqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@IdPers", idPers);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 0)
                    {
                        

                        // Consulta para obtener los datos del cliente y mostralo en el carnet
                        string queryDatos = @"SELECT p.NombreP, p.ApellidoP, pa.FechaPago, s.nroSocio
                                                    FROM persona p
                                                    INNER JOIN pago pa ON p.IdPers = pa.IdPers
                                                    LEFT JOIN socio s ON p.IdPers = s.IdPers
                                                    WHERE p.IdPers = @IdPers;";

                        MySqlCommand cmdDatos = new MySqlCommand(queryDatos, sqlCon);
                        cmdDatos.Parameters.AddWithValue("@IdPers", idPers);

                        MySqlDataReader reader = cmdDatos.ExecuteReader();

                        // Insertar nuevo pago
                        E_Pago pago = new E_Pago();
                        pago.idPers = Convert.ToInt32(txtIDcliente.Text.Trim());
                        pago.monto = Convert.ToDecimal(txtMonto.Text.Trim());
                        pago.tipoPago = cboTpago.Text.Trim();
                        pago.fechaPago = DateTime.Now;

                        Datos.D_Pago nuevoPago = new Datos.D_Pago();
                        nuevoPago.Nuevo_Pago(pago);

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


                            // carnet.Show();
                        }
                        
                        MessageBox.Show("Pago registrado exitosamente.");
                        btnComprobante.Enabled = true;                        

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


        private void dgvListaPers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //int numero = e.RowIndex;


            //if (numero != 1)
            //{
            //    txtIDcliente.Text = Convert.ToString(dgvListaPers.Rows[numero].Cells[0].Value);
            //    // Int32 idper = Convert.ToInt32(dgvListaPers.CurrentRow.Cells[0].Value);
            //}
            //else
            //{
            //    MessageBox.Show("selecciono el ENCABEZADO");
            //}

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvListaPers.Rows[e.RowIndex];

                txtIDcliente.Text = row.Cells["IdPers"].Value.ToString();
                cmbTcliente.SelectedItem = row.Cells["TipoP"].Value.ToString();

            }
            else
            {
                MessageBox.Show("selecciono el ENCABEZADO");
            }
        }

        private void dgvListaPers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dgvListaPers.Rows[e.RowIndex];

            //    txtIDcliente.Text = row.Cells["IdPers"].Value.ToString();
            //    cmbTcliente.SelectedItem = row.Cells["TipoP"].Value.ToString();

            //}
            //else
            //{
            //    MessageBox.Show("selecciono el ENCABEZADO");
            //}

        }

        private void txtIDcliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
