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
    public partial class OrderDishDal
    {
        string connStr = SqlHelper.GetConnectionString("ItcastCater");

        public List<OrderDetailInfo> GetList(int id)
        {
            string sqlText = "select odi.*, di.DTitle as ODDishTitle, di.DPrice as ODSinglePrice from OrderDetailInfo as odi inner join DishInfo as di on odi.ODDishId = di.DId where odi.ODOrderId = @ODOrderId";
            SqlParameter para = new SqlParameter("@ODOrderId", id);
            DataTable dt = SqlHelper.ExecuteDataTable(connStr, sqlText, para);
            List<OrderDetailInfo> list = new List<OrderDetailInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new OrderDetailInfo()
                {
                    ODId = ToInt32(row["ODId"]),
                    ODOrderId = ToInt32(row["ODOrderId"]),
                    ODDishId = ToInt32(row["ODDishId"]),
                    ODCount = ToInt32(row["ODCount"]),
                    ODDishTitle = row["ODDishTitle"].ToString(),
                    ODSinglePrice = ToDecimal(row["ODSinglePrice"])
                });
            }
            return list;
        }

        public int Insert(OrderDetailInfo odi)
        {
            string sqlText = "insert into OrderDetailInfo([ODOrderId], [ODDishId], [ODCount]) values (@ODOrderId, @ODDishId, @ODCount)";
            SqlParameter[] paras =
            {
                new SqlParameter("@ODOrderId", odi.ODOrderId),
                new SqlParameter("@ODDishId", odi.ODDishId),
                new SqlParameter("@ODCount", odi.ODCount)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }

        public int Update(OrderDetailInfo odi)
        {
            string sqlText = "update OrderDetailInfo set [ODOrderId] = @ODOrderId, [ODDishId] = @ODDishId, [ODCount] = @ODCount where [ODId] = @ODId";
            SqlParameter[] paras =
            {
                new SqlParameter("@ODId", odi.ODId),
                new SqlParameter("@ODOrderId", odi.ODOrderId),
                new SqlParameter("@ODDishId", odi.ODDishId),
                new SqlParameter("@ODCount", odi.ODCount)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }

        public int Delete(OrderDetailInfo odi)
        {
            string sqlText = "delete from OrderDetailInfo where [ODOrderId] = @ODOrderId and [ODDishId] = @ODDishId";
            SqlParameter[] paras =
            {
                new SqlParameter("@ODOrderId", odi.ODOrderId),
                new SqlParameter("@ODDishId",odi.ODDishId)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }
    }
}
