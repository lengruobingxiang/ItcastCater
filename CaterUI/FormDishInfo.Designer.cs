namespace CaterUI
{
    partial class FormDishInfo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDPinyin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTypeEdit = new System.Windows.Forms.Button();
            this.cbDType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDishInfo = new System.Windows.Forms.DataGridView();
            this.DId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPinyin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtDPinyin);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDPrice);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnTypeEdit);
            this.groupBox3.Controls.Add(this.cbDType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDTitle);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDId);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(567, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 287);
            this.groupBox3.TabIndex = 5;
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
            // txtDPinyin
            // 
            this.txtDPinyin.Location = new System.Drawing.Point(71, 185);
            this.txtDPinyin.Name = "txtDPinyin";
            this.txtDPinyin.Size = new System.Drawing.Size(144, 21);
            this.txtDPinyin.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "拼  音：";
            // 
            // txtDPrice
            // 
            this.txtDPrice.Location = new System.Drawing.Point(71, 154);
            this.txtDPrice.Name = "txtDPrice";
            this.txtDPrice.Size = new System.Drawing.Size(144, 21);
            this.txtDPrice.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "价  格：";
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
            // cbDType
            // 
            this.cbDType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDType.FormattingEnabled = true;
            this.cbDType.Location = new System.Drawing.Point(71, 88);
            this.cbDType.Name = "cbDType";
            this.cbDType.Size = new System.Drawing.Size(144, 20);
            this.cbDType.TabIndex = 7;
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
            // txtDTitle
            // 
            this.txtDTitle.Location = new System.Drawing.Point(71, 56);
            this.txtDTitle.Name = "txtDTitle";
            this.txtDTitle.Size = new System.Drawing.Size(144, 21);
            this.txtDTitle.TabIndex = 5;
            this.txtDTitle.TextChanged += new System.EventHandler(this.txtDTitle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "菜  名：";
            // 
            // txtDId
            // 
            this.txtDId.Location = new System.Drawing.Point(71, 25);
            this.txtDId.Name = "txtDId";
            this.txtDId.ReadOnly = true;
            this.txtDId.Size = new System.Drawing.Size(144, 21);
            this.txtDId.TabIndex = 3;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbSearchType);
            this.groupBox2.Controls.Add(this.btnSearchAll);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSearchTitle);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(567, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索";
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Location = new System.Drawing.Point(71, 59);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(142, 20);
            this.cbSearchType.TabIndex = 5;
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.Location = new System.Drawing.Point(14, 93);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(201, 23);
            this.btnSearchAll.TabIndex = 4;
            this.btnSearchAll.Text = "显示全部";
            this.btnSearchAll.UseVisualStyleBackColor = true;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "类  型：";
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(71, 23);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(144, 21);
            this.txtSearchTitle.TabIndex = 1;
            this.txtSearchTitle.Leave += new System.EventHandler(this.txtSearchTitle_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "菜  名：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvDishInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 422);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // dgvDishInfo
            // 
            this.dgvDishInfo.AllowUserToAddRows = false;
            this.dgvDishInfo.AllowUserToDeleteRows = false;
            this.dgvDishInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDishInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DId,
            this.DTitle,
            this.DPinyin,
            this.DTypeTitle,
            this.DPrice});
            this.dgvDishInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDishInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvDishInfo.MultiSelect = false;
            this.dgvDishInfo.Name = "dgvDishInfo";
            this.dgvDishInfo.ReadOnly = true;
            this.dgvDishInfo.RowTemplate.Height = 23;
            this.dgvDishInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDishInfo.Size = new System.Drawing.Size(543, 402);
            this.dgvDishInfo.TabIndex = 0;
            this.dgvDishInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDishInfo_CellDoubleClick);
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
            this.DTitle.HeaderText = "菜名";
            this.DTitle.Name = "DTitle";
            this.DTitle.ReadOnly = true;
            // 
            // DPinyin
            // 
            this.DPinyin.DataPropertyName = "DPinyin";
            this.DPinyin.HeaderText = "拼音";
            this.DPinyin.Name = "DPinyin";
            this.DPinyin.ReadOnly = true;
            // 
            // DTypeTitle
            // 
            this.DTypeTitle.DataPropertyName = "DTypeTitle";
            this.DTypeTitle.HeaderText = "类型";
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
            // FormDishInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 448);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDishInfo";
            this.Text = "菜单管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDishInfo_FormClosed);
            this.Load += new System.EventHandler(this.FormDishInfo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDPinyin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTypeEdit;
        private System.Windows.Forms.ComboBox cbDType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDishInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPinyin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPrice;
        private System.Windows.Forms.ComboBox cbSearchType;
    }
}