namespace ProjectArchivist
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.List_ArchivedItems = new System.Windows.Forms.ListBox();
            this.Button_AddArchivedItem = new System.Windows.Forms.Button();
            this.Button_RemoveArchivedItem = new System.Windows.Forms.Button();
            this.Button_EditArchivedItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // List_ArchivedItems
            // 
            this.List_ArchivedItems.FormattingEnabled = true;
            this.List_ArchivedItems.Location = new System.Drawing.Point(12, 259);
            this.List_ArchivedItems.Name = "List_ArchivedItems";
            this.List_ArchivedItems.Size = new System.Drawing.Size(150, 290);
            this.List_ArchivedItems.TabIndex = 0;
            // 
            // Button_AddArchivedItem
            // 
            this.Button_AddArchivedItem.Location = new System.Drawing.Point(168, 259);
            this.Button_AddArchivedItem.Name = "Button_AddArchivedItem";
            this.Button_AddArchivedItem.Size = new System.Drawing.Size(100, 50);
            this.Button_AddArchivedItem.TabIndex = 1;
            this.Button_AddArchivedItem.Text = "Add";
            this.Button_AddArchivedItem.UseVisualStyleBackColor = true;
            this.Button_AddArchivedItem.Click += new System.EventHandler(this.Button_AddArchivedItem_Click);
            // 
            // Button_RemoveArchivedItem
            // 
            this.Button_RemoveArchivedItem.Location = new System.Drawing.Point(168, 315);
            this.Button_RemoveArchivedItem.Name = "Button_RemoveArchivedItem";
            this.Button_RemoveArchivedItem.Size = new System.Drawing.Size(100, 50);
            this.Button_RemoveArchivedItem.TabIndex = 2;
            this.Button_RemoveArchivedItem.Text = "Remove";
            this.Button_RemoveArchivedItem.UseVisualStyleBackColor = true;
            // 
            // Button_EditArchivedItem
            // 
            this.Button_EditArchivedItem.Location = new System.Drawing.Point(168, 371);
            this.Button_EditArchivedItem.Name = "Button_EditArchivedItem";
            this.Button_EditArchivedItem.Size = new System.Drawing.Size(100, 50);
            this.Button_EditArchivedItem.TabIndex = 3;
            this.Button_EditArchivedItem.Text = "Edit";
            this.Button_EditArchivedItem.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Button_EditArchivedItem);
            this.Controls.Add(this.Button_RemoveArchivedItem);
            this.Controls.Add(this.Button_AddArchivedItem);
            this.Controls.Add(this.List_ArchivedItems);
            this.Name = "MainWindow";
            this.Text = "Project Archivist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox List_ArchivedItems;
        private System.Windows.Forms.Button Button_AddArchivedItem;
        private System.Windows.Forms.Button Button_RemoveArchivedItem;
        private System.Windows.Forms.Button Button_EditArchivedItem;
    }
}

