namespace CaterUI
{
    partial class FormManagerInfo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvManagerInfoList = new System.Windows.Forms.DataGridView();
            this.MId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMPwd = new System.Windows.Forms.TextBox();
            this.tbMName = new System.Windows.Forms.TextBox();
            this.tbMId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerInfoList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvManagerInfoList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // dgvManagerInfoList
            // 
            this.dgvManagerInfoList.AllowUserToAddRows = false;
            this.dgvManagerInfoList.AllowUserToDeleteRows = false;
            this.dgvManagerInfoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManagerInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagerInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MId,
            this.MName,
            this.MType});
            this.dgvManagerInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManagerInfoList.Location = new System.Drawing.Point(3, 17);
            this.dgvManagerInfoList.MultiSelect = false;
            this.dgvManagerInfoList.Name = "dgvManagerInfoList";
            this.dgvManagerInfoList.ReadOnly = true;
            this.dgvManagerInfoList.RowTemplate.Height = 23;
            this.dgvManagerInfoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManagerInfoList.Size = new System.Drawing.Size(344, 242);
            this.dgvManagerInfoList.TabIndex = 0;
            this.dgvManagerInfoList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManagerInfoList_CellDoubleClick);
            this.dgvManagerInfoList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvManagerInfoList_CellFormatting);
            // 
            // MId
            // 
            this.MId.DataPropertyName = "MId";
            this.MId.HeaderText = "编号";
            this.MId.Name = "MId";
            this.MId.ReadOnly = true;
            // 
            // MName
            // 
            this.MName.DataPropertyName = "MName";
            this.MName.HeaderText = "用户名";
            this.MName.Name = "MName";
            this.MName.ReadOnly = true;
            // 
            // MType
            // 
            this.MType.DataPropertyName = "MType";
            this.MType.HeaderText = "类型";
            this.MType.Name = "MType";
            this.MType.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.rbEmployee);
            this.groupBox2.Controls.Add(this.rbManager);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbMPwd);
            this.groupBox2.Controls.Add(this.tbMName);
            this.groupBox2.Controls.Add(this.tbMId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(368, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加/修改";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(8, 220);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(180, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "删除选中的店员";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Checked = true;
            this.rbEmployee.Location = new System.Drawing.Point(141, 135);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(47, 16);
            this.rbEmployee.TabIndex = 8;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "店员";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(65, 135);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(47, 16);
            this.rbManager.TabIndex = 7;
            this.rbManager.Text = "经理";
            this.rbManager.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "类  型：";
            // 
            // tbMPwd
            // 
            this.tbMPwd.Location = new System.Drawing.Point(65, 90);
            this.tbMPwd.Name = "tbMPwd";
            this.tbMPwd.PasswordChar = '*';
            this.tbMPwd.Size = new System.Drawing.Size(123, 21);
            this.tbMPwd.TabIndex = 5;
            // 
            // tbMName
            // 
            this.tbMName.Location = new System.Drawing.Point(65, 59);
            this.tbMName.Name = "tbMName";
            this.tbMName.Size = new System.Drawing.Size(123, 21);
            this.tbMName.TabIndex = 4;
            // 
            // tbMId
            // 
            this.tbMId.Location = new System.Drawing.Point(65, 28);
            this.tbMId.Name = "tbMId";
            this.tbMId.ReadOnly = true;
            this.tbMId.Size = new System.Drawing.Size(123, 21);
            this.tbMId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编  号：";
            // 
            // FormManagerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 286);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(16, 325);
            this.Name = "FormManagerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "店员管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManagerInfo_FormClosed);
            this.Load += new System.EventHandler(this.FormManagerInfo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagerInfoList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvManagerInfoList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMPwd;
        private System.Windows.Forms.TextBox tbMName;
        private System.Windows.Forms.TextBox tbMId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MType;
    }
}

