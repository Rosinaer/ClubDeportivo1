namespace ClubDeportivo1
{
    partial class frmPagos
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
            lblBuscar = new Label();
            textBox1 = new TextBox();
            btnBuscar = new Button();
            cmbTcliente = new ComboBox();
            cmbTcuota = new ComboBox();
            lblTcliente = new Label();
            lblTpago = new Label();
            textBox2 = new TextBox();
            lblMonto = new Label();
            dgvListaPers = new DataGridView();
            txtIDcliente = new TextBox();
            lblIDcliente = new Label();
            btnPago = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaPers).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(53, 110);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(82, 15);
            lblBuscar.TabIndex = 18;
            lblBuscar.Text = "Buscar Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 23);
            textBox1.TabIndex = 19;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(348, 101);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(72, 33);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbTcliente
            // 
            cmbTcliente.FormattingEnabled = true;
            cmbTcliente.Items.AddRange(new object[] { "Socio", "No Socio" });
            cmbTcliente.Location = new Point(771, 135);
            cmbTcliente.Name = "cmbTcliente";
            cmbTcliente.Size = new Size(121, 23);
            cmbTcliente.TabIndex = 21;
            // 
            // cmbTcuota
            // 
            cmbTcuota.FormattingEnabled = true;
            cmbTcuota.Items.AddRange(new object[] { "Mensual", "Diaria" });
            cmbTcuota.Location = new Point(771, 194);
            cmbTcuota.Name = "cmbTcuota";
            cmbTcuota.Size = new Size(121, 23);
            cmbTcuota.TabIndex = 22;
            // 
            // lblTcliente
            // 
            lblTcliente.AutoSize = true;
            lblTcliente.Location = new Point(679, 143);
            lblTcliente.Name = "lblTcliente";
            lblTcliente.Size = new Size(86, 15);
            lblTcliente.TabIndex = 23;
            lblTcliente.Text = "Tipo de Cliente";
            // 
            // lblTpago
            // 
            lblTpago.AutoSize = true;
            lblTpago.Location = new Point(679, 197);
            lblTpago.Name = "lblTpago";
            lblTpago.Size = new Size(81, 15);
            lblTpago.TabIndex = 24;
            lblTpago.Text = "Tipo de Cuota";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(771, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 25;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(717, 250);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 26;
            lblMonto.Text = "Monto";
            // 
            // dgvListaPers
            // 
            dgvListaPers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPers.Location = new Point(53, 161);
            dgvListaPers.Name = "dgvListaPers";
            dgvListaPers.RowTemplate.Height = 25;
            dgvListaPers.Size = new Size(585, 196);
            dgvListaPers.TabIndex = 27;
            // 
            // txtIDcliente
            // 
            txtIDcliente.Location = new Point(771, 61);
            txtIDcliente.MaxLength = 11;
            txtIDcliente.Name = "txtIDcliente";
            txtIDcliente.Size = new Size(121, 23);
            txtIDcliente.TabIndex = 28;
            // 
            // lblIDcliente
            // 
            lblIDcliente.AutoSize = true;
            lblIDcliente.Location = new Point(694, 64);
            lblIDcliente.Name = "lblIDcliente";
            lblIDcliente.Size = new Size(57, 15);
            lblIDcliente.TabIndex = 29;
            lblIDcliente.Text = "Id Cliente";
            // 
            // btnPago
            // 
            btnPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPago.Location = new Point(710, 302);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(192, 55);
            btnPago.TabIndex = 30;
            btnPago.Text = "Realizar Cobro";
            btnPago.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(836, 406);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 32);
            btnVolver.TabIndex = 31;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(959, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnPago);
            Controls.Add(lblIDcliente);
            Controls.Add(txtIDcliente);
            Controls.Add(dgvListaPers);
            Controls.Add(lblMonto);
            Controls.Add(textBox2);
            Controls.Add(lblTpago);
            Controls.Add(lblTcliente);
            Controls.Add(cmbTcuota);
            Controls.Add(cmbTcliente);
            Controls.Add(btnBuscar);
            Controls.Add(textBox1);
            Controls.Add(lblBuscar);
            Name = "frmPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPagos";
            Load += frmPagos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaPers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBuscar;
        private TextBox textBox1;
        private Button btnBuscar;
        private ComboBox cmbTcliente;
        private ComboBox cmbTcuota;
        private Label lblTcliente;
        private Label lblTpago;
        private TextBox textBox2;
        private Label lblMonto;
        private DataGridView dgvListaPers;
        private TextBox txtIDcliente;
        private Label lblIDcliente;
        private Button btnPago;
        private Button btnVolver;
    }
}