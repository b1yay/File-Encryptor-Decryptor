namespace FileEncryptorGui
{
    partial class EncryptForm
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
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBoxEncryptionMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFiles
            // 
            this.lstFiles.BackColor = System.Drawing.Color.LavenderBlush;
            this.lstFiles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 22;
            this.lstFiles.Location = new System.Drawing.Point(56, 105);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(395, 136);
            this.lstFiles.TabIndex = 0;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            this.lstFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFiles_KeyDown_1);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.LightPink;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncrypt.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(649, 339);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(153, 45);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose the file you want to Encrypt";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightPink;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(368, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(153, 45);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBoxEncryptionMethod
            // 
            this.comboBoxEncryptionMethod.BackColor = System.Drawing.Color.LavenderBlush;
            this.comboBoxEncryptionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncryptionMethod.DropDownWidth = 500;
            this.comboBoxEncryptionMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxEncryptionMethod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEncryptionMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.comboBoxEncryptionMethod.FormattingEnabled = true;
            this.comboBoxEncryptionMethod.Location = new System.Drawing.Point(690, 105);
            this.comboBoxEncryptionMethod.Name = "comboBoxEncryptionMethod";
            this.comboBoxEncryptionMethod.Size = new System.Drawing.Size(212, 20);
            this.comboBoxEncryptionMethod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(685, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Encryption Method:";
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::FileEncryptorGui.Properties.Resources.Blue_and_Teal_Big_Bright_and_Bold_Ai_Technology_Banner__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 696);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEncryptionMethod);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lstFiles);
            this.Name = "EncryptForm";
            this.Text = "EncryptForm";
            this.Load += new System.EventHandler(this.EncryptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboBoxEncryptionMethod;
        private System.Windows.Forms.Label label2;
    }
}