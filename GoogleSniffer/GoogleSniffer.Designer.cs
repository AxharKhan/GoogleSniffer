namespace GoogleSniffer
{
    partial class GoogleSniffer
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
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.TextInput = new MetroFramework.Controls.MetroTextBox();
            this.SearchButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // TextInput
            // 
            // 
            // 
            // 
            this.TextInput.CustomButton.Image = null;
            this.TextInput.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.TextInput.CustomButton.Name = "";
            this.TextInput.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextInput.CustomButton.TabIndex = 1;
            this.TextInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextInput.CustomButton.UseSelectable = true;
            this.TextInput.CustomButton.Visible = false;
            this.TextInput.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextInput.Lines = new string[0];
            this.TextInput.Location = new System.Drawing.Point(174, 136);
            this.TextInput.MaxLength = 32767;
            this.TextInput.Name = "TextInput";
            this.TextInput.PasswordChar = '\0';
            this.TextInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextInput.SelectedText = "";
            this.TextInput.SelectionLength = 0;
            this.TextInput.SelectionStart = 0;
            this.TextInput.ShortcutsEnabled = true;
            this.TextInput.Size = new System.Drawing.Size(478, 50);
            this.TextInput.Style = MetroFramework.MetroColorStyle.White;
            this.TextInput.TabIndex = 0;
            this.TextInput.UseSelectable = true;
            this.TextInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextInput_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(360, 203);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(109, 30);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseSelectable = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // GoogleSniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TextInput);
            this.Name = "GoogleSniffer";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "GoogleSniffer";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Controls.MetroTextBox TextInput;
        private MetroFramework.Controls.MetroButton SearchButton;
    }
}