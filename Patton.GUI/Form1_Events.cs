using Newtonsoft.Json.Linq;
using Postman.Core;
using Postman.Core.Domain;
using Postman.Core.Enum;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WinPostman.Dialog;
using WinPostman.Helper;
using WinPostman.Extensions;
using WinPostman.Plugins;

namespace WinPostman
{
    public partial class Form1
    {
        #region Buttons
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;

            var fileChosed = openFileDialog1.FileName;
            var attachment = new Attachment
            {
                FileName = Path.GetFileName(fileChosed),
                MimeType = MimeMapping.GetMimeMapping(fileChosed),
                Data = File.ReadAllBytes(fileChosed)
            };



            this.gvFiles.Rows.Add(attachment.FileName, attachment.MimeType, attachment.Data.Length, attachment);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidUrl())
                {
                    MessageBox.Show("Url invalida.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.btnSend.Enabled = false;
                this.txtContent.Text = string.Empty;
                this.lbStatusCode.Text = string.Empty;
                this.statusLabel.Text = "Loading request...";

                List<Attachment> attachments = GetAttachments();
                List<Header> headers = GetHeaders();
                RestSharp.Method method = GetMethod();
                String bodyRow = this.txtBodyRaw.Text;
                var client = new RestClient(this.Host);
                var request = CreateRequest(this.Uri, method, bodyRow, chkUseXmlSerializer.Checked, headers, attachments);

                Tuple<RestClient, IRestRequest> valores = new Tuple<RestClient, IRestRequest>(client, request);
                this.ShowLoadingWindow();

                this.bwSendRequest.RunWorkerAsync(valores);

            }
            catch (Exception ex)
            {
                this.btnSend.Enabled = true;

                throw;
            }
        }

        private void btnGuardarConfig_Click(object sender, EventArgs e)
        {
            SaveConfig();

        }

