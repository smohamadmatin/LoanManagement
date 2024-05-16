using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LoanManagement
{
    public partial class Form1 : Form
    {
        //public bool isopn;
        public Form1()
        {
            InitializeComponent();
        }
        /*public void loadform(object Form)
        {

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }*/

        private void label1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            UserControl2 userControl2 = new UserControl2();
            userControl2.Hide();
            //loadform(new FORMDASHBOARD());

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.Gray;

        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.White;
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.BackColor = Color.Gray;
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            label3.BackColor = Color.Gray;
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            label3.BackColor = Color.White;
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            label4.BackColor = Color.Gray;
        }

        private void label4_MouseUp(object sender, MouseEventArgs e)
        {
            label4.BackColor = Color.White;
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            label5.BackColor = Color.Gray;
        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            label5.BackColor = Color.White;
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            label6.BackColor = Color.Gray;
        }

        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            label6.BackColor = Color.White;
        }
        bool hello;
        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            //hello = FORMDASHBOARD.isopen
        }
    }
}
