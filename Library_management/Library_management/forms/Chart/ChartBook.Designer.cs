﻿
namespace Library_management.forms.Chart
{
    partial class ChartBook
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.photos2 = new System.Windows.Forms.Label();
            this.photos1 = new System.Windows.Forms.Label();
            this.BarChartBooks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChartBooks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(-1, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 92);
            this.panel1.TabIndex = 7;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(192, 42);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(266, 30);
            this.title.TabIndex = 0;
            this.title.Text = "CHART ABOUT BOOKS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(658, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 140;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // photos2
            // 
            this.photos2.AutoSize = true;
            this.photos2.Location = new System.Drawing.Point(398, 462);
            this.photos2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.photos2.Name = "photos2";
            this.photos2.Size = new System.Drawing.Size(188, 13);
            this.photos2.TabIndex = 9;
            this.photos2.Text = "H4.2 Pie chart illustrates type of books";
            // 
            // photos1
            // 
            this.photos1.AutoSize = true;
            this.photos1.Location = new System.Drawing.Point(45, 462);
            this.photos1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.photos1.Name = "photos1";
            this.photos1.Size = new System.Drawing.Size(220, 13);
            this.photos1.TabIndex = 8;
            this.photos1.Text = "H4.1Bar chart illustrates the books library had";
            // 
            // BarChartBooks
            // 
            chartArea1.Name = "ChartArea1";
            this.BarChartBooks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarChartBooks.Legends.Add(legend1);
            this.BarChartBooks.Location = new System.Drawing.Point(47, 192);
            this.BarChartBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarChartBooks.Name = "BarChartBooks";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Books";
            this.BarChartBooks.Series.Add(series1);
            this.BarChartBooks.Size = new System.Drawing.Size(314, 244);
            this.BarChartBooks.TabIndex = 141;
            this.BarChartBooks.Text = "chart";
            // 
            // pieChartBooks
            // 
            chartArea2.Name = "ChartArea1";
            this.pieChartBooks.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieChartBooks.Legends.Add(legend2);
            this.pieChartBooks.Location = new System.Drawing.Point(400, 205);
            this.pieChartBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pieChartBooks.Name = "pieChartBooks";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pieChartBooks.Series.Add(series2);
            this.pieChartBooks.Size = new System.Drawing.Size(225, 244);
            this.pieChartBooks.TabIndex = 142;
            this.pieChartBooks.Text = "Pie chart Books";
            // 
            // ChartBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 538);
            this.Controls.Add(this.pieChartBooks);
            this.Controls.Add(this.BarChartBooks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.photos2);
            this.Controls.Add(this.photos1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChartBook";
            this.Text = "ChartBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label photos2;
        private System.Windows.Forms.Label photos1;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChartBooks;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartBooks;
    }
}