        private void btnCargarConfig_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            this.txtContent.Text = string.Empty;
            this.lbStatusCode.Text = string.Empty;
        }

        private void btnAddHeader_Click(object sender, EventArgs e)
        {
            DlgHeader dlg = new DlgHeader();


            DialogResult result = dlg.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Header header = dlg.Value;
                this.AddHeader(header);
            }

        }

        private void btnRemoveHeader_Click(object sender, EventArgs e)
        {
            if (this.gvHeaders.SelectedRows != null && this.gvHeaders.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.gvHeaders.SelectedRows)
                {
                    if (row.Cells[0].Value == null || row.Cells[1].Value == null) continue;
                    this.gvHeaders.Rows.Remove(row);
                }
            }
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            if (this.gvFiles.SelectedRows != null && this.gvFiles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.gvFiles.SelectedRows)
                {
                    if (row.Cells[0].Value == null || row.Cells[1].Value == null) continue;
                    this.gvFiles.Rows.Remove(row);
                }
            }
        }

        private void btnSaveAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gvFiles.SelectedRows != null && this.gvFiles.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in this.gvFiles.SelectedRows)
                    {
                        if (row.Cells[0].Value == null || row.Cells[1].Value == null || (row.Cells[3].Value as Attachment) == null) continue;

                        Attachment attachment = row.Cells[3].Value as Attachment;

                        saveAttachmentDialog.FileName = attachment.FileName;
                        DialogResult result = saveAttachmentDialog.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            File.WriteAllBytes(saveAttachmentDialog.FileName, attachment.Data);
                            MessageBox.Show($"Attachment {attachment.FileName} save successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddVariable_Click(object sender, EventArgs e)
        {
            DlgVariable dlg = new DlgVariable();


            DialogResult result = dlg.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Variable variable = dlg.Value;
                this.AddVariable(variable);
            }
        }

        private void btnRemoveVariable_Click(object sender, EventArgs e)
        {
            if (this.gvVariables.SelectedRows != null && this.gvVariables.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.gvVariables.SelectedRows)
                {
                    if (row.Cells[0].Value == null || row.Cells[1].Value == null) continue;
                    this.gvVariables.Rows.Remove(row);
                }
            }
        }

        private void btnBuscarBody_Click(object sender, EventArgs e)
        {
            this.txtBodyRaw.HighlightText(this.txtBuscarBody.Text, System.Drawing.Color.Red, System.Drawing.Color.Blue);
        }
        #endregion

        #region BackgroundWorker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            Tuple<RestClient, IRestRequest> valores = (Tuple<RestClient, IRestRequest>)e.Argument;
            var client = valores.Item1;
            var request = valores.Item2;

            e.Result = client.Execute(request);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.HideLoadingWindow();
            this.btnSend.Enabled = true;

            if (e.Error == null)
            {
                IRestResponse response = (IRestResponse)e.Result;
                
                this.txtContent.Text = response.Content;
                this.lbStatusCode.Text = $"{(int)response.StatusCode} - {response.StatusCode.ToString()}";
                this.tabControl1.SelectedTab = tabPage4;
                this.statusLabel.Text = "Request done!";
                if (chkSaveResponse.Checked)
                {
                    DialogResult result = this.saveResponseDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string path = this.saveResponseDialog.FileName;
                        File.WriteAllBytes(path, response.RawBytes);
                        MessageBox.Show("Archivo almacenado exitosamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }

            this.PrettyFormat(this.PrettyFormatType);

        }
        #endregion

        #region GridView
        private void gvFiles_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && this.gvFiles.Rows.Count > 0 && e.ColumnIndex == -1)
            {
                DataGridViewRow row = this.gvFiles.Rows[e.RowIndex];
                Attachment attachment = this.GetAttachment(row);
                if (attachment == null) return;
                DlgAttachment dlg = new DlgAttachment();
                dlg.Value = attachment;
                DialogResult result = dlg.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    SetAttachment(dlg.Value, row);
                }
            }
        }

        private void gvHeaders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && this.gvHeaders.Rows.Count > 0 && e.ColumnIndex == -1)
            {

                DataGridViewRow row = this.gvHeaders.Rows[e.RowIndex];

                Header header = this.GetHeader(row);

                if (header == null) return;

                DlgHeader dlg = new DlgHeader();
                dlg.Value = header;

                DialogResult result = dlg.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    row.Cells[0].Value = dlg.Value.Text;
                    row.Cells[1].Value = dlg.Value.Value;
                }

            }
        } 
        #endregion

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void aboutPatonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DlgAbout about = new DlgAbout();
            about.ShowDialog();
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewWorkspace();

        }

        

        private void gvVariables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && this.gvHeaders.Rows.Count > 0 && e.ColumnIndex == -1)
            {

                DataGridViewRow row = this.gvVariables.Rows[e.RowIndex];

                Variable variable = this.GetVariable(row);

                if (variable == null) return;

                DlgVariable dlg = new DlgVariable();
                dlg.Value = variable;

                DialogResult result = dlg.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    row.Cells[0].Value = dlg.Value.Name;
                    row.Cells[1].Value = dlg.Value.Value;
                }

            }
        }

        private void tbarNew_Click(object sender, EventArgs e)
        {
            NewWorkspace();

        }

        private void tbarOpen_Click(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private void tbarSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        

        private void txtBuscarBody_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.txtBuscarBody.Text.Length == 0)
            {
                string text = this.txtBodyRaw.Text;
                this.txtBodyRaw.Clear();
                this.txtBodyRaw.Text = text;
            }
        }


        private void cbxPrintFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PrettyFormat(this.PrettyFormatType);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable lista = Enum_Method_Extensions.GetValues<HttpMethodEnum>();
            List<HttpContentType> mimes = new List<HttpContentType>();
            mimes.Add(new HttpContentType("JSON (application/json)", "application/json"));
            mimes.Add(new HttpContentType("XML (application/xml)", "application/xml"));
            mimes.Add(new HttpContentType("XML (text/xml)", "text/xml"));
            mimes.Add(new HttpContentType("HTML (text/html)", "text/html"));
            mimes.Add(new HttpContentType("Text (text/plain)", "text/plain"));

            this.cbxHttpMethods.DataSource = lista;
            progressBar1.Visible = false;
            this.Text = this.Title;
            this.cbxBodyType.DataSource = mimes;
            this.cbxBodyType.DisplayMember = "Name";
            this.cbxBodyType.SelectedIndex = 0;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
            "Close the window?",
            "Are you sure?",
            MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }

        private void csvGenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCsvGen frm = new FrmCsvGen();
            frm.Show(this);
        }

        private void xmlToCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXmlToCsv frm = new FrmXmlToCsv();
            frm.Show(this);
        }
    }
}
