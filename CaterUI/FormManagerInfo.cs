using CaterBll;
using CaterCommon;
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
    public partial class FormManagerInfo : Form
    {
        public FormManagerInfo()
        {
            InitializeComponent();
        }

        // 创建业务逻辑层对象
        ManagerInfoBll mIBll = new ManagerInfoBll();

        private void FormManagerInfo_Load(object sender, EventArgs e)
        {
            // 加载列表
            LoadList();
        }

        private void LoadList()
        {
            // 禁止DataGridView自动增加列
            this.dgvManagerInfoList.AutoGenerateColumns = false;
            // 把业务逻辑层返回的集合作为数据源
            this.dgvManagerInfoList.DataSource = mIBll.GetList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo()
            {
                MName = this.tbMName.Text,
                MPwd = Md5Helper.EncryptString(this.tbMPwd.Text),
                MType = ToInt32(this.rbManager.Checked)
            };
            if (this.btnAdd.Text == "添加")
            {
                if (mIBll.Add(mi))
                {
                    // 如果添加成功，则重新加载数据
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    tbMName.Clear();
                    tbMPwd.Clear();
                    rbEmployee.Checked = true;
                    LoadList();
                }
                else
                {
                    MessageBox.Show("添加失败，请稍后重试！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.btnAdd.Text == "修改")
            {
                mi.MId = ToInt32(tbMId.Text);
                if (mIBll.Edit(mi))
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    tbMId.Clear();
                    tbMName.Clear();
                    tbMPwd.Clear();
                    rbEmployee.Checked = true;
                    this.btnAdd.Text = "添加";
                    LoadList();
                }
            }
        }

        // 改变MType的显示
        private void dgvManagerInfoList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 对第三列进行设置
            if (e.ColumnIndex == 2)
            {
                e.Value = ToInt32(e.Value) == 1 ? "经理" : "店员";
            }
        }

        // 双击单元格显示信息
        private void dgvManagerInfoList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvManagerInfoList.Rows[e.RowIndex];
            tbMId.Text = row.Cells["Mid"].Value.ToString();
            tbMName.Text = row.Cells["MName"].Value.ToString();
            tbMPwd.Text = "这是原来的密码吗？";
            rbManager.Checked = ToBoolean(row.Cells["MType"].Value);
            rbEmployee.Checked = !rbManager.Checked;
            btnAdd.Text = "修改";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbMId.Clear();
            tbMName.Clear();
            tbMPwd.Clear();
            rbEmployee.Checked = true;
            this.btnAdd.Text = "添加";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var rows = dgvManagerInfoList.SelectedRows;
            if (rows.Count > 0)
            {
                int mId = ToInt32(rows[0].Cells["MId"].Value);
                if (MessageBox.Show($"你真的要删除编号为{mId}的账户吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (mIBll.Remove(mId))
                    {
                        MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                        LoadList();
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择要删除的行！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
