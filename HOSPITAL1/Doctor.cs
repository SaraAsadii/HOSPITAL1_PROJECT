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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            string mcnumber = textBox1.Text;
            string name = textBox2.Text;
            string lastname = textBox3.Text;
            string nationalid = textBox4.Text;
            string phonenumber = textBox5.Text;
            string degree = comboBox1.Text;
            string specialty = textBox6.Text;
            string address = textBox7.Text;
            string droom = comboBox2.Text;

            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
                string query = " INSERT INTO Doctor1(MCNumber,Name,Lastname,NationalID,PhoneNumber,Degree,Specialty,Address,DRoom) VALUES ('" + mcnumber + "' , N'" + name + "' , N'" + lastname + "' , '" + nationalid + "' , '" + phonenumber + "' , N'" + degree + "' , N'" + specialty + "' , N'" + address + "' , '" + droom + "')";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("mcnumber", textBox1.Text);
                cmd.Parameters.AddWithValue("name", textBox2.Text);
                cmd.Parameters.AddWithValue("lastname", textBox3.Text);
                cmd.Parameters.AddWithValue("nationalid", textBox4.Text);
                cmd.Parameters.AddWithValue("phonenumber", textBox5.Text);
                cmd.Parameters.AddWithValue("degree", comboBox1.Text);
                cmd.Parameters.AddWithValue("specialty", textBox6.Text);
                cmd.Parameters.AddWithValue("address", textBox7.Text);
                cmd.Parameters.AddWithValue("droom", comboBox2.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ذخیره شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
                comboBox1.Text = null;
                comboBox2.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ذخیره نشدند");
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string mcnumber = textBox1.Text;
                string name = textBox2.Text;
                string lastname = textBox3.Text;
                string nationalid = textBox4.Text;
                string phonenumber = textBox5.Text;
                string degree = comboBox1.Text;
                string specialty = textBox6.Text;
                string address = textBox7.Text;
                string droom = comboBox2.Text;

                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " UPDATE Doctor1 SET MCNumber = '" + mcnumber + "' , Name = N'" + name + "' , Lastname = N'" + lastname + "' , NationalID = '" + nationalid + "' , PhoneNumber = '" + phonenumber + "' , Degree = N'" + degree + "' , Specialty = N'" + specialty + "' , Address = N'" + address + "' , DRoom = '" + droom + "' WHERE MCNumber = N'" + mcnumber + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("mcnumber", textBox1.Text);
                cmd.Parameters.AddWithValue("name", textBox2.Text);
                cmd.Parameters.AddWithValue("lastname", textBox3.Text);
                cmd.Parameters.AddWithValue("nationalid", textBox4.Text);
                cmd.Parameters.AddWithValue("phonenumber", textBox5.Text);
                cmd.Parameters.AddWithValue("degree", comboBox1.Text);
                cmd.Parameters.AddWithValue("specialty", textBox6.Text);
                cmd.Parameters.AddWithValue("address", textBox7.Text);
                cmd.Parameters.AddWithValue("droom", comboBox2.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ویرایش شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
                comboBox1.Text = null;
                comboBox2.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ویرایش نشدند");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string mcnumber = textBox1.Text;
                string name = textBox2.Text;
                string lastname = textBox3.Text;
                string nationalid = textBox4.Text;
                string phonenumber = textBox5.Text;
                string degree = comboBox1.Text;
                string specialty = textBox6.Text;
                string address = textBox7.Text;
                string droom = comboBox2.Text;

                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " DELETE FROM Doctor1 WHERE MCNumber = '" + mcnumber + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("mcnumber", textBox1.Text);
                cmd.Parameters.AddWithValue("name", textBox2.Text);
                cmd.Parameters.AddWithValue("lastname", textBox3.Text);
                cmd.Parameters.AddWithValue("nationalid", textBox4.Text);
                cmd.Parameters.AddWithValue("phonenumber", textBox5.Text);
                cmd.Parameters.AddWithValue("degree", comboBox1.Text);
                cmd.Parameters.AddWithValue("specialty", textBox6.Text);
                cmd.Parameters.AddWithValue("address", textBox7.Text);
                cmd.Parameters.AddWithValue("droom", comboBox2.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت حذف شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
                comboBox1.Text = null;
                comboBox2.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات حذف نشدند");
            }
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
