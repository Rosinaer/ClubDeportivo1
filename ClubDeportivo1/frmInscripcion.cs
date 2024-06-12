using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClubDeportivo1.Entidades;
using ClubDeportivo1.Datos;
using MySql.Data.MySqlClient;

namespace ClubDeportivo1
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTipo.Items.Add("Socio");
            cboTipo.Items.Add("No Socio");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
               txtDocumento.Text == "" || txtDireccion.Text == "" ||
               txtContacto.Text == "" || cboTipo.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Persona pers = new E_Persona();
                pers.NombreP = txtNombre.Text;
                pers.ApellidoP = txtApellido.Text;
                pers.DocP = Convert.ToInt32(txtDocumento.Text);
                pers.TipoP = cboTipo.Text;

                // instanciamos para usar el metodo dentro de persona
                Datos.Persona persona = new Datos.Persona();
                respuesta = persona.Nueva_Pers(pers);
                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("LA PERSONA YA EXISTE", "AVISO DEL  SISTEMA",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("se almaceno con exito con el codigo Nro " +
                         respuesta, "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            cboTipo.Text = "";
            txtNombre.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }
       
    }
}

