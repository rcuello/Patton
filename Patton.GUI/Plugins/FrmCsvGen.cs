using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPostman.Plugins
{
    public partial class FrmCsvGen : Form
    {
        public FrmCsvGen()
        {
            InitializeComponent();
        }

        private void FrmCsvGen_Load(object sender, EventArgs e)
        {
            this.txtFechaEmision.Text = DateTime.Now.ToString("yyyy-MM-dd");
            this.txtFechaVence.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                this.toolStripStatusLabel1.Text = "Generating files...";

                StringBuilder strHeader = new StringBuilder();
                StringBuilder strDetail = new StringBuilder();

                string header = this.txtHeader.Text.Trim();
                string detail = this.txtDetail.Text.Trim();

                long rangoInicial = Convert.ToInt64(nudRangoInicial.Value);
                long rangoFinal = Convert.ToInt64(nudRangoFinal.Value);

                string fechaEmision = this.txtFechaEmision.Text;
                string fechaVence = this.txtFechaVence.Text;
                string comprador = this.txtComprador.Text;
                string contacto = this.txtContacto.Text;
                string contactoEmail = this.txtContactoEmail.Text;
                string prefijo = this.txtPrefijo.Text.Trim();
                string compradorNit = this.txtCompradorNit.Text.Trim();
                header = header.Replace("{{FECHA_EMISION}}", fechaEmision);
                header = header.Replace("{{FECHA_VENCE}}", fechaVence);
                header = header.Replace("{{COMPRADOR}}", comprador);
                header = header.Replace("{{CONTACTO_EMAIL}}", contactoEmail);
                header = header.Replace("{{CONTACTO}}", contacto);
                header = header.Replace("{{COMPRADOR_NIT}}", compradorNit);

                for (long i = rangoInicial; i <= rangoFinal; i++)
                {
                    
                    string item = header.Replace("{{NUMERO_FACTURA}}", string.Format("{0}{1}", prefijo, i));
                    string itemDetail = detail.Replace("{{NUMERO_FACTURA}}", string.Format("{0}{1}", prefijo, i));

                    strHeader.Append(item);
                    strHeader.AppendFormat("{0}", Environment.NewLine);

                    strDetail.Append(itemDetail);
                    strDetail.AppendFormat("{0}", Environment.NewLine);
                }

                this.saveFileDialog1.FileName = "Header.csv";

                this.toolStripStatusLabel1.Text = "Generating header...";
                DialogResult result = this.saveFileDialog1.ShowDialog();
                bool savedHeader = false;
                bool savedDetail = false;

                if (result == DialogResult.OK)
                {
                    File.WriteAllText(this.saveFileDialog1.FileName, strHeader.ToString()) ;
                    this.toolStripStatusLabel1.Text = "Header OK!";
                    savedHeader = true;
                }

                this.saveFileDialog1.FileName = "Detail.csv";

                this.toolStripStatusLabel1.Text = "Generating detail...";

                DialogResult result2 = this.saveFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    
                    File.WriteAllText(this.saveFileDialog1.FileName, strDetail.ToString());
                    this.toolStripStatusLabel1.Text = "Detail OK!";
                    savedDetail = true;
                }

                if(savedHeader || savedDetail)
                {
                    MessageBox.Show("Archivo generado exitosamente", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FileInfo dir = new FileInfo(this.saveFileDialog1.FileName);
                    
                    Process.Start(dir.DirectoryName);

                }
                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
