using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WinPostman.Plugins
{
    public partial class FrmXmlToCsv : Form
    {
        public FrmXmlToCsv()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string xmlHeader = txtHeader.Text.Trim();

            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(xmlHeader);

            XmlElement xmlElement = xdoc.DocumentElement;
            foreach (XmlNode node in xmlElement.ChildNodes)
            {
                if (node.NodeType == XmlNodeType.Text && !string.IsNullOrWhiteSpace(node.Value))
                {
                    Console.WriteLine(node.Value.Trim());
                }
                    
            }
                
        }
    }
}
