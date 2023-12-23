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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_PAO_Click(object sender, EventArgs e)
        {
            FormAddFilm AddForm = new FormAddFilm();
            AddForm.ShowDialog();
        }

        private void buttonDelete_PAO_Click(object sender, EventArgs e)
        {
            string[] data = ds.OpenFilm(0);

            labelName_PAO.Text = data[0];
            labelYearText_PAO.Text = data[1];
            labelGenreText_PAO.Text = data[2];
            labelDirectorText_PAO.Text = data[3];
            labelScreenwriterText_PAO.Text = data[4];
            labelRoleText_PAO.Text = data[5];
            labelCountryText_PAO.Text = data[6];
            labelStudioText_PAO.Text = data[7];
            labelDescriptionText_PAO.Text = data[8];
        }

        private void UpdateFilmsButtons()
        {
            flowLayoutPanelLeft_PAO.Controls.Clear();
            
        }

        private void labelRoleText_PAO_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_PAO_Enter(object sender, EventArgs e)
        {
            if(textBoxSearch_PAO.Text == "Поиск...")
            {
                textBoxSearch_PAO.Text = "";
                textBoxSearch_PAO.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_PAO_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch_PAO.Text == "")
            {
                textBoxSearch_PAO.Text = "Поиск...";
                textBoxSearch_PAO.ForeColor = Color.Silver;
            }
        }
    }
}
