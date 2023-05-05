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
    public partial class Frm_HW_Main : Form
    {
        public Frm_HW_Main()
        {
            InitializeComponent();
        }

        Form formNow;
        private void ShowForm(Form frm)
        {
            if (formNow != null)
            {
                formNow.Close();
            }
            formNow = frm;
            frm.TopLevel = false;
            frm.Parent = splitContainer2.Panel2;
            frm.Show();
        }

        private void labTitle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MSIT150 06 吳宜庭");
        }

        private void btn01Hello_Click(object sender, EventArgs e)
        {
            Frm_HW_HelloForm frm = new Frm_HW_HelloForm();
            ShowForm(frm);
        }

        private void btn02Loan_Click(object sender, EventArgs e)
        {
            Frm_HW_Loan frm = new Frm_HW_Loan();
            ShowForm(frm);
        }

        private void btn03POS_Click(object sender, EventArgs e)
        {
            Frm_HW_POS frm = new Frm_HW_POS();
            ShowForm(frm);
        }

        private void btn00Calculator_Click(object sender, EventArgs e)
        {
            Frm_HW_Calculator frm = new Frm_HW_Calculator();
            ShowForm(frm);
        }

        private void btnStudent1_Click(object sender, EventArgs e)
        {
            Frm_HW_Student_StructForm frm = new Frm_HW_Student_StructForm();
            ShowForm(frm);
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            Frm_HW_Method frm = new Frm_HW_Method();
            ShowForm(frm);
        }

        private void btn00ForDoWhile_Click(object sender, EventArgs e)
        {
            Frm_HW_ForDoWhile frm = new Frm_HW_ForDoWhile();
            ShowForm(frm);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Frm_HW_GuessNumber frm = new Frm_HW_GuessNumber();
            ShowForm(frm);
        }
    }
}
