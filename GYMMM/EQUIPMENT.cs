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
    public partial class EQUIPMENT : Form
    {
        int total = 0;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-QBVHU5T2;Initial Catalog=P_GYMMM;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public EQUIPMENT()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void viewwqpdet()
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

        private void vieworderdet()
        {
            con.Close();
            cmd = new SqlCommand("select o_id,Equipment_Category.EC_NAME,Equipment_tbl.E_NAME,oe_address,oe_price,or_qty,ot_total from order_tb join Equipment_Category on order_tb.oec_id=Equipment_Category.EC_ID join Equipment_tbl on order_tb.oec_id=Equipment_tbl.E_ID", con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible= true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;    
            textBox4.Visible = true;    
            comboBox1.Visible = true;   
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            dataGridView1.Visible= true;



            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            textBox3.Visible = false;
            comboBox3.Visible = false;
            comboBox5.Visible = false;
            richTextBox1.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            dataGridView2.Visible= false;
        }

        private void EQUIPMENT_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
            comboBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            dataGridView1.Visible= false;

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            textBox3.Visible = false;   
            comboBox3.Visible = false;  
            comboBox5.Visible = false;  
            richTextBox1.Visible = false;   
            textBox5.Visible = false;   
            textBox6.Visible = false;   
            textBox7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;    
            button10.Visible = false;   
            button11.Visible = false;  
            button12.Visible = false;
            dataGridView2.Visible = false;
            vieworderdet();
            viewwqpdet();
            con.Close();
            cmd= new SqlCommand("select EC_NAME from Equipment_Category",con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(0));
                comboBox3.Items.Add(dr.GetString(0));
            }




            dr.Close();
            con.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Close();
            int a = comboBox1.SelectedIndex + 1;
            con.Open();
            cmd = new SqlCommand("insert into Equipment_tbl values ("+textBox1.Text+",'"+textBox2.Text+"',"+a+","+textBox4.Text+")", con);
            cmd.ExecuteNonQuery();
            con.Close();
            clearbox();
            viewwqpdet();
            MessageBox.Show("Equipmet Inserted SuccessFully.");
        }

        private void clearbox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = -1 ;

            textBox3.Text = "";
            comboBox3.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            richTextBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text= "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a;
            if (comboBox1.SelectedIndex > -1)
            {
                a = comboBox1.SelectedIndex + 1;
            }
            else {
                a = -1;
            }
            con.Close();
            cmd = new SqlCommand("update Equipment_tbl set [E_NAME] = '"+textBox2.Text+ "',[C_ID] = "+a+",[E_PRICE] = " + textBox4.Text+" where [E_ID] = "+textBox1.Text+" ",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            clearbox();
            viewwqpdet();
            MessageBox.Show("Equipment Updated SuccessFully.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("select * from Equipment_tbl where E_ID = "+textBox1.Text+" ", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int a = (int) dr.GetValue(2)-1;
                comboBox1.SelectedIndex = a;
                textBox2.Text = dr.GetString(1).ToString();
                textBox4.Text = dr.GetInt32(3).ToString();

            }
            else {
                MessageBox.Show("No Equipment Exist.");
            }
            con.Close();
            dr.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("delete from Equipment_tbl where E_ID = "+textBox1.Text+" ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            clearbox();
            viewwqpdet();
            MessageBox.Show("Equipment Deleted SuccessFully.");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox4.Visible = false;
            comboBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            dataGridView1.Visible=false;

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            textBox3.Visible = true;
            comboBox3.Visible = true;
            comboBox5.Visible = true;
            richTextBox1.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;    
            dataGridView2.Visible = true;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Close();
            int cat = (int) comboBox3.SelectedIndex + 1;
            cmd = new SqlCommand("select E_ID from Equipment_tbl where E_NAME = '"+comboBox5.Text+"'",con);
            con.Open();
            int name = (int)cmd.ExecuteScalar();
            con.Close();
            cmd = new SqlCommand("insert into order_tb values("+cat+","+name+",'"+richTextBox1.Text+"',"+textBox5.Text+","+textBox6.Text+","+textBox7.Text+")",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            clearbox();
            MessageBox.Show("Order Issue SuccessFullly");
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
            con.Close();
            cmd = new SqlCommand("select E_PRICE from Equipment_tbl where E_NAME = '"+comboBox5.Text+"'",con);
            con.Open();
            int pricee = (int)cmd.ExecuteScalar();
            textBox5.Text = pricee.ToString();
            con.Close();


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            if (comboBox3.SelectedItem != null && comboBox3.SelectedItem != null)
            {
                con.Close();
                String EQ_NAME = comboBox3.SelectedItem.ToString();
                cmd = new SqlCommand("select EC_ID from Equipment_Category where EC_NAME = '" + EQ_NAME + "'", con);

                con.Open();
                object a = cmd.ExecuteScalar();
                int b = Convert.ToInt32(a);
                cmd = new SqlCommand("select E_NAME from Equipment_tbl where C_ID = " + b + "", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox5.Items.Add(dr.GetString(0));
                }
                dr.Close();
            }
            con.Close();
        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(textBox6.Text);
            int price = int.Parse(textBox5.Text);
            total = qty * price;
            textBox7.Text = total.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Close();
            int cat = (int)comboBox3.SelectedIndex + 1;
            cmd = new SqlCommand("select E_ID from Equipment_tbl where E_NAME = '" + comboBox5.Text + "'", con);
            con.Open();
            int name = (int)cmd.ExecuteScalar();
            con.Close();
            cmd = new SqlCommand("update order_tb set oec_id="+cat+",oe_id="+name+",oe_address='"+richTextBox1.Text+"',oe_price = "+textBox5.Text+",or_qty="+textBox6.Text+",ot_total="+textBox7.Text+" where o_id ="+textBox3.Text+" ",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            clearbox();
            MessageBox.Show("Order Update SuccessFully.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("select EC_ID from Equipment_Category where EC_ID = (select oec_id from order_tb where o_id = "+textBox3.Text+") ",con);
            con.Open();
            int a = (int)cmd.ExecuteScalar();
            a--;
            comboBox3.SelectedIndex= a;
            con.Close();
            cmd = new SqlCommand("select E_NAME from Equipment_tbl where E_ID = (select oec_id from order_tb where o_id = "+textBox3.Text+")", con);
            con.Open();
            string b = cmd.ExecuteScalar().ToString();
            comboBox5.Text = b;
            con.Close();
            cmd = new SqlCommand("select * from order_tb where o_id ="+textBox3.Text+"",con);
            SqlDataReader dr;
            con.Open();
            dr= cmd.ExecuteReader();
            if(dr.Read())
            {
                richTextBox1.Text = dr.GetString(3).ToString();
                textBox5.Text= dr.GetInt32(4).ToString();
                textBox6.Text = dr.GetInt32(5).ToString(); 
                textBox7.Text= dr.GetValue(6).ToString();
            }
            con.Close();
            dr.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("delete from order_tb where o_id ="+textBox3.Text+" ", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            clearbox();
            MessageBox.Show("Order Deleted SuccessFully.");
        }
    }
}
