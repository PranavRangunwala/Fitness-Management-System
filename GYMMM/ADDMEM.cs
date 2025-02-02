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

namespace GYMMM
{
    public partial class ADDMEM : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-QBVHU5T2;Initial Catalog=P_GYMMM;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();  
        public ADDMEM()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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
            else {
                gender = radioButton2.Text;
            }

            string dobb = dob.Text;
            Int64 mobile = Int64.Parse(mo.Text);
            String email = em.Text;
            String jdd = jd.Text;
            string gymtime = gt.Text;
            string address = ad.Text;
            string membership = mt.Text;
            cmd = new SqlCommand("insert into NewMember values('"+fname+ "','"+lname+ "','"+gender+ "','"+dobb+ "',"+mobile+ ",'"+email+ "','"+jdd+ "','"+gymtime+"','"+ address + "','"+membership+"')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds= new DataSet();
            da.Fill(ds);
            resetcontrols();
            MessageBox.Show("Data Save");
           

        }

        private void resetcontrols()
        {
            fn.Text = "";
            ln.Text = "";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            mo.Text = "";
            em.Text = "";
            gt.SelectedIndex = -1;
            mt.SelectedIndex = -1;
            dob.Value = DateTime.Now;
            jd.Value= DateTime.Now;
            ad.Text = "";

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
            String email = em.Text;
            String jdd = jd.Text;
            string gymtime = gt.Text;
            string address = ad.Text;
            string membership = mt.Text;
            cmd = new SqlCommand("update NewMember set Fname = '" + fname + "',Lname = '" + lname + "',Gender = '" + gender + "',Dob = '" + dobb + "',Mobile = " + mobile + ",Email = '" + email + "',JoinDate = '" + jdd + "',GymTime = '" + gymtime + "',Maddress = '" + address + "',MembershipTime = '" + membership + "' where MID = "+mi.Text+"", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            resetcontrols();
            MessageBox.Show("Update SuccessFully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetcontrols();
            con.Close();
            cmd = new SqlCommand("select * from NewMember where MID = " + mi.Text + "", con);
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
                em.Text = dr.GetValue(6).ToString();
                jd.Text = dr.GetValue(7).ToString();
                gt.SelectedItem = dr.GetValue(8).ToString();
                ad.Text = dr.GetValue(9).ToString();
                mt.SelectedItem = dr.GetValue(10).ToString();

            }
            else {
                MessageBox.Show("Member Not Found");
            }
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetcontrols();
        }

        private void ADDMEM_Load(object sender, EventArgs e)
        {

        }
    }
}
