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

        ExclusionEditingWindow exclusionWindow;
        MainWindow parent;

        public ArchivedItemEditingWindow(bool _isAdding, MainWindow _parent)
        {
            InitializeComponent();
            isAdding = _isAdding;
            parent = _parent;

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

        private void Button_ExclusionsAdd_Click(object sender, EventArgs e)
        {
            exclusionWindow = new ExclusionEditingWindow(false);
            exclusionWindow.ShowDialog();
        }

        private void Button_ExclusionsRemove_Click(object sender, EventArgs e)
        {

        }

        private void Button_ExclusionsEdit_Click(object sender, EventArgs e)
        {
            if (List_Exclusions.SelectedItem != null)
            {
                exclusionWindow = new ExclusionEditingWindow(false);
                exclusionWindow.LoadFields(
                    (string)List_Exclusions.SelectedItem,
                    exclusionRecursiveDefinitions[(string)List_Exclusions.SelectedItem]);
                exclusionWindow.ShowDialog();
            }
        }

        private void Button_ExitWithSave_Click(object sender, EventArgs e)
        {
            ArchivedItem newItem = new ArchivedItem();
            newItem.itemName = Textbox_ItemName.Text;
            newItem.sourcePath = Textbox_SourcePath.Text;
            newItem.destinationPath = Textbox_DestinationPath.Text;
            newItem.fileName = Textbox_FileName.Text;
            newItem.password = Textbox_Password.Text;

            newItem.exclusions = new List<string>();
            foreach (object o in List_Exclusions.Items)
                newItem.exclusions.Add((string)o);
            newItem.exclusionRecursiveDefinitions = exclusionRecursiveDefinitions;

            newItem.type = (ArchiveType)Enum.Parse(
                typeof(ArchiveType), Dropdown_FileType.SelectedItem.ToString());
            newItem.compressionLevel = (int)Numeric_CompLevel.Value;
            newItem.compressionMethod = (CompressionMethod)Enum.Parse(
                typeof(CompressionMethod), Dropdown_Method.SelectedItem.ToString());

            parent.CreateItem(newItem);
        }

        private void Button_ExitWithoutSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
