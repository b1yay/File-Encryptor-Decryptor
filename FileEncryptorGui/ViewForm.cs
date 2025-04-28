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
    public partial class ViewForm : Form
    {
        private string userFilesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserFiles");

        public ViewForm()
        {
            InitializeComponent();
            LoadFiles();
        }

        private void LoadFiles()
        {
            listBoxFiles.Items.Clear();
            if (Directory.Exists(userFilesPath))
            {
                string[] files = Directory.GetFiles(userFilesPath);
                foreach (string file in files)
                {
                    listBoxFiles.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void txtFileContent_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty if you don't need it
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem != null)
            {
                string selectedFile = listBoxFiles.SelectedItem.ToString();
                string fullPath = Path.Combine(userFilesPath, selectedFile);

                if (File.Exists(fullPath))
                {
                    string content = File.ReadAllText(fullPath);
                    txtFileContent.Text = content;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form
        }
    }
}
