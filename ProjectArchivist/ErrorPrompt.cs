using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectArchivist
{
    public partial class ErrorPrompt : Form
    {
        public ErrorPrompt(string errorMsg)
        {
            InitializeComponent();
            Label_ErrorDesc.Text = errorMsg;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
