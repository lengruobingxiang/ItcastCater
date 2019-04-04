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
    public partial class DishInfoDal
    {
        string connStr = SqlHelper.GetConnectionString("ItcastCater");

        public List<DishInfo> GetList(Dictionary<string, string> para)
        {
            string sqlText = "select di.*, dti.DTTitle as DTypeTitle from DishInfo as di inner join DishTypeInfo as dti on di.DTypeId = dti.DTId where di.DDelFlag = 0";
            if (para.Count > 0)
            {
                foreach (var pair in para)
                {
                    sqlText += " and " + pair.Key + " like '%" + pair.Value + "%'";
                }
            }
            List<DishInfo> list = new List<DishInfo>();
            DataTable dt = SqlHelper.ExecuteDataTable(connStr, sqlText);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DishInfo()
                {
                    DId = ToInt32(row["DId"]),
                    DTitle = row["DTitle"].ToString(),
                    DPinyin = row["DPinyin"].ToString(),
                    DPrice = ToDecimal(row["DPrice"]),
                    DTypeId = ToInt32(row["DTypeId"]),
                    DTypeTitle = row["DTypeTitle"].ToString()
                });
            }
            return list;
        }

        public int Insert(DishInfo di)
        {
            string sqlText = "insert into DishInfo([DTitle], [DPinyin], [DTypeId], [DPrice]) values (@DTitle, @DPinyin, @DTypeId, @DPrice)";
            SqlParameter[] paras =
            {
                new SqlParameter("@DTitle", di.DTitle),
                new SqlParameter("@DPinyin", di.DPinyin),
                new SqlParameter("@DTypeId", di.DTypeId),
                new SqlParameter("@DPrice", di.DPrice)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }

        public int Update(DishInfo di)
        {
            string sqlText = "update DishInfo set DTitle = @DTitle, DPinyin = @DPinyin, DTypeId = @DTypeId, DPrice = @DPrice where DId = @DId";
            SqlParameter[] paras =
            {
                new SqlParameter("@DId", di.DId),
                new SqlParameter("@DTitle", di.DTitle),
                new SqlParameter("@DPinyin", di.DPinyin),
                new SqlParameter("@DTypeId", di.DTypeId),
                new SqlParameter("@DPrice", di.DPrice)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }

        public int Delete(int id)
        {
            string sqlText = "update DishInfo set DDelFlag = 1 where DId = @DId";
            SqlParameter para = new SqlParameter("@DId", id);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, para);
        }
    }
}
