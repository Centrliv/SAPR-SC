using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;

namespace SAPR_SC
{
    public partial class Diagram : Form
    {
        //private Bitmap bmp = null;

        //private const int WorldWidth = 670;
        //private const int WorldHeight = 1500;

        public Diagram(List<double> L, List<double> A, List<double> Parameters, List<double> E, List<int> Q, List<double> del)
        {
            InitializeComponent();
            arrL = L;
            arrA = A;
            arrParameters = Parameters;
            arrE = E;
            arrLoadsQ = Q;
            delta = del;
        }       

        List<double> arrL = new List<double>();
        List<double> arrA = new List<double>();
        List<double> arrParameters = new List<double>();
        List<double> arrE = new List<double>();
        List<double> delta = new List<double>();
        List<int> arrLoadsQ = new List<int>();

        public Main form;

        private void Diagram_Shown(object sender, EventArgs e)
        {
            double lenght = 0, maxLenght = 0;

            bool constN = true;

            for (int i = 1; i < arrE.Count; i++)
            {
                if (arrE[0] != arrE[i])
                {
                    constN = false;
                    break;
                }
            }

            for (int i = 0; i < arrL.Count; i++)
            {
                maxLenght+= (arrL[i] * arrParameters[1]);
            }

            for (int j = 0; j < arrL.Count; j++)
            {
                double y1, y2, y3,
                        A = (arrA[j] * arrParameters[0]),
                        L = (arrL[j] * arrParameters[1]),
                        q = (arrLoadsQ[j] * arrParameters[3]),
                        E = arrE[j],
                        U0 = delta[j],
                        UL = delta[j + 1],
                        step = L / 1000;
                foreach (Chart ch in Controls.OfType<Chart>())
                {
                    ch.Series.Add(j.ToString());
                    ch.ChartAreas[0].AxisX.Minimum = 0;
                    ch.ChartAreas[0].AxisX.Maximum = (double)maxLenght;
                    ch.ChartAreas[0].AxisX.Interval = (double)(L/L);
                    ch.ChartAreas[0].BackColor = Color.Transparent;
                    ch.Series[j].ChartType = SeriesChartType.Area;
                    ch.Series[j].BackHatchStyle = ChartHatchStyle.DarkVertical;
                    ch.Series[j].BorderColor = Color.Black;
                    ch.Series[j].Color = Color.Black;
                    ch.Series[j].ShadowColor = Color.Transparent;
                }

                for (double i = 0; i <= L; i += step)
                {
                    y1 = (E * A / L) * (UL - U0) + (q * L / 2) * (1 - 2 * i / L);
                    ChartN.Series[j].Points.AddXY(lenght, y1);
                    y2 = y1 / A;
                    Chartσ.Series[j].Points.AddXY(lenght, y2);
                    y3 = U0 + i / L * (UL - U0) + (q * L * L / (2 * E * A)) * (i / L) * (1 - i / L);
                    ChartU.Series[j].Points.AddXY(lenght, y3);
                    lenght += step;
                }
            }
            lenght = 0;
            for (int j = 0; j < arrL.Count; j++)
            {
                double y1, y2, y3,
                        A = (arrA[j] * arrParameters[0]),
                        L = (arrL[j] * arrParameters[1]),
                        q = (arrLoadsQ[j] * arrParameters[3]),
                        E = arrE[j],
                        U0 = delta[j],
                        UL = delta[j + 1];

                string chartNum = (j + 1 + "s").ToString();
                foreach (Chart ch in Controls.OfType<Chart>())
                {
                    ch.Series.Add(chartNum);
                    ch.Series[chartNum].IsValueShownAsLabel = true;
                    ch.Series[chartNum].LabelFormat = "#.###e+00";
                    ch.Series[chartNum].LabelBackColor = Color.Blue;
                    ch.Series[chartNum].LabelForeColor = Color.White;
                    ch.Series[chartNum].ChartType = SeriesChartType.Area;
                    ch.Series[chartNum].BackHatchStyle = ChartHatchStyle.DarkVertical;
                    ch.Series[chartNum].BorderColor = Color.Transparent;
                    ch.Series[chartNum].Color = Color.Transparent;
                    ch.Series[chartNum].ShadowColor = Color.Transparent;
                }

                for (double i = 0; i <= L; i += L)
                {
                    if (i < L)
                    {
                        y1 = (E * A / L) * (UL - U0) + (q * L / 2) * (1 - 2 * i / L);
                        y2 = y1 / A;
                        y3 = U0 + i / L * (UL - U0) + (q * L * L / (2 * E * A)) * (i / L) * (1 - i / L);
                        ChartN.Series[chartNum].Points.AddXY(lenght, y1);
                        Chartσ.Series[chartNum].Points.AddXY(lenght, y2);
                        ChartU.Series[chartNum].Points.AddXY(lenght, y3);
                    }
                    else
                    {
                        y1 = (E * A / L) * (UL - U0) + (q * L / 2) * (1 - 2 * i / L);
                        y2 = y1 / A;
                        ChartN.Series[chartNum].Points.AddXY(lenght, y1);
                        Chartσ.Series[chartNum].Points.AddXY(lenght, y2);
                        if (j == arrL.Count - 1)
                        {
                            y3 = U0 + i / L * (UL - U0) + (q * L * L / (2 * E * A)) * (i / L) * (1 - i / L);
                            ChartU.Series[chartNum].Points.AddXY(lenght, y3);
                        }
                        break;
                    }
                    lenght += L;
                }
            }
            foreach (Chart ch in Controls.OfType<Chart>())
            {
                ch.ChartAreas[0].AxisX.Crossing = 0;
                ch.ChartAreas[0].AxisY.Crossing = 0;
            }
        }

