using CaterCommon;
using CaterDal;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaterBll
{
    public partial class ManagerInfoBll
    {
        // 创建数据层对象
        ManagerInfoDal mIDal = new ManagerInfoDal();

        // 获得数据列表
        public List<ManagerInfo> GetList()
        {
            // 调用数据访问层查询方法
            return mIDal.GetList();
        }

        // 插入数据
        public bool Add(ManagerInfo mi)
        {
            // 调用数据访问层插入方法
            return mIDal.Insert(mi) > 0;
        }

        // 更新数据
        public bool Edit(ManagerInfo mi)
        {
            return mIDal.Update(mi) > 0;
        }

        public bool Remove(int id)
        {
            return mIDal.Delete(id) > 0;
        }

        public LoginState Login(string name, string pwd, out ManagerInfo mi)
        {
            LoginState state;
            mi = mIDal.GetByName(name);
            if (mi == null)
            {
                state = LoginState.NameError;
            }
            else if (Md5Helper.EncryptString(pwd) == mi.MPwd)
            {
                state = LoginState.OK;
            }
            else
            {
                state = LoginState.PwdError;
            }
            return state;
        }
    }
}
