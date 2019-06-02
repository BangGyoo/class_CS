using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCheckBox
{
    public partial class Form1 : Form
    {
        //public CheckBox ch1;
        //public CheckBox ch2;
        //public CheckBox ch3;
        public RadioButton ch1;
        public RadioButton ch2;
        public RadioButton ch3;
        GroupBox gb;

        public Form1()
        {
            InitializeComponent();
            ch1 = new RadioButton();
            ch1.Text = "감자";
            ch2 = new RadioButton();
            ch2.Text = "고구마";
            ch3 = new RadioButton() {
                Text = "토마토"
            };
            gb = new GroupBox();
            gb.Text = "test";
            gb.Controls.Add(ch3);

            ch1.Location = new Point(10, 10);
            ch2.Location = new Point(10, 30);
            gb.Location = new Point(400, 50);
            ch3.Location = new Point(20, 20);

            Button btn = new Button()
            {
                Text = "click",
                Location = new Point(120, 50),
  
            };
            btn.Click += new EventHandler(Click_Button);

            Controls.Add(ch1);
            Controls.Add(ch2);
            Controls.Add(gb);
            Controls.Add(btn);
        }
        private void Click_Button(object sender,EventArgs e)
        {
            string str = "지금 들어있는 것은 \n";
            if (ch1.Checked == true) str += ch1.Text + "\n";
            if (ch2.Checked == true) str += ch2.Text + "\n";
            if (ch3.Checked == true) str += ch3.Text + "\n";

            MessageBox.Show(str, "title",MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }
    }
}
