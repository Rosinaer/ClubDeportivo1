namespace ClubDeportivo1
{
    partial class frmSocios
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
            dgvSocios = new DataGridView();
            dgvNosocios = new DataGridView();
            btnListSocios = new Button();
            btnListNosoc = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNosocios).BeginInit();
            SuspendLayout();
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.AllowUserToOrderColumns = true;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(14, 124);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowTemplate.Height = 25;
            dgvSocios.Size = new Size(273, 288);
            dgvSocios.TabIndex = 0;
            // 
            // dgvNosocios
            // 
            dgvNosocios.AllowUserToAddRows = false;
            dgvNosocios.AllowUserToDeleteRows = false;
            dgvNosocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNosocios.Location = new Point(403, 124);
            dgvNosocios.Name = "dgvNosocios";
            dgvNosocios.ReadOnly = true;
            dgvNosocios.RowTemplate.Height = 25;
            dgvNosocios.Size = new Size(273, 288);
            dgvNosocios.TabIndex = 1;
            // 
            // btnListSocios
            // 
            btnListSocios.Cursor = Cursors.Hand;
            btnListSocios.Location = new Point(14, 65);
            btnListSocios.Name = "btnListSocios";
            btnListSocios.Size = new Size(128, 41);
            btnListSocios.TabIndex = 2;
            btnListSocios.Text = "Lista Socios";
            btnListSocios.UseVisualStyleBackColor = true;
            btnListSocios.Click += btnListSocios_Click;
            // 
            // btnListNosoc
            // 
            btnListNosoc.Cursor = Cursors.Hand;
            btnListNosoc.Location = new Point(403, 65);
            btnListNosoc.Name = "btnListNosoc";
            btnListNosoc.Size = new Size(128, 41);
            btnListNosoc.TabIndex = 3;
            btnListNosoc.Text = "Lista No Socios";
            btnListNosoc.UseVisualStyleBackColor = true;
            btnListNosoc.Click += btnListNosoc_Click;
            // 
            // btnVolver
            // 
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Location = new Point(688, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(100, 32);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnListNosoc);
            Controls.Add(btnListSocios);
            Controls.Add(dgvNosocios);
            Controls.Add(dgvSocios);
            Name = "frmSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSocios";
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNosocios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSocios;
        private DataGridView dgvNosocios;
        private Button btnListSocios;
        private Button btnListNosoc;
        private Button btnVolver;
    }
}