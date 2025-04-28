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
using System.Security.Cryptography;

namespace FileEncryptorGui
{
    public partial class EncryptForm : Form
    {
        // 🔐 RSA key pair
        private RSAParameters publicKey;
        private RSAParameters privateKey;

        string folderPath = Path.Combine(Application.StartupPath, "UserFiles");

        public EncryptForm()
        {
            InitializeComponent();
        }

        private void LoadFileList()
        {
            if (Directory.Exists(folderPath))
            {
                var files = Directory.GetFiles(folderPath, "*.txt")
                                     .Select(f => Path.GetFileName(f))
                                     .ToArray();
                lstFiles.Items.AddRange(files);
            }
        }
        private void EncryptForm_Load(object sender, EventArgs e)
        {
            LoadFileList();
            comboBoxEncryptionMethod.Items.Clear();
            comboBoxEncryptionMethod.Items.Add("ASCII Shift (+3)");
            comboBoxEncryptionMethod.Items.Add("Reverse Text");
            comboBoxEncryptionMethod.Items.Add("Base64 Encode");
            comboBoxEncryptionMethod.Items.Add("AES");
           // comboBoxEncryptionMethod.Items.Add("RSA");

            comboBoxEncryptionMethod.SelectedIndex = 0; // optional: selects first option by default
            GenerateKeys(); // 👈 Call this to initialize RSA keys

        }
        private void GenerateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                publicKey = rsa.ExportParameters(false);  // public key
                privateKey = rsa.ExportParameters(true);  // private + public key
            }
        }

        private void lstFiles_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EncryptSelectedFile();
                e.Handled = true;
            }
        }
        private void EncryptSelectedFile()
        {
            if (lstFiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a file from the list.");
                return;
            }

            string fileName = lstFiles.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please select or enter a file name.");
                return;
            }

            string fullPath = Path.Combine(folderPath, fileName);
            if (!File.Exists(fullPath))
            {
                MessageBox.Show("File does not exist.");
                return;
            }

            string content = File.ReadAllText(fullPath);
            string encrypted = new string(content.Select(c => (char)(c + 3)).ToArray());

            string encryptedFileName = Path.GetFileNameWithoutExtension(fileName) + "_encrypted.txt";
            string encryptedPath = Path.Combine(folderPath, encryptedFileName);

            File.WriteAllText(encryptedPath, encrypted);

            MessageBox.Show($"Encrypted file saved as '{encryptedFileName}' in UserFiles.");
        }
        private string EncryptText(string input, string method)
        {
            switch (method)
            {
                case "ASCII Shift (+3)":
                    return new string(input.Select(c => (char)(c + 3)).ToArray());

                case "Reverse Text":
                    return new string(input.Reverse().ToArray());

                case "Base64 Encode":
                    byte[] bytes = Encoding.UTF8.GetBytes(input);
                    return Convert.ToBase64String(bytes);

                case "AES":
                    return AesEncrypt(input, "MySecretKey123"); // Replace with user input later if desired
                case "RSA":
                    return RSAEncrypt(input);

                default:
                    return input;
            }
        }
        private string RSAEncrypt(string input)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(RsaKeyManager.PublicKey);
                byte[] bytesToEncrypt = Encoding.UTF8.GetBytes(input);
                byte[] encryptedBytes = rsa.Encrypt(bytesToEncrypt, false);
                return Convert.ToBase64String(encryptedBytes);
            }
        }


        private string AesEncrypt(string plainText, string key)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32)); //key agr 32 spaces se choti ho tou left right white spaces pad hojati hein to cut it exactlt to 32 spaces
                aes.Key = keyBytes;
                aes.IV = new byte[16]; // IV is a 16 byte array full of zeros (zero for simplicity)

                using (var encryptor = aes.CreateEncryptor())
                using (var ms = new MemoryStream())
                using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (var sw = new StreamWriter(cs))
                {
                    sw.Write(plainText);
                    sw.Close();
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            if (lstFiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a file from the list.");
                return;
            }

            string fileName = lstFiles.SelectedItem.ToString();
            string fullPath = Path.Combine(folderPath, fileName);

            if (!File.Exists(fullPath))
            {
                MessageBox.Show("File does not exist.");
                return;
            }

            string method = comboBoxEncryptionMethod.SelectedItem.ToString();
            string originalContent = File.ReadAllText(fullPath);
            string encryptedContent = EncryptText(originalContent, method);

            string methodTag = method.Replace(" ", "").Replace("+", "Plus"); // make it filename-safe
            string encryptedFileName = Path.GetFileNameWithoutExtension(fileName) + $"_{methodTag}_encrypted.txt";
            string encryptedPath = Path.Combine(folderPath, encryptedFileName);

            File.WriteAllText(encryptedPath, encryptedContent);

            MessageBox.Show($"Encrypted file saved as '{encryptedFileName}' in UserFiles.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
