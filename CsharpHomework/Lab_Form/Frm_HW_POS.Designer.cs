namespace Lab_Form
{
    partial class Frm_HW_POS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HW_POS));
            this.GBMenu = new System.Windows.Forms.GroupBox();
            this.btnJuice = new System.Windows.Forms.Button();
            this.btnMilkTea = new System.Windows.Forms.Button();
            this.btnTea = new System.Windows.Forms.Button();
            this.btnCoffee = new System.Windows.Forms.Button();
            this.GBOrder = new System.Windows.Forms.GroupBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.GBPrice = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.GBPayment = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPayCard = new System.Windows.Forms.Button();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.GBMenu.SuspendLayout();
            this.GBOrder.SuspendLayout();
            this.GBPrice.SuspendLayout();
            this.GBPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBMenu
            // 
            this.GBMenu.Controls.Add(this.btnJuice);
            this.GBMenu.Controls.Add(this.btnMilkTea);
            this.GBMenu.Controls.Add(this.btnTea);
            this.GBMenu.Controls.Add(this.btnCoffee);
            this.GBMenu.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GBMenu.Location = new System.Drawing.Point(19, 17);
            this.GBMenu.Name = "GBMenu";
            this.GBMenu.Size = new System.Drawing.Size(339, 366);
            this.GBMenu.TabIndex = 0;
            this.GBMenu.TabStop = false;
            this.GBMenu.Text = "菜單Menu";
            // 
            // btnJuice
            // 
            this.btnJuice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJuice.BackColor = System.Drawing.Color.Beige;
            this.btnJuice.Image = ((System.Drawing.Image)(resources.GetObject("btnJuice.Image")));
            this.btnJuice.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJuice.Location = new System.Drawing.Point(173, 199);
            this.btnJuice.Name = "btnJuice";
            this.btnJuice.Size = new System.Drawing.Size(158, 154);
            this.btnJuice.TabIndex = 3;
            this.btnJuice.Text = "果汁 $160\r\nJuice";
            this.btnJuice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJuice.UseVisualStyleBackColor = false;
            this.btnJuice.Click += new System.EventHandler(this.btnJuice_Click);
            // 
            // btnMilkTea
            // 
            this.btnMilkTea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMilkTea.BackColor = System.Drawing.Color.Beige;
            this.btnMilkTea.Image = ((System.Drawing.Image)(resources.GetObject("btnMilkTea.Image")));
            this.btnMilkTea.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMilkTea.Location = new System.Drawing.Point(9, 199);
            this.btnMilkTea.Name = "btnMilkTea";
            this.btnMilkTea.Size = new System.Drawing.Size(158, 154);
            this.btnMilkTea.TabIndex = 2;
            this.btnMilkTea.Text = "奶茶 $140\r\nMilk Tea";
            this.btnMilkTea.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMilkTea.UseVisualStyleBackColor = false;
            this.btnMilkTea.Click += new System.EventHandler(this.btnMilkTea_Click);
            // 
            // btnTea
            // 
            this.btnTea.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTea.BackColor = System.Drawing.Color.Beige;
            this.btnTea.Image = ((System.Drawing.Image)(resources.GetObject("btnTea.Image")));
            this.btnTea.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTea.Location = new System.Drawing.Point(173, 34);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(158, 159);
            this.btnTea.TabIndex = 1;
            this.btnTea.Text = "紅茶 $130\r\nBlack Tea";
            this.btnTea.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTea.UseVisualStyleBackColor = false;
            this.btnTea.Click += new System.EventHandler(this.btnTea_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCoffee.BackColor = System.Drawing.Color.Beige;
            this.btnCoffee.Image = ((System.Drawing.Image)(resources.GetObject("btnCoffee.Image")));
            this.btnCoffee.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCoffee.Location = new System.Drawing.Point(9, 34);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(158, 159);
            this.btnCoffee.TabIndex = 0;
            this.btnCoffee.Text = "咖啡 $150\r\nCoffee";
            this.btnCoffee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCoffee.UseVisualStyleBackColor = false;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // GBOrder
            // 
            this.GBOrder.Controls.Add(this.txtOrder);
            this.GBOrder.Controls.Add(this.btnClearOrder);
            this.GBOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GBOrder.Location = new System.Drawing.Point(389, 17);
            this.GBOrder.Name = "GBOrder";
            this.GBOrder.Size = new System.Drawing.Size(449, 246);
            this.GBOrder.TabIndex = 1;
            this.GBOrder.TabStop = false;
            this.GBOrder.Text = "點餐內容 Order";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(16, 34);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrder.Size = new System.Drawing.Size(407, 144);
            this.txtOrder.TabIndex = 1;
            this.txtOrder.Text = "尚未點餐";
            this.txtOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(147, 189);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(151, 42);
            this.btnClearOrder.TabIndex = 0;
            this.btnClearOrder.Text = "清除點餐";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // GBPrice
            // 
            this.GBPrice.Controls.Add(this.txtTotal);
            this.GBPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GBPrice.Location = new System.Drawing.Point(389, 279);
            this.GBPrice.Name = "GBPrice";
            this.GBPrice.Size = new System.Drawing.Size(191, 107);
            this.GBPrice.TabIndex = 2;
            this.GBPrice.TabStop = false;
            this.GBPrice.Text = "結帳金額";
            // 
            // txtTotal
            // 
            this.txtTotal.AcceptsReturn = true;
            this.txtTotal.Location = new System.Drawing.Point(19, 51);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(158, 34);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "NT$ 0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GBPayment
            // 
            this.GBPayment.Controls.Add(this.label1);
            this.GBPayment.Controls.Add(this.btnPayCard);
            this.GBPayment.Controls.Add(this.btnPayCash);
            this.GBPayment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GBPayment.Location = new System.Drawing.Point(598, 279);
            this.GBPayment.Name = "GBPayment";
            this.GBPayment.Size = new System.Drawing.Size(240, 107);
            this.GBPayment.TabIndex = 3;
            this.GBPayment.TabStop = false;
            this.GBPayment.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(138, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "刷卡9折!";
            // 
            // btnPayCard
            // 
            this.btnPayCard.Location = new System.Drawing.Point(130, 33);
            this.btnPayCard.Name = "btnPayCard";
            this.btnPayCard.Size = new System.Drawing.Size(98, 43);
            this.btnPayCard.TabIndex = 1;
            this.btnPayCard.Text = "信用卡";
            this.btnPayCard.UseVisualStyleBackColor = true;
            this.btnPayCard.Click += new System.EventHandler(this.btnPayCard_Click);
            // 
            // btnPayCash
            // 
            this.btnPayCash.Location = new System.Drawing.Point(16, 33);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(98, 43);
            this.btnPayCash.TabIndex = 0;
            this.btnPayCash.Text = "現金";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // Frm_HW_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(862, 403);
            this.Controls.Add(this.GBPayment);
            this.Controls.Add(this.GBPrice);
            this.Controls.Add(this.GBOrder);
            this.Controls.Add(this.GBMenu);
            this.Name = "Frm_HW_POS";
            this.Text = "Cafe POS";
            this.GBMenu.ResumeLayout(false);
            this.GBOrder.ResumeLayout(false);
            this.GBOrder.PerformLayout();
            this.GBPrice.ResumeLayout(false);
            this.GBPrice.PerformLayout();
            this.GBPayment.ResumeLayout(false);
            this.GBPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBMenu;
        private System.Windows.Forms.GroupBox GBOrder;
        private System.Windows.Forms.GroupBox GBPrice;
        private System.Windows.Forms.GroupBox GBPayment;
        private System.Windows.Forms.Button btnJuice;
        private System.Windows.Forms.Button btnMilkTea;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Button btnCoffee;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPayCard;
        private System.Windows.Forms.Button btnPayCash;
    }
}