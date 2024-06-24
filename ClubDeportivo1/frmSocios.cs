using ClubDeportivo1.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo1
{
    public partial class frmSocios : Form
    {
        public frmSocios()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnListNosoc_Click(object sender, EventArgs e)
        {

        }

        private void btnListSocios_Click(object sender, EventArgs e)
        {
            dgvSocios.AutoGenerateColumns = false;

            // Carga DataGridView           

            DataTable Tabla = new DataTable();
            MySqlDataReader resultado;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query = "SELECT * FROM persona WHERE TipoP ='Socio'";
                            

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            dgvSocios.DataSource = Tabla;
        }

    }
}