        private void Diagram_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            Hide();
        }

        //public void fail()
        //{
        //    bmp = new Bitmap(1 * (WorldWidth), 1 * (WorldHeight));
        //    using (Graphics g = Graphics.FromImage(bmp))
        //    {
        //        g.Clear(Color.White);
        //        g.SmoothingMode = SmoothingMode.AntiAlias;
        //        g.ScaleTransform(1, 1);
        //        g.TranslateTransform(20, 200);
        //        g.SmoothingMode = SmoothingMode.AntiAlias;

        //        int axisX = 0, count = 0;
        //        for (int i = 0; i < arrL.Count; i++)
        //            axisX += sectionLength[i];
        //        g.DrawLine(brLineLight, 0, 0, axisX, 0);
        //        g.DrawLine(brLineLight, 0, 400, axisX, 400);
        //        Plots.Image = bmp;
        //        Point[] pointsN = new Point[axisX];
        //        Point[] pointsS = new Point[axisX];
        //        Point[] pointsU = new Point[axisX];
        //        for (int i = 0; i < arrL.Count; i++)
        //        {
        //            decimal y1, y2, y3,
        //                A = (decimal)(arrA[i] * arrParameters[0]),
        //                L = (decimal)(arrL[i] * arrParameters[1]),
        //                q = (decimal)(arrLoadsQ[i] * arrParameters[3]),
        //                E = (decimal)arrE[i],
        //                U0 = (decimal)delta[i],
        //                UL = (decimal)delta[i + 1];
        //            for (int j = 0; j < sectionLength[i]; j++)
        //            {
        //                y1 = (E * A / L) * (UL - U0) + (q * L / 2) * (1 - 2 * j / L);
        //                y2 = y1 / (decimal)arrParameters[0];
        //                y3 = U0 + j / L * (UL - U0) + (q * L * L / (2 * E * A)) * (j / L) * (1 - j / L);
        //                pointsN[count] = new Point(count, -(int)y1 / 5 - 50);
        //                pointsS[count] = new Point(count, -(int)y2 / 5 - 50);
        //                pointsU[count] = new Point(count, -(int)y3 / 5 - 50);
        //                //MessageBox.Show(y3.ToString() + " " + pointsU[count].ToString());
        //                count++;
        //            }
        //        }
        //        g.DrawLines(brLine, pointsN);
        //        g.TranslateTransform(0, 400);
        //        g.DrawLines(brLine, pointsS);
        //        g.TranslateTransform(0, 400);
        //        g.DrawLines(brLine, pointsU);
        //        Plots.Image = bmp;
        //    }
        //}

        //private void KernelPainting()
        //{
        //    int widthRemains, square, maxSquare, bufWidth, width = 0;
        //    square = 120 / maxSquare;
        //    widthRemains = width;
        //    bufWidth = width = 630 / width;
        //    widthRemains = 630 - widthRemains * width;

