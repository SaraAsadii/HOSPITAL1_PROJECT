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
    public partial class Nurse : Form
    {
        public Nurse()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox10.Text;
                string name = textBox2.Text;
                string lastname = textBox3.Text;
                string nationalid = textBox4.Text;
                string phonenumber = textBox5.Text;
                string birthday = textBox6.Text;
                string gender = comboBox1.Text;
                string degree = textBox8.Text;
                string position = textBox1.Text;
                string bakhsh = comboBox2.Text;
                string salary = textBox7.Text;

                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " INSERT INTO Nurse(Id,Name,Lastname,NationalID,PhoneNumber,Birthday,Gender,Degree,Position,Bakhsh,Salary) VALUES ('" + id + "' , N'" + name + "' , N'" + lastname + "' , '" + nationalid + "' , '" + phonenumber + "' , '" + birthday + "' , N'" + gender + "' , N'" + degree + "' , N'" + position + "' , N'" + bakhsh + "' , '" + salary + "')";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("id", textBox10.Text);
                cmd.Parameters.AddWithValue("name", textBox2.Text);
                cmd.Parameters.AddWithValue("lastname", textBox3.Text);
                cmd.Parameters.AddWithValue("nationalid", textBox4.Text);
                cmd.Parameters.AddWithValue("phonenumber", textBox5.Text);
                cmd.Parameters.AddWithValue("birthday", textBox6.Text);
                cmd.Parameters.AddWithValue("gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("degree", textBox8.Text);
                cmd.Parameters.AddWithValue("position", textBox1.Text);
                cmd.Parameters.AddWithValue("bakhsh", comboBox2.Text);
                cmd.Parameters.AddWithValue("salary", textBox7.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ذخیره شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox10.Text = "";
                comboBox1.Text = comboBox2.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ذخیره نشدند");
            }
        }

        private void Nurse_Load(object sender, EventArgs e)
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


            string query = " SELECT Bakhsh FROM Bakhsh ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string bakhsh = reader["Bakhsh"].ToString();
                comboBox2.Items.Add(bakhsh);
            }
            reader.Close();
            sc.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string id = textBox10.Text;

            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT Name, Lastname, NationalID, PhoneNumber, Birthday, Gender, Degree, Position, Bakhsh, Salary FROM Nurse WHERE Id = '" + id + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = reader["Name"].ToString();
                textBox3.Text = reader["Lastname"].ToString();
                textBox4.Text = reader["NationalID"].ToString();
                textBox5.Text = reader["PhoneNumber"].ToString();
                textBox6.Text = reader["Birthday"].ToString();
                comboBox1.Text = reader["Gender"].ToString();
                textBox8.Text = reader["Degree"].ToString();
                textBox1.Text = reader["Position"].ToString();
                comboBox2.Text = reader["Bakhsh"].ToString();
                textBox7.Text = reader["Salary"].ToString();
            }
            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox10.Text;
                string name = textBox2.Text;
                string lastname = textBox3.Text;
                string nationalid = textBox4.Text;
                string phonenumber = textBox5.Text;
                string birthday = textBox6.Text;
                string gender = comboBox1.Text;
                string degree = textBox8.Text;
                string position = textBox1.Text;
                string bakhsh = comboBox2.Text;
                string salary = textBox7.Text;


                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " UPDATE Nurse SET Id = '" + id + "' , Name = N'" + name + "' , Lastname = N'" + lastname + "' , NationalID = '" + nationalid + "' , PhoneNumber = '" + phonenumber + "' , Birthday = '" + birthday + "' , Gender = N'" + gender + "' , Degree = N'" + degree + "' , Position = N'" + position + "' , Bakhsh = N'" + bakhsh + "' , Salary = '" + salary + "' WHERE Id = '" + id + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("id", textBox10.Text);
                cmd.Parameters.AddWithValue("name", textBox2.Text);
                cmd.Parameters.AddWithValue("lastname", textBox3.Text);
                cmd.Parameters.AddWithValue("nationalid", textBox4.Text);
                cmd.Parameters.AddWithValue("phonenumber", textBox5.Text);
                cmd.Parameters.AddWithValue("birthday", textBox6.Text);
                cmd.Parameters.AddWithValue("gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("degree", textBox8.Text);
                cmd.Parameters.AddWithValue("position", textBox1.Text);
                cmd.Parameters.AddWithValue("bakhsh", comboBox2.Text);
                cmd.Parameters.AddWithValue("salary", textBox7.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ویرایش شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox10.Text = "";
                comboBox1.Text = comboBox2.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ویرایش نشدند");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox10.Text = "";
            comboBox1.Text = comboBox2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox10.Text;
                string name = textBox2.Text;
                string lastname = textBox3.Text;
                string nationalid = textBox4.Text;
                string phonenumber = textBox5.Text;
                string birthday = textBox6.Text;
                string gender = comboBox1.Text;
                string degree = textBox8.Text;
                string position = textBox1.Text;
                string bakhsh = comboBox2.Text;
                string salary = textBox7.Text;


                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " DELETE FROM Nurse WHERE Id = '" + id + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("id", textBox10.Text);
                cmd.Parameters.AddWithValue("name", textBox2.Text);
                cmd.Parameters.AddWithValue("lastname", textBox3.Text);
                cmd.Parameters.AddWithValue("nationalid", textBox4.Text);
                cmd.Parameters.AddWithValue("phonenumber", textBox5.Text);
                cmd.Parameters.AddWithValue("birthday", textBox6.Text);
                cmd.Parameters.AddWithValue("gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("degree", textBox8.Text);
                cmd.Parameters.AddWithValue("position", textBox1.Text);
                cmd.Parameters.AddWithValue("bakhsh", comboBox2.Text);
                cmd.Parameters.AddWithValue("salary", textBox7.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت حذف شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox10.Text = "";
                comboBox1.Text = comboBox2.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات حذف  نشدند");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management m = new Management();
            m.Show();
        }
    }
}
