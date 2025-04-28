using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEncryptorGui
{
    public partial class DeleteForm : Form
    {
        private string userFilesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserFiles");

        public DeleteForm()
        {
            InitializeComponent();
        }
        private void DeleteForm_Load(object sender, EventArgs e)
        {
            LoadFiles(); // This loads the list of files into the ListBox
        }

        private void LoadFiles()
        {
            listBoxFiles.Items.Clear();

            if (Directory.Exists(userFilesPath))
            {
                var files = Directory.GetFiles(userFilesPath);
                foreach (var file in files)
                {
                    listBoxFiles.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a file to delete.");
                return;
            }

            string selectedFile = listBoxFiles.SelectedItem.ToString();
            string fullPath = Path.Combine(userFilesPath, selectedFile);

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
                MessageBox.Show($"File '{selectedFile}' deleted successfully.");
                LoadFiles(); // Refresh list
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
