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
    public partial class DlgVariable : Form
    {

        public Variable Value
        {
            get
            {
                return new Variable()
                {
                    Name    = this.txtHeader.Text,
                    Value   = this.txtValue.Text
                };
            }

            set
            {
                this.txtHeader.Text = (value != null) ? value.Name : null;
                this.txtValue.Text = (value != null) ? value.Value : null;
            }
        }
        public DlgVariable()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
