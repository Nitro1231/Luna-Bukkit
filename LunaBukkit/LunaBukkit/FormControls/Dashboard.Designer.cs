namespace LunaBukkit.FormControls {
    partial class Dashboard {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dashboardTitle = new System.Windows.Forms.Label();
            this.SystemChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sysChartText = new System.Windows.Forms.Label();
            this.tTimeText = new System.Windows.Forms.Label();
            this.pcUserNameText = new System.Windows.Forms.Label();
            this.pcBitText = new System.Windows.Forms.Label();
            this.pcCPUName = new System.Windows.Forms.Label();
            this.ramProgressBar = new LunaBukkit.Controls.CircleProgressBar();
            this.cpuProgressBar = new LunaBukkit.Controls.CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.SystemChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardTitle
            // 
            this.dashboardTitle.AutoSize = true;
            this.dashboardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardTitle.Location = new System.Drawing.Point(2, 0);
            this.dashboardTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dashboardTitle.Name = "dashboardTitle";
            this.dashboardTitle.Size = new System.Drawing.Size(238, 45);
            this.dashboardTitle.TabIndex = 0;
            this.dashboardTitle.Text = "dashboardTitle";
            // 
            // SystemChart
            // 
            this.SystemChart.BackColor = System.Drawing.Color.Transparent;
            this.SystemChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.SystemChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            legend1.Name = "Legend1";
            this.SystemChart.Legends.Add(legend1);
            this.SystemChart.Location = new System.Drawing.Point(-11, 63);
            this.SystemChart.Name = "SystemChart";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "CPU";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "RAM";
            this.SystemChart.Series.Add(series1);
            this.SystemChart.Series.Add(series2);
            this.SystemChart.Size = new System.Drawing.Size(647, 177);
            this.SystemChart.TabIndex = 6;
            this.SystemChart.Text = "Chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(568, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "CPU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(691, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "RAM";
            // 
            // sysChartText
            // 
            this.sysChartText.AutoSize = true;
            this.sysChartText.Location = new System.Drawing.Point(446, 243);
            this.sysChartText.Name = "sysChartText";
            this.sysChartText.Size = new System.Drawing.Size(73, 15);
            this.sysChartText.TabIndex = 11;
            this.sysChartText.Text = "sysChartText";
            // 
            // tTimeText
            // 
            this.tTimeText.AutoSize = true;
            this.tTimeText.Location = new System.Drawing.Point(53, 242);
            this.tTimeText.Name = "tTimeText";
            this.tTimeText.Size = new System.Drawing.Size(58, 15);
            this.tTimeText.TabIndex = 12;
            this.tTimeText.Text = "tTimeText";
            // 
            // pcUserNameText
            // 
            this.pcUserNameText.AutoSize = true;
            this.pcUserNameText.Location = new System.Drawing.Point(36, 267);
            this.pcUserNameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcUserNameText.Name = "pcUserNameText";
            this.pcUserNameText.Size = new System.Drawing.Size(96, 15);
            this.pcUserNameText.TabIndex = 13;
            this.pcUserNameText.Text = "pcUserNameText";
            // 
            // pcBitText
            // 
            this.pcBitText.AutoSize = true;
            this.pcBitText.Location = new System.Drawing.Point(36, 286);
            this.pcBitText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcBitText.Name = "pcBitText";
            this.pcBitText.Size = new System.Drawing.Size(55, 15);
            this.pcBitText.TabIndex = 14;
            this.pcBitText.Text = "pcBitText";
            // 
            // pcCPUName
            // 
            this.pcCPUName.AutoSize = true;
            this.pcCPUName.Location = new System.Drawing.Point(36, 305);
            this.pcCPUName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcCPUName.Name = "pcCPUName";
            this.pcCPUName.Size = new System.Drawing.Size(75, 15);
            this.pcCPUName.TabIndex = 15;
            this.pcCPUName.Text = "pcCPUName";
            // 
            // ramProgressBar
            // 
            this.ramProgressBar.Location = new System.Drawing.Point(668, 102);
            this.ramProgressBar.Name = "ramProgressBar";
            this.ramProgressBar.Size = new System.Drawing.Size(120, 120);
            this.ramProgressBar.TabIndex = 8;
            // 
            // cpuProgressBar
            // 
            this.cpuProgressBar.Location = new System.Drawing.Point(542, 102);
            this.cpuProgressBar.Name = "cpuProgressBar";
            this.cpuProgressBar.Size = new System.Drawing.Size(120, 120);
            this.cpuProgressBar.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.pcCPUName);
            this.Controls.Add(this.pcBitText);
            this.Controls.Add(this.pcUserNameText);
            this.Controls.Add(this.tTimeText);
            this.Controls.Add(this.sysChartText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ramProgressBar);
            this.Controls.Add(this.cpuProgressBar);
            this.Controls.Add(this.SystemChart);
            this.Controls.Add(this.dashboardTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(800, 506);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.SystemChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboardTitle;
        internal System.Windows.Forms.DataVisualization.Charting.Chart SystemChart;
        private Controls.CircleProgressBar cpuProgressBar;
        private Controls.CircleProgressBar ramProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sysChartText;
        private System.Windows.Forms.Label tTimeText;
        private System.Windows.Forms.Label pcUserNameText;
        private System.Windows.Forms.Label pcBitText;
        private System.Windows.Forms.Label pcCPUName;
    }
}
