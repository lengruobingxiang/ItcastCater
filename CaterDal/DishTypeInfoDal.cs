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
    public partial class DishTypeInfoDal
    {
        string connStr = SqlHelper.GetConnectionString("ItcastCater");

        public List<DishTypeInfo> GetList()
        {
            string sqlText = "select * from DishTypeInfo where DTDelFlag = 0";
            DataTable dt = SqlHelper.ExecuteDataTable(connStr, sqlText);
            List<DishTypeInfo> list = new List<DishTypeInfo>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DishTypeInfo()
                {
                    DTId = ToInt32(row["DTId"]),
                    DTTitle = row["DTTitle"].ToString()
                });
            }
            return list;
        }

        public int Insert(DishTypeInfo mti)
        {
            string sqlText = "insert into DishTypeInfo(DTTitle) values (@DTTitle)";
            SqlParameter para = new SqlParameter("@DTTitle", mti.DTTitle);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, para);
        }

        public int Update(DishTypeInfo mti)
        {
            string sqlText = "update DishTypeInfo set DTTitle = @DTTitle where DTId = @DTId";
            SqlParameter[] paras =
            {
                new SqlParameter("@DTTitle", mti.DTTitle),
                new SqlParameter("@DTId", mti.DTId)
            };
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, paras);
        }

        public int Delete(int id)
        {
            string sqlText = "update DishTypeInfo set DTDelFlag = 1 where DTId = @DTId";
            SqlParameter para = new SqlParameter("@DTId", id);
            return SqlHelper.ExecuteNonQuery(connStr, sqlText, para);
        }
    }
}
