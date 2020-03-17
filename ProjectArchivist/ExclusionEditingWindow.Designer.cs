namespace ProjectArchivist
{
    partial class ExclusionEditingWindow
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
            this.components = new System.ComponentModel.Container();
            this.Textbox_Name = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Checkbox_IsRecursive = new System.Windows.Forms.CheckBox();
            this.Button_ExitWithSave = new System.Windows.Forms.Button();
            this.Button_ExitWithoutSave = new System.Windows.Forms.Button();
            this.Tooltip_Recursion = new System.Windows.Forms.ToolTip(this.components);
            this.Tooltip_Exclusion = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Textbox_Name
            // 
            this.Textbox_Name.Location = new System.Drawing.Point(77, 12);
            this.Textbox_Name.MaxLength = 128;
            this.Textbox_Name.Name = "Textbox_Name";
            this.Textbox_Name.Size = new System.Drawing.Size(200, 20);
            this.Textbox_Name.TabIndex = 3;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(12, 16);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(52, 13);
            this.Label_Name.TabIndex = 2;
            this.Label_Name.Text = "Exclusion";
            // 
            // Checkbox_IsRecursive
            // 
            this.Checkbox_IsRecursive.AutoSize = true;
            this.Checkbox_IsRecursive.Location = new System.Drawing.Point(15, 38);
            this.Checkbox_IsRecursive.Name = "Checkbox_IsRecursive";
            this.Checkbox_IsRecursive.Size = new System.Drawing.Size(128, 17);
            this.Checkbox_IsRecursive.TabIndex = 5;
            this.Checkbox_IsRecursive.Text = "Recursive Exclusion?";
            this.Checkbox_IsRecursive.UseVisualStyleBackColor = true;
            // 
            // Button_ExitWithSave
            // 
            this.Button_ExitWithSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ExitWithSave.Location = new System.Drawing.Point(297, 12);
            this.Button_ExitWithSave.Name = "Button_ExitWithSave";
            this.Button_ExitWithSave.Size = new System.Drawing.Size(125, 30);
            this.Button_ExitWithSave.TabIndex = 26;
            this.Button_ExitWithSave.Text = "Save Item And Exit";
            this.Button_ExitWithSave.UseVisualStyleBackColor = true;
            // 
            // Button_ExitWithoutSave
            // 
            this.Button_ExitWithoutSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ExitWithoutSave.Location = new System.Drawing.Point(297, 48);
            this.Button_ExitWithoutSave.Name = "Button_ExitWithoutSave";
            this.Button_ExitWithoutSave.Size = new System.Drawing.Size(125, 30);
            this.Button_ExitWithoutSave.TabIndex = 25;
            this.Button_ExitWithoutSave.Text = "Exit Without Saving";
            this.Button_ExitWithoutSave.UseVisualStyleBackColor = true;
            // 
            // ExclusionEditingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 95);
            this.Controls.Add(this.Button_ExitWithSave);
            this.Controls.Add(this.Button_ExitWithoutSave);
            this.Controls.Add(this.Checkbox_IsRecursive);
            this.Controls.Add(this.Textbox_Name);
            this.Controls.Add(this.Label_Name);
            this.Name = "ExclusionEditingWindow";
            this.Text = "ExclusionEditingWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Textbox_Name;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.CheckBox Checkbox_IsRecursive;
        private System.Windows.Forms.Button Button_ExitWithSave;
        private System.Windows.Forms.Button Button_ExitWithoutSave;
        private System.Windows.Forms.ToolTip Tooltip_Recursion;
        private System.Windows.Forms.ToolTip Tooltip_Exclusion;
    }
}