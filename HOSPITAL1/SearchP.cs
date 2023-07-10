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
    public partial class SearchP : Form
    {
        public SearchP()
        {
            InitializeComponent();
        }

        private void SearchP_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query2 = " SELECT Insurance FROM Insurance ";
            SqlCommand cmd2 = new SqlCommand(query2, sc);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string insurance = reader2["Insurance"].ToString();
                comboBox2.Items.Add(insurance);
            }
            reader2.Close();

            string query1 = " SELECT Room FROM Room ";
            SqlCommand cmd1 = new SqlCommand(query1, sc);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string room = reader1["Room"].ToString();
                comboBox1.Items.Add(room);
            }
            reader1.Close();

            string query3 = " SELECT Bed FROM Bed ";
            SqlCommand cmd3 = new SqlCommand(query3, sc);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                string bed = reader3["Bed"].ToString();
                comboBox3.Items.Add(bed);
            }
            reader1.Close();
            sc.Close();

            // TODO: This line of code loads data into the 'database1DataSet1.Admission' table. You can move, or remove it, as needed.
            this.admissionTableAdapter.Fill(this.database1DataSet1.Admission);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madmissionid = textBox1.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT Patient, Doctor, Date, Time, Insurance, Room, Bed, Diagnosis, Describtion FROM Admission WHERE AdmissionID = '" + madmissionid + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = reader["Patient"].ToString();
                textBox3.Text = reader["Doctor"].ToString();
                textBox4.Text = reader["Date"].ToString();
                textBox5.Text = reader["Time"].ToString();
                comboBox2.Text = reader["Insurance"].ToString();
                comboBox1.Text = reader["Room"].ToString();
                comboBox3.Text = reader["Bed"].ToString();
                textBox6.Text = reader["Diagnosis"].ToString();
                textBox7.Text = reader["Describtion"].ToString();
            }
            reader.Close();
            sc.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
            comboBox1.Text = comboBox2.Text = comboBox3.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management m = new Management();
            m.Show();
        }
    }
}
