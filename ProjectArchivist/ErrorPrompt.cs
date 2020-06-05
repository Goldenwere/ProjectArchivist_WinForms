using System;
using System.Windows.Forms;
using System.Media;

namespace ProjectArchivist
{
    /// <summary>
    /// Holds strings that can be loaded into labels when errors occur
    /// </summary>
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

    /// <summary>
    /// Defines possible errors that can be encountered in the program
    /// </summary>
    public enum ErrorType
    {
        /// <summary>
        /// Indicates no error found
        /// </summary>
        VALID,

        /// <summary>
        /// Indicates that an entry is a duplicate of another
        /// </summary>
        DUPLICATE,

        /// <summary>
        /// Indicates that something is missing from the entry
        /// </summary>
        MISSING,

        /// <summary>
        /// Indicates that something is wrong with an entry
        /// </summary>
        INVALID
    }

    /// <summary>
    /// The error prompt is a window used for providing information to the user about errors that occurred
    /// </summary>
    public partial class ErrorPrompt : Form
    {
        /// <summary>
        /// Constructs an error window with a defined message
        /// </summary>
        /// <param name="errorMsg">The message to display to the user</param>
        public ErrorPrompt(string errorMsg)
        {
            InitializeComponent();
            Label_ErrorDesc.Text = errorMsg;
            SoundPlayer sound = new SoundPlayer("sounds\\vintprox_error-notification-banjo.wav");
            sound.Play();
        }

        /// <summary>
        /// The close button closes the error window
        /// </summary>
        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
