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
using System.Xml;
using Newtonsoft.Json;

namespace WinPostman
{
    public partial class Form1 : Form
    {
        private DlgWait _dlgWait;
        public String PrettyFormatType
        {
            get
            {
                if (this.cbxPrintFormat.SelectedIndex > -1)
                {
                    return this.cbxPrintFormat.Items[this.cbxPrintFormat.SelectedIndex].ToString();
                }

                return string.Empty;       
            }
        }
        public String Title
        {
            get
            {
                return "Patton v.alpha 0.0.7";
            }
        }
        public String Host
        {
            get { return this.txtHost.Text.Trim(); }
            set { this.txtHost.Text = value; }
        }
        public String Uri
        {
            get { return this.txtUri.Text.Trim(); }
            set { this.txtUri.Text = value; }
        }

        public String BodyType
        {
            get
            {
                if (this.cbxBodyType.SelectedIndex < 0) return null;
                return this.cbxBodyType.Items[this.cbxBodyType.SelectedIndex].ToString();
            }
        }

        public HttpMethodEnum SelectedMethod
        {
            get
            {
                return (HttpMethodEnum)this.cbxHttpMethods.Items[this.cbxHttpMethods.SelectedIndex];
            }

            set
            {
                this.cbxHttpMethods.SelectedItem = value;

            }
        }

        public HttpContentType SelectedContentType
        {
            get
            {
                return (HttpContentType)this.cbxBodyType.Items[this.cbxBodyType.SelectedIndex];
            }

            set
            {
                if (value != null)
                {
                    this.cbxBodyType.SelectedIndex = this.cbxBodyType.FindStringExact(value.Name);
                }


            }
        }
        public Form1()
        {
            InitializeComponent();
            this._dlgWait = new DlgWait();
            this._dlgWait.Owner = this;
            this._dlgWait.StartPosition = FormStartPosition.Manual;


        }

        

