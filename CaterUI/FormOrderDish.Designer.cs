namespace CaterUI
{
    partial class FormOrderDish
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDishInfo = new System.Windows.Forms.DataGridView();
            this.DId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPinyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDTypeTitle = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDPinyin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.ODDishId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ODDishTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ODSinglePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ODCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ODTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDishInfo);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 640);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜单";
            // 
            // dgvDishInfo
            // 
            this.dgvDishInfo.AllowUserToAddRows = false;
            this.dgvDishInfo.AllowUserToDeleteRows = false;
            this.dgvDishInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDishInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDishInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DId,
            this.DTitle,
            this.DPinyin,
            this.DTypeTitle,
            this.DPrice});
            this.dgvDishInfo.Location = new System.Drawing.Point(6, 72);
            this.dgvDishInfo.MultiSelect = false;
            this.dgvDishInfo.Name = "dgvDishInfo";
            this.dgvDishInfo.ReadOnly = true;
            this.dgvDishInfo.RowTemplate.Height = 23;
            this.dgvDishInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDishInfo.Size = new System.Drawing.Size(461, 562);
            this.dgvDishInfo.TabIndex = 1;
            this.dgvDishInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDishInfo_CellDoubleClick);
            // 
            // DId
            // 
            this.DId.DataPropertyName = "DId";
            this.DId.HeaderText = "编号";
            this.DId.Name = "DId";
            this.DId.ReadOnly = true;
            // 
            // DTitle
            // 
            this.DTitle.DataPropertyName = "DTitle";
            this.DTitle.HeaderText = "名称";
            this.DTitle.Name = "DTitle";
            this.DTitle.ReadOnly = true;
            // 
            // DPinyin
            // 
            this.DPinyin.DataPropertyName = "DPinyin";
            this.DPinyin.HeaderText = "首字母";
            this.DPinyin.Name = "DPinyin";
            this.DPinyin.ReadOnly = true;
            // 
            // DTypeTitle
            // 
            this.DTypeTitle.DataPropertyName = "DTypeTitle";
            this.DTypeTitle.HeaderText = "分类";
            this.DTypeTitle.Name = "DTypeTitle";
            this.DTypeTitle.ReadOnly = true;
            // 
            // DPrice
            // 
            this.DPrice.DataPropertyName = "DPrice";
            this.DPrice.HeaderText = "价格";
            this.DPrice.Name = "DPrice";
            this.DPrice.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbDTypeTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDPinyin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 46);
            this.panel1.TabIndex = 0;
            // 
            // cbDTypeTitle
            // 
            this.cbDTypeTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDTypeTitle.FormattingEnabled = true;
            this.cbDTypeTitle.Location = new System.Drawing.Point(315, 14);
            this.cbDTypeTitle.Name = "cbDTypeTitle";
            this.cbDTypeTitle.Size = new System.Drawing.Size(131, 20);
            this.cbDTypeTitle.TabIndex = 3;
            this.cbDTypeTitle.SelectedIndexChanged += new System.EventHandler(this.CbDTypeTitle_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "菜品分类：";
            // 
            // txtDPinyin
            // 
            this.txtDPinyin.Location = new System.Drawing.Point(99, 14);
            this.txtDPinyin.Name = "txtDPinyin";
            this.txtDPinyin.Size = new System.Drawing.Size(125, 21);
            this.txtDPinyin.TabIndex = 1;
            this.txtDPinyin.TextChanged += new System.EventHandler(this.TxtDPinyin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜名首字母：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvOrderDetail);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(491, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 640);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已点菜品";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.AllowUserToDeleteRows = false;
            this.dgvOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ODDishId,
            this.ODDishTitle,
            this.ODSinglePrice,
            this.ODCount,
            this.ODTotalPrice});
            this.dgvOrderDetail.Location = new System.Drawing.Point(6, 72);
            this.dgvOrderDetail.MultiSelect = false;
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 23;
            this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetail.Size = new System.Drawing.Size(461, 562);
            this.dgvOrderDetail.TabIndex = 1;
            this.dgvOrderDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrderDetail_CellValueChanged);
            // 
            // ODDishId
            // 
            this.ODDishId.DataPropertyName = "ODDishId";
            this.ODDishId.HeaderText = "菜品编号";
            this.ODDishId.Name = "ODDishId";
            this.ODDishId.ReadOnly = true;
            // 
            // ODDishTitle
            // 
            this.ODDishTitle.DataPropertyName = "ODDishTitle";
            this.ODDishTitle.HeaderText = "菜品名称";
            this.ODDishTitle.Name = "ODDishTitle";
            this.ODDishTitle.ReadOnly = true;
            // 
            // ODSinglePrice
            // 
            this.ODSinglePrice.DataPropertyName = "ODSinglePrice";
            this.ODSinglePrice.HeaderText = "单价";
            this.ODSinglePrice.Name = "ODSinglePrice";
            this.ODSinglePrice.ReadOnly = true;
            // 
            // ODCount
            // 
            this.ODCount.DataPropertyName = "ODCount";
            this.ODCount.HeaderText = "数量";
            this.ODCount.Name = "ODCount";
            this.ODCount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ODTotalPrice
            // 
            this.ODTotalPrice.DataPropertyName = "ODTotalPrice";
            this.ODTotalPrice.HeaderText = "总价";
            this.ODTotalPrice.Name = "ODTotalPrice";
            this.ODTotalPrice.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnPlaceOrder);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.lblTotalMoney);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(6, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 46);
            this.panel2.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(365, 12);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "下单";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(268, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除选中";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.AutoSize = true;
            this.lblTotalMoney.ForeColor = System.Drawing.Color.Red;
            this.lblTotalMoney.Location = new System.Drawing.Point(78, 17);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(11, 12);
            this.lblTotalMoney.TabIndex = 4;
            this.lblTotalMoney.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "消费总计：";
            // 
            // FormOrderDish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 664);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOrderDish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "点餐管理";
            this.Load += new System.EventHandler(this.FormOrderDish_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDishInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPinyin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbDTypeTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDPinyin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODDishId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODDishTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODSinglePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ODTotalPrice;
    }
}