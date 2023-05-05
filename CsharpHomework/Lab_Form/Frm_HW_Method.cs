using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_HW_Method : Form
    {
        int[] intArr = new int[10];
        string[] strArr = { "Apple Pie", "國王布丁", ":D", "Cake", "Donald Duck",
                                             "螢光魷", "Coke", "Utopia", "Banana", "美學" };
        public Frm_HW_Method()
        {
            InitializeComponent();
            Random ran = new Random();
            Methods ini = new Methods();
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = ran.Next(0,100);
            }
            labIntArray.Text = "整數陣列: { " + ini.PrintArray(intArr) + " }";
            labStrArray.Text = "字串陣列: { " + ini.PrintArray(strArr) + " }";
        }

        private void btnOddEven_Click(object sender, EventArgs e)
        {
            int Num;
            Methods m = new Methods();
            if (!(int.TryParse(txtNum.Text, out Num)))
            {
                MessageBox.Show("請輸入數字");
                txtNum.Clear();
                txtNum.Focus();
            }
            else labShow.Text = (m.IsEven(Num))? $"輸入的數字「{Num}」為偶數": $"輸入的數字「{Num}」為奇數";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
        }

        private void btnOdd_Click(object sender, EventArgs e)
        {
            int Even = 0, Odd = 0;
            Methods m = new Methods();
            m.NumofOdd(intArr, ref Even, ref Odd);
            labShow.Text = $"{labIntArray.Text}\n當中有{Odd}個奇數、{Even}個偶數";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            labShow.Text = $"{labIntArray.Text} 的數字總和為{m.intArrSum(intArr)}";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            labShow.Text = $"{labIntArray.Text} 的最大值為{m.intArrMax(intArr)}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            labShow.Text = $"{labIntArray.Text} 的最小值為{m.intArrMin(intArr)}";
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            labShow.Text = $"{labIntArray.Text} 的最小值為{m.intArrMin(intArr)}\n最大值為{m.intArrMax(intArr)}";
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = 1000;
            labShow.Text = $"int a = {a}, int b = {b}\n";
            Methods m = new Methods();
            m.Swap(ref a, ref b);
            labShow.Text += "交換後\n";
            labShow.Text += $"int a = {a}, int b = {b}";

        }

        private void btnLongest_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            int length = 0;
            labShow.Text = $"{labStrArray.Text} \n中最長的名字為{m.LongestName(strArr, ref length)}\n長度為{length}字元";
        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            string stringContains = "";
            labShow.Text = $"{labStrArray.Text} \n其中有C或c的名字共有{m.ContainsCorc(strArr,ref stringContains)}個，如下：\n{stringContains}";
        }

        int[,] matrix1 = new int[10, 10];
        
        private void btn1001_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            m.A1001(ref  matrix1);
            labShow.Text = m.PrintMatrix(matrix1);
        }

        private void btn0110_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            m.A0110(ref matrix1);
            labShow.Text = m.PrintMatrix(matrix1);
        }

        private void btn1010_Click(object sender, EventArgs e)
        {
            Methods m = new Methods();
            m.A1010(ref matrix1);
            labShow.Text = m.PrintMatrix(matrix1);
        }




    }
}
