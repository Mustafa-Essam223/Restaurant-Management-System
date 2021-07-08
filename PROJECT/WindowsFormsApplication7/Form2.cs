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
    public partial class Form2 : Form
    {
        CrystalReport3 report;
        public Form2()
        {
            InitializeComponent();
          

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            report = new CrystalReport3();
            foreach (ParameterDiscreteValue v in report.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            report.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = report;
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
