using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;


namespace ClubDeportivo1
{
    public partial class frmCarnet : Form
    {
        public frmCarnet()
        {
            InitializeComponent();
        }

        public string nombre_f;
        public string apellido_f;
        public int nrosocio_f;
        public DateTime fecha_f;

        private void lblCarnet_Click(object sender, EventArgs e)
        {

        }

        private void pCarnet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar carnet como PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                try
                {
                    GenerarPdf(filePath);
                    MessageBox.Show("Operación exitosa", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void GenerarPdf(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (PdfWriter writer = new PdfWriter(fs))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Añadir título
                        Paragraph title = new Paragraph("Carnet de Socio")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(20);
                        document.Add(title);

                        // Añadir contenido
                        document.Add(new Paragraph($"Nombre: {nombre_f}"));
                        document.Add(new Paragraph($"Apellido: {apellido_f}"));
                        document.Add(new Paragraph($"Número de Socio: {nrosocio_f}"));
                        document.Add(new Paragraph($"Fecha de Registro: {fecha_f:dd/MM/yyyy}"));

                        // Cerrar el documento
                        document.Close();
                    }
                }
            }
        }

        private void frmCarnet_Load_1(object sender, EventArgs e)
        {
            /* ----------------------------------------
            *   asignación de los valores a los datos
            *   que muestra cada etiqueta del diseño
            *   del comprobante de pago
            *   --------------------------------------------- */
            lblname.Text = nombre_f;
            lblApe.Text = apellido_f;
            lblReg.Text = fecha_f.ToString("dd/MM/yyyy");
            lblnroSocio.Text = Convert.ToString(nrosocio_f);

        }
    }
}
