using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace logout
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss1 = new Form1();
            ss1.Show();
        }*/

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item.Cells[3].Value.ToString();
                    //dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    //dataGridView2.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
            }
            textBox1.Text = (sum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //PrintDocument pd = new PrintDocument();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss1 = new Form1();
            ss1.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(@"Data Source=DIPU-PC\SQLEXPRESS;Initial Catalog=Data;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from rct", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //dataGridView1.DataSource = dt;

            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = false;
                dataGridView1.Rows[n].Cells[1].Value = item["ID"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Product_List"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Price"].ToString();

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item.Cells[3].Value.ToString();
                    //dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    //dataGridView2.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
            }
            textBox1.Text = (sum.ToString());
        }

        private void signoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //Form1 frm1 = new Form1();
            //frm1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox5.Text = (Double.Parse(textBox1.Text) - Double.Parse(textBox4.Text)).ToString();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }
    }
}

Screenshot: http://prntscr.com/9sdm43
