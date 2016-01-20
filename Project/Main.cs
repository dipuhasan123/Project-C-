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
using System.Drawing.Printing;

namespace logout
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss1 = new Form1();
            ss1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
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
        public void PrintPage(object sender, PrintPageEventArgs e)
        {

            //string f = richTextBox1.Text;
            string text1 = textBox1.Text;
            string text2 = textBox5.Text;
            e.Graphics.DrawString(text2, new Font("Georga", 35, FontStyle.Bold), Brushes.Black, 10, 10);
            //e.Graphics.DrawString(text1, new Font("Georga", 35, FontStyle.Bold), Brushes.Black, 10, 15);
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintPage);
            printPreviewDialog1.Show();

            for (int i = 0; i<5; i++)
            {
                printPreviewDialog1.Show();

            }
            //printPreviewDialog1.Show();

            //printPreviewControl1.Document = printDocument1;

        }





        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss1 = new Form1();
            ss1.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void Rec_Click(object sender, EventArgs e)
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

        private void click1(object sender, EventArgs e)
        {
            //textBox5.Text = (Double.Parse(textBox1.Text) - Double.Parse(textBox4.Text)).ToString();
        }

        private void click2(object sender, EventArgs e)
        {
            //textBox5.Text = (Double.Parse(textBox1.Text) - Double.Parse(textBox4.Text)).ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void e(object sender, EventArgs e)
        {
            //textBox5.Text = (Double.Parse(textBox1.Text) - Double.Parse(textBox4.Text)).ToString();

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        /* private void Rec_Click_1(object sender, EventArgs e)
         {
             textBox5.Text = (Double.Parse(textBox1.Text) - Double.Parse(textBox4.Text)).ToString();
         }
         */
        /*private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Text = (Double.Parse(textBox1.Text) - Double.Parse(textBox4.Text)).ToString();
        }*/

        private void Main_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0,0);
            this.Size = new Size(w, h);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            textBox5.Text = (Double.Parse(textBox1.Text) - Double.Parse(textBox4.Text)).ToString();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
            }
            textBox1.Text = (sum.ToString());
        }
    }
}

Screenshot: 1. http://prntscr.com/9sdmik
            2. http://prntscr.com/9sdmrd
            3. http://prntscr.com/9sdmze
            4. http://prntscr.com/9sdn6n
            5. http://prntscr.com/9sdnnn
            6. 