        //    g.Clear(Color.Transparent);
        //    int count = 0;
        //    int sL = sectionLength[count];
        //    StringFormat sf = new StringFormat
        //    {
        //        Alignment = StringAlignment.Center,
        //        LineAlignment = StringAlignment.Far
        //    };
        //    for (int i = 70; i < 700 - widthRemains; i += sL)
        //    {
        //        Rectangle Rect = new Rectangle(i, 100, sectionLength[count], 160);
        //        g.DrawRectangle(brLineLight, Rect);
        //        g.DrawString(arrL[count].ToString() + "L", new Font("Times", 10), Brushes.Black, Rect, sf);
        //        g.FillRectangle(brFill, i, 100 - sectionSquare[count] / 2, sectionLength[count], sectionSquare[count]);
        //        g.DrawRectangle(brFrame, i, 100 - sectionSquare[count] / 2, sectionLength[count], sectionSquare[count]);
        //        sL = sectionLength[count];
        //        sectionCordinates.Add(i + sL);
        //        count++;
        //    }
        //    SealingInstallation(700 - widthRemains);
        //    LoadsQPainting(sf);
        //    LoadsFPainting();
        //    Kernel.Image = bmp;
        //}
        //private void LoadsQPainting(StringFormat infoString)
        //{
        //    for (int i = 0; i < arrLoadsQ.Count; i++)
        //    {
        //        Rectangle Rect = new Rectangle(sectionCordinates[i], 80, sectionLength[i], 80);
        //        infoString.LineAlignment = StringAlignment.Near;
        //        if (arrLoadsQ[i] > 0)
        //        {
        //            for (int j = sectionCordinates[i] + 15; j <= sectionCordinates[i + 1]; j += 15)
        //            {
        //                brQ.EndCap = LineCap.Flat;
        //                brQ.StartCap = LineCap.ArrowAnchor;
        //                g.DrawLine(brQ, j, 100, j - 15, 100);
        //                g.DrawString(arrLoadsQ[i].ToString() + "q", new Font("Times", 10), Brushes.Red, Rect, infoString);
        //            }

        //        }
        //        if (arrLoadsQ[i] < 0)
        //        {
        //            for (int j = sectionCordinates[i] + 15; j <= sectionCordinates[i + 1]; j += 15)
        //            {
        //                brQ.StartCap = LineCap.Flat;
        //                brQ.EndCap = LineCap.ArrowAnchor;
        //                g.DrawLine(brQ, j, 100, j - 15, 100);
        //                g.DrawString(arrLoadsQ[i].ToString() + "q", new Font("Times", 10), Brushes.Red, Rect, infoString);
        //            }
        //        }
        //    }
        //}

        //private void LoadsFPainting()
        //{
        //    for (int i = 0; i < sectionCordinates.Count; i++)
        //    {
        //        if (arrLoadsF[i] > 0)
        //        {
        //            brF.StartCap = LineCap.Flat;
        //            brF.EndCap = LineCap.ArrowAnchor;
        //            g.DrawLine(brF, sectionCordinates[i], 100, sectionCordinates[i] + 50, 100);
        //            g.DrawString(arrLoadsF[i].ToString() + "F", new Font("Times", 10, FontStyle.Bold), Brushes.Blue, sectionCordinates[i] + 10, 110);
        //        }
        //        if (arrLoadsF[i] < 0)
        //        {
        //            brF.StartCap = LineCap.ArrowAnchor;
        //            brF.EndCap = LineCap.Flat;
        //            g.DrawLine(brF, sectionCordinates[i] - 50, 100, sectionCordinates[i], 100);
        //            g.DrawString(arrLoadsF[i].ToString() + "F", new Font("Times", 10, FontStyle.Bold), Brushes.Blue, sectionCordinates[i] - 30, 110);
        //        }
        //    }
        //}

        //private void SealingInstallation(int end)
        //{
        //    if (BeginningSealing.Checked)
        //    {
        //        g.DrawLine(brLine, 65, 15, 65, 190);
        //        for (int i = 0; i < 175; i += 24)
        //        {
        //            g.DrawLine(brLineLight, 50, i, 65, i + 20);
        //        }
        //    }
        //    if (EndSealing.Checked)
        //    {
        //        g.DrawLine(brLine, end + 5, 15, end + 5, 190);
        //        for (int i = 15; i < 190; i += 24)
        //        {
        //            g.DrawLine(brLineLight, end + 5, i, 720, i + 20);
        //        }
        //    }
        //    if (BeginningEndSealing.Checked)
        //    {
        //        g.DrawLine(brLine, 65, 15, 65, 190);
        //        g.DrawLine(brLine, end + 5, 15, end + 5, 190);
        //        for (int i = 15; i < 190; i += 24)
        //        {
        //            g.DrawLine(brLineLight, end + 5, i, 720, i + 20);
        //        }
        //        for (int i = 0; i < 175; i += 24)
        //        {
        //            g.DrawLine(brLineLight, 50, i, 65, i + 20);
        //        }
        //    }
        //}

    }
}
