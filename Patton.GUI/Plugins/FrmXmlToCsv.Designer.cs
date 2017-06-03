namespace WinPostman.Plugins
{
    partial class FrmXmlToCsv
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeparador = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Separador";
            // 
            // txtSeparador
            // 
            this.txtSeparador.Location = new System.Drawing.Point(81, 13);
            this.txtSeparador.Name = "txtSeparador";
            this.txtSeparador.Size = new System.Drawing.Size(39, 20);
            this.txtSeparador.TabIndex = 1;
            this.txtSeparador.Text = ";";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 372);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtHeader);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Header";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detail";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtHeader
            // 
            this.txtHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHeader.Location = new System.Drawing.Point(3, 3);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(743, 340);
            this.txtHeader.TabIndex = 0;
            // 
            // txtDetail
            // 
            this.txtDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetail.Location = new System.Drawing.Point(3, 3);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(743, 340);
            this.txtDetail.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(164, 9);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(113, 50);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // FrmXmlToCsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 466);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtSeparador);
            this.Controls.Add(this.label1);
            this.Name = "FrmXmlToCsv";
            this.Text = "FrmXmlToCsv";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeparador;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnGenerar;
    }
}