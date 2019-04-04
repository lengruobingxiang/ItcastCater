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
    public partial class FormDishTypeInfo : Form
    {
        public FormDishTypeInfo()
        {
            InitializeComponent();
        }

        DishTypeInfoBll dtiBll = new DishTypeInfoBll();
        DialogResult diaResult = DialogResult.Cancel;

        private void FormDishTypeInfo_Load(object sender, EventArgs e)
        {
            this.dgvDishTypeInfo.AutoGenerateColumns = false;
            LoadList();
        }

        private void LoadList()
        {
            this.dgvDishTypeInfo.DataSource = dtiBll.GetList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DishTypeInfo dti = new DishTypeInfo()
            {
                DTTitle = txtDTITitle.Text
            };
            if (btnAdd.Text == "添加")
            {
                if (dtiBll.Add(dti))
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtDTIId.Clear();
                    txtDTITitle.Clear();
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
                dti.DTId = ToInt32(txtDTIId.Text);
                if (dtiBll.Edit(dti))
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtDTIId.Clear();
                    txtDTITitle.Clear();
                    LoadList();
                    diaResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDTIId.Clear();
            txtDTITitle.Clear();
            btnAdd.Text = "添加";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var row = dgvDishTypeInfo.SelectedRows[0];
            int id = ToInt32(row.Cells["DTId"].Value);
            var result = MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (dtiBll.Remove(id))
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

        private void dgvDishTypeInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var row = dgvDishTypeInfo.Rows[index];
            txtDTIId.Text = row.Cells["DTId"].Value.ToString();
            txtDTITitle.Text = row.Cells["DTTitle"].Value.ToString();
            btnAdd.Text = "修改";
        }

        private void FormDishTypeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = diaResult;
        }
    }
}
