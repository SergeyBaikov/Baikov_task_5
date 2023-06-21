using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button18_Click(object sender, EventArgs e)
        {
            you = Convert.ToDouble(result);
            label1.Text = you.ToString();
            if (action == "")
            {
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (textBox1.Text[i] == '+' || textBox1.Text[i] == '-' || textBox1.Text[i] == '*' || textBox1.Text[i] == '/')
                    {
                        action = textBox1.Text[i].ToString();
                        string[] str = textBox1.Text.Split(Convert.ToChar(action));
                        if (action == "+")
                            result = (Convert.ToDouble(str[0]) + Convert.ToDouble(str[1])).ToString();
                        if (action == "-")
                            result = (Convert.ToDouble(str[0]) - Convert.ToDouble(str[1])).ToString();
                        if (action == "*")
                            result = (Convert.ToDouble(str[0]) * Convert.ToDouble(str[1])).ToString();
                        if (action == "/")
                            result = (Convert.ToDouble(str[0]) / Convert.ToDouble(str[1])).ToString();
                    }
                }
            }
            else
            {
                if (action == "+")
                    result = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(number1)).ToString();
                if (action == "-")
                    result = (Convert.ToDouble(number1) - Convert.ToDouble(textBox1.Text)).ToString();
                if (action == "*")
                    result = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(number1)).ToString();
                if (action == "/")
                    result = (Convert.ToDouble(number1) / Convert.ToDouble(textBox1.Text)).ToString();
            }
            action = "";
            textBox1.Text = result;
        }


        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length - 1 == 0)
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = null;
            label1.Text = "0";
            number1 = null;
            you = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Button b =(Button) sender;
            if(textBox1.Text=="0")
            {
                textBox1.Text = "";

            }
            if (textBox1.Text.IndexOf(",") > 0 && b.Text==",") {
            
                return;
            }
            textBox1.Text = textBox1.Text+b.Text;



        }
        string action="";
        string number1;
        string result;
        double you;
        private void button14_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            action = b.Text;
            number1 = textBox1.Text;
            textBox1.Text = "";
            

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                button18.PerformClick();
            }
        }
    }
}
