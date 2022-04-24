
namespace SAPR_SC
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.RemoveSection = new System.Windows.Forms.Button();
            this.EndF = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TaskParameters = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSection = new System.Windows.Forms.Button();
            this.Sections = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forceF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forceQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BeginningEndSealing = new System.Windows.Forms.RadioButton();
            this.EndSealing = new System.Windows.Forms.RadioButton();
            this.BeginningSealing = new System.Windows.Forms.RadioButton();
            this.BorderCondition = new System.Windows.Forms.GroupBox();
            this.Kernel = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.EndF)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskParameters)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sections)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.BorderCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kernel)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemoveSection
            // 
            this.RemoveSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveSection.Enabled = false;
            this.RemoveSection.Location = new System.Drawing.Point(473, 160);
            this.RemoveSection.Name = "RemoveSection";
            this.RemoveSection.Size = new System.Drawing.Size(118, 24);
            this.RemoveSection.TabIndex = 2;
            this.RemoveSection.Text = "Удалить участок";
            this.RemoveSection.UseVisualStyleBackColor = true;
            this.RemoveSection.Click += new System.EventHandler(this.RemoveSection_Click);
            // 
            // EndF
            // 
            this.EndF.AllowUserToAddRows = false;
            this.EndF.AllowUserToDeleteRows = false;
            this.EndF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EndF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EndF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.EndF.Location = new System.Drawing.Point(5, 20);
            this.EndF.Name = "EndF";
            this.EndF.RowTemplate.Height = 25;
            this.EndF.Size = new System.Drawing.Size(158, 72);
            this.EndF.TabIndex = 0;
            this.EndF.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EndF_CellEndEdit);
            this.EndF.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.EndF_CellValidating);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.EndF);
            this.groupBox4.Location = new System.Drawing.Point(614, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 96);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сила в конце конструкции";
            // 
            // TaskParameters
            // 
            this.TaskParameters.AllowUserToAddRows = false;
            this.TaskParameters.AllowUserToDeleteRows = false;
            this.TaskParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskParameters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5});
            this.TaskParameters.Location = new System.Drawing.Point(6, 19);
            this.TaskParameters.Name = "TaskParameters";
            this.TaskParameters.RowTemplate.Height = 25;
            this.TaskParameters.Size = new System.Drawing.Size(761, 60);
            this.TaskParameters.TabIndex = 12;
            this.TaskParameters.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskParameters_CellEndEdit);
            this.TaskParameters.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.TaskParameters_CellValidating);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "A, м2.";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "L, м.";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "F, H.";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "q, Н/м.";
            this.Column5.Name = "Column5";
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.TaskParameters);
            this.groupBox3.Location = new System.Drawing.Point(10, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(773, 88);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры задачи";
            // 
            // TablesToolStripMenuItem
            // 
            this.TablesToolStripMenuItem.Name = "TablesToolStripMenuItem";
            this.TablesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.TablesToolStripMenuItem.Text = "Табличное представление";
            this.TablesToolStripMenuItem.Click += new System.EventHandler(this.TablesToolStripMenuItem_Click);
            // 
            // ChartsToolStripMenuItem
            // 
            this.ChartsToolStripMenuItem.Name = "ChartsToolStripMenuItem";
            this.ChartsToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.ChartsToolStripMenuItem.Text = "Графическое представление";
            this.ChartsToolStripMenuItem.Click += new System.EventHandler(this.ChartsToolStripMenuItem_Click);
            // 
            // ResultsToolStripMenuItem
            // 
            this.ResultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChartsToolStripMenuItem,
            this.TablesToolStripMenuItem,
            this.PlotsToolStripMenuItem});
            this.ResultsToolStripMenuItem.Enabled = false;
            this.ResultsToolStripMenuItem.Name = "ResultsToolStripMenuItem";
            this.ResultsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ResultsToolStripMenuItem.Text = "Результаты";
            // 
            // PlotsToolStripMenuItem
            // 
            this.PlotsToolStripMenuItem.Name = "PlotsToolStripMenuItem";
            this.PlotsToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.PlotsToolStripMenuItem.Text = "Эпюры";
            this.PlotsToolStripMenuItem.Click += new System.EventHandler(this.PlotsToolStripMenuItem_Click);
            // 
            // CalculationToolStripMenuItem
            // 
            this.CalculationToolStripMenuItem.Enabled = false;
            this.CalculationToolStripMenuItem.Name = "CalculationToolStripMenuItem";
            this.CalculationToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.CalculationToolStripMenuItem.Text = "Выполнить расчет";
            this.CalculationToolStripMenuItem.Click += new System.EventHandler(this.CalculationToolStripMenuItem_Click);
            // 
            // ImportToolStripMenuItem
            // 
            this.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem";
            this.ImportToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ImportToolStripMenuItem.Text = "Загрузить проект";
            this.ImportToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // ExportToolStripMenuItem
            // 
            this.ExportToolStripMenuItem.Enabled = false;
            this.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            this.ExportToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ExportToolStripMenuItem.Text = "Сохранить проект";
            this.ExportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportToolStripMenuItem,
            this.ImportToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // AddSection
            // 
            this.AddSection.Location = new System.Drawing.Point(6, 159);
            this.AddSection.Name = "AddSection";
            this.AddSection.Size = new System.Drawing.Size(118, 24);
            this.AddSection.TabIndex = 1;
            this.AddSection.Text = "Добавить участок";
            this.AddSection.UseVisualStyleBackColor = true;
            this.AddSection.Click += new System.EventHandler(this.AddSection_Click);
            // 
            // Sections
            // 
            this.Sections.AllowUserToAddRows = false;
            this.Sections.AllowUserToDeleteRows = false;
            this.Sections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Sections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.secWidth,
            this.secSquare,
            this.forceF,
            this.forceQ,
            this.epss,
            this.sp});
            this.Sections.Location = new System.Drawing.Point(6, 20);
            this.Sections.MultiSelect = false;
            this.Sections.Name = "Sections";
            this.Sections.RowTemplate.Height = 25;
            this.Sections.Size = new System.Drawing.Size(585, 134);
            this.Sections.TabIndex = 0;
            this.Sections.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sections_CellEndEdit);
            this.Sections.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Sections_CellValidating);
            // 
            // num
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.num.DefaultCellStyle = dataGridViewCellStyle1;
            this.num.FillWeight = 38.07107F;
            this.num.HeaderText = "№";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // secWidth
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.secWidth.DefaultCellStyle = dataGridViewCellStyle2;
            this.secWidth.FillWeight = 115.4822F;
            this.secWidth.HeaderText = "L";
            this.secWidth.Name = "secWidth";
            this.secWidth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // secSquare
            // 
            this.secSquare.FillWeight = 115.4822F;
            this.secSquare.HeaderText = "A";
            this.secSquare.Name = "secSquare";
            this.secSquare.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // forceF
            // 
            this.forceF.FillWeight = 115.4822F;
            this.forceF.HeaderText = "F";
            this.forceF.Name = "forceF";
            this.forceF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // forceQ
            // 
            this.forceQ.FillWeight = 115.4822F;
            this.forceQ.HeaderText = "q";
            this.forceQ.Name = "forceQ";
            this.forceQ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // epss
            // 
            dataGridViewCellStyle3.Format = "E2";
            dataGridViewCellStyle3.NullValue = null;
            this.epss.DefaultCellStyle = dataGridViewCellStyle3;
            this.epss.HeaderText = "E, Па.";
            this.epss.Name = "epss";
            this.epss.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sp
            // 
            dataGridViewCellStyle4.Format = "E2";
            dataGridViewCellStyle4.NullValue = null;
            this.sp.DefaultCellStyle = dataGridViewCellStyle4;
            this.sp.HeaderText = "σ, Па.";
            this.sp.Name = "sp";
            this.sp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.RemoveSection);
            this.groupBox2.Controls.Add(this.AddSection);
            this.groupBox2.Controls.Add(this.Sections);
            this.groupBox2.Location = new System.Drawing.Point(10, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 189);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Участки стержня";
            // 
            // BeginningEndSealing
            // 
            this.BeginningEndSealing.AutoSize = true;
            this.BeginningEndSealing.Location = new System.Drawing.Point(10, 62);
            this.BeginningEndSealing.Name = "BeginningEndSealing";
            this.BeginningEndSealing.Size = new System.Drawing.Size(112, 17);
            this.BeginningEndSealing.TabIndex = 2;
            this.BeginningEndSealing.TabStop = true;
            this.BeginningEndSealing.Text = "В начале и конце";
            this.BeginningEndSealing.UseVisualStyleBackColor = true;
            this.BeginningEndSealing.CheckedChanged += new System.EventHandler(this.BeginningEndSealing_CheckedChanged);
            // 
            // EndSealing
            // 
            this.EndSealing.AutoSize = true;
            this.EndSealing.Location = new System.Drawing.Point(10, 41);
            this.EndSealing.Name = "EndSealing";
            this.EndSealing.Size = new System.Drawing.Size(65, 17);
            this.EndSealing.TabIndex = 1;
            this.EndSealing.TabStop = true;
            this.EndSealing.Text = "В конце";
            this.EndSealing.UseVisualStyleBackColor = true;
            this.EndSealing.CheckedChanged += new System.EventHandler(this.EndSealing_CheckedChanged);
            // 
            // BeginningSealing
            // 
            this.BeginningSealing.AutoSize = true;
            this.BeginningSealing.Location = new System.Drawing.Point(10, 19);
            this.BeginningSealing.Name = "BeginningSealing";
            this.BeginningSealing.Size = new System.Drawing.Size(70, 17);
            this.BeginningSealing.TabIndex = 0;
            this.BeginningSealing.TabStop = true;
            this.BeginningSealing.Text = "В начале";
            this.BeginningSealing.UseVisualStyleBackColor = true;
            this.BeginningSealing.CheckedChanged += new System.EventHandler(this.BeginningSealing_CheckedChanged);
            // 
            // BorderCondition
            // 
            this.BorderCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BorderCondition.Controls.Add(this.BeginningEndSealing);
            this.BorderCondition.Controls.Add(this.EndSealing);
            this.BorderCondition.Controls.Add(this.BeginningSealing);
            this.BorderCondition.Enabled = false;
            this.BorderCondition.Location = new System.Drawing.Point(613, 130);
            this.BorderCondition.Name = "BorderCondition";
            this.BorderCondition.Size = new System.Drawing.Size(170, 88);
            this.BorderCondition.TabIndex = 16;
            this.BorderCondition.TabStop = false;
            this.BorderCondition.Text = "Заделка";
            // 
            // Kernel
            // 
            this.Kernel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Kernel.Location = new System.Drawing.Point(10, 328);
            this.Kernel.Name = "Kernel";
            this.Kernel.Size = new System.Drawing.Size(773, 279);
            this.Kernel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Kernel.TabIndex = 15;
            this.Kernel.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.CalculationToolStripMenuItem,
            this.ResultsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 619);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BorderCondition);
            this.Controls.Add(this.Kernel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(811, 658);
            this.Name = "Main";
            this.Text = "SAPR-SC";
            ((System.ComponentModel.ISupportInitialize)(this.EndF)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskParameters)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Sections)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.BorderCondition.ResumeLayout(false);
            this.BorderCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kernel)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveSection;
        private System.Windows.Forms.DataGridView EndF;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView TaskParameters;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem TablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.Button AddSection;
        private System.Windows.Forms.DataGridView Sections;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton BeginningEndSealing;
        private System.Windows.Forms.RadioButton EndSealing;
        private System.Windows.Forms.RadioButton BeginningSealing;
        private System.Windows.Forms.GroupBox BorderCondition;
        private System.Windows.Forms.PictureBox Kernel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem PlotsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn secWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn secSquare;
        private System.Windows.Forms.DataGridViewTextBoxColumn forceF;
        private System.Windows.Forms.DataGridViewTextBoxColumn forceQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn epss;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp;
    }
}

