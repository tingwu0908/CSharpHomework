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
    public partial class Frm_HW_ForDoWhile : Form
    {
        public Frm_HW_ForDoWhile()
        {
            InitializeComponent();
        }

        Methods m = new Methods();
        private void btnBinary_Click(object sender, EventArgs e)
        {
            int DecNum;
            if (!(int.TryParse(txtDec.Text, out DecNum)))
            {
                MessageBox.Show("請輸入數字");
                txtDec.Clear();
                txtDec.Focus();
            }
            else
            {
                labShow.Text = m.BinaryConvert(DecNum);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
        }

        private void btnTree_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(txtRows.Text, out int rows)))
            {
                MessageBox.Show("請輸入數字");
                txtRows.Clear();
                txtRows.Focus();
            }
            else
            {
                labShow.Text = m.XmasTree(rows);
            }
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            labShow.Text = m.Print99();
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            labShow.Text = m.LotteryRandom(); 
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int from, to, step;
            if ((int.TryParse(txtFrom.Text, out from)) && (int.TryParse(txtTo.Text, out to)) &&
                (int.TryParse(txtStep.Text, out step)))
            {
                labShow.Text = $"{from} 到 {to} 相隔 {step - 1}\n加總為 {m.ForSum(from, to, step)}";
            }
            else MessageBox.Show("請輸入數值");
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int from, to, step;
            if ((int.TryParse(txtFrom.Text, out from)) && (int.TryParse(txtTo.Text, out to)) &&
                (int.TryParse(txtStep.Text, out step)))
            {
                labShow.Text = $"{from} 到 {to} 相隔 {step - 1}\n加總為 {m.WhileSum(from, to, step)}";
            }
            else MessageBox.Show("請輸入數值");
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int from, to, step;
            if ((int.TryParse(txtFrom.Text, out from)) && (int.TryParse(txtTo.Text, out to)) &&
                (int.TryParse(txtStep.Text, out step)))
            {
                labShow.Text = $"{from} 到 {to} 相隔 {step - 1}\n加總為 {m.DoSum(from, to, step)}";
            }
            else MessageBox.Show("請輸入數值");
        }
    }
}
