using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace max_number_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brn1_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(txt1.Text);
            lbl1.Text = Convert.ToString(num);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int num3;
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);
            num3 = Convert.ToInt32(txt3.Text);
            
            if(num1<num2)
                {
                if(num2<num3)
                    {
                    lbl1.Text = Convert.ToString(num3);
                    }
                    else
                    {
                    lbl1.Text = Convert.ToString(num2);
                    }
                }
            else if(num1<num3)
                {
                lbl1.Text = Convert.ToString(num3);
                }
            else
                {
                lbl1.Text = Convert.ToString(num1);
                }
        }
    }
}
