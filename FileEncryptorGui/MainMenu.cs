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
    public partial class MainMenu : Form
    {
        string folderPath = Path.Combine(Application.StartupPath, "UserFiles");
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnCreateFile_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide Main Menu

            using (var inputDialog = new InputDialog("Enter the file name:"))
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = inputDialog.InputText;

                    if (!Directory.Exists(folderPath))
                        Directory.CreateDirectory(folderPath);

                    if (!fileName.EndsWith(".txt"))
                        fileName += ".txt";

                    string fullPath = Path.Combine(folderPath, fileName);

                    // NEW: Ask for content
                    string content = "";
                    using (var contentDialog = new InputDialog("Enter file content:"))
                    {
                        if (contentDialog.ShowDialog() == DialogResult.OK)
                        {
                            content = contentDialog.InputText;
                        }
                    }

                    // Create file with content
                    File.WriteAllText(fullPath, content);

                    MessageBox.Show($"File '{fileName}' created with content in 'UserFiles' folder!");
                }
            }

            this.Show(); // Show Main Menu
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            EncryptForm encryptForm = new EncryptForm();
            encryptForm.ShowDialog();
        }

        private void btnDecryptFile_Click(object sender, EventArgs e)
        {
            DecryptForm decryptForm = new DecryptForm();
            decryptForm.ShowDialog();
        }

        private void btnViewFiles_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.ShowDialog();
        }
    }
}

