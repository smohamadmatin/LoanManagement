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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
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
