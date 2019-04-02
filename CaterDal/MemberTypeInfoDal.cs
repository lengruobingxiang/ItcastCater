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
    public partial class MemberTypeInfoDal
    {
        string connStr = SqlHelper.GetConnectionString("ItcastCater");
        public List<MemberTypeInfo> GetList()
        {
            List<MemberTypeInfo> list = new List<MemberTypeInfo>();
            string sqlText = "select * from MemberTypeInfo where MTDelFlag = 0";
            DataTable dt = SqlHelper.ExecuteDataTable(connStr, sqlText);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new MemberTypeInfo()
                {
                    MTId = ToInt32(row["MTId"]),
                    MTTitle = row["MTTitle"].ToString(),
                    MTDiscount = ToDecimal(row["MTDiscount"])
                });
            }
            return list;
        }

        public int Insert(MemberTypeInfo mti)
        {
            string sqlText = "insert into MemberTypeInfo(MTTitle, MTDiscount) values (@MTTitle, @MTDiscount)";
            Dictionary<string, object> paras = new Dictionary<string, object>();
            paras.Add("@MTTitle", mti.MTTitle);
            paras.Add("@MTDiscount", mti.MTDiscount);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, SqlHelper.ParaDictionary2SqlParameterCollection(paras));
        }

        public int Update(MemberTypeInfo mti)
        {
            string sqlText = "update MemberTypeInfo set MTTitle = @MTTitle, MTDiscount = @MTDiscount where MTId = @MTId";
            SqlParameter[] paras =
            {
                new SqlParameter("@MTTitle", mti.MTTitle),
                new SqlParameter("@MTDiscount", mti.MTDiscount),
                new SqlParameter("@MTId", mti.MTId)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }

        public int Delete(int id)
        {
            string sqlText = "update MemberTypeInfo set MTDelFlag = 1 where MTId = @MTId";
            SqlParameter para = new SqlParameter("@MTId", id);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, para);
        }
    }
}
