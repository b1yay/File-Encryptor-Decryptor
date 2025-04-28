namespace FileEncryptorGui
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnEncryptFile = new System.Windows.Forms.Button();
            this.btnDecryptFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnViewFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(274, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILE ENCRYPTOR/DECRYPTOR";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.BackColor = System.Drawing.Color.HotPink;
            this.btnCreateFile.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCreateFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreateFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreateFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateFile.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateFile.Location = new System.Drawing.Point(308, 187);
            this.btnCreateFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(139, 53);
            this.btnCreateFile.TabIndex = 1;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = false;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click_1);
            // 
            // btnEncryptFile
            // 
            this.btnEncryptFile.BackColor = System.Drawing.Color.HotPink;
            this.btnEncryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnEncryptFile.FlatAppearance.BorderSize = 100;
            this.btnEncryptFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEncryptFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEncryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncryptFile.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEncryptFile.Location = new System.Drawing.Point(589, 187);
            this.btnEncryptFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEncryptFile.Name = "btnEncryptFile";
            this.btnEncryptFile.Size = new System.Drawing.Size(139, 53);
            this.btnEncryptFile.TabIndex = 2;
            this.btnEncryptFile.Text = "Encrypt File";
            this.btnEncryptFile.UseVisualStyleBackColor = false;
            this.btnEncryptFile.Click += new System.EventHandler(this.btnEncryptFile_Click);
            // 
            // btnDecryptFile
            // 
            this.btnDecryptFile.BackColor = System.Drawing.Color.HotPink;
            this.btnDecryptFile.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnDecryptFile.FlatAppearance.BorderSize = 100;
            this.btnDecryptFile.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDecryptFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDecryptFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDecryptFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecryptFile.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDecryptFile.Location = new System.Drawing.Point(589, 306);
            this.btnDecryptFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDecryptFile.Name = "btnDecryptFile";
            this.btnDecryptFile.Size = new System.Drawing.Size(139, 53);
            this.btnDecryptFile.TabIndex = 3;
            this.btnDecryptFile.Text = "Decrypt File";
            this.btnDecryptFile.UseVisualStyleBackColor = false;
            this.btnDecryptFile.Click += new System.EventHandler(this.btnDecryptFile_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.BackColor = System.Drawing.Color.HotPink;
            this.btnDeleteFile.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnDeleteFile.FlatAppearance.BorderSize = 100;
            this.btnDeleteFile.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteFile.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteFile.Location = new System.Drawing.Point(308, 306);
            this.btnDeleteFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(139, 53);
            this.btnDeleteFile.TabIndex = 4;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnViewFiles
            // 
            this.btnViewFiles.BackColor = System.Drawing.Color.HotPink;
            this.btnViewFiles.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnViewFiles.FlatAppearance.BorderSize = 100;
            this.btnViewFiles.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewFiles.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFiles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewFiles.Location = new System.Drawing.Point(456, 415);
            this.btnViewFiles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnViewFiles.Name = "btnViewFiles";
            this.btnViewFiles.Size = new System.Drawing.Size(139, 53);
            this.btnViewFiles.TabIndex = 5;
            this.btnViewFiles.Text = "View Files";
            this.btnViewFiles.UseVisualStyleBackColor = false;
            this.btnViewFiles.Click += new System.EventHandler(this.btnViewFiles_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 696);
            this.Controls.Add(this.btnViewFiles);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnDecryptFile);
            this.Controls.Add(this.btnEncryptFile);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnEncryptFile;
        private System.Windows.Forms.Button btnDecryptFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnViewFiles;
    }
}