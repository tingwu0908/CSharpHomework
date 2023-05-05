namespace Lab_Form
{
    partial class Frm_HW_Calculator
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
            this.labNum1 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.labNum2 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.labAns = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNum1
            // 
            this.labNum1.AutoSize = true;
            this.labNum1.BackColor = System.Drawing.Color.Transparent;
            this.labNum1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum1.ForeColor = System.Drawing.Color.DarkGreen;
            this.labNum1.Location = new System.Drawing.Point(56, 39);
            this.labNum1.Name = "labNum1";
            this.labNum1.Size = new System.Drawing.Size(107, 36);
            this.labNum1.TabIndex = 0;
            this.labNum1.Text = "Num1:";
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlus.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnPlus.Location = new System.Drawing.Point(41, 177);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 50);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "＋";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNum1.Location = new System.Drawing.Point(194, 36);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 43);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNum2.Location = new System.Drawing.Point(194, 99);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 43);
            this.txtNum2.TabIndex = 4;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labNum2
            // 
            this.labNum2.AutoSize = true;
            this.labNum2.BackColor = System.Drawing.Color.Transparent;
            this.labNum2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNum2.ForeColor = System.Drawing.Color.DarkGreen;
            this.labNum2.Location = new System.Drawing.Point(56, 102);
            this.labNum2.Name = "labNum2";
            this.labNum2.Size = new System.Drawing.Size(107, 36);
            this.labNum2.TabIndex = 3;
            this.labNum2.Text = "Num2:";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinus.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnMinus.Location = new System.Drawing.Point(118, 177);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 50);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "－";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimes.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTimes.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnTimes.Location = new System.Drawing.Point(194, 177);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(50, 50);
            this.btnTimes.TabIndex = 6;
            this.btnTimes.Text = "×";
            this.btnTimes.UseVisualStyleBackColor = false;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDivide.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnDivide.Location = new System.Drawing.Point(270, 177);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(50, 50);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // txtAns
            // 
            this.txtAns.BackColor = System.Drawing.SystemColors.Control;
            this.txtAns.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAns.Enabled = false;
            this.txtAns.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAns.Location = new System.Drawing.Point(159, 268);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(135, 43);
            this.txtAns.TabIndex = 9;
            this.txtAns.Text = "0";
            this.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labAns
            // 
            this.labAns.AutoSize = true;
            this.labAns.BackColor = System.Drawing.Color.Transparent;
            this.labAns.Font = new System.Drawing.Font("微軟正黑體", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAns.ForeColor = System.Drawing.Color.DarkGreen;
            this.labAns.Location = new System.Drawing.Point(56, 271);
            this.labAns.Name = "labAns";
            this.labAns.Size = new System.Drawing.Size(73, 36);
            this.labAns.TabIndex = 8;
            this.labAns.Text = "Ans:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnReset.Location = new System.Drawing.Point(109, 344);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 50);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Frm_HW_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(352, 423);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.labAns);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.labNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.labNum1);
            this.Name = "Frm_HW_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNum1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label labNum2;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label labAns;
        private System.Windows.Forms.Button btnReset;
    }
}