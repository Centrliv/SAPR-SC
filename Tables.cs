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
    public partial class Tables : Form
    {        
        public Tables(List<double> L, List<double> A, List<double> Parameters, List<double> E, List<double> S, List<int> Q, List<double> del)
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
        private void Tables_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < arrL.Count; i++)
            {
                SelectedSection.Items.Add(i + 1);
            }
            for (int i = 0; i < delta.Count; i++)
            {
                Deltas.Rows.Add(i+1, delta[i]);
            }
            SelectedSection.SelectedIndex = 0;
        }

        private void SelectedSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ss = SelectedSection.SelectedIndex;
            InputL.Clear();
            ReultN.Clear();
            Resultσ.Clear();
            ResultU.Clear();
            double y1, y2, y3;                   
            StressStainStateComponents.Rows.Clear();
            double A = arrA[ss] * arrParameters[0],
                   L = arrL[ss] * arrParameters[1],
                   q = arrLoadsQ[ss] * arrParameters[3],
                   E = arrE[ss],
                   U0 = delta[ss],
                   UL = delta[ss + 1],
                   step = L * 0.2;
            int count = 0;
            for (double i = 0; i <= L; i += step)
            {
                y1 = (E * A / L) * (UL - U0) + (q * L / 2) * (1 - 2 * i / L);
                y2 = y1 / A;
                y3 = U0 + i / L * (UL - U0) + (q * L * L / (2 * E * A)) * (i / L) * (1 - i / L);
                StressStainStateComponents.Rows.Add(i, y1, y2, y3, arrS[ss]);
                if (Math.Abs(y2) >= arrS[SelectedSection.SelectedIndex])
                {
                    for (int j = 1; j<=3; j++)
                        StressStainStateComponents.Rows[count].Cells[j].Style.ForeColor = Color.Red;
                }
                count++;
            }
        }

        private void Receive_Click(object sender, EventArgs e)
        {
            int ss = SelectedSection.SelectedIndex;
            double y1, y2, y3,
                    A = arrA[ss] * arrParameters[0],
                    L = arrL[ss] * arrParameters[1],
                    q = arrLoadsQ[ss] * arrParameters[3],
                    E = arrE[ss],
                    U0 = delta[ss],
                    UL = delta[ss + 1];
            double number, lenght;
            bool result = double.TryParse(InputL.Text.ToString(), out number);
            if (result == true)
            {
                error.Clear();
                lenght = double.Parse(InputL.Text.ToString());
                if (lenght < 0 || lenght > L)
                    error.SetError(InputL, "Введено некорректное значение длины");
                else
                {
                    y1 = (E * A / L) * (UL - U0) + (q * L / 2) * (1 - 2 * lenght / L);
                    y2 = y1 / A;
                    y3 = U0 + lenght / L * (UL - U0) + (q * L * L / (2 * E * A)) * (lenght / L) * (1 - lenght / L);                      
                    ReultN.Text = y1.ToString();
                    Resultσ.Text = y2.ToString();
                    ResultU.Text = y3.ToString();
                    if (Math.Abs(y2) >= arrS[SelectedSection.SelectedIndex])
                    {
                        ReultN.ForeColor = Color.Red;
                        Resultσ.ForeColor = Color.Red;
                        ResultU.ForeColor = Color.Red;
                    }
                    else
                    {
                        ReultN.ForeColor = Color.Black;
                        Resultσ.ForeColor = Color.Black;
                        ResultU.ForeColor = Color.Black;
                    }
                }
            }
            else
                error.SetError(InputL, "Введено некорректное значение длины");
        }

        private void Tables_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
            Hide();
        }
    }
}
