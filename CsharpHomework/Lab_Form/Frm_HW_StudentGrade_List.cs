using System;
using System.Collections;
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
    public partial class Frm_HW_StudentGrade_List : Form
    {
        public Frm_HW_StudentGrade_List()
        {
            InitializeComponent();
        }
        List<Student> stList = new List<Student>();
        void ShowList()
        {
            labShow.Text = "姓名   國文  英文  數學  總分   平均     最低      最高\r\n";
            foreach (Student st in stList)
            {
                labShow.Text += ($"{st.Name,-5}  {st.MandarinScore,4}  {st.EnglishScore,4}  {st.MathScore,4}  " +
                    $"{st.TtlScore,4}   {st.AvgScore,4} {st.HighestSub,7} {st.LowestSub,7}\r\n");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請輸入姓名");
                txtName.Focus();
            }
            else if (double.TryParse(txtMand.Text, out st.MandarinScore) && (double.TryParse(txtMath.Text, out st.MathScore))
                && (double.TryParse(txtEng.Text, out st.EnglishScore)) &&
                st.checkScore(st.MandarinScore) && st.checkScore(st.MathScore) && st.checkScore(st.EnglishScore))
            {
                st.Name = txtName.Text;
                st.SetStacScore();
                st.HL();
                stList.Add(st);
                ShowList();
            }
            else
            {
                MessageBox.Show("請輸入正確分數");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請輸入姓名");
                txtName.Focus();
            }
            else if (double.TryParse(txtMand.Text, out st.MandarinScore) && (double.TryParse(txtMath.Text, out st.MathScore))
                && (double.TryParse(txtEng.Text, out st.EnglishScore)) &&
                st.checkScore(st.MandarinScore) && st.checkScore(st.MathScore) && st.checkScore(st.EnglishScore))
            {
                st.Name = txtName.Text;
                st.SetStacScore();
                st.HL();
                stList.Insert(0,st);
                ShowList();
            }
            else
            {
                MessageBox.Show("請輸入正確分數");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (stList.Count > 0)
            {
                stList.RemoveAt(0);
                ShowList();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            stList.Clear();
            labShow.Text = "姓名   國文  英文  數學  總分   平均     最低      最高\r\n";
            labStat.Text = "統計資料";
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                }
            }
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            if (stList.Count > 0)
            {

                foreach (Control item in this.Controls)
                {
                    if ((item is Button) && (item.Name != "btnClear"))
                    {
                        item.Enabled = false;
                    }
                }
                ListScore ls = new ListScore();
                ls.ScoreCalculate(stList);

                labStat.Text = $"{"總分　",-4}{ls.sum[0],4}  {ls.sum[1],4}  {ls.sum[2],4}\r\n" +
                                           $"{"平均　",-4}{Math.Round(ls.avg[0], 1),4}  {Math.Round(ls.avg[1], 1),4}  {Math.Round(ls.avg[2], 1),4}\r\n" +
                                           $"{"最高分",-4}{ls.max[0],4}  {ls.max[1],4}  {ls.max[2],4}\r\n" +
                                           $"{"最低分",-4}{ls.min[0],4}  {ls.min[1],4}  {ls.min[2],4}\r\n";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int ranBig, ranSmall;
            List<Student> filter = new List<Student>();
            if (int.TryParse(txtRan1.Text,out ranSmall) && int.TryParse(txtRan2.Text,out ranBig))
            {
                int temp = ranBig;
                if(ranBig < ranSmall)
                {
                    ranBig = ranSmall;
                    ranSmall = temp;
                }
                foreach(Student st in stList)
                {
                    if(st.MandarinScore >=ranSmall &&st.MandarinScore <= ranBig)
                    {
                        filter.Add(st);
                    }
                }
                labShow.Text = "姓名   國文  英文  數學  總分   平均     最低      最高\r\n";
                foreach (Student st in filter)
                {
                    labShow.Text += ($"{st.Name,-5}  {st.MandarinScore,4}  {st.EnglishScore,4}  {st.MathScore,4}  " +
                        $"{st.TtlScore,4}   {st.AvgScore,4} {st.HighestSub,7} {st.LowestSub,7}\r\n");
                }
            }
            else
            {
                MessageBox.Show("請輸入正確範圍");
            }
        }
    }
}
