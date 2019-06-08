using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void leftShift_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(Origin.Text);
            int shift = int.Parse(Change.Text);

            int result = (temp << shift);

            MessageBox.Show(Origin.Text + "를 " + Change.Text + "bit shift left 합니다.");

            Orig_2.Text = Convert.ToString(temp, 2);
            Orig_10.Text = Convert.ToString(temp, 10);
            Orig_16.Text = Convert.ToString(temp, 16);
            Change_2.Text = Convert.ToString(result, 2);
            Change_10.Text = Convert.ToString(result, 10);
            Change_16.Text = Convert.ToString(result, 16);

        }

        private void rightShift_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(Origin.Text);
            int shift = int.Parse(Change.Text);

            int result = (temp >> shift);

            MessageBox.Show(Origin.Text + "를 " + Change.Text + "bit shift right 합니다.");

            Orig_2.Text = Convert.ToString(temp, 2);
            Orig_10.Text = Convert.ToString(temp, 10);
            Orig_16.Text = Convert.ToString(temp, 16);
            Change_2.Text = Convert.ToString(result, 2);
            Change_10.Text = Convert.ToString(result, 10);
            Change_16.Text = Convert.ToString(result, 16);
        }
    }
}
