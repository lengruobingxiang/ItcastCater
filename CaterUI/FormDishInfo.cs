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
    public partial class FormDishInfo : Form
    {
        private FormDishInfo()
        {
            InitializeComponent();
        }

        DishInfoBll diBll = new DishInfoBll();
        static FormDishInfo _form = null;

        private void FormDishInfo_Load(object sender, EventArgs e)
        {
            this.dgvDishInfo.AutoGenerateColumns = false;
            LoadList();
            LoadTypeList();
        }

        private void LoadList()
        {
            Dictionary<string, string> paras = new Dictionary<string, string>();
            if (txtSearchTitle.Text != string.Empty)
            {
                paras.Add("DTitle", txtSearchTitle.Text);
            }
            if (cbSearchType.SelectedIndex != 0)
            {
                paras.Add("DTTitle", cbSearchType.Text);
            }
            this.dgvDishInfo.DataSource = diBll.GetList(paras);
        }

        private void LoadTypeList()
        {
            this.cbDType.DataSource = (new DishTypeInfoBll()).GetList();
            this.cbDType.DisplayMember = "DTTitle";
            this.cbDType.ValueMember = "DTId";
            this.cbDType.SelectedIndex = -1;
            List<DishTypeInfo> list = new List<DishTypeInfo>();
            list.Add(new DishTypeInfo()
            {
                DTId = 0,
                DTTitle = "全部"
            });
            list.AddRange((new DishTypeInfoBll()).GetList());
            this.cbSearchType.DataSource = list;
            this.cbSearchType.DisplayMember = "DTTitle";
            this.cbSearchType.ValueMember = "DTId";
        }

        public static FormDishInfo Create()
        {
            if (_form == null)
            {
                _form = new FormDishInfo();
            }
            return _form;
        }
        private void txtSearchTitle_Leave(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            this.txtSearchTitle.Clear();
            this.cbSearchType.SelectedIndex = -1;
            LoadList();
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DishInfo di = new DishInfo()
            {
                DPinyin = txtDPinyin.Text,
                DPrice = ToDecimal(txtDPrice.Text),
                DTitle = txtDTitle.Text,
                DTypeId = ToInt32(cbDType.SelectedValue)
            };
            if (btnAdd.Text == "添加")
            {
                if (diBll.Add(di))
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtDPinyin.Clear();
                    txtDPrice.Clear();
                    txtDTitle.Clear();
                    cbDType.SelectedIndex = -1;
                    LoadList();
                }
                else
                {
                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnAdd.Text == "修改")
            {
                di.DId = ToInt32(txtDId.Text);
                if (diBll.Edit(di))
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtDId.Clear();
                    txtDPinyin.Clear();
                    txtDPrice.Clear();
                    txtDTitle.Clear();
                    cbDType.SelectedIndex = -1;
                    btnAdd.Text = "添加";
                    LoadList();
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvDishInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvDishInfo.Rows[e.RowIndex];
            txtDId.Text = row.Cells["DId"].Value.ToString();
            txtDPinyin.Text = row.Cells["DPinyin"].Value.ToString();
            txtDPrice.Text = row.Cells["DPrice"].Value.ToString();
            txtDTitle.Text = row.Cells["DTitle"].Value.ToString();
            cbDType.Text = row.Cells["DTypeTitle"].Value.ToString();
            btnAdd.Text = "修改";
        }

        private void txtDTitle_TextChanged(object sender, EventArgs e)
        {
            txtDPinyin.Text = PinyinHelper.GetPinyinInitial(txtDTitle.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDId.Clear();
            txtDPinyin.Clear();
            txtDPrice.Clear();
            txtDTitle.Clear();
            cbDType.SelectedIndex = -1;
            btnAdd.Text = "添加";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var row = dgvDishInfo.SelectedRows[0];
            int id = ToInt32(row.Cells["DId"].Value);
            if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            } 
            if (diBll.Remove(id))
            {
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadList();
            }
        }

        private void btnTypeEdit_Click(object sender, EventArgs e)
        {
            FormDishTypeInfo dti = new FormDishTypeInfo();
            if (dti.ShowDialog() == DialogResult.OK)
            {
                LoadTypeList();
            }
        }

        private void FormDishInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form = null;
        }
    }
}
