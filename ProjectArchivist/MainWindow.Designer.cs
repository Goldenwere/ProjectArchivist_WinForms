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
            this.Button_AddArchivedItem = new System.Windows.Forms.Button();
            this.Button_RemoveArchivedItem = new System.Windows.Forms.Button();
            this.Button_EditArchivedItem = new System.Windows.Forms.Button();
            this.List_ArchivedItems = new System.Windows.Forms.ListBox();
            this.Group_ArchiveList = new System.Windows.Forms.GroupBox();
            this.Label_Method = new System.Windows.Forms.Label();
            this.Dropdown_GlobalMethod = new System.Windows.Forms.ComboBox();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Dropdown_GlobalFileType = new System.Windows.Forms.ComboBox();
            this.Numeric_CompLevel = new System.Windows.Forms.NumericUpDown();
            this.Label_CompLevel = new System.Windows.Forms.Label();
            this.Textbox_GlobalPassword = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Group_Globals = new System.Windows.Forms.GroupBox();
            this.Button_GlobalDestination = new System.Windows.Forms.Button();
            this.Button_ApplyGlobals = new System.Windows.Forms.Button();
            this.Textbox_GlobalDestination = new System.Windows.Forms.TextBox();
            this.Label_GlobalsWarning = new System.Windows.Forms.Label();
            this.Label_GlobalDestination = new System.Windows.Forms.Label();
            this.Button_BatchDestination = new System.Windows.Forms.Button();
            this.Textbox_BatchDestination = new System.Windows.Forms.TextBox();
            this.Label_BatchDestination = new System.Windows.Forms.Label();
            this.Group_File = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveFileDialog_Script = new System.Windows.Forms.SaveFileDialog();
            this.FolderBrowse_Destination = new System.Windows.Forms.FolderBrowserDialog();
            this.Group_ArchiveList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CompLevel)).BeginInit();
            this.Group_Globals.SuspendLayout();
            this.Group_File.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_AddArchivedItem
            // 
            this.Button_AddArchivedItem.Location = new System.Drawing.Point(162, 19);
            this.Button_AddArchivedItem.Name = "Button_AddArchivedItem";
            this.Button_AddArchivedItem.Size = new System.Drawing.Size(100, 50);
            this.Button_AddArchivedItem.TabIndex = 1;
            this.Button_AddArchivedItem.Text = "Add";
            this.Button_AddArchivedItem.UseVisualStyleBackColor = true;
            this.Button_AddArchivedItem.Click += new System.EventHandler(this.Button_AddArchivedItem_Click);
            // 
            // Button_RemoveArchivedItem
            // 
            this.Button_RemoveArchivedItem.Location = new System.Drawing.Point(162, 75);
            this.Button_RemoveArchivedItem.Name = "Button_RemoveArchivedItem";
            this.Button_RemoveArchivedItem.Size = new System.Drawing.Size(100, 50);
            this.Button_RemoveArchivedItem.TabIndex = 2;
            this.Button_RemoveArchivedItem.Text = "Remove";
            this.Button_RemoveArchivedItem.UseVisualStyleBackColor = true;
            this.Button_RemoveArchivedItem.Click += new System.EventHandler(this.Button_RemoveArchivedItem_Click);
            // 
            // Button_EditArchivedItem
            // 
            this.Button_EditArchivedItem.Location = new System.Drawing.Point(162, 131);
            this.Button_EditArchivedItem.Name = "Button_EditArchivedItem";
            this.Button_EditArchivedItem.Size = new System.Drawing.Size(100, 50);
            this.Button_EditArchivedItem.TabIndex = 3;
            this.Button_EditArchivedItem.Text = "Edit";
            this.Button_EditArchivedItem.UseVisualStyleBackColor = true;
            this.Button_EditArchivedItem.Click += new System.EventHandler(this.Button_EditArchivedItem_Click);
            // 
            // List_ArchivedItems
            // 
            this.List_ArchivedItems.FormattingEnabled = true;
            this.List_ArchivedItems.Location = new System.Drawing.Point(6, 19);
            this.List_ArchivedItems.Name = "List_ArchivedItems";
            this.List_ArchivedItems.Size = new System.Drawing.Size(150, 290);
            this.List_ArchivedItems.TabIndex = 0;
            // 
            // Group_ArchiveList
            // 
            this.Group_ArchiveList.Controls.Add(this.List_ArchivedItems);
            this.Group_ArchiveList.Controls.Add(this.Button_EditArchivedItem);
            this.Group_ArchiveList.Controls.Add(this.Button_AddArchivedItem);
            this.Group_ArchiveList.Controls.Add(this.Button_RemoveArchivedItem);
            this.Group_ArchiveList.Location = new System.Drawing.Point(12, 87);
            this.Group_ArchiveList.Name = "Group_ArchiveList";
            this.Group_ArchiveList.Size = new System.Drawing.Size(267, 316);
            this.Group_ArchiveList.TabIndex = 5;
            this.Group_ArchiveList.TabStop = false;
            this.Group_ArchiveList.Text = "List of Archived Items";
            // 
            // Label_Method
            // 
            this.Label_Method.AutoSize = true;
            this.Label_Method.Location = new System.Drawing.Point(6, 96);
            this.Label_Method.Name = "Label_Method";
            this.Label_Method.Size = new System.Drawing.Size(43, 13);
            this.Label_Method.TabIndex = 25;
            this.Label_Method.Text = "Method";
            // 
            // Dropdown_GlobalMethod
            // 
            this.Dropdown_GlobalMethod.FormattingEnabled = true;
            this.Dropdown_GlobalMethod.Location = new System.Drawing.Point(71, 93);
            this.Dropdown_GlobalMethod.Name = "Dropdown_GlobalMethod";
            this.Dropdown_GlobalMethod.Size = new System.Drawing.Size(200, 21);
            this.Dropdown_GlobalMethod.TabIndex = 24;
            // 
            // Label_Type
            // 
            this.Label_Type.AutoSize = true;
            this.Label_Type.Location = new System.Drawing.Point(6, 43);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(50, 13);
            this.Label_Type.TabIndex = 23;
            this.Label_Type.Text = "File Type";
            // 
            // Dropdown_GlobalFileType
            // 
            this.Dropdown_GlobalFileType.FormattingEnabled = true;
            this.Dropdown_GlobalFileType.Location = new System.Drawing.Point(71, 40);
            this.Dropdown_GlobalFileType.Name = "Dropdown_GlobalFileType";
            this.Dropdown_GlobalFileType.Size = new System.Drawing.Size(200, 21);
            this.Dropdown_GlobalFileType.TabIndex = 22;
            // 
            // Numeric_CompLevel
            // 
            this.Numeric_CompLevel.Location = new System.Drawing.Point(171, 67);
            this.Numeric_CompLevel.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Numeric_CompLevel.Name = "Numeric_CompLevel";
            this.Numeric_CompLevel.Size = new System.Drawing.Size(100, 20);
            this.Numeric_CompLevel.TabIndex = 21;
            // 
            // Label_CompLevel
            // 
            this.Label_CompLevel.AutoSize = true;
            this.Label_CompLevel.Location = new System.Drawing.Point(6, 69);
            this.Label_CompLevel.Name = "Label_CompLevel";
            this.Label_CompLevel.Size = new System.Drawing.Size(96, 13);
            this.Label_CompLevel.TabIndex = 20;
            this.Label_CompLevel.Text = "Compression Level";
            // 
            // Textbox_GlobalPassword
            // 
            this.Textbox_GlobalPassword.Location = new System.Drawing.Point(71, 13);
            this.Textbox_GlobalPassword.MaxLength = 128;
            this.Textbox_GlobalPassword.Name = "Textbox_GlobalPassword";
            this.Textbox_GlobalPassword.Size = new System.Drawing.Size(200, 20);
            this.Textbox_GlobalPassword.TabIndex = 19;
            this.Textbox_GlobalPassword.UseSystemPasswordChar = true;
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(6, 16);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(53, 13);
            this.Label_Password.TabIndex = 18;
            this.Label_Password.Text = "Password";
            // 
            // Group_Globals
            // 
            this.Group_Globals.Controls.Add(this.Button_GlobalDestination);
            this.Group_Globals.Controls.Add(this.Button_ApplyGlobals);
            this.Group_Globals.Controls.Add(this.Textbox_GlobalDestination);
            this.Group_Globals.Controls.Add(this.Label_GlobalsWarning);
            this.Group_Globals.Controls.Add(this.Label_GlobalDestination);
            this.Group_Globals.Controls.Add(this.Label_Password);
            this.Group_Globals.Controls.Add(this.Label_Method);
            this.Group_Globals.Controls.Add(this.Textbox_GlobalPassword);
            this.Group_Globals.Controls.Add(this.Dropdown_GlobalMethod);
            this.Group_Globals.Controls.Add(this.Label_CompLevel);
            this.Group_Globals.Controls.Add(this.Label_Type);
            this.Group_Globals.Controls.Add(this.Numeric_CompLevel);
            this.Group_Globals.Controls.Add(this.Dropdown_GlobalFileType);
            this.Group_Globals.Location = new System.Drawing.Point(285, 87);
            this.Group_Globals.Name = "Group_Globals";
            this.Group_Globals.Size = new System.Drawing.Size(282, 316);
            this.Group_Globals.TabIndex = 26;
            this.Group_Globals.TabStop = false;
            this.Group_Globals.Text = "Global Controls";
            // 
            // Button_GlobalDestination
            // 
            this.Button_GlobalDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_GlobalDestination.Location = new System.Drawing.Point(216, 138);
            this.Button_GlobalDestination.Name = "Button_GlobalDestination";
            this.Button_GlobalDestination.Size = new System.Drawing.Size(60, 20);
            this.Button_GlobalDestination.TabIndex = 35;
            this.Button_GlobalDestination.Text = "Browse...";
            this.Button_GlobalDestination.UseVisualStyleBackColor = true;
            this.Button_GlobalDestination.Click += new System.EventHandler(this.Button_GlobalDestination_Click);
            // 
            // Button_ApplyGlobals
            // 
            this.Button_ApplyGlobals.Location = new System.Drawing.Point(6, 259);
            this.Button_ApplyGlobals.Name = "Button_ApplyGlobals";
            this.Button_ApplyGlobals.Size = new System.Drawing.Size(270, 50);
            this.Button_ApplyGlobals.TabIndex = 4;
            this.Button_ApplyGlobals.Text = "Apply Globals";
            this.Button_ApplyGlobals.UseVisualStyleBackColor = true;
            this.Button_ApplyGlobals.Click += new System.EventHandler(this.Button_ApplyGlobals_Click);
            // 
            // Textbox_GlobalDestination
            // 
            this.Textbox_GlobalDestination.Location = new System.Drawing.Point(71, 138);
            this.Textbox_GlobalDestination.Name = "Textbox_GlobalDestination";
            this.Textbox_GlobalDestination.Size = new System.Drawing.Size(139, 20);
            this.Textbox_GlobalDestination.TabIndex = 34;
            // 
            // Label_GlobalsWarning
            // 
            this.Label_GlobalsWarning.AutoSize = true;
            this.Label_GlobalsWarning.Location = new System.Drawing.Point(6, 185);
            this.Label_GlobalsWarning.MaximumSize = new System.Drawing.Size(273, 0);
            this.Label_GlobalsWarning.Name = "Label_GlobalsWarning";
            this.Label_GlobalsWarning.Size = new System.Drawing.Size(272, 52);
            this.Label_GlobalsWarning.TabIndex = 27;
            this.Label_GlobalsWarning.Text = "Warning: Applying these changes will overwrite the values stored in the items cur" +
    "rently in the List of Archived Items. You must edit an existing item afterward i" +
    "n order to make exceptions.";
            // 
            // Label_GlobalDestination
            // 
            this.Label_GlobalDestination.AutoSize = true;
            this.Label_GlobalDestination.Location = new System.Drawing.Point(6, 141);
            this.Label_GlobalDestination.Name = "Label_GlobalDestination";
            this.Label_GlobalDestination.Size = new System.Drawing.Size(60, 13);
            this.Label_GlobalDestination.TabIndex = 33;
            this.Label_GlobalDestination.Text = "Destination";
            // 
            // Button_BatchDestination
            // 
            this.Button_BatchDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_BatchDestination.Location = new System.Drawing.Point(489, 12);
            this.Button_BatchDestination.Name = "Button_BatchDestination";
            this.Button_BatchDestination.Size = new System.Drawing.Size(60, 20);
            this.Button_BatchDestination.TabIndex = 29;
            this.Button_BatchDestination.Text = "Browse...";
            this.Button_BatchDestination.UseVisualStyleBackColor = true;
            this.Button_BatchDestination.Click += new System.EventHandler(this.Button_BatchDestination_Click);
            // 
            // Textbox_BatchDestination
            // 
            this.Textbox_BatchDestination.Location = new System.Drawing.Point(78, 13);
            this.Textbox_BatchDestination.Name = "Textbox_BatchDestination";
            this.Textbox_BatchDestination.Size = new System.Drawing.Size(405, 20);
            this.Textbox_BatchDestination.TabIndex = 28;
            // 
            // Label_BatchDestination
            // 
            this.Label_BatchDestination.AutoSize = true;
            this.Label_BatchDestination.Location = new System.Drawing.Point(6, 16);
            this.Label_BatchDestination.Name = "Label_BatchDestination";
            this.Label_BatchDestination.Size = new System.Drawing.Size(66, 13);
            this.Label_BatchDestination.TabIndex = 27;
            this.Label_BatchDestination.Text = "Save File As";
            // 
            // Group_File
            // 
            this.Group_File.Controls.Add(this.Label_BatchDestination);
            this.Group_File.Controls.Add(this.Textbox_BatchDestination);
            this.Group_File.Controls.Add(this.Button_BatchDestination);
            this.Group_File.Location = new System.Drawing.Point(12, 12);
            this.Group_File.Name = "Group_File";
            this.Group_File.Size = new System.Drawing.Size(555, 44);
            this.Group_File.TabIndex = 32;
            this.Group_File.TabStop = false;
            this.Group_File.Text = ".bat File Settings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(555, 50);
            this.button1.TabIndex = 28;
            this.button1.Text = "Create Script";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SaveFileDialog_Script
            // 
            this.SaveFileDialog_Script.Filter = "Batch Script File | *.bat";
            // 
            // FolderBrowse_Destination
            // 
            this.FolderBrowse_Destination.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Group_File);
            this.Controls.Add(this.Group_Globals);
            this.Controls.Add(this.Group_ArchiveList);
            this.Name = "MainWindow";
            this.Text = "Project Archivist";
            this.Group_ArchiveList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CompLevel)).EndInit();
            this.Group_Globals.ResumeLayout(false);
            this.Group_Globals.PerformLayout();
            this.Group_File.ResumeLayout(false);
            this.Group_File.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Button_AddArchivedItem;
        private System.Windows.Forms.Button Button_RemoveArchivedItem;
        private System.Windows.Forms.Button Button_EditArchivedItem;
        private System.Windows.Forms.ListBox List_ArchivedItems;
        private System.Windows.Forms.GroupBox Group_ArchiveList;
        private System.Windows.Forms.Label Label_Method;
        private System.Windows.Forms.ComboBox Dropdown_GlobalMethod;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.ComboBox Dropdown_GlobalFileType;
        private System.Windows.Forms.NumericUpDown Numeric_CompLevel;
        private System.Windows.Forms.Label Label_CompLevel;
        private System.Windows.Forms.TextBox Textbox_GlobalPassword;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.GroupBox Group_Globals;
        private System.Windows.Forms.Label Label_GlobalsWarning;
        private System.Windows.Forms.Button Button_ApplyGlobals;
        private System.Windows.Forms.Button Button_BatchDestination;
        private System.Windows.Forms.TextBox Textbox_BatchDestination;
        private System.Windows.Forms.Label Label_BatchDestination;
        private System.Windows.Forms.GroupBox Group_File;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog_Script;
        private System.Windows.Forms.Button Button_GlobalDestination;
        private System.Windows.Forms.TextBox Textbox_GlobalDestination;
        private System.Windows.Forms.Label Label_GlobalDestination;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowse_Destination;
    }
}

