using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPR_SC
{
    public partial class Charts : Form
    {
        public Charts(List<double> L, List<double> A, List<double> Parameters, List<double> E, List<double> S, List<int> Q, List<double> del)
        {
            InitializeComponent();
            arrL = L;
            arrA = A;
            arrParameters = Parameters;
            arrE = E;
            arrS = S;
            arrLoadsQ = Q;
            delta = del;
        }

        public Main form;

        List<double> arrL = new List<double>();
        List<double> arrA = new List<double>();
        List<double> arrParameters = new List<double>();
        List<double> arrE = new List<double>();
        List<double> arrS = new List<double>();
        List<double> delta = new List<double>();
        List<int> arrLoadsQ = new List<int>();

        private void Results_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < arrL.Count; i++)
            {
                SelectedSection.Items.Add(i + 1);
            }
            SelectedSection.SelectedIndex = 0;
        }

        private void Charts_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            Hide();
        }

        private void SelectedSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartN.Series[0].Points.Clear();
            ChartU.Series[0].Points.Clear();
            Chartσ.Series[0].Points.Clear();

            int counter = SelectedSection.SelectedIndex;
            decimal y1, y2, y3,
                    A = (decimal)(arrA[counter] * arrParameters[0]),
                    L = (decimal)(arrL[counter] * arrParameters[1]),
                    q = (decimal)(arrLoadsQ[counter] * arrParameters[3]),
                    E = (decimal)arrE[counter],
                    U0 = (decimal)delta[counter],
                    UL = (decimal)delta[counter + 1],
                    step = L / 100;

            ChartN.ChartAreas[0].AxisX.Minimum = ChartU.ChartAreas[0].AxisX.Minimum = Chartσ.ChartAreas[0].AxisX.Minimum = 0;
            ChartN.ChartAreas[0].AxisX.Maximum = ChartU.ChartAreas[0].AxisX.Maximum = Chartσ.ChartAreas[0].AxisX.Maximum =(double)L;
            ChartN.ChartAreas[0].AxisX.Interval = ChartU.ChartAreas[0].AxisX.Interval = Chartσ.ChartAreas[0].AxisX.Interval = (double)L * 0.05;

            for (decimal i = 0; i <= L; i += step)
            {
                y1 = (E * A / L) * (UL - U0) + (q * L / 2) * (1 - 2 * i / L);
                ChartN.Series[0].Points.AddXY(i, y1);                
                y2 = y1 / A;
                Chartσ.Series[0].Points.AddXY(i, y2);
                y3 = U0 + i / L * (UL - U0) + (q * L * L / (2 * E * A)) * (i / L) * (1 - i / L);
                ChartU.Series[0].Points.AddXY(i, y3);
            }
        }
    }
}
