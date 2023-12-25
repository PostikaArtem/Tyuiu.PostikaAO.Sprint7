﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


using Tyuiu.PostikaAO.Sprint7.Project.V9.Lib;
namespace Tyuiu.PostikaAO.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        int openedFilm = -1;
        Size defaultLabelSize;

        public FormMain()
        {
            InitializeComponent();
            UpdateFilmsButtons();
            ds.ClearUnusedImages();

            defaultLabelSize = labelGenreText_PAO.Size;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_PAO_Click(object sender, EventArgs e)
        {
            FormAddFilm AddForm = new FormAddFilm();
            AddForm.ShowDialog();
            UpdateFilmsButtons();
        }

        private void buttonDelete_PAO_Click(object sender, EventArgs e)
        {

            if (openedFilm != -1)
            {
                DialogResult result = MessageBox.Show($"Вы действительно хотите удалить информацию о {labelName_PAO.Text}?", "Удаление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    flowLayoutPanelLeft_PAO.Controls.Clear();
                    ds.DeleteFilm(openedFilm);
                    InfoReset();
                    UpdateFilmsButtons();
                }
            }
            else
            {
                MessageBox.Show("Для удаления откройте страницу с фильмом.", "Ошибка");
            }


        }

        private void labelRoleText_PAO_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_PAO_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBoxSearch_PAO_Leave(object sender, EventArgs e)
        {
           
        }


        public void Search(string request)
        {
            flowLayoutPanelLeft_PAO.Controls.Clear();

            string[] allFilmsNames = ds.GetNecessaryTypeInfo(1);
            string[] allFilmsImages = ds.GetNecessaryTypeInfo(0);

            for (int i = 0; i < allFilmsNames.Length; i++)
            {
                string lowerFilmName = allFilmsNames[i].ToLower();

                if (lowerFilmName.Contains(request.ToLower()))
                {
                    Button newButton = CreateButton(allFilmsNames[i],i,allFilmsImages[i]);
                    flowLayoutPanelLeft_PAO.Controls.Add(newButton);
                }
            }

            if (flowLayoutPanelLeft_PAO.Controls.Count == 0)
            {
                UpdateFilmsButtons();
                MessageBox.Show("Запрос не найден.", "Ошибка");
            }
        }


        private Button CreateButton(string filmName, int lineNum, string pathImage)
        {
            Size buttonSize = new Size(94, 141);
            Button openButton = new Button();
            openButton.Size = buttonSize;
            openButton.Text = filmName;
            openButton.ForeColor = Color.DarkGray;
            openButton.TextAlign = ContentAlignment.BottomCenter;
            openButton.Name = $"buttonFilm{lineNum}_PAO";
            try
            {
                openButton.BackgroundImage = Image.FromFile(pathImage);
            }
            catch
            {
                openButton.BackgroundImage = Properties.Resources.imageLoadError;
            }
            openButton.BackgroundImageLayout = ImageLayout.Stretch;
            openButton.Click += new EventHandler(this.OpenFilm);
            return openButton;
        } 

        private void InfoReset()
        {
            pictureBoxPreview_PAO.Image = Properties.Resources.imagePlaceholder;
            labelName_PAO.Text = "Выберите фильм";
            labelCountryText_PAO.Text = "-";
            labelScreenwriterText_PAO.Text = "-";
            labelDirectorText_PAO.Text = "-";
            labelGenreText_PAO.Text = "-";
            labelRoleText_PAO.Text = "-";
            labelRatingText_PAO.Text = "-";
            labelYearText_PAO.Text = "-";
            labelDescriptionText_PAO.Text = "-";

            toolStripButtonDelete_PAO.Enabled = false;
        }



        public void UpdateFilmsButtons()
        {
            flowLayoutPanelLeft_PAO.Controls.Clear();

            int lineNum =ds.GetFilmCount();
            if (lineNum == 0) return;
            for(int i = 0; i < lineNum; i++) 
            {
                string[] temp = ds.GetNecessaryFilmInfo(i);
                Button newButton = CreateButton(temp[1],i,temp[0]);
                flowLayoutPanelLeft_PAO.Controls.Add(newButton);
            }

        }

        private void OpenFilm(Object sender, EventArgs e)
        {
            string[] genres = { "Боевик", "Детектив", "Драма", "Исторический фильм", "Комедия", "Музыкальный фильм", "Триллер" };
            Button b = (Button)sender;
            toolStripButtonDelete_PAO.Enabled = true;
            openedFilm = b.TabIndex;

            string[] data = ds.GetNecessaryFilmInfo(openedFilm);

            try
            {
                pictureBoxPreview_PAO.Image = Image.FromFile(data[0]);

            }
            catch
            {
                pictureBoxPreview_PAO.Image = Properties.Resources.imageLoadError;
            }
            labelName_PAO.Text = data[1];
            labelYearText_PAO.Text = data[2];
            labelGenreText_PAO.Text = genres[int.Parse(data[3])];
            labelDirectorText_PAO.Text = data[4];
            labelScreenwriterText_PAO.Text = data[5];
            labelCountryText_PAO.Text = data[6];
            labelRoleText_PAO.Text = data[8];
            labelRatingText_PAO.Text = data[7];
            labelDescriptionText_PAO.Text = data[9];

            MoveLabels();
            
        }

        private void pictureBoxPreview_PAO_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_PAO_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxSearch_PAO_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            FormAddFilm AddForm = new FormAddFilm();
            AddForm.ShowDialog();
            UpdateFilmsButtons();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить информацию о {labelName_PAO.Text}?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                flowLayoutPanelLeft_PAO.Controls.Clear();
                ds.DeleteFilm(openedFilm);
                InfoReset();
                UpdateFilmsButtons();
            }

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            string searchRequest = toolStripTextBoxSearch_PAO.Text;

            if (!string.IsNullOrEmpty(searchRequest))
            {
                Search(searchRequest.ToLower());
            }
            else
            {
                UpdateFilmsButtons();
                MessageBox.Show("Задан пустой поисковой запрос.", "Ошибка");
            }
        }

        private void toolStripButton1_Click_3(object sender, EventArgs e)
        {
            FormStatistics formStatistics = new FormStatistics();
            formStatistics.ShowDialog();


        }

        private void toolStripTextBoxSearch_PAO_Enter(object sender, EventArgs e)
        {
            if(toolStripTextBoxSearch_PAO.Text == "Поиск...")
            {
                toolStripTextBoxSearch_PAO.Text = "";
                toolStripTextBoxSearch_PAO.ForeColor = Color.Black;
            }
        }

        private void toolStripTextBoxSearch_PAO_Leave(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch_PAO.Text == "")
            {
                toolStripTextBoxSearch_PAO.Text = "Поиск...";
                toolStripTextBoxSearch_PAO.ForeColor = Color.Silver;
            }
        }

        private void toolStripButtonHelp_PAO_Click(object sender, EventArgs e)
        {
            FormInformatoin formInformation = new FormInformatoin();
            formInformation.ShowDialog();
        }

        private void toolStripButtonHelp_PAO_Click_1(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }


        private Size GetLabelSize(Label neededLabel)
        {
            Size neededSize = new Size(this.Width - neededLabel.Location.X - 35 , defaultLabelSize.Height);

            Size result = neededLabel.GetPreferredSize(neededSize);
            return result;
        }

        private void MoveLabels()
        {
            Label[] titles = { labelDirector_PAO, labelScreenwriter_PAO, labelRole_PAO, labelCountry_PAO, labelRating_PAO, labelDescription_PAO };
            Label[] parametrs = { labelDirectorText_PAO, labelScreenwriterText_PAO, labelRoleText_PAO, labelCountryText_PAO, labelRatingText_PAO, labelDescriptionText_PAO };

            for (int i = 0; i < parametrs.Length; i++)
            {
                parametrs[i].Size = GetLabelSize(parametrs[i]);

                if (i != parametrs.Length - 1)
                {
                    int AxisY = parametrs[i].Location.Y + parametrs[i].Size.Height;
                    parametrs[i + 1].Location = new Point(parametrs[i].Location.X, AxisY);
                    titles[i + 1].Location = new Point(titles[i].Location.X, AxisY);
                }
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            MoveLabels();
        }
    }
}
