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

        private void button1_Click(object sender, EventArgs e)
        {
            bool x;
            if (x = true)
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
            }
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
