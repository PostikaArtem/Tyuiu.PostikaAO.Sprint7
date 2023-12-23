
namespace Tyuiu.PostikaAO.Sprint7.Project.V9
{
    partial class FormMain
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
            this.panelTop_PAO = new System.Windows.Forms.Panel();
            this.buttonHelp_PAO = new System.Windows.Forms.Button();
            this.buttonDelete_PAO = new System.Windows.Forms.Button();
            this.buttonAdd_PAO = new System.Windows.Forms.Button();
            this.buttonSearch_PAO = new System.Windows.Forms.Button();
            this.textBoxSearch_PAO = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelLeft_PAO = new System.Windows.Forms.FlowLayoutPanel();
            this.labelScreenwriter_PAO = new System.Windows.Forms.Label();
            this.labelDirector_PAO = new System.Windows.Forms.Label();
            this.labelGenre_PAO = new System.Windows.Forms.Label();
            this.labelYear_PAO = new System.Windows.Forms.Label();
            this.labelYearText_PAO = new System.Windows.Forms.Label();
            this.labelGenreText_PAO = new System.Windows.Forms.Label();
            this.labelDirectorText_PAO = new System.Windows.Forms.Label();
            this.labelScreenwriterText_PAO = new System.Windows.Forms.Label();
            this.labelRoleText_PAO = new System.Windows.Forms.Label();
            this.labelCountryText_PAO = new System.Windows.Forms.Label();
            this.labelStudioText_PAO = new System.Windows.Forms.Label();
            this.labelDescriptionText_PAO = new System.Windows.Forms.Label();
            this.labelStudio_PAO = new System.Windows.Forms.Label();
            this.labelCountry_PAO = new System.Windows.Forms.Label();
            this.labelName_PAO = new System.Windows.Forms.Label();
            this.labelRole_PAO = new System.Windows.Forms.Label();
            this.labelDescription_PAO = new System.Windows.Forms.Label();
            this.groupBoxInformation_PAO = new System.Windows.Forms.GroupBox();
            this.pictureBoxPreview_PAO = new System.Windows.Forms.PictureBox();
            this.panelTop_PAO.SuspendLayout();
            this.groupBoxInformation_PAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview_PAO)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_PAO
            // 
            this.panelTop_PAO.Controls.Add(this.textBoxSearch_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonSearch_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonAdd_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonDelete_PAO);
            this.panelTop_PAO.Controls.Add(this.buttonHelp_PAO);
            this.panelTop_PAO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PAO.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PAO.Name = "panelTop_PAO";
            this.panelTop_PAO.Size = new System.Drawing.Size(1349, 66);
            this.panelTop_PAO.TabIndex = 0;
            // 
            // buttonHelp_PAO
            // 
            this.buttonHelp_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_PAO.Location = new System.Drawing.Point(1243, 12);
            this.buttonHelp_PAO.Name = "buttonHelp_PAO";
            this.buttonHelp_PAO.Size = new System.Drawing.Size(94, 43);
            this.buttonHelp_PAO.TabIndex = 2;
            this.buttonHelp_PAO.Text = "Справка";
            this.buttonHelp_PAO.UseVisualStyleBackColor = true;
            // 
            // buttonDelete_PAO
            // 
            this.buttonDelete_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete_PAO.Location = new System.Drawing.Point(689, 14);
            this.buttonDelete_PAO.Name = "buttonDelete_PAO";
            this.buttonDelete_PAO.Size = new System.Drawing.Size(396, 45);
            this.buttonDelete_PAO.TabIndex = 1;
            this.buttonDelete_PAO.Text = "Открыть";
            this.buttonDelete_PAO.UseVisualStyleBackColor = true;
            this.buttonDelete_PAO.Click += new System.EventHandler(this.buttonDelete_PAO_Click);
            // 
            // buttonAdd_PAO
            // 
            this.buttonAdd_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd_PAO.Location = new System.Drawing.Point(273, 12);
            this.buttonAdd_PAO.Name = "buttonAdd_PAO";
            this.buttonAdd_PAO.Size = new System.Drawing.Size(400, 47);
            this.buttonAdd_PAO.TabIndex = 0;
            this.buttonAdd_PAO.Text = "Добавить";
            this.buttonAdd_PAO.UseVisualStyleBackColor = true;
            this.buttonAdd_PAO.Click += new System.EventHandler(this.buttonAdd_PAO_Click);
            // 
            // buttonSearch_PAO
            // 
            this.buttonSearch_PAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch_PAO.Location = new System.Drawing.Point(160, 12);
            this.buttonSearch_PAO.Name = "buttonSearch_PAO";
            this.buttonSearch_PAO.Size = new System.Drawing.Size(94, 44);
            this.buttonSearch_PAO.TabIndex = 1;
            this.buttonSearch_PAO.Text = "Найти";
            this.buttonSearch_PAO.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch_PAO
            // 
            this.textBoxSearch_PAO.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSearch_PAO.Location = new System.Drawing.Point(12, 22);
            this.textBoxSearch_PAO.Multiline = true;
            this.textBoxSearch_PAO.Name = "textBoxSearch_PAO";
            this.textBoxSearch_PAO.Size = new System.Drawing.Size(142, 26);
            this.textBoxSearch_PAO.TabIndex = 0;
            this.textBoxSearch_PAO.Text = "Поиск...";
            this.textBoxSearch_PAO.Enter += new System.EventHandler(this.textBoxSearch_PAO_Enter);
            this.textBoxSearch_PAO.Leave += new System.EventHandler(this.textBoxSearch_PAO_Leave);
            // 
            // flowLayoutPanelLeft_PAO
            // 
            this.flowLayoutPanelLeft_PAO.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanelLeft_PAO.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelLeft_PAO.Location = new System.Drawing.Point(0, 66);
            this.flowLayoutPanelLeft_PAO.Name = "flowLayoutPanelLeft_PAO";
            this.flowLayoutPanelLeft_PAO.Size = new System.Drawing.Size(267, 622);
            this.flowLayoutPanelLeft_PAO.TabIndex = 1;
            // 
            // labelScreenwriter_PAO
            // 
            this.labelScreenwriter_PAO.AutoSize = true;
            this.labelScreenwriter_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScreenwriter_PAO.Location = new System.Drawing.Point(512, 164);
            this.labelScreenwriter_PAO.Name = "labelScreenwriter_PAO";
            this.labelScreenwriter_PAO.Size = new System.Drawing.Size(146, 29);
            this.labelScreenwriter_PAO.TabIndex = 9;
            this.labelScreenwriter_PAO.Text = "Сценарист:";
            // 
            // labelDirector_PAO
            // 
            this.labelDirector_PAO.AutoSize = true;
            this.labelDirector_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirector_PAO.Location = new System.Drawing.Point(525, 135);
            this.labelDirector_PAO.Name = "labelDirector_PAO";
            this.labelDirector_PAO.Size = new System.Drawing.Size(133, 29);
            this.labelDirector_PAO.TabIndex = 8;
            this.labelDirector_PAO.Text = "Режессер:";
            // 
            // labelGenre_PAO
            // 
            this.labelGenre_PAO.AutoSize = true;
            this.labelGenre_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre_PAO.Location = new System.Drawing.Point(576, 106);
            this.labelGenre_PAO.Name = "labelGenre_PAO";
            this.labelGenre_PAO.Size = new System.Drawing.Size(82, 29);
            this.labelGenre_PAO.TabIndex = 7;
            this.labelGenre_PAO.Text = "Жанр:";
            // 
            // labelYear_PAO
            // 
            this.labelYear_PAO.AutoSize = true;
            this.labelYear_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear_PAO.Location = new System.Drawing.Point(134, 565);
            this.labelYear_PAO.Name = "labelYear_PAO";
            this.labelYear_PAO.Size = new System.Drawing.Size(61, 29);
            this.labelYear_PAO.TabIndex = 6;
            this.labelYear_PAO.Text = "Год:";
            // 
            // labelYearText_PAO
            // 
            this.labelYearText_PAO.AutoSize = true;
            this.labelYearText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYearText_PAO.Location = new System.Drawing.Point(201, 565);
            this.labelYearText_PAO.Name = "labelYearText_PAO";
            this.labelYearText_PAO.Size = new System.Drawing.Size(21, 29);
            this.labelYearText_PAO.TabIndex = 10;
            this.labelYearText_PAO.Text = "-";
            // 
            // labelGenreText_PAO
            // 
            this.labelGenreText_PAO.AutoSize = true;
            this.labelGenreText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenreText_PAO.Location = new System.Drawing.Point(694, 106);
            this.labelGenreText_PAO.Name = "labelGenreText_PAO";
            this.labelGenreText_PAO.Size = new System.Drawing.Size(21, 29);
            this.labelGenreText_PAO.TabIndex = 11;
            this.labelGenreText_PAO.Text = "-";
            // 
            // labelDirectorText_PAO
            // 
            this.labelDirectorText_PAO.AutoSize = true;
            this.labelDirectorText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirectorText_PAO.Location = new System.Drawing.Point(694, 135);
            this.labelDirectorText_PAO.Name = "labelDirectorText_PAO";
            this.labelDirectorText_PAO.Size = new System.Drawing.Size(21, 29);
            this.labelDirectorText_PAO.TabIndex = 12;
            this.labelDirectorText_PAO.Text = "-";
            // 
            // labelScreenwriterText_PAO
            // 
            this.labelScreenwriterText_PAO.AutoSize = true;
            this.labelScreenwriterText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScreenwriterText_PAO.Location = new System.Drawing.Point(694, 164);
            this.labelScreenwriterText_PAO.Name = "labelScreenwriterText_PAO";
            this.labelScreenwriterText_PAO.Size = new System.Drawing.Size(21, 29);
            this.labelScreenwriterText_PAO.TabIndex = 13;
            this.labelScreenwriterText_PAO.Text = "-";
            // 
            // labelRoleText_PAO
            // 
            this.labelRoleText_PAO.AutoSize = true;
            this.labelRoleText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoleText_PAO.Location = new System.Drawing.Point(694, 193);
            this.labelRoleText_PAO.Name = "labelRoleText_PAO";
            this.labelRoleText_PAO.Size = new System.Drawing.Size(21, 29);
            this.labelRoleText_PAO.TabIndex = 14;
            this.labelRoleText_PAO.Text = "-";
            this.labelRoleText_PAO.Click += new System.EventHandler(this.labelRoleText_PAO_Click);
            // 
            // labelCountryText_PAO
            // 
            this.labelCountryText_PAO.AutoSize = true;
            this.labelCountryText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountryText_PAO.Location = new System.Drawing.Point(694, 222);
            this.labelCountryText_PAO.Name = "labelCountryText_PAO";
            this.labelCountryText_PAO.Size = new System.Drawing.Size(21, 29);
            this.labelCountryText_PAO.TabIndex = 15;
            this.labelCountryText_PAO.Text = "-";
            // 
            // labelStudioText_PAO
            // 
            this.labelStudioText_PAO.AutoSize = true;
            this.labelStudioText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudioText_PAO.Location = new System.Drawing.Point(694, 251);
            this.labelStudioText_PAO.Name = "labelStudioText_PAO";
            this.labelStudioText_PAO.Size = new System.Drawing.Size(21, 29);
            this.labelStudioText_PAO.TabIndex = 16;
            this.labelStudioText_PAO.Text = "-";
            // 
            // labelDescriptionText_PAO
            // 
            this.labelDescriptionText_PAO.AutoSize = true;
            this.labelDescriptionText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescriptionText_PAO.Location = new System.Drawing.Point(694, 280);
            this.labelDescriptionText_PAO.Name = "labelDescriptionText_PAO";
            this.labelDescriptionText_PAO.Size = new System.Drawing.Size(21, 29);
            this.labelDescriptionText_PAO.TabIndex = 17;
            this.labelDescriptionText_PAO.Text = "-";
            // 
            // labelStudio_PAO
            // 
            this.labelStudio_PAO.AutoSize = true;
            this.labelStudio_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudio_PAO.Location = new System.Drawing.Point(555, 251);
            this.labelStudio_PAO.Name = "labelStudio_PAO";
            this.labelStudio_PAO.Size = new System.Drawing.Size(102, 29);
            this.labelStudio_PAO.TabIndex = 12;
            this.labelStudio_PAO.Text = "Студия:";
            // 
            // labelCountry_PAO
            // 
            this.labelCountry_PAO.AutoSize = true;
            this.labelCountry_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry_PAO.Location = new System.Drawing.Point(555, 222);
            this.labelCountry_PAO.Name = "labelCountry_PAO";
            this.labelCountry_PAO.Size = new System.Drawing.Size(103, 29);
            this.labelCountry_PAO.TabIndex = 11;
            this.labelCountry_PAO.Text = "Страна:";
            // 
            // labelName_PAO
            // 
            this.labelName_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_PAO.Location = new System.Drawing.Point(479, 18);
            this.labelName_PAO.Name = "labelName_PAO";
            this.labelName_PAO.Size = new System.Drawing.Size(585, 52);
            this.labelName_PAO.TabIndex = 5;
            this.labelName_PAO.Text = "Выберите или добавьте фильм";
            // 
            // labelRole_PAO
            // 
            this.labelRole_PAO.AutoSize = true;
            this.labelRole_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole_PAO.Location = new System.Drawing.Point(549, 193);
            this.labelRole_PAO.Name = "labelRole_PAO";
            this.labelRole_PAO.Size = new System.Drawing.Size(109, 29);
            this.labelRole_PAO.TabIndex = 10;
            this.labelRole_PAO.Text = "В ролях:";
            // 
            // labelDescription_PAO
            // 
            this.labelDescription_PAO.AutoSize = true;
            this.labelDescription_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription_PAO.Location = new System.Drawing.Point(520, 280);
            this.labelDescription_PAO.Name = "labelDescription_PAO";
            this.labelDescription_PAO.Size = new System.Drawing.Size(137, 29);
            this.labelDescription_PAO.TabIndex = 13;
            this.labelDescription_PAO.Text = "Описание:";
            // 
            // groupBoxInformation_PAO
            // 
            this.groupBoxInformation_PAO.Controls.Add(this.labelDescription_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelRole_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelName_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelCountry_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelStudio_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelDescriptionText_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelStudioText_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelCountryText_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelRoleText_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelScreenwriterText_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelDirectorText_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelGenreText_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelYearText_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.pictureBoxPreview_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelYear_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelGenre_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelDirector_PAO);
            this.groupBoxInformation_PAO.Controls.Add(this.labelScreenwriter_PAO);
            this.groupBoxInformation_PAO.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInformation_PAO.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBoxInformation_PAO.Location = new System.Drawing.Point(267, 66);
            this.groupBoxInformation_PAO.Name = "groupBoxInformation_PAO";
            this.groupBoxInformation_PAO.Size = new System.Drawing.Size(1070, 622);
            this.groupBoxInformation_PAO.TabIndex = 3;
            this.groupBoxInformation_PAO.TabStop = false;
            this.groupBoxInformation_PAO.Text = "-";
            // 
            // pictureBoxPreview_PAO
            // 
            this.pictureBoxPreview_PAO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxPreview_PAO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxPreview_PAO.Image = global::Tyuiu.PostikaAO.Sprint7.Project.V9.Properties.Resources.imagePlaceholder;
            this.pictureBoxPreview_PAO.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxPreview_PAO.Name = "pictureBoxPreview_PAO";
            this.pictureBoxPreview_PAO.Size = new System.Drawing.Size(400, 529);
            this.pictureBoxPreview_PAO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview_PAO.TabIndex = 2;
            this.pictureBoxPreview_PAO.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 688);
            this.Controls.Add(this.groupBoxInformation_PAO);
            this.Controls.Add(this.flowLayoutPanelLeft_PAO);
            this.Controls.Add(this.panelTop_PAO);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект | Вариант 9 | Постика А.О.";
            this.panelTop_PAO.ResumeLayout(false);
            this.panelTop_PAO.PerformLayout();
            this.groupBoxInformation_PAO.ResumeLayout(false);
            this.groupBoxInformation_PAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview_PAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_PAO;
        private System.Windows.Forms.Button buttonSearch_PAO;
        private System.Windows.Forms.TextBox textBoxSearch_PAO;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLeft_PAO;
        private System.Windows.Forms.Button buttonDelete_PAO;
        private System.Windows.Forms.Button buttonAdd_PAO;
        private System.Windows.Forms.Button buttonHelp_PAO;
        private System.Windows.Forms.Label labelScreenwriter_PAO;
        private System.Windows.Forms.Label labelDirector_PAO;
        private System.Windows.Forms.Label labelGenre_PAO;
        private System.Windows.Forms.Label labelYear_PAO;
        private System.Windows.Forms.PictureBox pictureBoxPreview_PAO;
        private System.Windows.Forms.Label labelYearText_PAO;
        private System.Windows.Forms.Label labelGenreText_PAO;
        private System.Windows.Forms.Label labelDirectorText_PAO;
        private System.Windows.Forms.Label labelScreenwriterText_PAO;
        private System.Windows.Forms.Label labelRoleText_PAO;
        private System.Windows.Forms.Label labelCountryText_PAO;
        private System.Windows.Forms.Label labelStudioText_PAO;
        private System.Windows.Forms.Label labelDescriptionText_PAO;
        private System.Windows.Forms.Label labelStudio_PAO;
        private System.Windows.Forms.Label labelCountry_PAO;
        private System.Windows.Forms.Label labelName_PAO;
        private System.Windows.Forms.Label labelRole_PAO;
        private System.Windows.Forms.Label labelDescription_PAO;
        private System.Windows.Forms.GroupBox groupBoxInformation_PAO;
    }
}

