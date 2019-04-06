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
    public partial class FormMain : Form
    {
        ManagerInfo LoginManager = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin(this);
            formLogin.ShowDialog();
            LoginManager = (ManagerInfo)this.Tag;
            // 如果登录的是店员，则不显示店员管理按钮
            if (LoginManager != null && LoginManager.MType == 0)
            {
                MenuManagerInfo.Visible = false;

            }
            LoadHallInfo();
        }

        private void MenuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认退出？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MenuManagerInfo_Click(object sender, EventArgs e)
        {
            FormManagerInfo managerInfo = FormManagerInfo.Create();
            managerInfo.Show();
            managerInfo.Focus();
        }

        private void MenuMemberInfo_Click(object sender, EventArgs e)
        {
            FormMemberInfo memberInfo = FormMemberInfo.Create();
            memberInfo.Show();
            memberInfo.Focus();
        }

        // 在TabControl控件中动态添加厅包
        private void LoadHallInfo()
        {
            tcHallInfo.TabPages.Clear();
            HallInfoBll hiBll = new HallInfoBll();
            TableInfoBll tiBll = new TableInfoBll();
            var halls = hiBll.GetList();
            foreach (var hall in halls)
            {
                // 根据厅包对象创建标签页对象
                TabPage tp = new TabPage(hall.HTitle);
                // 获取厅包对象的所有餐桌
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("THallId", hall.HId.ToString());
                var tables = tiBll.GetList(dic);
                // 创建ListView控件
                ListView lvTableInfo = new ListView();
                lvTableInfo.Dock = DockStyle.Fill;
                lvTableInfo.LargeImageList = ilTable;
                lvTableInfo.MouseDoubleClick += LvTableInfo_MouseDoubleClick;
                foreach (var table in tables)
                {
                    ListViewItem lvi = new ListViewItem(table.TTitle, table.TIsFree ? "Free" : "Busy");
                    // 在lvi的tag属性中保存TableId属性值
                    lvi.Tag = table;
                    lvTableInfo.Items.Add(lvi);
                }
                // 将ListView控件添加到TabPage中
                tp.Controls.Add(lvTableInfo);
                // 将标签页加入到TabControl中
                tcHallInfo.TabPages.Add(tp);
            }
        }

        // 双击餐桌，开单
        private void LvTableInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TableInfoBll tiBll = new TableInfoBll();
            OrderInfoBll oiBll = new OrderInfoBll();

            // 获取餐桌编号
            var lviTable = (sender as ListView).SelectedItems[0];
            TableInfo ti = lviTable.Tag as TableInfo;

            // 餐桌空闲->点菜
            if (ti.TIsFree)
            {
                if (tiBll.ChangeState(ti.TId) && oiBll.PlaceOrder(ti.TId))
                {
                    lviTable.ImageKey = "Busy";
                    ti.TIsFree = false;
                    ti.TOrderType = OrderType.Order;
                }
            }
            else
            {
                ti.TOrderType = OrderType.Add;
            }

            ti.TOrderId = oiBll.GetOrderIdByTableId(ti.TId);

            // 弹出点餐窗口
            FormOrderDish od = new FormOrderDish();
            od.Tag = ti;
            od.Show();
        }

        private void MenuTableInfo_Click(object sender, EventArgs e)
        {
            FormTableInfo ti = FormTableInfo.Create();
            ti.Show();
            ti.Focus();
            ti.TableChanged += LoadHallInfo;
        }


        private void MenuDishInfo_Click(object sender, EventArgs e)
        {
            FormDishInfo di = FormDishInfo.Create();
            di.Show();
            di.Focus();
        }

        private void MenuOrder_Click(object sender, EventArgs e)
        {
            TabPage tb = tcHallInfo.SelectedTab;
            ListView lv = tb.Controls[0] as ListView;
            ListViewItem table = lv.SelectedItems[0];
            TableInfo ti = table.Tag as TableInfo;
            if (ti.TIsFree)
            {
                MessageBox.Show("该餐桌为空闲状态，无需结账！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                FormOrderPay formOrderPay = new FormOrderPay();
                formOrderPay.Tag = table.Tag;
                formOrderPay.FormRefresh += LoadHallInfo;
                formOrderPay.ShowDialog();
            }
        }
    }
}
