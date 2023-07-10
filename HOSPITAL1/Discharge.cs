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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOSPITAL1
{
    public partial class Discharge : Form
    {
        public Discharge()
        {
            InitializeComponent();
        }

        private void Discharge_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madmissionid = textBox1.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT Patient, Doctor, Date, Time, Insurance, Room, Bed FROM Admission WHERE AdmissionID = '" + madmissionid + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox6.Text = reader["Patient"].ToString();
                textBox3.Text = reader["Doctor"].ToString();
                textBox5.Text = reader["Date"].ToString();
                textBox4.Text = reader["Time"].ToString();
                comboBox2.Text = reader["Insurance"].ToString();
                comboBox1.Text = reader["Room"].ToString();
                comboBox3.Text = reader["Bed"].ToString();
            }
            reader.Close();

            string admissionid = textBox1.Text;
            string query1 = " SELECT Paid FROM Money WHERE AdmissionID = '" + admissionid + "' ";
            SqlCommand cmd1 = new SqlCommand(query1, sc);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                textBox12.Text = reader1["Paid"].ToString();
            }
            reader1.Close();
            sc.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string madmissionid = textBox1.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT * FROM Discharge WHERE AdmissionID = '" + madmissionid + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox6.Text = reader["Patient"].ToString();
                textBox3.Text = reader["Doctor"].ToString();
                textBox5.Text = reader["Date"].ToString();
                textBox4.Text = reader["Time"].ToString();
                comboBox2.Text = reader["Insurance"].ToString();
                comboBox1.Text = reader["Room"].ToString();
                comboBox3.Text = reader["Bed"].ToString();
                textBox12.Text = reader["Paid"].ToString();
                textBox2.Text = reader["Diagnosis"].ToString();
                textBox7.Text = reader["Describtion"].ToString();
            }
            reader.Close();
            sc.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string madmissionid = textBox1.Text;
                string patient = textBox6.Text;
                string doctor = textBox3.Text;
                string date = textBox5.Text;
                string time = textBox4.Text;
                string insurance = comboBox2.Text;
                string room = comboBox1.Text;
                string bed = comboBox3.Text;
                string paid = textBox6.Text;
                string diagnosis = textBox2.Text;
                string describtion = textBox7.Text;


                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " INSERT INTO Discharge(AdmissionID,Patient,Doctor,Date,Time,Insurance,Room,Bed,Paid,Diagnosis,Describtion) VALUES ('" + madmissionid + "' , N'" + patient + "' , N'" + doctor + "' , '" + date + "' , '" + time + "' , N'" + insurance + "' , '" + room + "' , '" + bed + "' , '" + paid + "' , N'" + diagnosis + "' , N'" + describtion + "')";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("madmissionid", textBox1.Text);
                cmd.Parameters.AddWithValue("patient", textBox2.Text);
                cmd.Parameters.AddWithValue("doctor", textBox3.Text);
                cmd.Parameters.AddWithValue("date", textBox4.Text);
                cmd.Parameters.AddWithValue("time", textBox5.Text);
                cmd.Parameters.AddWithValue("insurance", comboBox2.Text);
                cmd.Parameters.AddWithValue("room", comboBox1.Text);
                cmd.Parameters.AddWithValue("bed", comboBox3.Text);
                cmd.Parameters.AddWithValue("paid", textBox12.Text);
                cmd.Parameters.AddWithValue("diagnosis", textBox2.Text);
                cmd.Parameters.AddWithValue("describtion", textBox7.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ذخیره شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox12.Text = "";
                comboBox1.Text = comboBox2.Text = comboBox3.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ذخیره نشدند");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string madmissionid = textBox1.Text;
                string patient = textBox6.Text;
                string doctor = textBox3.Text;
                string date = textBox5.Text;
                string time = textBox4.Text;
                string insurance = comboBox2.Text;
                string room = comboBox1.Text;
                string bed = comboBox3.Text;
                string paid = textBox6.Text;
                string diagnosis = textBox2.Text;
                string describtion = textBox7.Text;

                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " UPDATE Discharge SET AdmissionID = '" + madmissionid + "' , Patient = N'" + patient + "' , Doctor = N'" + doctor + "' , Date = '" + date + "' , Time = '" + time + "' , Insurance = N'" + insurance + "' , Room = '" + room + "' , Bed = '" + bed + "' , Paid = '" + paid + "' , Diagnosis = N'" + diagnosis + "' , Describtion = N'" + describtion + "' WHERE AdmissionID = '" + madmissionid + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("madmissionid", textBox1.Text);
                cmd.Parameters.AddWithValue("patient", textBox2.Text);
                cmd.Parameters.AddWithValue("doctor", textBox3.Text);
                cmd.Parameters.AddWithValue("date", textBox4.Text);
                cmd.Parameters.AddWithValue("time", textBox5.Text);
                cmd.Parameters.AddWithValue("insurance", comboBox2.Text);
                cmd.Parameters.AddWithValue("room", comboBox1.Text);
                cmd.Parameters.AddWithValue("bed", comboBox3.Text);
                cmd.Parameters.AddWithValue("paid", textBox12.Text);
                cmd.Parameters.AddWithValue("diagnosis", textBox2.Text);
                cmd.Parameters.AddWithValue("describtion", textBox7.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ویرایش شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox12.Text = "";
                comboBox1.Text = comboBox2.Text = comboBox3.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ویرایش نشدند");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox12.Text = "";
            comboBox1.Text = comboBox2.Text = comboBox3.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management m = new Management();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Discharge_Load_1(object sender, EventArgs e)
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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
