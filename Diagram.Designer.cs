
namespace SAPR_SC
{
    partial class Diagram
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagram));
            this.Plots = new System.Windows.Forms.PictureBox();
            this.panWindow = new System.Windows.Forms.Panel();
            this.ChartN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chartσ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Plots)).BeginInit();
            this.panWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chartσ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartU)).BeginInit();
            this.SuspendLayout();
            // 
            // Plots
            // 
            this.Plots.Location = new System.Drawing.Point(0, 0);
            this.Plots.Name = "Plots";
            this.Plots.Size = new System.Drawing.Size(100, 50);
            this.Plots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Plots.TabIndex = 0;
            this.Plots.TabStop = false;
            // 
            // panWindow
            // 
            this.panWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panWindow.AutoScroll = true;
            this.panWindow.Controls.Add(this.Plots);
            this.panWindow.Location = new System.Drawing.Point(12, 12);
            this.panWindow.Name = "panWindow";
            this.panWindow.Size = new System.Drawing.Size(219, 6268);
            this.panWindow.TabIndex = 2;
            // 
            // ChartN
            // 
            this.ChartN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartN.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.Name = "ChartArea1";
            this.ChartN.ChartAreas.Add(chartArea1);
            this.ChartN.Location = new System.Drawing.Point(12, 12);
            this.ChartN.Name = "ChartN";
            this.ChartN.Size = new System.Drawing.Size(798, 400);
            this.ChartN.TabIndex = 14;
            this.ChartN.Text = "ChartN";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "Nx";
            this.ChartN.Titles.Add(title1);
            // 
            // Chartσ
            // 
            this.Chartσ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chartσ.BackColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.Name = "ChartArea1";
            this.Chartσ.ChartAreas.Add(chartArea2);
            this.Chartσ.Location = new System.Drawing.Point(12, 418);
            this.Chartσ.Name = "Chartσ";
            this.Chartσ.Size = new System.Drawing.Size(798, 400);
            this.Chartσ.TabIndex = 15;
            this.Chartσ.Text = "Chartσ";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title1";
            title2.Text = "σx";
            this.Chartσ.Titles.Add(title2);
            // 
            // ChartU
            // 
            this.ChartU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChartU.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.Name = "ChartArea1";
            this.ChartU.ChartAreas.Add(chartArea3);
            this.ChartU.Location = new System.Drawing.Point(12, 824);
            this.ChartU.Name = "ChartU";
            this.ChartU.Size = new System.Drawing.Size(798, 400);
            this.ChartU.TabIndex = 16;
            this.ChartU.Text = "ChartU";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title1";
            title3.Text = "ux";
            this.ChartU.Titles.Add(title3);
            // 
            // Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(839, 451);
            this.Controls.Add(this.ChartU);
            this.Controls.Add(this.Chartσ);
            this.Controls.Add(this.ChartN);
            this.Controls.Add(this.panWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(855, 490);
            this.Name = "Diagram";
            this.Text = "Представление результатов в виде эпюр";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Diagram_FormClosed);
            this.Shown += new System.EventHandler(this.Diagram_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Plots)).EndInit();
            this.panWindow.ResumeLayout(false);
            this.panWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chartσ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Plots;
        private System.Windows.Forms.Panel panWindow;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartN;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chartσ;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartU;
    }
}