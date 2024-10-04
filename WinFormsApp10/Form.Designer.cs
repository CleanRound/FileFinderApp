namespace FileSearchApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.openSearchWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openSearchWindowButton
            // 
            this.openSearchWindowButton.Location = new System.Drawing.Point(30, 30);
            this.openSearchWindowButton.Name = "openSearchWindowButton";
            this.openSearchWindowButton.Size = new System.Drawing.Size(200, 50);
            this.openSearchWindowButton.TabIndex = 0;
            this.openSearchWindowButton.Text = "Open Search Window";
            this.openSearchWindowButton.UseVisualStyleBackColor = true;
            this.openSearchWindowButton.Click += new System.EventHandler(this.openSearchWindowButton_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.openSearchWindowButton);
            this.Name = "MainForm";
            this.Text = "File Search Application";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button openSearchWindowButton;
    }

    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.searchMaskTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // folderTextBox
            // 
            this.folderTextBox.Location = new System.Drawing.Point(30, 30);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(200, 22);
            this.folderTextBox.TabIndex = 0;
            // 
            // searchMaskTextBox
            // 
            this.searchMaskTextBox.Location = new System.Drawing.Point(30, 70);
            this.searchMaskTextBox.Name = "searchMaskTextBox";
            this.searchMaskTextBox.Size = new System.Drawing.Size(200, 22);
            this.searchMaskTextBox.TabIndex = 1;
            this.searchMaskTextBox.Text = "*.doc";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(240, 30);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(240, 70);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultsListBox
            // 
            this.searchResultsListBox.FormattingEnabled = true;
            this.searchResultsListBox.ItemHeight = 16;
            this.searchResultsListBox.Location = new System.Drawing.Point(30, 110);
            this.searchResultsListBox.Name = "searchResultsListBox";
            this.searchResultsListBox.Size = new System.Drawing.Size(285, 180);
            this.searchResultsListBox.TabIndex = 4;
            // 
            // SearchForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 320);
            this.Controls.Add(this.searchResultsListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.searchMaskTextBox);
            this.Controls.Add(this.folderTextBox);
            this.Name = "SearchForm";
            this.Text = "Search Files";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.TextBox searchMaskTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox searchResultsListBox;
    }
}
