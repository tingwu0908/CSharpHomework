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
    public partial class Frm_HW_GuessNumber : Form
    {
        public int num;

        public Frm_HW_GuessNumber()
        {
            InitializeComponent();
            Random rdm = new Random();
            num = rdm.Next(1,100);
        }

        public void ChangeLabel(string str)
        {
            labTitle.Text = str;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Frm_HW_GuessNumber_c childForm = new Frm_HW_GuessNumber_c();
            childForm.Owner = this;
            childForm.ShowDialog();
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The answer is : " + num);
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            num = rdm.Next(1, 100);
            ChangeLabel("Please select a number \nbetween 1 and 100.");

        }
    }
}
