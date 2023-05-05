namespace Lab_Form
{
    partial class Frm_HW_Method
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
            this.labNumber = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnOddEven = new System.Windows.Forms.Button();
            this.btnOdd = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnLongest = new System.Windows.Forms.Button();
            this.btnContain = new System.Windows.Forms.Button();
            this.btn1001 = new System.Windows.Forms.Button();
            this.btn0110 = new System.Windows.Forms.Button();
            this.btn0101 = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labShow = new System.Windows.Forms.Label();
            this.labResult = new System.Windows.Forms.Label();
            this.labIntArray = new System.Windows.Forms.Label();
            this.labStrArray = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labNumber
            // 
            this.labNumber.AutoSize = true;
            this.labNumber.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNumber.Location = new System.Drawing.Point(19, 29);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(95, 25);
            this.labNumber.TabIndex = 0;
            this.labNumber.Text = "Number:";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.FloralWhite;
            this.txtNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum.Location = new System.Drawing.Point(120, 26);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(84, 34);
            this.txtNum.TabIndex = 1;
            // 
            // btnOddEven
            // 
            this.btnOddEven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOddEven.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOddEven.Location = new System.Drawing.Point(219, 23);
            this.btnOddEven.Name = "btnOddEven";
            this.btnOddEven.Size = new System.Drawing.Size(180, 40);
            this.btnOddEven.TabIndex = 2;
            this.btnOddEven.Text = "輸入的是奇數或偶數";
            this.btnOddEven.UseVisualStyleBackColor = false;
            this.btnOddEven.Click += new System.EventHandler(this.btnOddEven_Click);
            // 
            // btnOdd
            // 
            this.btnOdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOdd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOdd.Location = new System.Drawing.Point(12, 80);
            this.btnOdd.Name = "btnOdd";
            this.btnOdd.Size = new System.Drawing.Size(180, 40);
            this.btnOdd.TabIndex = 3;
            this.btnOdd.Text = "數字陣列統計奇偶數";
            this.btnOdd.UseVisualStyleBackColor = false;
            this.btnOdd.Click += new System.EventHandler(this.btnOdd_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinMax.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinMax.Location = new System.Drawing.Point(12, 264);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(180, 40);
            this.btnMinMax.TabIndex = 4;
            this.btnMinMax.Text = "數字陣列最大/最小值";
            this.btnMinMax.UseVisualStyleBackColor = false;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMin.Location = new System.Drawing.Point(12, 216);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(180, 40);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "數字陣列最小值";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMax.Location = new System.Drawing.Point(12, 171);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(180, 40);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "數字陣列最大值";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSum.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSum.Location = new System.Drawing.Point(12, 125);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(180, 40);
            this.btnSum.TabIndex = 7;
            this.btnSum.Text = "數字陣列加總";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnLongest
            // 
            this.btnLongest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLongest.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLongest.Location = new System.Drawing.Point(208, 80);
            this.btnLongest.Name = "btnLongest";
            this.btnLongest.Size = new System.Drawing.Size(212, 40);
            this.btnLongest.TabIndex = 8;
            this.btnLongest.Text = "字串陣列最長的名字";
            this.btnLongest.UseVisualStyleBackColor = false;
            this.btnLongest.Click += new System.EventHandler(this.btnLongest_Click);
            // 
            // btnContain
            // 
            this.btnContain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContain.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnContain.Location = new System.Drawing.Point(208, 126);
            this.btnContain.Name = "btnContain";
            this.btnContain.Size = new System.Drawing.Size(212, 40);
            this.btnContain.TabIndex = 9;
            this.btnContain.Text = "字串陣列有幾個包含C/c";
            this.btnContain.UseVisualStyleBackColor = false;
            this.btnContain.Click += new System.EventHandler(this.btnContain_Click);
            // 
            // btn1001
            // 
            this.btn1001.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1001.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1001.Location = new System.Drawing.Point(208, 172);
            this.btn1001.Name = "btn1001";
            this.btn1001.Size = new System.Drawing.Size(212, 40);
            this.btn1001.TabIndex = 10;
            this.btn1001.Text = "[10,10]二維陣列-邊1內0";
            this.btn1001.UseVisualStyleBackColor = false;
            this.btn1001.Click += new System.EventHandler(this.btn1001_Click);
            // 
            // btn0110
            // 
            this.btn0110.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0110.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn0110.Location = new System.Drawing.Point(208, 218);
            this.btn0110.Name = "btn0110";
            this.btn0110.Size = new System.Drawing.Size(212, 40);
            this.btn0110.TabIndex = 11;
            this.btn0110.Text = "[10,10]二維陣列-邊0內1";
            this.btn0110.UseVisualStyleBackColor = false;
            this.btn0110.Click += new System.EventHandler(this.btn0110_Click);
            // 
            // btn0101
            // 
            this.btn0101.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0101.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn0101.Location = new System.Drawing.Point(208, 264);
            this.btn0101.Name = "btn0101";
            this.btn0101.Size = new System.Drawing.Size(212, 40);
            this.btn0101.TabIndex = 12;
            this.btn0101.Text = "[10,10]二維陣列-01交錯";
            this.btn0101.UseVisualStyleBackColor = false;
            this.btn0101.Click += new System.EventHandler(this.btn1010_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSwap.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwap.Location = new System.Drawing.Point(453, 23);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(150, 40);
            this.btnSwap.TabIndex = 13;
            this.btnSwap.Text = "兩數字Swap";
            this.btnSwap.UseVisualStyleBackColor = false;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(582, 80);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labShow
            // 
            this.labShow.BackColor = System.Drawing.Color.FloralWhite;
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Location = new System.Drawing.Point(469, 124);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(263, 194);
            this.labShow.TabIndex = 15;
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(466, 96);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(74, 25);
            this.labResult.TabIndex = 16;
            this.labResult.Text = "Result:";
            // 
            // labIntArray
            // 
            this.labIntArray.AutoSize = true;
            this.labIntArray.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labIntArray.Location = new System.Drawing.Point(12, 320);
            this.labIntArray.Name = "labIntArray";
            this.labIntArray.Size = new System.Drawing.Size(69, 19);
            this.labIntArray.TabIndex = 17;
            this.labIntArray.Text = "Int Array";
            // 
            // labStrArray
            // 
            this.labStrArray.AutoSize = true;
            this.labStrArray.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStrArray.Location = new System.Drawing.Point(12, 348);
            this.labStrArray.Name = "labStrArray";
            this.labStrArray.Size = new System.Drawing.Size(94, 19);
            this.labStrArray.TabIndex = 18;
            this.labStrArray.Text = "String Array";
            // 
            // Frm_HW_Method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(766, 379);
            this.Controls.Add(this.labStrArray);
            this.Controls.Add(this.labIntArray);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.btn0101);
            this.Controls.Add(this.btn0110);
            this.Controls.Add(this.btn1001);
            this.Controls.Add(this.btnContain);
            this.Controls.Add(this.btnLongest);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.btnOdd);
            this.Controls.Add(this.btnOddEven);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.labNumber);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Frm_HW_Method";
            this.Text = "Frm_HW_Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumber;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnOddEven;
        private System.Windows.Forms.Button btnOdd;
        private System.Windows.Forms.Button btnMinMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnLongest;
        private System.Windows.Forms.Button btnContain;
        private System.Windows.Forms.Button btn1001;
        private System.Windows.Forms.Button btn0110;
        private System.Windows.Forms.Button btn0101;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labIntArray;
        private System.Windows.Forms.Label labStrArray;
    }
}