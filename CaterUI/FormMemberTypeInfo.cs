using CaterBll;
using CaterModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;

namespace CaterUI
{
    public partial class FormMemberTypeInfo : Form
    {
        public FormMemberTypeInfo()
        {
            InitializeComponent();
        }

        MemberTypeInfoBll mtiBll = new MemberTypeInfoBll();
        DialogResult result = DialogResult.Cancel;
        int dgvSelectedIndex = -1;

        private void FormMemberTypeInfo_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void FormLoad()
        {
            this.dgvMemberTypeInfo.AutoGenerateColumns = false;
            this.dgvMemberTypeInfo.DataSource = mtiBll.GetList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemberTypeInfo mti = new MemberTypeInfo()
            {
                MTTitle = this.txtMTTitle.Text,
                MTDiscount = ToDecimal(this.txtMTDiscount.Text)
            };
            if (this.btnAdd.Text == "添加")
            {
                if (mtiBll.Add(mti))
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    FormLoad();
                    result = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.btnAdd.Text == "修改")
            {
                mti.MTId = ToInt32(txtMTId.Text);
                if (mtiBll.Edit(mti))
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    FormLoad();
                    if (dgvSelectedIndex > -1)
                    {
                        dgvMemberTypeInfo.Rows[dgvSelectedIndex].Selected = true;
                    }
                    result = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.txtMTId.Clear();
            this.txtMTTitle.Clear();
            this.txtMTDiscount.Clear();
            this.btnAdd.Text = "添加";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtMTId.Clear();
            this.txtMTTitle.Clear();
            this.txtMTDiscount.Clear();
            this.btnAdd.Text = "添加";
        }

        private void dgvMemberTypeInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            dgvSelectedIndex = rowIndex;
            DataGridViewRow row = dgvMemberTypeInfo.Rows[rowIndex];
            txtMTId.Text = row.Cells["MTId"].Value.ToString();
            txtMTTitle.Text = row.Cells["MTTitle"].Value.ToString();
            txtMTDiscount.Text = row.Cells["MTDiscount"].Value.ToString();
            btnAdd.Text = "修改";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var row = dgvMemberTypeInfo.SelectedRows[0];
            int id = ToInt32(row.Cells["MTId"].Value);
            if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            if (mtiBll.Remove(id))
            {
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                FormLoad();
                result = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMemberTypeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}
