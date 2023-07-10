using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL1
{
    public partial class SearchD : Form
    {
        public SearchD()
        {
            InitializeComponent();
        }

        private void SearchD_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT Degree FROM Degree ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string degree = reader["Degree"].ToString();
                comboBox1.Items.Add(degree);
            }
            reader.Close();

            string query2 = " SELECT DRoom FROM DRoom ";
            SqlCommand cmd2 = new SqlCommand(query2, sc);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string droom = reader2["DRoom"].ToString();
                comboBox2.Items.Add(droom);
            }
            reader2.Close();
            sc.Close();

            // TODO: This line of code loads data into the 'database1DataSet.Doctor1' table. You can move, or remove it, as needed.
            this.doctor1TableAdapter.Fill(this.database1DataSet.Doctor1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
            comboBox1.Text = null;
            comboBox2.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management m = new Management();
            m.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string mcnumber = textBox1.Text;

            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT Name, Lastname, NationalID, PhoneNumber, Degree, Specialty, Address, DRoom FROM Doctor1 WHERE MCNumber = '" + mcnumber + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = reader["Name"].ToString();
                textBox3.Text = reader["Lastname"].ToString();
                textBox4.Text = reader["NationalID"].ToString();
                textBox5.Text = reader["PhoneNumber"].ToString();
                comboBox1.Text = reader["Degree"].ToString();
                textBox6.Text = reader["Specialty"].ToString();
                textBox7.Text = reader["Address"].ToString();
                comboBox2.Text = reader["DRoom"].ToString();
            }
            sc.Close();
        }
    }
}
