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
    public partial class Frm_HW_Loan : Form
    {
        public Frm_HW_Loan()
        {
            InitializeComponent();
        }

        double 貸款金額, 年利率, 貸款期數, 每期應繳金額, 全部利息, 平均攤還率 = 0;


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(checkNum(txt貸款金額.Text, txt年利率.Text, txt貸款期數.Text))
            {
                //平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
                double 月利率 = 年利率 / 1200;
                平均攤還率 = (Math.Pow((1 + 月利率), 貸款期數) * 月利率) / ((Math.Pow((1 + 月利率), 貸款期數)) - 1);
                //平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率
                每期應繳金額 = 貸款金額 * 平均攤還率;
                全部利息 = 每期應繳金額 * 貸款期數 - 貸款金額;


                txt每期金額.Text = Math.Round(每期應繳金額).ToString("#,0");
                txt全部利息.Text = Math.Round(全部利息).ToString("#,0");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reset();
        }

        bool checkNum(string 貸款金額, string 年利率, string 貸款期數)
        {
            bool result = double.TryParse(貸款金額, out this.貸款金額) &&
                double.TryParse(年利率, out this.年利率) &&
                double.TryParse(貸款期數, out this.貸款期數);

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
            txt貸款金額.Text = String.Empty;
            txt年利率.Text = String.Empty;
            txt貸款期數.Text = String.Empty;
            txt每期金額.Text = String.Empty;
            txt全部利息.Text = String.Empty;
            平均攤還率 = 0;
        }
    }
}
