namespace ouoioBOT
{
    partial class Form2
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.logTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(7, 72);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(809, 374);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.NewWindow += new System.ComponentModel.CancelEventHandler(this.webBrowser1_NewWindow);
            // 
            // logTextBox
            // 
            // 
            // 
            // 
            this.logTextBox.CustomButton.Image = null;
            this.logTextBox.CustomButton.Location = new System.Drawing.Point(595, 2);
            this.logTextBox.CustomButton.Name = "";
            this.logTextBox.CustomButton.Size = new System.Drawing.Size(197, 197);
            this.logTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.logTextBox.CustomButton.TabIndex = 1;
            this.logTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.logTextBox.CustomButton.UseSelectable = true;
            this.logTextBox.CustomButton.Visible = false;
            this.logTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.logTextBox.Lines = new string[0];
            this.logTextBox.Location = new System.Drawing.Point(23, 452);
            this.logTextBox.MaxLength = 32767;
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.PasswordChar = '\0';
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBox.SelectedText = "";
            this.logTextBox.SelectionLength = 0;
            this.logTextBox.SelectionStart = 0;
            this.logTextBox.ShortcutsEnabled = true;
            this.logTextBox.Size = new System.Drawing.Size(795, 202);
            this.logTextBox.TabIndex = 1;
            this.logTextBox.UseSelectable = true;
            this.logTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.logTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 677);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form2";
            this.Resizable = false;
            this.Text = "Web Browser";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroTextBox logTextBox;
    }
}