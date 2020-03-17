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

        public bool isAdding;
        public ArchivedItemEditingWindow parent;

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

        public void LoadFields(string name, bool isRecursive)
        {
            Textbox_Name.Text = name;
            Checkbox_IsRecursive.Checked = isRecursive;
        }

        private void Button_ExitWithSave_Click(object sender, EventArgs e)
        {
            if (isAdding)
                parent.CreateExclusion(Textbox_Name.Text, Checkbox_IsRecursive.Checked);
            else
                parent.UpdatedEditedExclusion(Textbox_Name.Text, Checkbox_IsRecursive.Checked);

            Close();
        }

        private void Button_ExitWithoutSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
