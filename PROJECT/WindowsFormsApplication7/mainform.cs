using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using WindowsFormsApplication7;

namespace Restaurant_Project
{
    public partial class MainForm : Form
    {
        string ordb = "Data Source=ORCL;User Id=hr;Password=hr;";
        OracleConnection connection;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ordb);
            connection.Open();
        }

        private void CustomerFormButton_Click(object sender, EventArgs e)
        {
            CustomerForm Left_button = new CustomerForm();
            Left_button.Show();
        }

        private void ReservationsFormButton_Click(object sender, EventArgs e)
        {
            Form1 reservations = new Form1();
            reservations.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();

        }
    }
}
