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
    public partial class TableInfoDal
    {
        string connStr = SqlHelper.GetConnectionString("ItcastCater");

        public List<TableInfo> GetList(Dictionary<string, string> para)
        {
            string sqlText = "select ti.*, hi.HTitle as THallTitle, oi.OId as TOrderId from TableInfo as ti inner join HallInfo as hi on ti.THallId = hi.HId left join OrderInfo as oi on ti.TId = oi.OTableId and OIsPay = 0 where ti.TDelFlag = 0";
            if (para.Count > 0)
            {
                foreach (var pair in para)
                {
                    sqlText += " and " + pair.Key + " like '%" + pair.Value + "%'";
                }
            }
            List<TableInfo> list = new List<TableInfo>();
            DataTable dt = SqlHelper.ExecuteDataTable(connStr, sqlText);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TableInfo()
                {
                    TId = ToInt32(row["TId"]),
                    TTitle = row["TTitle"].ToString(),
                    THallId = ToInt32(row["THallId"]),
                    THallTitle = row["THallTitle"].ToString(),
                    TIsFree = ToBoolean(row["TIsFree"]),
                    TOrderId = row["TOrderId"] == Convert.DBNull ? 0 : ToInt32(row["TOrderId"])
                });
            }
            return list;
        }

        public int ChangeState(int tableId)
        {
            string SqlText = "update TableInfo set TIsFree = ~TIsFree where TId = @TId";
            SqlParameter para = new SqlParameter("@TId", tableId);
            return SqlHelper.ExecuteNonQuery(connStr, SqlText, para);
        }

        public int Insert(TableInfo ti)
        {
            string sqlText = "insert into TableInfo([TTitle], [THallId], [TIsFree]) values (@TTitle, @THallId, @TIsFree)";
            SqlParameter[] paras =
            {
                new SqlParameter("@TTitle", ti.TTitle),
                new SqlParameter("@THallId", ti.THallId),
                new SqlParameter("@TIsFree", ti.TIsFree)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }

        public int Update(TableInfo ti)
        {
            string sqlText = "update TableInfo set TTitle = @TTitle, THallId = @THallId, TIsFree = @TIsFree where TId = @TId";
            SqlParameter[] paras =
            {
                new SqlParameter("@TId", ti.TId),
                new SqlParameter("@TTitle", ti.TTitle),
                new SqlParameter("@THallId", ti.THallId),
                new SqlParameter("@TIsFree", ti.TIsFree)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }

        public int Delete(int id)
        {
            string sqlText = "update TableInfo set TDelFlag = 1 where TId = @TId";
            SqlParameter para = new SqlParameter("@TId", id);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, para);
        }
    }
}
