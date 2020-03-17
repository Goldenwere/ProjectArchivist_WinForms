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
    public struct Errors
    {
        public const string ERR_NO_ITEM_SEL = "No item currently selected";
        public const string ERR_NO_ITEMS_PRESENT = "There are no items in the list to remove";
    }

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
