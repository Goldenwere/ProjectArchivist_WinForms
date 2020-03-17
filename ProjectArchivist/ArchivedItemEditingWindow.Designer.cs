namespace ProjectArchivist
{
    partial class ArchivedItemEditingWindow
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
            this.Label_ItemName = new System.Windows.Forms.Label();
            this.Textbox_ItemName = new System.Windows.Forms.TextBox();
            this.Label_SourcePath = new System.Windows.Forms.Label();
            this.Textbox_SourcePath = new System.Windows.Forms.TextBox();
            this.FolderBrowse_Source = new System.Windows.Forms.FolderBrowserDialog();
            this.Button_Source = new System.Windows.Forms.Button();
            this.Label_DestinationPath = new System.Windows.Forms.Label();
            this.Textbox_DestinationPath = new System.Windows.Forms.TextBox();
            this.Button_Destination = new System.Windows.Forms.Button();
            this.FolderBrowse_Destination = new System.Windows.Forms.FolderBrowserDialog();
            this.Label_FileName = new System.Windows.Forms.Label();
            this.Textbox_FileName = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Textbox_Password = new System.Windows.Forms.TextBox();
            this.Label_CompLevel = new System.Windows.Forms.Label();
            this.Numeric_CompLevel = new System.Windows.Forms.NumericUpDown();
            this.Dropdown_FileType = new System.Windows.Forms.ComboBox();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Dropdown_Method = new System.Windows.Forms.ComboBox();
            this.Label_Method = new System.Windows.Forms.Label();
            this.List_Exclusions = new System.Windows.Forms.ListBox();
            this.Label_Exclusions = new System.Windows.Forms.Label();
            this.Button_ExclusionsAdd = new System.Windows.Forms.Button();
            this.Button_ExclusionsRemove = new System.Windows.Forms.Button();
            this.Button_ExclusionsEdit = new System.Windows.Forms.Button();
            this.Button_ExitWithoutSave = new System.Windows.Forms.Button();
            this.Button_ExitWithSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CompLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_ItemName
            // 
            this.Label_ItemName.AutoSize = true;
            this.Label_ItemName.Location = new System.Drawing.Point(12, 16);
            this.Label_ItemName.Name = "Label_ItemName";
            this.Label_ItemName.Size = new System.Drawing.Size(58, 13);
            this.Label_ItemName.TabIndex = 0;
            this.Label_ItemName.Text = "Item Name";
            // 
            // Textbox_ItemName
            // 
            this.Textbox_ItemName.Location = new System.Drawing.Point(77, 12);
            this.Textbox_ItemName.MaxLength = 128;
            this.Textbox_ItemName.Name = "Textbox_ItemName";
            this.Textbox_ItemName.Size = new System.Drawing.Size(200, 20);
            this.Textbox_ItemName.TabIndex = 1;
            // 
            // Label_SourcePath
            // 
            this.Label_SourcePath.AutoSize = true;
            this.Label_SourcePath.Location = new System.Drawing.Point(12, 41);
            this.Label_SourcePath.Name = "Label_SourcePath";
            this.Label_SourcePath.Size = new System.Drawing.Size(41, 13);
            this.Label_SourcePath.TabIndex = 2;
            this.Label_SourcePath.Text = "Source";
            // 
            // Textbox_SourcePath
            // 
            this.Textbox_SourcePath.Location = new System.Drawing.Point(77, 38);
            this.Textbox_SourcePath.Name = "Textbox_SourcePath";
            this.Textbox_SourcePath.Size = new System.Drawing.Size(200, 20);
            this.Textbox_SourcePath.TabIndex = 3;
            // 
            // FolderBrowse_Source
            // 
            this.FolderBrowse_Source.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Button_Source
            // 
            this.Button_Source.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Source.Location = new System.Drawing.Point(284, 38);
            this.Button_Source.Name = "Button_Source";
            this.Button_Source.Size = new System.Drawing.Size(60, 20);
            this.Button_Source.TabIndex = 4;
            this.Button_Source.Text = "Browse...";
            this.Button_Source.UseVisualStyleBackColor = true;
            // 
            // Label_DestinationPath
            // 
            this.Label_DestinationPath.AutoSize = true;
            this.Label_DestinationPath.Location = new System.Drawing.Point(12, 67);
            this.Label_DestinationPath.Name = "Label_DestinationPath";
            this.Label_DestinationPath.Size = new System.Drawing.Size(60, 13);
            this.Label_DestinationPath.TabIndex = 5;
            this.Label_DestinationPath.Text = "Destination";
            // 
            // Textbox_DestinationPath
            // 
            this.Textbox_DestinationPath.Location = new System.Drawing.Point(77, 64);
            this.Textbox_DestinationPath.Name = "Textbox_DestinationPath";
            this.Textbox_DestinationPath.Size = new System.Drawing.Size(200, 20);
            this.Textbox_DestinationPath.TabIndex = 6;
            // 
            // Button_Destination
            // 
            this.Button_Destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Destination.Location = new System.Drawing.Point(284, 63);
            this.Button_Destination.Name = "Button_Destination";
            this.Button_Destination.Size = new System.Drawing.Size(60, 20);
            this.Button_Destination.TabIndex = 7;
            this.Button_Destination.Text = "Browse...";
            this.Button_Destination.UseVisualStyleBackColor = true;
            // 
            // FolderBrowse_Destination
            // 
            this.FolderBrowse_Destination.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Label_FileName
            // 
            this.Label_FileName.AutoSize = true;
            this.Label_FileName.Location = new System.Drawing.Point(12, 93);
            this.Label_FileName.Name = "Label_FileName";
            this.Label_FileName.Size = new System.Drawing.Size(54, 13);
            this.Label_FileName.TabIndex = 8;
            this.Label_FileName.Text = "File Name";
            // 
            // Textbox_FileName
            // 
            this.Textbox_FileName.Location = new System.Drawing.Point(77, 90);
            this.Textbox_FileName.MaxLength = 128;
            this.Textbox_FileName.Name = "Textbox_FileName";
            this.Textbox_FileName.Size = new System.Drawing.Size(200, 20);
            this.Textbox_FileName.TabIndex = 9;
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(12, 119);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(53, 13);
            this.Label_Password.TabIndex = 10;
            this.Label_Password.Text = "Password";
            // 
            // Textbox_Password
            // 
            this.Textbox_Password.Location = new System.Drawing.Point(77, 116);
            this.Textbox_Password.MaxLength = 128;
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.Size = new System.Drawing.Size(200, 20);
            this.Textbox_Password.TabIndex = 11;
            this.Textbox_Password.UseSystemPasswordChar = true;
            // 
            // Label_CompLevel
            // 
            this.Label_CompLevel.AutoSize = true;
            this.Label_CompLevel.Location = new System.Drawing.Point(12, 172);
            this.Label_CompLevel.Name = "Label_CompLevel";
            this.Label_CompLevel.Size = new System.Drawing.Size(96, 13);
            this.Label_CompLevel.TabIndex = 12;
            this.Label_CompLevel.Text = "Compression Level";
            // 
            // Numeric_CompLevel
            // 
            this.Numeric_CompLevel.Location = new System.Drawing.Point(177, 170);
            this.Numeric_CompLevel.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.Numeric_CompLevel.Name = "Numeric_CompLevel";
            this.Numeric_CompLevel.Size = new System.Drawing.Size(100, 20);
            this.Numeric_CompLevel.TabIndex = 13;
            // 
            // Dropdown_FileType
            // 
            this.Dropdown_FileType.FormattingEnabled = true;
            this.Dropdown_FileType.Location = new System.Drawing.Point(77, 143);
            this.Dropdown_FileType.Name = "Dropdown_FileType";
            this.Dropdown_FileType.Size = new System.Drawing.Size(200, 21);
            this.Dropdown_FileType.TabIndex = 14;
            // 
            // Label_Type
            // 
            this.Label_Type.AutoSize = true;
            this.Label_Type.Location = new System.Drawing.Point(12, 146);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(50, 13);
            this.Label_Type.TabIndex = 15;
            this.Label_Type.Text = "File Type";
            // 
            // Dropdown_Method
            // 
            this.Dropdown_Method.FormattingEnabled = true;
            this.Dropdown_Method.Location = new System.Drawing.Point(77, 196);
            this.Dropdown_Method.Name = "Dropdown_Method";
            this.Dropdown_Method.Size = new System.Drawing.Size(200, 21);
            this.Dropdown_Method.TabIndex = 16;
            // 
            // Label_Method
            // 
            this.Label_Method.AutoSize = true;
            this.Label_Method.Location = new System.Drawing.Point(12, 199);
            this.Label_Method.Name = "Label_Method";
            this.Label_Method.Size = new System.Drawing.Size(43, 13);
            this.Label_Method.TabIndex = 17;
            this.Label_Method.Text = "Method";
            // 
            // List_Exclusions
            // 
            this.List_Exclusions.FormattingEnabled = true;
            this.List_Exclusions.Location = new System.Drawing.Point(400, 38);
            this.List_Exclusions.Name = "List_Exclusions";
            this.List_Exclusions.Size = new System.Drawing.Size(100, 173);
            this.List_Exclusions.TabIndex = 18;
            // 
            // Label_Exclusions
            // 
            this.Label_Exclusions.AutoSize = true;
            this.Label_Exclusions.Location = new System.Drawing.Point(397, 12);
            this.Label_Exclusions.Name = "Label_Exclusions";
            this.Label_Exclusions.Size = new System.Drawing.Size(57, 13);
            this.Label_Exclusions.TabIndex = 19;
            this.Label_Exclusions.Text = "Exclusions";
            // 
            // Button_ExclusionsAdd
            // 
            this.Button_ExclusionsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ExclusionsAdd.Location = new System.Drawing.Point(506, 38);
            this.Button_ExclusionsAdd.Name = "Button_ExclusionsAdd";
            this.Button_ExclusionsAdd.Size = new System.Drawing.Size(60, 50);
            this.Button_ExclusionsAdd.TabIndex = 20;
            this.Button_ExclusionsAdd.Text = "Add";
            this.Button_ExclusionsAdd.UseVisualStyleBackColor = true;
            // 
            // Button_ExclusionsRemove
            // 
            this.Button_ExclusionsRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ExclusionsRemove.Location = new System.Drawing.Point(506, 100);
            this.Button_ExclusionsRemove.Name = "Button_ExclusionsRemove";
            this.Button_ExclusionsRemove.Size = new System.Drawing.Size(60, 50);
            this.Button_ExclusionsRemove.TabIndex = 21;
            this.Button_ExclusionsRemove.Text = "Remove";
            this.Button_ExclusionsRemove.UseVisualStyleBackColor = true;
            // 
            // Button_ExclusionsEdit
            // 
            this.Button_ExclusionsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ExclusionsEdit.Location = new System.Drawing.Point(506, 161);
            this.Button_ExclusionsEdit.Name = "Button_ExclusionsEdit";
            this.Button_ExclusionsEdit.Size = new System.Drawing.Size(60, 50);
            this.Button_ExclusionsEdit.TabIndex = 22;
            this.Button_ExclusionsEdit.Text = "Edit";
            this.Button_ExclusionsEdit.UseVisualStyleBackColor = true;
            // 
            // Button_ExitWithoutSave
            // 
            this.Button_ExitWithoutSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ExitWithoutSave.Location = new System.Drawing.Point(647, 191);
            this.Button_ExitWithoutSave.Name = "Button_ExitWithoutSave";
            this.Button_ExitWithoutSave.Size = new System.Drawing.Size(125, 30);
            this.Button_ExitWithoutSave.TabIndex = 23;
            this.Button_ExitWithoutSave.Text = "Exit Without Saving";
            this.Button_ExitWithoutSave.UseVisualStyleBackColor = true;
            // 
            // Button_ExitWithSave
            // 
            this.Button_ExitWithSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ExitWithSave.Location = new System.Drawing.Point(647, 155);
            this.Button_ExitWithSave.Name = "Button_ExitWithSave";
            this.Button_ExitWithSave.Size = new System.Drawing.Size(125, 30);
            this.Button_ExitWithSave.TabIndex = 24;
            this.Button_ExitWithSave.Text = "Save Item And Exit";
            this.Button_ExitWithSave.UseVisualStyleBackColor = true;
            // 
            // ArchivedItemEditingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 233);
            this.Controls.Add(this.Button_ExitWithSave);
            this.Controls.Add(this.Button_ExitWithoutSave);
            this.Controls.Add(this.Button_ExclusionsEdit);
            this.Controls.Add(this.Button_ExclusionsRemove);
            this.Controls.Add(this.Button_ExclusionsAdd);
            this.Controls.Add(this.Label_Exclusions);
            this.Controls.Add(this.List_Exclusions);
            this.Controls.Add(this.Label_Method);
            this.Controls.Add(this.Dropdown_Method);
            this.Controls.Add(this.Label_Type);
            this.Controls.Add(this.Dropdown_FileType);
            this.Controls.Add(this.Numeric_CompLevel);
            this.Controls.Add(this.Label_CompLevel);
            this.Controls.Add(this.Textbox_Password);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Textbox_FileName);
            this.Controls.Add(this.Label_FileName);
            this.Controls.Add(this.Button_Destination);
            this.Controls.Add(this.Textbox_DestinationPath);
            this.Controls.Add(this.Label_DestinationPath);
            this.Controls.Add(this.Button_Source);
            this.Controls.Add(this.Textbox_SourcePath);
            this.Controls.Add(this.Label_SourcePath);
            this.Controls.Add(this.Textbox_ItemName);
            this.Controls.Add(this.Label_ItemName);
            this.Name = "ArchivedItemEditingWindow";
            this.Text = "Editing item...";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_CompLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ItemName;
        private System.Windows.Forms.TextBox Textbox_ItemName;
        private System.Windows.Forms.Label Label_SourcePath;
        private System.Windows.Forms.TextBox Textbox_SourcePath;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowse_Source;
        private System.Windows.Forms.Button Button_Source;
        private System.Windows.Forms.Label Label_DestinationPath;
        private System.Windows.Forms.TextBox Textbox_DestinationPath;
        private System.Windows.Forms.Button Button_Destination;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowse_Destination;
        private System.Windows.Forms.Label Label_FileName;
        private System.Windows.Forms.TextBox Textbox_FileName;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.TextBox Textbox_Password;
        private System.Windows.Forms.Label Label_CompLevel;
        private System.Windows.Forms.NumericUpDown Numeric_CompLevel;
        private System.Windows.Forms.ComboBox Dropdown_FileType;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.ComboBox Dropdown_Method;
        private System.Windows.Forms.Label Label_Method;
        private System.Windows.Forms.ListBox List_Exclusions;
        private System.Windows.Forms.Label Label_Exclusions;
        private System.Windows.Forms.Button Button_ExclusionsAdd;
        private System.Windows.Forms.Button Button_ExclusionsRemove;
        private System.Windows.Forms.Button Button_ExclusionsEdit;
        private System.Windows.Forms.Button Button_ExitWithoutSave;
        private System.Windows.Forms.Button Button_ExitWithSave;
    }
}