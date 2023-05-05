namespace Lab_Form
{
    partial class Frm_HW_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HW_Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labTitle = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btn00ForDoWhile = new System.Windows.Forms.Button();
            this.btn00Method = new System.Windows.Forms.Button();
            this.btn04Student1 = new System.Windows.Forms.Button();
            this.btn00Calculator = new System.Windows.Forms.Button();
            this.btn03POS = new System.Windows.Forms.Button();
            this.btn02Loan = new System.Windows.Forms.Button();
            this.btn01Hello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.Controls.Add(this.labTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 700);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labTitle.Location = new System.Drawing.Point(151, 30);
            this.labTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(132, 43);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "C#作業";
            this.labTitle.Click += new System.EventHandler(this.labTitle_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.Controls.Add(this.btnGuess);
            this.splitContainer2.Panel1.Controls.Add(this.btn00ForDoWhile);
            this.splitContainer2.Panel1.Controls.Add(this.btn00Method);
            this.splitContainer2.Panel1.Controls.Add(this.btn04Student1);
            this.splitContainer2.Panel1.Controls.Add(this.btn00Calculator);
            this.splitContainer2.Panel1.Controls.Add(this.btn03POS);
            this.splitContainer2.Panel1.Controls.Add(this.btn02Loan);
            this.splitContainer2.Panel1.Controls.Add(this.btn01Hello);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Beige;
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Size = new System.Drawing.Size(1000, 601);
            this.splitContainer2.SplitterDistance = 180;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnGuess
            // 
            this.btnGuess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuess.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuess.BackColor = System.Drawing.Color.MintCream;
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuess.Location = new System.Drawing.Point(28, 331);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(122, 40);
            this.btnGuess.TabIndex = 7;
            this.btnGuess.Text = "??_Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btn00ForDoWhile
            // 
            this.btn00ForDoWhile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn00ForDoWhile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn00ForDoWhile.BackColor = System.Drawing.Color.MintCream;
            this.btn00ForDoWhile.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn00ForDoWhile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn00ForDoWhile.Location = new System.Drawing.Point(28, 285);
            this.btn00ForDoWhile.Name = "btn00ForDoWhile";
            this.btn00ForDoWhile.Size = new System.Drawing.Size(122, 40);
            this.btn00ForDoWhile.TabIndex = 6;
            this.btn00ForDoWhile.Text = "??_ForDoWhile";
            this.btn00ForDoWhile.UseVisualStyleBackColor = false;
            this.btn00ForDoWhile.Click += new System.EventHandler(this.btn00ForDoWhile_Click);
            // 
            // btn00Method
            // 
            this.btn00Method.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn00Method.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn00Method.BackColor = System.Drawing.Color.MintCream;
            this.btn00Method.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn00Method.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn00Method.Location = new System.Drawing.Point(28, 239);
            this.btn00Method.Name = "btn00Method";
            this.btn00Method.Size = new System.Drawing.Size(122, 40);
            this.btn00Method.TabIndex = 5;
            this.btn00Method.Text = "??_Method";
            this.btn00Method.UseVisualStyleBackColor = false;
            this.btn00Method.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btn04Student1
            // 
            this.btn04Student1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn04Student1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn04Student1.BackColor = System.Drawing.Color.MintCream;
            this.btn04Student1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn04Student1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn04Student1.Location = new System.Drawing.Point(30, 147);
            this.btn04Student1.Name = "btn04Student1";
            this.btn04Student1.Size = new System.Drawing.Size(120, 40);
            this.btn04Student1.TabIndex = 4;
            this.btn04Student1.Text = "04_Student1";
            this.btn04Student1.UseVisualStyleBackColor = false;
            this.btn04Student1.Click += new System.EventHandler(this.btnStudent1_Click);
            // 
            // btn00Calculator
            // 
            this.btn00Calculator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn00Calculator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn00Calculator.BackColor = System.Drawing.Color.MintCream;
            this.btn00Calculator.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn00Calculator.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn00Calculator.Location = new System.Drawing.Point(28, 193);
            this.btn00Calculator.Name = "btn00Calculator";
            this.btn00Calculator.Size = new System.Drawing.Size(122, 40);
            this.btn00Calculator.TabIndex = 3;
            this.btn00Calculator.Text = "??_Calculator";
            this.btn00Calculator.UseVisualStyleBackColor = false;
            this.btn00Calculator.Click += new System.EventHandler(this.btn00Calculator_Click);
            // 
            // btn03POS
            // 
            this.btn03POS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn03POS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn03POS.BackColor = System.Drawing.Color.MintCream;
            this.btn03POS.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn03POS.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn03POS.Location = new System.Drawing.Point(30, 101);
            this.btn03POS.Name = "btn03POS";
            this.btn03POS.Size = new System.Drawing.Size(120, 40);
            this.btn03POS.TabIndex = 2;
            this.btn03POS.Text = "03_POS";
            this.btn03POS.UseVisualStyleBackColor = false;
            this.btn03POS.Click += new System.EventHandler(this.btn03POS_Click);
            // 
            // btn02Loan
            // 
            this.btn02Loan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn02Loan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn02Loan.BackColor = System.Drawing.Color.MintCream;
            this.btn02Loan.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn02Loan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn02Loan.Location = new System.Drawing.Point(30, 55);
            this.btn02Loan.Name = "btn02Loan";
            this.btn02Loan.Size = new System.Drawing.Size(120, 40);
            this.btn02Loan.TabIndex = 1;
            this.btn02Loan.Text = "02_Loan";
            this.btn02Loan.UseVisualStyleBackColor = false;
            this.btn02Loan.Click += new System.EventHandler(this.btn02Loan_Click);
            // 
            // btn01Hello
            // 
            this.btn01Hello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn01Hello.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn01Hello.BackColor = System.Drawing.Color.MintCream;
            this.btn01Hello.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn01Hello.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn01Hello.Location = new System.Drawing.Point(30, 9);
            this.btn01Hello.Name = "btn01Hello";
            this.btn01Hello.Size = new System.Drawing.Size(120, 40);
            this.btn01Hello.TabIndex = 0;
            this.btn01Hello.Text = "01_Hello";
            this.btn01Hello.UseVisualStyleBackColor = false;
            this.btn01Hello.Click += new System.EventHandler(this.btn01Hello_Click);
            // 
            // Frm_HW_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_HW_Main";
            this.Text = "Frm_HW_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btn01Hello;
        private System.Windows.Forms.Button btn03POS;
        private System.Windows.Forms.Button btn02Loan;
        private System.Windows.Forms.Button btn00Calculator;
        private System.Windows.Forms.Button btn04Student1;
        private System.Windows.Forms.Button btn00Method;
        private System.Windows.Forms.Button btn00ForDoWhile;
        private System.Windows.Forms.Button btnGuess;
    }
}