using CaterCommon;
using CaterModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;

namespace CaterDal
{
    public partial class ManagerInfoDal
    {
        string connStr = SqlHelper.GetConnectionString("ItcastCater");

        #region 查询获取结果集
        /// <summary>
        /// 查询获取结果集
        /// </summary>
        /// <returns></returns>
        public List<ManagerInfo> GetList()
        {
            string sqlText = "select * from [ManagerInfo] where MDelFlag = 0";
            DataTable dt = SqlHelper.ExecuteDataTable(connStr, sqlText);
            List<ManagerInfo> list = new List<ManagerInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ManagerInfo()
                {
                    MId = ToInt32(row["MId"].ToString()),
                    MName = row["MName"].ToString(),
                    MPwd = row["MPwd"].ToString(),
                    MType = ToInt32(row["MType"].ToString())
                });
            }
            return list;
        }
        #endregion

        #region 插入数据
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="mi">插入的ManagerInfo对象</param>
        /// <returns>受影响的行数</returns>
        public int Insert(ManagerInfo mi)
        {
            // 构造insert语句
            string sqlText = "insert into ManagerInfo(MName, MPwd, MType) values (@MName, @MPwd, @MType)";
            Dictionary<string, object> paraDic = new Dictionary<string, object>();
            paraDic.Add("@MName", mi.MName);
            paraDic.Add("@MPwd", mi.MPwd);
            paraDic.Add("@MType", mi.MType);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, SqlHelper.ParaDictionary2SqlParameterCollection(paraDic));
        }
        #endregion

        #region 更新数据
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="mi">更新的ManagerInfo对象</param>
        /// <returns>受影响的行数</returns>
        public int Update(ManagerInfo mi)
        {
            string temp = string.Empty;
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@MName", mi.MName);
            paras.Add("@MType", mi.MType);
            paras.Add("@MId", mi.MId);
            if (mi.MPwd != Md5Helper.EncryptString("这是原来的密码吗？"))
            {
                paras.Add("@MPwd", mi.MPwd);
                temp = " MPwd = @MPwd,";
            }
            string sqlText = "update ManagerInfo set MName = @MName," + temp + " MType = @MType where MId = @MId";
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, SqlHelper.ParaDictionary2SqlParameterCollection(paras));
        }
        #endregion

        #region 软删除数据
        /// <summary>
        /// 根据ID软删除账户
        /// </summary>
        /// <param name="mId">账户id</param>
        /// <returns>受影响的行数</returns>
        public int Delete(int mId)
        {
            string sqlText = "update ManagerInfo set MDelFlag = 1 where MId = @MId";
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, new SqlParameter("@MId", mId));
        } 
        #endregion
    }
}
