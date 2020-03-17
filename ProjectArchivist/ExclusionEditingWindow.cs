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

        public ExclusionEditingWindow()
        {
            InitializeComponent();
            Tooltip_Exclusion.SetToolTip(Textbox_Name, exclusionTooltip);
            Tooltip_Recursion.SetToolTip(Checkbox_IsRecursive, recursionTooltip);
        }
    }
}
