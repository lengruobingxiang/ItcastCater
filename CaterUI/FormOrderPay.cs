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
    public partial class FormOrderPay : Form
    {
        public FormOrderPay()
        {
            InitializeComponent();
        }

        private TableInfo table;
        private OrderInfoBll oiBll = new OrderInfoBll();
        private MemberInfoBll miBll = new MemberInfoBll();
        private MemberTypeInfoBll mtiBll = new MemberTypeInfoBll();
        private OrderPayBll opBll = new OrderPayBll();

        private MemberInfo member = null;

        public event Action FormRefresh;

        private void FormOrderPay_Load(object sender, EventArgs e)
        {
            this.gbMember.Enabled = false;
            table = this.Tag as TableInfo;
            GetMoneyByOrderId();
        }

        private void GetMoneyByOrderId()
        {
            var oi = oiBll.GetOrder(table.TOrderId);
            lblMoney.Text = oi.OMoney.ToString();
            lblCash.Text = (oi.OMoney * oi.ODiscount).ToString("F2");
        }

        private void CbIsMember_CheckedChanged(object sender, EventArgs e)
        {
            gbMember.Enabled = cbIsMember.Checked;
            if (!cbIsMember.Checked)
            {
                member = null;
                txtMId.Clear();
                txtMPhone.Clear();
                lblMbDiscount.Text = 1.ToString("F2");
                lblMbMoney.Text = 0.ToString("F2");
                lblMbType.Text = "普通会员";
                cbUseMbMoney.Checked = false;
                lblCash.Text = lblMoney.Text;
            }
        }

        private void TxtMId_Leave(object sender, EventArgs e)
        {
            GetMemberInfo(txtMId.Text, txtMPhone.Text);
        }

        private void TxtMPhone_Leave(object sender, EventArgs e)
        {
            GetMemberInfo(txtMId.Text, txtMPhone.Text);
        }

        private void GetMemberInfo(string mbId, string mbPhone)
        {
            if (mbId == string.Empty && mbPhone == string.Empty)
            {
                lblMbDiscount.Text = 1.ToString("F2");
                lblMbMoney.Text = 0.ToString("F2");
                lblMbType.Text = "普通会员";
                cbUseMbMoney.Checked = false;
                lblCash.Text = lblMoney.Text;
                return;
            }
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (mbId != string.Empty)
            {
                dic.Add("MbId", mbId);
            }
            if (mbPhone != string.Empty)
            {
                dic.Add("MbPhone", mbPhone);
            }
            member = miBll.GetList(dic).Count == 0 ? null : miBll.GetList(dic)[0];

            if (member == null)
            {
                MessageBox.Show("会员不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMId.Clear();
                txtMPhone.Clear();
                lblMbDiscount.Text = 1.ToString("F2");
                lblMbMoney.Text = 0.ToString("F2");
                lblMbType.Text = "普通会员";
                cbUseMbMoney.Checked = false;
            }
            else
            {
                lblMbDiscount.Text = member.MbDiscount.ToString();
                lblMbMoney.Text = member.MbMoney.ToString();
                lblMbType.Text = member.MbTypeTitle;
            }
            lblCash.Text = (ToDecimal(lblMoney.Text) * ToDecimal(lblMbDiscount.Text)).ToString("F2");
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            decimal cashMoney = ToDecimal(lblCash.Text);
            
            // 勾选了使用余额
            if (cbUseMbMoney.Checked)
            {
                decimal mbMoney = ToDecimal(lblMbMoney.Text);
                // 会员余额不足
                if (mbMoney < cashMoney)
                {
                    MessageBox.Show("会员余额不足！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            OrderPayInfo opi = new OrderPayInfo()
            {
                CMember = member,
                CMoney = cashMoney,
                CTable = table,
                CUseMbMoney = cbUseMbMoney.Checked
            };

            if (opBll.Pay(opi))
            {
                this.FormRefresh();
                MessageBox.Show("付款成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("付款失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
