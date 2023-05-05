using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_HW_Calculator : Form
    {
        public Frm_HW_Calculator()
        {
            InitializeComponent();
        }

        double num1, num2, ans = 0;

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (checkNum(txtNum1.Text,txtNum2.Text))
            {
                ans = num1 + num2;
                txtAns.Text = ans.ToString();
            }
            
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (checkNum(txtNum1.Text, txtNum2.Text))
            {
                ans = num1 - num2;
                txtAns.Text = ans.ToString();
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {

            if (checkNum(txtNum1.Text, txtNum2.Text))
            {
                ans = num1 * num2;
                txtAns.Text = ans.ToString();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            if (checkNum(txtNum1.Text, txtNum2.Text))
            {
                ans = num1 / num2;
                txtAns.Text = ans.ToString();
            }
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        bool checkNum(string num1, string num2)
        {
            bool result = double.TryParse(num1, out this.num1) &&
                double.TryParse(num2, out this.num2);
            if (!result)
            {
                MessageBox.Show("請輸入數字");
                reset();
                return false;
            }
            else return true;
        }

        void reset()
        {
            num1 = 0;
            num2 = 0;
            ans = 0;
            txtNum1.Text = String.Empty;
            txtNum2.Text = String.Empty;
            txtAns.Text = ans.ToString();
        }

    }
}
