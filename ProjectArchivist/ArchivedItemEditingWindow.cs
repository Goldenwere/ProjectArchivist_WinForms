﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectArchivist
{
    /// <summary>
    /// The item editor window displays inputs for creating or editing archived items
    /// </summary>
    public partial class ArchivedItemEditingWindow : Form
    {
        // Working set
        public ArchivedItem editingItem;
        public Dictionary<string, bool> exclusionRecursiveDefinitions;
        public Dictionary<string, bool> ExclusionRecursiveDefinitions
        { get { return exclusionRecursiveDefinitions; } }

        // Windows associated with the editor
        ExclusionEditingWindow exclusionWindow;
        MainWindow parent;
        ErrorPrompt error;

        /// <summary>
        /// Constructs and sets up an item editor window
        /// </summary>
        /// <param name="_editingItem">An item to edit, otherwise leave null for item creation</param>
        /// <param name="_parent">The editor's parent window</param>
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

            string[] methods = Enum.GetNames(typeof(CompressionMethod));
            Dropdown_Method.Items.AddRange(methods);
            Dropdown_Method.DropDownStyle = ComboBoxStyle.DropDownList;

            if (editingItem == null)
            {
                Textbox_ItemName.Enabled = true;
                Dropdown_FileType.SelectedItem = parent.DefaultFileType;
                Dropdown_Method.SelectedItem = parent.DefaultMethod;
                Numeric_CompLevel.Value = parent.DefaultLevel;
                Textbox_DestinationPath.Text = parent.DefaultDestination;
                Textbox_Password.Text = parent.DefaultPassword;

                if (System.IO.Directory.Exists(parent.DefaultDestination))
                    FolderBrowser.SelectedPath = parent.DefaultDestination;
            }

            else
                Textbox_ItemName.Enabled = false;
        }

        /// <summary>
        /// Load fields when editing an item; called from the parent
        /// </summary>
        /// <param name="itemToLoad">The item whose values are to fill the window's fields with</param>
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

        /// <summary>
        /// The exclusions add button opens the exclusion editing window
        /// </summary>
        private void Button_ExclusionsAdd_Click(object sender, EventArgs e)
        {
            exclusionWindow = new ExclusionEditingWindow(true, this);
            exclusionWindow.ShowDialog();
        }

        /// <summary>
        /// The exclusions remove button removes an exclusion from the list unless there is an error
        /// </summary>
        private void Button_ExclusionsRemove_Click(object sender, EventArgs e)
        {
            if (List_Exclusions.SelectedItem != null)
                List_Exclusions.Items.Remove(List_Exclusions.SelectedItem);

            else
                HandleListErrors();
        }

        /// <summary>
        /// The exclusions edit button edits an exclusion unless there is an error
        /// </summary>
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

            else
                HandleListErrors();
        }

        /// <summary>
        /// The exit-with-save button saves an item before closing the item editor as long as there are no errors
        /// </summary>
        private void Button_ExitWithSave_Click(object sender, EventArgs e)
        {
            ErrorType errorType;
            if ((errorType = VerifyRequiredFields(out List<string> invalidItems)) != ErrorType.VALID)
            {
                switch (errorType)
                {
                    case ErrorType.DUPLICATE:
                        error = new ErrorPrompt(Errors.ERR_DUPL_ITEMS + string.Join("\n", invalidItems));
                        break;
                    case ErrorType.INVALID:
                        error = new ErrorPrompt(Errors.ERR_INVALID_ITEMS + string.Join("\n", invalidItems) + Errors.HINT_INVALID_ITEMS);
                        break;
                    case ErrorType.MISSING:
                        error = new ErrorPrompt(Errors.ERR_MISSING_ITEMS + string.Join("\n", invalidItems));
                        break;
                    default:
                        break;
                }

                error.ShowDialog();
            }

            else
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
        }

        /// <summary>
        /// The exit-without-save button closes the editor without saving beforehand
        /// </summary>
        private void Button_ExitWithoutSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Adds an exclusion to the item
        /// </summary>
        public void CreateExclusion(string name, bool isRecursive)
        {
            exclusionRecursiveDefinitions.Add(name, isRecursive);
            List_Exclusions.Items.Add(name);
            if (editingItem != null && editingItem.exclusions != null && editingItem.exclusionRecursiveDefinitions != null)
            {
                editingItem.exclusions.Add(name);
                editingItem.exclusionRecursiveDefinitions.Add(name, isRecursive);
            }
        }

        /// <summary>
        /// Updates an existing exclusion of the item
        /// </summary>
        public void UpdatedEditedExclusion(string name, bool isRecursive)
        {
            exclusionRecursiveDefinitions[name] = isRecursive;
            if (editingItem != null && editingItem.exclusions != null && editingItem.exclusionRecursiveDefinitions != null)
            {
                editingItem.exclusionRecursiveDefinitions[name] = isRecursive;
            }
        }

        /// <summary>
        /// The source browse button opens a folder browser dialog to choose a source path
        /// </summary>
        private void Button_Source_Click(object sender, EventArgs e)
        {
            FolderBrowser.ShowDialog();
            Textbox_SourcePath.Text = FolderBrowser.SelectedPath;
        }

        /// <summary>
        /// The destination button opens a folder browser dialog to choose a destination path
        /// </summary>
        private void Button_Destination_Click(object sender, EventArgs e)
        {
            FolderBrowser.ShowDialog();
            Textbox_DestinationPath.Text = FolderBrowser.SelectedPath;
        }

        /// <summary>
        /// Opens an error window when there's problems with a user action involving the list
        /// </summary>
        private void HandleListErrors()
        {
            if (List_Exclusions.Items.Count == 0)
                error = new ErrorPrompt(Errors.ERR_NO_ITEMS_PRESENT);

            else
                error = new ErrorPrompt(Errors.ERR_NO_ITEM_SEL);

            error.ShowDialog();
        }

        /// <summary>
        /// Ensures required editor fields are valid for the item
        /// </summary>
        /// <param name="invalidItems">Any invalid entries found in the list</param>
        /// <returns>An error if any found in the editor's fields</returns>
        private ErrorType VerifyRequiredFields(out List<string> invalidItems)
        {
            invalidItems = new List<string>();

            // First handle missing items
            if (Textbox_ItemName.Text == "")
                invalidItems.Add("- Item Name");

            if (Textbox_SourcePath.Text == "")
                invalidItems.Add("- Source Path");

            if (Textbox_DestinationPath.Text == "")
                invalidItems.Add("- Destination Path");

            if (Textbox_FileName.Text == "")
                invalidItems.Add("- File Name");

            // Exit early for missing items
            if (invalidItems.Count > 0)
                return ErrorType.MISSING;

            // Now handle invalid items
            try
            {
                System.IO.Path.GetFullPath(Textbox_SourcePath.Text);
            }
            catch (Exception e)
            {
                invalidItems.Add("- Source Path");
            }

            try
            {
                System.IO.Path.GetFullPath(Textbox_DestinationPath.Text);
            }
            catch (Exception e)
            {
                invalidItems.Add("- Destination Path");
            }

            try
            {
                System.IO.Path.GetFullPath(Textbox_FileName.Text);
            }
            catch (Exception e)
            {
                invalidItems.Add("- File Name");
            }

            if (invalidItems.Count > 0)
                return ErrorType.INVALID;

            // Now handle duplicates
            List<ArchivedItem> items = parent.ArchivedItems.Values.ToList();
            foreach(ArchivedItem item in items)
            {
                if (Textbox_ItemName.Text == item.itemName &&
                    editingItem != item)
                    invalidItems.Add("- Item Name");

                if (Textbox_FileName.Text == item.fileName &&
                    Textbox_DestinationPath.Text == item.destinationPath &&
                    editingItem != item)
                    invalidItems.Add("- Destination + File Path");
            }

            if (invalidItems.Count > 0)
                return ErrorType.DUPLICATE;

            else
                return ErrorType.VALID;
        }
    }
}
