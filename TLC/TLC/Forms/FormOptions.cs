using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLC.Forms
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
