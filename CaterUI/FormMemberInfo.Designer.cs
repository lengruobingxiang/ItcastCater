namespace CaterUI
{
    partial class FormMemberInfo
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
            this.dgvMemberInfo = new System.Windows.Forms.DataGridView();
            this.MbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MbTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MbPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MbMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMbMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMbPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTypeEdit = new System.Windows.Forms.Button();
            this.cbMbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMbId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvMemberInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // dgvMemberInfo
            // 
            this.dgvMemberInfo.AllowUserToAddRows = false;
            this.dgvMemberInfo.AllowUserToDeleteRows = false;
            this.dgvMemberInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MbId,
            this.MbName,
            this.MbTypeTitle,
            this.MbPhone,
            this.MbMoney});
            this.dgvMemberInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMemberInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvMemberInfo.MultiSelect = false;
            this.dgvMemberInfo.Name = "dgvMemberInfo";
            this.dgvMemberInfo.ReadOnly = true;
            this.dgvMemberInfo.RowTemplate.Height = 23;
            this.dgvMemberInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberInfo.Size = new System.Drawing.Size(543, 404);
            this.dgvMemberInfo.TabIndex = 0;
            this.dgvMemberInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberInfo_CellDoubleClick);
            // 
            // MbId
            // 
            this.MbId.DataPropertyName = "MbId";
            this.MbId.HeaderText = "编号";
            this.MbId.Name = "MbId";
            this.MbId.ReadOnly = true;
            // 
            // MbName
            // 
            this.MbName.DataPropertyName = "MbName";
            this.MbName.HeaderText = "姓名";
            this.MbName.Name = "MbName";
            this.MbName.ReadOnly = true;
            // 
            // MbTypeTitle
            // 
            this.MbTypeTitle.DataPropertyName = "MbTypeTitle";
            this.MbTypeTitle.HeaderText = "类型";
            this.MbTypeTitle.Name = "MbTypeTitle";
            this.MbTypeTitle.ReadOnly = true;
            // 
            // MbPhone
            // 
            this.MbPhone.DataPropertyName = "MbPhone";
            this.MbPhone.HeaderText = "手机号";
            this.MbPhone.Name = "MbPhone";
            this.MbPhone.ReadOnly = true;
            // 
            // MbMoney
            // 
            this.MbMoney.DataPropertyName = "MbMoney";
            this.MbMoney.HeaderText = "账户余额";
            this.MbMoney.Name = "MbMoney";
            this.MbMoney.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearchPhone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSearchName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(567, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(14, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(201, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "显示全部";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Location = new System.Drawing.Point(71, 59);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(144, 21);
            this.txtSearchPhone.TabIndex = 3;
            this.txtSearchPhone.Leave += new System.EventHandler(this.txtSearchPhone_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "手机号：";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(71, 23);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(144, 21);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.Leave += new System.EventHandler(this.txtSearchName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓  名：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtMbMoney);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtMbPhone);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnTypeEdit);
            this.groupBox3.Controls.Add(this.cbMbType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtMbName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtMbId);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(567, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 287);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加/修改";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(14, 251);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(201, 23);
            this.btnDel.TabIndex = 15;
            this.btnDel.Text = "删除选中";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMbMoney
            // 
            this.txtMbMoney.Location = new System.Drawing.Point(71, 185);
            this.txtMbMoney.Name = "txtMbMoney";
            this.txtMbMoney.Size = new System.Drawing.Size(144, 21);
            this.txtMbMoney.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "余  额：";
            // 
            // txtMbPhone
            // 
            this.txtMbPhone.Location = new System.Drawing.Point(71, 154);
            this.txtMbPhone.Name = "txtMbPhone";
            this.txtMbPhone.Size = new System.Drawing.Size(144, 21);
            this.txtMbPhone.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "手机号：";
            // 
            // btnTypeEdit
            // 
            this.btnTypeEdit.Location = new System.Drawing.Point(71, 120);
            this.btnTypeEdit.Name = "btnTypeEdit";
            this.btnTypeEdit.Size = new System.Drawing.Size(144, 23);
            this.btnTypeEdit.TabIndex = 8;
            this.btnTypeEdit.Text = "类型管理";
            this.btnTypeEdit.UseVisualStyleBackColor = true;
            this.btnTypeEdit.Click += new System.EventHandler(this.btnTypeEdit_Click);
            // 
            // cbMbType
            // 
            this.cbMbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMbType.FormattingEnabled = true;
            this.cbMbType.Location = new System.Drawing.Point(71, 88);
            this.cbMbType.Name = "cbMbType";
            this.cbMbType.Size = new System.Drawing.Size(144, 20);
            this.cbMbType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "类  型：";
            // 
            // txtMbName
            // 
            this.txtMbName.Location = new System.Drawing.Point(71, 56);
            this.txtMbName.Name = "txtMbName";
            this.txtMbName.Size = new System.Drawing.Size(144, 21);
            this.txtMbName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "姓  名：";
            // 
            // txtMbId
            // 
            this.txtMbId.Location = new System.Drawing.Point(71, 25);
            this.txtMbId.Name = "txtMbId";
            this.txtMbId.ReadOnly = true;
            this.txtMbId.Size = new System.Drawing.Size(144, 21);
            this.txtMbId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "编  号：";
            // 
            // FormMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 448);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMemberInfo";
            this.Text = "会员管理";
            this.Load += new System.EventHandler(this.FormMemberInfo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMemberInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMbMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMbPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTypeEdit;
        private System.Windows.Forms.ComboBox cbMbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MbTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MbPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MbMoney;
    }
}