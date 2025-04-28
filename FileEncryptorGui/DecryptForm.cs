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
    public partial class DecryptForm : Form
    {
        private RSAParameters privateKey;
        private string userFilesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserFiles");

        public DecryptForm()
        {
            InitializeComponent();

        }

        private void DecryptForm_Load(object sender, EventArgs e)
        {
            LoadRsaKeys();
            // 👈 Needed for RSA decryption

            LoadEncryptedFiles();
        }
        private void LoadRsaKeys()
        {
            privateKey = RsaKeyManager.PrivateKey;  // Use shared key
        }


        private void LoadEncryptedFiles()
        {
            listBoxEncryptedFiles.Items.Clear();
            if (Directory.Exists(userFilesPath))
            {
                string[] files = Directory.GetFiles(userFilesPath);
                foreach (string file in files)
                {
                    // Assuming encrypted files have "_encrypted" in name
                    if (Path.GetFileName(file).Contains("_encrypted"))
                    {
                        listBoxEncryptedFiles.Items.Add(Path.GetFileName(file));
                    }
                }
            }
        }

        private string AesDecrypt(string cipherText, string key)
        {
            try
            {
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                byte[] keyBytes = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32));

                using (Aes aes = Aes.Create())
                {
                    aes.Key = keyBytes;
                    aes.IV = new byte[16]; // Must match the IV used in encryption

                    using (var decryptor = aes.CreateDecryptor())
                    using (var ms = new MemoryStream(cipherBytes))
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    using (var sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch
            {
                MessageBox.Show("AES Decryption failed. File might be corrupted or key is invalid.");
                return "";
            }
        }
        private string RSADecrypt(string encryptedText)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.ImportParameters(privateKey);
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, false);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (listBoxEncryptedFiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a file to decrypt.");
                return;
            }

            string selectedFile = listBoxEncryptedFiles.SelectedItem.ToString();
            string fullPath = Path.Combine(userFilesPath, selectedFile);
            string decryptedFileName = selectedFile.Replace("_encrypted", "_decrypted");
            string decryptedPath = Path.Combine(userFilesPath, decryptedFileName);

            // Detect encryption method from file name
            string method = "ASCII Shift"; // default
            if (selectedFile.Contains("ReverseText"))
                method = "Reverse Text";
            else if (selectedFile.Contains("Base64Encode"))
                method = "Base64 Encode";
            else if (selectedFile.Contains("AES")) // 🔹 Add this line
                method = "AES";

            try
            {
                string encryptedContent = File.ReadAllText(fullPath);
                string decryptedContent = DecryptText(encryptedContent, method);
                File.WriteAllText(decryptedPath, decryptedContent);

                MessageBox.Show("File decrypted successfully!");
                LoadEncryptedFiles(); // Refresh list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error decrypting file: " + ex.Message);
            }
        }


        private string DecryptText(string input, string method)
        {
            switch (method)
            {
                case "ASCII Shift":
                    return new string(input.Select(c => (char)(c - 3)).ToArray());

                case "Reverse Text":
                    return new string(input.Reverse().ToArray());

                case "Base64 Encode":
                    try
                    {
                        byte[] data = Convert.FromBase64String(input);
                        return Encoding.UTF8.GetString(data);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Base64 encoded content.");
                        return "";
                    }

                case "AES":
                    return AesDecrypt(input, "MySecretKey123"); // Use same key as encryption

                case "RSA":
                    return RSADecrypt(input);

                default:
                    return input;
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxEncryptedFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
