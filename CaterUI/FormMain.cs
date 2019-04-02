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
        }

        private void MenuQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确认退出？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
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
    }
}
