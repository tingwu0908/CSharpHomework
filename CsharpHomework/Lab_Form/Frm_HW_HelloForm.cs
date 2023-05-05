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
    public partial class Frm_HW_HelloForm : Form
    {
        public Frm_HW_HelloForm()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string engname = txtEngname.Text;
            string sign = txtzsign.Text;
            string bloodtype = txtblood.Text;
            MessageBox.Show("Hello! 我是" + name + "，\n\r" + "英文名字是" + engname + "，\n\r" + "我的星座是" + sign + "，\n\r" + "我的血型是" + bloodtype + "型。");

        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string engname = txtEngname.Text;
            string sign = txtzsign.Text;
            string bloodtype = txtblood.Text;
            MessageBox.Show("Hi! 我是" + name + "，\n\r" + "英文名字是" + engname + "，\n\r" + "我的星座是" + sign + "，\n\r" + "我的血型是" + bloodtype + "型。");

        }
    }
}
