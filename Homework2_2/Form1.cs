using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2_2
{
    
    public partial class Form1 : Form
    {
        public static Stack<Form> formStack = new Stack<Form>();

        public class SubForm : Form
        {
            
            public SubForm()
            {
                formStack.Push(this);
                Button btn = new Button();
                btn.Location = new Point(20, 20);
                Controls.Add(btn);
                switch ( formStack.Count  )
                {
                    case 2:
                        btn.Text = "두 번째"; 
                        break;
                    case 3:
                        btn.Text = "세 번째";
                        break;
                    default:
                        break;
                }
                btn.Click += new EventHandler(Clicked_Button);
                this.FormClosing += new FormClosingEventHandler(Delete_Button);
            }
            private void Clicked_Button(object sender, EventArgs e)
            {
                if(formStack.Count < 3) { 
                    SubForm sub = new SubForm();
                    sub.Visible = true;
                }
                else
                {
                    MessageBox.Show("더 이상 생성할수 없습니다.", "No");
                }
            }
            private void Delete_Button(object sender, FormClosingEventArgs e)
            {
                formStack.Pop();
            }
        }
        

        public Form1()
        {
            formStack.Push(this);
            InitializeComponent();
        }


        private void 두번째폼열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubForm sub = new SubForm();
            sub.Visible = true;
        }

        private void 폼제거ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form x = formStack.Peek();
            if(formStack.Count != 1 ) x.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
