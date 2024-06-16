namespace ClubDeportivo1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(181, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(71, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(225, 125);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(167, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(225, 171);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(167, 23);
            txtPass.TabIndex = 3;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(269, 236);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(79, 29);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(438, 336);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pictureBox1;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIngresar;
    }
}
