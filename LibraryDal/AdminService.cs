using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using LibraryModels;
using System.Data;
using System.Data.SqlClient;

namespace LibraryDal
{
    //提供管理员信息
    public class AdminService
    {
        private readonly string connString = ConfigurationManager.ConnectionStrings["Library"].ConnectionString;
        public bool CheckUserLogin(string loginId,string loginPwd)
        {
            bool flag = false;
            //sql语句
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from Admin");
            sb.AppendLine("where loginId=@loginId and loginPwd=@loginPwd");
            //变量赋值,设置参数
            SqlParameter[] paras =
            {
                new SqlParameter("@loginId",loginId),
                new SqlParameter("@loginPwd",loginPwd)
            };
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                //创建执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                //设置执行工具的参数
                cmd.Parameters.AddRange(paras);
                //打开连接
                conn.Open();
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                //判断
                if (reader.Read())
                {
                    flag = true;
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            //关闭数据库
            finally{
                conn.Close();
            }
            return flag;
        }
    }
}
