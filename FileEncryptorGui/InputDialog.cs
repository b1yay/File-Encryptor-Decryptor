using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEncryptorGui
{
    public partial class InputDialog : Form
    {
        public string InputText => txtInput.Text;

        public InputDialog(string prompt)
        {
            InitializeComponent();
            lblPrompt.Text = prompt;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Input cannot be empty!");
            }
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {
            txtInput.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
