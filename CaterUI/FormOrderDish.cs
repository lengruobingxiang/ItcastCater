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
    public partial class FormOrderDish : Form
    {
        public FormOrderDish()
        {
            InitializeComponent();
        }

        DishInfoBll diBll = new DishInfoBll();
        OrderDishBll odBll = new OrderDishBll();
        OrderInfoBll oiBll = new OrderInfoBll();

        List<OrderDetailInfo> detailList = new List<OrderDetailInfo>();
        TableInfo table;

        private void FormOrderDish_Load(object sender, EventArgs e)
        {
            table  = this.Tag as TableInfo;
            LoadDishTypeInfo();
            LoadDishInfo();
            LoadOrderDetailInfo();
        }

        private void LoadDishInfo()
        {
            dgvDishInfo.AutoGenerateColumns = false;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (txtDPinyin.Text != string.Empty)
            {
                dic.Add("DPinyin", txtDPinyin.Text.ToUpper());
            }
            if (cbDTypeTitle.Text != "全部")
            {
                dic.Add("DTypeId", cbDTypeTitle.SelectedValue.ToString());
            }
            var list = diBll.GetList(dic);
            dgvDishInfo.DataSource = list;
        }

        private void LoadDishTypeInfo()
        {
            cbDTypeTitle.Items.Clear();
            List<DishTypeInfo> list = new List<DishTypeInfo>();
            list.Add(new DishTypeInfo()
            {
                DTId = 0,
                DTTitle = "全部"
            });
            list.AddRange(new DishTypeInfoBll().GetList());
            cbDTypeTitle.DataSource = list;
            cbDTypeTitle.ValueMember = "DTId";
            cbDTypeTitle.DisplayMember = "DTTitle";
            cbDTypeTitle.SelectedIndex = 0;
        }

        private void LoadOrderDetailInfo()
        {
            dgvOrderDetail.AutoGenerateColumns = false;
            detailList = odBll.GetList(this.table.TOrderId);
            dgvOrderDetail.DataSource = detailList;
            lblTotalMoney.Text = GetTotalMoney().ToString();
        }

        private void CbDTypeTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDishInfo();
        }

        private void TxtDPinyin_TextChanged(object sender, EventArgs e)
        {
            LoadDishInfo();
        }

        private void DgvDishInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int dishId = ToInt32(dgvDishInfo.Rows[e.RowIndex].Cells["DId"].Value);
            int? index = GetDishIndex(dishId);
            if (index != null)
            {
                // 已经点过这个菜，数量直接+1
                var detail = detailList[index.Value];
                detail.ODCount++;
                odBll.Edit(detail);
            }
            else
            {
                // 没有点过这个菜，增加行
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("DId", dishId.ToString());
                var di = diBll.GetList(dic)[0];
                odBll.Add(new OrderDetailInfo()
                {
                    ODOrderId = table.TOrderId,
                    ODDishId = dishId,
                    ODDishTitle = di.DTitle,
                    ODSinglePrice = di.DPrice,
                    ODCount = 1,
                });
            }
            LoadOrderDetailInfo();
        }

        private void DgvOrderDetail_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (detailList != null && detailList.Count != 0 && e.ColumnIndex == 3)
            {
                var row = dgvOrderDetail.Rows[e.RowIndex];
                int dishId = ToInt32(row.Cells["ODDishId"].Value);
                int newCount = ToInt32(row.Cells["ODCount"].Value);
                var odi = detailList[GetDishIndex(dishId).Value];
                odi.ODCount = newCount;
                odBll.Edit(odi);
                row.Cells["ODTotalPrice"].Value = odi.ODTotalPrice;
                // 更新值以后需要刷新dgv控件
                dgvOrderDetail.Refresh();
                lblTotalMoney.Text = GetTotalMoney().ToString();
            }
        }

        // 判断菜品是否已经被点过，点过则返回在集合中的索引
        private int? GetDishIndex(int dishId)
        {
            int? index = null;
            int count = detailList.Count;
            for (int i = 0; i < count; i++)
            {
                if (detailList[i].ODDishId == dishId)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        // 获得当前订单总金额
        private decimal GetTotalMoney()
        {
            decimal total = 0;
            foreach (OrderDetailInfo odi in detailList)
            {
                decimal temp = odi.ODTotalPrice;
                total += temp;
            }
            return total;
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (oiBll.SetOrderMoney(table.TOrderId, ToDecimal(lblTotalMoney.Text)))
            {
                MessageBox.Show("下单成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("下单失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var row = dgvOrderDetail.SelectedRows[0];
                int dishId = ToInt32(row.Cells["ODDishId"].Value);
                OrderDetailInfo odi = detailList[GetDishIndex(dishId).Value];
                if (odBll.Remove(odi) && oiBll.SetOrderMoney(table.TOrderId, ToDecimal(lblTotalMoney.Text)))
                {
                    LoadOrderDetailInfo();
                    MessageBox.Show("删除成功！", "提示");
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
