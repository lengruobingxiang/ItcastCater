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
    public partial class MemberInfoDal
    {
        string connStr = SqlHelper.GetConnectionString("ItcastCater");

        public List<MemberInfo> GetList(Dictionary<string, string> dic)
        {
            string sqlText = "select mi.*, mti.MTTitle as MbTypeTitle, mti.MTDiscount as MbDiscount from MemberInfo as mi inner join MemberTypeInfo as mti on mi.MbTypeId = mti.MTId where mi.MbDelFlag = 0";
            if (dic.Count > 0)
            {
                foreach (KeyValuePair<string, string> pair in dic)
                {
                    sqlText += " and " + pair.Key + " like '%" + pair.Value + "%'";
                }
            }
            DataTable dt = SqlHelper.ExecuteDataTable(connStr, sqlText);
            List<MemberInfo> list = new List<MemberInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new MemberInfo()
                {
                    MbId = ToInt32(row["MbId"]),
                    MbTypeId = ToInt32(row["MbTypeId"]),
                    MbName = row["MbName"].ToString(),
                    MbPhone = row["MbPhone"].ToString(),
                    MbMoney = ToDecimal(row["MbMoney"]),
                    MbTypeTitle = row["MbTypeTitle"].ToString(),
                    MbDiscount = ToDecimal(row["MbDiscount"])
                });
            }
            return list;
        }

        public int Insert(MemberInfo mi)
        {
            string sqlText = "insert into MemberInfo([MbTypeId], [MbName], [MbPhone], [MbMoney]) values (@MbTypeId, @MbName, @MbPhone, @MbMoney)";
            SqlParameter[] paras =
            {
                new SqlParameter("@MbTypeId", mi.MbTypeId),
                new SqlParameter("@MbName", mi.MbName),
                new SqlParameter("@MbPhone", mi.MbPhone),
                new SqlParameter("@MbMoney", mi.MbMoney)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }

        public int Delete(int id)
        {
            string sqlText = "update MemberInfo set [MbDelFlag] = 1 where [MbId] = @MbId";
            SqlParameter para = new SqlParameter("@MbId", id);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, para);
        }

        public int Update(MemberInfo mi)
        {
            string sqlText = "update MemberInfo set [MbTypeId] = @MbTypeId, [MbName] = @MbName, [MbPhone] = @MbPhone, [MbMoney] = @MbMoney where [MbId] = @MbId";
            SqlParameter[] paras =
            {
                new SqlParameter("@MbId", mi.MbId),
                new SqlParameter("@MbTypeId", mi.MbTypeId),
                new SqlParameter("@MbName", mi.MbName),
                new SqlParameter("@MbPhone", mi.MbPhone),
                new SqlParameter("@MbMoney", mi.MbMoney)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }
    }
}
