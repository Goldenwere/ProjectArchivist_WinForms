using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProjectArchivist
{
    public struct Errors
    {
        public const string ERR_NO_ITEM_SEL = "No item currently selected";
        public const string ERR_NO_ITEMS_PRESENT = "There are no items in the list";
        public const string ERR_DUPL_ITEMS = "Duplicate entries in fields: \n";
        public const string ERR_MISSING_ITEMS = "Missing entries in fields: \n";
        public const string ERR_INVALID_ITEMS = "Invalid entries in fields: \n";
        public const string HINT_INVALID_ITEMS = "\nLook for invalid path/file characters";
        public const string ERR_GLOBAL_DUPL = "Cannot apply globals due to duplicate file names: \n";
        public const string ERR_DUPL_EXCPTN = "Exception already exists";
        public const string ERR_MISSING_EXCPTN = "Missing entry for exception name field";
    }

    public enum ErrorType
    {
        VALID,
        DUPLICATE,
        MISSING,
        INVALID
    }

    public partial class ErrorPrompt : Form
    {
        public ErrorPrompt(string errorMsg)
        {
            InitializeComponent();
            Label_ErrorDesc.Text = errorMsg;
            SoundPlayer sound = new SoundPlayer("sounds\\vintprox_error-notification-banjo.wav");
            sound.Play();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
