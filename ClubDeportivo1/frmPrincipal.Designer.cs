namespace ClubDeportivo1
{
    partial class frmPrincipal
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
            lblIngreso = new Label();
            btnInscribir = new Button();
            btnAsignar_Actividad = new Button();
            btnPagar_Cuota = new Button();
            btnEmitir_Comprobante = new Button();
            btnEmitir_Carnet = new Button();
            btnSalir = new Button();
            chkApto_Fisico = new CheckBox();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.BackColor = Color.Transparent;
            lblIngreso.ForeColor = Color.Black;
            lblIngreso.Location = new Point(34, 19);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(50, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Tag = "";
            lblIngreso.Text = "Usuario:";
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.FromArgb(255, 255, 192);
            btnInscribir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.Location = new Point(86, 91);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(136, 40);
            btnInscribir.TabIndex = 1;
            btnInscribir.Text = "INSCRIBIR";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnAsignar_Actividad
            // 
            btnAsignar_Actividad.BackColor = Color.FromArgb(255, 255, 192);
            btnAsignar_Actividad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignar_Actividad.Location = new Point(351, 91);
            btnAsignar_Actividad.Name = "btnAsignar_Actividad";
            btnAsignar_Actividad.Size = new Size(136, 40);
            btnAsignar_Actividad.TabIndex = 2;
            btnAsignar_Actividad.Text = "ASIGNAR ACTIVIDAD";
            btnAsignar_Actividad.UseVisualStyleBackColor = false;
            // 
            // btnPagar_Cuota
            // 
            btnPagar_Cuota.BackColor = Color.FromArgb(255, 255, 192);
            btnPagar_Cuota.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar_Cuota.Location = new Point(86, 186);
            btnPagar_Cuota.Name = "btnPagar_Cuota";
            btnPagar_Cuota.Size = new Size(136, 40);
            btnPagar_Cuota.TabIndex = 3;
            btnPagar_Cuota.Text = "PAGAR CUOTA";
            btnPagar_Cuota.UseVisualStyleBackColor = false;
            btnPagar_Cuota.Click += btnPagar_Cuota_Click;
            // 
            // btnEmitir_Comprobante
            // 
            btnEmitir_Comprobante.BackColor = Color.FromArgb(255, 255, 192);
            btnEmitir_Comprobante.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmitir_Comprobante.Location = new Point(351, 186);
            btnEmitir_Comprobante.Name = "btnEmitir_Comprobante";
            btnEmitir_Comprobante.Size = new Size(136, 40);
            btnEmitir_Comprobante.TabIndex = 4;
            btnEmitir_Comprobante.Text = "EMITIR COMPROBANTE";
            btnEmitir_Comprobante.UseVisualStyleBackColor = false;
            // 
            // btnEmitir_Carnet
            // 
            btnEmitir_Carnet.BackColor = Color.FromArgb(255, 255, 192);
            btnEmitir_Carnet.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmitir_Carnet.Location = new Point(351, 286);
            btnEmitir_Carnet.Name = "btnEmitir_Carnet";
            btnEmitir_Carnet.Size = new Size(136, 40);
            btnEmitir_Carnet.TabIndex = 5;
            btnEmitir_Carnet.Text = "EMITIR CARNET";
            btnEmitir_Carnet.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 255, 192);
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(224, 378);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 32);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // chkApto_Fisico
            // 
            chkApto_Fisico.AutoSize = true;
            chkApto_Fisico.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkApto_Fisico.Location = new Point(129, 307);
            chkApto_Fisico.Name = "chkApto_Fisico";
            chkApto_Fisico.Size = new Size(97, 19);
            chkApto_Fisico.TabIndex = 7;
            chkApto_Fisico.Text = "APTO FISICO";
            chkApto_Fisico.UseVisualStyleBackColor = true;
            chkApto_Fisico.CheckedChanged += chkApto_Fisico_CheckedChanged;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(574, 450);
            Controls.Add(chkApto_Fisico);
            Controls.Add(btnSalir);
            Controls.Add(btnEmitir_Carnet);
            Controls.Add(btnEmitir_Comprobante);
            Controls.Add(btnPagar_Cuota);
            Controls.Add(btnAsignar_Actividad);
            Controls.Add(btnInscribir);
            Controls.Add(lblIngreso);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Button btnInscribir;
        private Button btnAsignar_Actividad;
        private Button btnPagar_Cuota;
        private Button btnEmitir_Comprobante;
        private Button btnEmitir_Carnet;
        private Button btnSalir;
        private CheckBox chkApto_Fisico;
    }
}