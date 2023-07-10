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
    public partial class Off : Form
    {
        public Off()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string code = textBox9.Text;

            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT * FROM Ofr WHERE Code = '" + code + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = reader["Id"].ToString();
                textBox3.Text = reader["Name"].ToString();
                textBox1.Text = reader["Lastname"].ToString();
                textBox5.Text = reader["Day"].ToString();
                textBox6.Text = reader["SDate"].ToString();
                textBox7.Text = reader["Edate"].ToString();
                comboBox1.Text = reader["Type"].ToString();
                textBox4.Text = reader["Reason"].ToString();
            }
            sc.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                string code = textBox9.Text;
                string id = textBox2.Text;
                string name = textBox3.Text;
                string lastname = textBox1.Text;
                string day = textBox5.Text;
                string sdate = textBox6.Text;
                string edate = textBox7.Text;
                string type = comboBox1.Text;
                string reason = textBox4.Text;

                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " INSERT INTO Ofr(Code,Id,Name,Lastname,Day,SDate,EDate,Type,Reason) VALUES ('" + code + "' , '" + id + "' , N'" + name + "' , N'" + lastname + "' , '" + day + "' , '" + sdate + "' , '" + edate + "' , N'" + type + "' , N'" + reason + "')";
                SqlCommand cmd = new SqlCommand(query, sc);

                cmd.Parameters.AddWithValue("code", textBox9.Text);
                cmd.Parameters.AddWithValue("id", textBox2.Text);
                cmd.Parameters.AddWithValue("name", textBox3.Text);
                cmd.Parameters.AddWithValue("lastname", textBox1.Text);
                cmd.Parameters.AddWithValue("day", textBox5.Text);
                cmd.Parameters.AddWithValue("sdate", textBox6.Text);
                cmd.Parameters.AddWithValue("edate", textBox7.Text);
                cmd.Parameters.AddWithValue("type", comboBox1.Text);
                cmd.Parameters.AddWithValue("reason", textBox4.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ذخیره شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox9.Text = "";
                comboBox1.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات ذخیره نشدند");
            }
        }

        private void Off_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query1 = " SELECT Mr FROM Mr ";
            SqlCommand cmd1 = new SqlCommand(query1, sc);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                string mr = reader1["Mr"].ToString();
                comboBox1.Items.Add(mr);
            }
            reader1.Close();
            sc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string code = textBox9.Text;
                string id = textBox2.Text;
                string name = textBox3.Text;
                string lastname = textBox1.Text;
                string day = textBox5.Text;
                string sdate = textBox6.Text;
                string edate = textBox7.Text;
                string type = comboBox1.Text;
                string reason = textBox4.Text;


                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " UPDATE Ofr SET Code = '" + code + "' , Id = '" + id + "' , Name = N'" + name + "' , Lastname = N'" + lastname + "' , Day = '" + day + "' , SDate = '" + sdate + "' , EDate = '" + edate + "' , Type = '" + type + "' , Reason = N'" + reason + "' WHERE Code = '" + code + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("code", textBox9.Text);
                cmd.Parameters.AddWithValue("id", textBox2.Text);
                cmd.Parameters.AddWithValue("name", textBox3.Text);
                cmd.Parameters.AddWithValue("lastname", textBox1.Text);
                cmd.Parameters.AddWithValue("day", textBox5.Text);
                cmd.Parameters.AddWithValue("sdate", textBox6.Text);
                cmd.Parameters.AddWithValue("edate", textBox7.Text);
                cmd.Parameters.AddWithValue("type", comboBox1.Text);
                cmd.Parameters.AddWithValue("reason", textBox4.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت ویرایش شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox9.Text = "";
                comboBox1.Text = null;
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
                string code = textBox9.Text;
                string id = textBox2.Text;
                string name = textBox3.Text;
                string lastname = textBox1.Text;
                string day = textBox5.Text;
                string sdate = textBox6.Text;
                string edate = textBox7.Text;
                string type = comboBox1.Text;
                string reason = textBox4.Text;


                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                string query = " DELETE FROM Ofr WHERE Code = '" + code + "' ";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.Parameters.AddWithValue("code", textBox9.Text);
                cmd.Parameters.AddWithValue("id", textBox2.Text);
                cmd.Parameters.AddWithValue("name", textBox3.Text);
                cmd.Parameters.AddWithValue("lastname", textBox1.Text);
                cmd.Parameters.AddWithValue("day", textBox5.Text);
                cmd.Parameters.AddWithValue("sdate", textBox6.Text);
                cmd.Parameters.AddWithValue("edate", textBox7.Text);
                cmd.Parameters.AddWithValue("type", comboBox1.Text);
                cmd.Parameters.AddWithValue("reason", textBox4.Text);
                cmd.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show(".اطلاعات با موفقیت حذف شدند");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox9.Text = "";
                comboBox1.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show(".اطلاعات حذف  نشدند");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox9.Text = "";
            comboBox1.Text = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management m = new Management();
            m.Show();
        }
    }
}
