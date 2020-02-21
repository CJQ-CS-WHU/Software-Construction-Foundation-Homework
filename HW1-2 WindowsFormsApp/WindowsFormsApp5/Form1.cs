using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Calculate : Form
    {
        double x = 0;
        double y = 1;
        char ope = ' ';
        double r = 1;
        bool flag = true;
        public Calculate()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (num1.Text.Length == 0 || num2.Text.Length == 0)
            {
                messageBox.Text = "Please enter number .";
                flag = false;
            }
            switch (ope)
            {
                case '+': r = x + y; flag = true; break;
                case '-': r = x - y; flag = true; break;
                case '*': r = x * y; flag = true; break;
                case '/':
                    {
                        if (y == 0)
                        {
                            messageBox.Text = "Divided by zero!";
                            flag = false;
                        }
                        else
                            r = x / y;
                    }
                    break;
            }
            if (flag == true)
            {
                result.Text = r.ToString();
                messageBox.Text = "Result is right.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void num1_TextChanged(object sender, EventArgs e)
        {
            try {
                if (messageBox.Text.Length == 0)
                    messageBox.Text = "Please enter first number!";
                else
                {
                    x = double.Parse(num1.Text);
                    messageBox.Text = "Successfully enter!";
                }
            }
            catch (OverflowException)
            {
                messageBox.Text = "Error: overflow.";
            }
        }

        private void num2_TextChanged(object sender, EventArgs e)
        {
            try {
                if (num2.Text.Length == 0)
                    messageBox.Text = "Please enter second number! ";
                else
                {
                    y = double.Parse(num2.Text);
                    messageBox.Text = "Successfully enter!";
                }
            }
            catch (OverflowException)
            {
                messageBox.Text = "Error: overflow.";
            }
        }
    
        private void Calculate_Load(object sender, EventArgs e)
        {

        } 

        private void op_SelectedIndexChanged(object sender, EventArgs e)
        {
                ope = char.Parse(op.SelectedItem.ToString());
                messageBox.Text = "Successfully enter!";
        
        }
    }
}
