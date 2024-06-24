namespace ClubDeportivo1
{
    partial class frmInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            lblContacto = new Label();
            lblDocumento = new Label();
            cboTipo = new ComboBox();
            txtNombre = new TextBox();
            txtContacto = new TextBox();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            label1 = new Label();
            dgvPersonas = new DataGridView();
            idPers = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            nroDoc = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Contacto = new DataGridViewTextBoxColumn();
            Tcliente = new DataGridViewTextBoxColumn();
            fechareg = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(333, 59);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(133, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "INSCRIPCION";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(98, 131);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(72, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(429, 131);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(76, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "APELLIDO";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDireccion.Location = new Point(429, 182);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(74, 20);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Direccion";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblContacto.Location = new Point(104, 230);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(70, 20);
            lblContacto.TabIndex = 4;
            lblContacto.Text = "Contacto";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(98, 182);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(89, 20);
            lblDocumento.TabIndex = 5;
            lblDocumento.Text = "Documento";
            // 
            // cboTipo
            // 
            cboTipo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Socio", "No Socio" });
            cboTipo.Location = new Point(521, 231);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 28);
            cboTipo.TabIndex = 6;
            cboTipo.Text = "TIPO";
            cboTipo.SelectedIndexChanged += cboTipo_SelectedIndexChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(203, 132);
            txtNombre.MaxLength = 45;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(203, 231);
            txtContacto.MaxLength = 20;
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(162, 23);
            txtContacto.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(521, 183);
            txtDireccion.MaxLength = 80;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(162, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(521, 131);
            txtApellido.MaxLength = 45;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(162, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(203, 182);
            txtDocumento.MaxLength = 20;
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(162, 23);
            txtDocumento.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.Location = new Point(208, 322);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 32);
            btnIngresar.TabIndex = 7;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Location = new Point(359, 322);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Location = new Point(497, 322);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 32);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(429, 234);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 15;
            label1.Text = "Cliente";
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.AllowUserToOrderColumns = true;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { idPers, Nombre, Apellido, nroDoc, Direccion, Contacto, Tcliente, fechareg });
            dgvPersonas.Location = new Point(67, 369);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowTemplate.Height = 25;
            dgvPersonas.Size = new Size(743, 231);
            dgvPersonas.TabIndex = 16;
            dgvPersonas.CellContentClick += dgvPersonas_CellContentClick;
            // 
            // idPers
            // 
            idPers.HeaderText = "Id";
            idPers.Name = "idPers";
            idPers.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // nroDoc
            // 
            nroDoc.HeaderText = "Nro Doc";
            nroDoc.Name = "nroDoc";
            nroDoc.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Contacto
            // 
            Contacto.HeaderText = "Contacto";
            Contacto.Name = "Contacto";
            Contacto.ReadOnly = true;
            // 
            // Tcliente
            // 
            Tcliente.HeaderText = "Tipo Cliente";
            Tcliente.Name = "Tcliente";
            Tcliente.ReadOnly = true;
            // 
            // fechareg
            // 
            fechareg.HeaderText = "Fecha Registro";
            fechareg.Name = "fechareg";
            fechareg.ReadOnly = true;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(871, 612);
            Controls.Add(dgvPersonas);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtDireccion);
            Controls.Add(txtContacto);
            Controls.Add(txtNombre);
            Controls.Add(cboTipo);
            Controls.Add(lblDocumento);
            Controls.Add(lblContacto);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInscripcion";
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label lblContacto;
        private Label lblDocumento;
        private ComboBox cboTipo;
        private TextBox txtNombre;
        private TextBox txtContacto;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label label1;
        private DataGridView dgvPersonas;
        private DataGridViewTextBoxColumn idPers;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn nroDoc;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Contacto;
        private DataGridViewTextBoxColumn Tcliente;
        private DataGridViewTextBoxColumn fechareg;
    }
}