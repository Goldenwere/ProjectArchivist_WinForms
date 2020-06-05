using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectArchivist
{
    /// <summary>
    /// The exclusion editor displays inputs for creating or editing exclusions associated with ArchivedItems
    /// </summary>
    public partial class ExclusionEditingWindow : Form
    {
        const string exclusionTooltip =
            "Example Input:\n" +
            "temp.* : excludes files that start with \"temp.\"\n" +
            "*.png : excludes files that end with \".png\"\n";

        const string recursionTooltip =
            "Explanation\n" + 
            "Assume exclusion field says obj\n" +
            "If excluding any and all \"obj\" folders, check this box.\n" +
            "If excluding only the topmost \"obj\" folder, don't check this box.\n";

        // Windows associated with the editor
        ErrorPrompt error;
        public ArchivedItemEditingWindow parent;

        // Whether the exclusion editor is adding (otherwise editing) an exclusion; 
        // used for determining what to call on the parent and for enabling/disabling the name textbox
        public bool isAdding;

        /// <summary>
        /// Constructs an exclusion editor window and associates its parent and whether it is adding or editing
        /// </summary>
        public ExclusionEditingWindow(bool _isAdding, ArchivedItemEditingWindow _parent)
        {
            InitializeComponent();
            Tooltip_Exclusion.SetToolTip(Textbox_Name, exclusionTooltip);
            Tooltip_Recursion.SetToolTip(Checkbox_IsRecursive, recursionTooltip);

            parent = _parent;
            isAdding = _isAdding;
            if (isAdding)
                Textbox_Name.Enabled = true;
            else
                Textbox_Name.Enabled = false;
        }

        /// <summary>
        /// Loads fields when editing an exclusion; called from the parent
        /// </summary>
        /// <param name="name">The name of the exclusion</param>
        /// <param name="isRecursive">The recursive setting of the exclusion</param>
        public void LoadFields(string name, bool isRecursive)
        {
            Textbox_Name.Text = name;
            Checkbox_IsRecursive.Checked = isRecursive;
        }

        /// <summary>
        /// The exit-with-save button saves the exclusion before closing the window
        /// </summary>
        private void Button_ExitWithSave_Click(object sender, EventArgs e)
        {
            switch(ValidateEntry())
            {
                case ErrorType.DUPLICATE:
                    error = new ErrorPrompt(Errors.ERR_DUPL_EXCPTN);
                    error.ShowDialog();
                    break;
                case ErrorType.MISSING:
                    error = new ErrorPrompt(Errors.ERR_MISSING_EXCPTN);
                    error.ShowDialog();
                    break;
                case ErrorType.VALID:
                default:
                    if (isAdding)
                        parent.CreateExclusion(Textbox_Name.Text, Checkbox_IsRecursive.Checked);
                    else
                        parent.UpdatedEditedExclusion(Textbox_Name.Text, Checkbox_IsRecursive.Checked);

                    Close();
                    break;
            }
        }

        /// <summary>
        /// The exit-without-save button closes the editor window without saving the exclusion beforehand
        /// </summary>
        private void Button_ExitWithoutSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ensures that the exclusion entered is not empty or a duplicate
        /// </summary>
        /// <returns>The error, if any, found when validating the exclusion</returns>
        private ErrorType ValidateEntry()
        {
            if (Textbox_Name.Text == "")
                return ErrorType.MISSING;

            List<string> entries = parent.ExclusionRecursiveDefinitions.Keys.ToList();
            foreach (string s in entries)
                if (s == Textbox_Name.Text && isAdding)
                    return ErrorType.DUPLICATE;

            return ErrorType.VALID;
        }
    }
}
