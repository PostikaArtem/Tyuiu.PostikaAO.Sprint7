
namespace Tyuiu.PostikaAO.Sprint7.Project.V9
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGenreStatistics_PAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreStatistics_PAO)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGenreStatistics_PAO
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGenreStatistics_PAO.ChartAreas.Add(chartArea1);
            this.chartGenreStatistics_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartGenreStatistics_PAO.Legends.Add(legend1);
            this.chartGenreStatistics_PAO.Location = new System.Drawing.Point(0, 0);
            this.chartGenreStatistics_PAO.Name = "chartGenreStatistics_PAO";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGenreStatistics_PAO.Series.Add(series1);
            this.chartGenreStatistics_PAO.Size = new System.Drawing.Size(703, 443);
            this.chartGenreStatistics_PAO.TabIndex = 0;
            this.chartGenreStatistics_PAO.Click += new System.EventHandler(this.chart1_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 443);
            this.Controls.Add(this.chartGenreStatistics_PAO);
            this.MinimumSize = new System.Drawing.Size(721, 490);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreStatistics_PAO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenreStatistics_PAO;
    }
}