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
namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet dset;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=orcl; User Id=hr;password=hr;";
            string command = "select * from reservations where Reservation_ID = :x";
            adapter = new OracleDataAdapter(command, connection);
            Console.WriteLine(adapter.ToString());
            adapter.SelectCommand.Parameters.Add("x", textBox1.Text);
            dset = new DataSet();
            adapter.Fill(dset);

            dataGridView1.DataSource = dset.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            builder = new OracleCommandBuilder(adapter);
            adapter.Update(dset.Tables[0]);
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
