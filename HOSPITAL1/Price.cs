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
    public partial class Price : Form
    {
        public Price()
        {
            InitializeComponent();
        }

        private void Price_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Ae' table. You can move, or remove it, as needed.
            this.aeTableAdapter.Fill(this.database1DataSet3.Ae);
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query2 = " SELECT Ae FROM Ae ";
            SqlCommand cmd2 = new SqlCommand(query2, sc);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                string ae = reader2["Ae"].ToString();
                comboBox2.Items.Add(ae);
            }
            reader2.Close();
            sc.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ae = textBox10.Text;
            SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = " SELECT Price FROM Ae WHERE Code = '" + ae + "' ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = reader["Price"].ToString();
            }
            reader.Close();
            sc.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Management m = new Management();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
