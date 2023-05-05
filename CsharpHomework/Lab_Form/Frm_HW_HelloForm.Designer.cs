namespace Lab_Form
{
    partial class Frm_HW_HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HW_HelloForm));
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEngname = new System.Windows.Forms.TextBox();
            this.labEngname = new System.Windows.Forms.Label();
            this.txtzsign = new System.Windows.Forms.TextBox();
            this.labzsign = new System.Windows.Forms.Label();
            this.txtblood = new System.Windows.Forms.TextBox();
            this.labblood = new System.Windows.Forms.Label();
            this.btnSayHello = new System.Windows.Forms.Button();
            this.btnSayHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.BackColor = System.Drawing.Color.Transparent;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.ForeColor = System.Drawing.Color.RosyBrown;
            this.labName.Location = new System.Drawing.Point(149, 40);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(111, 29);
            this.labName.TabIndex = 1;
            this.labName.Text = "中文姓名:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtName.HideSelection = false;
            this.txtName.Location = new System.Drawing.Point(291, 40);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 31);
            this.txtName.TabIndex = 2;
            // 
            // txtEngname
            // 
            this.txtEngname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEngname.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEngname.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtEngname.HideSelection = false;
            this.txtEngname.Location = new System.Drawing.Point(291, 96);
            this.txtEngname.Margin = new System.Windows.Forms.Padding(4);
            this.txtEngname.Name = "txtEngname";
            this.txtEngname.Size = new System.Drawing.Size(192, 31);
            this.txtEngname.TabIndex = 5;
            // 
            // labEngname
            // 
            this.labEngname.AutoSize = true;
            this.labEngname.BackColor = System.Drawing.Color.Transparent;
            this.labEngname.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEngname.ForeColor = System.Drawing.Color.RosyBrown;
            this.labEngname.Location = new System.Drawing.Point(149, 96);
            this.labEngname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEngname.Name = "labEngname";
            this.labEngname.Size = new System.Drawing.Size(111, 29);
            this.labEngname.TabIndex = 4;
            this.labEngname.Text = "英文姓名:";
            // 
            // txtzsign
            // 
            this.txtzsign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtzsign.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtzsign.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtzsign.HideSelection = false;
            this.txtzsign.Location = new System.Drawing.Point(291, 154);
            this.txtzsign.Margin = new System.Windows.Forms.Padding(4);
            this.txtzsign.Name = "txtzsign";
            this.txtzsign.Size = new System.Drawing.Size(192, 31);
            this.txtzsign.TabIndex = 7;
            // 
            // labzsign
            // 
            this.labzsign.AutoSize = true;
            this.labzsign.BackColor = System.Drawing.Color.Transparent;
            this.labzsign.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labzsign.ForeColor = System.Drawing.Color.RosyBrown;
            this.labzsign.Location = new System.Drawing.Point(149, 154);
            this.labzsign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labzsign.Name = "labzsign";
            this.labzsign.Size = new System.Drawing.Size(65, 29);
            this.labzsign.TabIndex = 6;
            this.labzsign.Text = "星座:";
            this.labzsign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtblood
            // 
            this.txtblood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtblood.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtblood.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtblood.HideSelection = false;
            this.txtblood.Location = new System.Drawing.Point(291, 215);
            this.txtblood.Margin = new System.Windows.Forms.Padding(4);
            this.txtblood.Name = "txtblood";
            this.txtblood.Size = new System.Drawing.Size(192, 31);
            this.txtblood.TabIndex = 9;
            // 
            // labblood
            // 
            this.labblood.AutoSize = true;
            this.labblood.BackColor = System.Drawing.Color.Transparent;
            this.labblood.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labblood.ForeColor = System.Drawing.Color.RosyBrown;
            this.labblood.Location = new System.Drawing.Point(149, 215);
            this.labblood.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labblood.Name = "labblood";
            this.labblood.Size = new System.Drawing.Size(65, 29);
            this.labblood.TabIndex = 8;
            this.labblood.Text = "血型:";
            // 
            // btnSayHello
            // 
            this.btnSayHello.BackColor = System.Drawing.Color.Transparent;
            this.btnSayHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSayHello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSayHello.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSayHello.FlatAppearance.BorderSize = 0;
            this.btnSayHello.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSayHello.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSayHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayHello.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHello.ForeColor = System.Drawing.Color.MediumPurple;
            this.btnSayHello.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHello.Image")));
            this.btnSayHello.Location = new System.Drawing.Point(46, 282);
            this.btnSayHello.Margin = new System.Windows.Forms.Padding(4);
            this.btnSayHello.Name = "btnSayHello";
            this.btnSayHello.Size = new System.Drawing.Size(260, 60);
            this.btnSayHello.TabIndex = 10;
            this.btnSayHello.Text = "Say Hello";
            this.btnSayHello.UseMnemonic = false;
            this.btnSayHello.UseVisualStyleBackColor = false;
            this.btnSayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // btnSayHi
            // 
            this.btnSayHi.BackColor = System.Drawing.Color.Transparent;
            this.btnSayHi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSayHi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSayHi.FlatAppearance.BorderSize = 0;
            this.btnSayHi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSayHi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSayHi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayHi.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSayHi.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnSayHi.Image = ((System.Drawing.Image)(resources.GetObject("btnSayHi.Image")));
            this.btnSayHi.Location = new System.Drawing.Point(352, 282);
            this.btnSayHi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSayHi.Name = "btnSayHi";
            this.btnSayHi.Size = new System.Drawing.Size(260, 60);
            this.btnSayHi.TabIndex = 11;
            this.btnSayHi.Text = "Say Hi";
            this.btnSayHi.UseVisualStyleBackColor = false;
            this.btnSayHi.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // Frm_HW_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(652, 373);
            this.Controls.Add(this.txtblood);
            this.Controls.Add(this.labblood);
            this.Controls.Add(this.txtzsign);
            this.Controls.Add(this.labzsign);
            this.Controls.Add(this.txtEngname);
            this.Controls.Add(this.labEngname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnSayHi);
            this.Controls.Add(this.btnSayHello);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_HW_HelloForm";
            this.Text = "Hello Form:D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSayHello;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEngname;
        private System.Windows.Forms.Label labEngname;
        private System.Windows.Forms.TextBox txtzsign;
        private System.Windows.Forms.Label labzsign;
        private System.Windows.Forms.TextBox txtblood;
        private System.Windows.Forms.Label labblood;
        private System.Windows.Forms.Button btnSayHi;
    }
}

