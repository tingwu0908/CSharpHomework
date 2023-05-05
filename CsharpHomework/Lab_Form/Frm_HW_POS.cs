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
    public partial class Frm_HW_POS : Form
    {
        public Frm_HW_POS()
        {
            InitializeComponent();
        }

        string Order;  //點餐內容
        int totalPrice = 0;  //總金額
        int[] count = {0,0,0,0};   //各品項個數 0:咖啡 1:紅茶 2:奶茶 3:果汁

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            count[0]++;
            clickOrderButton(CafeMenu.咖啡Coffee);
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            count[1]++;
            clickOrderButton(CafeMenu.紅茶BlackTea);
        }

        

        private void btnMilkTea_Click(object sender, EventArgs e)
        {
            count[2]++;
            clickOrderButton(CafeMenu.奶茶MilkTea);
        }

        private void btnJuice_Click(object sender, EventArgs e)
        {
            count[3]++;
            clickOrderButton(CafeMenu.果汁Juice);
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            reset();
        }

        public enum CafeMenu
        {
            咖啡Coffee = 150,
            紅茶BlackTea = 130,
            奶茶MilkTea = 140,
            果汁Juice = 160
        }

        public void clickOrderButton(CafeMenu drink)
        {
            totalPrice += (int)drink;

            Order = string.Empty;

            if (count[0] > 0)
            {
                //Order = CafeMenu.咖啡Coffee + " ×" + count[0] + ", 共 NT$ " + (int)CafeMenu.咖啡Coffee * count[0] + " 元\r\n";
                Order = $"{CafeMenu.咖啡Coffee} × {count[0]}, 共 NT$ {(int)CafeMenu.咖啡Coffee * count[0]} 元\r\n";

            }
            if (count[1] > 0)
            {
                Order += $"{CafeMenu.紅茶BlackTea} × {(count)[1]}, 共 NT$ {(int)CafeMenu.紅茶BlackTea * count[1]} 元\r\n";
            }
            if (count[2] > 0)
            {
                Order += $"{CafeMenu.奶茶MilkTea} × {count[2]}, 共 NT$ {(int)CafeMenu.奶茶MilkTea * count[2]} 元\r\n";
            }
            if (count[3] > 0)
            {
                Order += $"{CafeMenu.果汁Juice} × {count[3]}, 共 NT$ {(int)CafeMenu.果汁Juice * count[3]} 元\r\n";
            }

            txtTotal.Text = $"NT$ {totalPrice}";
            txtOrder.Text = Order;

        }


        private void btnPayCash_Click(object sender, EventArgs e)
        {
            DialogResult result = 
                MessageBox.Show($"總金額: NT$ {totalPrice} 元", "確認付款", MessageBoxButtons.YesNo);
            
            if(result == DialogResult.Yes)
            {
                reset();
            }
        }

        private void btnPayCard_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show($"總金額: NT$ {totalPrice} 元\r\n折扣後金額: NT$ {totalPrice*0.9} 元", "確認付款", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                reset();
            }
        }

        void reset()
        {
            Order = string.Empty;
            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            totalPrice = 0;
            txtOrder.Text = "尚未點餐";
            txtTotal.Text = "NT$ 0";
        }
    }
}
