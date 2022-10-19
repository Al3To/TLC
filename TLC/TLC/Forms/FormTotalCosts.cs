using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TLC.Forms
{
    public partial class FormTotalCosts : Form
    {
        private FormIndex _FormIndex;
        public FormTotalCosts(FormIndex formIndex)
        {
            InitializeComponent();
            _FormIndex = formIndex;
            this.Text = String.Empty;
            this.ControlBox = false;
        }
        public void Write(string data)
        { 
            labelCosts.Text += data;
            labelCosts.Update();
        }
    }
}
