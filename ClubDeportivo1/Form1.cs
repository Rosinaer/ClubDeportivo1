using System.Data;

namespace ClubDeportivo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /* este evento se ejecuta cuando llega el foco */

            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /*este evento se ejecuta cuando llega el foco */
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {

            if (txtPass.Text == "CONTRASE�A")
                txtPass.Text = "";
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
                txtPass.Text = "CONTRASE�A";
            txtPass.UseSystemPasswordChar = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los Datos desde el formulario

            Datos.Usuario dato = new Datos.Usuario(); // variable que contiene todas las caracteristicas de la clase

            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtPass.Text);

            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                MessageBox.Show("Ingreso exitoso", "MENSAJES DEL SISTEMA",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPrincipal Principal = new frmPrincipal();

                 Principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                 Principal.usuario = Convert.ToString(txtUsuario.Text);

                Principal.Show(); // se llama al formulario principal
                this.Hide(); // se oculta el formulario del login

            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
