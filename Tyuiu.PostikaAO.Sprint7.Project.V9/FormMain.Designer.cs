﻿
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
            this.toolStripMenu_PAO = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd_PAO = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete_PAO = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1_PAO = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxSearch_PAO = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch_PAO = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2_PAO = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStat_PAO = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInformation_PAO = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp_PAO = new System.Windows.Forms.ToolStripButton();
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
            this.labelRatingText_PAO = new System.Windows.Forms.Label();
            this.labelDescriptionText_PAO = new System.Windows.Forms.Label();
            this.labelRating_PAO = new System.Windows.Forms.Label();
            this.labelCountry_PAO = new System.Windows.Forms.Label();
            this.labelName_PAO = new System.Windows.Forms.Label();
            this.labelRole_PAO = new System.Windows.Forms.Label();
            this.labelDescription_PAO = new System.Windows.Forms.Label();
            this.pictureBoxPreview_PAO = new System.Windows.Forms.PictureBox();
            this.toolStripMenu_PAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview_PAO)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu_PAO
            // 
            this.toolStripMenu_PAO.BackColor = System.Drawing.Color.LightGray;
            this.toolStripMenu_PAO.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMenu_PAO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd_PAO,
            this.toolStripButtonDelete_PAO,
            this.toolStripSeparator1_PAO,
            this.toolStripTextBoxSearch_PAO,
            this.toolStripButtonSearch_PAO,
            this.toolStripSeparator2_PAO,
            this.toolStripButtonStat_PAO,
            this.toolStripButtonInformation_PAO,
            this.toolStripButtonHelp_PAO});
            this.toolStripMenu_PAO.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu_PAO.Name = "toolStripMenu_PAO";
            this.toolStripMenu_PAO.Size = new System.Drawing.Size(1184, 27);
            this.toolStripMenu_PAO.TabIndex = 3;
            this.toolStripMenu_PAO.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonAdd_PAO
            // 
            this.toolStripButtonAdd_PAO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd_PAO.Image = global::Tyuiu.PostikaAO.Sprint7.Project.V9.Properties.Resources.sign_add_icon_34367;
            this.toolStripButtonAdd_PAO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd_PAO.Name = "toolStripButtonAdd_PAO";
            this.toolStripButtonAdd_PAO.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAdd_PAO.Text = "Добавить фильм";
            this.toolStripButtonAdd_PAO.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonDelete_PAO
            // 
            this.toolStripButtonDelete_PAO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete_PAO.Enabled = false;
            this.toolStripButtonDelete_PAO.Image = global::Tyuiu.PostikaAO.Sprint7.Project.V9.Properties.Resources.sign_error_icon_34362;
            this.toolStripButtonDelete_PAO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete_PAO.Name = "toolStripButtonDelete_PAO";
            this.toolStripButtonDelete_PAO.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDelete_PAO.Text = "Удалить фильм";
            this.toolStripButtonDelete_PAO.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1_PAO
            // 
            this.toolStripSeparator1_PAO.Name = "toolStripSeparator1_PAO";
            this.toolStripSeparator1_PAO.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBoxSearch_PAO
            // 
            this.toolStripTextBoxSearch_PAO.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripTextBoxSearch_PAO.Name = "toolStripTextBoxSearch_PAO";
            this.toolStripTextBoxSearch_PAO.Size = new System.Drawing.Size(141, 27);
            this.toolStripTextBoxSearch_PAO.Text = "Поиск...";
            this.toolStripTextBoxSearch_PAO.Enter += new System.EventHandler(this.toolStripTextBoxSearch_PAO_Enter);
            this.toolStripTextBoxSearch_PAO.Leave += new System.EventHandler(this.toolStripTextBoxSearch_PAO_Leave);
            // 
            // toolStripButtonSearch_PAO
            // 
            this.toolStripButtonSearch_PAO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch_PAO.Image = global::Tyuiu.PostikaAO.Sprint7.Project.V9.Properties.Resources.sign_add_icon_34367_копия;
            this.toolStripButtonSearch_PAO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch_PAO.Name = "toolStripButtonSearch_PAO";
            this.toolStripButtonSearch_PAO.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonSearch_PAO.Text = "Поиск фильма";
            this.toolStripButtonSearch_PAO.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // toolStripSeparator2_PAO
            // 
            this.toolStripSeparator2_PAO.Name = "toolStripSeparator2_PAO";
            this.toolStripSeparator2_PAO.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonStat_PAO
            // 
            this.toolStripButtonStat_PAO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStat_PAO.Image = global::Tyuiu.PostikaAO.Sprint7.Project.V9.Properties.Resources.stats;
            this.toolStripButtonStat_PAO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStat_PAO.Name = "toolStripButtonStat_PAO";
            this.toolStripButtonStat_PAO.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonStat_PAO.Text = "Статистика по жанрам";
            this.toolStripButtonStat_PAO.Click += new System.EventHandler(this.toolStripButton1_Click_3);
            // 
            // toolStripButtonInformation_PAO
            // 
            this.toolStripButtonInformation_PAO.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonInformation_PAO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInformation_PAO.Image = global::Tyuiu.PostikaAO.Sprint7.Project.V9.Properties.Resources.info;
            this.toolStripButtonInformation_PAO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInformation_PAO.Name = "toolStripButtonInformation_PAO";
            this.toolStripButtonInformation_PAO.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonInformation_PAO.Text = "Сведенья о программе";
            this.toolStripButtonInformation_PAO.Click += new System.EventHandler(this.toolStripButtonHelp_PAO_Click);
            // 
            // toolStripButtonHelp_PAO
            // 
            this.toolStripButtonHelp_PAO.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonHelp_PAO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp_PAO.Image = global::Tyuiu.PostikaAO.Sprint7.Project.V9.Properties.Resources.sign_question_icon_34359;
            this.toolStripButtonHelp_PAO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp_PAO.Name = "toolStripButtonHelp_PAO";
            this.toolStripButtonHelp_PAO.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonHelp_PAO.Text = "toolStripButton1";
            this.toolStripButtonHelp_PAO.Click += new System.EventHandler(this.toolStripButtonHelp_PAO_Click_1);
            // 
            // flowLayoutPanelLeft_PAO
            // 
            this.flowLayoutPanelLeft_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanelLeft_PAO.AutoScroll = true;
            this.flowLayoutPanelLeft_PAO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelLeft_PAO.Location = new System.Drawing.Point(0, 31);
            this.flowLayoutPanelLeft_PAO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelLeft_PAO.Name = "flowLayoutPanelLeft_PAO";
            this.flowLayoutPanelLeft_PAO.Size = new System.Drawing.Size(278, 669);
            this.flowLayoutPanelLeft_PAO.TabIndex = 1;
            // 
            // labelScreenwriter_PAO
            // 
            this.labelScreenwriter_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScreenwriter_PAO.Location = new System.Drawing.Point(553, 144);
            this.labelScreenwriter_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScreenwriter_PAO.Name = "labelScreenwriter_PAO";
            this.labelScreenwriter_PAO.Size = new System.Drawing.Size(112, 24);
            this.labelScreenwriter_PAO.TabIndex = 9;
            this.labelScreenwriter_PAO.Text = "Сценарист:";
            this.labelScreenwriter_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDirector_PAO
            // 
            this.labelDirector_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirector_PAO.Location = new System.Drawing.Point(553, 120);
            this.labelDirector_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDirector_PAO.Name = "labelDirector_PAO";
            this.labelDirector_PAO.Size = new System.Drawing.Size(112, 24);
            this.labelDirector_PAO.TabIndex = 8;
            this.labelDirector_PAO.Text = "Режессер:";
            this.labelDirector_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelGenre_PAO
            // 
            this.labelGenre_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre_PAO.Location = new System.Drawing.Point(553, 97);
            this.labelGenre_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenre_PAO.Name = "labelGenre_PAO";
            this.labelGenre_PAO.Size = new System.Drawing.Size(112, 24);
            this.labelGenre_PAO.TabIndex = 7;
            this.labelGenre_PAO.Text = "Жанр:";
            this.labelGenre_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelYear_PAO
            // 
            this.labelYear_PAO.AutoSize = true;
            this.labelYear_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear_PAO.Location = new System.Drawing.Point(334, 341);
            this.labelYear_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYear_PAO.Name = "labelYear_PAO";
            this.labelYear_PAO.Size = new System.Drawing.Size(49, 24);
            this.labelYear_PAO.TabIndex = 6;
            this.labelYear_PAO.Text = "Год:";
            // 
            // labelYearText_PAO
            // 
            this.labelYearText_PAO.AutoSize = true;
            this.labelYearText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYearText_PAO.Location = new System.Drawing.Point(385, 341);
            this.labelYearText_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYearText_PAO.Name = "labelYearText_PAO";
            this.labelYearText_PAO.Size = new System.Drawing.Size(16, 24);
            this.labelYearText_PAO.TabIndex = 10;
            this.labelYearText_PAO.Text = "-";
            // 
            // labelGenreText_PAO
            // 
            this.labelGenreText_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGenreText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenreText_PAO.Location = new System.Drawing.Point(662, 93);
            this.labelGenreText_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenreText_PAO.Name = "labelGenreText_PAO";
            this.labelGenreText_PAO.Size = new System.Drawing.Size(592, 24);
            this.labelGenreText_PAO.TabIndex = 11;
            this.labelGenreText_PAO.Text = "-";
            this.labelGenreText_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDirectorText_PAO
            // 
            this.labelDirectorText_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDirectorText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirectorText_PAO.Location = new System.Drawing.Point(662, 120);
            this.labelDirectorText_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDirectorText_PAO.Name = "labelDirectorText_PAO";
            this.labelDirectorText_PAO.Size = new System.Drawing.Size(592, 24);
            this.labelDirectorText_PAO.TabIndex = 12;
            this.labelDirectorText_PAO.Text = "-";
            this.labelDirectorText_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelScreenwriterText_PAO
            // 
            this.labelScreenwriterText_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScreenwriterText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScreenwriterText_PAO.Location = new System.Drawing.Point(662, 144);
            this.labelScreenwriterText_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScreenwriterText_PAO.Name = "labelScreenwriterText_PAO";
            this.labelScreenwriterText_PAO.Size = new System.Drawing.Size(592, 24);
            this.labelScreenwriterText_PAO.TabIndex = 13;
            this.labelScreenwriterText_PAO.Text = "-";
            this.labelScreenwriterText_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRoleText_PAO
            // 
            this.labelRoleText_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoleText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoleText_PAO.Location = new System.Drawing.Point(662, 167);
            this.labelRoleText_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoleText_PAO.Name = "labelRoleText_PAO";
            this.labelRoleText_PAO.Size = new System.Drawing.Size(592, 24);
            this.labelRoleText_PAO.TabIndex = 14;
            this.labelRoleText_PAO.Text = "-";
            this.labelRoleText_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRoleText_PAO.Click += new System.EventHandler(this.labelRoleText_PAO_Click);
            // 
            // labelCountryText_PAO
            // 
            this.labelCountryText_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCountryText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountryText_PAO.Location = new System.Drawing.Point(662, 191);
            this.labelCountryText_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountryText_PAO.Name = "labelCountryText_PAO";
            this.labelCountryText_PAO.Size = new System.Drawing.Size(592, 24);
            this.labelCountryText_PAO.TabIndex = 15;
            this.labelCountryText_PAO.Text = "-";
            this.labelCountryText_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRatingText_PAO
            // 
            this.labelRatingText_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRatingText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRatingText_PAO.Location = new System.Drawing.Point(662, 214);
            this.labelRatingText_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRatingText_PAO.Name = "labelRatingText_PAO";
            this.labelRatingText_PAO.Size = new System.Drawing.Size(592, 24);
            this.labelRatingText_PAO.TabIndex = 16;
            this.labelRatingText_PAO.Text = "-";
            this.labelRatingText_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescriptionText_PAO
            // 
            this.labelDescriptionText_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescriptionText_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescriptionText_PAO.Location = new System.Drawing.Point(662, 238);
            this.labelDescriptionText_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescriptionText_PAO.Name = "labelDescriptionText_PAO";
            this.labelDescriptionText_PAO.Size = new System.Drawing.Size(592, 24);
            this.labelDescriptionText_PAO.TabIndex = 17;
            this.labelDescriptionText_PAO.Text = "-";
            // 
            // labelRating_PAO
            // 
            this.labelRating_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRating_PAO.Location = new System.Drawing.Point(553, 214);
            this.labelRating_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRating_PAO.Name = "labelRating_PAO";
            this.labelRating_PAO.Size = new System.Drawing.Size(112, 24);
            this.labelRating_PAO.TabIndex = 12;
            this.labelRating_PAO.Text = "Оценка:";
            this.labelRating_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCountry_PAO
            // 
            this.labelCountry_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountry_PAO.Location = new System.Drawing.Point(553, 191);
            this.labelCountry_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountry_PAO.Name = "labelCountry_PAO";
            this.labelCountry_PAO.Size = new System.Drawing.Size(112, 24);
            this.labelCountry_PAO.TabIndex = 11;
            this.labelCountry_PAO.Text = "Страна:";
            this.labelCountry_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName_PAO
            // 
            this.labelName_PAO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName_PAO.Location = new System.Drawing.Point(564, 31);
            this.labelName_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName_PAO.Name = "labelName_PAO";
            this.labelName_PAO.Size = new System.Drawing.Size(595, 40);
            this.labelName_PAO.TabIndex = 5;
            this.labelName_PAO.Text = "Выберите фильм ";
            this.labelName_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRole_PAO
            // 
            this.labelRole_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole_PAO.Location = new System.Drawing.Point(553, 167);
            this.labelRole_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRole_PAO.Name = "labelRole_PAO";
            this.labelRole_PAO.Size = new System.Drawing.Size(112, 24);
            this.labelRole_PAO.TabIndex = 10;
            this.labelRole_PAO.Text = "В ролях:";
            this.labelRole_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDescription_PAO
            // 
            this.labelDescription_PAO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescription_PAO.Location = new System.Drawing.Point(553, 238);
            this.labelDescription_PAO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription_PAO.Name = "labelDescription_PAO";
            this.labelDescription_PAO.Size = new System.Drawing.Size(112, 24);
            this.labelDescription_PAO.TabIndex = 13;
            this.labelDescription_PAO.Text = "Описание:";
            this.labelDescription_PAO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxPreview_PAO
            // 
            this.pictureBoxPreview_PAO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxPreview_PAO.Image = global::Tyuiu.PostikaAO.Sprint7.Project.V9.Properties.Resources.imagePlaceholder;
            this.pictureBoxPreview_PAO.Location = new System.Drawing.Point(282, 31);
            this.pictureBoxPreview_PAO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxPreview_PAO.Name = "pictureBoxPreview_PAO";
            this.pictureBoxPreview_PAO.Size = new System.Drawing.Size(200, 295);
            this.pictureBoxPreview_PAO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview_PAO.TabIndex = 2;
            this.pictureBoxPreview_PAO.TabStop = false;
            this.pictureBoxPreview_PAO.Click += new System.EventHandler(this.pictureBoxPreview_PAO_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1184, 559);
            this.Controls.Add(this.labelYearText_PAO);
            this.Controls.Add(this.labelDescription_PAO);
            this.Controls.Add(this.labelYear_PAO);
            this.Controls.Add(this.pictureBoxPreview_PAO);
            this.Controls.Add(this.labelRole_PAO);
            this.Controls.Add(this.toolStripMenu_PAO);
            this.Controls.Add(this.labelCountry_PAO);
            this.Controls.Add(this.labelRating_PAO);
            this.Controls.Add(this.labelName_PAO);
            this.Controls.Add(this.labelDescriptionText_PAO);
            this.Controls.Add(this.labelRatingText_PAO);
            this.Controls.Add(this.flowLayoutPanelLeft_PAO);
            this.Controls.Add(this.labelCountryText_PAO);
            this.Controls.Add(this.labelScreenwriter_PAO);
            this.Controls.Add(this.labelRoleText_PAO);
            this.Controls.Add(this.labelDirector_PAO);
            this.Controls.Add(this.labelScreenwriterText_PAO);
            this.Controls.Add(this.labelGenre_PAO);
            this.Controls.Add(this.labelDirectorText_PAO);
            this.Controls.Add(this.labelGenreText_PAO);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1200, 598);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект | Вариант 9 | Постика А.О.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.toolStripMenu_PAO.ResumeLayout(false);
            this.toolStripMenu_PAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview_PAO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLeft_PAO;
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
        private System.Windows.Forms.Label labelRatingText_PAO;
        private System.Windows.Forms.Label labelDescriptionText_PAO;
        private System.Windows.Forms.Label labelRating_PAO;
        private System.Windows.Forms.Label labelCountry_PAO;
        private System.Windows.Forms.Label labelName_PAO;
        private System.Windows.Forms.Label labelRole_PAO;
        private System.Windows.Forms.Label labelDescription_PAO;
        private System.Windows.Forms.ToolStrip toolStripMenu_PAO;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd_PAO;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete_PAO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1_PAO;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_PAO;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch_PAO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2_PAO;
        private System.Windows.Forms.ToolStripButton toolStripButtonStat_PAO;
        private System.Windows.Forms.ToolStripButton toolStripButtonInformation_PAO;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp_PAO;
    }
}

