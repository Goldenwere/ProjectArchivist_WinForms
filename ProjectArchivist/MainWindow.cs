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
        Dictionary<string, ArchivedItem> archivedItems;
        Dictionary<ArchivedItem, string> inverseSearchDict;

        public MainWindow()
        {
            InitializeComponent();
            archivedItems = new Dictionary<string, ArchivedItem>();
            inverseSearchDict = new Dictionary<ArchivedItem, string>();
        }

        private void Button_AddArchivedItem_Click(object sender, EventArgs e)
        {
            itemEditingWindow = new ArchivedItemEditingWindow(null, this);
            itemEditingWindow.ShowDialog();
        }

        private void Button_RemoveArchivedItem_Click(object sender, EventArgs e)
        {

        }

        private void Button_EditArchivedItem_Click(object sender, EventArgs e)
        {
            if (List_ArchivedItems.SelectedItem != null)
            {
                itemEditingWindow = new ArchivedItemEditingWindow(archivedItems[(string)List_ArchivedItems.SelectedItem], this);
                itemEditingWindow.LoadFields(archivedItems[(string)List_ArchivedItems.SelectedItem]);
                itemEditingWindow.ShowDialog();
            }
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

        private void Button_Destination_Click(object sender, EventArgs e)
        {
            if (!SaveFileDialog_Script.FileName.Contains(".bat"))
                SaveFileDialog_Script.FileName += "*.bat";
            SaveFileDialog_Script.ShowDialog();
            Textbox_DestinationPath.Text = SaveFileDialog_Script.FileName;
        }
    }
}
