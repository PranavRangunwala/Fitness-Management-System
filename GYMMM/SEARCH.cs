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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYMMM
{
    public partial class SEARCH : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-QBVHU5T2;Initial Catalog=P_GYMMM;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public SEARCH()
        {
            InitializeComponent();
        }

        private void SEARCH_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Member");
            comboBox1.Items.Add("Equipment");
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
                cmd = new SqlCommand("select SID,Fname,Lname,Gender,Dob,Mobile,Salary,Email,JoinDate,CITY.C_NAME,Saddress from NewStaff join CITY on NewStaff.C_ID=CITY.C_ID where [SID] = "+textBox1.Text+"",con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 
                da.Fill(dt);
                dataGridView1.DataSource= dt;
                con.Close();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                con.Close();
                cmd = new SqlCommand("select * from NewMember where MID = " + textBox1.Text + "", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                con.Close();
                cmd = new SqlCommand("select E_ID,Equipment_Category.EC_NAME,E_NAME,E_PRICE from Equipment_tbl join Equipment_Category on Equipment_tbl.C_ID=Equipment_Category.EC_ID where [E_ID] = '" + textBox1.Text + "'", con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            else if(comboBox1.SelectedIndex == 2) 
            {
                viewwqp();
            }
        }

        private void viewwqp()
        {
            con.Close();
            cmd = new SqlCommand("select E_ID,Equipment_Category.EC_NAME,E_NAME,E_PRICE from Equipment_tbl join Equipment_Category on Equipment_tbl.C_ID=Equipment_Category.EC_ID", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
