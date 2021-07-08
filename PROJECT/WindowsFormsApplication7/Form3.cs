using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace WindowsFormsApplication7
{
    public partial class Form3 : Form
    {
        CrystalReport6 report1;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            report1 = new CrystalReport6();
            crystalReportViewer1.ReportSource = report1;


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
