using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LoanManagement
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

            bool x;
        private void button1_Click(object sender, EventArgs e)
        {
            /*if (x = true)
            {

                button13.FlatAppearance.BorderSize = 50;
                button13.FlatStyle = FlatStyle.Standard;
                button13.FlatAppearance.BorderColor = Color.Blue;
                x = false;
            }
            else
            {
                button13.FlatAppearance.BorderSize = 0;
                button13.FlatStyle = FlatStyle.Flat;
                x = true;
            }*/
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tabControl1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            label1.Select();
        }
    }
}
