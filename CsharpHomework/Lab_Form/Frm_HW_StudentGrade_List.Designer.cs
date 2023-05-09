namespace Lab_Form
{
    partial class Frm_HW_StudentGrade_List
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
            this.labShow = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labStat = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.txtMand = new System.Windows.Forms.TextBox();
            this.labMand = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRan1 = new System.Windows.Forms.TextBox();
            this.txtRan2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labShow
            // 
            this.labShow.BackColor = System.Drawing.SystemColors.Control;
            this.labShow.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(233, 12);
            this.labShow.Multiline = true;
            this.labShow.Name = "labShow";
            this.labShow.ReadOnly = true;
            this.labShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.labShow.Size = new System.Drawing.Size(504, 258);
            this.labShow.TabIndex = 47;
            this.labShow.Text = "姓名   國文  英文  數學  總分   平均     最低      最高";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labStat);
            this.panel2.Location = new System.Drawing.Point(233, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 159);
            this.panel2.TabIndex = 46;
            // 
            // labStat
            // 
            this.labStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labStat.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStat.Location = new System.Drawing.Point(0, 0);
            this.labStat.Name = "labStat";
            this.labStat.Size = new System.Drawing.Size(500, 155);
            this.labStat.TabIndex = 0;
            this.labStat.Text = "統計資料";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(35, 437);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 37);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(35, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 37);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "清除所有資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(35, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 37);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMath.Location = new System.Drawing.Point(101, 142);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(106, 34);
            this.txtMath.TabIndex = 40;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labMath.Location = new System.Drawing.Point(12, 145);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(57, 25);
            this.labMath.TabIndex = 39;
            this.labMath.Text = "數學:";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEng.Location = new System.Drawing.Point(101, 96);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(106, 34);
            this.txtEng.TabIndex = 38;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labEng.Location = new System.Drawing.Point(12, 99);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(57, 25);
            this.labEng.TabIndex = 37;
            this.labEng.Text = "英文:";
            // 
            // txtMand
            // 
            this.txtMand.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMand.Location = new System.Drawing.Point(101, 54);
            this.txtMand.Name = "txtMand";
            this.txtMand.Size = new System.Drawing.Size(106, 34);
            this.txtMand.TabIndex = 36;
            // 
            // labMand
            // 
            this.labMand.AutoSize = true;
            this.labMand.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labMand.Location = new System.Drawing.Point(12, 57);
            this.labMand.Name = "labMand";
            this.labMand.Size = new System.Drawing.Size(57, 25);
            this.labMand.TabIndex = 35;
            this.labMand.Text = "國文:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(101, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(106, 34);
            this.txtName.TabIndex = 34;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labName.Location = new System.Drawing.Point(12, 15);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 25);
            this.labName.TabIndex = 33;
            this.labName.Text = "姓名:";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(35, 236);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(144, 37);
            this.btnInsert.TabIndex = 48;
            this.btnInsert.Text = "插入儲存資料";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(35, 279);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(144, 37);
            this.btnRemove.TabIndex = 49;
            this.btnRemove.Text = "移除一筆資料";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRan1
            // 
            this.txtRan1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRan1.Location = new System.Drawing.Point(35, 400);
            this.txtRan1.Name = "txtRan1";
            this.txtRan1.Size = new System.Drawing.Size(50, 30);
            this.txtRan1.TabIndex = 50;
            this.txtRan1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRan2
            // 
            this.txtRan2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRan2.Location = new System.Drawing.Point(129, 400);
            this.txtRan2.Name = "txtRan2";
            this.txtRan2.Size = new System.Drawing.Size(50, 30);
            this.txtRan2.TabIndex = 51;
            this.txtRan2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 52;
            this.label1.Text = "搜尋國文成績範圍";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "－";
            // 
            // btnStat
            // 
            this.btnStat.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStat.Location = new System.Drawing.Point(593, 444);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(144, 37);
            this.btnStat.TabIndex = 54;
            this.btnStat.Text = "各科統計";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // Frm_HW_StudentGrade_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 487);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRan2);
            this.Controls.Add(this.txtRan1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.txtMand);
            this.Controls.Add(this.labMand);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "Frm_HW_StudentGrade_List";
            this.Text = "Frm_HW_StudentGrade_List";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox labShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labStat;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.TextBox txtMand;
        private System.Windows.Forms.Label labMand;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtRan1;
        private System.Windows.Forms.TextBox txtRan2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStat;
    }
}