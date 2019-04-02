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

namespace CaterUI
{
    public partial class FormLogin : Form
    {
        Form parentForm;

        public FormLogin(Form parent)
        {
            this.parentForm = parent;
            InitializeComponent();
        }

        ManagerInfoBll mIBll = new ManagerInfoBll();

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 获取文本框信息
            string name = txtName.Text;
            string pwd = txtPwd.Text;
            LoginState state = mIBll.Login(name, pwd, out ManagerInfo mi);
            parentForm.Tag = mi;
            switch (state)
            {
                case LoginState.OK:
                    MessageBox.Show("登录成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                    parentForm.Show();
                    break;
                case LoginState.NameError:
                    MessageBox.Show("用户名不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtName.Clear();
                    this.txtPwd.Clear();
                    break;
                case LoginState.PwdError:
                    MessageBox.Show("密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtPwd.Clear();
                    break;
                default:
                    break;
            }
        }
    }
}
