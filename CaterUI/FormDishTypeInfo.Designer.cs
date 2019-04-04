namespace CaterUI
{
    partial class FormDishTypeInfo
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
            this.dgvDishTypeInfo = new System.Windows.Forms.DataGridView();
            this.DTId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDTITitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDTIId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishTypeInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvDishTypeInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表";
            // 
            // dgvDishTypeInfo
            // 
            this.dgvDishTypeInfo.AllowUserToAddRows = false;
            this.dgvDishTypeInfo.AllowUserToDeleteRows = false;
            this.dgvDishTypeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDishTypeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishTypeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DTId,
            this.DTTitle});
            this.dgvDishTypeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDishTypeInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvDishTypeInfo.Name = "dgvDishTypeInfo";
            this.dgvDishTypeInfo.ReadOnly = true;
            this.dgvDishTypeInfo.RowTemplate.Height = 23;
            this.dgvDishTypeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDishTypeInfo.Size = new System.Drawing.Size(243, 204);
            this.dgvDishTypeInfo.TabIndex = 0;
            this.dgvDishTypeInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDishTypeInfo_CellDoubleClick);
            // 
            // DTId
            // 
            this.DTId.DataPropertyName = "DTId";
            this.DTId.HeaderText = "编号";
            this.DTId.Name = "DTId";
            this.DTId.ReadOnly = true;
            // 
            // DTTitle
            // 
            this.DTTitle.DataPropertyName = "DTTitle";
            this.DTTitle.HeaderText = "种类";
            this.DTTitle.Name = "DTTitle";
            this.DTTitle.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtDTITitle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDTIId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(267, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "添加/修改";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(23, 178);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(168, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除选中";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(116, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDTITitle
            // 
            this.txtDTITitle.Location = new System.Drawing.Point(68, 79);
            this.txtDTITitle.Name = "txtDTITitle";
            this.txtDTITitle.Size = new System.Drawing.Size(123, 21);
            this.txtDTITitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "种类：";
            // 
            // txtDTIId
            // 
            this.txtDTIId.Location = new System.Drawing.Point(68, 35);
            this.txtDTIId.Name = "txtDTIId";
            this.txtDTIId.ReadOnly = true;
            this.txtDTIId.Size = new System.Drawing.Size(123, 21);
            this.txtDTIId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号：";
            // 
            // FormDishTypeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 248);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDishTypeInfo";
            this.Text = "菜单分类管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDishTypeInfo_FormClosed);
            this.Load += new System.EventHandler(this.FormDishTypeInfo_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishTypeInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDishTypeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDTITitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDTIId;
        private System.Windows.Forms.Label label1;
    }
}