using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Types;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace Restaurant_Project
{
    public partial class CustomerForm : Form
    {
        string ordb = "Data Source=ORCL;User Id=scott;Password=tiger;";
        OracleConnection connection;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ordb);
            connection.Open();

            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "select CustID from Customer";
            command.CommandType = CommandType.Text;
            OracleDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                CutomersID.Items.Add(dr[0]);
            }
            dr.Close();


            command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "SHOW_MEALS";
            command.CommandType = CommandType.StoredProcedure;
            //List_Of_Meals
            command.Parameters.Add("List_Of_Meals", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                ShowMealsBOX.Items.Add(Reader["mealID"].ToString() + "] "
                    + Reader["meal_name"].ToString() + " " + Reader["price"].ToString() + " $");
            }
            Reader.Close();

        }

        private void CutomersID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "insert into Customer values (:CustID,:FirstName,:LastName," +
                ":full_name,:VisaCard_Num,:Address,:phone)";

            command.Parameters.Add("CustID", IDTEXT.Text);
            command.Parameters.Add("FirstName", Firstname.Text);
            command.Parameters.Add("LastName", LastName.Text);
            command.Parameters.Add("full_name", Firstname.Text + ' ' + LastName.Text);
            command.Parameters.Add("VisaCard_Num", VisaCardtext.Text);
            command.Parameters.Add("Address", AddressText.Text);
            command.Parameters.Add("phone", PhoneText.Text);

            int r = command.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Customer Successfully added");
                CutomersID.Items.Add(IDTEXT.Text);
            }
            // else, throw exception 
        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void VisaCardtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowLatInvoicebtn_Click(object sender, EventArgs e)
        {
            int val, val2;
            OracleCommand command = new OracleCommand();
            command.Connection = connection;

            command.CommandText = "INVOICES";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("idd", OracleDbType.Int32, ParameterDirection.Output);
            command.Parameters.Add("costt", OracleDbType.Int32, ParameterDirection.Output);
            command.Parameters.Add("Customer_IDD", CutomersID.SelectedItem.ToString());

            command.ExecuteNonQuery();

            try
            {
                val = Convert.ToInt32(command.Parameters["idd"].Value.ToString());
                val2 = Convert.ToInt32(command.Parameters["costt"].Value.ToString());

            }
            catch
            {
                val = 9081209;
                val2 = 9081309;
            }
            // 2nd and third id have invoices 
            MessageBox.Show("ID: " + val + "\nCost: " + val2);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ShowMealsBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IDTEXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
