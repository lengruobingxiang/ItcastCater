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
    public partial class FormMemberInfo : Form
    {
        private FormMemberInfo()
        {
            InitializeComponent();
        }

        MemberInfoBll miBll = new MemberInfoBll();
        int dgvSelectedIndex = -1;
        static FormMemberInfo _form = null;

        public static FormMemberInfo Create()
        {
            if (_form == null)
            {
                _form = new FormMemberInfo();
            }
            return _form;
        }

        private void FormMemberInfo_Load(object sender, EventArgs e)
        {
            dgvMemberInfo.AutoGenerateColumns = false;
            LoadMemberList();
            LoadMemberTypeList();
        }

        private void LoadMemberTypeList()
        {
            MemberTypeInfoBll mtiBll = new MemberTypeInfoBll();
            List<MemberTypeInfo> list = mtiBll.GetList();
            cbMbType.DataSource = list;
            cbMbType.DisplayMember = "MTTitle";
            cbMbType.ValueMember = "MTId";
            cbMbType.SelectedIndex = -1;
        }

        private void LoadMemberList()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (txtSearchName.Text != string.Empty)
            {
                dic.Add("MbName", txtSearchName.Text);
            }
            if (txtSearchPhone.Text != string.Empty)
            {
                dic.Add("MbPhone", txtSearchPhone.Text);
            }
            dgvMemberInfo.DataSource = miBll.GetList(dic);
            if (dgvSelectedIndex > -1)
            {
                dgvMemberInfo.Rows[dgvSelectedIndex].Selected = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearchName.Clear();
            txtSearchPhone.Clear();
            LoadMemberList();
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void txtSearchPhone_Leave(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemberInfo mi = new MemberInfo()
            {
                MbName = txtMbName.Text,
                MbTypeId = ToInt32(cbMbType.SelectedValue),
                MbTypeTitle = cbMbType.SelectedText,
                MbPhone = txtMbPhone.Text,
                MbMoney = ToDecimal(txtMbMoney.Text)
            };
            if (btnAdd.Text == "添加")
            {
                if (miBll.Add(mi))
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtMbName.Clear();
                    txtMbMoney.Clear();
                    txtMbPhone.Clear();
                    cbMbType.SelectedIndex = -1;
                    LoadMemberList();
                }
            }
            else if (btnAdd.Text == "修改")
            {
                mi.MbId = ToInt32(txtMbId.Text);
                if (miBll.Edit(mi))
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtMbName.Clear();
                    txtMbMoney.Clear();
                    txtMbPhone.Clear();
                    cbMbType.SelectedIndex = -1;
                    btnAdd.Text = "添加";
                    LoadMemberList();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMbId.Clear();
            txtMbName.Clear();
            txtMbMoney.Clear();
            txtMbPhone.Clear();
            cbMbType.SelectedIndex = -1;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var row = dgvMemberInfo.SelectedRows[0];
            int id = ToInt32(row.Cells["MbId"]);
            miBll.Remove(id);
        }

        private void dgvMemberInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            dgvSelectedIndex = index;
            var row = dgvMemberInfo.Rows[index];
            txtMbId.Text = row.Cells["MbId"].Value.ToString();
            txtMbName.Text = row.Cells["MbName"].Value.ToString();
            txtMbMoney.Text = row.Cells["MbMoney"].Value.ToString();
            txtMbPhone.Text = row.Cells["MbPhone"].Value.ToString();
            cbMbType.Text = row.Cells["MbTypeTitle"].Value.ToString();
            btnAdd.Text = "修改";
        }

        private void btnTypeEdit_Click(object sender, EventArgs e)
        {
            FormMemberTypeInfo formMTI = new FormMemberTypeInfo();
            DialogResult result = formMTI.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadMemberTypeList();
                LoadMemberList();
            }
        }
    }
}
