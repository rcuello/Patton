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
    public partial class DlgAttachment : Form
    {

        public Attachment Value
        {
            get
            {
                return this.propertyGrid1.SelectedObject as Attachment;
            }

            set
            {
                this.propertyGrid1.SelectedObject = value;
            }
        }
        public DlgAttachment()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
