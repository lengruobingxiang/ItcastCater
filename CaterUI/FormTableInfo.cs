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
    public partial class FormTableInfo : Form
    {
        private FormTableInfo()
        {
            InitializeComponent();
        }

        TableInfoBll tiBll = new TableInfoBll();
        static FormTableInfo _form = null;

        public event Action TableChanged;

        private void FormTableInfo_Load(object sender, EventArgs e)
        {
            this.dgvTableInfo.AutoGenerateColumns = false;
            LoadHallList();
            LoadList();
        }

        private void LoadList()
        {
            Dictionary<string, string> paras = new Dictionary<string, string>();
            if (cbSearchHall.SelectedIndex != 0)
            {
                paras.Add("THallId", cbSearchHall.SelectedValue.ToString());
            }
            if (cbSearchFree.SelectedIndex != -1)
            {
                paras.Add("TIsFree", cbSearchFree.Text == "空闲" ? "1" : "0");
            }
            this.dgvTableInfo.DataSource = tiBll.GetList(paras);
        }

        private void LoadHallList()
        {
            List<HallInfo> list = new List<HallInfo>();
            list.Add(new HallInfo()
            {
                HId = 0,
                HTitle = "全部"
            });
            list.AddRange((new HallInfoBll()).GetList());
            this.cbSearchHall.DataSource = list;
            this.cbSearchHall.DisplayMember = "HTitle";
            this.cbSearchHall.ValueMember = "HId";
            this.cbTHall.DataSource = (new HallInfoBll()).GetList();
            this.cbTHall.DisplayMember = "HTitle";
            this.cbTHall.ValueMember = "HId";
            this.cbTHall.SelectedIndex = -1;
            cbSearchFree.Items.AddRange(new string[] { "空闲", "使用中" });
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            this.cbSearchHall.SelectedIndex = 0;
            this.cbSearchFree.SelectedIndex = -1;
            LoadList();
        }

        private void cbSearchHall_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void cbSearchFree_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TableInfo ti = new TableInfo()
            {
                TTitle = txtTTitle.Text,
                THallId = ToInt32(cbTHall.SelectedValue),
                TIsFree = rbFree.Checked
            };
            if (btnAdd.Text == "添加")
            {
                if (tiBll.Add(ti))
                {
                    MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtTTitle.Clear();
                    cbTHall.SelectedIndex = -1;
                    rbFree.Checked = true;
                    LoadList();
                    TableChanged();
                }
                else
                {
                    MessageBox.Show("添加失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnAdd.Text == "修改")
            {
                ti.TId = ToInt32(txtTId.Text);
                if (tiBll.Edit(ti))
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    txtTId.Clear();
                    txtTTitle.Clear();
                    cbTHall.SelectedIndex = -1;
                    rbFree.Checked = true;
                    btnAdd.Text = "添加";
                    LoadList();
                    TableChanged();
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static FormTableInfo Create()
        {
            if (_form == null)
            {
                _form = new FormTableInfo();
            }
            return _form;
        }

        private void dgvTableInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvTableInfo.Rows[e.RowIndex];
            txtTId.Text = row.Cells["TId"].Value.ToString();
            txtTTitle.Text = row.Cells["TTitle"].Value.ToString();
            rbFree.Checked = ToBoolean(row.Cells["TIsFree"].Value.ToString());
            rbBusy.Checked = !rbFree.Checked;
            cbTHall.Text = row.Cells["THallTitle"].Value.ToString();
            btnAdd.Text = "修改";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTId.Clear();
            txtTTitle.Clear();
            cbTHall.SelectedIndex = -1;
            rbFree.Checked = true;
            btnAdd.Text = "添加";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var row = dgvTableInfo.SelectedRows[0];
            int id = ToInt32(row.Cells["TId"].Value);
            if (MessageBox.Show("确认删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }
            if (tiBll.Remove(id))
            {
                MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                LoadList();
                TableChanged();
            }
        }

        private void btnTHallEdit_Click(object sender, EventArgs e)
        {
            FormHallInfo hi = new FormHallInfo();
            if (hi.ShowDialog() == DialogResult.OK)
            {
                LoadHallList();
                TableChanged();
            }
        }

        private void dgvTableInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = ToBoolean(e.Value) ? "空闲" : "使用中";
            }
        }

        private void FormTableInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form = null;
        }
    }
}
