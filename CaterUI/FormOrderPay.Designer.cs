namespace CaterUI
{
    partial class FormOrderPay
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
            this.cbIsMember = new System.Windows.Forms.CheckBox();
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.lblMbDiscount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMbType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUseMbMoney = new System.Windows.Forms.CheckBox();
            this.lblMbMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIsMember
            // 
            this.cbIsMember.AutoSize = true;
            this.cbIsMember.Location = new System.Drawing.Point(12, 12);
            this.cbIsMember.Name = "cbIsMember";
            this.cbIsMember.Size = new System.Drawing.Size(48, 16);
            this.cbIsMember.TabIndex = 0;
            this.cbIsMember.Text = "会员";
            this.cbIsMember.UseVisualStyleBackColor = true;
            this.cbIsMember.CheckedChanged += new System.EventHandler(this.CbIsMember_CheckedChanged);
            // 
            // gbMember
            // 
            this.gbMember.Controls.Add(this.lblMbDiscount);
            this.gbMember.Controls.Add(this.label8);
            this.gbMember.Controls.Add(this.lblMbType);
            this.gbMember.Controls.Add(this.label6);
            this.gbMember.Controls.Add(this.cbUseMbMoney);
            this.gbMember.Controls.Add(this.lblMbMoney);
            this.gbMember.Controls.Add(this.label3);
            this.gbMember.Controls.Add(this.txtMPhone);
            this.gbMember.Controls.Add(this.label2);
            this.gbMember.Controls.Add(this.txtMId);
            this.gbMember.Controls.Add(this.label1);
            this.gbMember.Location = new System.Drawing.Point(12, 34);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(293, 183);
            this.gbMember.TabIndex = 1;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "会员信息";
            // 
            // lblMbDiscount
            // 
            this.lblMbDiscount.AutoSize = true;
            this.lblMbDiscount.Location = new System.Drawing.Point(242, 150);
            this.lblMbDiscount.Name = "lblMbDiscount";
            this.lblMbDiscount.Size = new System.Drawing.Size(29, 12);
            this.lblMbDiscount.TabIndex = 10;
            this.lblMbDiscount.Text = "1.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "折    扣：";
            // 
            // lblMbType
            // 
            this.lblMbType.AutoSize = true;
            this.lblMbType.Location = new System.Drawing.Point(90, 150);
            this.lblMbType.Name = "lblMbType";
            this.lblMbType.Size = new System.Drawing.Size(53, 12);
            this.lblMbType.TabIndex = 8;
            this.lblMbType.Text = "普通会员";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "会员等级：";
            // 
            // cbUseMbMoney
            // 
            this.cbUseMbMoney.AutoSize = true;
            this.cbUseMbMoney.Location = new System.Drawing.Point(199, 114);
            this.cbUseMbMoney.Name = "cbUseMbMoney";
            this.cbUseMbMoney.Size = new System.Drawing.Size(72, 16);
            this.cbUseMbMoney.TabIndex = 6;
            this.cbUseMbMoney.Text = "使用余额";
            this.cbUseMbMoney.UseVisualStyleBackColor = true;
            // 
            // lblMbMoney
            // 
            this.lblMbMoney.AutoSize = true;
            this.lblMbMoney.Location = new System.Drawing.Point(90, 115);
            this.lblMbMoney.Name = "lblMbMoney";
            this.lblMbMoney.Size = new System.Drawing.Size(11, 12);
            this.lblMbMoney.TabIndex = 5;
            this.lblMbMoney.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "账户余额：";
            // 
            // txtMPhone
            // 
            this.txtMPhone.Location = new System.Drawing.Point(92, 68);
            this.txtMPhone.Name = "txtMPhone";
            this.txtMPhone.Size = new System.Drawing.Size(179, 21);
            this.txtMPhone.TabIndex = 3;
            this.txtMPhone.Leave += new System.EventHandler(this.TxtMPhone_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "手 机 号：";
            // 
            // txtMId
            // 
            this.txtMId.Location = new System.Drawing.Point(92, 31);
            this.txtMId.Name = "txtMId";
            this.txtMId.Size = new System.Drawing.Size(179, 21);
            this.txtMId.TabIndex = 1;
            this.txtMId.Leave += new System.EventHandler(this.TxtMId_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员编号：";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(102, 235);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(11, 12);
            this.lblMoney.TabIndex = 10;
            this.lblMoney.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "消费金额：";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.ForeColor = System.Drawing.Color.Red;
            this.lblCash.Location = new System.Drawing.Point(244, 235);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(11, 12);
            this.lblCash.TabIndex = 12;
            this.lblCash.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "应收金额：";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(35, 267);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 13;
            this.btnPay.Text = "确认结账";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormOrderPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbMember);
            this.Controls.Add(this.cbIsMember);
            this.Name = "FormOrderPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "结账";
            this.Load += new System.EventHandler(this.FormOrderPay_Load);
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIsMember;
        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.Label lblMbDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbUseMbMoney;
        private System.Windows.Forms.Label lblMbMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button button2;
    }
}