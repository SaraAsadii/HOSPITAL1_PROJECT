using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL1
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
            this.Hide();
        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchD sd = new SearchD();
            sd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            p.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nurse n = new Nurse();
            n.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Worker w = new Worker();
            w.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Off o = new Off();
            o.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admission a = new Admission();
            a.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SearchP sp = new SearchP();
            sp.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Discharge ds = new Discharge();
            ds.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Money m = new Money();
            m.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Emergency em = new Emergency();
            em.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Dead de = new Dead();
            de.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
            l.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Price pr = new Price();
            pr.Show();
            this.Hide();
        }
    }
}
