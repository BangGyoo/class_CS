using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form1 : Form
    {

        enum Oper
        {
            NON,
            SUM,
            MIN,
            MUT,
            DIV
        }
        private float num1 = 0;
        private Oper oper = Oper.NON;
        private bool inputMode = true;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox2.TextAlign = HorizontalAlignment.Center;

        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            switch (oper)
            {
                case (Oper.NON):

                    break;
                case (Oper.SUM):
                    textBox1.Text = (num1 + float.Parse(textBox1.Text)).ToString();
                    inputMode = false;
                    break;
                case (Oper.MIN):
                    textBox1.Text = (num1 - float.Parse(textBox1.Text)).ToString();
                    inputMode = false;
                    break;
                case (Oper.DIV):
                    textBox1.Text = (num1 / float.Parse(textBox1.Text)).ToString();
                    inputMode = false;
                    break;
                case (Oper.MUT):
                    textBox1.Text = (num1 * float.Parse(textBox1.Text)).ToString();
                    inputMode = false;
                    break;
            }
            oper = Oper.NON;
            num1 = 0.0f;
        }

        private string returnOper(Oper op)
        {
            switch (op)
            {
                case (Oper.SUM):
                    return "+";
                case (Oper.MIN):
                    return "-";
                case (Oper.DIV):
                    return "/";
                case (Oper.MUT):
                    return "*";
                default:
                    return "";
            }


        }

        private void saveOperator(Oper op)
        {

            switch (oper)
            {
                case (Oper.NON):
                    if (textBox1.Text != "0")
                    {
                        num1 = float.Parse(textBox1.Text);
                        //textBox1.Text = "0";
                    }
                    break;
                case (Oper.SUM):
                    if (num1 != 0)
                    {
                        num1 += float.Parse(textBox1.Text);
                        textBox1.Text = num1.ToString();
                    }
                    else if (textBox1.Text != "0")
                    {
                        num1 = float.Parse(textBox1.Text);
                        //textBox1.Text = "0";
                    }
                    
                    break;
                case (Oper.MIN):
                    if (num1 != 0)
                    {
                        num1 -= float.Parse(textBox1.Text);
                        textBox1.Text = num1.ToString();
                    }
                    else if (textBox1.Text != "0")
                    {
                        num1 = float.Parse(textBox1.Text);
                        //textBox1.Text = "0";
                    }
                    
                    break;
                case (Oper.DIV):
                    if (num1 != 0)
                    {
                        num1 /= float.Parse(textBox1.Text);
                        textBox1.Text = num1.ToString();
                    }
                    else if (textBox1.Text != "0")
                    {
                        num1 = float.Parse(textBox1.Text);
                        //textBox1.Text = "0";
                    }
                    
                    break;
                case (Oper.MUT):
                    if (num1 != 0)
                    {
                        num1 *= float.Parse(textBox1.Text);
                        textBox1.Text = num1.ToString();
                    }
                    else if (textBox1.Text != "0")
                    {
                        num1 = float.Parse(textBox1.Text);
                        //textBox1.Text = "0";
                    }
                    
                    break;
                
            }
            textBox2.Text = returnOper(op);
            inputMode = false;
            oper = op;
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            saveOperator(Oper.DIV);
        }

        private void mutBtn_Click(object sender, EventArgs e)
        {
            saveOperator(Oper.MUT);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            saveOperator(Oper.MIN);
        }

        private void plsBtn_Click(object sender, EventArgs e)
        {
            saveOperator(Oper.SUM);
        }

        private void invBtn_Click(object sender, EventArgs e)
        {
            float arg = float.Parse(textBox1.Text);
            textBox1.Text = (1 / arg).ToString();
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            btnClick(".");
        }
        private void btnClick(string num)
        {

            //if (oper != Oper.NON)
            //{
            //    textBox1.Text = "0";
            //    //oper = Oper.NON;
            //}
            if (inputMode == false)
            {
                textBox1.Text = "0";
                inputMode = true;
            }

            if (textBox1.Text != "0")
                textBox1.AppendText(num);
            else textBox1.Text = num;



        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnClick("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnClick("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnClick("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnClick("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnClick("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnClick("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnClick("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnClick("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnClick("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btnClick("9");
        }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Clear();
            num1 = 0.0f;
            Oper oper = Oper.NON;

        }
    }
}
