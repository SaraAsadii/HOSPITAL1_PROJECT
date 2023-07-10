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
    public partial class Emergency : Form
    {
        public Emergency()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string madmissionid = textBox1.Text;
                string date = textBox2.Text;
                string time = textBox11.Text;
                string patient = textBox4.Text;
                string age = textBox6.Text;
                string gender = comboBox1.Text;
                bool pregnant = checkBox1.Checked;
                string aa = textBox7.Text;
                string ab = textBox5.Text;
                string ac = textBox8.Text;
                bool un = checkBox2.Checked;
                bool pain = checkBox4.Checked;
                bool verbal = checkBox7.Checked;
                bool alert = checkBox9.Checked;
                bool ad = checkBox3.Checked;
                bool ae = checkBox5.Checked;
                bool af = checkBox6.Checked;
                bool ag = checkBox8.Checked;
                bool ah = checkBox12.Checked;
                bool ai = checkBox11.Checked;
                bool aj = checkBox10.Checked;
                string ak = textBox9.Text;
                string al = textBox10.Text;


                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " INSERT INTO Emergency(AdmissionID,Date,Time,Patient,Age,Gender,Pregnant,AA,AB,AC,Un,Pain,Verbal,Alert,AD,AE,AF,AG,AH,AI,AJ,AK,AL) VALUES ('" + madmissionid + "' , '" + date + "' , '" + time + "' , N'" + patient + "' , '" + age + "' , N'" + gender + "' , '" + pregnant + "' , N'" + aa + "' , N'" + ab + "' , N'" + ac + "' , '" + un + "' , '" + pain + "' , '" + verbal + "' , '" + alert + "' , '" + ad + "' , '" + ae + "' , '" + af + "' , '" + ag + "' , '" + ah + "' , '" + ai + "' , '" + aj + "' , N'" + ak + "' , N'" + al + "')";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("madmissionid", textBox1.Text);
                cmd.Parameters.AddWithValue("date", textBox2.Text);
                cmd.Parameters.AddWithValue("time", textBox11.Text);
                cmd.Parameters.AddWithValue("patient", textBox4.Text);
                cmd.Parameters.AddWithValue("age", textBox6.Text);
                cmd.Parameters.AddWithValue("gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("pregnant", checkBox1.Checked);
                cmd.Parameters.AddWithValue("aa", textBox7.Text);
                cmd.Parameters.AddWithValue("ab", textBox5.Text);
                cmd.Parameters.AddWithValue("ac", textBox8.Text);
                cmd.Parameters.AddWithValue("un", checkBox2.Checked);
                cmd.Parameters.AddWithValue("pain", checkBox4.Checked);
                cmd.Parameters.AddWithValue("verbal", checkBox7.Checked);
                cmd.Parameters.AddWithValue("alert", checkBox9.Checked);
                cmd.Parameters.AddWithValue("ad", checkBox3.Checked);
                cmd.Parameters.AddWithValue("ae", checkBox5.Checked);
                cmd.Parameters.AddWithValue("af", checkBox6.Checked);
                cmd.Parameters.AddWithValue("ag", checkBox8.Checked);
                cmd.Parameters.AddWithValue("ah", checkBox12.Checked);
                cmd.Parameters.AddWithValue("ai", checkBox11.Checked);
                cmd.Parameters.AddWithValue("aj", checkBox10.Checked);
                cmd.Parameters.AddWithValue("ak", textBox9.Text);
                cmd.Parameters.AddWithValue("al", textBox10.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ذخیره شدند");
                textBox1.Text = textBox2.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = "";
                comboBox1.Text = null;
                checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = checkBox4.Checked = checkBox5.Checked = checkBox6.Checked = checkBox7.Checked = checkBox8.Checked = checkBox9.Checked = checkBox10.Checked = checkBox11.Checked = checkBox12.Checked = false;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ذخیره نشدند");
            }
        }

        private void Emergency_Load(object sender, EventArgs e)
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
            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string madmissionid = textBox1.Text;
                string date = textBox2.Text;
                string time = textBox11.Text;
                string patient = textBox4.Text;
                string age = textBox6.Text;
                string gender = comboBox1.Text;
                bool pregnant = checkBox1.Checked;
                string aa = textBox7.Text;
                string ab = textBox5.Text;
                string ac = textBox8.Text;
                bool un = checkBox2.Checked;
                bool pain = checkBox4.Checked;
                bool verbal = checkBox7.Checked;
                bool alert = checkBox9.Checked;
                bool ad = checkBox3.Checked;
                bool ae = checkBox5.Checked;
                bool af = checkBox6.Checked;
                bool ag = checkBox8.Checked;
                bool ah = checkBox12.Checked;
                bool ai = checkBox11.Checked;
                bool aj = checkBox10.Checked;
                string ak = textBox9.Text;
                string al = textBox10.Text;

                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " UPDATE Emergency SET AdmissionID = '" + madmissionid + "' , Date = '" + date + "' , Time = '" + time + "' , Patient = '" + patient + "' , Age = '" + age + "' , Gender = N'" + gender + "' , Pregnant = '" + pregnant + "' , AA = N'" + aa + "' , AB = N'" + ab + "' , AC = N'" + ac + "' , Un = '" + un + "' , Pain = '" + pain + "' , Verbal = '" + verbal + "' , Alert = '" + alert + "' , AD = '" + ad + "' , AE = '" + ae + "' , AF = '" + af + "' , AG = '" + ag + "' , AH = '" + ah + "' , AI = '" + ai + "' ,  AJ = '" + aj + "' ,  AK = N'" + ak + "' ,  AL = N'" + al + "' WHERE AdmissionID = '" + madmissionid + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("madmissionid", textBox1.Text);
                cmd.Parameters.AddWithValue("date", textBox2.Text);
                cmd.Parameters.AddWithValue("time", textBox11.Text);
                cmd.Parameters.AddWithValue("patient", textBox4.Text);
                cmd.Parameters.AddWithValue("age", textBox6.Text);
                cmd.Parameters.AddWithValue("gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("pregnant", checkBox1.Checked);
                cmd.Parameters.AddWithValue("aa", textBox7.Text);
                cmd.Parameters.AddWithValue("ab", textBox5.Text);
                cmd.Parameters.AddWithValue("ac", textBox8.Text);
                cmd.Parameters.AddWithValue("un", checkBox2.Checked);
                cmd.Parameters.AddWithValue("pain", checkBox4.Checked);
                cmd.Parameters.AddWithValue("verbal", checkBox7.Checked);
                cmd.Parameters.AddWithValue("alert", checkBox9.Checked);
                cmd.Parameters.AddWithValue("ad", checkBox3.Checked);
                cmd.Parameters.AddWithValue("ae", checkBox5.Checked);
                cmd.Parameters.AddWithValue("af", checkBox6.Checked);
                cmd.Parameters.AddWithValue("ag", checkBox8.Checked);
                cmd.Parameters.AddWithValue("ah", checkBox12.Checked);
                cmd.Parameters.AddWithValue("ai", checkBox11.Checked);
                cmd.Parameters.AddWithValue("aj", checkBox10.Checked);
                cmd.Parameters.AddWithValue("ak", textBox9.Text);
                cmd.Parameters.AddWithValue("al", textBox10.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ویرایش شدند");
                textBox1.Text = textBox2.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = "";
                comboBox1.Text = null;
                checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = checkBox4.Checked = checkBox5.Checked = checkBox6.Checked = checkBox7.Checked = checkBox8.Checked = checkBox9.Checked = checkBox10.Checked = checkBox11.Checked = checkBox12.Checked = false;
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
                string madmissionid = textBox1.Text;
                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " DELETE FROM Emergency WHERE AdmissionID = '" + madmissionid + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("madmissionid", textBox1.Text);
                cmd.Parameters.AddWithValue("date", textBox2.Text);
                cmd.Parameters.AddWithValue("time", textBox11.Text);
                cmd.Parameters.AddWithValue("patient", textBox4.Text);
                cmd.Parameters.AddWithValue("age", textBox6.Text);
                cmd.Parameters.AddWithValue("gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("pregnant", checkBox1.Checked);
                cmd.Parameters.AddWithValue("aa", textBox7.Text);
                cmd.Parameters.AddWithValue("ab", textBox5.Text);
                cmd.Parameters.AddWithValue("ac", textBox8.Text);
                cmd.Parameters.AddWithValue("un", checkBox2.Checked);
                cmd.Parameters.AddWithValue("pain", checkBox4.Checked);
                cmd.Parameters.AddWithValue("verbal", checkBox7.Checked);
                cmd.Parameters.AddWithValue("alert", checkBox9.Checked);
                cmd.Parameters.AddWithValue("ad", checkBox3.Checked);
                cmd.Parameters.AddWithValue("ae", checkBox5.Checked);
                cmd.Parameters.AddWithValue("af", checkBox6.Checked);
                cmd.Parameters.AddWithValue("ag", checkBox8.Checked);
                cmd.Parameters.AddWithValue("ah", checkBox12.Checked);
                cmd.Parameters.AddWithValue("ai", checkBox11.Checked);
                cmd.Parameters.AddWithValue("aj", checkBox10.Checked);
                cmd.Parameters.AddWithValue("ak", textBox9.Text);
                cmd.Parameters.AddWithValue("al", textBox10.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت حذف شدند");
                textBox1.Text = textBox2.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = "";
                comboBox1.Text = null;
                checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = checkBox4.Checked = checkBox5.Checked = checkBox6.Checked = checkBox7.Checked = checkBox8.Checked = checkBox9.Checked = checkBox10.Checked = checkBox11.Checked = checkBox12.Checked = false;
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

        private void button7_Click(object sender, EventArgs e)
        {
            string madmissionid = textBox1.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT * FROM Emergency WHERE AdmissionID = '" + madmissionid + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = reader["Date"].ToString();
                textBox11.Text = reader["Time"].ToString();
                textBox4.Text = reader["Patient"].ToString();
                textBox6.Text = reader["Age"].ToString();
                comboBox1.Text = reader["Gender"].ToString();
                textBox7.Text = reader["AA"].ToString();
                textBox5.Text = reader["AB"].ToString();
                textBox8.Text = reader["AC"].ToString();
                textBox9.Text = reader["AK"].ToString();
                textBox10.Text = reader["AL"].ToString();

            }
            reader.Close();
            sc.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = "";
            comboBox1.Text = null;
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = checkBox4.Checked = checkBox5.Checked = checkBox6.Checked = checkBox7.Checked = checkBox8.Checked = checkBox9.Checked = checkBox10.Checked = checkBox11.Checked = checkBox12.Checked = false;
        }
    }
}
