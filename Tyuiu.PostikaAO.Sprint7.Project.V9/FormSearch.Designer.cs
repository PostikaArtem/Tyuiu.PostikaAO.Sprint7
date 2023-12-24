
namespace Tyuiu.PostikaAO.Sprint7.Project.V9
{
    partial class FormSearch
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
            this.textBoxSearch_PAO = new System.Windows.Forms.TextBox();
            this.buttonSearch_PAO = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearch_PAO
            // 
            this.textBoxSearch_PAO.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearch_PAO.Location = new System.Drawing.Point(12, 12);
            this.textBoxSearch_PAO.Multiline = true;
            this.textBoxSearch_PAO.Name = "textBoxSearch_PAO";
            this.textBoxSearch_PAO.Size = new System.Drawing.Size(172, 26);
            this.textBoxSearch_PAO.TabIndex = 1;
            this.textBoxSearch_PAO.Text = "Поиск...";
            this.textBoxSearch_PAO.TextChanged += new System.EventHandler(this.textBoxSearch_PAO_TextChanged);
            this.textBoxSearch_PAO.Enter += new System.EventHandler(this.textBoxSearch_PAO_Enter);
            this.textBoxSearch_PAO.Leave += new System.EventHandler(this.textBoxSearch_PAO_Leave);
            // 
            // buttonSearch_PAO
            // 
            this.buttonSearch_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch_PAO.Location = new System.Drawing.Point(190, 12);
            this.buttonSearch_PAO.Name = "buttonSearch_PAO";
            this.buttonSearch_PAO.Size = new System.Drawing.Size(89, 28);
            this.buttonSearch_PAO.TabIndex = 2;
            this.buttonSearch_PAO.Text = "Найти";
            this.buttonSearch_PAO.UseVisualStyleBackColor = true;
            this.buttonSearch_PAO.Click += new System.EventHandler(this.buttonSearch_PAO_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 52);
            this.Controls.Add(this.buttonSearch_PAO);
            this.Controls.Add(this.textBoxSearch_PAO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск фильма";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch_PAO;
        private System.Windows.Forms.Button buttonSearch_PAO;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}