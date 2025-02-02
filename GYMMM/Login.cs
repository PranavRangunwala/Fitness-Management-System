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

namespace GYMMM
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-QBVHU5T2;Initial Catalog=P_GYMMM;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //int A = int.Parse(textBox1.Text);
                //String B = textBox2.Text;
                //cmd = new SqlCommand("select A_ID from ",con); 
                //if()

                SqlConnection my = new SqlConnection(@"Data Source=LAPTOP-QBVHU5T2;Initial Catalog=P_GYMMM;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from ADMIN_TBL where A_ID= " + textBox1.Text + " and pass = '" + textBox2.Text + "'", my);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {

                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Please check your Username|Password");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SqlConnection my = new SqlConnection(@"Data Source=LAPTOP-QBVHU5T2;Initial Catalog=P_GYMMM;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from NewStaff where SID= " + textBox1.Text + " and Password = '" + textBox2.Text + "'", my);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {

                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Please check your Username|Password");
                }
            }
        }
    }
}
