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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string patientid = textBox1.Text;
                string name = textBox2.Text;
                string lastname = textBox3.Text;
                string nationalid = textBox4.Text;
                string phonenumber = textBox5.Text;
                string age = textBox6.Text;
                string gender = comboBox1.Text;
                string insurance = comboBox2.Text;
                string disease = textBox8.Text;
                string address = textBox7.Text;


                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " INSERT INTO Patient(PatientID,Name,Lastname,NationalID,PhoneNumber,Age,Gender,Insurance,Disease,Address) VALUES ('" + patientid + "' , N'" + name + "' , N'" + lastname + "' , '" + nationalid + "' , '" + phonenumber + "' , '" + age + "' , N'" + gender + "' , N'" + insurance + "' , N'" + disease + "' , N'" + address + "')";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("patientid", textBox1.Text);
                cmd.Parameters.AddWithValue("name", textBox2.Text);
                cmd.Parameters.AddWithValue("lastname", textBox3.Text);
                cmd.Parameters.AddWithValue("nationalid", textBox4.Text);
                cmd.Parameters.AddWithValue("phonenumber", textBox5.Text);
                cmd.Parameters.AddWithValue("age", textBox6.Text);
                cmd.Parameters.AddWithValue("gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("insurance", comboBox2.Text);
                cmd.Parameters.AddWithValue("disease", textBox8.Text);
                cmd.Parameters.AddWithValue("address", textBox7.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ذخیره شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
                comboBox1.Text = comboBox2.Text = null;
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
                string patientid = textBox1.Text;
                string name = textBox2.Text;
                string lastname = textBox3.Text;
                string nationalid = textBox4.Text;
                string phonenumber = textBox5.Text;
                string age = textBox6.Text;
                string gender = comboBox1.Text;
                string insurance = comboBox2.Text;
                string disease = textBox8.Text;
                string address = textBox7.Text;


                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " UPDATE Patient SET PatientID = '" + patientid + "' , Name = N'" + name + "' , Lastname = N'" + lastname + "' , NationalID = '" + nationalid + "' , PhoneNumber = '" + phonenumber + "' , Age = '" + age + "' , Gender = N'" + gender + "' , Insurance = N'" + insurance + "' , Disease = N'" + disease + "' , Address = N'" + address + "' WHERE PatientID = '" + patientid + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("patientid", textBox1.Text);
                cmd.Parameters.AddWithValue("name", textBox2.Text);
                cmd.Parameters.AddWithValue("lastname", textBox3.Text);
                cmd.Parameters.AddWithValue("nationalid", textBox4.Text);
                cmd.Parameters.AddWithValue("phonenumber", textBox5.Text);
                cmd.Parameters.AddWithValue("age", textBox6.Text);
                cmd.Parameters.AddWithValue("gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("insurance", comboBox2.Text);
                cmd.Parameters.AddWithValue("disease", textBox8.Text);
                cmd.Parameters.AddWithValue("address", textBox7.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ویرایش شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
                comboBox1.Text = comboBox2.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ویرایش نشدند");
            }
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query1 = " SELECT Gender FROM Gender ";
            SqlCommand cmd1 = new SqlCommand(query1, sc);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string gender = reader1["Gender"].ToString();
                comboBox1.Items.Add(gender);
            }
            reader1.Close();


            string query2 = " SELECT Insurance FROM Insurance ";
            SqlCommand cmd2 = new SqlCommand(query2, sc);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string insurance = reader2["Insurance"].ToString();
                comboBox2.Items.Add(insurance);
            }
            reader2.Close();
            sc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string patientid = textBox1.Text;
                string name = textBox2.Text;
                string lastname = textBox3.Text;
                string nationalid = textBox4.Text;
                string phonenumber = textBox5.Text;
                string age = textBox6.Text;
                string gender = comboBox1.Text;
                string insurance = comboBox2.Text;
                string disease = textBox8.Text;
                string address = textBox7.Text;


                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " DELETE FROM Patient WHERE PatientID = '" + patientid + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("patientid", textBox1.Text);
                cmd.Parameters.AddWithValue("name", textBox2.Text);
                cmd.Parameters.AddWithValue("lastname", textBox3.Text);
                cmd.Parameters.AddWithValue("nationalid", textBox4.Text);
                cmd.Parameters.AddWithValue("phonenumber", textBox5.Text);
                cmd.Parameters.AddWithValue("age", textBox6.Text);
                cmd.Parameters.AddWithValue("gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("insurance", comboBox2.Text);
                cmd.Parameters.AddWithValue("disease", textBox8.Text);
                cmd.Parameters.AddWithValue("address", textBox7.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت حذف شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
                comboBox1.Text = comboBox2.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات حذف نشدند");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management m = new Management();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = "";
            comboBox1.Text = comboBox2.Text = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string patientid = textBox1.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT Name, Lastname, NationalID, PhoneNumber, Age, Gender, Insurance, Disease, Address FROM Patient WHERE PatientID = '" + patientid + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = reader["Name"].ToString();
                textBox3.Text = reader["Lastname"].ToString();
                textBox4.Text = reader["NationalID"].ToString();
                textBox5.Text = reader["PhoneNumber"].ToString();
                textBox6.Text = reader["Age"].ToString();
                comboBox1.Text = reader["Gender"].ToString();
                comboBox2.Text = reader["Insurance"].ToString();
                textBox8.Text = reader["Disease"].ToString();
                textBox7.Text = reader["Address"].ToString();
            }
            reader.Close();
            sc.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
