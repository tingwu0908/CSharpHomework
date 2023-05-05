namespace Lab_Form
{
    partial class Frm_HW_Loan
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
            this.lab貸款金額 = new System.Windows.Forms.Label();
            this.lab年利率 = new System.Windows.Forms.Label();
            this.lab貸款期數 = new System.Windows.Forms.Label();
            this.lab每期金額 = new System.Windows.Forms.Label();
            this.lab全部利息 = new System.Windows.Forms.Label();
            this.txt貸款金額 = new System.Windows.Forms.TextBox();
            this.txt貸款期數 = new System.Windows.Forms.TextBox();
            this.txt每期金額 = new System.Windows.Forms.TextBox();
            this.txt全部利息 = new System.Windows.Forms.TextBox();
            this.txt年利率 = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab貸款金額
            // 
            this.lab貸款金額.AutoSize = true;
            this.lab貸款金額.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab貸款金額.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lab貸款金額.Location = new System.Drawing.Point(51, 90);
            this.lab貸款金額.Name = "lab貸款金額";
            this.lab貸款金額.Size = new System.Drawing.Size(142, 29);
            this.lab貸款金額.TabIndex = 0;
            this.lab貸款金額.Text = "貸款金額(元)";
            // 
            // lab年利率
            // 
            this.lab年利率.AutoSize = true;
            this.lab年利率.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab年利率.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lab年利率.Location = new System.Drawing.Point(51, 152);
            this.lab年利率.Name = "lab年利率";
            this.lab年利率.Size = new System.Drawing.Size(116, 29);
            this.lab年利率.TabIndex = 1;
            this.lab年利率.Text = "年利率(%)";
            // 
            // lab貸款期數
            // 
            this.lab貸款期數.AutoSize = true;
            this.lab貸款期數.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab貸款期數.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lab貸款期數.Location = new System.Drawing.Point(51, 214);
            this.lab貸款期數.Name = "lab貸款期數";
            this.lab貸款期數.Size = new System.Drawing.Size(142, 29);
            this.lab貸款期數.TabIndex = 2;
            this.lab貸款期數.Text = "貸款期數(月)";
            // 
            // lab每期金額
            // 
            this.lab每期金額.AutoSize = true;
            this.lab每期金額.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab每期金額.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lab每期金額.Location = new System.Drawing.Point(409, 83);
            this.lab每期金額.Name = "lab每期金額";
            this.lab每期金額.Size = new System.Drawing.Size(188, 29);
            this.lab每期金額.TabIndex = 3;
            this.lab每期金額.Text = "每期應交金額(元)";
            // 
            // lab全部利息
            // 
            this.lab全部利息.AutoSize = true;
            this.lab全部利息.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab全部利息.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lab全部利息.Location = new System.Drawing.Point(409, 140);
            this.lab全部利息.Name = "lab全部利息";
            this.lab全部利息.Size = new System.Drawing.Size(142, 29);
            this.lab全部利息.TabIndex = 4;
            this.lab全部利息.Text = "全部利息(元)";
            // 
            // txt貸款金額
            // 
            this.txt貸款金額.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt貸款金額.Location = new System.Drawing.Point(213, 87);
            this.txt貸款金額.Name = "txt貸款金額";
            this.txt貸款金額.Size = new System.Drawing.Size(144, 38);
            this.txt貸款金額.TabIndex = 1;
            // 
            // txt貸款期數
            // 
            this.txt貸款期數.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt貸款期數.Location = new System.Drawing.Point(213, 211);
            this.txt貸款期數.Name = "txt貸款期數";
            this.txt貸款期數.Size = new System.Drawing.Size(144, 38);
            this.txt貸款期數.TabIndex = 3;
            // 
            // txt每期金額
            // 
            this.txt每期金額.BackColor = System.Drawing.SystemColors.Control;
            this.txt每期金額.Enabled = false;
            this.txt每期金額.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt每期金額.Location = new System.Drawing.Point(613, 80);
            this.txt每期金額.Name = "txt每期金額";
            this.txt每期金額.Size = new System.Drawing.Size(144, 38);
            this.txt每期金額.TabIndex = 4;
            // 
            // txt全部利息
            // 
            this.txt全部利息.BackColor = System.Drawing.SystemColors.Control;
            this.txt全部利息.Enabled = false;
            this.txt全部利息.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt全部利息.Location = new System.Drawing.Point(613, 137);
            this.txt全部利息.Name = "txt全部利息";
            this.txt全部利息.Size = new System.Drawing.Size(144, 38);
            this.txt全部利息.TabIndex = 5;
            // 
            // txt年利率
            // 
            this.txt年利率.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt年利率.Location = new System.Drawing.Point(213, 149);
            this.txt年利率.Name = "txt年利率";
            this.txt年利率.Size = new System.Drawing.Size(144, 38);
            this.txt年利率.TabIndex = 2;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labTitle.Location = new System.Drawing.Point(30, 25);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(282, 42);
            this.labTitle.TabIndex = 6;
            this.labTitle.Text = "本息平均攤還試算";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.Location = new System.Drawing.Point(102, 282);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 40);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "試算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(219, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Frm_HW_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(832, 353);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.txt年利率);
            this.Controls.Add(this.txt全部利息);
            this.Controls.Add(this.txt每期金額);
            this.Controls.Add(this.txt貸款期數);
            this.Controls.Add(this.txt貸款金額);
            this.Controls.Add(this.lab全部利息);
            this.Controls.Add(this.lab每期金額);
            this.Controls.Add(this.lab貸款期數);
            this.Controls.Add(this.lab年利率);
            this.Controls.Add(this.lab貸款金額);
            this.Name = "Frm_HW_Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab貸款金額;
        private System.Windows.Forms.Label lab年利率;
        private System.Windows.Forms.Label lab貸款期數;
        private System.Windows.Forms.Label lab每期金額;
        private System.Windows.Forms.Label lab全部利息;
        private System.Windows.Forms.TextBox txt貸款金額;
        private System.Windows.Forms.TextBox txt貸款期數;
        private System.Windows.Forms.TextBox txt每期金額;
        private System.Windows.Forms.TextBox txt全部利息;
        private System.Windows.Forms.TextBox txt年利率;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}