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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DIPU-PC\SQLEXPRESS;Initial Catalog=Data;Integrated Security=True;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from login where username= '"+textBox1.Text+"' and password='"+textBox2.Text+"'", con);
            DataTable dt = new DataTable();

            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("error");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

Ccreenshot :  http://prntscr.com/9sdlet
              http://prntscr.com/9sdoop


