namespace SortingWInForm
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BubbleChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.FastChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.InsertChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BogoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShakerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BubbleChartTimer = new System.Windows.Forms.TextBox();
            this.FastChartTimer = new System.Windows.Forms.TextBox();
            this.InsertChartTimer = new System.Windows.Forms.TextBox();
            this.BogoChartTimer = new System.Windows.Forms.TextBox();
            this.ShakerChartTimer = new System.Windows.Forms.TextBox();
            this.HowMuchText = new System.Windows.Forms.TextBox();
            this.BubbleBox = new System.Windows.Forms.CheckBox();
            this.ShakerBox = new System.Windows.Forms.CheckBox();
            this.BogoBox = new System.Windows.Forms.CheckBox();
            this.QuickBox = new System.Windows.Forms.CheckBox();
            this.InsertBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BubbleChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FastChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BogoChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShakerChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BubbleChart
            // 
            chartArea1.Name = "ChartArea1";
            this.BubbleChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BubbleChart.Legends.Add(legend1);
            this.BubbleChart.Location = new System.Drawing.Point(9, 100);
            this.BubbleChart.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BubbleChart.Name = "BubbleChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.BubbleChart.Series.Add(series1);
            this.BubbleChart.Size = new System.Drawing.Size(290, 174);
            this.BubbleChart.TabIndex = 0;
            this.BubbleChart.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FastChart
            // 
            chartArea2.Name = "ChartArea1";
            this.FastChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.FastChart.Legends.Add(legend2);
            this.FastChart.Location = new System.Drawing.Point(312, 100);
            this.FastChart.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.FastChart.Name = "FastChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.FastChart.Series.Add(series2);
            this.FastChart.Size = new System.Drawing.Size(290, 174);
            this.FastChart.TabIndex = 2;
            this.FastChart.Text = "chart2";
            // 
            // InsertChart
            // 
            chartArea3.Name = "ChartArea1";
            this.InsertChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.InsertChart.Legends.Add(legend3);
            this.InsertChart.Location = new System.Drawing.Point(621, 100);
            this.InsertChart.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.InsertChart.Name = "InsertChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.InsertChart.Series.Add(series3);
            this.InsertChart.Size = new System.Drawing.Size(290, 174);
            this.InsertChart.TabIndex = 3;
            this.InsertChart.Text = "chart3";
            // 
            // BogoChart
            // 
            chartArea4.Name = "ChartArea1";
            this.BogoChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.BogoChart.Legends.Add(legend4);
            this.BogoChart.Location = new System.Drawing.Point(134, 319);
            this.BogoChart.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BogoChart.Name = "BogoChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.BogoChart.Series.Add(series4);
            this.BogoChart.Size = new System.Drawing.Size(290, 174);
            this.BogoChart.TabIndex = 4;
            this.BogoChart.Text = "chart4";
            // 
            // ShakerChart
            // 
            chartArea5.Name = "ChartArea1";
            this.ShakerChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ShakerChart.Legends.Add(legend5);
            this.ShakerChart.Location = new System.Drawing.Point(482, 319);
            this.ShakerChart.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ShakerChart.Name = "ShakerChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.ShakerChart.Series.Add(series5);
            this.ShakerChart.Size = new System.Drawing.Size(290, 174);
            this.ShakerChart.TabIndex = 5;
            this.ShakerChart.Text = "chart5";
            // 
            // BubbleChartTimer
            // 
            this.BubbleChartTimer.Location = new System.Drawing.Point(67, 74);
            this.BubbleChartTimer.Name = "BubbleChartTimer";
            this.BubbleChartTimer.ReadOnly = true;
            this.BubbleChartTimer.Size = new System.Drawing.Size(145, 20);
            this.BubbleChartTimer.TabIndex = 6;
            // 
            // FastChartTimer
            // 
            this.FastChartTimer.Location = new System.Drawing.Point(369, 74);
            this.FastChartTimer.Name = "FastChartTimer";
            this.FastChartTimer.ReadOnly = true;
            this.FastChartTimer.Size = new System.Drawing.Size(145, 20);
            this.FastChartTimer.TabIndex = 7;
            // 
            // InsertChartTimer
            // 
            this.InsertChartTimer.Location = new System.Drawing.Point(669, 74);
            this.InsertChartTimer.Name = "InsertChartTimer";
            this.InsertChartTimer.ReadOnly = true;
            this.InsertChartTimer.Size = new System.Drawing.Size(145, 20);
            this.InsertChartTimer.TabIndex = 8;
            // 
            // BogoChartTimer
            // 
            this.BogoChartTimer.Location = new System.Drawing.Point(193, 293);
            this.BogoChartTimer.Name = "BogoChartTimer";
            this.BogoChartTimer.ReadOnly = true;
            this.BogoChartTimer.Size = new System.Drawing.Size(145, 20);
            this.BogoChartTimer.TabIndex = 9;
            // 
            // ShakerChartTimer
            // 
            this.ShakerChartTimer.Location = new System.Drawing.Point(568, 293);
            this.ShakerChartTimer.Name = "ShakerChartTimer";
            this.ShakerChartTimer.ReadOnly = true;
            this.ShakerChartTimer.Size = new System.Drawing.Size(145, 20);
            this.ShakerChartTimer.TabIndex = 10;
            // 
            // HowMuchText
            // 
            this.HowMuchText.Location = new System.Drawing.Point(312, 28);
            this.HowMuchText.Name = "HowMuchText";
            this.HowMuchText.Size = new System.Drawing.Size(59, 20);
            this.HowMuchText.TabIndex = 11;
            this.HowMuchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HowMuchText_KeyPress);
            // 
            // BubbleBox
            // 
            this.BubbleBox.Location = new System.Drawing.Point(392, 22);
            this.BubbleBox.Name = "BubbleBox";
            this.BubbleBox.Size = new System.Drawing.Size(114, 32);
            this.BubbleBox.TabIndex = 12;
            this.BubbleBox.Text = "Bubble";
            this.BubbleBox.UseVisualStyleBackColor = true;
            // 
            // ShakerBox
            // 
            this.ShakerBox.Location = new System.Drawing.Point(443, 22);
            this.ShakerBox.Name = "ShakerBox";
            this.ShakerBox.Size = new System.Drawing.Size(114, 32);
            this.ShakerBox.TabIndex = 13;
            this.ShakerBox.Text = "Shaker";
            this.ShakerBox.UseVisualStyleBackColor = true;
            // 
            // BogoBox
            // 
            this.BogoBox.Location = new System.Drawing.Point(503, 22);
            this.BogoBox.Name = "BogoBox";
            this.BogoBox.Size = new System.Drawing.Size(114, 32);
            this.BogoBox.TabIndex = 14;
            this.BogoBox.Text = "Bogo";
            this.BogoBox.UseVisualStyleBackColor = true;
            // 
            // QuickBox
            // 
            this.QuickBox.Location = new System.Drawing.Point(556, 22);
            this.QuickBox.Name = "QuickBox";
            this.QuickBox.Size = new System.Drawing.Size(114, 32);
            this.QuickBox.TabIndex = 15;
            this.QuickBox.Text = "Quick";
            this.QuickBox.UseVisualStyleBackColor = true;
            // 
            // InsertBox
            // 
            this.InsertBox.Location = new System.Drawing.Point(607, 22);
            this.InsertBox.Name = "InsertBox";
            this.InsertBox.Size = new System.Drawing.Size(114, 32);
            this.InsertBox.TabIndex = 16;
            this.InsertBox.Text = "Insert";
            this.InsertBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 24);
            this.button2.TabIndex = 17;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Array Length:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 529);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InsertBox);
            this.Controls.Add(this.QuickBox);
            this.Controls.Add(this.BogoBox);
            this.Controls.Add(this.ShakerBox);
            this.Controls.Add(this.BubbleBox);
            this.Controls.Add(this.HowMuchText);
            this.Controls.Add(this.ShakerChartTimer);
            this.Controls.Add(this.BogoChartTimer);
            this.Controls.Add(this.InsertChartTimer);
            this.Controls.Add(this.FastChartTimer);
            this.Controls.Add(this.BubbleChartTimer);
            this.Controls.Add(this.ShakerChart);
            this.Controls.Add(this.BogoChart);
            this.Controls.Add(this.InsertChart);
            this.Controls.Add(this.FastChart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BubbleChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BubbleChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FastChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsertChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BogoChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShakerChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.CheckBox BubbleBox;
        private System.Windows.Forms.CheckBox ShakerBox;
        private System.Windows.Forms.CheckBox BogoBox;
        private System.Windows.Forms.CheckBox QuickBox;
        private System.Windows.Forms.CheckBox InsertBox;

        private System.Windows.Forms.TextBox HowMuchText;

        private System.Windows.Forms.TextBox FastChartTimer;
        private System.Windows.Forms.TextBox InsertChartTimer;
        private System.Windows.Forms.TextBox BogoChartTimer;
        private System.Windows.Forms.TextBox ShakerChartTimer;

        private System.Windows.Forms.TextBox BubbleChartTimer;

        private System.Windows.Forms.DataVisualization.Charting.Chart FastChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart InsertChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart BogoChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ShakerChart;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DataVisualization.Charting.Chart BubbleChart;

        #endregion
    }
}