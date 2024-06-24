namespace ClubDeportivo1
{
    partial class frmCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnet));
            pCarnet = new Panel();
            lblClub = new Label();
            panel1 = new Panel();
            lblApe = new Label();
            pictureBox1 = new PictureBox();
            lblnroSocio = new Label();
            lblSocio = new Label();
            lblReg = new Label();
            lblCfec = new Label();
            lblname = new Label();
            lblCarnetSocio = new Label();
            btnPrint = new Button();
            btnCarnetSalir = new Button();
            pCarnet.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pCarnet
            // 
            pCarnet.BackColor = Color.Cornsilk;
            pCarnet.Controls.Add(lblClub);
            pCarnet.Location = new Point(0, 0);
            pCarnet.Name = "pCarnet";
            pCarnet.Size = new Size(459, 58);
            pCarnet.TabIndex = 0;
            pCarnet.Paint += pCarnet_Paint;
            // 
            // lblClub
            // 
            lblClub.AutoSize = true;
            lblClub.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblClub.Location = new Point(170, 21);
            lblClub.Name = "lblClub";
            lblClub.Size = new Size(126, 21);
            lblClub.TabIndex = 0;
            lblClub.Text = "Club Deportivo";
            lblClub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblApe);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblnroSocio);
            panel1.Controls.Add(lblSocio);
            panel1.Controls.Add(lblReg);
            panel1.Controls.Add(lblCfec);
            panel1.Controls.Add(lblname);
            panel1.Controls.Add(lblCarnetSocio);
            panel1.Location = new Point(5, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 142);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblApe.Location = new Point(68, 63);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(34, 17);
            lblApe.TabIndex = 8;
            lblApe.Text = "Katz";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(302, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblnroSocio
            // 
            lblnroSocio.AutoSize = true;
            lblnroSocio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblnroSocio.Location = new Point(245, 48);
            lblnroSocio.Name = "lblnroSocio";
            lblnroSocio.Size = new Size(35, 15);
            lblnroSocio.TabIndex = 6;
            lblnroSocio.Text = "1039";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(177, 48);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(62, 15);
            lblSocio.TabIndex = 5;
            lblSocio.Text = "Nro Socio:";
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.Location = new Point(177, 90);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(65, 15);
            lblReg.TabIndex = 4;
            lblReg.Text = "20/04/2024";
            // 
            // lblCfec
            // 
            lblCfec.AutoSize = true;
            lblCfec.Location = new Point(68, 90);
            lblCfec.Name = "lblCfec";
            lblCfec.Size = new Size(84, 15);
            lblCfec.TabIndex = 3;
            lblCfec.Text = "Fecha Registro";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblname.Location = new Point(68, 46);
            lblname.Name = "lblname";
            lblname.Size = new Size(40, 17);
            lblname.TabIndex = 2;
            lblname.Text = "Alina";
            // 
            // lblCarnetSocio
            // 
            lblCarnetSocio.AutoSize = true;
            lblCarnetSocio.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarnetSocio.Location = new Point(160, 0);
            lblCarnetSocio.Name = "lblCarnetSocio";
            lblCarnetSocio.Size = new Size(131, 21);
            lblCarnetSocio.TabIndex = 1;
            lblCarnetSocio.Text = "Carnet De Socio";
            lblCarnetSocio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(351, 269);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(92, 25);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "Imprimir";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnCarnetSalir
            // 
            btnCarnetSalir.BackColor = Color.FromArgb(255, 255, 192);
            btnCarnetSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCarnetSalir.Location = new Point(193, 262);
            btnCarnetSalir.Name = "btnCarnetSalir";
            btnCarnetSalir.Size = new Size(104, 32);
            btnCarnetSalir.TabIndex = 7;
            btnCarnetSalir.Text = "Volver";
            btnCarnetSalir.UseVisualStyleBackColor = false;
            btnCarnetSalir.Click += btnSalir_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(471, 317);
            Controls.Add(btnCarnetSalir);
            Controls.Add(btnPrint);
            Controls.Add(pCarnet);
            Controls.Add(panel1);
            Name = "frmCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarnet";
            Load += frmCarnet_Load_1;
            pCarnet.ResumeLayout(false);
            pCarnet.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pCarnet;
        private Label lblClub;
        private Panel panel1;
        private Label lblCarnetSocio;
        private Label lblname;
        private Label lblnroSocio;
        private Label lblSocio;
        private Label lblReg;
        private Label lblCfec;
        private Button btnPrint;
        private PictureBox pictureBox1;
        private Label lblApe;
        private Button btnCarnetSalir;
    }
}