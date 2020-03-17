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
        public ArchivedItem editingItem;
        public Dictionary<string, bool> exclusionRecursiveDefinitions;

        ExclusionEditingWindow exclusionWindow;
        MainWindow parent;

        public ArchivedItemEditingWindow(ArchivedItem _editingItem, MainWindow _parent)
        {
            InitializeComponent();
            exclusionRecursiveDefinitions = new Dictionary<string, bool>();
            editingItem = _editingItem;
            parent = _parent;
            if (editingItem == null)
                Textbox_ItemName.Enabled = true;
            else
                Textbox_ItemName.Enabled = false;

            string[] types = Enum.GetNames(typeof(ArchiveType));
            Dropdown_FileType.Items.AddRange(types);
            Dropdown_FileType.DropDownStyle = ComboBoxStyle.DropDownList;
            Dropdown_FileType.SelectedIndex = 0;

            string[] methods = Enum.GetNames(typeof(CompressionMethod));
            Dropdown_Method.Items.AddRange(methods);
            Dropdown_Method.DropDownStyle = ComboBoxStyle.DropDownList;
            Dropdown_Method.SelectedIndex = 0;
        }

        public void LoadFields(ArchivedItem itemToLoad)
        {
            Textbox_ItemName.Text = itemToLoad.itemName;
            Textbox_SourcePath.Text = itemToLoad.sourcePath;
            Textbox_DestinationPath.Text = itemToLoad.destinationPath;
            Textbox_FileName.Text = itemToLoad.fileName;
            Textbox_Password.Text = itemToLoad.password;
            Dropdown_FileType.SelectedItem = itemToLoad.type.ToString();
            Numeric_CompLevel.Value = itemToLoad.compressionLevel;
            Dropdown_Method.SelectedItem = itemToLoad.compressionMethod.ToString();

            List_Exclusions.Items.AddRange(itemToLoad.exclusions.ToArray());
            exclusionRecursiveDefinitions = itemToLoad.exclusionRecursiveDefinitions;
        }

        private void Button_ExclusionsAdd_Click(object sender, EventArgs e)
        {
            exclusionWindow = new ExclusionEditingWindow(true, this);
            exclusionWindow.ShowDialog();
        }

        private void Button_ExclusionsRemove_Click(object sender, EventArgs e)
        {

        }

        private void Button_ExclusionsEdit_Click(object sender, EventArgs e)
        {
            if (List_Exclusions.SelectedItem != null)
            {
                exclusionWindow = new ExclusionEditingWindow(false, this);
                exclusionWindow.LoadFields(
                    (string)List_Exclusions.SelectedItem,
                    exclusionRecursiveDefinitions[(string)List_Exclusions.SelectedItem]);
                exclusionWindow.ShowDialog();
            }
        }

        private void Button_ExitWithSave_Click(object sender, EventArgs e)
        {
            if (editingItem == null)
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

            else
            {
                editingItem.itemName = Textbox_ItemName.Text;
                editingItem.sourcePath = Textbox_SourcePath.Text;
                editingItem.destinationPath = Textbox_DestinationPath.Text;
                editingItem.fileName = Textbox_FileName.Text;
                editingItem.password = Textbox_Password.Text;

                editingItem.exclusions = new List<string>();
                foreach (object o in List_Exclusions.Items)
                    editingItem.exclusions.Add((string)o);
                editingItem.exclusionRecursiveDefinitions = exclusionRecursiveDefinitions;

                editingItem.type = (ArchiveType)Enum.Parse(
                    typeof(ArchiveType), Dropdown_FileType.SelectedItem.ToString());
                editingItem.compressionLevel = (int)Numeric_CompLevel.Value;
                editingItem.compressionMethod = (CompressionMethod)Enum.Parse(
                    typeof(CompressionMethod), Dropdown_Method.SelectedItem.ToString());

                parent.UpdateEditedItem(editingItem);
            }

            Close();
        }

        private void Button_ExitWithoutSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CreateExclusion(string name, bool isRecursive)
        {
            exclusionRecursiveDefinitions.Add(name, isRecursive);
            List_Exclusions.Items.Add(name);
        }

        public void UpdatedEditedExclusion(string name, bool isRecursive)
        {
            exclusionRecursiveDefinitions[name] = isRecursive;
        }

        private void Button_Source_Click(object sender, EventArgs e)
        {
            FolderBrowse_Source.ShowDialog();
            Textbox_SourcePath.Text = FolderBrowse_Source.SelectedPath;
        }

        private void Button_Destination_Click(object sender, EventArgs e)
        {
            FolderBrowse_Destination.ShowDialog();
            Textbox_DestinationPath.Text = FolderBrowse_Destination.SelectedPath;
        }
    }
}
