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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        internal string? rol;
        internal string? usuario;


        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();

            inscripcion.Show();
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkApto_Fisico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkApto_Fisico.Checked)
            {
                btnInscribir.Enabled = true;
                btnAsignar_Actividad.Enabled = true;
                btnPagar_Cuota.Enabled = true;
                btnEmitir_Comprobante.Enabled = true;
                btnEmitir_Carnet.Enabled = false;
            }
           
            else
            {
                btnInscribir.Enabled = false;
                btnAsignar_Actividad.Enabled = false;
                btnPagar_Cuota.Enabled = false;
                btnEmitir_Comprobante.Enabled = false;
                btnEmitir_Carnet.Enabled = false;
            }
        }
    }
}
