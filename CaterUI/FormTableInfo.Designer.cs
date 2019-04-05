namespace CaterUI
{
    partial class FormTableInfo
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
            this.rbBusy = new System.Windows.Forms.RadioButton();
            this.rbFree = new System.Windows.Forms.RadioButton();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTHallEdit = new System.Windows.Forms.Button();
            this.cbTHall = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSearchFree = new System.Windows.Forms.ComboBox();
            this.cbSearchHall = new System.Windows.Forms.ComboBox();
            this.btnSearchAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTableInfo = new System.Windows.Forms.DataGridView();
            this.TId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THallTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIsFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbBusy);
            this.groupBox3.Controls.Add(this.rbFree);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnTHallEdit);
            this.groupBox3.Controls.Add(this.cbTHall);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTTitle);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTId);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(567, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 287);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加/修改";
            // 
            // rbBusy
            // 
            this.rbBusy.AutoSize = true;
            this.rbBusy.Location = new System.Drawing.Point(156, 173);
            this.rbBusy.Name = "rbBusy";
            this.rbBusy.Size = new System.Drawing.Size(59, 16);
            this.rbBusy.TabIndex = 17;
            this.rbBusy.TabStop = true;
            this.rbBusy.Text = "使用中";
            this.rbBusy.UseVisualStyleBackColor = true;
            // 
            // rbFree
            // 
            this.rbFree.AutoSize = true;
            this.rbFree.Checked = true;
            this.rbFree.Location = new System.Drawing.Point(71, 173);
            this.rbFree.Name = "rbFree";
            this.rbFree.Size = new System.Drawing.Size(47, 16);
            this.rbFree.TabIndex = 16;
            this.rbFree.TabStop = true;
            this.rbFree.Text = "空闲";
            this.rbFree.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "空  闲：";
            // 
            // btnTHallEdit
            // 
            this.btnTHallEdit.Location = new System.Drawing.Point(71, 120);
            this.btnTHallEdit.Name = "btnTHallEdit";
            this.btnTHallEdit.Size = new System.Drawing.Size(144, 23);
            this.btnTHallEdit.TabIndex = 8;
            this.btnTHallEdit.Text = "厅包管理";
            this.btnTHallEdit.UseVisualStyleBackColor = true;
            this.btnTHallEdit.Click += new System.EventHandler(this.btnTHallEdit_Click);
            // 
            // cbTHall
            // 
            this.cbTHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTHall.FormattingEnabled = true;
            this.cbTHall.Location = new System.Drawing.Point(71, 88);
            this.cbTHall.Name = "cbTHall";
            this.cbTHall.Size = new System.Drawing.Size(144, 20);
            this.cbTHall.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "厅  包：";
            // 
            // txtTTitle
            // 
            this.txtTTitle.Location = new System.Drawing.Point(71, 56);
            this.txtTTitle.Name = "txtTTitle";
            this.txtTTitle.Size = new System.Drawing.Size(144, 21);
            this.txtTTitle.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "名  称：";
            // 
            // txtTId
            // 
            this.txtTId.Location = new System.Drawing.Point(71, 25);
            this.txtTId.Name = "txtTId";
            this.txtTId.ReadOnly = true;
            this.txtTId.Size = new System.Drawing.Size(144, 21);
            this.txtTId.TabIndex = 3;
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
            this.groupBox2.Controls.Add(this.cbSearchFree);
            this.groupBox2.Controls.Add(this.cbSearchHall);
            this.groupBox2.Controls.Add(this.btnSearchAll);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(567, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 131);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索";
            // 
            // cbSearchFree
            // 
            this.cbSearchFree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchFree.FormattingEnabled = true;
            this.cbSearchFree.Location = new System.Drawing.Point(71, 59);
            this.cbSearchFree.Name = "cbSearchFree";
            this.cbSearchFree.Size = new System.Drawing.Size(142, 20);
            this.cbSearchFree.TabIndex = 7;
            this.cbSearchFree.SelectedIndexChanged += new System.EventHandler(this.cbSearchFree_SelectedIndexChanged);
            // 
            // cbSearchHall
            // 
            this.cbSearchHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchHall.FormattingEnabled = true;
            this.cbSearchHall.Location = new System.Drawing.Point(71, 23);
            this.cbSearchHall.Name = "cbSearchHall";
            this.cbSearchHall.Size = new System.Drawing.Size(142, 20);
            this.cbSearchHall.TabIndex = 6;
            this.cbSearchHall.SelectedIndexChanged += new System.EventHandler(this.cbSearchHall_SelectedIndexChanged);
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
            this.label2.Text = "空  闲：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "厅  包：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvTableInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 424);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // dgvTableInfo
            // 
            this.dgvTableInfo.AllowUserToAddRows = false;
            this.dgvTableInfo.AllowUserToDeleteRows = false;
            this.dgvTableInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TId,
            this.TTitle,
            this.THallTitle,
            this.TIsFree});
            this.dgvTableInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTableInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvTableInfo.MultiSelect = false;
            this.dgvTableInfo.Name = "dgvTableInfo";
            this.dgvTableInfo.ReadOnly = true;
            this.dgvTableInfo.RowTemplate.Height = 23;
            this.dgvTableInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTableInfo.Size = new System.Drawing.Size(543, 404);
            this.dgvTableInfo.TabIndex = 0;
            this.dgvTableInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableInfo_CellDoubleClick);
            this.dgvTableInfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTableInfo_CellFormatting);
            // 
            // TId
            // 
            this.TId.DataPropertyName = "TId";
            this.TId.HeaderText = "编号";
            this.TId.Name = "TId";
            this.TId.ReadOnly = true;
            // 
            // TTitle
            // 
            this.TTitle.DataPropertyName = "TTitle";
            this.TTitle.HeaderText = "名称";
            this.TTitle.Name = "TTitle";
            this.TTitle.ReadOnly = true;
            // 
            // THallTitle
            // 
            this.THallTitle.DataPropertyName = "THallTitle";
            this.THallTitle.HeaderText = "厅包";
            this.THallTitle.Name = "THallTitle";
            this.THallTitle.ReadOnly = true;
            // 
            // TIsFree
            // 
            this.TIsFree.DataPropertyName = "TIsFree";
            this.TIsFree.HeaderText = "状态";
            this.TIsFree.Name = "TIsFree";
            this.TIsFree.ReadOnly = true;
            // 
            // FormTableInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 448);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTableInfo";
            this.Text = "餐桌管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTableInfo_FormClosed);
            this.Load += new System.EventHandler(this.FormTableInfo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTHallEdit;
        private System.Windows.Forms.ComboBox cbTHall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTableInfo;
        private System.Windows.Forms.ComboBox cbSearchHall;
        private System.Windows.Forms.RadioButton rbBusy;
        private System.Windows.Forms.RadioButton rbFree;
        private System.Windows.Forms.ComboBox cbSearchFree;
        private System.Windows.Forms.DataGridViewTextBoxColumn TId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn THallTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIsFree;
    }
}