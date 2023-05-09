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

namespace Lab_Form
{
    public partial class Frm_HW_PictureShow : Form
    {

        public Frm_HW_PictureShow()
        {
            InitializeComponent();
            picShow.Image = Properties.Resources.onigiri_ikura;
        }
        public Frm_HW_PictureShow(string pic)
        {
            InitializeComponent();
            //picShow.Image = Properties.Resources.pic;
        }

    }
}
