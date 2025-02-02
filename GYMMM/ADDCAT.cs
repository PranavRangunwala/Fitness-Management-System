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
    public partial class ADDCAT : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-QBVHU5T2;Initial Catalog=P_GYMMM;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public ADDCAT()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            con.Close();    
            cmd = new SqlCommand("insert into Equipment_Category values("+si.Text+",'"+fn.Text+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            clearbox();
            viewdata();
            MessageBox.Show("Category Inserted.");
        }

        private void clearbox()
        {
            si.Text= "";
            fn.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("delete from Equipment_Category where EC_ID = "+si.Text+"", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            clearbox();
            viewdata();
            MessageBox.Show("Category Deleted.");
        }

        private void viewdata()
        {
            con.Close();
            cmd = new SqlCommand("select * from Equipment_Category", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ADDCAT_Load(object sender, EventArgs e)
        {
            viewdata();
        }
    }
}
