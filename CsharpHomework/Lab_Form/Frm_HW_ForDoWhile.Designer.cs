namespace Lab_Form
{
    partial class Frm_HW_ForDoWhile
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
            this.labResult = new System.Windows.Forms.Label();
            this.labShow = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.labFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.labTo = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.labStep = new System.Windows.Forms.Label();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btn99 = new System.Windows.Forms.Button();
            this.btnLottery = new System.Windows.Forms.Button();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.labRows = new System.Windows.Forms.Label();
            this.txtDec = new System.Windows.Forms.TextBox();
            this.labdec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(66, 177);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(74, 25);
            this.labResult.TabIndex = 19;
            this.labResult.Text = "Result:";
            // 
            // labShow
            // 
            this.labShow.BackColor = System.Drawing.Color.GhostWhite;
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(146, 177);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(712, 217);
            this.labShow.TabIndex = 18;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(19, 351);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 40);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "清空結果欄";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labFrom
            // 
            this.labFrom.AutoSize = true;
            this.labFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labFrom.Location = new System.Drawing.Point(52, 24);
            this.labFrom.Name = "labFrom";
            this.labFrom.Size = new System.Drawing.Size(67, 25);
            this.labFrom.TabIndex = 20;
            this.labFrom.Text = "From:";
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.GhostWhite;
            this.txtFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFrom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtFrom.Location = new System.Drawing.Point(125, 21);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(102, 34);
            this.txtFrom.TabIndex = 21;
            this.txtFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.GhostWhite;
            this.txtTo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTo.Location = new System.Drawing.Point(125, 63);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(102, 34);
            this.txtTo.TabIndex = 23;
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labTo
            // 
            this.labTo.AutoSize = true;
            this.labTo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTo.Location = new System.Drawing.Point(52, 66);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(41, 25);
            this.labTo.TabIndex = 22;
            this.labTo.Text = "To:";
            // 
            // txtStep
            // 
            this.txtStep.BackColor = System.Drawing.Color.GhostWhite;
            this.txtStep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStep.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtStep.Location = new System.Drawing.Point(125, 105);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(102, 34);
            this.txtStep.TabIndex = 25;
            this.txtStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labStep
            // 
            this.labStep.AutoSize = true;
            this.labStep.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStep.Location = new System.Drawing.Point(52, 108);
            this.labStep.Name = "labStep";
            this.labStep.Size = new System.Drawing.Size(59, 25);
            this.labStep.TabIndex = 24;
            this.labStep.Text = "Step:";
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFor.Location = new System.Drawing.Point(278, 12);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(91, 43);
            this.btnFor.TabIndex = 26;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnWhile.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhile.Location = new System.Drawing.Point(278, 66);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(91, 43);
            this.btnWhile.TabIndex = 27;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDo.Location = new System.Drawing.Point(278, 121);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(91, 43);
            this.btnDo.TabIndex = 28;
            this.btnDo.Text = "Do";
            this.btnDo.UseVisualStyleBackColor = false;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnTree
            // 
            this.btnTree.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTree.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTree.Location = new System.Drawing.Point(656, 9);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(170, 43);
            this.btnTree.TabIndex = 29;
            this.btnTree.Text = "直角聖誕樹";
            this.btnTree.UseVisualStyleBackColor = false;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBinary.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBinary.Location = new System.Drawing.Point(656, 68);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(170, 43);
            this.btnBinary.TabIndex = 30;
            this.btnBinary.Text = "100的二進位";
            this.btnBinary.UseVisualStyleBackColor = false;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btn99
            // 
            this.btn99.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn99.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn99.Location = new System.Drawing.Point(468, 126);
            this.btn99.Name = "btn99";
            this.btn99.Size = new System.Drawing.Size(170, 43);
            this.btn99.TabIndex = 31;
            this.btn99.Text = "九九乘法表";
            this.btn99.UseVisualStyleBackColor = false;
            this.btn99.Click += new System.EventHandler(this.btn99_Click);
            // 
            // btnLottery
            // 
            this.btnLottery.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLottery.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLottery.Location = new System.Drawing.Point(656, 126);
            this.btnLottery.Name = "btnLottery";
            this.btnLottery.Size = new System.Drawing.Size(170, 43);
            this.btnLottery.TabIndex = 32;
            this.btnLottery.Text = "樂透int[]不重複";
            this.btnLottery.UseVisualStyleBackColor = false;
            this.btnLottery.Click += new System.EventHandler(this.btnLottery_Click);
            // 
            // txtRows
            // 
            this.txtRows.BackColor = System.Drawing.Color.GhostWhite;
            this.txtRows.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRows.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtRows.Location = new System.Drawing.Point(536, 15);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(102, 34);
            this.txtRows.TabIndex = 34;
            this.txtRows.Text = "10";
            this.txtRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labRows
            // 
            this.labRows.AutoSize = true;
            this.labRows.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRows.Location = new System.Drawing.Point(453, 18);
            this.labRows.Name = "labRows";
            this.labRows.Size = new System.Drawing.Size(68, 25);
            this.labRows.TabIndex = 33;
            this.labRows.Text = "Rows:";
            // 
            // txtDec
            // 
            this.txtDec.BackColor = System.Drawing.Color.GhostWhite;
            this.txtDec.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtDec.Location = new System.Drawing.Point(536, 72);
            this.txtDec.Name = "txtDec";
            this.txtDec.Size = new System.Drawing.Size(102, 34);
            this.txtDec.TabIndex = 36;
            this.txtDec.Text = "100";
            this.txtDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labdec
            // 
            this.labdec.AutoSize = true;
            this.labdec.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labdec.Location = new System.Drawing.Point(437, 75);
            this.labdec.Name = "labdec";
            this.labdec.Size = new System.Drawing.Size(93, 25);
            this.labdec.TabIndex = 35;
            this.labdec.Text = "Decimal:";
            // 
            // Frm_HW_ForDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(870, 407);
            this.Controls.Add(this.txtDec);
            this.Controls.Add(this.labdec);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.labRows);
            this.Controls.Add(this.btnLottery);
            this.Controls.Add(this.btn99);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.labStep);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.labTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.labFrom);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.btnClear);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "Frm_HW_ForDoWhile";
            this.Text = "Frm_HW_ForDoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.TextBox txtStep;
        private System.Windows.Forms.Label labStep;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btn99;
        private System.Windows.Forms.Button btnLottery;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label labRows;
        private System.Windows.Forms.TextBox txtDec;
        private System.Windows.Forms.Label labdec;
    }
}