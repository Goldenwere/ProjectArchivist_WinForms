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
            this.Dropdown_Method = new System.Windows.Forms.ComboBox();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Dropdown_FileType = new System.Windows.Forms.ComboBox();
            this.Numeric_CompLevel = new System.Windows.Forms.NumericUpDown();
            this.Label_CompLevel = new System.Windows.Forms.Label();
            this.Textbox_Password = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Group_Globals = new System.Windows.Forms.GroupBox();
            this.Label_GlobalsWarning = new System.Windows.Forms.Label();
            this.Button_ApplyGlobals = new System.Windows.Forms.Button();
            this.Button_Destination = new System.Windows.Forms.Button();
            this.Textbox_DestinationPath = new System.Windows.Forms.TextBox();
            this.Label_DestinationPath = new System.Windows.Forms.Label();
            this.Group_File = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveFileDialog_Script = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // Dropdown_Method
            // 
            this.Dropdown_Method.FormattingEnabled = true;
            this.Dropdown_Method.Location = new System.Drawing.Point(71, 93);
            this.Dropdown_Method.Name = "Dropdown_Method";
            this.Dropdown_Method.Size = new System.Drawing.Size(200, 21);
            this.Dropdown_Method.TabIndex = 24;
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
            // Dropdown_FileType
            // 
            this.Dropdown_FileType.FormattingEnabled = true;
            this.Dropdown_FileType.Location = new System.Drawing.Point(71, 40);
            this.Dropdown_FileType.Name = "Dropdown_FileType";
            this.Dropdown_FileType.Size = new System.Drawing.Size(200, 21);
            this.Dropdown_FileType.TabIndex = 22;
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
            // Textbox_Password
            // 
            this.Textbox_Password.Location = new System.Drawing.Point(71, 13);
            this.Textbox_Password.MaxLength = 128;
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.Size = new System.Drawing.Size(200, 20);
            this.Textbox_Password.TabIndex = 19;
            this.Textbox_Password.UseSystemPasswordChar = true;
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
            this.Group_Globals.Controls.Add(this.button2);
            this.Group_Globals.Controls.Add(this.Button_ApplyGlobals);
            this.Group_Globals.Controls.Add(this.textBox1);
            this.Group_Globals.Controls.Add(this.Label_GlobalsWarning);
            this.Group_Globals.Controls.Add(this.label1);
            this.Group_Globals.Controls.Add(this.Label_Password);
            this.Group_Globals.Controls.Add(this.Label_Method);
            this.Group_Globals.Controls.Add(this.Textbox_Password);
            this.Group_Globals.Controls.Add(this.Dropdown_Method);
            this.Group_Globals.Controls.Add(this.Label_CompLevel);
            this.Group_Globals.Controls.Add(this.Label_Type);
            this.Group_Globals.Controls.Add(this.Numeric_CompLevel);
            this.Group_Globals.Controls.Add(this.Dropdown_FileType);
            this.Group_Globals.Location = new System.Drawing.Point(285, 87);
            this.Group_Globals.Name = "Group_Globals";
            this.Group_Globals.Size = new System.Drawing.Size(282, 316);
            this.Group_Globals.TabIndex = 26;
            this.Group_Globals.TabStop = false;
            this.Group_Globals.Text = "Global Controls";
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
            // Button_ApplyGlobals
            // 
            this.Button_ApplyGlobals.Location = new System.Drawing.Point(6, 259);
            this.Button_ApplyGlobals.Name = "Button_ApplyGlobals";
            this.Button_ApplyGlobals.Size = new System.Drawing.Size(270, 50);
            this.Button_ApplyGlobals.TabIndex = 4;
            this.Button_ApplyGlobals.Text = "Apply Globals";
            this.Button_ApplyGlobals.UseVisualStyleBackColor = true;
            // 
            // Button_Destination
            // 
            this.Button_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Destination.Location = new System.Drawing.Point(489, 12);
            this.Button_Destination.Name = "Button_Destination";
            this.Button_Destination.Size = new System.Drawing.Size(60, 20);
            this.Button_Destination.TabIndex = 29;
            this.Button_Destination.Text = "Browse...";
            this.Button_Destination.UseVisualStyleBackColor = true;
            // 
            // Textbox_DestinationPath
            // 
            this.Textbox_DestinationPath.Location = new System.Drawing.Point(78, 13);
            this.Textbox_DestinationPath.Name = "Textbox_DestinationPath";
            this.Textbox_DestinationPath.Size = new System.Drawing.Size(405, 20);
            this.Textbox_DestinationPath.TabIndex = 28;
            // 
            // Label_DestinationPath
            // 
            this.Label_DestinationPath.AutoSize = true;
            this.Label_DestinationPath.Location = new System.Drawing.Point(6, 16);
            this.Label_DestinationPath.Name = "Label_DestinationPath";
            this.Label_DestinationPath.Size = new System.Drawing.Size(66, 13);
            this.Label_DestinationPath.TabIndex = 27;
            this.Label_DestinationPath.Text = "Save File As";
            // 
            // Group_File
            // 
            this.Group_File.Controls.Add(this.Label_DestinationPath);
            this.Group_File.Controls.Add(this.Textbox_DestinationPath);
            this.Group_File.Controls.Add(this.Button_Destination);
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(216, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 20);
            this.button2.TabIndex = 35;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Destination";
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
        private System.Windows.Forms.ComboBox Dropdown_Method;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.ComboBox Dropdown_FileType;
        private System.Windows.Forms.NumericUpDown Numeric_CompLevel;
        private System.Windows.Forms.Label Label_CompLevel;
        private System.Windows.Forms.TextBox Textbox_Password;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.GroupBox Group_Globals;
        private System.Windows.Forms.Label Label_GlobalsWarning;
        private System.Windows.Forms.Button Button_ApplyGlobals;
        private System.Windows.Forms.Button Button_Destination;
        private System.Windows.Forms.TextBox Textbox_DestinationPath;
        private System.Windows.Forms.Label Label_DestinationPath;
        private System.Windows.Forms.GroupBox Group_File;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog_Script;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowse_Destination;
    }
}

