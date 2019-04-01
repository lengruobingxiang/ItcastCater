using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CaterDal
{
    public class SqlHelper
    {
        #region 返回连接字符串
        /// <summary>
        /// 返回连接字符串
        /// </summary>
        /// <param name="connStrName">连接字符串对应的name值</param>
        /// <returns>返回连接字符串</returns>
        public static string GetConnectionString(string connStrName)
        {
            return ConfigurationManager.ConnectionStrings[connStrName].ConnectionString;
        }
        #endregion

        #region 执行非查询语句，返回受影响的行数（通用版）
        /// <summary>
        /// 执行非查询语句，返回受影响的行数
        /// </summary>
        /// <param name="connStr">数据库连接字符串</param>
        /// <param name="sqlText">执行的SQL语句或存储过程名</param>
        /// <param name="commandType">sqlText的类型是sql脚本还是存储过程</param>
        /// <param name="parameters">查询参数集合</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string connStr, string sqlText, CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sqlText;
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region 执行非查询语句，返回受影响的行数（sql语句）
        /// <summary>
        /// 执行非查询语句，返回受影响的行数
        /// </summary>
        /// <param name="connStr">数据库连接字符串</param>
        /// <param name="sqlText">执行的SQL语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNonQuery(string connStr, string sqlText, params SqlParameter[] parameters)
        {
            return ExecuteNonQuery(connStr, sqlText, CommandType.Text, parameters);
        }
        #endregion

        #region 返回查询结果的第一行第一列的值（通用版）
        /// <summary>
        /// 返回查询结果的第一行第一列的值
        /// </summary>
        /// <param name="connStr">数据库连接字符串</param>
        /// <param name="sqlText">执行的SQL语句或存储过程名</param>
        /// <param name="commandType">sqlText的类型是sql脚本还是存储过程</param>
        /// <param name="parameters">查询参数集合</param>
        /// <returns>返回查询结果的第一行第一列的值</returns>
        public static T ExecuteScalar<T>(string connStr, string sqlText,CommandType commandType, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sqlText;
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);
                    return (T)cmd.ExecuteScalar();
                }
            }
        }
        #endregion

        #region 返回查询结果的第一行第一列的值（sql语句）
        /// <summary>
        /// 返回查询结果的第一行第一列的值
        /// </summary>
        /// <param name="connStr">数据库连接字符串</param>
        /// <param name="sqlText">执行的SQL语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>返回查询结果的第一行第一列的值</returns>
        public static T ExecuteScalar<T>(string connStr, string sqlText, params SqlParameter[] parameters)
        {
            return ExecuteScalar<T>(connStr, sqlText, CommandType.Text, parameters);
        }
        #endregion

        #region 返回包含查询结果的DataTable（通用版）
        /// <summary>
        /// 返回包含查询结果的DataTable
        /// </summary>
        /// <param name="connStr">数据库连接字符串</param>
        /// <param name="sqlText">sql脚本或存储过程名</param>
        /// <param name="commandType">sqlText的类型是sql脚本还是存储过程</param>
        /// <param name="selectParameters">查询参数集合</param>
        /// <returns>返回包含查询结果的DataTable</returns>
        public static DataTable ExecuteDataTable(string connStr, string sqlText, CommandType commandType, params SqlParameter[] selectParameters)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(sqlText, connStr))
            {
                DataTable dt = new DataTable();
                adapter.SelectCommand.Parameters.AddRange(selectParameters);
                adapter.SelectCommand.CommandType = commandType;
                adapter.Fill(dt);
                return dt;
            }
        }
        #endregion

        #region 返回包含查询结果的DataTable（sql语句）
        /// <summary>
        /// 返回包含查询结果的DataTable
        /// </summary>
        /// <param name="connStr">数据库连接字符串</param>
        /// <param name="sqlText">执行的SQL语句</param>
        /// <param name="selectParameters">查询参数集合</param>
        /// <returns>返回包含查询结果的DataTable</returns>
        public static DataTable ExecuteDataTable(string connStr, string sqlText, params SqlParameter[] selectParameters)
        {
            return ExecuteDataTable(connStr, sqlText, CommandType.Text, selectParameters);
        }
        #endregion

        #region 返回一个SqlDataReader对象，注意：用完以后必须dispose()（通用版）
        /// <summary>
        /// 返回一个SqlDataReader对象，注意：用完以后必须dispose()
        /// </summary>
        /// <param name="connStr">数据库连接字符串</param>
        /// <param name="sqlText">执行的SQL语句或存储过程名</param>
        /// <param name="commandType">sqlText的类型是sql脚本还是存储过程</param>
        /// <param name="parameters">查询参数集合</param>
        /// <returns>返回一个SqlDataReader对象，注意：用完以后必须dispose()</returns>
        public static SqlDataReader ExecuteReader(string connStr, string sqlText, CommandType commandType, params SqlParameter[] parameters)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = sqlText;
            cmd.CommandType = commandType;
            cmd.Parameters.AddRange(parameters);
            // 参数代表释放SqlDataReader的时候顺便释放SqlConnection对象
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        #endregion

        #region 返回一个SqlDataReader对象，注意：用完以后必须dispose()（sql语句）
        /// <summary>
        /// 返回一个SqlDataReader对象，注意：用完以后必须dispose()
        /// </summary>
        /// <param name="connStr">数据库连接字符串</param>
        /// <param name="sqlText">执行的SQL语句</param>
        /// <param name="parameters">参数集合</param>
        /// <returns>返回一个SqlDataReader对象，注意：用完以后必须dispose()</returns>
        public static SqlDataReader ExecuteReader(string connStr, string sqlText, params SqlParameter[] parameters)
        {
            return ExecuteReader(connStr, sqlText, CommandType.Text, parameters);
        }
        #endregion

        #region 把参数键值对集合转换成SqlParameter数组
        /// <summary>
        /// 把参数键值对集合转换成SqlParameter数组
        /// </summary>
        /// <param name="paraDictionary">参数键值对集合</param>
        /// <returns>SqlParameter数组</returns>
        public static SqlParameter[] ParaDictionary2SqlParameterCollection(Dictionary<string, object> paraDictionary)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            foreach (KeyValuePair<string, object> item in paraDictionary)
            {
                paras.Add(new SqlParameter(item.Key, item.Value));
            }
            return paras.ToArray();
        }
        #endregion
    }
}
