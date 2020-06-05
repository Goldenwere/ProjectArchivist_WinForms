using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjectArchivist
{
    /// <summary>
    /// The main window displays a list of archived items, global settings, and the setting for saving and creating a script
    /// </summary>
    public partial class MainWindow : Form
    {
        // Windows that can be opened from this window
        ArchivedItemEditingWindow itemEditingWindow;
        ErrorPrompt error;
        GeneralMessageForm msg;

        // Working set
        Dictionary<string, ArchivedItem> archivedItems;
        Dictionary<ArchivedItem, string> inverseSearchDict;

        /// <summary>
        /// Current working set of archived items
        /// </summary>
        public Dictionary<string, ArchivedItem> ArchivedItems
        { get { return archivedItems; } }

        /// <summary>
        /// Returns the default file type selected in Globals
        /// </summary>
        public string DefaultFileType
        { get { return (string)Dropdown_GlobalFileType.SelectedItem; } }

        /// <summary>
        /// Returns the default file type selected in Globals
        /// </summary>
        public string DefaultMethod
        { get { return (string)Dropdown_GlobalMethod.SelectedItem; } }

        /// <summary>
        /// Returns the default compression level selected in Globals
        /// </summary>
        public int DefaultLevel
        { get { return (int)Numeric_CompLevel.Value; } }

        /// <summary>
        /// Returns the default destination set in Globals
        /// </summary>
        public string DefaultDestination
        { get { return Textbox_GlobalDestination.Text; } }

        /// <summary>
        /// Returns the default password set in Globals
        /// </summary>
        public string DefaultPassword
        { get { return Textbox_GlobalPassword.Text; } }

        /// <summary>
        /// Constructs the main window and working variables
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            archivedItems = new Dictionary<string, ArchivedItem>();
            inverseSearchDict = new Dictionary<ArchivedItem, string>();

            string[] types = Enum.GetNames(typeof(ArchiveType));
            Dropdown_GlobalFileType.Items.AddRange(types);
            Dropdown_GlobalFileType.DropDownStyle = ComboBoxStyle.DropDownList;
            Dropdown_GlobalFileType.SelectedIndex = 0;

            string[] methods = Enum.GetNames(typeof(CompressionMethod));
            Dropdown_GlobalMethod.Items.AddRange(methods);
            Dropdown_GlobalMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            Dropdown_GlobalMethod.SelectedIndex = 0;
        }

        /// <summary>
        /// When the button for adding archived items is clicked, open the item editing window for a new item
        /// </summary>
        private void Button_AddArchivedItem_Click(object sender, EventArgs e)
        {
            itemEditingWindow = new ArchivedItemEditingWindow(null, this);
            itemEditingWindow.ShowDialog();
        }

        /// <summary>
        /// When the button for removed archived items is clicked, remove the currently selected item unless there are errors
        /// </summary>
        private void Button_RemoveArchivedItem_Click(object sender, EventArgs e)
        {
            if (List_ArchivedItems.SelectedItem != null)
                List_ArchivedItems.Items.Remove(List_ArchivedItems.SelectedItem);

            else
                HandleListErrors();
        }

        /// <summary>
        /// When the button for editing archived items is clicked, open the item editing window for the selected item unless there are errors
        /// </summary>
        private void Button_EditArchivedItem_Click(object sender, EventArgs e)
        {
            if (List_ArchivedItems.SelectedItem != null)
            {
                itemEditingWindow = new ArchivedItemEditingWindow(archivedItems[(string)List_ArchivedItems.SelectedItem], this);
                itemEditingWindow.LoadFields(archivedItems[(string)List_ArchivedItems.SelectedItem]);
                itemEditingWindow.ShowDialog();
            }

            else
                HandleListErrors();
        }

        /// <summary>
        /// Creates an item by adding it to the working set and the list pane in the main window
        /// </summary>
        /// <param name="newItem">The new item being created</param>
        public void CreateItem(ArchivedItem newItem)
        {
            archivedItems.Add(newItem.itemName, newItem);
            inverseSearchDict.Add(newItem, newItem.itemName);
            List_ArchivedItems.Items.Add(newItem.itemName);
        }

        /// <summary>
        /// Updates an existing item in the list pane
        /// </summary>
        /// <param name="item">The item being edited</param>
        public void UpdateEditedItem(ArchivedItem item)
        {
            List_ArchivedItems.Items[List_ArchivedItems.Items.IndexOf(item.itemName)] = item.itemName;
        }

        /// <summary>
        /// When the browse button for the batch file is clicked, open a SaveFileDialog
        /// </summary>
        private void Button_BatchDestination_Click(object sender, EventArgs e)
        {
            if (!SaveFileDialog_Script.FileName.Contains(".bat"))
                SaveFileDialog_Script.FileName += "*.bat";
            SaveFileDialog_Script.ShowDialog();
            Textbox_BatchDestination.Text = SaveFileDialog_Script.FileName;
        }

        /// <summary>
        /// When the globals destination browse button is clicked, open a FolderBrowserDialog
        /// </summary>
        private void Button_GlobalDestination_Click(object sender, EventArgs e)
        {
            FolderBrowse_Destination.ShowDialog();
            Textbox_GlobalDestination.Text = FolderBrowse_Destination.SelectedPath;
        }

        /// <summary>
        /// Applies globals to existing items unless there are errors
        /// </summary>
        private void Button_ApplyGlobals_Click(object sender, EventArgs e)
        {
            List<ArchivedItem> items = archivedItems.Values.ToList();
            ErrorType errorType;
            if ((errorType = ValidateGlobalDestination(items, out List<string> duplicates)) != ErrorType.VALID)
            {
                error = new ErrorPrompt(Errors.ERR_GLOBAL_DUPL + string.Join("\n", duplicates));
                error.ShowDialog();
            }

            else
            {
                foreach (ArchivedItem item in items)
                {
                    item.password = Textbox_GlobalPassword.Text;
                    item.type = (ArchiveType)Enum.Parse(
                        typeof(ArchiveType), Dropdown_GlobalFileType.SelectedItem.ToString());
                    item.compressionMethod = (CompressionMethod)Enum.Parse(
                        typeof(CompressionMethod), Dropdown_GlobalMethod.SelectedItem.ToString());
                    item.compressionLevel = (int)Numeric_CompLevel.Value;
                    item.destinationPath = Textbox_GlobalDestination.Text;
                }
            }
        }
        
        /// <summary>
        /// When the Create Script button is clicked, create a script and display a window showing whether it succeeded or failed
        /// </summary>
        private void Button_CreateScript_Click(object sender, EventArgs e)
        {
            Exception ex = FileManagement.SaveFile(archivedItems.Values.ToList(), Textbox_BatchDestination.Text);

            if (ex != null)
            {
                error = new ErrorPrompt("Error: " + ex.Message);
                error.ShowDialog();
            }

            else
            {
                msg = new GeneralMessageForm("Created script successfully");
                msg.ShowDialog();
            }
        }

        /// <summary>
        /// Opens an error window when there's problems with a user action involving the list
        /// </summary>
        private void HandleListErrors()
        {
            if (List_ArchivedItems.Items.Count == 0)
                error = new ErrorPrompt(Errors.ERR_NO_ITEMS_PRESENT);

            else
                error = new ErrorPrompt(Errors.ERR_NO_ITEM_SEL);

            error.ShowDialog();
        }

        /// <summary>
        /// Ensures that there will be no conflicts with existing items when applying globals
        /// </summary>
        /// <param name="items">The current items being validated</param>
        /// <param name="duplicates">Items that have the same file name if applying a global destination path, empty if the return is ErrorType.VALID</param>
        /// <returns>An error if any (ErrorType.DUPLICATE, otherwise ErrorType.VALID) found with the globals</returns>
        private ErrorType ValidateGlobalDestination(List<ArchivedItem> items, out List<string> duplicates)
        {
            duplicates = new List<string>();

            foreach (ArchivedItem itemA in items)
                foreach (ArchivedItem itemB in items)
                    if (itemA != itemB)
                        if (itemA.fileName == itemB.fileName)
                            duplicates.Add("- Conflict between " + itemA.itemName + " and " + itemB.itemName);

            if (duplicates.Count > 0)
                return ErrorType.DUPLICATE;
            else
                return ErrorType.VALID;
        }
    }
}
