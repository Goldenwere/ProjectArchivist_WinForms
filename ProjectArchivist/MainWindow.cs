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
    public partial class MainWindow : Form
    {
        ArchivedItemEditingWindow itemEditingWindow;
        ErrorPrompt error;
        Dictionary<string, ArchivedItem> archivedItems;
        Dictionary<ArchivedItem, string> inverseSearchDict;

        public Dictionary<string, ArchivedItem> ArchivedItems
        { get { return archivedItems; } }

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

        private void Button_AddArchivedItem_Click(object sender, EventArgs e)
        {
            itemEditingWindow = new ArchivedItemEditingWindow(null, this);
            itemEditingWindow.ShowDialog();
        }

        private void Button_RemoveArchivedItem_Click(object sender, EventArgs e)
        {
            if (List_ArchivedItems.SelectedItem != null)
                List_ArchivedItems.Items.Remove(List_ArchivedItems.SelectedItem);

            else
                HandleListErrors();
        }

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

        public void CreateItem(ArchivedItem newItem)
        {
            archivedItems.Add(newItem.itemName, newItem);
            inverseSearchDict.Add(newItem, newItem.itemName);
            List_ArchivedItems.Items.Add(newItem.itemName);
        }

        public void UpdateEditedItem(ArchivedItem item)
        {
            List_ArchivedItems.Items[List_ArchivedItems.Items.IndexOf(item.itemName)] = item.itemName;
        }

        private void Button_BatchDestination_Click(object sender, EventArgs e)
        {
            if (!SaveFileDialog_Script.FileName.Contains(".bat"))
                SaveFileDialog_Script.FileName += "*.bat";
            SaveFileDialog_Script.ShowDialog();
            Textbox_BatchDestination.Text = SaveFileDialog_Script.FileName;
        }

        private void Button_GlobalDestination_Click(object sender, EventArgs e)
        {
            FolderBrowse_Destination.ShowDialog();
            Textbox_GlobalDestination.Text = FolderBrowse_Destination.SelectedPath;
        }

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

        private void Button_CreateScript_Click(object sender, EventArgs e)
        {
            FileManagement.SaveFile(archivedItems.Values.ToList(), Textbox_BatchDestination.Text);
        }

        private void HandleListErrors()
        {
            if (List_ArchivedItems.Items.Count == 0)
                error = new ErrorPrompt(Errors.ERR_NO_ITEMS_PRESENT);

            else
                error = new ErrorPrompt(Errors.ERR_NO_ITEM_SEL);

            error.ShowDialog();
        }

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
