namespace ouoioBOT
{
    partial class Form1
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
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.deviceStatus = new MetroFramework.Controls.MetroLabel();
            this.consoleOutput = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(209, 2);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(213, 150);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
           this.metroTextBox1.PromptText = "Örn: ouo.io/XYz5f";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(235, 28);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Örn: ouo.io/XYz5f";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 150);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(141, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Gidilecek URL Adresi:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(807, 506);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Cihaz Durumu:";
            // 
            // deviceStatus
            // 
            this.deviceStatus.AutoSize = true;
            this.deviceStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.deviceStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.deviceStatus.Location = new System.Drawing.Point(930, 506);
            this.deviceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceStatus.Name = "deviceStatus";
            this.deviceStatus.Size = new System.Drawing.Size(87, 20);
            this.deviceStatus.TabIndex = 3;
            this.deviceStatus.Text = "metroLabel3";
            this.deviceStatus.UseCustomForeColor = true;
            // 
            // consoleOutput
            // 
            // 
            // 
            // 
            this.consoleOutput.CustomButton.Image = null;
            this.consoleOutput.CustomButton.Location = new System.Drawing.Point(587, 2);
            this.consoleOutput.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.consoleOutput.CustomButton.Name = "";
            this.consoleOutput.CustomButton.Size = new System.Drawing.Size(157, 157);
            this.consoleOutput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.consoleOutput.CustomButton.TabIndex = 1;
            this.consoleOutput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.consoleOutput.CustomButton.UseSelectable = true;
            this.consoleOutput.CustomButton.Visible = false;
            this.consoleOutput.Lines = new string[0];
            this.consoleOutput.Location = new System.Drawing.Point(29, 383);
            this.consoleOutput.Margin = new System.Windows.Forms.Padding(4);
            this.consoleOutput.MaxLength = 32767;
            this.consoleOutput.Multiline = true;
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.PasswordChar = '\0';
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleOutput.SelectedText = "";
            this.consoleOutput.SelectionLength = 0;
            this.consoleOutput.SelectionStart = 0;
            this.consoleOutput.ShortcutsEnabled = true;
            this.consoleOutput.Size = new System.Drawing.Size(747, 162);
            this.consoleOutput.TabIndex = 4;
            this.consoleOutput.UseSelectable = true;
            this.consoleOutput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.consoleOutput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.consoleOutput.TextChanged += new System.EventHandler(this.consoleOutput_TextChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(30, 204);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(418, 106);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Başla";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.consoleOutput);
            this.Controls.Add(this.deviceStatus);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "ouo.io BOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel deviceStatus;
        private MetroFramework.Controls.MetroTextBox consoleOutput;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

