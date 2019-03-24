using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        private int btn2_loop = 1;
        private int btn3_loop = 1;
        private const int MARGIN = 5;
        private int elapsedTime = 0;
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("버튼들을 지울까여?");
            FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }    
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            //if (elapsedTime == 4)
            // {
            //     if (MessageBox.Show("470초 경과 했습니다.", Text,
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            //    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //     {
            //         Application.Exit();
            //     }
            // }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                Button btn = new Button();
                btn.Text = "동적생성" + i;
                btn.Text += "번째";
                btn.Width = 100;
                btn.Height = 20;
                Controls.Add(btn);
                btn.Location = new Point(15, 50 + i * (20 + MARGIN));
                btn.Visible = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "동적생성" + btn2_loop;
            btn.Text += "번째";
            btn.Width = 100;
            btn.Height = 20;

            Controls.Add(btn);
            btn.Location = new Point(150, 50 + btn2_loop * (20 + MARGIN));
            btn.Visible = true;
            btn2_loop++;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "동적생성" + btn3_loop;
            btn.Text += "번째";
            btn.Width = 100;
            btn.Height = 20;

            Controls.Add(btn);
            btn.Location = new Point(300, 50 + btn3_loop * (20 + MARGIN));
            btn.Visible = true;
            btn.Click += new EventHandler(button3_Click);
            btn3_loop++;
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("버튼 삭제 할까요?", Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.No)
            {
                e.Cancel = true;

            }

            else
            {
                Controls.Clear();
                MessageBox.Show((int)(elapsedTime * 0.1) + "초 경과 했습니다.");
               
                e.Cancel = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
