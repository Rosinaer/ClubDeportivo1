using ClubDeportivo1.Datos;
using ClubDeportivo1.Entidades;
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
            MySqlConnection sqlCon = new MySqlConnection();
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
    }
}
