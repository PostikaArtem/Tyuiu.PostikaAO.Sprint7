using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PostikaAO.Sprint7.Project.V9
{
    public partial class FormSearch : Form
    {
        FormMain form;
        public FormSearch(FormMain formMain )
        {
            InitializeComponent();
            form = formMain;
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void buttonSearch_PAO_Click(object sender, EventArgs e)
        {
            string searchRequest = textBoxSearch_PAO.Text;

            if (!string.IsNullOrEmpty(searchRequest))
            {
                form.Search(searchRequest.ToLower());
            }
            else
            {
                form.UpdateFilmsButtons();
                MessageBox.Show("Задан пустой поисковой запрос.", "Ошибка");
            }
            
            
            this.Close();
        }

        private void textBoxSearch_PAO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_PAO_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch_PAO.Text == "Поиск...")
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
