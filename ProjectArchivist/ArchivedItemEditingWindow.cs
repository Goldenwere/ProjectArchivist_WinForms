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
    public partial class ArchivedItemEditingWindow : Form
    {
        public bool isAdding;
        public Dictionary<string, bool> exclusionRecursiveDefinitions;

        public ArchivedItemEditingWindow(bool _isAdding)
        {
            InitializeComponent();
            isAdding = _isAdding;

            string[] types = Enum.GetNames(typeof(ArchiveType));
            Dropdown_FileType.Items.AddRange(types);

            string[] methods = Enum.GetNames(typeof(CompressionMethod));
            Dropdown_Method.Items.AddRange(methods);
        }

        public void LoadFields(ArchivedItem itemToLoad)
        {
            Textbox_ItemName.Text = itemToLoad.itemName;
            Textbox_SourcePath.Text = itemToLoad.sourcePath;
            Textbox_DestinationPath.Text = itemToLoad.destinationPath;
            Textbox_FileName.Text = itemToLoad.fileName;
            Textbox_Password.Text = itemToLoad.password;
            Dropdown_FileType.SelectedItem = itemToLoad.type;
            Numeric_CompLevel.Value = itemToLoad.compressionLevel;
            Dropdown_Method.SelectedItem = itemToLoad.compressionMethod;

            List_Exclusions.Items.AddRange(itemToLoad.exclusions.ToArray());
            exclusionRecursiveDefinitions = itemToLoad.exclusionRecursiveDefinitions;

        }
    }
}
