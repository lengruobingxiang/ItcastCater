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
    public partial class FormHallInfo : Form
    {
        public FormHallInfo()
        {
            InitializeComponent();
        }

        HallInfoBll hiBll = new HallInfoBll();
        DialogResult diaResult = DialogResult.Cancel;

        private void FormHallInfo_Load(object sender, EventArgs e)
        {
            this.dgvHallInfo.AutoGenerateColumns = false;
            LoadList();
        }

        private void LoadList()
        {
            this.dgvHallInfo.DataSource = hiBll.GetList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HallInfo hi = new HallInfo()
            {
                HTitle = txtHTitle.Text
            };
            if (btnAdd.Text == "添加")
            {
                if (hiBll.Add(hi))
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtHId.Clear();
                    txtHTitle.Clear();
                    LoadList();
                    diaResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnAdd.Text == "修改")
            {
                hi.HId = ToInt32(txtHId.Text);
                if (hiBll.Edit(hi))
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtHId.Clear();
                    txtHTitle.Clear();
                    diaResult = DialogResult.OK;
                    LoadList();
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtHId.Clear();
            txtHTitle.Clear();
            btnAdd.Text = "添加";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var row = dgvHallInfo.SelectedRows[0];
            int id = ToInt32(row.Cells["HId"].Value);
            var result = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (hiBll.Remove(id))
            {
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadList();
                diaResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHallInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var row = dgvHallInfo.Rows[index];
            txtHId.Text = row.Cells["HId"].Value.ToString();
            txtHTitle.Text = row.Cells["HTitle"].Value.ToString();
            btnAdd.Text = "修改";
        }

        private void FormHallInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = diaResult;
        }
    }
}
