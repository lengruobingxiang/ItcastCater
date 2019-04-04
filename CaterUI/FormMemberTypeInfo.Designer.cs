namespace CaterUI
{
    partial class FormMemberTypeInfo
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
            this.dgvMemberTypeInfo = new System.Windows.Forms.DataGridView();
            this.MTId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMTDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMTTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMTId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberTypeInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvMemberTypeInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // dgvMemberTypeInfo
            // 
            this.dgvMemberTypeInfo.AllowUserToAddRows = false;
            this.dgvMemberTypeInfo.AllowUserToDeleteRows = false;
            this.dgvMemberTypeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberTypeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberTypeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MTId,
            this.MTTitle,
            this.MTDiscount});
            this.dgvMemberTypeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberTypeInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvMemberTypeInfo.MultiSelect = false;
            this.dgvMemberTypeInfo.Name = "dgvMemberTypeInfo";
            this.dgvMemberTypeInfo.ReadOnly = true;
            this.dgvMemberTypeInfo.RowTemplate.Height = 23;
            this.dgvMemberTypeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberTypeInfo.Size = new System.Drawing.Size(343, 199);
            this.dgvMemberTypeInfo.TabIndex = 0;
            this.dgvMemberTypeInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberTypeInfo_CellDoubleClick);
            // 
            // MTId
            // 
            this.MTId.DataPropertyName = "MTId";
            this.MTId.HeaderText = "编号";
            this.MTId.Name = "MTId";
            this.MTId.ReadOnly = true;
            // 
            // MTTitle
            // 
            this.MTTitle.DataPropertyName = "MTTitle";
            this.MTTitle.HeaderText = "类型";
            this.MTTitle.Name = "MTTitle";
            this.MTTitle.ReadOnly = true;
            // 
            // MTDiscount
            // 
            this.MTDiscount.DataPropertyName = "MTDiscount";
            this.MTDiscount.HeaderText = "折扣";
            this.MTDiscount.Name = "MTDiscount";
            this.MTDiscount.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtMTDiscount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMTTitle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMTId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(367, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加/修改";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(16, 180);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(170, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "删除选中";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(111, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMTDiscount
            // 
            this.txtMTDiscount.Location = new System.Drawing.Point(61, 104);
            this.txtMTDiscount.Name = "txtMTDiscount";
            this.txtMTDiscount.Size = new System.Drawing.Size(125, 21);
            this.txtMTDiscount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "折扣：";
            // 
            // txtMTTitle
            // 
            this.txtMTTitle.Location = new System.Drawing.Point(61, 66);
            this.txtMTTitle.Name = "txtMTTitle";
            this.txtMTTitle.Size = new System.Drawing.Size(125, 21);
            this.txtMTTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "类型：";
            // 
            // txtMTId
            // 
            this.txtMTId.Location = new System.Drawing.Point(61, 28);
            this.txtMTId.Name = "txtMTId";
            this.txtMTId.ReadOnly = true;
            this.txtMTId.Size = new System.Drawing.Size(125, 21);
            this.txtMTId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // FormMemberTypeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 243);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMemberTypeInfo";
            this.Text = "会员分类管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMemberTypeInfo_FormClosed);
            this.Load += new System.EventHandler(this.FormMemberTypeInfo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberTypeInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMemberTypeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTDiscount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMTDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMTTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMTId;
        private System.Windows.Forms.Label label1;
    }
}