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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        
        public void ShowStatistics()
        {

            chartGenreStatistics_PAO.ChartAreas[0].AxisX.Title = "Жанры";
            chartGenreStatistics_PAO.ChartAreas[0].AxisY.Title = "Количество фильмов";

            //chartGenreStatistics_PAO.Series[0].Points.AddXY(i, numsMass[i]);
        }
    }
}
