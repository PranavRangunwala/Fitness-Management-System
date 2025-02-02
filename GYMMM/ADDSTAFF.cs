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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYMMM
{
    public partial class ADDSTAFF : Form
    {
        public ADDSTAFF()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-QBVHU5T2;Initial Catalog=P_GYMMM;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void ADDSTAFF_Load(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("Select C_NAME from CITY", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                citycombo.Items.Add(dr.GetString(0));
            }
            dr.Close();
            con.Close();

            
        }
        private void resetcontrols()
        {
            fn.Text = "";
            ln.Text = "";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            mo.Text = "";
            em.Text = "";
            citycombo.SelectedIndex = -1;
            dob.Value = DateTime.Now;
            jd.Value = DateTime.Now;
            ad.Text = "";
            sa.Text = "";
            pa.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fname = fn.Text;
            string lname = ln.Text;
            string gender = "";
            bool ischecked = radioButton1.Checked;

            if (ischecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            string dobb = dob.Text;
            Int64 mobile = Int64.Parse(mo.Text);
            Int64 salary = Int64.Parse(sa.Text);
            String email = em.Text;
            String jdd = jd.Text;
            con.Close();
            cmd = new SqlCommand("select C_ID from CITY where C_NAME = '"+citycombo.Text+"'",con);
            con.Open();
            string City = cmd.ExecuteScalar().ToString();
            string address = ad.Text;
            string password = pa.Text;
            cmd = new SqlCommand("insert into NewStaff values('" + fname + "','" + lname + "','" + gender + "','" + dobb + "'," + mobile + ","+salary+",'" + email + "','" + jdd + "'," + City + ",'" + address + "','"+password+"')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            resetcontrols();
            MessageBox.Show("Data Save");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetcontrols();
            con.Close();
            cmd = new SqlCommand("select * from NewStaff where SID = " + si.Text + "", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                fn.Text = dr.GetValue(1).ToString();
                ln.Text += dr.GetValue(2).ToString();
                if (radioButton1.Text == dr.GetValue(3).ToString())
                {
                    radioButton1.Checked = true;
                }
                else if (radioButton2.Text == dr.GetValue(3).ToString())
                {
                    radioButton2.Checked = true;
                }
                dob.Text = dr.GetValue(4).ToString();
                mo.Text = dr.GetValue(5).ToString();
                sa.Text = dr.GetValue(6).ToString();
                em.Text = dr.GetValue(7).ToString();
                jd.Text = dr.GetValue(8).ToString();
                citycombo.SelectedIndex = (int) dr.GetValue(9) - 1;
                ad.Text = dr.GetValue(10).ToString();
                pa.Text = dr.GetValue(11).ToString();

            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = fn.Text;
            string lname = ln.Text;
            string gender = "";
            bool ischecked = radioButton1.Checked;

            if (ischecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            string dobb = dob.Text;
            Int64 mobile = Int64.Parse(mo.Text);
            Int64 salary = Int64.Parse(sa.Text);
            String email = em.Text;
            String jdd = jd.Text;
            con.Close();
            cmd = new SqlCommand("select C_ID from CITY where C_NAME = '" + citycombo.Text + "'", con);
            con.Open();
            string City = cmd.ExecuteScalar().ToString();
            string address = ad.Text;
            string Pass = pa.Text;
            cmd = new SqlCommand("update NewStaff set Fname = '" + fname + "',Lname = '" + lname + "',Gender = '" + gender + "',Dob = '" + dobb + "',Mobile = " + mobile + ",Salary = "+salary+",Email = '" + email + "',JoinDate = '" + jdd + "',C_ID = "+City+",Saddress = '" + address + "' where SID = " + si.Text + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            resetcontrols();
            MessageBox.Show("Update SuccessFully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetcontrols();
        }
    }
}
