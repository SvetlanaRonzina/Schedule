using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            string text = rtbWorks.Text;
            int workersCount = int.Parse(tbWorkersCount.Text);
            int pointsCount = int.Parse(tbPointsCount.Text);
            char?[,] result = Solver.Solve(text, workersCount, pointsCount);
        }
    }
}
