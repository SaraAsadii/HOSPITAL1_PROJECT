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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Management m = new Management();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                SqlCommand comm = new SqlCommand("SELECT password FROM Login WHERE Username='" + username + "'", sc);
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                string pass = reader["Password"].ToString();
                if (password == pass)
                {
                    MessageBox.Show("Login successful");
                    m.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Incorrect");
                sc.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
