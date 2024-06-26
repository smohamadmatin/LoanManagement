﻿using System;
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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
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

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {

            textBox1.BringToFront();

        }

        private void UserControl2_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(textBox2.Text, NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out var number))
            {

                // number is now of type long
                number += number;
                textBox2.Text = long.Parse(textBox2.Text.Replace(",", "")).ToString("n0");
                textBox2.SelectionStart = textBox2.Text.Length;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(textBox3.Text, NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out var number))
            {

                // number is now of type long
                number += number;
                textBox3.Text = long.Parse(textBox3.Text.Replace(",", "")).ToString("n0");
                textBox3.SelectionStart = textBox3.Text.Length;

            }
        }
    }
}