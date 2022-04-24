
namespace SAPR_SC
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Charts));
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedSection = new System.Windows.Forms.ComboBox();
            this.ChartU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chartσ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ChartU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chartσ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartN)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Отображаемый участок стержня";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedSection
            // 
            this.SelectedSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedSection.FormattingEnabled = true;
            this.SelectedSection.Location = new System.Drawing.Point(189, 12);
            this.SelectedSection.Name = "SelectedSection";
            this.SelectedSection.Size = new System.Drawing.Size(87, 21);
            this.SelectedSection.TabIndex = 7;
            this.SelectedSection.SelectedIndexChanged += new System.EventHandler(this.SelectedSection_SelectedIndexChanged);
            // 
            // ChartU
            // 
            this.ChartU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ChartU.ChartAreas.Add(chartArea1);
            this.ChartU.Location = new System.Drawing.Point(3, 715);
            this.ChartU.Name = "ChartU";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.ChartU.Series.Add(series1);
            this.ChartU.Size = new System.Drawing.Size(735, 350);
            this.ChartU.TabIndex = 10;
            this.ChartU.Text = "chart2";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "ux";
            this.ChartU.Titles.Add(title1);
            // 
            // Chartσ
            // 
            this.Chartσ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.Chartσ.ChartAreas.Add(chartArea2);
            this.Chartσ.Location = new System.Drawing.Point(3, 359);
            this.Chartσ.Name = "Chartσ";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.Chartσ.Series.Add(series2);
            this.Chartσ.Size = new System.Drawing.Size(735, 350);
            this.Chartσ.TabIndex = 11;
            this.Chartσ.Text = "chart3";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "σx";
            this.Chartσ.Titles.Add(title2);
            // 
            // ChartN
            // 
            this.ChartN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.ChartN.ChartAreas.Add(chartArea3);
            this.ChartN.Location = new System.Drawing.Point(3, 3);
            this.ChartN.Name = "ChartN";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.ChartN.Series.Add(series3);
            this.ChartN.Size = new System.Drawing.Size(735, 350);
            this.ChartN.TabIndex = 13;
            this.ChartN.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title1";
            title3.Text = "Nx";
            this.ChartN.Titles.Add(title3);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ChartN);
            this.panel1.Controls.Add(this.Chartσ);
            this.panel1.Controls.Add(this.ChartU);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 1068);
            this.panel1.TabIndex = 14;
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(799, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedSection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(815, 520);
            this.Name = "Charts";
            this.Text = "Графическое представление результатов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Charts_FormClosed);
            this.Shown += new System.EventHandler(this.Results_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ChartU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chartσ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectedSection;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartU;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chartσ;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartN;
        private System.Windows.Forms.Panel panel1;
    }
}