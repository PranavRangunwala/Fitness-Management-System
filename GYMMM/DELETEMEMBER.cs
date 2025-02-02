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

namespace GYMMM
{
    public partial class DELETEMEMBER : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-QBVHU5T2;Initial Catalog=P_GYMMM;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public DELETEMEMBER()
        {
            InitializeComponent();
        }

        private void DELETEMEMBER_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Member");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                viewstaffdetail();
                
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                viewmemberdetail();
            }
        }

        private void viewstaffdetail()
        {
            con.Close();
            cmd = new SqlCommand("select SID,Fname,Lname,Gender,Dob,Mobile,Salary,Email,JoinDate,CITY.C_NAME,Saddress from NewStaff join CITY on NewStaff.C_ID=CITY.C_ID ", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void viewmemberdetail()
        {
            con.Close();
            cmd = new SqlCommand("select * from NewMember", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                con.Close();
                cmd = new SqlCommand("delete from NewStaff where SID = " + textBox1.Text + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                viewstaffdetail();
                MessageBox.Show("Staff Deleted SuccessFully");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                con.Close();
                cmd = new SqlCommand("delete from NewMember where MID = " + textBox1.Text + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                viewmemberdetail();
                MessageBox.Show("Member Deleted SuccessFully");
            }
            else {
                MessageBox.Show("Select Category.");
            }
        }
    }
}
