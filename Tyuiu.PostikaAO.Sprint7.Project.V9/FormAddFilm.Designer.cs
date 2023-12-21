
namespace Tyuiu.PostikaAO.Sprint7.Project.V9
{
    partial class FormAddFilm
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
            this.textBoxlName_PAO = new System.Windows.Forms.TextBox();
            this.textBoxRole_PAO = new System.Windows.Forms.TextBox();
            this.textBoxYear_PAO = new System.Windows.Forms.TextBox();
            this.textBoxDescription_PAO = new System.Windows.Forms.TextBox();
            this.textBoxDirector_PAO = new System.Windows.Forms.TextBox();
            this.textBoxGenre_PAO = new System.Windows.Forms.TextBox();
            this.textBoxScreenwriter_PAO = new System.Windows.Forms.TextBox();
            this.textBoxStudio_PAO = new System.Windows.Forms.TextBox();
            this.textBoxCountry_PAO = new System.Windows.Forms.TextBox();
            this.buttonAdd_PAO = new System.Windows.Forms.Button();
            this.pictureBoxPreview_PAO = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview_PAO)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxlName_PAO
            // 
            this.textBoxlName_PAO.Location = new System.Drawing.Point(337, 56);
            this.textBoxlName_PAO.Name = "textBoxlName_PAO";
            this.textBoxlName_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxlName_PAO.TabIndex = 0;
            // 
            // textBoxRole_PAO
            // 
            this.textBoxRole_PAO.Location = new System.Drawing.Point(475, 56);
            this.textBoxRole_PAO.Name = "textBoxRole_PAO";
            this.textBoxRole_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxRole_PAO.TabIndex = 1;
            // 
            // textBoxYear_PAO
            // 
            this.textBoxYear_PAO.Location = new System.Drawing.Point(337, 118);
            this.textBoxYear_PAO.Name = "textBoxYear_PAO";
            this.textBoxYear_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxYear_PAO.TabIndex = 2;
            // 
            // textBoxDescription_PAO
            // 
            this.textBoxDescription_PAO.Location = new System.Drawing.Point(475, 238);
            this.textBoxDescription_PAO.Name = "textBoxDescription_PAO";
            this.textBoxDescription_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxDescription_PAO.TabIndex = 3;
            // 
            // textBoxDirector_PAO
            // 
            this.textBoxDirector_PAO.Location = new System.Drawing.Point(337, 238);
            this.textBoxDirector_PAO.Name = "textBoxDirector_PAO";
            this.textBoxDirector_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxDirector_PAO.TabIndex = 4;
            // 
            // textBoxGenre_PAO
            // 
            this.textBoxGenre_PAO.Location = new System.Drawing.Point(337, 183);
            this.textBoxGenre_PAO.Name = "textBoxGenre_PAO";
            this.textBoxGenre_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxGenre_PAO.TabIndex = 5;
            // 
            // textBoxScreenwriter_PAO
            // 
            this.textBoxScreenwriter_PAO.Location = new System.Drawing.Point(337, 298);
            this.textBoxScreenwriter_PAO.Name = "textBoxScreenwriter_PAO";
            this.textBoxScreenwriter_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxScreenwriter_PAO.TabIndex = 6;
            // 
            // textBoxStudio_PAO
            // 
            this.textBoxStudio_PAO.Location = new System.Drawing.Point(475, 183);
            this.textBoxStudio_PAO.Name = "textBoxStudio_PAO";
            this.textBoxStudio_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudio_PAO.TabIndex = 7;
            // 
            // textBoxCountry_PAO
            // 
            this.textBoxCountry_PAO.Location = new System.Drawing.Point(475, 118);
            this.textBoxCountry_PAO.Name = "textBoxCountry_PAO";
            this.textBoxCountry_PAO.Size = new System.Drawing.Size(100, 22);
            this.textBoxCountry_PAO.TabIndex = 8;
            // 
            // buttonAdd_PAO
            // 
            this.buttonAdd_PAO.Location = new System.Drawing.Point(641, 393);
            this.buttonAdd_PAO.Name = "buttonAdd_PAO";
            this.buttonAdd_PAO.Size = new System.Drawing.Size(134, 45);
            this.buttonAdd_PAO.TabIndex = 9;
            this.buttonAdd_PAO.Text = "Добавить";
            this.buttonAdd_PAO.UseVisualStyleBackColor = true;
            this.buttonAdd_PAO.Click += new System.EventHandler(this.buttonAdd_PAO_Click);
            // 
            // pictureBoxPreview_PAO
            // 
            this.pictureBoxPreview_PAO.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBoxPreview_PAO.Location = new System.Drawing.Point(52, 97);
            this.pictureBoxPreview_PAO.Name = "pictureBoxPreview_PAO";
            this.pictureBoxPreview_PAO.Size = new System.Drawing.Size(179, 183);
            this.pictureBoxPreview_PAO.TabIndex = 11;
            this.pictureBoxPreview_PAO.TabStop = false;
            this.pictureBoxPreview_PAO.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAddFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPreview_PAO);
            this.Controls.Add(this.buttonAdd_PAO);
            this.Controls.Add(this.textBoxCountry_PAO);
            this.Controls.Add(this.textBoxStudio_PAO);
            this.Controls.Add(this.textBoxScreenwriter_PAO);
            this.Controls.Add(this.textBoxGenre_PAO);
            this.Controls.Add(this.textBoxDirector_PAO);
            this.Controls.Add(this.textBoxDescription_PAO);
            this.Controls.Add(this.textBoxYear_PAO);
            this.Controls.Add(this.textBoxRole_PAO);
            this.Controls.Add(this.textBoxlName_PAO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddFilm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview_PAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxlName_PAO;
        private System.Windows.Forms.TextBox textBoxRole_PAO;
        private System.Windows.Forms.TextBox textBoxYear_PAO;
        private System.Windows.Forms.TextBox textBoxDescription_PAO;
        private System.Windows.Forms.TextBox textBoxDirector_PAO;
        private System.Windows.Forms.TextBox textBoxGenre_PAO;
        private System.Windows.Forms.TextBox textBoxScreenwriter_PAO;
        private System.Windows.Forms.TextBox textBoxStudio_PAO;
        private System.Windows.Forms.TextBox textBoxCountry_PAO;
        private System.Windows.Forms.Button buttonAdd_PAO;
        private System.Windows.Forms.PictureBox pictureBoxPreview_PAO;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}