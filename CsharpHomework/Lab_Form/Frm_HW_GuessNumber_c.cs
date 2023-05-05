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
    public partial class Frm_HW_GuessNumber_c : Form
    {
        public Frm_HW_GuessNumber_c()
        {
            InitializeComponent();
        }

            int upper = 100;
            int lower = 1;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Frm_HW_GuessNumber parentForm = (Frm_HW_GuessNumber)this.Owner;
            int gnum;
            int num = parentForm.num;
            if (int.TryParse(txtGNum.Text, out gnum))
            {
                if(gnum == num)
                {
                    MessageBox.Show($"Congratulations!!! You got {num} !!!");
                    parentForm.ChangeLabel("Congratulations!!!");
                }
                else if( gnum >= upper || gnum <= lower)
                {
                    MessageBox.Show($"Please input a number between {lower} and {upper}.");
                }
                else if(gnum > num)
                {
                    upper = gnum;
                    parentForm.ChangeLabel($"Too Large!!!\nBetween {lower} and {upper}");
                }
                else if (gnum < num)
                {
                    lower = gnum;
                    parentForm.ChangeLabel($"Too Small!!!\nBetween {lower} and {upper}");
                }
            }
            else MessageBox.Show("Please guess a number!!!");
            

        }
    }
}
