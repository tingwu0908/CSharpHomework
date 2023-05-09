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
    public partial class Frm_HW_Student_StructForm : Form
    {
        public Frm_HW_Student_StructForm()
        {
            InitializeComponent();
        }

           Student st = new Student();
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請輸入姓名");
                txtName.Focus();
            }
            else if(double.TryParse(txtMand.Text, out st.MandarinScore)&&(double.TryParse(txtMath.Text, out st.MathScore))
                &&(double.TryParse(txtEng.Text, out st.EnglishScore))&&
                st.checkScore(st.MandarinScore) && st.checkScore(st.MathScore) && st.checkScore(st.EnglishScore))
            {
                MessageBox.Show("儲存成功!");
            }
            else 
            {
                MessageBox.Show("請輸入正確分數");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            labShow.Text = $"姓名：{txtName.Text}\n國文：{st.MandarinScore}分\n英文：{st.EnglishScore}分\n數學：{st.MathScore}分";
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            st.HL();
            labMixMax.Text = $"最高分科目及成績：{st.HighestSub}分\n最低分科目及成績：{st.LowestSub}分";
        }
    }
}
