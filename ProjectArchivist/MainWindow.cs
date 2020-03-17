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

        public MainWindow()
        {
            InitializeComponent();
            archivedItems = new Dictionary<string, ArchivedItem>();
        }

        private void Button_AddArchivedItem_Click(object sender, EventArgs e)
        {
            itemEditingWindow = new ArchivedItemEditingWindow(true, this);
            itemEditingWindow.ShowDialog();
        }

        private void Button_RemoveArchivedItem_Click(object sender, EventArgs e)
        {

        }

        private void Button_EditArchivedItem_Click(object sender, EventArgs e)
        {
            if (List_ArchivedItems.SelectedItem != null)
            {
                itemEditingWindow = new ArchivedItemEditingWindow(false, this);
                itemEditingWindow.LoadFields(archivedItems[(string)List_ArchivedItems.SelectedItem]);
                itemEditingWindow.ShowDialog();
            }
        }
    }
}
