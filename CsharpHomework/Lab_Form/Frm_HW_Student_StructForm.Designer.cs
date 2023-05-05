namespace Lab_Form
{
    partial class Frm_HW_Student_StructForm
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMand = new System.Windows.Forms.TextBox();
            this.labMand = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.GBScore = new System.Windows.Forms.GroupBox();
            this.labMixMax = new System.Windows.Forms.Label();
            this.labShow = new System.Windows.Forms.Label();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.GBScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labName.Location = new System.Drawing.Point(62, 40);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(57, 25);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(151, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(106, 34);
            this.txtName.TabIndex = 1;
            // 
            // txtMand
            // 
            this.txtMand.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMand.Location = new System.Drawing.Point(151, 84);
            this.txtMand.Name = "txtMand";
            this.txtMand.Size = new System.Drawing.Size(106, 34);
            this.txtMand.TabIndex = 3;
            // 
            // labMand
            // 
            this.labMand.AutoSize = true;
            this.labMand.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labMand.Location = new System.Drawing.Point(62, 87);
            this.labMand.Name = "labMand";
            this.labMand.Size = new System.Drawing.Size(57, 25);
            this.labMand.TabIndex = 2;
            this.labMand.Text = "國文:";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEng.Location = new System.Drawing.Point(151, 131);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(106, 34);
            this.txtEng.TabIndex = 5;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labEng.Location = new System.Drawing.Point(62, 134);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(57, 25);
            this.labEng.TabIndex = 4;
            this.labEng.Text = "英文:";
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMath.Location = new System.Drawing.Point(151, 182);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(106, 34);
            this.txtMath.TabIndex = 7;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labMath.Location = new System.Drawing.Point(62, 185);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(57, 25);
            this.labMath.TabIndex = 6;
            this.labMath.Text = "數學:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(40, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 46);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShow.Location = new System.Drawing.Point(159, 244);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(147, 46);
            this.btnShow.TabIndex = 9;
            this.btnShow.Text = "顯示儲存內容";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // GBScore
            // 
            this.GBScore.Controls.Add(this.labMixMax);
            this.GBScore.Controls.Add(this.labShow);
            this.GBScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GBScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GBScore.Location = new System.Drawing.Point(337, 22);
            this.GBScore.Name = "GBScore";
            this.GBScore.Size = new System.Drawing.Size(280, 234);
            this.GBScore.TabIndex = 10;
            this.GBScore.TabStop = false;
            this.GBScore.Text = "成績";
            // 
            // labMixMax
            // 
            this.labMixMax.BackColor = System.Drawing.Color.Lavender;
            this.labMixMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMixMax.Location = new System.Drawing.Point(6, 163);
            this.labMixMax.Name = "labMixMax";
            this.labMixMax.Size = new System.Drawing.Size(268, 63);
            this.labMixMax.TabIndex = 1;
            // 
            // labShow
            // 
            this.labShow.BackColor = System.Drawing.Color.Lavender;
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Location = new System.Drawing.Point(6, 30);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(268, 132);
            this.labShow.TabIndex = 0;
            // 
            // btnMinMax
            // 
            this.btnMinMax.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMinMax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMinMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinMax.Location = new System.Drawing.Point(415, 262);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(202, 46);
            this.btnMinMax.TabIndex = 11;
            this.btnMinMax.Text = "最高分/最低分科目";
            this.btnMinMax.UseVisualStyleBackColor = false;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // Frm_HW_Student_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(635, 329);
            this.Controls.Add(this.btnMinMax);
            this.Controls.Add(this.GBScore);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.txtMand);
            this.Controls.Add(this.labMand);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "Frm_HW_Student_StructForm";
            this.Text = "Student_StructForm";
            this.GBScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMand;
        private System.Windows.Forms.Label labMand;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox GBScore;
        private System.Windows.Forms.Label labMixMax;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button btnMinMax;
    }
}