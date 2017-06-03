namespace WinPostman.Plugins
{
    partial class FrmCsvGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCsvGen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrefijo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaEmision = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaVence = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComprador = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.nudRangoInicial = new System.Windows.Forms.NumericUpDown();
            this.nudRangoFinal = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtContactoEmail = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtCompradorNit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangoInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangoFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. {{NUMERO_FACTURA}} *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. {{NUMERO_FACTURA}} *";
            // 
            // txtPrefijo
            // 
            this.txtPrefijo.Location = new System.Drawing.Point(82, 13);
            this.txtPrefijo.Name = "txtPrefijo";
            this.txtPrefijo.Size = new System.Drawing.Size(100, 20);
            this.txtPrefijo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prefijo";
            // 
            // txtFechaEmision
            // 
            this.txtFechaEmision.Location = new System.Drawing.Point(185, 71);
            this.txtFechaEmision.Name = "txtFechaEmision";
            this.txtFechaEmision.Size = new System.Drawing.Size(149, 20);
            this.txtFechaEmision.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "{{FECHA_EMISION}} (yyyy-mm-dd)";
            // 
            // txtFechaVence
            // 
            this.txtFechaVence.Location = new System.Drawing.Point(185, 105);
            this.txtFechaVence.Name = "txtFechaVence";
            this.txtFechaVence.Size = new System.Drawing.Size(153, 20);
            this.txtFechaVence.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "{{FECHA_VENCE}} (yyyy-mm-dd)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "{{COMPRADOR}}";
            // 
            // txtComprador
            // 
            this.txtComprador.Location = new System.Drawing.Point(482, 71);
            this.txtComprador.Name = "txtComprador";
            this.txtComprador.Size = new System.Drawing.Size(187, 20);
            this.txtComprador.TabIndex = 11;
            this.txtComprador.Text = "Blackcat Interfaces SAS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 243);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(992, 326);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.txtHeader);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Header";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 275);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(978, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "[Status]";
            // 
            // txtHeader
            // 
            this.txtHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHeader.Location = new System.Drawing.Point(3, 3);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(978, 294);
            this.txtHeader.TabIndex = 0;
            this.txtHeader.Text = resources.GetString("txtHeader.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtDetail
            // 
            this.txtDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetail.Location = new System.Drawing.Point(3, 3);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(978, 294);
            this.txtDetail.TabIndex = 0;
            this.txtDetail.Text = resources.GetString("txtDetail.Text");
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(15, 139);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(160, 48);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // nudRangoInicial
            // 
            this.nudRangoInicial.Location = new System.Drawing.Point(357, 13);
            this.nudRangoInicial.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nudRangoInicial.Name = "nudRangoInicial";
            this.nudRangoInicial.Size = new System.Drawing.Size(120, 20);
            this.nudRangoInicial.TabIndex = 14;
            this.nudRangoInicial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudRangoFinal
            // 
            this.nudRangoFinal.Location = new System.Drawing.Point(357, 39);
            this.nudRangoFinal.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nudRangoFinal.Name = "nudRangoFinal";
            this.nudRangoFinal.Size = new System.Drawing.Size(120, 20);
            this.nudRangoFinal.TabIndex = 15;
            this.nudRangoFinal.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "{{CONTACTO}}";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(482, 137);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(187, 20);
            this.txtContacto.TabIndex = 17;
            this.txtContacto.Text = "Juliana Martinez";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "{{CONTACTO_EMAIL}}";
            // 
            // txtContactoEmail
            // 
            this.txtContactoEmail.Location = new System.Drawing.Point(482, 167);
            this.txtContactoEmail.Name = "txtContactoEmail";
            this.txtContactoEmail.Size = new System.Drawing.Size(187, 20);
            this.txtContactoEmail.TabIndex = 19;
            this.txtContactoEmail.Text = "juliana.martinez@yopmail.com";
            // 
            // txtCompradorNit
            // 
            this.txtCompradorNit.Location = new System.Drawing.Point(482, 101);
            this.txtCompradorNit.Name = "txtCompradorNit";
            this.txtCompradorNit.Size = new System.Drawing.Size(187, 20);
            this.txtCompradorNit.TabIndex = 21;
            this.txtCompradorNit.Text = "880900770";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "{{COMPRADOR_NIT}}";
            // 
            // FrmCsvGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 569);
            this.Controls.Add(this.txtCompradorNit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtContactoEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudRangoFinal);
            this.Controls.Add(this.nudRangoInicial);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtComprador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFechaVence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFechaEmision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrefijo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCsvGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCsvGen";
            this.Load += new System.EventHandler(this.FrmCsvGen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangoInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRangoFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrefijo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFechaEmision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaVence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComprador;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown nudRangoInicial;
        private System.Windows.Forms.NumericUpDown nudRangoFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtContactoEmail;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txtCompradorNit;
        private System.Windows.Forms.Label label9;
    }
}