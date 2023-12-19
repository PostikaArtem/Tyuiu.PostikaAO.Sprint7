
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
            this.panelLeft_PAO = new System.Windows.Forms.Panel();
            this.panelFill_PAO = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBoxName_PAO = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.panelTop_PAO.SuspendLayout();
            this.panelFill_PAO.SuspendLayout();
            this.groupBoxName_PAO.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_PAO
            // 
            this.panelTop_PAO.Controls.Add(this.comboBox1);
            this.panelTop_PAO.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PAO.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PAO.Name = "panelTop_PAO";
            this.panelTop_PAO.Size = new System.Drawing.Size(1012, 29);
            this.panelTop_PAO.TabIndex = 0;
            // 
            // panelLeft_PAO
            // 
            this.panelLeft_PAO.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PAO.Location = new System.Drawing.Point(0, 29);
            this.panelLeft_PAO.Name = "panelLeft_PAO";
            this.panelLeft_PAO.Size = new System.Drawing.Size(403, 496);
            this.panelLeft_PAO.TabIndex = 1;
            // 
            // panelFill_PAO
            // 
            this.panelFill_PAO.Controls.Add(this.groupBoxIn);
            this.panelFill_PAO.Controls.Add(this.groupBoxName_PAO);
            this.panelFill_PAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_PAO.Location = new System.Drawing.Point(403, 29);
            this.panelFill_PAO.Name = "panelFill_PAO";
            this.panelFill_PAO.Size = new System.Drawing.Size(609, 496);
            this.panelFill_PAO.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1012, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBoxName_PAO
            // 
            this.groupBoxName_PAO.Controls.Add(this.textBox1);
            this.groupBoxName_PAO.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxName_PAO.Location = new System.Drawing.Point(0, 0);
            this.groupBoxName_PAO.Name = "groupBoxName_PAO";
            this.groupBoxName_PAO.Size = new System.Drawing.Size(609, 71);
            this.groupBoxName_PAO.TabIndex = 0;
            this.groupBoxName_PAO.TabStop = false;
            this.groupBoxName_PAO.Text = "Название клипа:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(603, 47);
            this.textBox1.TabIndex = 0;
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Location = new System.Drawing.Point(56, 71);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(177, 101);
            this.groupBoxIn.TabIndex = 1;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "groupBox1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 525);
            this.Controls.Add(this.panelFill_PAO);
            this.Controls.Add(this.panelLeft_PAO);
            this.Controls.Add(this.panelTop_PAO);
            this.Name = "FormMain";
            this.Text = "Спринт 7 | Проект | Вариант 9 | Постика А.О.";
            this.panelTop_PAO.ResumeLayout(false);
            this.panelFill_PAO.ResumeLayout(false);
            this.groupBoxName_PAO.ResumeLayout(false);
            this.groupBoxName_PAO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_PAO;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelLeft_PAO;
        private System.Windows.Forms.Panel panelFill_PAO;
        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.GroupBox groupBoxName_PAO;
        private System.Windows.Forms.TextBox textBox1;
    }
}

