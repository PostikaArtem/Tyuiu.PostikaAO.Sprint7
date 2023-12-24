
namespace Tyuiu.PostikaAO.Sprint7.Project.V9
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAvatar_PAO = new System.Windows.Forms.PictureBox();
            this.buttonOK_PAO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PAO)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 153);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBoxAvatar_PAO
            // 
            this.pictureBoxAvatar_PAO.Image = global::Tyuiu.PostikaAO.Sprint7.Project.V9.Properties.Resources.pngwing_com;
            this.pictureBoxAvatar_PAO.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvatar_PAO.Name = "pictureBoxAvatar_PAO";
            this.pictureBoxAvatar_PAO.Size = new System.Drawing.Size(166, 202);
            this.pictureBoxAvatar_PAO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_PAO.TabIndex = 1;
            this.pictureBoxAvatar_PAO.TabStop = false;
            // 
            // buttonOK_PAO
            // 
            this.buttonOK_PAO.Location = new System.Drawing.Point(474, 206);
            this.buttonOK_PAO.Name = "buttonOK_PAO";
            this.buttonOK_PAO.Size = new System.Drawing.Size(91, 31);
            this.buttonOK_PAO.TabIndex = 2;
            this.buttonOK_PAO.Text = "OK";
            this.buttonOK_PAO.UseVisualStyleBackColor = true;
            this.buttonOK_PAO.Click += new System.EventHandler(this.buttonOK_PAO_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 249);
            this.Controls.Add(this.buttonOK_PAO);
            this.Controls.Add(this.pictureBoxAvatar_PAO);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_PAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_PAO;
        private System.Windows.Forms.Button buttonOK_PAO;
    }
}