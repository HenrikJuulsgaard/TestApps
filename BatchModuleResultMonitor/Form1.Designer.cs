﻿namespace BatchModuleResultMonitor
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
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.InfoText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StdDevTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxMax = new System.Windows.Forms.TextBox();
            this.TxtBoxAvg = new System.Windows.Forms.TextBox();
            this.TxtBoxMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            this.chart1.BorderlineColor = System.Drawing.Color.DarkGray;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 100;
            chartArea1.AxisX.LabelAutoFitMinFontSize = 10;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.BackColor = System.Drawing.Color.Gray;
            chartArea1.BackSecondaryColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(47, 138);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Gray;
            series1.Legend = "Legend1";
            series1.Name = "Batch Weight";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1423, 583);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 742);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoText
            // 
            this.InfoText.Location = new System.Drawing.Point(180, 58);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(1252, 20);
            this.InfoText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(75, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Application info";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(391, 755);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(221, 20);
            this.PathTextBox.TabIndex = 4;
            this.PathTextBox.Text = "C:\\Temp\\AlgoLog_2.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 758);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Folder path and filename with extension :";
            // 
            // StdDevTxtBox
            // 
            this.StdDevTxtBox.Location = new System.Drawing.Point(790, 755);
            this.StdDevTxtBox.Name = "StdDevTxtBox";
            this.StdDevTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StdDevTxtBox.Size = new System.Drawing.Size(71, 20);
            this.StdDevTxtBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 758);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Standard Diviation";
            // 
            // TxtBoxMax
            // 
            this.TxtBoxMax.Location = new System.Drawing.Point(1379, 202);
            this.TxtBoxMax.Name = "TxtBoxMax";
            this.TxtBoxMax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBoxMax.Size = new System.Drawing.Size(53, 20);
            this.TxtBoxMax.TabIndex = 10;
            // 
            // TxtBoxAvg
            // 
            this.TxtBoxAvg.Location = new System.Drawing.Point(1379, 228);
            this.TxtBoxAvg.Name = "TxtBoxAvg";
            this.TxtBoxAvg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBoxAvg.Size = new System.Drawing.Size(53, 20);
            this.TxtBoxAvg.TabIndex = 11;
            // 
            // TxtBoxMin
            // 
            this.TxtBoxMin.Location = new System.Drawing.Point(1379, 254);
            this.TxtBoxMin.Name = "TxtBoxMin";
            this.TxtBoxMin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBoxMin.Size = new System.Drawing.Size(53, 20);
            this.TxtBoxMin.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1290, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Max weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1288, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Avg weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1288, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Min weight";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1523, 863);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxMin);
            this.Controls.Add(this.TxtBoxAvg);
            this.Controls.Add(this.TxtBoxMax);
            this.Controls.Add(this.StdDevTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InfoText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StdDevTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxMax;
        private System.Windows.Forms.TextBox TxtBoxAvg;
        private System.Windows.Forms.TextBox TxtBoxMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

