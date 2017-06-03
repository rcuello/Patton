using Postman.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPostman.Dialog
{
    public partial class DlgHeader : Form
    {

        public Header Value
        {
            get
            {
                return new Header()
                {
                    Text    = this.txtHeader.Text,
                    Value   = this.txtValue.Text
                };
            }

            set
            {
                this.txtHeader.Text = (value != null) ? value.Text : null;
                this.txtValue.Text = (value != null) ? value.Value : null;
            }
        }
        public DlgHeader()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
