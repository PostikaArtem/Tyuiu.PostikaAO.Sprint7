using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PostikaAO.Sprint7.Project.V9.Lib;
namespace Tyuiu.PostikaAO.Sprint7.Project.V9
{
    public partial class FormAddFilm : Form
    {
        public FormAddFilm()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonAdd_PAO_Click(object sender, EventArgs e)
        {
            
            string[] values = new string[9];


            if(pathImage==""&& !string.IsNullOrEmpty(textBoxlName_PAO.Text)&& !string.IsNullOrEmpty(textBoxlName_PAO.Text) && !string.IsNullOrEmpty(textBoxScreenwriter_PAO.Text)&& !string.IsNullOrEmpty(textBoxDirector_PAO.Text) && !string.IsNullOrEmpty(textBoxGenre_PAO.Text) && !string.IsNullOrEmpty(textBoxRole_PAO.Text) && !string.IsNullOrEmpty(textBoxStudio_PAO.Text) && !string.IsNullOrEmpty(textBoxYear_PAO.Text) && !string.IsNullOrEmpty(textBoxDescription_PAO.Text))
            {
                values[0] = pathImage;
                values[1] = textBoxlName_PAO.Text;
                values[2] = textBoxCountry_PAO.Text;
                values[3] = textBoxScreenwriter_PAO.Text;
                values[4] = textBoxDirector_PAO.Text;
                values[5] = textBoxGenre_PAO.Text;
                values[6] = textBoxRole_PAO.Text;
                values[7] = textBoxStudio_PAO.Text;
                values[8] = textBoxYear_PAO.Text;
                values[9] = textBoxDescription_PAO.Text;

                ds.AddFilm(values);
            }
            else
            {
                MessageBox.Show("Заполните все поля!!!","Ошибка");
            }
        }
        string pathImage = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathImage = openFileDialog1.FileName;
                pictureBoxPreview_PAO.Image = Image.FromFile(pathImage);
            }
           
        }

    }
}