        private void SaveConfig()
        {
            try
            {

                DialogResult result = saveConfigDialog.ShowDialog();

                if (result != DialogResult.OK) return;

                this.statusLabel.Text = "Saving config...";
                List<Attachment> attachments = GetAttachments();
                List<Header> headers = GetHeaders();
                List<Variable> variables = GetVariables();

                ConfigHelper config = new ConfigHelper();

                config.Headers = headers;
                config.Attachments = attachments;
                config.Variables = variables;
                config.Host = this.Host;
                config.Uri = this.Uri;
                config.Method = (HttpMethodEnum)this.cbxHttpMethods.Items[this.cbxHttpMethods.SelectedIndex];
                config.UseXmlSerializer = this.chkUseXmlSerializer.Checked;
                config.BodyRaw = this.txtBodyRaw.Text;
                config.BodyContentType = this.SelectedContentType;

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(config);

                File.WriteAllText(saveConfigDialog.FileName, json);

                this.statusLabel.Text = "Save done!";
                MessageBox.Show("Configuracion guardada exitosamente!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadConfig()
        {
            DialogResult result = openConfigFileDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            try
            {
                this.ClearForm();

                this.statusLabel.Text = "Loading config...";

                this.gvHeaders.Rows.Clear();
                this.gvFiles.Rows.Clear();


                string fileName = openConfigFileDialog.FileName;
                FileInfo finfo = new FileInfo(fileName);

                ConfigHelper configHelper = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigHelper>(File.ReadAllText(fileName));

                this.Text = string.Format("{0} - {1}", this.Title, finfo.Name);
                this.Host = configHelper.Host;
                this.Uri = configHelper.Uri;
                this.SelectedMethod = configHelper.Method;
                this.SelectedContentType = configHelper.BodyContentType;
                this.txtBodyRaw.Text = configHelper.BodyRaw;
                this.chkUseXmlSerializer.Checked = configHelper.UseXmlSerializer;


                if (configHelper.Headers != null)
                {
                    foreach (Header header in configHelper.Headers)
                    {
                        this.gvHeaders.Rows.Add(header.Text, header.Value);
                    }
                }


                if (configHelper.Attachments != null)
                {
                    foreach (Attachment attachment in configHelper.Attachments)
                    {
                        this.gvFiles.Rows.Add(attachment.FileName, attachment.MimeType, attachment.Data.Length, attachment);
                    }
                }


                if (configHelper.Variables != null)
                {
                    foreach (Variable variable in configHelper.Variables)
                    {
                        this.gvVariables.Rows.Add(variable.Name, variable.Value);
                    }
                }


                this.statusLabel.Text = "Load done!";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUrl()
        {
            Uri uriResult;
            string uriName = string.Format("{0}{1}",this.txtHost.Text,this.txtUri.Text);

            bool result = System.Uri.TryCreate(uriName, UriKind.Absolute, out uriResult);

            return result && (uriResult.Scheme.ToLower()== "http" || uriResult.Scheme.ToLower() == "https");
        }

        private List<Attachment> GetAttachments()
        {
            List<Attachment> attachments = new List<Attachment>();

            foreach (DataGridViewRow row in this.gvFiles.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null) continue;

                attachments.Add((Attachment)row.Cells[3].Value);
            }

            return attachments;

        }

        private List<Variable> GetVariables()
        {
            List<Variable> variables = new List<Variable>();

            if (this.gvVariables.Rows != null)
            {
                foreach (DataGridViewRow row in this.gvVariables.Rows)
                {
                    if (row.Cells[0].Value == null || row.Cells[1].Value == null) continue;

                    Variable h = new Variable()
                    {
                        Name = row.Cells[0].Value.ToString(),
                        Value = row.Cells[1].Value.ToString()
                    };

                    variables.Add(h);
                }
            }

            return variables;
        }

        private List<Header> GetHeaders()
        {
            List<Header> headers = new List<Header>();

            foreach (DataGridViewRow row in this.gvHeaders.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null) continue;

                Header h = new Header()
                {
                    Text = row.Cells[0].Value.ToString(),
                    Value = row.Cells[1].Value.ToString()
                };

                headers.Add(h);
            }

            return headers;

        }

        private Header GetHeader(DataGridViewRow row)
        {

            if (row.Cells[0].Value == null || row.Cells[1].Value == null) return null;

            return new Header()
            {
                Text = row.Cells[0].Value.ToString(),
                Value = row.Cells[1].Value.ToString()
            };

        }

        private Attachment GetAttachment(DataGridViewRow row)
        {

            if (row.Cells[0].Value == null || row.Cells[1].Value == null) return null;

            return (Attachment)row.Cells[3].Value;

        }

        private Variable GetVariable(DataGridViewRow row)
        {

            if (row.Cells[0].Value == null || row.Cells[1].Value == null) return null;

            return new Variable()
            {
                Name = row.Cells[0].Value.ToString(),
                Value = row.Cells[1].Value.ToString()
            };

        }

        private void SetAttachment(Attachment attachment, DataGridViewRow row)
        {
            //this.gvFiles.Rows.Add(attachment.FileName, attachment.MimeType, attachment.Data.Length, attachment);
            row.Cells[0].Value = attachment.FileName;
            row.Cells[2].Value = attachment.Data.Length;
            row.Cells[3].Value = attachment;
        }

        private void AddHeader(Header header)
        {
            this.gvHeaders.Rows.Add(header.Text, header.Value);
        }

        private void AddVariable(Variable variable)
        {
            this.gvVariables.Rows.Add(variable.Name, variable.Value);
        }

        private void ClearForm()
        {
            this.Text = string.Format("{0}", this.Title);
            this.txtBodyRaw.Text = string.Empty;
            this.Host = string.Empty;
            this.Uri = string.Empty;
            this.txtContent.Text = string.Empty;
            this.lbStatusCode.Text = string.Empty;
            this.cbxHttpMethods.SelectedIndex = 0;
            this.cbxBodyType.SelectedIndex = 0;
            this.gvHeaders.Rows.Clear();
            this.gvFiles.Rows.Clear();
            this.gvVariables.Rows.Clear();
        }

        private String ParseBody(string body)
        {
            List<Variable> variables = this.GetVariables();
            foreach (Variable variable in variables)
            {
                string varname = "{{" + variable.Name + "}}";
                body = body.Replace(varname, variable.Value);
            }
            return body;
        }
        private RestSharp.Method GetMethod()
        {
            HttpMethodEnum method = (HttpMethodEnum)this.cbxHttpMethods.Items[this.cbxHttpMethods.SelectedIndex];
            switch (method)
            {
                case HttpMethodEnum.GET:
                    return RestSharp.Method.GET;
                case HttpMethodEnum.POST:
                    return RestSharp.Method.POST;
                case HttpMethodEnum.PUT:
                    return Method.PUT;
                case HttpMethodEnum.PATCH:
                    return Method.PATCH;
                case HttpMethodEnum.DELETE:
                    return Method.DELETE;
                case HttpMethodEnum.HEAD:
                    return Method.HEAD;
                case HttpMethodEnum.MERGE:
                    return Method.MERGE;
                case HttpMethodEnum.OPTIONS:
                    return Method.OPTIONS;
            }

            return Method.GET;
        }
        private IRestRequest CreateRequest(String uri, RestSharp.Method method, string body, bool useXmlSerializer, List<Header> headers, List<Attachment> attachments)
        {
            var parsedUri = this.ParseBody(uri);
            var request = new RestRequest(parsedUri, method);
            request.AddHeader("Cache-Control", "no-cache");
            request.AddHeader("Origin", "chrome-extension://aicmkgpgakddgnaphhhpliifpcfhicfo");
            request.AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.99 Safari/537.36");
            request.AddHeader("Accept-Language", "es-ES,es;q=0.8");
            request.AddHeader("Accept", "*/*");



            foreach (Header header in headers)
            {
                string headerValue = header.Value;
                headerValue = this.ParseBody(headerValue);
                request.AddHeader(header.Text, headerValue);
            }

            foreach (Attachment attachment in attachments)
            {
                string fileName = attachment.FileName;
                fileName = this.ParseBody(fileName);
                request.AddFile(name: fileName, bytes: attachment.Data, fileName: fileName, contentType: attachment.MimeType);
            }

            if (useXmlSerializer)
            {
                request.XmlSerializer = new RestSharp.Serializers.DotNetXmlSerializer();
            }

            if (!string.IsNullOrEmpty(body))
            {
                body = ParseBody(body);

                HttpContentType content = this.SelectedContentType;

                request.AddParameter(content.Value, body, ParameterType.RequestBody);
                //switch (this.BodyType)
                //{
                //    case "XML":
                //        ///request.AddXmlBody(body);
                //        request.AddParameter("application/xml", body, ParameterType.RequestBody);
                //        break;

                //    case "JSON":
                //        //var b = JObject.Parse(body);

                //        //string sbody = Newtonsoft.Json.JsonConvert.SerializeObject(b);
                //        //var c = request.JsonSerializer.Serialize(b);
                //        //request.JsonSerializer = new RestSharp.Serializers.JsonSerializer();

                //        //request.RequestFormat = DataFormat.Json;
                //        //request.AddJsonBody(c);
                //        request.AddParameter("application/json", body, ParameterType.RequestBody);
                //        break;

                //    default:
                //        request.AddBody(body);
                //        break;
                //}

            }


            return request;
        }

        private void NewWorkspace()
        {
            DialogResult result = MessageBox.Show("Estás seguro de crear un nuevo espacio de trabajo ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                ClearForm();

            }
        }

        private void ShowLoadingWindow()
        {
            this._dlgWait.Show();

        }

        private void HideLoadingWindow()
        {
            if (this._dlgWait != null) this._dlgWait.Hide();
        }

        

        private void PrettyFormat(string prettyFormat)
        {
            switch (prettyFormat)
            {
                case "JSON":
                    PrettyJsonFormat();
                    break;
                case "XML":
                    PrettyXmlFormat();
                    break;
            }
        }

        private void PrettyJsonFormat()
        {
            try
            {
                string json = this.txtContent.Text.Trim();
                if (string.IsNullOrEmpty(json)) return;

                dynamic parsedJson = JsonConvert.DeserializeObject(json);
                this.txtContent.Text = JsonConvert.SerializeObject(parsedJson, Newtonsoft.Json.Formatting.Indented);
            }
            catch 
            {

            }
        }
        private void PrettyXmlFormat()
        {
            string xml = this.txtContent.Text.Trim();

            if (string.IsNullOrEmpty(xml)) return;

            try
            {
                MemoryStream mStream = new MemoryStream();
                XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
                XmlDocument document = new XmlDocument();

                try
                {
                    // Load the XmlDocument with the XML.
                    document.LoadXml(xml);

                    writer.Formatting = System.Xml.Formatting.Indented;

                    // Write the XML into a formatting XmlTextWriter
                    document.WriteContentTo(writer);
                    writer.Flush();
                    mStream.Flush();

                    // Have to rewind the MemoryStream in order to read
                    // its contents.
                    mStream.Position = 0;

                    // Read MemoryStream contents into a StreamReader.
                    StreamReader sReader = new StreamReader(mStream);

                    // Extract the text from the StreamReader.
                    String FormattedXML = sReader.ReadToEnd();

                    this.txtContent.Text = FormattedXML;
                }
                catch (XmlException)
                {
                }

                mStream.Close();
                writer.Close();
            }
            catch
            {

                
            }

        }
    }
}
