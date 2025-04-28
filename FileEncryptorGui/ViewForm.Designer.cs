namespace FileEncryptorGui
{
    partial class ViewForm
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
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.BackColor = System.Drawing.Color.Pink;
            this.listBoxFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxFiles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFiles.ForeColor = System.Drawing.Color.DarkMagenta;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 15;
            this.listBoxFiles.Location = new System.Drawing.Point(0, 0);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(281, 696);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // txtFileContent
            // 
            this.txtFileContent.BackColor = System.Drawing.Color.LightPink;
            this.txtFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileContent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileContent.ForeColor = System.Drawing.Color.DarkMagenta;
            this.txtFileContent.Location = new System.Drawing.Point(281, 0);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.ReadOnly = true;
            this.txtFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFileContent.Size = new System.Drawing.Size(822, 696);
            this.txtFileContent.TabIndex = 1;
            this.txtFileContent.TextChanged += new System.EventHandler(this.txtFileContent_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepPink;
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(524, 582);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(178, 41);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 696);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.listBoxFiles);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.Button btnBack;
    }
}