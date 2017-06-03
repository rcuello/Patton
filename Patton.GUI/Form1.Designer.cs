namespace WinPostman
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbxHttpMethods = new System.Windows.Forms.ComboBox();
            this.txtUri = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnRemoveVariable = new System.Windows.Forms.Button();
            this.btnAddVariable = new System.Windows.Forms.Button();
            this.gvVariables = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRemoveHeader = new System.Windows.Forms.Button();
            this.btnAddHeader = new System.Windows.Forms.Button();
            this.gvHeaders = new System.Windows.Forms.DataGridView();
            this.colHeaderText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeaderValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveAttachment = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.chkUseXmlSerializer = new System.Windows.Forms.CheckBox();
            this.gvFiles = new System.Windows.Forms.DataGridView();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMimeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBuscarBody = new System.Windows.Forms.Button();
            this.txtBuscarBody = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBodyType = new System.Windows.Forms.ComboBox();
            this.txtBodyRaw = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbxPrintFormat = new System.Windows.Forms.ComboBox();
            this.chkSaveResponse = new System.Windows.Forms.CheckBox();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.lbStatusCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.saveConfigDialog = new System.Windows.Forms.SaveFileDialog();
            this.openConfigFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutPatonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbarNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tbarOpen = new System.Windows.Forms.ToolStripButton();
            this.tbarSave = new System.Windows.Forms.ToolStripButton();
            this.bwSendRequest = new System.ComponentModel.BackgroundWorker();
            this.saveAttachmentDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveResponseDialog = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVariables)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHeaders)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxHttpMethods
            // 
            this.cbxHttpMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHttpMethods.FormattingEnabled = true;
            this.cbxHttpMethods.Location = new System.Drawing.Point(16, 54);
            this.cbxHttpMethods.Name = "cbxHttpMethods";
            this.cbxHttpMethods.Size = new System.Drawing.Size(87, 21);
            this.cbxHttpMethods.TabIndex = 0;
            // 
            // txtUri
            // 
            this.txtUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUri.Location = new System.Drawing.Point(348, 55);
            this.txtUri.Name = "txtUri";
            this.txtUri.Size = new System.Drawing.Size(513, 20);
            this.txtUri.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 109);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 420);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnRemoveVariable);
            this.tabPage5.Controls.Add(this.btnAddVariable);
            this.tabPage5.Controls.Add(this.gvVariables);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(932, 394);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Custom Variables";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnRemoveVariable
            // 
            this.btnRemoveVariable.Location = new System.Drawing.Point(134, 9);
            this.btnRemoveVariable.Name = "btnRemoveVariable";
            this.btnRemoveVariable.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveVariable.TabIndex = 5;
            this.btnRemoveVariable.Text = "Remove";
            this.btnRemoveVariable.UseVisualStyleBackColor = true;
            this.btnRemoveVariable.Click += new System.EventHandler(this.btnRemoveVariable_Click);
            // 
            // btnAddVariable
            // 
            this.btnAddVariable.Location = new System.Drawing.Point(6, 9);
            this.btnAddVariable.Name = "btnAddVariable";
            this.btnAddVariable.Size = new System.Drawing.Size(122, 23);
            this.btnAddVariable.TabIndex = 4;
            this.btnAddVariable.Text = "Add";
            this.btnAddVariable.UseVisualStyleBackColor = true;
            this.btnAddVariable.Click += new System.EventHandler(this.btnAddVariable_Click);
            // 
            // gvVariables
            // 
            this.gvVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.gvVariables.Location = new System.Drawing.Point(3, 38);
            this.gvVariables.Name = "gvVariables";
            this.gvVariables.Size = new System.Drawing.Size(926, 237);
            this.gvVariables.TabIndex = 3;
            this.gvVariables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvVariables_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRemoveHeader);
            this.tabPage1.Controls.Add(this.btnAddHeader);
            this.tabPage1.Controls.Add(this.gvHeaders);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(932, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Headers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRemoveHeader
            // 
            this.btnRemoveHeader.Location = new System.Drawing.Point(134, 10);
            this.btnRemoveHeader.Name = "btnRemoveHeader";
            this.btnRemoveHeader.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveHeader.TabIndex = 2;
            this.btnRemoveHeader.Text = "Remove";
            this.btnRemoveHeader.UseVisualStyleBackColor = true;
            this.btnRemoveHeader.Click += new System.EventHandler(this.btnRemoveHeader_Click);
            // 
            // btnAddHeader
            // 
            this.btnAddHeader.Location = new System.Drawing.Point(6, 10);
            this.btnAddHeader.Name = "btnAddHeader";
            this.btnAddHeader.Size = new System.Drawing.Size(122, 23);
            this.btnAddHeader.TabIndex = 1;
            this.btnAddHeader.Text = "Add";
            this.btnAddHeader.UseVisualStyleBackColor = true;
            this.btnAddHeader.Click += new System.EventHandler(this.btnAddHeader_Click);
            // 
            // gvHeaders
            // 
            this.gvHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHeaderText,
            this.colHeaderValue});
            this.gvHeaders.Location = new System.Drawing.Point(3, 39);
            this.gvHeaders.Name = "gvHeaders";
            this.gvHeaders.Size = new System.Drawing.Size(926, 346);
            this.gvHeaders.TabIndex = 0;
            this.gvHeaders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHeaders_CellDoubleClick);
            // 
            // colHeaderText
            // 
            this.colHeaderText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHeaderText.HeaderText = "Header";
            this.colHeaderText.Name = "colHeaderText";
            // 
            // colHeaderValue
            // 
            this.colHeaderValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHeaderValue.HeaderText = "Value";
            this.colHeaderValue.Name = "colHeaderValue";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveAttachment);
            this.tabPage2.Controls.Add(this.btnRemoveFile);
            this.tabPage2.Controls.Add(this.chkUseXmlSerializer);
            this.tabPage2.Controls.Add(this.gvFiles);
            this.tabPage2.Controls.Add(this.btnLoadFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(932, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attachment";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveAttachment
            // 
            this.btnSaveAttachment.Location = new System.Drawing.Point(272, 7);
            this.btnSaveAttachment.Name = "btnSaveAttachment";
            this.btnSaveAttachment.Size = new System.Drawing.Size(122, 23);
            this.btnSaveAttachment.TabIndex = 4;
            this.btnSaveAttachment.Text = "Save attachment";
            this.btnSaveAttachment.UseVisualStyleBackColor = true;
            this.btnSaveAttachment.Click += new System.EventHandler(this.btnSaveAttachment_Click);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(135, 7);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveFile.TabIndex = 3;
            this.btnRemoveFile.Text = "Remove";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFile_Click);
            // 
            // chkUseXmlSerializer
            // 
            this.chkUseXmlSerializer.AutoSize = true;
            this.chkUseXmlSerializer.Location = new System.Drawing.Point(809, 11);
            this.chkUseXmlSerializer.Name = "chkUseXmlSerializer";
            this.chkUseXmlSerializer.Size = new System.Drawing.Size(107, 17);
            this.chkUseXmlSerializer.TabIndex = 2;
            this.chkUseXmlSerializer.Text = "Use XmlSerializer";
            this.chkUseXmlSerializer.UseVisualStyleBackColor = true;
            // 
            // gvFiles
            // 
            this.gvFiles.AllowUserToAddRows = false;
            this.gvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileName,
            this.colMimeType,
            this.colFileLength,
            this.colTag});
            this.gvFiles.Location = new System.Drawing.Point(7, 36);
            this.gvFiles.Name = "gvFiles";
            this.gvFiles.ReadOnly = true;
            this.gvFiles.Size = new System.Drawing.Size(919, 256);
            this.gvFiles.TabIndex = 1;
            this.gvFiles.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvFiles_CellMouseDoubleClick);
            // 
            // colFileName
            // 
            this.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFileName.HeaderText = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // colMimeType
            // 
            this.colMimeType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colMimeType.HeaderText = "MimeType";
            this.colMimeType.Name = "colMimeType";
            this.colMimeType.ReadOnly = true;
            this.colMimeType.Width = 81;
            // 
            // colFileLength
            // 
            this.colFileLength.HeaderText = "Length";
            this.colFileLength.Name = "colFileLength";
            this.colFileLength.ReadOnly = true;
            // 
            // colTag
            // 
            this.colTag.HeaderText = "Tag";
            this.colTag.Name = "colTag";
            this.colTag.ReadOnly = true;
            this.colTag.Visible = false;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(7, 7);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(122, 23);
            this.btnLoadFile.TabIndex = 0;
            this.btnLoadFile.Text = "Add";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBuscarBody);
            this.tabPage3.Controls.Add(this.txtBuscarBody);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cbxBodyType);
            this.tabPage3.Controls.Add(this.txtBodyRaw);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(932, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Body";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBuscarBody
            // 
            this.btnBuscarBody.Location = new System.Drawing.Point(748, 4);
            this.btnBuscarBody.Name = "btnBuscarBody";
            this.btnBuscarBody.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarBody.TabIndex = 5;
            this.btnBuscarBody.Text = "Resaltar";
            this.btnBuscarBody.UseVisualStyleBackColor = true;
            this.btnBuscarBody.Click += new System.EventHandler(this.btnBuscarBody_Click);
            // 
            // txtBuscarBody
            // 
            this.txtBuscarBody.Location = new System.Drawing.Point(418, 7);
            this.txtBuscarBody.Name = "txtBuscarBody";
            this.txtBuscarBody.Size = new System.Drawing.Size(306, 20);
            this.txtBuscarBody.TabIndex = 4;
            this.txtBuscarBody.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarBody_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content-Type";
            // 
            // cbxBodyType
            // 
            this.cbxBodyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBodyType.FormattingEnabled = true;
            this.cbxBodyType.Location = new System.Drawing.Point(92, 6);
            this.cbxBodyType.Name = "cbxBodyType";
            this.cbxBodyType.Size = new System.Drawing.Size(234, 21);
            this.cbxBodyType.TabIndex = 1;
            // 
            // txtBodyRaw
            // 
            this.txtBodyRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBodyRaw.BackColor = System.Drawing.Color.White;
            this.txtBodyRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBodyRaw.Location = new System.Drawing.Point(3, 32);
            this.txtBodyRaw.Name = "txtBodyRaw";
            this.txtBodyRaw.Size = new System.Drawing.Size(926, 356);
            this.txtBodyRaw.TabIndex = 0;
            this.txtBodyRaw.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.cbxPrintFormat);
            this.tabPage4.Controls.Add(this.chkSaveResponse);
            this.tabPage4.Controls.Add(this.btnClearResult);
            this.tabPage4.Controls.Add(this.txtContent);
            this.tabPage4.Controls.Add(this.lbStatusCode);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(932, 394);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Result";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbxPrintFormat
            // 
            this.cbxPrintFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPrintFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrintFormat.FormattingEnabled = true;
            this.cbxPrintFormat.Items.AddRange(new object[] {
            "TEXT",
            "JSON",
            "XML",
            "HTML"});
            this.cbxPrintFormat.Location = new System.Drawing.Point(597, 14);
            this.cbxPrintFormat.Name = "cbxPrintFormat";
            this.cbxPrintFormat.Size = new System.Drawing.Size(87, 21);
            this.cbxPrintFormat.TabIndex = 11;
            this.cbxPrintFormat.SelectedIndexChanged += new System.EventHandler(this.cbxPrintFormat_SelectedIndexChanged);
            // 
            // chkSaveResponse
            // 
            this.chkSaveResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSaveResponse.AutoSize = true;
            this.chkSaveResponse.Location = new System.Drawing.Point(709, 18);
            this.chkSaveResponse.Name = "chkSaveResponse";
            this.chkSaveResponse.Size = new System.Drawing.Size(97, 17);
            this.chkSaveResponse.TabIndex = 4;
            this.chkSaveResponse.Text = "Save response";
            this.chkSaveResponse.UseVisualStyleBackColor = true;
            // 
            // btnClearResult
            // 
            this.btnClearResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearResult.Location = new System.Drawing.Point(851, 12);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(75, 23);
            this.btnClearResult.TabIndex = 3;
            this.btnClearResult.Text = "Limpiar";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(3, 41);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(926, 347);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            // 
            // lbStatusCode
            // 
            this.lbStatusCode.AutoSize = true;
            this.lbStatusCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbStatusCode.Location = new System.Drawing.Point(49, 12);
            this.lbStatusCode.Name = "lbStatusCode";
            this.lbStatusCode.Size = new System.Drawing.Size(0, 13);
            this.lbStatusCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(867, 55);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 20);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(111, 55);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(231, 20);
            this.txtHost.TabIndex = 4;
            // 
            // saveConfigDialog
            // 
            this.saveConfigDialog.Filter = "Json Files|*.json";
            // 
            // openConfigFileDialog
            // 
            this.openConfigFileDialog.Filter = "Json Files|*.json";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(842, 80);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.pluginsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(97, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutPatonToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // aboutPatonToolStripMenuItem
            // 
            this.aboutPatonToolStripMenuItem.Name = "aboutPatonToolStripMenuItem";
            this.aboutPatonToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutPatonToolStripMenuItem.Text = "About Paton";
            this.aboutPatonToolStripMenuItem.Click += new System.EventHandler(this.aboutPatonToolStripMenuItem_Click);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csvGenToolStripMenuItem,
            this.xmlToCsvToolStripMenuItem});
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // csvGenToolStripMenuItem
            // 
            this.csvGenToolStripMenuItem.Name = "csvGenToolStripMenuItem";
            this.csvGenToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.csvGenToolStripMenuItem.Text = "Csv Gen";
            this.csvGenToolStripMenuItem.Click += new System.EventHandler(this.csvGenToolStripMenuItem_Click);
            // 
            // xmlToCsvToolStripMenuItem
            // 
            this.xmlToCsvToolStripMenuItem.Name = "xmlToCsvToolStripMenuItem";
            this.xmlToCsvToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.xmlToCsvToolStripMenuItem.Text = "Xml to Csv";
            this.xmlToCsvToolStripMenuItem.Click += new System.EventHandler(this.xmlToCsvToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(964, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(16, 17);
            this.statusLabel.Text = "...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbarNew,
            this.toolStripSeparator4,
            this.tbarOpen,
            this.tbarSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(964, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbarNew
            // 
            this.tbarNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbarNew.Image = ((System.Drawing.Image)(resources.GetObject("tbarNew.Image")));
            this.tbarNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbarNew.Name = "tbarNew";
            this.tbarNew.Size = new System.Drawing.Size(23, 22);
            this.tbarNew.Click += new System.EventHandler(this.tbarNew_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tbarOpen
            // 
            this.tbarOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbarOpen.Image = ((System.Drawing.Image)(resources.GetObject("tbarOpen.Image")));
            this.tbarOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbarOpen.Name = "tbarOpen";
            this.tbarOpen.Size = new System.Drawing.Size(23, 22);
            this.tbarOpen.Text = "tbarOpen";
            this.tbarOpen.Click += new System.EventHandler(this.tbarOpen_Click);
            // 
            // tbarSave
            // 
            this.tbarSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbarSave.Image = ((System.Drawing.Image)(resources.GetObject("tbarSave.Image")));
            this.tbarSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbarSave.Name = "tbarSave";
            this.tbarSave.Size = new System.Drawing.Size(23, 22);
            this.tbarSave.Click += new System.EventHandler(this.tbarSave_Click);
            // 
            // bwSendRequest
            // 
            this.bwSendRequest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bwSendRequest.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.bwSendRequest.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pretty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtUri);
            this.Controls.Add(this.cbxHttpMethods);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvVariables)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHeaders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFiles)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxHttpMethods;
        private System.Windows.Forms.TextBox txtUri;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.DataGridView gvFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMimeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTag;
        private System.Windows.Forms.DataGridView gvHeaders;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeaderText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeaderValue;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox txtBodyRaw;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label lbStatusCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveConfigDialog;
        private System.Windows.Forms.OpenFileDialog openConfigFileDialog;
        private System.Windows.Forms.CheckBox chkUseXmlSerializer;
        private System.Windows.Forms.ComboBox cbxBodyType;
        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnRemoveHeader;
        private System.Windows.Forms.Button btnAddHeader;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutPatonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnRemoveVariable;
        private System.Windows.Forms.Button btnAddVariable;
        private System.Windows.Forms.DataGridView gvVariables;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbarNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tbarOpen;
        private System.Windows.Forms.ToolStripButton tbarSave;
        private System.Windows.Forms.Button btnBuscarBody;
        private System.Windows.Forms.TextBox txtBuscarBody;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker bwSendRequest;
        private System.Windows.Forms.Button btnSaveAttachment;
        private System.Windows.Forms.SaveFileDialog saveAttachmentDialog;
        private System.Windows.Forms.CheckBox chkSaveResponse;
        private System.Windows.Forms.SaveFileDialog saveResponseDialog;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvGenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlToCsvToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxPrintFormat;
        private System.Windows.Forms.Label label4;
    }
}

