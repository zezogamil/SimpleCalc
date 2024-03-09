using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1_Calculator
{
    public partial class Form1 : Form
    {
        Calculator calc= new Calculator();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            calc.num1 = Convert.ToDouble(tbNum1.Text);  
            calc.num2 = Convert.ToDouble(tbNum2.Text);

            double res = calc.add();

            lblResult.Text = res.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            calc.num1 = Convert.ToDouble(tbNum1.Text);
            calc.num2 = Convert.ToDouble(tbNum2.Text);

            double res = calc.subtraction();

            lblResult.Text = res.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            calc.num1 = Convert.ToDouble(tbNum1.Text);
            calc.num2 = Convert.ToDouble(tbNum2.Text);

            double res = calc.divide();

            lblResult.Text = res.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            calc.num1 = Convert.ToDouble(tbNum1.Text);
            calc.num2 = Convert.ToDouble(tbNum2.Text);

            double res = calc.multiply();

            lblResult.Text = res.ToString();
        }
    }
}
