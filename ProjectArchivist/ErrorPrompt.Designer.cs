namespace ProjectArchivist
{
    partial class ErrorPrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorPrompt));
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Label_ErrorDesc = new System.Windows.Forms.Label();
            this.Button_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.Location = new System.Drawing.Point(12, 13);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(112, 13);
            this.Label_Heading.TabIndex = 0;
            this.Label_Heading.Text = "An error has occurred:";
            // 
            // Label_ErrorDesc
            // 
            this.Label_ErrorDesc.AutoSize = true;
            this.Label_ErrorDesc.Location = new System.Drawing.Point(12, 35);
            this.Label_ErrorDesc.Name = "Label_ErrorDesc";
            this.Label_ErrorDesc.Size = new System.Drawing.Size(77, 13);
            this.Label_ErrorDesc.TabIndex = 1;
            this.Label_ErrorDesc.Text = "Unknown error";
            // 
            // Button_Close
            // 
            this.Button_Close.Location = new System.Drawing.Point(105, 226);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(75, 23);
            this.Button_Close.TabIndex = 2;
            this.Button_Close.Text = "Close";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // ErrorPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Label_ErrorDesc);
            this.Controls.Add(this.Label_Heading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "ErrorPrompt";
            this.Text = "An error has occurred";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Heading;
        private System.Windows.Forms.Label Label_ErrorDesc;
        private System.Windows.Forms.Button Button_Close;
    }
}