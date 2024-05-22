using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagement
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.BringToFront();
        }

        private void UserControl3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.BringToFront();
            }
            else
            {
                textBox1.BringToFront();
            }
        }


        private void UserControl3_Load_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.BringToFront();
            }
            else
            {
                textBox1.BringToFront();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(textBox1.Text, NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out var number))
            {

                // number is now of type long
                number += number;
                textBox1.Text = long.Parse(textBox1.Text.Replace(",", "")).ToString("n0");
                textBox1.SelectionStart = textBox1.Text.Length;

            }
        }
    }

}
