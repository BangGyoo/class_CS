using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        public partial class CustomForm : Form
        {


            static int FormCnt = 0;
            static CustomForm[] forms;

            public void CreateFormClicked(object sender, EventArgs e)
            {
                if (FormCnt == 1)
                {
                    FormCnt++;
                    forms[1] = new CustomForm("두번째");
                    forms[1].Show();
                }
                else if (FormCnt == 2)
                {
                    FormCnt++;
                    forms[2] = new CustomForm("세번째");
                    forms[2].Show();
                }
                else
                {
                    MessageBox.Show("마지막 줄의 버튼입니다.", "다음 줄 테스트");
                }
            }
            public void DeleteFormClicked(object sender, EventArgs e)
            {
                if (FormCnt <= 1) MessageBox.Show("모두 지웠습니다.", "그만지워");
                else
                {
                    forms[FormCnt-1].Close();
                }
            }
            

            public CustomForm()
            {
                FormCnt++;

                forms = new CustomForm[3];
                forms[0] = this;
                
                

                this.Text = "첫번째 폼";
                MenuStrip mainMenu = new MenuStrip();
                ToolStripMenuItem open = new ToolStripMenuItem();
                open.Text = "폼 생성";
                ToolStripMenuItem nextOpen = new ToolStripMenuItem();
                nextOpen.Text = "두번째 폼 열기";
                ToolStripMenuItem close = new ToolStripMenuItem();
                close.Text = "폼 제거";

                nextOpen.Click += new EventHandler(CreateFormClicked);
                close.Click += new EventHandler(DeleteFormClicked);
                open.DropDownItems.Add(nextOpen);
                mainMenu.Items.Add(open);
                mainMenu.Items.Add(close);

                Controls.Add(mainMenu);
                
            }
            public CustomForm(String title)
            {
                this.Text = title + " 폼";
                Button btn = new Button();
                btn.Text = title + " 바";
                btn.Location = new Point(100, 50);
                btn.Click += new EventHandler(CreateFormClicked);
                Controls.Add(btn);
                FormClosing += new FormClosingEventHandler(FormClosedEventHandler);
            }
            void FormClosedEventHandler(object sender,EventArgs e)
            {
                FormCnt--;
            }

        }


        public Form1()
        {
           
            InitializeComponent();
            IsMdiContainer = true;
            CustomForm form = new CustomForm();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
