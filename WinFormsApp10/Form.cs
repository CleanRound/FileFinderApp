using System;
using System.IO;
using System.Windows.Forms;

namespace FileSearchApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void openSearchWindowButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
    }

    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    folderTextBox.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string folderPath = folderTextBox.Text;
            string searchMask = searchMaskTextBox.Text;

            if (string.IsNullOrWhiteSpace(folderPath) || string.IsNullOrWhiteSpace(searchMask))
            {
                MessageBox.Show("Please specify both the folder and the search mask.");
                return;
            }

            searchResultsListBox.Items.Clear();

            try
            {
                string[] files = Directory.GetFiles(folderPath, searchMask);

                foreach (var file in files)
                {
                    searchResultsListBox.Items.Add(Path.GetFileName(file));
                }

                if (files.Length == 0)
                {
                    MessageBox.Show("No files found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
