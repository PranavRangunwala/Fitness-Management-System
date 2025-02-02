using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMMM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem2.Image = Image.FromFile(@"C:\Users\RANGUNWALA\Downloads\rym_member_icons\gym icons and images\Name-48-50px\img3.jpg");
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEMEMBER DM = new DELETEMEMBER();
            DM.Show();
        }
        Boolean b = true;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem2.Image = Image.FromFile(@"C:\Users\RANGUNWALA\Downloads\rym_member_icons\gym icons and images\Name-48-50px\img3.jpg");

            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem2.Image = Image.FromFile(@"C:\Users\RANGUNWALA\Downloads\rym_member_icons\gym icons and images\Name-48-50px\img2.jpg");

            }
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDMEM NM = new ADDMEM();
            NM.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDSTAFF AF = new ADDSTAFF();
            AF.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EQUIPMENT E = new EQUIPMENT();
            E.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEARCH se = new SEARCH();
            se.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Will Close YOur Application. Contirm?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Wellcome Back","Wellcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout confirm?","Logout",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Login lg = new Login();
                lg.Show();
            }
        }

        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDCAT AC = new ADDCAT();
            AC.Show();


        }
    }
}
