using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace SAPR_SC
{
    public partial class Main : Form
    {
        Graphics g;
        Bitmap bmp;
        public Main()
        {
            InitializeComponent();
            bmp = new Bitmap(Kernel.Width, Kernel.Height);
            g = Graphics.FromImage(bmp);
        }

        List<double> arrL = new List<double>();
        List<double> arrA = new List<double>();
        List<double> arrParameters = new List<double>();
        List<double> arrE = new List<double>();
        List<double> arrS = new List<double>();
        List<double> delta = new List<double>();
        List<int> arrLoadsQ = new List<int>();
        List<int> arrLoadsF = new List<int>();
        List<int> arrSealing = new List<int>();
        List<int> sectionCordinates = new List<int>();
        List<int> sectionLength = new List<int>();
        List<int> sectionSquare = new List<int>();        

        Pen brLine = new Pen(Color.Black, 5);
        Pen brLineLight = new Pen(Color.Black, 2);
        Pen brFrame = new Pen(Color.FromArgb(119, 119, 119), 5);
        Pen brF = new Pen(Color.FromArgb(0, 0, 255), 10);
        Pen brQ = new Pen(Color.FromArgb(255, 0, 0), 5);
        SolidBrush brFill = new SolidBrush(Color.FromArgb(238, 238, 238));

        private void KernelPainting()
        {
            ResultsToolStripMenuItem.Enabled = false;
            sectionLength.Clear();
            sectionCordinates.Clear();
            sectionSquare.Clear();
            arrL.Clear();
            arrA.Clear();
            arrE.Clear();
            arrS.Clear();
            arrLoadsF.Clear();
            arrLoadsQ.Clear();
            sectionCordinates.Add(70);
            int widthRemains, square, maxSquare, bufWidth, width = 0;
            maxSquare = int.Parse(Sections.Rows[0].Cells[2].Value.ToString());
            for (int i = 0; i < Sections.Rows.Count; i++)
            {
                width += int.Parse(Sections.Rows[i].Cells[1].Value.ToString());
                if (maxSquare < int.Parse(Sections.Rows[i].Cells[2].Value.ToString()))
                {
                    maxSquare = int.Parse(Sections.Rows[i].Cells[2].Value.ToString());
                }
            }
            square = 120 / maxSquare;
            widthRemains = width;
            bufWidth = width = 630 / width;
            widthRemains = 630 - widthRemains * width;
            for (int i = 0; i < Sections.Rows.Count; i++)
            {
                bufWidth *= int.Parse(Sections.Rows[i].Cells[1].Value.ToString());
                arrL.Add(int.Parse(Sections.Rows[i].Cells[1].Value.ToString()));
                arrA.Add(int.Parse(Sections.Rows[i].Cells[2].Value.ToString()));
                arrLoadsF.Add(int.Parse(Sections.Rows[i].Cells[3].Value.ToString()));
                arrLoadsQ.Add(int.Parse(Sections.Rows[i].Cells[4].Value.ToString()));
                arrE.Add(double.Parse(Sections.Rows[i].Cells[5].Value.ToString()));
                arrS.Add(double.Parse(Sections.Rows[i].Cells[6].Value.ToString()));
                sectionSquare.Add(square * int.Parse(Sections.Rows[i].Cells[2].Value.ToString()));
                sectionLength.Add(bufWidth); 
                bufWidth = width;
            }
            arrLoadsF.Add(int.Parse(EndF.Rows[0].Cells[0].Value.ToString()));
            g.Clear(Color.Transparent);
            int count = 0;
            int sL = sectionLength[count];
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Far
            };
            for (int i = 70; i < 700 - widthRemains; i += sL)
            {
                Rectangle Rect = new Rectangle(i, 100, sectionLength[count], 160);
                g.DrawRectangle(brLineLight, Rect);
                g.DrawString(arrL[count].ToString() + "L", new Font("Times", 10), Brushes.Black, Rect, sf);
                g.FillRectangle(brFill, i, 100 - sectionSquare[count] / 2, sectionLength[count], sectionSquare[count]);
                g.DrawRectangle(brFrame, i, 100 - sectionSquare[count] / 2, sectionLength[count], sectionSquare[count]);
                sL = sectionLength[count];
                sectionCordinates.Add(i + sL);
                count++;
            }
            SealingInstallation(700 - widthRemains);
            LoadsQPainting(sf);
            LoadsFPainting();
            Kernel.Image = bmp;
        }

        private void LoadsQPainting(StringFormat infoString)
        {
            for (int i = 0; i < arrLoadsQ.Count; i++)
            {
                Rectangle Rect = new Rectangle(sectionCordinates[i], 80, sectionLength[i], 80);
                infoString.LineAlignment = StringAlignment.Near;
                if (arrLoadsQ[i] > 0)
                {
                    for (int j = sectionCordinates[i] + 15; j <= sectionCordinates[i + 1]; j += 15)
                    {
                        brQ.EndCap = LineCap.Flat;
                        brQ.StartCap = LineCap.ArrowAnchor;
                        g.DrawLine(brQ, j, 100, j - 15, 100);
                        g.DrawString(arrLoadsQ[i].ToString() + "q", new Font("Times", 10), Brushes.Red, Rect, infoString);
                    }

                }
                if (arrLoadsQ[i] < 0)
                {
                    for (int j = sectionCordinates[i] + 15; j <= sectionCordinates[i + 1]; j += 15)
                    {
                        brQ.StartCap = LineCap.Flat;
                        brQ.EndCap = LineCap.ArrowAnchor;
                        g.DrawLine(brQ, j, 100, j - 15, 100);
                        g.DrawString(arrLoadsQ[i].ToString() + "q", new Font("Times", 10), Brushes.Red, Rect, infoString);
                    }
                }
            }
        }

        private void LoadsFPainting()
        {
            for (int i = 0; i < sectionCordinates.Count; i++)
            {
                if (arrLoadsF[i] > 0)
                {
                    brF.StartCap = LineCap.Flat;
                    brF.EndCap = LineCap.ArrowAnchor;
                    g.DrawLine(brF, sectionCordinates[i], 100, sectionCordinates[i] + 50, 100);
                    g.DrawString(arrLoadsF[i].ToString() + "F", new Font("Times", 10, FontStyle.Bold), Brushes.Blue, sectionCordinates[i] + 10, 105);
                }
                if (arrLoadsF[i] < 0)
                {
                    brF.StartCap = LineCap.ArrowAnchor;
                    brF.EndCap = LineCap.Flat;
                    g.DrawLine(brF, sectionCordinates[i] - 50, 100, sectionCordinates[i], 100);
                    g.DrawString(arrLoadsF[i].ToString() + "F", new Font("Times", 10, FontStyle.Bold), Brushes.Blue, sectionCordinates[i] - 30, 105);
                }
            }
        }

        private void AddSection_Click(object sender, EventArgs e)
        {
            arrL.Add(1);
            arrA.Add(1);
            arrLoadsQ.Add(0);
            arrLoadsF.Add(0);
            arrE.Add(2e11F);
            arrS.Add(2e6F);

            if (Sections.Rows.Count == 0)
            {
                double[] input = { 1, 1, 1, 1 };
                EndF.Rows.Add("0");
                TaskParameters.Rows.Add(1, 1, 1, 1);
                Sections.Rows.Add(Sections.Rows.Count + 1, 1, 1, 0, 0, 2e11F, 2e6F);
                arrParameters.AddRange(input);
                RemoveSection.Enabled = true;
                BorderCondition.Enabled = true;
                BeginningSealing.Checked = true;
                ExportToolStripMenuItem.Enabled = true;
                CalculationToolStripMenuItem.Enabled = true;
            }
            else
            {
                Sections.Rows.Add(Sections.Rows.Count + 1, 1, 1, 0, 0, 2e11F, 2e6F);
            }
            KernelPainting();
        }

        private void RemoveSection_Click(object sender, EventArgs e)
        {
            if (Sections.Rows.Count > 1)
            {
                int rowIndex = int.Parse(Sections.CurrentRow.Cells[0].Value.ToString()) - 1;
                Sections.Rows.RemoveAt(rowIndex);
                for (int i = rowIndex; i < Sections.Rows.Count; i++)
                    Sections.Rows[i].Cells[0].Value = i + 1;
                KernelPainting();
            }
            else
            {
                Sections.Rows.Clear();
                EndF.Rows.Clear();
                TaskParameters.Rows.Clear();
                arrParameters.Clear();
                RemoveSection.Enabled = false;
                ExportToolStripMenuItem.Enabled = false;
                BorderCondition.Enabled = false;
                EndF.Enabled = false;
                CalculationToolStripMenuItem.Enabled = false;
                Kernel.Image = null;
            }
        }

        private void SealingInstallation(int end)
        {
            if (BeginningSealing.Checked)
            {
                g.DrawLine(brLine, 65, 15, 65, 190);
                for (int i = 0; i < 175; i += 24)
                {
                    g.DrawLine(brLineLight, 50, i, 65, i + 20);
                }
            }
            if (EndSealing.Checked)
            {
                g.DrawLine(brLine, end + 5, 15, end + 5, 190);
                for (int i = 15; i < 190; i += 24)
                {
                    g.DrawLine(brLineLight, end + 5, i, 720, i + 20);
                }
            }
            if (BeginningEndSealing.Checked)
            {
                g.DrawLine(brLine, 65, 15, 65, 190);
                g.DrawLine(brLine, end + 5, 15, end + 5, 190);
                for (int i = 15; i < 190; i += 24)
                {
                    g.DrawLine(brLineLight, end + 5, i, 720, i + 20);
                }
                for (int i = 0; i < 175; i += 24)
                {
                    g.DrawLine(brLineLight, 50, i, 65, i + 20);
                }
            }
        }

        private void BeginningSealing_CheckedChanged(object sender, EventArgs e)
        {
            arrSealing.Clear();
            arrSealing.Add(1);
            arrSealing.Add(0);
            KernelPainting();

        }

        private void EndSealing_CheckedChanged(object sender, EventArgs e)
        {
            arrSealing.Clear();
            arrSealing.Add(0);
            arrSealing.Add(1);
            KernelPainting();
        }

        private void BeginningEndSealing_CheckedChanged(object sender, EventArgs e)
        {
            arrSealing.Clear();
            arrSealing.Add(1);
            arrSealing.Add(1);
            KernelPainting();
        }

        private void Sections_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double newdouble;
            int newInteger;
            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || double.Parse(e.FormattedValue.ToString()) <= 0 || string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    Sections.Rows[e.RowIndex].ErrorText = "Значением " + TaskParameters.Columns[TaskParameters.CurrentCell.ColumnIndex].HeaderText + " должно быть целое неотрицательное число";
                    e.Cancel = true;
                }
            }
            else if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                if (!double.TryParse(e.FormattedValue.ToString(), out newdouble) || double.Parse(e.FormattedValue.ToString()) <= 0 || string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    TaskParameters.Rows[e.RowIndex].ErrorText = "Значением параметра " + TaskParameters.Columns[TaskParameters.CurrentCell.ColumnIndex].HeaderText[0] + " должно быть положительное число. Допустима экспоненциальная запись.";
                    e.Cancel = true;
                }
            }
            else
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    Sections.Rows[e.RowIndex].ErrorText = "Значением силы " + TaskParameters.Columns[TaskParameters.CurrentCell.ColumnIndex].HeaderText + " должно быть целое число";
                    e.Cancel = true;
                }
            }
        }

        private void Sections_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Sections.Rows[e.RowIndex].ErrorText = String.Empty;
            KernelPainting();
        }

        private void EndF_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EndF.Rows[e.RowIndex].ErrorText = String.Empty;
            KernelPainting();
        }

        private void EndF_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int newInteger;
            if (!int.TryParse(e.FormattedValue.ToString(), out newInteger) || string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                EndF.Rows[e.RowIndex].ErrorText = "Значением силы F должно быть целое число";
                e.Cancel = true;
            }
        }

        private void TaskParameters_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TaskParameters.Rows[e.RowIndex].ErrorText = String.Empty;
            arrParameters.Clear();
            for (int i = 0; i < 4; i++)
            {
                arrParameters.Add(double.Parse(TaskParameters.Rows[0].Cells[i].Value.ToString()));
            }
            KernelPainting();
        }

        private void TaskParameters_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double newdouble;
            if (!double.TryParse(e.FormattedValue.ToString(), out newdouble) || double.Parse(e.FormattedValue.ToString()) <= 0 || string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                TaskParameters.Rows[e.RowIndex].ErrorText = "Значением параметра " + TaskParameters.Columns[TaskParameters.CurrentCell.ColumnIndex].HeaderText[0] + " должно быть положительное число. Допустима экспоненциальная запись.";
                e.Cancel = true;
            }
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path;
                OpenFileDialog open = new OpenFileDialog
                {
                    Title = ("Открыть..."),
                    AddExtension = true,
                    DefaultExt = "SC",
                    Filter = "SC Text Document (*.SC) | *.SC",
                };
                if (open.ShowDialog() == DialogResult.OK)
                {
                    double[] input = { 2e11F, 1, 1, 1, 1, 1 };
                    arrL.Clear();
                    arrSealing.Clear();
                    arrA.Clear();
                    arrLoadsQ.Clear();
                    arrLoadsF.Clear();
                    arrParameters.Clear();
                    arrParameters.AddRange(input);
                    int sections = 0;
                    string parameters = "";
                    string[] parameters_arr;
                    path = open.FileName;
                    IEnumerable<string> result = File.ReadLines(path).Skip(4).Take(1);
                    foreach (string str in result)
                    {
                        sections = int.Parse(str);
                    }
                    result = File.ReadLines(path).Skip(6).Take(sections);
                    foreach (string str in result)
                    {
                        parameters = str;
                        parameters_arr = parameters.Split();
                        arrL.Add(int.Parse(parameters_arr[1]));
                        arrA.Add(int.Parse(parameters_arr[2]));
                        arrLoadsQ.Add(int.Parse(parameters_arr[3]));
                        arrE.Add(double.Parse(parameters_arr[4]));
                        arrS.Add(double.Parse(parameters_arr[5]));
                    }
                    result = File.ReadLines(path).Skip(9 + sections).Take(2);
                    foreach (string str in result)
                    {
                        arrSealing.Add(int.Parse(str));
                    }
                    result = File.ReadLines(path).Skip(14 + sections).Take(sections + 1);
                    foreach (string str in result)
                    {
                        arrLoadsF.Add(int.Parse(str));
                    }
                    result = File.ReadLines(path).Skip(18 + 2 * sections).Take(sections);
                    foreach (string str in result)
                    {
                        parameters = str;
                    }
                    parameters_arr = parameters.Split();
                    for (int i = 1; i <= 4; i++)
                    {
                        arrParameters[i - 1] = double.Parse(parameters_arr[i]);
                    }
                    Sections.Rows.Clear();
                    EndF.Rows.Clear();
                    TaskParameters.Rows.Clear();
                    for (int i = 0; i < sections; i++)
                    {
                        Sections.Rows.Add(i + 1, arrL[i], arrA[i], arrLoadsF[i], arrLoadsQ[i], arrE[i], arrS[i]);
                    }
                    EndF.Rows.Add((arrLoadsF[arrLoadsF.Count - 1]).ToString());
                    TaskParameters.Rows.Add(arrParameters[0], arrParameters[1], arrParameters[2], arrParameters[3], arrParameters[4], arrParameters[5]);
                    RemoveSection.Enabled = true;
                    BorderCondition.Enabled = true;
                    if (arrSealing[0] == 1 && arrSealing[1] == 0)
                        BeginningSealing.Checked = true;
                    else if (arrSealing[1] == 0 && arrSealing[1] == 1)
                        EndSealing.Checked = true;
                    else
                        BeginningEndSealing.Checked = true;
                    ExportToolStripMenuItem.Enabled = true;
                    CalculationToolStripMenuItem.Enabled = true;
                    KernelPainting();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки файла проекта");
            }
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path;
            SaveFileDialog save = new SaveFileDialog
            {
                Title = ("Сохранить как..."),
                AddExtension = true,
                DefaultExt = "SC",
                Filter = "SC Text Document (*.SC) | *.SC",
                OverwritePrompt = true
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                path = save.FileName;
                StreamWriter sw = File.CreateText(path);
                sw.WriteLine("\t" + path);
                sw.WriteLine("**************************************************");
                sw.WriteLine("\tNR\tNC\tQS\tE\tS");
                sw.WriteLine("**************************************************");
                sw.WriteLine("\t" + arrL.Count);
                sw.WriteLine("**************************************************");
                for (int i = 0; i < arrL.Count; i++)
                    sw.WriteLine("\t" + arrL[i] + "\t" + arrA[i] + "\t" + arrLoadsQ[i] + "\t" + arrE[i] + "\t" + arrS[i]);
                sw.WriteLine("**************************************************");
                sw.WriteLine("\tNB");
                sw.WriteLine("**************************************************");
                sw.WriteLine("\t" + arrSealing[0].ToString());
                sw.WriteLine("\t" + arrSealing[1].ToString());
                sw.WriteLine("**************************************************");
                sw.WriteLine("\tQR");
                sw.WriteLine("**************************************************");
                for (int i = 0; i < arrLoadsF.Count; i++)
                    sw.WriteLine("\t" + arrLoadsF[i]);
                sw.WriteLine("**************************************************");
                sw.WriteLine("\tA\tL\tF\tq");
                sw.WriteLine("**************************************************");
                sw.WriteLine("\t" + arrParameters[0] + "\t" + arrParameters[1] + "\t" + arrParameters[2] + "\t" + arrParameters[3]);
                sw.Close();
            }
        }

        private void CalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delta.Clear();
            int n = arrLoadsF.Count;
            double[,] A1 = new double[n, n];
            double[] X = new double[n];
            double[] B = new double[n];
            int beginS, endS;
            beginS = arrSealing[0] == 0 ? 1 : 0;
            endS = arrSealing[1] == 0 ? 1 : 0;
            for (int i = 0; i < n; i++)
                X[i] = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && i == 0)
                    {
                        A1[i, j] = arrE[i] * arrA[i] * arrParameters[0] / (arrL[i] * arrParameters[1]);
                    }
                    else if (i == j && i == n - 1)
                    {
                        A1[i, j] = arrE[i - 1] * arrA[i - 1] * arrParameters[0] / (arrL[i - 1] * arrParameters[1]);
                    }
                    else if (i == j)
                    {
                        A1[i, j] = arrE[i - 1] * arrA[i - 1] * arrParameters[0] / (arrL[i - 1] * arrParameters[1]) + arrE[1] * arrA[i] * arrParameters[0] / (arrL[i] * arrParameters[1]);
                    }
                    else if (i - j == 1)
                    {
                        A1[j, i] = A1[i, j] = -arrE[i - 1] * arrA[i - 1] * arrParameters[0] / (arrL[i - 1] * arrParameters[1]);
                    }
                    else A1[i, j] = 0;
                }
            }

            if (beginS == 0)
                for (int i = 0; i < n; i++)
                {
                    A1[0, i] = i == 0 ? 1 : 0;
                    if (i == 0)
                        continue;
                    A1[i, 0] = 0;
                }
            if (endS == 0)
                for (int i = 0; i < n; i++)
                {
                    A1[n - 1, i] = i == n - 1 ? 1 : 0;
                    if (i == n - 1)
                        continue;
                    A1[i, n - 1] = 0;
                }

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    B[i] = (arrLoadsQ[i] * arrParameters[3] * arrL[i] * arrParameters[1] / 2 + arrLoadsF[i] * arrParameters[2]) * beginS;
                }
                else if (i == n - 1)
                {
                    B[i] = (arrLoadsQ[i - 1] * arrParameters[3] * arrL[i - 1] * arrParameters[1] / 2 + arrLoadsF[i] * arrParameters[2]) * endS;
                }
                else
                    B[i] = (arrLoadsQ[i - 1] * arrParameters[3] * arrL[i - 1] * arrParameters[1] / 2) + (arrLoadsQ[i] * arrParameters[3] * arrL[i] * arrParameters[1] / 2) + arrLoadsF[i] * arrParameters[2];
            }

            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    for (int j = k + 1; j < n; j++)
                    {
                        A1[i, j] = A1[i, j] - A1[k, j] * (A1[i, k] / A1[k, k]);
                    }
                    B[i] = B[i] - B[k] * A1[i, k] / A1[k, k];
                }
            }

            for (int k = n - 1; k >= 0; k--)
            {
                double s = 0;
                for (int j = k + 1; j < n; j++)
                    s += A1[k, j] * X[j];
                X[k] = (B[k] - s) / A1[k, k];
            }

            foreach (var i in X)
                delta.Add(i);

            MessageBox.Show("Расчеты выполнены. Для просмотра результатов нажмите кнопку \"Результаты\".");
            ResultsToolStripMenuItem.Enabled = true;
        }

        private void ChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Charts cf = new Charts(arrL, arrA, arrParameters, arrE, arrS, arrLoadsQ, delta)
            {
                form = this,
                Owner = this
            };
            if (WindowState == FormWindowState.Maximized)
                cf.WindowState = FormWindowState.Maximized;
            else
                cf.WindowState = FormWindowState.Normal;
            cf.Show();
            Hide();
        }

        private void TablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tables tf = new Tables(arrL, arrA, arrParameters, arrE, arrS, arrLoadsQ, delta);
            tf.form = this;
            tf.Owner = this;
            if (WindowState == FormWindowState.Maximized)
                tf.WindowState = FormWindowState.Maximized;
            else
                tf.WindowState = FormWindowState.Normal;
            tf.Show();
            Hide();
        }

        private void PlotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diagram df = new Diagram(arrL, arrA, arrParameters, arrE, arrLoadsQ, delta)
            {
                form = this,
                Owner = this
            };
            if (WindowState == FormWindowState.Maximized)
                df.WindowState = FormWindowState.Maximized;
            else
                df.WindowState = FormWindowState.Normal;
            df.Show();
            Hide();
        }
    }
}