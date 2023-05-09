using Lab_Form.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Lab_Form
{
    public partial class Frm_HW_PictureViewer : Form
    {
        public Frm_HW_PictureViewer()
        {
            InitializeComponent();
        }

        private void ShowPict(string img)
        {
            Frm_HW_PictureShow showPic = new Frm_HW_PictureShow(img);
            showPic.Show();
        }

        private void p1_Click(object sender, EventArgs e)
        {
            label1.Text = p1.Name;
            ShowPict(this.Name);
        }
    }
}
